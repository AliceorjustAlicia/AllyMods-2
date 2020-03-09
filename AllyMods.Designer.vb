<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllyMods
    Inherits MetroSet_UI.Forms.MetroSetForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EList = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        Me.btnEnable = New MetroSet_UI.Controls.MetroSetButton()
        Me.StyleManager = New MetroSet_UI.StyleManager()
        Me.btnDisable = New MetroSet_UI.Controls.MetroSetButton()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EList
        '
        Me.EList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColType})
        Me.EList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.EList.HideSelection = False
        Me.EList.Location = New System.Drawing.Point(159, 7)
        Me.EList.Name = "EList"
        Me.EList.Size = New System.Drawing.Size(634, 213)
        Me.EList.TabIndex = 0
        Me.EList.TabStop = False
        Me.EList.UseCompatibleStateImageBehavior = False
        Me.EList.View = System.Windows.Forms.View.Details
        '
        'ColName
        '
        Me.ColName.Text = "Name:"
        Me.ColName.Width = 300
        '
        'ColType
        '
        Me.ColType.Text = "Type:"
        Me.ColType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColType.Width = 150
        '
        'DList
        '
        Me.DList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.DList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.DList.HideSelection = False
        Me.DList.Location = New System.Drawing.Point(159, 229)
        Me.DList.Name = "DList"
        Me.DList.Size = New System.Drawing.Size(634, 213)
        Me.DList.TabIndex = 1
        Me.DList.TabStop = False
        Me.DList.UseCompatibleStateImageBehavior = False
        Me.DList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name:"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type:"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.MediumPurple
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnRefresh.Location = New System.Drawing.Point(32, 220)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(99, 31)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Location = New System.Drawing.Point(15, 363)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(133, 36)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "ERROR"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.MediumPurple
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnDelete.Location = New System.Drawing.Point(32, 258)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 31)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Image = Global.AllyMods2.My.Resources.Resources.settings_icon
        Me.btnSettings.Location = New System.Drawing.Point(103, 391)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(47, 51)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.TabStop = False
        '
        'btnEnable
        '
        Me.btnEnable.DisabledBackColor = System.Drawing.Color.Gray
        Me.btnEnable.DisabledBorderColor = System.Drawing.Color.Gray
        Me.btnEnable.DisabledForeColor = System.Drawing.SystemColors.Menu
        Me.btnEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEnable.HoverBorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEnable.HoverColor = System.Drawing.Color.MediumSlateBlue
        Me.btnEnable.HoverTextColor = System.Drawing.Color.White
        Me.btnEnable.Location = New System.Drawing.Point(23, 101)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.NormalBorderColor = System.Drawing.Color.MediumPurple
        Me.btnEnable.NormalColor = System.Drawing.Color.MediumPurple
        Me.btnEnable.NormalTextColor = System.Drawing.Color.White
        Me.btnEnable.PressBorderColor = System.Drawing.Color.SlateBlue
        Me.btnEnable.PressColor = System.Drawing.Color.SlateBlue
        Me.btnEnable.PressTextColor = System.Drawing.Color.White
        Me.btnEnable.Size = New System.Drawing.Size(116, 39)
        Me.btnEnable.Style = MetroSet_UI.Design.Style.Custom
        Me.btnEnable.StyleManager = Me.StyleManager
        Me.btnEnable.TabIndex = 8
        Me.btnEnable.TabStop = False
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.ThemeAuthor = "Narwin"
        Me.btnEnable.ThemeName = "MetroDark"
        '
        'StyleManager
        '
        Me.StyleManager.CustomTheme = "C:\Users\Alice\AppData\Roaming\Microsoft\Windows\Templates\ThemeFile.xml"
        Me.StyleManager.MetroForm = Me
        Me.StyleManager.Style = MetroSet_UI.Design.Style.Custom
        Me.StyleManager.ThemeAuthor = "Alice"
        Me.StyleManager.ThemeName = "MetroDark"
        '
        'btnDisable
        '
        Me.btnDisable.DisabledBackColor = System.Drawing.Color.Gray
        Me.btnDisable.DisabledBorderColor = System.Drawing.Color.Gray
        Me.btnDisable.DisabledForeColor = System.Drawing.SystemColors.Menu
        Me.btnDisable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDisable.HoverBorderColor = System.Drawing.Color.MediumSlateBlue
        Me.btnDisable.HoverColor = System.Drawing.Color.MediumSlateBlue
        Me.btnDisable.HoverTextColor = System.Drawing.Color.White
        Me.btnDisable.Location = New System.Drawing.Point(23, 158)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.NormalBorderColor = System.Drawing.Color.MediumPurple
        Me.btnDisable.NormalColor = System.Drawing.Color.MediumPurple
        Me.btnDisable.NormalTextColor = System.Drawing.Color.White
        Me.btnDisable.PressBorderColor = System.Drawing.Color.SlateBlue
        Me.btnDisable.PressColor = System.Drawing.Color.SlateBlue
        Me.btnDisable.PressTextColor = System.Drawing.Color.White
        Me.btnDisable.Size = New System.Drawing.Size(116, 39)
        Me.btnDisable.Style = MetroSet_UI.Design.Style.Custom
        Me.btnDisable.StyleManager = Me.StyleManager
        Me.btnDisable.TabIndex = 9
        Me.btnDisable.TabStop = False
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.ThemeAuthor = "Narwin"
        Me.btnDisable.ThemeName = "MetroDark"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = Global.AllyMods2.My.Resources.Resources.close_icon
        Me.btnClose.Location = New System.Drawing.Point(9, 391)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 51)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 10
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = Global.AllyMods2.My.Resources.Resources.minimize_icon
        Me.btnMinimize.Location = New System.Drawing.Point(56, 391)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(47, 51)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 11
        Me.btnMinimize.TabStop = False
        '
        'AllyMods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BorderColor = System.Drawing.Color.MediumPurple
        Me.BorderThickness = 3.0!
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DList)
        Me.Controls.Add(Me.EList)
        Me.HeaderColor = System.Drawing.Color.MediumPurple
        Me.Name = "AllyMods"
        Me.Padding = New System.Windows.Forms.Padding(12, 90, 12, 12)
        Me.ShowTitle = False
        Me.SmallLineColor1 = System.Drawing.Color.MediumPurple
        Me.SmallLineColor2 = System.Drawing.Color.MediumPurple
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Style = MetroSet_UI.Design.Style.Custom
        Me.StyleManager = Me.StyleManager
        Me.Text = "ALLYMODS"
        Me.TextColor = System.Drawing.Color.White
        Me.ThemeName = "MetroDark"
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EList As ListView
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents ColType As ColumnHeader
    Friend WithEvents DList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSettings As PictureBox
    Friend WithEvents btnEnable As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents StyleManager As MetroSet_UI.StyleManager
    Friend WithEvents btnDisable As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
End Class
