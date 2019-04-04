<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanBay
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVeDau = New System.Windows.Forms.Button()
        Me.btnLui = New System.Windows.Forms.Button()
        Me.btnTien = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnVeCuoi = New System.Windows.Forms.Button()
        Me.dgvThongTinSB = New System.Windows.Forms.DataGridView()
        Me.masanbay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tensanbay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenSanBay = New System.Windows.Forms.TextBox()
        Me.txtMaSanBay = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvThongTinSB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(61, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Tên sân bay"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(61, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Mã sân bay"
        '
        'btnVeDau
        '
        Me.btnVeDau.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeDau.Location = New System.Drawing.Point(82, 164)
        Me.btnVeDau.Name = "btnVeDau"
        Me.btnVeDau.Size = New System.Drawing.Size(62, 29)
        Me.btnVeDau.TabIndex = 142
        Me.btnVeDau.Text = "l<"
        Me.btnVeDau.UseVisualStyleBackColor = True
        '
        'btnLui
        '
        Me.btnLui.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLui.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLui.Location = New System.Drawing.Point(165, 164)
        Me.btnLui.Name = "btnLui"
        Me.btnLui.Size = New System.Drawing.Size(62, 29)
        Me.btnLui.TabIndex = 143
        Me.btnLui.Text = "<"
        Me.btnLui.UseVisualStyleBackColor = True
        '
        'btnTien
        '
        Me.btnTien.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTien.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTien.Location = New System.Drawing.Point(253, 164)
        Me.btnTien.Name = "btnTien"
        Me.btnTien.Size = New System.Drawing.Size(62, 29)
        Me.btnTien.TabIndex = 145
        Me.btnTien.Text = ">"
        Me.btnTien.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(390, 123)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 31)
        Me.btnThoat.TabIndex = 141
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXoa.Location = New System.Drawing.Point(294, 123)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(78, 31)
        Me.btnXoa.TabIndex = 137
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnSua.Location = New System.Drawing.Point(197, 123)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 138
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(104, 123)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 139
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(5, 123)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 140
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnVeCuoi
        '
        Me.btnVeCuoi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeCuoi.Location = New System.Drawing.Point(338, 164)
        Me.btnVeCuoi.Name = "btnVeCuoi"
        Me.btnVeCuoi.Size = New System.Drawing.Size(62, 29)
        Me.btnVeCuoi.TabIndex = 144
        Me.btnVeCuoi.Text = ">l"
        Me.btnVeCuoi.UseVisualStyleBackColor = True
        '
        'dgvThongTinSB
        '
        Me.dgvThongTinSB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinSB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinSB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinSB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masanbay, Me.tensanbay})
        Me.dgvThongTinSB.Location = New System.Drawing.Point(-7, 211)
        Me.dgvThongTinSB.Name = "dgvThongTinSB"
        Me.dgvThongTinSB.Size = New System.Drawing.Size(490, 120)
        Me.dgvThongTinSB.TabIndex = 135
        '
        'masanbay
        '
        Me.masanbay.DataPropertyName = "MaSanBay"
        Me.masanbay.HeaderText = "Mã sân bay"
        Me.masanbay.Name = "masanbay"
        Me.masanbay.Width = 200
        '
        'tensanbay
        '
        Me.tensanbay.DataPropertyName = "TenSanBay"
        Me.tensanbay.HeaderText = "Tên sân bay"
        Me.tensanbay.Name = "tensanbay"
        Me.tensanbay.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(140, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "QUẢN LÝ SÂN BAY"
        '
        'txtTenSanBay
        '
        Me.txtTenSanBay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenSanBay.Location = New System.Drawing.Point(155, 79)
        Me.txtTenSanBay.Name = "txtTenSanBay"
        Me.txtTenSanBay.Size = New System.Drawing.Size(219, 26)
        Me.txtTenSanBay.TabIndex = 148
        '
        'txtMaSanBay
        '
        Me.txtMaSanBay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSanBay.Location = New System.Drawing.Point(155, 45)
        Me.txtMaSanBay.Name = "txtMaSanBay"
        Me.txtMaSanBay.Size = New System.Drawing.Size(219, 26)
        Me.txtMaSanBay.TabIndex = 149
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox3.Location = New System.Drawing.Point(305, 383)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(95, 22)
        Me.ComboBox3.TabIndex = 153
        Me.ComboBox3.Text = "0"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox2.Location = New System.Drawing.Point(181, 383)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(95, 22)
        Me.ComboBox2.TabIndex = 154
        Me.ComboBox2.Text = "0"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.ComboBox1.Location = New System.Drawing.Point(74, 383)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 22)
        Me.ComboBox1.TabIndex = 155
        Me.ComboBox1.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label7.Location = New System.Drawing.Point(299, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Em bé ( < 2 )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(181, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Trẻ em ( 2 - 11 )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(77, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Người lớn"
        '
        'SanBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 443)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTenSanBay)
        Me.Controls.Add(Me.txtMaSanBay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVeDau)
        Me.Controls.Add(Me.btnLui)
        Me.Controls.Add(Me.btnTien)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnVeCuoi)
        Me.Controls.Add(Me.dgvThongTinSB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SanBay"
        Me.Text = "SanBay"
        CType(Me.dgvThongTinSB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVeDau As Button
    Friend WithEvents btnLui As Button
    Friend WithEvents btnTien As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnVeCuoi As Button
    Friend WithEvents dgvThongTinSB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenSanBay As TextBox
    Friend WithEvents txtMaSanBay As TextBox
    Friend WithEvents masanbay As DataGridViewTextBoxColumn
    Friend WithEvents tensanbay As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
