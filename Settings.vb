Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.mbgModifier = True Then
            mbgSwitch.Switched = True
            ColorWheel.Visible = True
            ColorWheel.Color = My.Settings.MainColor
        End If

        If My.Settings.headerModifier = True Then
            sbgSwitch.Switched = True
            ColorWheel2.Visible = True
            ColorWheel2.Color = My.Settings.headerColor
        End If

        If My.Settings.borderModifier = True Then
            borderSwitch.Switched = True
            ColorWheel3.Visible = True
            ColorWheel3.Color = My.Settings.borderColor
        End If
    End Sub

    Private Sub ColorWheel1_ColorChanged_1(sender As Object, e As EventArgs) Handles ColorWheel.ColorChanged
        Me.BackColor = ColorWheel.Color
        My.Settings.MainColor = ColorWheel.Color
        Me.BackColor = My.Settings.MainColor
        AllyMods.BackColor = My.Settings.MainColor
        AllyMods.Refresh()
        Me.Refresh()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Switch1_MouseClick(sender As Object, e As MouseEventArgs) Handles mbgSwitch.MouseClick
        If mbgSwitch.Switched = True Then
            My.Settings.mbgModifier = True
            My.Settings.Save()
            ColorWheel.Visible = True
        Else
            My.Settings.mbgModifier = False
            Me.BackColor = My.Settings.DefColor
            AllyMods.BackColor = My.Settings.DefColor
            ColorWheel.Visible = False
            My.Settings.Save()
        End If

    End Sub

    Private Sub ColorWheel2_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel2.ColorChanged
        Me.HeaderColor = ColorWheel2.Color

        My.Settings.headerColor = ColorWheel2.Color
        AllyMods.HeaderColor = My.Settings.headerColor
        AllyMods.Refresh()
        Me.Refresh()
    End Sub

    Private Sub sbgSwitch_MouseClick(sender As Object, e As MouseEventArgs) Handles sbgSwitch.MouseClick
        If sbgSwitch.Switched = True Then
            My.Settings.headerModifier = True
            My.Settings.Save()
            ColorWheel2.Visible = True
            Me.Refresh()
            AllyMods.Refresh()
        Else
            My.Settings.headerModifier = False
            Me.HeaderColor = Color.MediumPurple
            AllyMods.HeaderColor = Color.MediumPurple
            ColorWheel2.Visible = False
            My.Settings.Save()
            Me.Refresh()
            AllyMods.Refresh()
        End If
    End Sub

    Private Sub MetroSetSwitch1_MouseClick(sender As Object, e As MouseEventArgs) Handles borderSwitch.MouseClick
        If borderSwitch.Switched = True Then
            My.Settings.borderModifier = True
            My.Settings.Save()
            ColorWheel3.Visible = True
            Me.Refresh()
            AllyMods.Refresh()
        Else
            My.Settings.borderModifier = False
            Me.BorderColor = Color.MediumPurple
            AllyMods.BorderColor = Color.MediumPurple
            ColorWheel3.Visible = False
            My.Settings.Save()
            Me.Refresh()
            AllyMods.Refresh()
        End If
    End Sub

    Private Sub ColorWheel3_ColorChanged(sender As Object, e As EventArgs) Handles ColorWheel3.ColorChanged
        Me.BorderColor = ColorWheel3.Color
        My.Settings.borderColor = ColorWheel3.Color
        AllyMods.BorderColor = My.Settings.borderColor
        AllyMods.Refresh()
        Me.Refresh()
    End Sub
End Class