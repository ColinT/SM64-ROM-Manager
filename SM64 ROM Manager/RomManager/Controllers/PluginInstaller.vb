﻿Imports System.IO
Imports System.Reflection
Imports Pilz.Reflection.PluginSystem
Imports SM64_ROM_Manager.SettingsManager
Imports SM64_ROM_Manager.Publics
Imports System.IO.Compression

Public Module PluginInstaller

    Public Function GetAllPlugins() As IEnumerable(Of PluginInfo)
        Dim list As New List(Of PluginInfo)

        For Each kvp In Publics.PluginManager.Plugins
            list.Add(New PluginInfo(kvp.Value))
        Next

        Return list
    End Function

    Public Sub RemovePlugin(plugin As PluginInfo)
        Dim allPlugins As IEnumerable(Of PluginInfo) = GetAllPlugins()
        Dim pluginDir As String = Path.GetDirectoryName(plugin.Location)
        Dim asmWantToRemove As New List(Of AssemblyName) From {plugin.Plugin.Assembly.GetName}
        Dim asmToRemove As New List(Of AssemblyName)
        Dim filesToRemove As New List(Of String)
        Dim loadedAssemblies As Assembly() = AppDomain.CurrentDomain.GetAssemblies()

        'Check what should be removed
        For Each ref In plugin.Plugin.Assembly.GetReferencedAssemblies
            For Each asm As Assembly In loadedAssemblies
                If asm.FullName = ref.FullName Then
                    asmWantToRemove.Add(asm.GetName)
                End If
            Next
        Next

        'Check for references assemblies
        For Each asm As AssemblyName In asmWantToRemove.ToArray
            For Each p As PluginInfo In allPlugins
                For Each ref In p.Plugin.Assembly.GetReferencedAssemblies
                    If ref.FullName = asm.FullName Then
                        If asm.FullName = plugin.Plugin.Assembly.FullName Then
                            Throw New InvalidOperationException("This Plugin can't be removed since it is used by an other Plugin.")
                        Else
                            asmWantToRemove.Remove(asm)
                        End If
                    Else
                        asmToRemove.Add(asm)
                    End If
                Next
            Next
        Next

        'Check what assemblies are loaded and can be removed
        For Each asmName As AssemblyName In asmToRemove
            Dim asm As Assembly = loadedAssemblies.FirstOrDefault(Function(n) n.FullName = asmName.FullName)
            If asm IsNot Nothing Then
                filesToRemove.Add(asm.Location)
            End If
        Next

        'Remove files
        For Each f As String In filesToRemove
            Settings.JobsToDo.Add(New JobToDo With {.Type = JobToDoType.DeleteFile, .Urgency = JobToDoUrgency.AsSoonAsPossible, .Params = {f}})
        Next

        'Remove directory if empty
        If Directory.GetFiles(pluginDir, String.Empty, SearchOption.AllDirectories).Length = filesToRemove.Count Then
            Settings.JobsToDo.Add(New JobToDo With {.Type = JobToDoType.DeleteDirectory, .Urgency = JobToDoUrgency.AsSoonAsPossible, .Params = {pluginDir, True}})
        End If
    End Sub

    Public Sub InstallPluginFrom(filePath As String, isFolder As Boolean)
        Dim throwIsAlreadyInstalled = Sub() Throw New InvalidOperationException("This plugin (or an other version of it) is already installed!")
        Dim destPath As String = Path.Combine(MyPluginsPath, Path.GetFileName(filePath))

        If isFolder Then
            Dim dirInfo As New DirectoryInfo(destPath)

            If Not dirInfo.Exists Then
                throwIsAlreadyInstalled()
            End If

            dirInfo.CopyTo(destPath, SearchOption.AllDirectories)
        Else
            If Not File.Exists(destPath) Then
                throwIsAlreadyInstalled()
            End If

            Select Case Path.GetExtension(filePath).ToLower
                Case ".zip"
                    ZipFile.ExtractToDirectory(filePath, destPath)
                Case ".dll"
                    Dim asm As Assembly = Assembly.ReflectionOnlyLoadFrom(filePath)

                    For Each pi As PluginInfo In GetAllPlugins()
                        If pi.Plugin.Assembly.FullName = asm.FullName Then
                            throwIsAlreadyInstalled()
                        End If
                    Next

                    File.Copy(filePath, destPath)
            End Select
        End If
    End Sub

    Public Class PluginInfo

        Public ReadOnly Property Plugin As Plugin
        Public ReadOnly Property Name As String
        Public ReadOnly Property Version As Version
        Public ReadOnly Property Developer As String
        Public ReadOnly Property Location As String

        Public Sub New(p As Plugin)
            Plugin = p

            Dim asmName As AssemblyName = p.Assembly.GetName
            Name = asmName.Name
            Version = asmName.Version

            Dim fvi As FileVersionInfo = FileVersionInfo.GetVersionInfo(p.Assembly.Location)
            Developer = fvi.CompanyName

            Location = p.Assembly.Location
        End Sub

    End Class

End Module
