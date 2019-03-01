﻿Imports System.IO

Namespace Global.SM64Lib.Data

    Public Class BinaryArrayData
        Inherits BinaryData

        Private ReadOnly myBaseStream As Stream

        Public ReadOnly Property RomAccess As FileAccess = FileAccess.Read

        Public Sub New(buffer As Byte())
            myBaseStream = New MemoryStream(buffer)
        End Sub

        Protected Overrides Function GetBaseStream() As Stream
            Return myBaseStream
        End Function

    End Class

End Namespace
