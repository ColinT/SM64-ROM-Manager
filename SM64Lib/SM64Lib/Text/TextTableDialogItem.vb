﻿Imports SM64Lib.Text.Profiles

Namespace Global.SM64Lib.Text

    Public Class TextTableDialogItem
        Inherits TextTableItem

        Public Property LinesPerSite As Integer = 4
        Public Property HorizontalPosition As DialogVerticalPosition = DialogVerticalPosition.Centred
        Public Property VerticalPosition As DialogHorizontalPosition = DialogHorizontalPosition.Middle
        Public Property UnknownValue As Byte = 0

        Public Sub New(bytes As Byte(), info As TextTableGroupInfo)
            MyBase.New(bytes, info)
        End Sub

    End Class

End Namespace
