<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits MetroSet_UI.Forms.MetroSetForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.mbgSwitch = New MetroSet_UI.Controls.MetroSetSwitch()
        Me.ColorWheel = New Cyotek.Windows.Forms.ColorWheel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.ColorWheel2 = New Cyotek.Windows.Forms.ColorWheel()
        Me.sbgSwitch = New MetroSet_UI.Controls.MetroSetSwitch()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.ColorWheel3 = New Cyotek.Windows.Forms.ColorWheel()
        Me.borderSwitch = New MetroSet_UI.Controls.MetroSetSwitch()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mbgSwitch
        '
        Me.mbgSwitch.BackColor = System.Drawing.Color.Transparent
        Me.mbgSwitch.BackgroundColor = System.Drawing.Color.Empty
        Me.mbgSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.mbgSwitch.CheckColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mbgSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.mbgSwitch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mbgSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.mbgSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.mbgSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.mbgSwitch.Location = New System.Drawing.Point(14, 83)
        Me.mbgSwitch.Name = "mbgSwitch"
        Me.mbgSwitch.Size = New System.Drawing.Size(58, 22)
        Me.mbgSwitch.Style = MetroSet_UI.Design.Style.Light
        Me.mbgSwitch.StyleManager = Nothing
        Me.mbgSwitch.Switched = False
        Me.mbgSwitch.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.mbgSwitch.TabIndex = 1
        Me.mbgSwitch.Text = "MetroSetSwitch1"
        Me.mbgSwitch.ThemeAuthor = "Narwin"
        Me.mbgSwitch.ThemeName = "MetroLite"
        Me.mbgSwitch.UnCheckColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        '
        'ColorWheel
        '
        Me.ColorWheel.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel.Location = New System.Drawing.Point(78, 32)
        Me.ColorWheel.Name = "ColorWheel"
        Me.ColorWheel.Size = New System.Drawing.Size(133, 122)
        Me.ColorWheel.TabIndex = 12
        Me.ColorWheel.Visible = False
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(10, 48)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(67, 29)
        Me.lbl1.TabIndex = 13
        Me.lbl1.Text = "Main color"
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(7, 190)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(67, 32)
        Me.lbl2.TabIndex = 16
        Me.lbl2.Text = "Secondary color"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorWheel2
        '
        Me.ColorWheel2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel2.Location = New System.Drawing.Point(75, 175)
        Me.ColorWheel2.Name = "ColorWheel2"
        Me.ColorWheel2.Size = New System.Drawing.Size(133, 122)
        Me.ColorWheel2.TabIndex = 15
        Me.ColorWheel2.Visible = False
        '
        'sbgSwitch
        '
        Me.sbgSwitch.BackColor = System.Drawing.Color.Transparent
        Me.sbgSwitch.BackgroundColor = System.Drawing.Color.Empty
        Me.sbgSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.sbgSwitch.CheckColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.sbgSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.sbgSwitch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbgSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.sbgSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.sbgSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.sbgSwitch.Location = New System.Drawing.Point(11, 226)
        Me.sbgSwitch.Name = "sbgSwitch"
        Me.sbgSwitch.Size = New System.Drawing.Size(58, 22)
        Me.sbgSwitch.Style = MetroSet_UI.Design.Style.Light
        Me.sbgSwitch.StyleManager = Nothing
        Me.sbgSwitch.Switched = False
        Me.sbgSwitch.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.sbgSwitch.TabIndex = 14
        Me.sbgSwitch.Text = "MetroSetSwitch1"
        Me.sbgSwitch.ThemeAuthor = "Narwin"
        Me.sbgSwitch.ThemeName = "MetroLite"
        Me.sbgSwitch.UnCheckColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AllyMods2.My.Resources.Resources.divider
        Me.PictureBox1.Location = New System.Drawing.Point(231, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 299)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.AllyMods2.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(0, 289)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 51)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 11
        Me.btnClose.TabStop = False
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(331, 48)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(67, 29)
        Me.lbl3.TabIndex = 20
        Me.lbl3.Text = "Main color"
        '
        'ColorWheel3
        '
        Me.ColorWheel3.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel3.Location = New System.Drawing.Point(399, 32)
        Me.ColorWheel3.Name = "ColorWheel3"
        Me.ColorWheel3.Size = New System.Drawing.Size(133, 122)
        Me.ColorWheel3.TabIndex = 19
        Me.ColorWheel3.Visible = False
        '
        'borderSwitch
        '
        Me.borderSwitch.BackColor = System.Drawing.Color.Transparent
        Me.borderSwitch.BackgroundColor = System.Drawing.Color.Empty
        Me.borderSwitch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.borderSwitch.CheckColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.borderSwitch.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.borderSwitch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.borderSwitch.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.borderSwitch.DisabledCheckColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.borderSwitch.DisabledUnCheckColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.borderSwitch.Location = New System.Drawing.Point(335, 83)
        Me.borderSwitch.Name = "borderSwitch"
        Me.borderSwitch.Size = New System.Drawing.Size(58, 22)
        Me.borderSwitch.Style = MetroSet_UI.Design.Style.Light
        Me.borderSwitch.StyleManager = Nothing
        Me.borderSwitch.Switched = False
        Me.borderSwitch.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.borderSwitch.TabIndex = 18
        Me.borderSwitch.Text = "hdrSwitch"
        Me.borderSwitch.ThemeAuthor = "Narwin"
        Me.borderSwitch.ThemeName = "MetroLite"
        Me.borderSwitch.UnCheckColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        '
        'Settings
        '
        Me.AllowResize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundColor = System.Drawing.Color.Empty
        Me.BorderColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(553, 336)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.ColorWheel3)
        Me.Controls.Add(Me.borderSwitch)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.ColorWheel2)
        Me.Controls.Add(Me.sbgSwitch)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.ColorWheel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.mbgSwitch)
        Me.Controls.Add(Me.PictureBox1)
        Me.HeaderColor = System.Drawing.Color.MediumPurple
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(553, 336)
        Me.MinimumSize = New System.Drawing.Size(553, 336)
        Me.Name = "Settings"
        Me.Padding = New System.Windows.Forms.Padding(2, 60, 2, 2)
        Me.ShowHeader = True
        Me.ShowLeftRect = False
        Me.SmallLineColor1 = System.Drawing.Color.MediumPurple
        Me.SmallLineColor2 = System.Drawing.Color.MediumPurple
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SETTINGS"
        Me.TextAlign = MetroSet_UI.Design.TextAlign.Center
        Me.TextColor = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mbgSwitch As MetroSet_UI.Controls.MetroSetSwitch
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents ColorWheel As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents ColorWheel2 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents sbgSwitch As MetroSet_UI.Controls.MetroSetSwitch
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents ColorWheel3 As Cyotek.Windows.Forms.ColorWheel
    Friend WithEvents borderSwitch As MetroSet_UI.Controls.MetroSetSwitch
End Class
