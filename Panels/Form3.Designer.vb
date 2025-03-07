<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.panelIndicator3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.panelIndicator2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.panelIndicator1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.logOutBtn = New Guna.UI.WinForms.GunaButton()
        Me.PanelBtn3 = New Guna.UI.WinForms.GunaButton()
        Me.PanelBtn2 = New Guna.UI.WinForms.GunaButton()
        Me.PanelBtn1 = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panelBtn = New Guna.UI.WinForms.GunaButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.lblClock1 = New Guna.UI.WinForms.GunaLabel()
        Me.startBtn = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.contentPane = New Guna.UI.WinForms.GunaPanel()
        Me.startUpBtn = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.minimize = New Guna.UI.WinForms.GunaPanel()
        Me.min = New Guna.UI.WinForms.GunaPanel()
        Me.lblClock = New Guna.UI.WinForms.GunaLabel()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.panelIndicator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelIndicator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelIndicator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentPane.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.minimize.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1200, 420)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.White
        Me.PanelMenu.Controls.Add(Me.panelIndicator3)
        Me.PanelMenu.Controls.Add(Me.panelIndicator2)
        Me.PanelMenu.Controls.Add(Me.panelIndicator1)
        Me.PanelMenu.Controls.Add(Me.logOutBtn)
        Me.PanelMenu.Controls.Add(Me.PanelBtn3)
        Me.PanelMenu.Controls.Add(Me.PanelBtn2)
        Me.PanelMenu.Controls.Add(Me.PanelBtn1)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.White
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(85, 720)
        Me.PanelMenu.TabIndex = 2
        '
        'panelIndicator3
        '
        Me.panelIndicator3.BackColor = System.Drawing.Color.Silver
        Me.panelIndicator3.BaseColor = System.Drawing.Color.DimGray
        Me.panelIndicator3.Location = New System.Drawing.Point(-114, 249)
        Me.panelIndicator3.Name = "panelIndicator3"
        Me.panelIndicator3.Size = New System.Drawing.Size(120, 60)
        Me.panelIndicator3.TabIndex = 7
        Me.panelIndicator3.TabStop = False
        '
        'panelIndicator2
        '
        Me.panelIndicator2.BackColor = System.Drawing.Color.Silver
        Me.panelIndicator2.BaseColor = System.Drawing.Color.DimGray
        Me.panelIndicator2.Location = New System.Drawing.Point(-114, 171)
        Me.panelIndicator2.Name = "panelIndicator2"
        Me.panelIndicator2.Size = New System.Drawing.Size(120, 60)
        Me.panelIndicator2.TabIndex = 6
        Me.panelIndicator2.TabStop = False
        '
        'panelIndicator1
        '
        Me.panelIndicator1.BackColor = System.Drawing.Color.Silver
        Me.panelIndicator1.BaseColor = System.Drawing.Color.DimGray
        Me.panelIndicator1.Location = New System.Drawing.Point(-114, 86)
        Me.panelIndicator1.Name = "panelIndicator1"
        Me.panelIndicator1.Size = New System.Drawing.Size(120, 60)
        Me.panelIndicator1.TabIndex = 5
        Me.panelIndicator1.TabStop = False
        '
        'logOutBtn
        '
        Me.logOutBtn.AnimationHoverSpeed = 0.07!
        Me.logOutBtn.AnimationSpeed = 0.03!
        Me.logOutBtn.BackColor = System.Drawing.Color.Transparent
        Me.logOutBtn.BaseColor = System.Drawing.Color.Transparent
        Me.logOutBtn.BorderColor = System.Drawing.Color.Transparent
        Me.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logOutBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.logOutBtn.FocusedColor = System.Drawing.Color.Empty
        Me.logOutBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutBtn.ForeColor = System.Drawing.Color.Black
        Me.logOutBtn.Image = CType(resources.GetObject("logOutBtn.Image"), System.Drawing.Image)
        Me.logOutBtn.ImageOffsetX = 14
        Me.logOutBtn.ImageSize = New System.Drawing.Size(40, 40)
        Me.logOutBtn.Location = New System.Drawing.Point(0, 633)
        Me.logOutBtn.Name = "logOutBtn"
        Me.logOutBtn.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.logOutBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.logOutBtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.logOutBtn.OnHoverImage = Nothing
        Me.logOutBtn.OnPressedColor = System.Drawing.Color.Black
        Me.logOutBtn.Size = New System.Drawing.Size(220, 85)
        Me.logOutBtn.TabIndex = 4
        Me.logOutBtn.Text = "Log Out"
        Me.logOutBtn.TextOffsetX = 15
        '
        'PanelBtn3
        '
        Me.PanelBtn3.AnimationHoverSpeed = 0.07!
        Me.PanelBtn3.AnimationSpeed = 0.03!
        Me.PanelBtn3.BackColor = System.Drawing.Color.Violet
        Me.PanelBtn3.BaseColor = System.Drawing.Color.White
        Me.PanelBtn3.BorderColor = System.Drawing.Color.Transparent
        Me.PanelBtn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelBtn3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PanelBtn3.FocusedColor = System.Drawing.Color.Empty
        Me.PanelBtn3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBtn3.ForeColor = System.Drawing.Color.Black
        Me.PanelBtn3.Image = CType(resources.GetObject("PanelBtn3.Image"), System.Drawing.Image)
        Me.PanelBtn3.ImageOffsetX = 12
        Me.PanelBtn3.ImageSize = New System.Drawing.Size(45, 45)
        Me.PanelBtn3.Location = New System.Drawing.Point(0, 247)
        Me.PanelBtn3.Name = "PanelBtn3"
        Me.PanelBtn3.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.PanelBtn3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PanelBtn3.OnHoverForeColor = System.Drawing.Color.Black
        Me.PanelBtn3.OnHoverImage = Nothing
        Me.PanelBtn3.OnPressedColor = System.Drawing.Color.Black
        Me.PanelBtn3.Size = New System.Drawing.Size(220, 65)
        Me.PanelBtn3.TabIndex = 3
        Me.PanelBtn3.Text = "Account"
        Me.PanelBtn3.TextOffsetX = 15
        '
        'PanelBtn2
        '
        Me.PanelBtn2.AnimationHoverSpeed = 0.07!
        Me.PanelBtn2.AnimationSpeed = 0.03!
        Me.PanelBtn2.BaseColor = System.Drawing.Color.White
        Me.PanelBtn2.BorderColor = System.Drawing.Color.Transparent
        Me.PanelBtn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelBtn2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PanelBtn2.FocusedColor = System.Drawing.Color.Empty
        Me.PanelBtn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBtn2.ForeColor = System.Drawing.Color.Black
        Me.PanelBtn2.Image = CType(resources.GetObject("PanelBtn2.Image"), System.Drawing.Image)
        Me.PanelBtn2.ImageOffsetX = 10
        Me.PanelBtn2.ImageSize = New System.Drawing.Size(48, 51)
        Me.PanelBtn2.Location = New System.Drawing.Point(2, 169)
        Me.PanelBtn2.Name = "PanelBtn2"
        Me.PanelBtn2.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.PanelBtn2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PanelBtn2.OnHoverForeColor = System.Drawing.Color.Black
        Me.PanelBtn2.OnHoverImage = Nothing
        Me.PanelBtn2.OnPressedColor = System.Drawing.Color.Black
        Me.PanelBtn2.Size = New System.Drawing.Size(220, 65)
        Me.PanelBtn2.TabIndex = 2
        Me.PanelBtn2.Text = "Financial Flow"
        Me.PanelBtn2.TextOffsetX = 15
        '
        'PanelBtn1
        '
        Me.PanelBtn1.AnimationHoverSpeed = 0.07!
        Me.PanelBtn1.AnimationSpeed = 0.03!
        Me.PanelBtn1.BaseColor = System.Drawing.Color.White
        Me.PanelBtn1.BorderColor = System.Drawing.Color.Transparent
        Me.PanelBtn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelBtn1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PanelBtn1.FocusedColor = System.Drawing.Color.Empty
        Me.PanelBtn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBtn1.ForeColor = System.Drawing.Color.Black
        Me.PanelBtn1.Image = CType(resources.GetObject("PanelBtn1.Image"), System.Drawing.Image)
        Me.PanelBtn1.ImageOffsetX = 10
        Me.PanelBtn1.ImageSize = New System.Drawing.Size(50, 50)
        Me.PanelBtn1.Location = New System.Drawing.Point(0, 84)
        Me.PanelBtn1.Name = "PanelBtn1"
        Me.PanelBtn1.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.PanelBtn1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.PanelBtn1.OnHoverForeColor = System.Drawing.Color.Black
        Me.PanelBtn1.OnHoverImage = Nothing
        Me.PanelBtn1.OnPressedColor = System.Drawing.Color.Black
        Me.PanelBtn1.Size = New System.Drawing.Size(220, 65)
        Me.PanelBtn1.TabIndex = 1
        Me.PanelBtn1.Text = "Project Creation"
        Me.PanelBtn1.TextOffsetX = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.panelBtn)
        Me.Panel4.Controls.Add(Me.PanelContainer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(85, 65)
        Me.Panel4.TabIndex = 0
        '
        'panelBtn
        '
        Me.panelBtn.AnimationHoverSpeed = 0.07!
        Me.panelBtn.AnimationSpeed = 0.03!
        Me.panelBtn.BackColor = System.Drawing.Color.Transparent
        Me.panelBtn.BaseColor = System.Drawing.Color.Black
        Me.panelBtn.BorderColor = System.Drawing.Color.Transparent
        Me.panelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.panelBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelBtn.FocusedColor = System.Drawing.Color.Empty
        Me.panelBtn.Font = New System.Drawing.Font("Trocchi", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelBtn.ForeColor = System.Drawing.Color.White
        Me.panelBtn.Image = Nothing
        Me.panelBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.panelBtn.Location = New System.Drawing.Point(0, 0)
        Me.panelBtn.Name = "panelBtn"
        Me.panelBtn.OnHoverBaseColor = System.Drawing.Color.White
        Me.panelBtn.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.panelBtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.panelBtn.OnHoverImage = Nothing
        Me.panelBtn.OnPressedColor = System.Drawing.Color.Gray
        Me.panelBtn.OnPressedDepth = 0
        Me.panelBtn.Size = New System.Drawing.Size(85, 65)
        Me.panelBtn.TabIndex = 0
        Me.panelBtn.Text = "AT"
        Me.panelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.panelBtn.UseTransfarantBackground = True
        '
        'PanelContainer
        '
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.Controls.Add(Me.lblClock1)
        Me.PanelContainer.Controls.Add(Me.startBtn)
        Me.PanelContainer.Controls.Add(Me.GunaPictureBox1)
        Me.PanelContainer.ForeColor = System.Drawing.Color.Black
        Me.PanelContainer.Location = New System.Drawing.Point(0, 68)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1230, 608)
        Me.PanelContainer.TabIndex = 3
        '
        'lblClock1
        '
        Me.lblClock1.AutoSize = True
        Me.lblClock1.Font = New System.Drawing.Font("Trocchi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock1.ForeColor = System.Drawing.Color.Snow
        Me.lblClock1.Location = New System.Drawing.Point(1047, 128)
        Me.lblClock1.Name = "lblClock1"
        Me.lblClock1.Size = New System.Drawing.Size(117, 31)
        Me.lblClock1.TabIndex = 4
        Me.lblClock1.Text = "12:00 AM"
        '
        'startBtn
        '
        Me.startBtn.AnimationHoverSpeed = 0.07!
        Me.startBtn.AnimationSpeed = 0.03!
        Me.startBtn.BackColor = System.Drawing.Color.Transparent
        Me.startBtn.BaseColor = System.Drawing.Color.Black
        Me.startBtn.BorderColor = System.Drawing.Color.Black
        Me.startBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.startBtn.FocusedColor = System.Drawing.Color.Empty
        Me.startBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.ForeColor = System.Drawing.Color.White
        Me.startBtn.Image = CType(resources.GetObject("startBtn.Image"), System.Drawing.Image)
        Me.startBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.startBtn.ImageSize = New System.Drawing.Size(40, 40)
        Me.startBtn.Location = New System.Drawing.Point(152, 344)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.startBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.startBtn.OnHoverForeColor = System.Drawing.Color.Black
        Me.startBtn.OnHoverImage = Nothing
        Me.startBtn.OnPressedColor = System.Drawing.Color.Black
        Me.startBtn.Radius = 10
        Me.startBtn.Size = New System.Drawing.Size(181, 44)
        Me.startBtn.TabIndex = 2
        Me.startBtn.Text = "Get started!"
        Me.startBtn.TextOffsetX = 30
        Me.startBtn.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-479, 275)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(1114, 655)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'contentPane
        '
        Me.contentPane.BackColor = System.Drawing.SystemColors.Control
        Me.contentPane.Controls.Add(Me.startUpBtn)
        Me.contentPane.Controls.Add(Me.GunaPictureBox2)
        Me.contentPane.Location = New System.Drawing.Point(0, 65)
        Me.contentPane.Name = "contentPane"
        Me.contentPane.Size = New System.Drawing.Size(1200, 659)
        Me.contentPane.TabIndex = 3
        '
        'startUpBtn
        '
        Me.startUpBtn.AnimationHoverSpeed = 0.07!
        Me.startUpBtn.AnimationSpeed = 0.03!
        Me.startUpBtn.BackColor = System.Drawing.Color.Transparent
        Me.startUpBtn.BaseColor1 = System.Drawing.Color.RoyalBlue
        Me.startUpBtn.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.startUpBtn.BorderColor = System.Drawing.Color.Transparent
        Me.startUpBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.startUpBtn.FocusedColor = System.Drawing.Color.Empty
        Me.startUpBtn.Font = New System.Drawing.Font("Trocchi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startUpBtn.ForeColor = System.Drawing.Color.White
        Me.startUpBtn.Image = CType(resources.GetObject("startUpBtn.Image"), System.Drawing.Image)
        Me.startUpBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.startUpBtn.ImageOffsetX = 70
        Me.startUpBtn.ImageSize = New System.Drawing.Size(40, 40)
        Me.startUpBtn.Location = New System.Drawing.Point(120, 250)
        Me.startUpBtn.Name = "startUpBtn"
        Me.startUpBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.startUpBtn.OnHoverBaseColor2 = System.Drawing.Color.RoyalBlue
        Me.startUpBtn.OnHoverBorderColor = System.Drawing.Color.BlanchedAlmond
        Me.startUpBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.startUpBtn.OnHoverImage = Nothing
        Me.startUpBtn.OnPressedColor = System.Drawing.Color.Black
        Me.startUpBtn.Radius = 20
        Me.startUpBtn.Size = New System.Drawing.Size(322, 47)
        Me.startUpBtn.TabIndex = 1
        Me.startUpBtn.Text = "Get Started!"
        Me.startUpBtn.TextOffsetX = 60
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(1200, 659)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 0
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaPanel1.Controls.Add(Me.minimize)
        Me.GunaPanel1.Controls.Add(Me.lblClock)
        Me.GunaPanel1.Location = New System.Drawing.Point(85, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1118, 65)
        Me.GunaPanel1.TabIndex = 4
        '
        'minimize
        '
        Me.minimize.Controls.Add(Me.min)
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Location = New System.Drawing.Point(968, 0)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(51, 65)
        Me.minimize.TabIndex = 1
        '
        'min
        '
        Me.min.BackColor = System.Drawing.Color.White
        Me.min.Location = New System.Drawing.Point(16, 32)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(20, 3)
        Me.min.TabIndex = 2
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("Trocchi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.Location = New System.Drawing.Point(1026, 23)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(79, 21)
        Me.lblClock.TabIndex = 0
        Me.lblClock.Text = "12:00 AM"
        '
        'Clock
        '
        Me.Clock.Enabled = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.contentPane)
        Me.Controls.Add(Me.GunaPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.panelIndicator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelIndicator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelIndicator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contentPane.ResumeLayout(False)
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.minimize.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents panelBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PanelBtn1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents logOutBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelBtn3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelBtn2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents startBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblClock1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents contentPane As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblClock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Clock As Timer
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents startUpBtn As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents panelIndicator3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents panelIndicator2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents panelIndicator1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents minimize As Guna.UI.WinForms.GunaPanel
    Friend WithEvents min As Guna.UI.WinForms.GunaPanel
End Class
