<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgv1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.txtlocation = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnbrowse = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnupload = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.BackgroundColor = System.Drawing.Color.White
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv1.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.EnableHeadersVisualStyles = False
        Me.dgv1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1.Location = New System.Drawing.Point(12, 76)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(526, 244)
        Me.dgv1.TabIndex = 0
        Me.dgv1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv1.ThemeStyle.HeaderStyle.Height = 4
        Me.dgv1.ThemeStyle.ReadOnly = False
        Me.dgv1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv1.ThemeStyle.RowsStyle.Height = 22
        Me.dgv1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'txtlocation
        '
        Me.txtlocation.BackColor = System.Drawing.Color.White
        Me.txtlocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlocation.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlocation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtlocation.LineColor = System.Drawing.Color.Gainsboro
        Me.txtlocation.Location = New System.Drawing.Point(12, 28)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlocation.Size = New System.Drawing.Size(194, 26)
        Me.txtlocation.TabIndex = 1
        '
        'btnbrowse
        '
        Me.btnbrowse.AnimationHoverSpeed = 0.07!
        Me.btnbrowse.AnimationSpeed = 0.03!
        Me.btnbrowse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbrowse.BorderColor = System.Drawing.Color.Black
        Me.btnbrowse.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnbrowse.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.CheckedForeColor = System.Drawing.Color.White
        Me.btnbrowse.CheckedImage = CType(resources.GetObject("btnbrowse.CheckedImage"), System.Drawing.Image)
        Me.btnbrowse.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnbrowse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnbrowse.FocusedColor = System.Drawing.Color.Empty
        Me.btnbrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Image = Nothing
        Me.btnbrowse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnbrowse.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnbrowse.Location = New System.Drawing.Point(233, 28)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbrowse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnbrowse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnbrowse.OnHoverImage = Nothing
        Me.btnbrowse.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnbrowse.OnPressedColor = System.Drawing.Color.Black
        Me.btnbrowse.Size = New System.Drawing.Size(118, 26)
        Me.btnbrowse.TabIndex = 2
        Me.btnbrowse.Text = "Choose File"
        Me.btnbrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnupload
        '
        Me.btnupload.AnimationHoverSpeed = 0.07!
        Me.btnupload.AnimationSpeed = 0.03!
        Me.btnupload.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupload.BorderColor = System.Drawing.Color.Black
        Me.btnupload.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnupload.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnupload.CheckedForeColor = System.Drawing.Color.White
        Me.btnupload.CheckedImage = CType(resources.GetObject("btnupload.CheckedImage"), System.Drawing.Image)
        Me.btnupload.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnupload.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupload.FocusedColor = System.Drawing.Color.Empty
        Me.btnupload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupload.ForeColor = System.Drawing.Color.White
        Me.btnupload.Image = Nothing
        Me.btnupload.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupload.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnupload.Location = New System.Drawing.Point(420, 28)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupload.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupload.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupload.OnHoverImage = Nothing
        Me.btnupload.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnupload.OnPressedColor = System.Drawing.Color.Black
        Me.btnupload.Size = New System.Drawing.Size(118, 26)
        Me.btnupload.TabIndex = 3
        Me.btnupload.Text = "Upload data"
        Me.btnupload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 8)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(200, 13)
        Me.ProgressBar1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 332)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnupload)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.txtlocation)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents txtlocation As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnbrowse As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnupload As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As Guna.UI.WinForms.GunaProgressBar
End Class
