<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelForm1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_UndoEnd = New Guna.UI.WinForms.GunaButton()
        Me.Btn_EndProject = New Guna.UI.WinForms.GunaButton()
        Me.Tbx_ProjName_Write = New System.Windows.Forms.TextBox()
        Me.Tbx_ClientName = New System.Windows.Forms.TextBox()
        Me.Tbx_DateEnded = New System.Windows.Forms.TextBox()
        Me.Tbx_Budget = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Load = New Guna.UI.WinForms.GunaButton()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel5 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lblDateHelp = New Guna.UI.WinForms.GunaLabel()
        Me.Create_Btn = New Guna.UI.WinForms.GunaGradientButton()
        Me.Btn_Delete = New Guna.UI.WinForms.GunaGradientButton()
        Me.Btn_Update = New Guna.UI.WinForms.GunaGradientButton()
        Me.lblNameHelp = New Guna.UI.WinForms.GunaLabel()
        Me.lblBudgetHelp = New Guna.UI.WinForms.GunaLabel()
        Me.lblClientHelp = New Guna.UI.WinForms.GunaLabel()
        Me.Tbx_ProjCode_Read = New System.Windows.Forms.TextBox()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.GunaElipsePanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Btn_UndoEnd
        '
        Me.Btn_UndoEnd.AnimationHoverSpeed = 0.07!
        Me.Btn_UndoEnd.AnimationSpeed = 0.03!
        Me.Btn_UndoEnd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_UndoEnd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_UndoEnd.BorderColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_UndoEnd.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_UndoEnd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Btn_UndoEnd.ForeColor = System.Drawing.Color.White
        Me.Btn_UndoEnd.Image = CType(resources.GetObject("Btn_UndoEnd.Image"), System.Drawing.Image)
        Me.Btn_UndoEnd.ImageOffsetX = 10
        Me.Btn_UndoEnd.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_UndoEnd.Location = New System.Drawing.Point(438, 463)
        Me.Btn_UndoEnd.Name = "Btn_UndoEnd"
        Me.Btn_UndoEnd.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.Btn_UndoEnd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_UndoEnd.OnHoverImage = Nothing
        Me.Btn_UndoEnd.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.Radius = 20
        Me.Btn_UndoEnd.Size = New System.Drawing.Size(152, 45)
        Me.Btn_UndoEnd.TabIndex = 6
        Me.Btn_UndoEnd.Text = "Undo End Proj"
        Me.Btn_UndoEnd.TextOffsetX = -5
        '
        'Btn_EndProject
        '
        Me.Btn_EndProject.AnimationHoverSpeed = 0.07!
        Me.Btn_EndProject.AnimationSpeed = 0.03!
        Me.Btn_EndProject.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EndProject.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_EndProject.BorderColor = System.Drawing.Color.Black
        Me.Btn_EndProject.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_EndProject.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_EndProject.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Btn_EndProject.ForeColor = System.Drawing.Color.White
        Me.Btn_EndProject.Image = CType(resources.GetObject("Btn_EndProject.Image"), System.Drawing.Image)
        Me.Btn_EndProject.ImageOffsetX = 25
        Me.Btn_EndProject.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_EndProject.Location = New System.Drawing.Point(279, 463)
        Me.Btn_EndProject.Name = "Btn_EndProject"
        Me.Btn_EndProject.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.Btn_EndProject.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_EndProject.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_EndProject.OnHoverImage = Nothing
        Me.Btn_EndProject.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_EndProject.Radius = 20
        Me.Btn_EndProject.Size = New System.Drawing.Size(152, 45)
        Me.Btn_EndProject.TabIndex = 5
        Me.Btn_EndProject.Text = "End Project"
        Me.Btn_EndProject.TextOffsetX = -7
        '
        'Tbx_ProjName_Write
        '
        Me.Tbx_ProjName_Write.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_ProjName_Write.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Tbx_ProjName_Write.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_ProjName_Write.Location = New System.Drawing.Point(20, 13)
        Me.Tbx_ProjName_Write.Name = "Tbx_ProjName_Write"
        Me.Tbx_ProjName_Write.Size = New System.Drawing.Size(188, 18)
        Me.Tbx_ProjName_Write.TabIndex = 2
        '
        'Tbx_ClientName
        '
        Me.Tbx_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_ClientName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Tbx_ClientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_ClientName.Location = New System.Drawing.Point(19, 13)
        Me.Tbx_ClientName.Name = "Tbx_ClientName"
        Me.Tbx_ClientName.Size = New System.Drawing.Size(189, 18)
        Me.Tbx_ClientName.TabIndex = 3
        '
        'Tbx_DateEnded
        '
        Me.Tbx_DateEnded.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_DateEnded.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Tbx_DateEnded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_DateEnded.Location = New System.Drawing.Point(19, 14)
        Me.Tbx_DateEnded.Name = "Tbx_DateEnded"
        Me.Tbx_DateEnded.Size = New System.Drawing.Size(189, 18)
        Me.Tbx_DateEnded.TabIndex = 6
        '
        'Tbx_Budget
        '
        Me.Tbx_Budget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_Budget.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Tbx_Budget.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Tbx_Budget.Location = New System.Drawing.Point(20, 14)
        Me.Tbx_Budget.Name = "Tbx_Budget"
        Me.Tbx_Budget.Size = New System.Drawing.Size(187, 18)
        Me.Tbx_Budget.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trocchi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(112, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Project Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(899, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trocchi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(112, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Project Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trocchi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(363, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Client Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trocchi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(114, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Project Budget"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trocchi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(364, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Date Ended"
        '
        'Btn_Load
        '
        Me.Btn_Load.AnimationHoverSpeed = 0.07!
        Me.Btn_Load.AnimationSpeed = 0.03!
        Me.Btn_Load.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Load.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_Load.BorderColor = System.Drawing.Color.Black
        Me.Btn_Load.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Load.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Load.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Btn_Load.ForeColor = System.Drawing.Color.White
        Me.Btn_Load.Image = CType(resources.GetObject("Btn_Load.Image"), System.Drawing.Image)
        Me.Btn_Load.ImageOffsetX = 25
        Me.Btn_Load.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Load.Location = New System.Drawing.Point(120, 463)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.Btn_Load.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Load.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Load.OnHoverImage = Nothing
        Me.Btn_Load.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Load.Radius = 20
        Me.Btn_Load.Size = New System.Drawing.Size(152, 45)
        Me.Btn_Load.TabIndex = 1
        Me.Btn_Load.Text = "Load"
        Me.Btn_Load.TextOffsetX = -3
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 40
        Me.GunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.Gainsboro
        Me.GunaDataGridView1.Location = New System.Drawing.Point(629, 11)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(561, 635)
        Me.GunaDataGridView1.TabIndex = 18
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.DimGray
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightGray
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.Tbx_ProjName_Write)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(116, 231)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 15
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(228, 44)
        Me.GunaElipsePanel2.TabIndex = 20
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.Tbx_ClientName)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(364, 231)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 15
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(228, 44)
        Me.GunaElipsePanel3.TabIndex = 20
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel4.Controls.Add(Me.Tbx_Budget)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(116, 322)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 15
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(228, 44)
        Me.GunaElipsePanel4.TabIndex = 20
        '
        'GunaElipsePanel5
        '
        Me.GunaElipsePanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel5.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel5.Controls.Add(Me.Tbx_DateEnded)
        Me.GunaElipsePanel5.Location = New System.Drawing.Point(364, 322)
        Me.GunaElipsePanel5.Name = "GunaElipsePanel5"
        Me.GunaElipsePanel5.Radius = 15
        Me.GunaElipsePanel5.Size = New System.Drawing.Size(228, 44)
        Me.GunaElipsePanel5.TabIndex = 20
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trocchi", 35.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(104, 56)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(406, 61)
        Me.GunaLabel1.TabIndex = 21
        Me.GunaLabel1.Text = "Project Creation"
        '
        'lblDateHelp
        '
        Me.lblDateHelp.AutoSize = True
        Me.lblDateHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDateHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblDateHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDateHelp.Location = New System.Drawing.Point(552, 368)
        Me.lblDateHelp.Name = "lblDateHelp"
        Me.lblDateHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblDateHelp.TabIndex = 22
        Me.lblDateHelp.Text = "Help?"
        '
        'Create_Btn
        '
        Me.Create_Btn.AnimationHoverSpeed = 0.07!
        Me.Create_Btn.AnimationSpeed = 0.03!
        Me.Create_Btn.BackColor = System.Drawing.Color.Transparent
        Me.Create_Btn.BaseColor1 = System.Drawing.Color.DarkOliveGreen
        Me.Create_Btn.BaseColor2 = System.Drawing.Color.LimeGreen
        Me.Create_Btn.BorderColor = System.Drawing.Color.Black
        Me.Create_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Create_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Create_Btn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create_Btn.ForeColor = System.Drawing.Color.White
        Me.Create_Btn.Image = CType(resources.GetObject("Create_Btn.Image"), System.Drawing.Image)
        Me.Create_Btn.ImageOffsetX = 28
        Me.Create_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Create_Btn.Location = New System.Drawing.Point(118, 412)
        Me.Create_Btn.Name = "Create_Btn"
        Me.Create_Btn.OnHoverBaseColor1 = System.Drawing.Color.LimeGreen
        Me.Create_Btn.OnHoverBaseColor2 = System.Drawing.Color.DarkOliveGreen
        Me.Create_Btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Create_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Create_Btn.OnHoverImage = Nothing
        Me.Create_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Create_Btn.OnPressedDepth = 35
        Me.Create_Btn.Radius = 20
        Me.Create_Btn.Size = New System.Drawing.Size(152, 45)
        Me.Create_Btn.TabIndex = 7
        Me.Create_Btn.Text = "Create"
        Me.Create_Btn.TextOffsetX = -5
        '
        'Btn_Delete
        '
        Me.Btn_Delete.AnimationHoverSpeed = 0.07!
        Me.Btn_Delete.AnimationSpeed = 0.03!
        Me.Btn_Delete.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Delete.BaseColor1 = System.Drawing.Color.Crimson
        Me.Btn_Delete.BaseColor2 = System.Drawing.Color.Tomato
        Me.Btn_Delete.BorderColor = System.Drawing.Color.Black
        Me.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Delete.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Image = CType(resources.GetObject("Btn_Delete.Image"), System.Drawing.Image)
        Me.Btn_Delete.ImageOffsetX = 30
        Me.Btn_Delete.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Delete.Location = New System.Drawing.Point(438, 412)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.OnHoverBaseColor1 = System.Drawing.Color.Tomato
        Me.Btn_Delete.OnHoverBaseColor2 = System.Drawing.Color.Crimson
        Me.Btn_Delete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Delete.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Delete.OnHoverImage = Nothing
        Me.Btn_Delete.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Delete.Radius = 20
        Me.Btn_Delete.Size = New System.Drawing.Size(152, 45)
        Me.Btn_Delete.TabIndex = 9
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.TextOffsetX = -8
        '
        'Btn_Update
        '
        Me.Btn_Update.AnimationHoverSpeed = 0.07!
        Me.Btn_Update.AnimationSpeed = 0.03!
        Me.Btn_Update.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Update.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.Btn_Update.BaseColor2 = System.Drawing.Color.CornflowerBlue
        Me.Btn_Update.BorderColor = System.Drawing.Color.Black
        Me.Btn_Update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Update.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Update.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.Image = CType(resources.GetObject("Btn_Update.Image"), System.Drawing.Image)
        Me.Btn_Update.ImageOffsetX = 28
        Me.Btn_Update.ImageSize = New System.Drawing.Size(23, 23)
        Me.Btn_Update.Location = New System.Drawing.Point(279, 412)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Btn_Update.OnHoverBaseColor2 = System.Drawing.Color.SlateBlue
        Me.Btn_Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Update.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Update.OnHoverImage = Nothing
        Me.Btn_Update.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Update.Radius = 20
        Me.Btn_Update.Size = New System.Drawing.Size(152, 45)
        Me.Btn_Update.TabIndex = 8
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.TextOffsetX = -6
        '
        'lblNameHelp
        '
        Me.lblNameHelp.AutoSize = True
        Me.lblNameHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNameHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblNameHelp.Location = New System.Drawing.Point(305, 276)
        Me.lblNameHelp.Name = "lblNameHelp"
        Me.lblNameHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblNameHelp.TabIndex = 23
        Me.lblNameHelp.Text = "Help?"
        '
        'lblBudgetHelp
        '
        Me.lblBudgetHelp.AutoSize = True
        Me.lblBudgetHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBudgetHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblBudgetHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBudgetHelp.Location = New System.Drawing.Point(305, 368)
        Me.lblBudgetHelp.Name = "lblBudgetHelp"
        Me.lblBudgetHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblBudgetHelp.TabIndex = 24
        Me.lblBudgetHelp.Text = "Help?"
        '
        'lblClientHelp
        '
        Me.lblClientHelp.AutoSize = True
        Me.lblClientHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClientHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblClientHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblClientHelp.Location = New System.Drawing.Point(552, 276)
        Me.lblClientHelp.Name = "lblClientHelp"
        Me.lblClientHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblClientHelp.TabIndex = 25
        Me.lblClientHelp.Text = "Help?"
        '
        'Tbx_ProjCode_Read
        '
        Me.Tbx_ProjCode_Read.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_ProjCode_Read.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_ProjCode_Read.ForeColor = System.Drawing.Color.DarkGray
        Me.Tbx_ProjCode_Read.Location = New System.Drawing.Point(116, 169)
        Me.Tbx_ProjCode_Read.Name = "Tbx_ProjCode_Read"
        Me.Tbx_ProjCode_Read.ReadOnly = True
        Me.Tbx_ProjCode_Read.Size = New System.Drawing.Size(188, 26)
        Me.Tbx_ProjCode_Read.TabIndex = 1
        '
        'panelForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 659)
        Me.Controls.Add(Me.Tbx_ProjCode_Read)
        Me.Controls.Add(Me.lblClientHelp)
        Me.Controls.Add(Me.lblBudgetHelp)
        Me.Controls.Add(Me.lblNameHelp)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Create_Btn)
        Me.Controls.Add(Me.lblDateHelp)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaElipsePanel5)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_UndoEnd)
        Me.Controls.Add(Me.Btn_EndProject)
        Me.Controls.Add(Me.Btn_Load)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "panelForm1"
        Me.Text = "Update"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.GunaElipsePanel5.ResumeLayout(False)
        Me.GunaElipsePanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_UndoEnd As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_EndProject As Guna.UI.WinForms.GunaButton
    Friend WithEvents Tbx_ProjName_Write As TextBox
    Friend WithEvents Tbx_ClientName As TextBox
    Friend WithEvents Tbx_DateEnded As TextBox
    Friend WithEvents Tbx_Budget As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_Load As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel5 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblDateHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Create_Btn As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Btn_Delete As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Btn_Update As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents lblNameHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblBudgetHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblClientHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Tbx_ProjCode_Read As TextBox
End Class
