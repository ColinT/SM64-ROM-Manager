Imports nUpdate.Updating

Public Class UpdateDialog

    Private mgr As UpdateManager = Nothing

    Public Sub New(mgr As UpdateManager)

        ' Dieser Aufruf ist f�r den Designer erforderlich.
        InitializeComponent()

        ' F�gen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.mgr = mgr
    End Sub

    Private Sub UpdateDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        '...
    End Sub
End Class