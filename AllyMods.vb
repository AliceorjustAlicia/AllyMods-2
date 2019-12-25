Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class AllyMods
    Dim ActiveMods As String = SpecialDirectories.MyDocuments + "\Electronic Arts\Sims 4\Mods\"
    Dim InactiveMods As String = SpecialDirectories.MyDocuments + "\Electronic Arts\Sims 4\Inactive\"
    Dim SimsDocuments As String = SpecialDirectories.MyDocuments + "\Electronic Arts\Sims 4"

    Dim activeinfo As New IO.DirectoryInfo(ActiveMods) ' Already transfer the information of the referenced path to the defined field
    Dim inactiveinfo As New IO.DirectoryInfo(InactiveMods) ' ^

    Private Function RefreshList()
        EList.Items.Clear()
        DList.Items.Clear()

        If Not Directory.Exists(InactiveMods) Then
            Directory.CreateDirectory(InactiveMods)
            Dim inactiveinfo As New IO.DirectoryInfo(InactiveMods)
        End If

        ' Active folder code
        For Each file In activeinfo.GetFiles

            EList.Items.Add(Path.GetFileNameWithoutExtension(file.ToString)).SubItems.Add(file.Extension.Remove(0, 1).ToUpper)

        Next

        For Each folder In activeinfo.GetDirectories

            EList.Items.Add(folder.Name).SubItems.Add("FOLDER")

        Next
        ' End active folder code

        ' Inactive folder code
        For Each file In inactiveinfo.GetFiles

            DList.Items.Add(Path.GetFileNameWithoutExtension(file.ToString)).SubItems.Add(file.Extension.Remove(0, 1).ToUpper)

        Next

        For Each folder In inactiveinfo.GetDirectories

            DList.Items.Add(folder.Name).SubItems.Add("FOLDER")

        Next
        ' End inactive folder code
        Return 0
    End Function
    Private Sub AllyMods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------- Allows the fade transition to be produced smoothly and with no problems by re-appearing the form without opacity (BunifuUI problem)

        Me.Visible = False
        Me.Opacity = 0
        Me.Visible = True
        '---------
        RefreshList()

    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click

        If DList.SelectedItems.Count <= 0 Then
            MsgBox("Select an item first")  ' Makes sure the user selects at least one item from the list before triggering an event of file/directory movement
            Return
        End If

        For Each selectedItem As ListViewItem In DList.SelectedItems
            MsgBox(System.IO.Directory.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower))

            If selectedItem.Selected Then
                ' MsgBox(ActiveMods + currentItem.Text + "." + currentItem.SubItems.Item(1).Text.ToLower) 'debug
                If File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                    File.Move(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)

                    RefreshList()


                ElseIf Directory.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                    Directory.Move(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)

                    RefreshList()

                End If

            End If
        Next

    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        If EList.SelectedItems.Count <= 0 Then
            MsgBox("Select an item first")  ' Makes sure the user selects at least one item from the list before triggering an event of file/directory movement
            Return
        End If

        For Each selectedItem As ListViewItem In EList.SelectedItems

            If selectedItem.Selected Then
                ' MsgBox(ActiveMods + currentItem.Text + "." + currentItem.SubItems.Item(1).Text.ToLower) 'debug



                If File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                    File.Move(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)

                    RefreshList()


                ElseIf Directory.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                    Directory.Move(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)

                    RefreshList()

                End If

            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub

    Private Sub Fade_Tick(sender As Object, e As EventArgs) Handles Fade.Tick
        FadeManager.ShowAsyc(Me)
        Fade.Enabled = False
    End Sub
End Class