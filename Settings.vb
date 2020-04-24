Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.mbgModifier = True Then
            mbgSwitch.Switched = True
            ColorWheel.Visible = True
            HexEditor1.Visible = True
            ColorWheel.Color = My.Settings.MainColor
            Me.BackColor = ColorWheel.Color
            Me.Refresh()
        End If

        If My.Settings.headerModifier = True Then
            sbgSwitch.Switched = True
            ColorWheel2.Visible = True
            ColorWheel2.Color = My.Settings.headerColor
            HexEditor2.Visible = True
        End If

        If My.Settings.borderModifier = True Then
            borderSwitch.Switched = True
            ColorWheel3.Visible = True
            ColorWheel3.Color = My.Settings.borderColor
            HexEditor3.Visible = True
        End If

        If My.Settings.fontModifier = True Then
            fontSwitch.Switched = True
            ColorWheel4.Visible = True
            ColorWheel4.Color = My.Settings.fontColor
            HexEditor4.Visible = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub MainSwitch_MouseClick(sender As Object, e As MouseEventArgs) Handles mbgSwitch.MouseClick
        If mbgSwitch.Switched = True Then
            My.Settings.mbgModifier = True
            My.Settings.Save()
            Me.BackColor = My.Settings.MainColor
            AllyMods.BackColor = My.Settings.MainColor
            ColorWheel.Visible = True
            HexEditor1.Visible = True
        Else
            My.Settings.mbgModifier = False
            HexEditor1.Visible = False
            Me.BackColor = My.Settings.DefColor
            AllyMods.BackColor = My.Settings.DefColor
            ColorWheel.Visible = False
            My.Settings.Save()
        End If

    End Sub

    Private Sub ColorWheel1_ColorChanged_1(sender As Object, e As EventArgs) Handles ColorWheel.ColorChanged
        Me.BackColor = ColorWheel.Color
        My.Settings.MainColor = ColorWheel.Color
        Me.BackColor = My.Settings.MainColor
        HexEditor1.Text = ColorTranslator.ToHtml(ColorWheel.Color)
        AllyMods.BackColor = My.Settings.MainColor
        AllyMods.Refresh()
        Me.Refresh()
    End Sub

    Private Sub ColorWheel2_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel2.ColorChanged
        Me.HeaderColor = ColorWheel2.Color
        AllyMods.HeaderColor = ColorWheel2.Color

        AllyMods.Refresh()

        HexEditor2.Text = ColorTranslator.ToHtml(ColorWheel2.Color)

        My.Settings.headerColor = ColorWheel2.Color
        AllyMods.HeaderColor = My.Settings.headerColor
        AllyMods.SmallLineColor1 = My.Settings.headerColor
        AllyMods.SmallLineColor2 = My.Settings.headerColor

        Me.Refresh()
    End Sub
    Private Sub ColorWheel3_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel3.ColorChanged
        Me.BorderColor = ColorWheel3.Color
        My.Settings.borderColor = ColorWheel3.Color
        HexEditor3.Text = ColorTranslator.ToHtml(ColorWheel3.Color)
        AllyMods.BorderColor = My.Settings.borderColor
        AllyMods.Refresh()
        Me.Refresh()
    End Sub
    Private Sub ColorWheel4_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel4.ColorChanged
        My.Settings.fontColor = ColorWheel4.Color
        HexEditor4.Text = ColorTranslator.ToHtml(ColorWheel4.Color)
        AllyMods.ForeColor = My.Settings.fontColor
        lbl1.ForeColor = My.Settings.fontColor
        lbl2.ForeColor = My.Settings.fontColor
        lbl3.ForeColor = My.Settings.fontColor
        lbl4.ForeColor = My.Settings.fontColor
        AllyMods.Refresh()
        Me.Refresh()


    End Sub

    Private Sub HeaderSwitch_MouseClick(sender As Object, e As MouseEventArgs) Handles sbgSwitch.MouseClick
        If sbgSwitch.Switched = True Then
            My.Settings.headerModifier = True
            My.Settings.Save()
            Me.HeaderColor = My.Settings.headerColor
            AllyMods.HeaderColor = My.Settings.headerColor
            ColorWheel2.Visible = True
            HexEditor2.Visible = True
            Me.Refresh()
            AllyMods.Refresh()
        Else
            My.Settings.headerModifier = False
            Me.HeaderColor = Color.MediumPurple
            AllyMods.HeaderColor = Color.MediumPurple
            ColorWheel2.Visible = False
            AllyMods.SmallLineColor1 = Color.MediumPurple
            AllyMods.SmallLineColor2 = Color.MediumPurple
            HexEditor2.Visible = False
            My.Settings.Save()
            Me.Refresh()
            AllyMods.Refresh()
        End If
    End Sub

    Private Sub BorderSwitch_MouseClick(sender As Object, e As MouseEventArgs) Handles borderSwitch.MouseClick
        If borderSwitch.Switched = True Then
            My.Settings.borderModifier = True
            My.Settings.Save()
            ColorWheel3.Visible = True
            HexEditor3.Visible = True
            Me.BorderColor = My.Settings.borderColor
            AllyMods.BorderColor = My.Settings.borderColor
            Me.Refresh()
            AllyMods.Refresh()
        Else
            My.Settings.borderModifier = False
            HexEditor3.Visible = False
            Me.BorderColor = Color.MediumPurple
            AllyMods.BorderColor = Color.MediumPurple
            ColorWheel3.Visible = False
            My.Settings.Save()
            Me.Refresh()
            AllyMods.Refresh()


        End If
    End Sub

    Private Sub fontSwitch_MouseClick(sender As Object, e As MouseEventArgs) Handles fontSwitch.MouseClick
        If fontSwitch.Switched = True Then
            My.Settings.fontModifier = True
            My.Settings.Save()
            ColorWheel4.Visible = True
            HexEditor4.Visible = True
            Me.ForeColor = My.Settings.borderColor
            AllyMods.ForeColor = My.Settings.borderColor
            Me.Refresh()
            AllyMods.Refresh()

            lbl1.ForeColor = ColorWheel4.Color
            lbl2.ForeColor = ColorWheel4.Color
            lbl3.ForeColor = ColorWheel4.Color
            lbl4.ForeColor = ColorWheel4.Color
        Else
            My.Settings.fontModifier = False
            HexEditor4.Visible = False
            Me.ForeColor = Color.Gray
            AllyMods.ForeColor = Color.Gray
            ColorWheel4.Visible = False
            My.Settings.Save()
            Me.Refresh()
            AllyMods.Refresh()

            lbl1.ForeColor = Color.Gray
            lbl2.ForeColor = Color.Gray
            lbl3.ForeColor = Color.Gray
            lbl4.ForeColor = Color.Gray

        End If

    End Sub

    Private Sub HexEditor1_TextChanged(sender As Object) Handles HexEditor1.TextChanged
        Try
            ColorWheel.Color = ColorTranslator.FromHtml(HexEditor1.Text)
            My.Settings.MainColor = ColorWheel.Color
            My.Settings.Save()

        Catch ex As Exception
            If Not HexEditor1.Text.Contains("#") Then
                HexEditor1.Text = "#" + HexEditor1.Text
            End If
        End Try

    End Sub

    Private Sub HexEditor2_TextChanged(sender As Object) Handles HexEditor2.TextChanged
        Try
            ColorWheel2.Color = ColorTranslator.FromHtml(HexEditor2.Text)
            My.Settings.headerColor = ColorWheel2.Color
            My.Settings.Save()
        Catch ex As Exception
            If Not HexEditor2.Text.Contains("#") Then
                HexEditor2.Text = "#" + HexEditor2.Text
            End If
        End Try
    End Sub

    Private Sub HexEditor3_TextChanged(sender As Object) Handles HexEditor3.TextChanged
        Try
            ColorWheel3.Color = ColorTranslator.FromHtml(HexEditor3.Text)
            My.Settings.borderColor = ColorWheel3.Color
            My.Settings.Save()
        Catch ex As Exception
            If Not HexEditor3.Text.Contains("#") Then
                HexEditor3.Text = "#" + HexEditor3.Text
            End If
        End Try
    End Sub

    Private Sub HexEditor4_TextChanged(sender As Object) Handles HexEditor4.TextChanged
        Try
            ColorWheel4.Color = ColorTranslator.FromHtml(HexEditor4.Text)
            My.Settings.fontColor = ColorWheel4.Color
            My.Settings.Save()
        Catch ex As Exception
            If Not HexEditor4.Text.Contains("#") Then
                HexEditor4.Text = "#" + HexEditor4.Text
            End If
        End Try
    End Sub
End Class