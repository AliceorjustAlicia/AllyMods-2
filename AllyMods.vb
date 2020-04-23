Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class AllyMods
    Dim CoreCheckBool As Boolean 'Used for further verification of required game files, check CoreCheck()

    Dim ActiveMods As String = SpecialDirectories.MyDocuments + "\Electronic Arts\Sims 4\Mods\"
    Dim InactiveMods As String = SpecialDirectories.MyDocuments + "\Electronic Arts\Sims 4\Inactive\"
    Dim SimsDocuments As String = SpecialDirectories.MyDocuments + "\Electronic Arts\"
    Dim AppDocuments As String = SpecialDirectories.MyDocuments + "\AllyMods-2\"

    Dim activeinfo As New IO.DirectoryInfo(ActiveMods) ' Already transfer the information of the referenced path to the defined field
    Dim inactiveinfo As New IO.DirectoryInfo(InactiveMods) ' ^

    Private Function CoreCheck()
        If Not Directory.Exists(SimsDocuments) Then
            CoreCheckBool = False 'Inconclusive check
        Else
            CoreCheckBool = True 'Conclusive     ^
        End If

    End Function
    Private Function RefreshList()
        Try
            EList.Items.Clear()
            DList.Items.Clear()

            If Not Directory.Exists(InactiveMods) Then
                Directory.CreateDirectory(InactiveMods)
                Dim inactiveinfo As New IO.DirectoryInfo(InactiveMods)
            End If

            ' Active folder code
            For Each file In activeinfo.GetFiles

                EList.Items.Add(Path.GetFileNameWithoutExtension(file.ToString), ImageList.Images.Count() - 2).SubItems.Add(file.Extension.Remove(0, 1).ToUpper)

            Next

            For Each folder In activeinfo.GetDirectories

                EList.Items.Add(folder.Name, ImageList.Images.Count() - 1).SubItems.Add("FOLDER")

            Next
            ' End active folder code

            ' Inactive folder code
            For Each file In inactiveinfo.GetFiles

                DList.Items.Add(Path.GetFileNameWithoutExtension(file.ToString), ImageList.Images.Count() - 2).SubItems.Add(file.Extension.Remove(0, 1).ToUpper)

            Next

            For Each folder In inactiveinfo.GetDirectories

                DList.Items.Add(folder.Name, ImageList.Images.Count() - 1).SubItems.Add("FOLDER")

            Next
            ' End inactive folder code

        Catch ex As Exception
            DeployCrashLog(ex.ToString)
            Process.Start(AppDocuments + "crashlogs.txt")
            Application.Exit()
        End Try


    End Function

    Private Function DeployCrashLog(r)

        If Not Directory.Exists(AppDocuments) Then
            Directory.CreateDirectory(AppDocuments)
            Dim crashlog As New IO.StreamWriter(AppDocuments + "crashlogs.txt", True)
            crashlog.WriteLine("- AllyMods 2 -", HorizontalAlignment.Center)
            crashlog.WriteLine(vbNewLine + "[" + DateAndTime.DateString + " : " + TimeString + "] " + r)
            crashlog.Close()
        Else
            Dim crashlog As New IO.StreamWriter(AppDocuments + "crashlogs.txt", True)
            crashlog.WriteLine(vbNewLine + "[" + DateAndTime.DateString + " : " + TimeString + "] " + r)
            crashlog.Close()
        End If


        Return r
    End Function
    Private Sub AllyMods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If AllyMods2.My.Settings.mbgModifier = True Then
            Me.BackColor = AllyMods2.My.Settings.MainColor
        End If

        If AllyMods2.My.Settings.headerModifier = True Then
            Me.HeaderColor = AllyMods2.My.Settings.headerColor
            Me.SmallLineColor1 = AllyMods2.My.Settings.headerColor
            Me.SmallLineColor2 = AllyMods2.My.Settings.headerColor
        End If

        If AllyMods2.My.Settings.borderModifier = True Then
            Me.BorderColor = AllyMods2.My.Settings.borderColor
        End If


        '--------- Enable drag-and-drop features
        EList.AllowDrop = True
        DList.AllowDrop = True
        '---------

        CoreCheck() 'Commence a file check

        If CoreCheckBool = True Then
            RefreshList()
            lblError.Visible = False

        Else 'Execute crashlog creation and Close()
            Dim result As DialogResult = MsgBox("Oops, something went wrong! Integrity files have not been found, crash-log has been generated at " + AppDocuments + " would you like to open it?", MsgBoxStyle.YesNo)

            DeployCrashLog("Integrity check has not been passed, error locating " + SimsDocuments + " has the game ran at least once?")

            If result = DialogResult.Yes Then
                Process.Start(AppDocuments + "crashlogs.txt")
                Close()

            ElseIf result = DialogResult.No Then
                Close()
            End If
        End If

    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        If DList.SelectedItems.Count <= 0 Then
            MsgBox("You must first select an item!", MsgBoxStyle.Information)  ' Makes sure the user selects at least one item from the list before triggering an event of file/directory movement
            Return
        End If

        For Each selectedItem As ListViewItem In DList.SelectedItems

            If selectedItem.Selected Then

                Try
                    If File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                        File.Move(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)
                        RefreshList()
                    ElseIf Directory.Exists(InactiveMods + selectedItem.Text) Then

                    Else

                        MsgBox(InactiveMods + selectedItem.Text + " is no longer present, have you moved it?")
                        RefreshList()
                        Return
                    End If

                    If Directory.Exists(InactiveMods + selectedItem.Text) Then
                        Directory.Move(InactiveMods + selectedItem.Text, ActiveMods + selectedItem.Text)
                        RefreshList()
                    ElseIf Not File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then

                    Else
                        MsgBox(InactiveMods + selectedItem.Text + " is no longer present, have you moved it?")
                        RefreshList()
                        Return
                    End If

                Catch ex As Exception 'Catch the exception and handle it with replacing functionality, if the file already exists
                    If Not File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) And Directory.Exists(InactiveMods + selectedItem.Text) Then
                        MsgBox(InactiveMods + selectedItem.Text + " is a directory And it already exists, please rename it before attempting to enable.")
                        Return
                    End If
                    Dim result As DialogResult = MessageBox.Show("The file you are trying to use already exists, would you Like to replace it?", "", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then
                        File.Replace(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, False)
                        RefreshList()
                    Else
                        Return
                    End If

                    RefreshList()
                    Return
                End Try
            End If
        Next

    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        If EList.SelectedItems.Count <= 0 Then
            MsgBox("You must first select an item!", MsgBoxStyle.Information)  ' Makes sure the user selects at least one item from the list before triggering an event of file/directory movement
            Return
        End If

        For Each selectedItem As ListViewItem In EList.SelectedItems

            If selectedItem.Selected Then
                Try

                    If File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                        File.Move(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)
                        RefreshList()
                    ElseIf Directory.Exists(ActiveMods + selectedItem.Text) Then

                    Else
                        MsgBox(InactiveMods + selectedItem.Text + "  is no longer present, have you moved it?")
                        RefreshList()
                        Return
                    End If

                    If Directory.Exists(ActiveMods + selectedItem.Text) Then
                        Directory.Move(ActiveMods + selectedItem.Text, InactiveMods + selectedItem.Text)
                        RefreshList()
                    ElseIf Not File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then

                    Else
                        MsgBox(InactiveMods + selectedItem.Text + " is no longer present, have you moved it?")
                        RefreshList()
                        Return
                    End If

                Catch ex As Exception 'Catch the exception and handle it with replacing functionality, if the file already exists
                    If Not File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) And Directory.Exists(ActiveMods + selectedItem.Text) Then
                        MsgBox(ActiveMods + selectedItem.Text + " is a directory And it already exists, please rename it before attempting to disable.")
                        Return
                    End If
                    Dim result As DialogResult = MessageBox.Show("The file you are trying to use already exists, would you Like to replace it?", "", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then

                        File.Replace(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower, False)
                        RefreshList()
                    Else
                        Return

                    End If

                    RefreshList()
                    Return
                End Try
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub

    Private Sub EList_DragDrop(sender As Object, e As DragEventArgs)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files

            If File.Exists(path) Then
                If Not File.Exists(ActiveMods + System.IO.Path.GetFileName(path)) Then
                    File.Move(path, ActiveMods + System.IO.Path.GetFileName(path))
                    RefreshList()
                Else
                    MsgBox("The file " + System.IO.Path.GetFileName(path) + " already exists on the enabled list and cannot be moved, please rename it")

                End If
            Else
                If Directory.Exists(path) And Not Directory.Exists(ActiveMods + System.IO.Path.GetFileName(path)) Then
                    Directory.Move(path, ActiveMods + System.IO.Path.GetFileName(path))
                    RefreshList()
                Else
                    MsgBox("The directory " + System.IO.Path.GetFileName(path) + " already exists on the enabled list and cannot be moved, please rename it")
                    Return
                End If

            End If
        Next
    End Sub

    Private Sub EList_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub DList_DragDrop(sender As Object, e As DragEventArgs)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files

            If File.Exists(path) Then
                If Not File.Exists(InactiveMods + System.IO.Path.GetFileName(path)) Then
                    File.Move(path, InactiveMods + System.IO.Path.GetFileName(path))
                    RefreshList()
                Else
                    MsgBox("The file " + System.IO.Path.GetFileName(path) + " already exists on the disabled list and cannot be moved, please rename it")

                End If

            Else
                If Directory.Exists(path) And Not Directory.Exists(InactiveMods + System.IO.Path.GetFileName(path)) Then
                    Directory.Move(path, InactiveMods + System.IO.Path.GetFileName(path))
                    RefreshList()
                Else
                    MsgBox("The directory " + System.IO.Path.GetFileName(path) + " already exists on the disabled list and cannot be moved, please rename it")

                End If

            End If
        Next
    End Sub

    Private Sub DList_DragEnter(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DList.SelectedItems.Count = 0 And EList.SelectedItems.Count = 0 Then
            MsgBox("You must first select an item!", MsgBoxStyle.Information)  ' Makes sure the user selects at least one item from the list before triggering an event of file/directory removal
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(EList.SelectedItems.Count + DList.SelectedItems.Count & " item(s) will be deleted and will not be able to be recovered, would you like to proceed?".ToString(), "AllyMods 2 - Confirmation is required", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            For Each selectedItem As ListViewItem In DList.SelectedItems

                If selectedItem.Selected Then

                    Try

                        If File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                            File.Delete(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)
                            RefreshList()
                        ElseIf Directory.Exists(InactiveMods + selectedItem.Text) Then

                        Else

                            MsgBox(InactiveMods + selectedItem.Text + "  is no longer present, have you moved it?")
                            RefreshList()
                            Return
                        End If

                        If Directory.Exists(InactiveMods + selectedItem.Text) Then
                            Directory.Delete(InactiveMods + selectedItem.Text)
                            RefreshList()
                        ElseIf Not File.Exists(InactiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then

                        Else
                            MsgBox(InactiveMods + selectedItem.Text + "  is no longer present, have you moved it?")
                            RefreshList()
                            Return
                        End If

                    Catch ex As Exception
                        MsgBox(ex)


                        RefreshList()
                        Return
                    End Try
                End If
            Next

            For Each selectedItem As ListViewItem In EList.SelectedItems

                If selectedItem.Selected Then

                    Try

                        If File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then
                            File.Delete(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower)
                            RefreshList()
                        ElseIf Directory.Exists(ActiveMods + selectedItem.Text) Then

                        Else

                            MsgBox(ActiveMods + selectedItem.Text + "  is no longer present, have you moved it?")
                            RefreshList()
                            Return
                        End If

                        If Directory.Exists(ActiveMods + selectedItem.Text) Then
                            Directory.Delete(ActiveMods + selectedItem.Text)
                            RefreshList()
                        ElseIf Not File.Exists(ActiveMods + selectedItem.Text + "." + selectedItem.SubItems.Item(1).Text.ToLower) Then

                        Else
                            MsgBox(ActiveMods + selectedItem.Text + "  is no longer present, have you moved it?")
                            RefreshList()
                            Return
                        End If

                    Catch ex As Exception
                        MsgBox(ex)


                        RefreshList()
                        Return
                    End Try
                End If
            Next

        Else
            Return
        End If

    End Sub

    ' Makes sure To deselect any items that are selected On the contrary form When the enter focus Event Is activated On one Of them (Avoiding confusion Of simultaneous selection)
    ' -------------------------------------------------------------------------------------------
    Private Sub EList_Enter(sender As Object, e As EventArgs) Handles EList.Enter
        For Each selecteditem As ListViewItem In DList.SelectedItems
            selecteditem.Selected = 0
        Next
    End Sub

    Private Sub DList_Enter(sender As Object, e As EventArgs) Handles DList.Enter
        For Each selecteditem As ListViewItem In EList.SelectedItems
            selecteditem.Selected = 0
        Next
    End Sub
    ' -------------------------------------------------------------------------------------------

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Settings.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class