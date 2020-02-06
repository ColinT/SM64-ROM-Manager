﻿Imports System.IO
Imports SM64_ROM_Manager.Updating.UpdateInstaller

Namespace Global.UpdateInstaller

    Public Module AddOn

        Public Sub Main(config As UpdateInstallerConfig)

            If config.NewApplicationVersion IsNot Nothing AndAlso config.CurrentApplicationVersion IsNot Nothing Then
                Dim v1600 As New Version("1.6.0.0")

                'Delete Tweaks
                If config.NewApplicationVersion.Version >= v1600 Then
                    Dim dir As New DirectoryInfo(Path.Combine(config.HostApplicationPath, "Data\Tweaks"))
                    If dir.Exists Then
                        dir.Delete(True)
                    End If
                End If
            End If
        End Sub

    End Module

End Namespace
