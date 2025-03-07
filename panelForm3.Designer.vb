<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm3
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelForm3))
        Me.Tbx_Username = New System.Windows.Forms.TextBox()
        Me.Tbx_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Credentials = New Guna.UI.WinForms.GunaGradientButton()
        Me.Btn_Update = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.lblPasswordHelp = New Guna.UI.WinForms.GunaLabel()
        Me.lblUsernameHelp = New Guna.UI.WinForms.GunaLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbx_Username
        '
        Me.Tbx_Username.BackColor = System.Drawing.Color.White
        Me.Tbx_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_Username.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_Username.Location = New System.Drawing.Point(23, 14)
        Me.Tbx_Username.Name = "Tbx_Username"
        Me.Tbx_Username.Size = New System.Drawing.Size(273, 26)
        Me.Tbx_Username.TabIndex = 1
        '
        'Tbx_Password
        '
        Me.Tbx_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_Password.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Tbx_Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_Password.Location = New System.Drawing.Point(23, 14)
        Me.Tbx_Password.Name = "Tbx_Password"
        Me.Tbx_Password.Size = New System.Drawing.Size(273, 26)
        Me.Tbx_Password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trocchi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(88, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trocchi", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(88, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Btn_Credentials
        '
        Me.Btn_Credentials.AnimationHoverSpeed = 0.07!
        Me.Btn_Credentials.AnimationSpeed = 0.03!
        Me.Btn_Credentials.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Credentials.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Credentials.BaseColor2 = System.Drawing.Color.MediumBlue
        Me.Btn_Credentials.BorderColor = System.Drawing.Color.Black
        Me.Btn_Credentials.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Credentials.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Credentials.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Credentials.ForeColor = System.Drawing.Color.White
        Me.Btn_Credentials.Image = CType(resources.GetObject("Btn_Credentials.Image"), System.Drawing.Image)
        Me.Btn_Credentials.ImageOffsetX = 25
        Me.Btn_Credentials.ImageSize = New System.Drawing.Size(25, 25)
        Me.Btn_Credentials.Location = New System.Drawing.Point(271, 522)
        Me.Btn_Credentials.Name = "Btn_Credentials"
        Me.Btn_Credentials.OnHoverBaseColor1 = System.Drawing.Color.MediumBlue
        Me.Btn_Credentials.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Credentials.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Credentials.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Credentials.OnHoverImage = Nothing
        Me.Btn_Credentials.OnPressedColor = System.Drawing.Color.Aqua
        Me.Btn_Credentials.Radius = 20
        Me.Btn_Credentials.Size = New System.Drawing.Size(200, 60)
        Me.Btn_Credentials.TabIndex = 7
        Me.Btn_Credentials.Text = "VIEW "
        Me.Btn_Credentials.TextOffsetX = -5
        '
        'Btn_Update
        '
        Me.Btn_Update.AnimationHoverSpeed = 0.07!
        Me.Btn_Update.AnimationSpeed = 0.03!
        Me.Btn_Update.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Update.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Update.BaseColor2 = System.Drawing.Color.Green
        Me.Btn_Update.BorderColor = System.Drawing.Color.Black
        Me.Btn_Update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Update.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Update.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.Image = CType(resources.GetObject("Btn_Update.Image"), System.Drawing.Image)
        Me.Btn_Update.ImageOffsetX = 22
        Me.Btn_Update.ImageSize = New System.Drawing.Size(25, 25)
        Me.Btn_Update.Location = New System.Drawing.Point(51, 522)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.OnHoverBaseColor1 = System.Drawing.Color.Green
        Me.Btn_Update.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Update.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Update.OnHoverImage = Nothing
        Me.Btn_Update.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Update.Radius = 20
        Me.Btn_Update.Size = New System.Drawing.Size(200, 60)
        Me.Btn_Update.TabIndex = 8
        Me.Btn_Update.Text = "UPDATE"
        Me.Btn_Update.TextOffsetX = -5
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.GunaElipsePanel1.Controls.Add(Me.GunaShadowPanel2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaShadowPanel1)
        Me.GunaElipsePanel1.Controls.Add(Me.lblPasswordHelp)
        Me.GunaElipsePanel1.Controls.Add(Me.lblUsernameHelp)
        Me.GunaElipsePanel1.Controls.Add(Me.Label4)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaPictureBox2)
        Me.GunaElipsePanel1.Controls.Add(Me.Btn_Credentials)
        Me.GunaElipsePanel1.Controls.Add(Me.Label1)
        Me.GunaElipsePanel1.Controls.Add(Me.Btn_Update)
        Me.GunaElipsePanel1.Controls.Add(Me.Label2)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(672, 26)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 20
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(505, 678)
        Me.GunaElipsePanel1.TabIndex = 10
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.Tbx_Password)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(93, 408)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 5
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(318, 53)
        Me.GunaShadowPanel2.TabIndex = 40
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.Tbx_Username)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(93, 305)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 5
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(318, 53)
        Me.GunaShadowPanel1.TabIndex = 39
        '
        'lblPasswordHelp
        '
        Me.lblPasswordHelp.AutoSize = True
        Me.lblPasswordHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPasswordHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblPasswordHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPasswordHelp.Location = New System.Drawing.Point(373, 464)
        Me.lblPasswordHelp.Name = "lblPasswordHelp"
        Me.lblPasswordHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblPasswordHelp.TabIndex = 38
        Me.lblPasswordHelp.Text = "Help?"
        '
        'lblUsernameHelp
        '
        Me.lblUsernameHelp.AutoSize = True
        Me.lblUsernameHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUsernameHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblUsernameHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUsernameHelp.Location = New System.Drawing.Point(373, 358)
        Me.lblUsernameHelp.Name = "lblUsernameHelp"
        Me.lblUsernameHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblUsernameHelp.TabIndex = 37
        Me.lblUsernameHelp.Text = "Help?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ACCOUNT"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(153, 51)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(210, 210)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 11
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.ErrorImage = CType(resources.GetObject("GunaPictureBox1.ErrorImage"), System.Drawing.Image)
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.InitialImage = CType(resources.GetObject("GunaPictureBox1.InitialImage"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-9, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(654, 659)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 9
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.Black
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(642, 171)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(570, 488)
        Me.GunaGradientPanel1.TabIndex = 11
        Me.GunaGradientPanel1.Text = "GunaGradientPanel1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Trocchi", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 48)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hello," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.CausesValidation = False
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(107, 473)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 172)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Angelito " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sanchez!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(85, 659)
        Me.GunaPanel1.TabIndex = 14
        '
        'panelForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "panelForm3"
        Me.Text = "Panel3"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tbx_Username As TextBox
    Friend WithEvents Tbx_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Credentials As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Btn_Update As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPasswordHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUsernameHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
End Class
