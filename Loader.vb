Public NotInheritable Class Loader
    Private Sub Loader_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load





        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
