﻿Imports System.IO

Namespace Data

    Public Class BinaryRom
        Inherits BinaryFile


        Public Sub New(rommgr As RomManager, romAccess As FileAccess)
            MyBase.New(rommgr.RomFile, FileMode.Open, romAccess)
            SetRomManager(rommgr)
        End Sub

        'Inherits BinaryData

        'Public ReadOnly Property RomAccess As FileAccess = FileAccess.Read

        'Public Sub New(rommgr As RomManager, romAccess As FileAccess)
        '    SetRomManager(rommgr)
        '    Me.RomAccess = romAccess
        'End Sub

        'Protected Overrides Function GetBaseStream() As Stream
        '    Return RomManager.GetStream(RomAccess)
        'End Function

    End Class

End Namespace
