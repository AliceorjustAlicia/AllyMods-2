<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllyMods
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllyMods))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.EList = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.FadeManager = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.Fade = New System.Windows.Forms.Timer(Me.components)
        Me.btnEnable = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnDisable = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.SuspendLayout()
        '
        'EList
        '
        Me.EList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName, Me.ColType})
        Me.EList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.EList.HideSelection = False
        Me.EList.Location = New System.Drawing.Point(170, 0)
        Me.EList.Name = "EList"
        Me.EList.Size = New System.Drawing.Size(634, 256)
        Me.EList.TabIndex = 0
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
        Me.DList.Location = New System.Drawing.Point(170, 262)
        Me.DList.Name = "DList"
        Me.DList.Size = New System.Drawing.Size(634, 176)
        Me.DList.TabIndex = 1
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
        Me.btnRefresh.Location = New System.Drawing.Point(49, 282)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'FadeManager
        '
        Me.FadeManager.Delay = 1
        '
        'Fade
        '
        Me.Fade.Enabled = True
        Me.Fade.Interval = 2000
        '
        'btnEnable
        '
        Me.btnEnable.AllowToggling = False
        Me.btnEnable.AnimationSpeed = 200
        Me.btnEnable.AutoGenerateColors = False
        Me.btnEnable.BackColor = System.Drawing.Color.Transparent
        Me.btnEnable.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnEnable.BackgroundImage = CType(resources.GetObject("btnEnable.BackgroundImage"), System.Drawing.Image)
        Me.btnEnable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEnable.ButtonText = "Enable"
        Me.btnEnable.ButtonTextMarginLeft = 0
        Me.btnEnable.ColorContrastOnClick = 45
        Me.btnEnable.ColorContrastOnHover = 45
        Me.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnEnable.CustomizableEdges = BorderEdges1
        Me.btnEnable.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnable.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnEnable.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEnable.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEnable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnEnable.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnEnable.ForeColor = System.Drawing.Color.White
        Me.btnEnable.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnable.IconMarginLeft = 11
        Me.btnEnable.IconPadding = 10
        Me.btnEnable.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnable.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEnable.IdleBorderRadius = 3
        Me.btnEnable.IdleBorderThickness = 1
        Me.btnEnable.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnEnable.IdleIconLeftImage = Nothing
        Me.btnEnable.IdleIconRightImage = Nothing
        Me.btnEnable.IndicateFocus = False
        Me.btnEnable.Location = New System.Drawing.Point(24, 146)
        Me.btnEnable.Name = "btnEnable"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 3
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnEnable.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 3
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnEnable.OnPressedState = StateProperties2
        Me.btnEnable.Size = New System.Drawing.Size(121, 62)
        Me.btnEnable.TabIndex = 3
        Me.btnEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEnable.TextMarginLeft = 0
        Me.btnEnable.UseDefaultRadiusAndThickness = True
        '
        'btnDisable
        '
        Me.btnDisable.AllowToggling = False
        Me.btnDisable.AnimationSpeed = 200
        Me.btnDisable.AutoGenerateColors = False
        Me.btnDisable.BackColor = System.Drawing.Color.Transparent
        Me.btnDisable.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnDisable.BackgroundImage = CType(resources.GetObject("btnDisable.BackgroundImage"), System.Drawing.Image)
        Me.btnDisable.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDisable.ButtonText = "Disable"
        Me.btnDisable.ButtonTextMarginLeft = 0
        Me.btnDisable.ColorContrastOnClick = 45
        Me.btnDisable.ColorContrastOnHover = 45
        Me.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnDisable.CustomizableEdges = BorderEdges2
        Me.btnDisable.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDisable.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnDisable.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDisable.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDisable.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnDisable.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnDisable.ForeColor = System.Drawing.Color.White
        Me.btnDisable.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisable.IconMarginLeft = 11
        Me.btnDisable.IconPadding = 10
        Me.btnDisable.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisable.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDisable.IdleBorderRadius = 3
        Me.btnDisable.IdleBorderThickness = 1
        Me.btnDisable.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnDisable.IdleIconLeftImage = Nothing
        Me.btnDisable.IdleIconRightImage = Nothing
        Me.btnDisable.IndicateFocus = False
        Me.btnDisable.Location = New System.Drawing.Point(24, 214)
        Me.btnDisable.Name = "btnDisable"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 3
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnDisable.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 3
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnDisable.OnPressedState = StateProperties4
        Me.btnDisable.Size = New System.Drawing.Size(121, 62)
        Me.btnDisable.TabIndex = 2
        Me.btnDisable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDisable.TextMarginLeft = 0
        Me.btnDisable.UseDefaultRadiusAndThickness = True
        '
        'AllyMods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.DList)
        Me.Controls.Add(Me.EList)
        Me.Name = "AllyMods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AllyMods"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EList As ListView
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents ColType As ColumnHeader
    Friend WithEvents DList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnDisable As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnEnable As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnRefresh As Button
    Friend WithEvents FadeManager As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents Fade As Timer
End Class
