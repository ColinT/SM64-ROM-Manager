﻿Imports System.IO
Imports SM64Lib.SegmentedBanking

Namespace Data

    Public Class BinarySegBank
        Inherits BinaryData

        Public ReadOnly Property SegBank As SegmentedBank

        Public Sub New(segBank As SegmentedBank, rommgr As RomManager)
            Me.SegBank = segBank
            SetRomManager(rommgr)
        End Sub

        Public Sub New(segBank As SegmentedBank)
            Me.SegBank = segBank
        End Sub

        Protected Overrides Function GetBaseStream() As Stream
            If RomManager IsNot Nothing Then
                Dim s As BinaryRom = RomManager.GetBinaryRom(FileAccess.Read)
                SegBank.ReadDataIfNull(s.BaseStream)
                s.Close()
            End If
            Return SegBank.Data
        End Function

    End Class

End Namespace
