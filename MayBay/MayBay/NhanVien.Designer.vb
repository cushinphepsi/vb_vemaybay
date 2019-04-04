<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Me.txtTenNV = New System.Windows.Forms.TextBox()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvThongTinNV = New System.Windows.Forms.DataGridView()
        Me.MaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatKhau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rdNam = New System.Windows.Forms.RadioButton()
        Me.rdNu = New System.Windows.Forms.RadioButton()
        Me.rdKhac = New System.Windows.Forms.RadioButton()
        Me.rdGioiTinh = New System.Windows.Forms.GroupBox()
        CType(Me.dgvThongTinNV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdGioiTinh.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenNV
        '
        Me.txtTenNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenNV.Location = New System.Drawing.Point(159, 72)
        Me.txtTenNV.Name = "txtTenNV"
        Me.txtTenNV.Size = New System.Drawing.Size(219, 26)
        Me.txtTenNV.TabIndex = 163
        '
        'txtMaNV
        '
        Me.txtMaNV.Enabled = False
        Me.txtMaNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(159, 38)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(219, 26)
        Me.txtMaNV.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(59, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tên nhân viên"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(59, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mã nhân viên"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(558, 183)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 31)
        Me.btnThoat.TabIndex = 156
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXoa.Location = New System.Drawing.Point(462, 183)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(78, 31)
        Me.btnXoa.TabIndex = 152
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnSua.Location = New System.Drawing.Point(365, 183)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 153
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(173, 183)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 155
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvThongTinNV
        '
        Me.dgvThongTinNV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinNV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNV, Me.TenNV, Me.GioiTinh, Me.DiaChi, Me.Email, Me.SDT, Me.MatKhau})
        Me.dgvThongTinNV.Location = New System.Drawing.Point(0, 220)
        Me.dgvThongTinNV.Name = "dgvThongTinNV"
        Me.dgvThongTinNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThongTinNV.Size = New System.Drawing.Size(778, 191)
        Me.dgvThongTinNV.TabIndex = 151
        '
        'MaNV
        '
        Me.MaNV.DataPropertyName = "MaNV"
        Me.MaNV.HeaderText = "Mã nhân viên"
        Me.MaNV.Name = "MaNV"
        '
        'TenNV
        '
        Me.TenNV.DataPropertyName = "TenNV"
        Me.TenNV.HeaderText = "Tên nhân viên"
        Me.TenNV.Name = "TenNV"
        Me.TenNV.Width = 180
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        Me.GioiTinh.HeaderText = "Giới tính"
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.Width = 70
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'SDT
        '
        Me.SDT.DataPropertyName = "SDT"
        Me.SDT.HeaderText = "SDT"
        Me.SDT.Name = "SDT"
        '
        'MatKhau
        '
        Me.MatKhau.DataPropertyName = "MatKhau"
        Me.MatKhau.HeaderText = "Mật khẩu"
        Me.MatKhau.Name = "MatKhau"
        Me.MatKhau.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(289, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "QUẢN LÝ NHÂN VIÊN"
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(272, 183)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 154
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatKhau.Location = New System.Drawing.Point(487, 109)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(219, 26)
        Me.txtMatKhau.TabIndex = 180
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(487, 72)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(219, 26)
        Me.txtDiaChi.TabIndex = 179
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDienThoai.Location = New System.Drawing.Point(487, 37)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(219, 26)
        Me.txtDienThoai.TabIndex = 178
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(159, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 26)
        Me.txtEmail.TabIndex = 177
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label9.Location = New System.Drawing.Point(402, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Mật khẩu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(402, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Địa chỉ "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(59, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Giới tính"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label8.Location = New System.Drawing.Point(59, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 19)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label11.Location = New System.Drawing.Point(400, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 19)
        Me.Label11.TabIndex = 166
        Me.Label11.Text = "Điện thoại"
        '
        'rdNam
        '
        Me.rdNam.AutoSize = True
        Me.rdNam.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdNam.Location = New System.Drawing.Point(4, 14)
        Me.rdNam.Name = "rdNam"
        Me.rdNam.Size = New System.Drawing.Size(57, 23)
        Me.rdNam.TabIndex = 0
        Me.rdNam.TabStop = True
        Me.rdNam.Text = "Nam"
        Me.rdNam.UseVisualStyleBackColor = True
        '
        'rdNu
        '
        Me.rdNu.AutoSize = True
        Me.rdNu.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdNu.Location = New System.Drawing.Point(78, 14)
        Me.rdNu.Name = "rdNu"
        Me.rdNu.Size = New System.Drawing.Size(48, 23)
        Me.rdNu.TabIndex = 0
        Me.rdNu.TabStop = True
        Me.rdNu.Text = "Nữ"
        Me.rdNu.UseVisualStyleBackColor = True
        '
        'rdKhac
        '
        Me.rdKhac.AutoSize = True
        Me.rdKhac.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdKhac.Location = New System.Drawing.Point(143, 14)
        Me.rdKhac.Name = "rdKhac"
        Me.rdKhac.Size = New System.Drawing.Size(60, 23)
        Me.rdKhac.TabIndex = 0
        Me.rdKhac.TabStop = True
        Me.rdKhac.Text = "Khác"
        Me.rdKhac.UseVisualStyleBackColor = True
        '
        'rdGioiTinh
        '
        Me.rdGioiTinh.Controls.Add(Me.rdKhac)
        Me.rdGioiTinh.Controls.Add(Me.rdNu)
        Me.rdGioiTinh.Controls.Add(Me.rdNam)
        Me.rdGioiTinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGioiTinh.Location = New System.Drawing.Point(159, 134)
        Me.rdGioiTinh.Name = "rdGioiTinh"
        Me.rdGioiTinh.Size = New System.Drawing.Size(219, 43)
        Me.rdGioiTinh.TabIndex = 183
        Me.rdGioiTinh.TabStop = False
        '
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 413)
        Me.Controls.Add(Me.rdGioiTinh)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTenNV)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvThongTinNV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLuu)
        Me.Name = "NhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NhanVien"
        CType(Me.dgvThongTinNV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdGioiTinh.ResumeLayout(False)
        Me.rdGioiTinh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTenNV As TextBox
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvThongTinNV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLuu As Button
    Friend WithEvents txtMatKhau As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MaNV As DataGridViewTextBoxColumn
    Friend WithEvents TenNV As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents SDT As DataGridViewTextBoxColumn
    Friend WithEvents MatKhau As DataGridViewTextBoxColumn
    Friend WithEvents rdNam As RadioButton
    Friend WithEvents rdNu As RadioButton
    Friend WithEvents rdKhac As RadioButton
    Friend WithEvents rdGioiTinh As GroupBox
End Class
