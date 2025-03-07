<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelForm2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ExpensesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Tbx_TimeRecord = New System.Windows.Forms.TextBox()
        Me.Tbx_Expenditure = New System.Windows.Forms.TextBox()
        Me.Tbx_Amount = New System.Windows.Forms.TextBox()
        Me.Tbx_TotalOutward = New System.Windows.Forms.TextBox()
        Me.Tbx_InwardExp = New System.Windows.Forms.TextBox()
        Me.Tbx_RemainingBudget = New System.Windows.Forms.TextBox()
        Me.Update = New Guna.UI.WinForms.GunaButton()
        Me.Delete = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Categories = New System.Windows.Forms.ComboBox()
        Me.MoneyFlow = New System.Windows.Forms.ComboBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.projName = New Guna.UI.WinForms.GunaLabel()
        Me.Btn_Insert = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblExpenditureHelp = New Guna.UI.WinForms.GunaLabel()
        Me.lblAmountHelp = New Guna.UI.WinForms.GunaLabel()
        CType(Me.ExpensesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExpensesChart
        '
        Me.ExpensesChart.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.Area3DStyle.Inclination = 5
        ChartArea1.Area3DStyle.PointDepth = 50
        ChartArea1.Area3DStyle.PointGapDepth = 150
        ChartArea1.Area3DStyle.Rotation = 20
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.DimGray
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.ExpensesChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ExpensesChart.Legends.Add(Legend1)
        Me.ExpensesChart.Location = New System.Drawing.Point(924, 8)
        Me.ExpensesChart.Name = "ExpensesChart"
        Me.ExpensesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.ExpensesChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))}
        Me.ExpensesChart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "CashFlow"
        Me.ExpensesChart.Series.Add(Series1)
        Me.ExpensesChart.Size = New System.Drawing.Size(267, 413)
        Me.ExpensesChart.TabIndex = 3
        Me.ExpensesChart.Text = "Cash Flow"
        '
        'Tbx_TimeRecord
        '
        Me.Tbx_TimeRecord.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_TimeRecord.Font = New System.Drawing.Font("Trocchi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_TimeRecord.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Tbx_TimeRecord.Location = New System.Drawing.Point(128, 127)
        Me.Tbx_TimeRecord.Name = "Tbx_TimeRecord"
        Me.Tbx_TimeRecord.ReadOnly = True
        Me.Tbx_TimeRecord.Size = New System.Drawing.Size(176, 15)
        Me.Tbx_TimeRecord.TabIndex = 4
        '
        'Tbx_Expenditure
        '
        Me.Tbx_Expenditure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_Expenditure.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Tbx_Expenditure.ForeColor = System.Drawing.Color.Gray
        Me.Tbx_Expenditure.Location = New System.Drawing.Point(17, 11)
        Me.Tbx_Expenditure.Name = "Tbx_Expenditure"
        Me.Tbx_Expenditure.Size = New System.Drawing.Size(231, 16)
        Me.Tbx_Expenditure.TabIndex = 5
        '
        'Tbx_Amount
        '
        Me.Tbx_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_Amount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_Amount.ForeColor = System.Drawing.Color.Gray
        Me.Tbx_Amount.Location = New System.Drawing.Point(16, 11)
        Me.Tbx_Amount.Name = "Tbx_Amount"
        Me.Tbx_Amount.Size = New System.Drawing.Size(231, 16)
        Me.Tbx_Amount.TabIndex = 6
        '
        'Tbx_TotalOutward
        '
        Me.Tbx_TotalOutward.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_TotalOutward.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbx_TotalOutward.ForeColor = System.Drawing.Color.DimGray
        Me.Tbx_TotalOutward.Location = New System.Drawing.Point(511, 458)
        Me.Tbx_TotalOutward.Name = "Tbx_TotalOutward"
        Me.Tbx_TotalOutward.ReadOnly = True
        Me.Tbx_TotalOutward.Size = New System.Drawing.Size(176, 36)
        Me.Tbx_TotalOutward.TabIndex = 7
        '
        'Tbx_InwardExp
        '
        Me.Tbx_InwardExp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_InwardExp.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tbx_InwardExp.ForeColor = System.Drawing.Color.DimGray
        Me.Tbx_InwardExp.Location = New System.Drawing.Point(805, 458)
        Me.Tbx_InwardExp.Name = "Tbx_InwardExp"
        Me.Tbx_InwardExp.ReadOnly = True
        Me.Tbx_InwardExp.Size = New System.Drawing.Size(176, 36)
        Me.Tbx_InwardExp.TabIndex = 8
        '
        'Tbx_RemainingBudget
        '
        Me.Tbx_RemainingBudget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbx_RemainingBudget.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Tbx_RemainingBudget.ForeColor = System.Drawing.Color.DimGray
        Me.Tbx_RemainingBudget.Location = New System.Drawing.Point(511, 527)
        Me.Tbx_RemainingBudget.Name = "Tbx_RemainingBudget"
        Me.Tbx_RemainingBudget.ReadOnly = True
        Me.Tbx_RemainingBudget.Size = New System.Drawing.Size(172, 36)
        Me.Tbx_RemainingBudget.TabIndex = 9
        '
        'Update
        '
        Me.Update.AnimationHoverSpeed = 0.07!
        Me.Update.AnimationSpeed = 0.03!
        Me.Update.BackColor = System.Drawing.Color.Transparent
        Me.Update.BaseColor = System.Drawing.Color.DarkTurquoise
        Me.Update.BorderColor = System.Drawing.Color.Black
        Me.Update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Update.FocusedColor = System.Drawing.Color.Empty
        Me.Update.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Update.ForeColor = System.Drawing.Color.White
        Me.Update.Image = CType(resources.GetObject("Update.Image"), System.Drawing.Image)
        Me.Update.ImageOffsetX = 11
        Me.Update.ImageSize = New System.Drawing.Size(20, 20)
        Me.Update.Location = New System.Drawing.Point(131, 512)
        Me.Update.Name = "Update"
        Me.Update.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Update.OnHoverForeColor = System.Drawing.Color.White
        Me.Update.OnHoverImage = Nothing
        Me.Update.OnPressedColor = System.Drawing.Color.Black
        Me.Update.Radius = 20
        Me.Update.Size = New System.Drawing.Size(130, 45)
        Me.Update.TabIndex = 13
        Me.Update.Text = "UPDATE"
        '
        'Delete
        '
        Me.Delete.AnimationHoverSpeed = 0.07!
        Me.Delete.AnimationSpeed = 0.03!
        Me.Delete.BackColor = System.Drawing.Color.Transparent
        Me.Delete.BaseColor = System.Drawing.Color.Red
        Me.Delete.BorderColor = System.Drawing.Color.Black
        Me.Delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Delete.FocusedColor = System.Drawing.Color.Empty
        Me.Delete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageOffsetX = 12
        Me.Delete.ImageSize = New System.Drawing.Size(20, 20)
        Me.Delete.Location = New System.Drawing.Point(267, 512)
        Me.Delete.Name = "Delete"
        Me.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Delete.OnHoverForeColor = System.Drawing.Color.White
        Me.Delete.OnHoverImage = Nothing
        Me.Delete.OnPressedColor = System.Drawing.Color.Black
        Me.Delete.Radius = 20
        Me.Delete.Size = New System.Drawing.Size(130, 45)
        Me.Delete.TabIndex = 14
        Me.Delete.Text = "DELETE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trocchi", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(124, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Expenditure:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trocchi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(127, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trocchi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(508, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total Outward Cash Flow"
        '
        'Categories
        '
        Me.Categories.BackColor = System.Drawing.Color.White
        Me.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Categories.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Categories.ForeColor = System.Drawing.Color.DimGray
        Me.Categories.FormattingEnabled = True
        Me.Categories.Location = New System.Drawing.Point(14, 11)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(130, 23)
        Me.Categories.TabIndex = 21
        Me.Categories.Text = "Categories"
        '
        'MoneyFlow
        '
        Me.MoneyFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MoneyFlow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MoneyFlow.ForeColor = System.Drawing.Color.DimGray
        Me.MoneyFlow.FormattingEnabled = True
        Me.MoneyFlow.Location = New System.Drawing.Point(16, 10)
        Me.MoneyFlow.Name = "MoneyFlow"
        Me.MoneyFlow.Size = New System.Drawing.Size(130, 23)
        Me.MoneyFlow.TabIndex = 22
        Me.MoneyFlow.Text = "Money Flow"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trocchi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 20
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.Gainsboro
        Me.GunaDataGridView1.Location = New System.Drawing.Point(428, 8)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GunaDataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray
        Me.GunaDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaDataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(496, 413)
        Me.GunaDataGridView1.TabIndex = 2
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Trocchi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 20
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.Tbx_Amount)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(128, 241)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(266, 39)
        Me.GunaElipsePanel1.TabIndex = 25
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.Tbx_Expenditure)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(128, 169)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(266, 39)
        Me.GunaElipsePanel2.TabIndex = 26
        '
        'projName
        '
        Me.projName.AutoSize = True
        Me.projName.Font = New System.Drawing.Font("Trocchi", 18.0!)
        Me.projName.ForeColor = System.Drawing.Color.Black
        Me.projName.Location = New System.Drawing.Point(107, 57)
        Me.projName.Name = "projName"
        Me.projName.Size = New System.Drawing.Size(164, 31)
        Me.projName.TabIndex = 27
        Me.projName.Text = "Place Holder"
        '
        'Btn_Insert
        '
        Me.Btn_Insert.AnimationHoverSpeed = 0.07!
        Me.Btn_Insert.AnimationSpeed = 0.03!
        Me.Btn_Insert.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Insert.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Insert.BaseColor2 = System.Drawing.Color.Green
        Me.Btn_Insert.BorderColor = System.Drawing.Color.Black
        Me.Btn_Insert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Insert.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Insert.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Insert.ForeColor = System.Drawing.Color.White
        Me.Btn_Insert.Image = CType(resources.GetObject("Btn_Insert.Image"), System.Drawing.Image)
        Me.Btn_Insert.ImageOffsetX = 80
        Me.Btn_Insert.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Insert.Location = New System.Drawing.Point(131, 461)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.OnHoverBaseColor1 = System.Drawing.Color.Green
        Me.Btn_Insert.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Insert.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Insert.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Insert.OnHoverImage = Nothing
        Me.Btn_Insert.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Insert.Radius = 20
        Me.Btn_Insert.Size = New System.Drawing.Size(266, 45)
        Me.Btn_Insert.TabIndex = 28
        Me.Btn_Insert.Text = "INSERT"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Silver
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(113, 115)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(295, 3)
        Me.GunaLinePanel1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trocchi", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(125, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Select:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trocchi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(801, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Total Inward Cash Flow"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trocchi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(508, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Remaining Balance:" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.Categories)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(131, 319)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 20
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(156, 43)
        Me.GunaElipsePanel3.TabIndex = 34
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel4.Controls.Add(Me.MoneyFlow)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(131, 378)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 20
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(156, 43)
        Me.GunaElipsePanel4.TabIndex = 35
        '
        'lblExpenditureHelp
        '
        Me.lblExpenditureHelp.AutoSize = True
        Me.lblExpenditureHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExpenditureHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblExpenditureHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblExpenditureHelp.Location = New System.Drawing.Point(359, 209)
        Me.lblExpenditureHelp.Name = "lblExpenditureHelp"
        Me.lblExpenditureHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblExpenditureHelp.TabIndex = 36
        Me.lblExpenditureHelp.Text = "Help?"
        '
        'lblAmountHelp
        '
        Me.lblAmountHelp.AutoSize = True
        Me.lblAmountHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAmountHelp.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lblAmountHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblAmountHelp.Location = New System.Drawing.Point(359, 281)
        Me.lblAmountHelp.Name = "lblAmountHelp"
        Me.lblAmountHelp.Size = New System.Drawing.Size(26, 11)
        Me.lblAmountHelp.TabIndex = 37
        Me.lblAmountHelp.Text = "Help?"
        '
        'panelForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 659)
        Me.Controls.Add(Me.lblAmountHelp)
        Me.Controls.Add(Me.lblExpenditureHelp)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.projName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.Btn_Insert)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Tbx_RemainingBudget)
        Me.Controls.Add(Me.Tbx_InwardExp)
        Me.Controls.Add(Me.Tbx_TotalOutward)
        Me.Controls.Add(Me.Tbx_TimeRecord)
        Me.Controls.Add(Me.ExpensesChart)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "panelForm2"
        Me.Text = "Panel3"
        CType(Me.ExpensesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpensesChart As DataVisualization.Charting.Chart
    Friend WithEvents Tbx_TimeRecord As TextBox
    Friend WithEvents Tbx_Expenditure As TextBox
    Friend WithEvents Tbx_Amount As TextBox
    Friend WithEvents Tbx_TotalOutward As TextBox
    Friend WithEvents Tbx_InwardExp As TextBox
    Friend WithEvents Tbx_RemainingBudget As TextBox
    Friend WithEvents Update As Guna.UI.WinForms.GunaButton
    Friend WithEvents Delete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Categories As ComboBox
    Friend WithEvents MoneyFlow As ComboBox
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents projName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Btn_Insert As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblExpenditureHelp As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAmountHelp As Guna.UI.WinForms.GunaLabel
End Class
