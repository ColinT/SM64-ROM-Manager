Imports System.Windows.Forms

Public Class TweakProfileEditor

    Public Sub New()

        ' Dieser Aufruf ist f�r den Designer erforderlich.
        InitializeComponent()

        ' F�gen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        UpdateAmbientColors
    End Sub

    Public Property Titel As String
        Get
            Return TextBoxX1.Text
        End Get
        Set(value As String)
            TextBoxX1.Text = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return TextBoxX2.Text
        End Get
        Set(value As String)
            TextBoxX2.Text = value
        End Set
    End Property

End Class