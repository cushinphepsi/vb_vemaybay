<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChuyenBay
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
        Me.dgvThongTinCB = New System.Windows.Forms.DataGridView()
        Me.txtTien = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGioDi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaCB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGioDen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbMaTB = New System.Windows.Forms.ComboBox()
        Me.cbMaMB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaChuyenBay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaTuyenBay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMayBay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayKhoiHanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayDen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioDi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioDen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpNgayDi = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayDen = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvThongTinCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvThongTinCB
        '
        Me.dgvThongTinCB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinCB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaChuyenBay, Me.MaTuyenBay, Me.MaMayBay, Me.NgayKhoiHanh, Me.NgayDen, Me.GioDi, Me.GioDen, Me.TongTien})
        Me.dgvThongTinCB.Location = New System.Drawing.Point(0, 214)
        Me.dgvThongTinCB.Name = "dgvThongTinCB"
        Me.dgvThongTinCB.Size = New System.Drawing.Size(765, 220)
        Me.dgvThongTinCB.TabIndex = 78
        '
        'txtTien
        '
        Me.txtTien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTien.Location = New System.Drawing.Point(481, 77)
        Me.txtTien.Name = "txtTien"
        Me.txtTien.Size = New System.Drawing.Size(219, 26)
        Me.txtTien.TabIndex = 190
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(375, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 23)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "Số tiền"
        '
        'txtGioDi
        '
        Me.txtGioDi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGioDi.Location = New System.Drawing.Point(144, 109)
        Me.txtGioDi.Name = "txtGioDi"
        Me.txtGioDi.Size = New System.Drawing.Size(219, 26)
        Me.txtGioDi.TabIndex = 187
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(39, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 186
        Me.Label4.Text = "Giờ đi"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(375, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 23)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Mã tuyến bay"
        '
        'txtMaCB
        '
        Me.txtMaCB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaCB.Location = New System.Drawing.Point(144, 43)
        Me.txtMaCB.Name = "txtMaCB"
        Me.txtMaCB.Size = New System.Drawing.Size(219, 26)
        Me.txtMaCB.TabIndex = 184
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(39, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Mã máy bay"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(39, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Mã chuyến bay"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(525, 177)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 31)
        Me.btnThoat.TabIndex = 176
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXoa.Location = New System.Drawing.Point(429, 177)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(78, 31)
        Me.btnXoa.TabIndex = 172
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnSua.Location = New System.Drawing.Point(332, 177)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 173
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(239, 177)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 174
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(140, 177)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 175
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(253, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 24)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "QUẢN LÝ CHUYẾN BAY"
        '
        'txtGioDen
        '
        Me.txtGioDen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGioDen.Location = New System.Drawing.Point(481, 109)
        Me.txtGioDen.Name = "txtGioDen"
        Me.txtGioDen.Size = New System.Drawing.Size(219, 26)
        Me.txtGioDen.TabIndex = 192
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label7.Location = New System.Drawing.Point(375, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Giờ đến"
        '
        'cbMaTB
        '
        Me.cbMaTB.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbMaTB.Location = New System.Drawing.Point(481, 42)
        Me.cbMaTB.Name = "cbMaTB"
        Me.cbMaTB.Size = New System.Drawing.Size(219, 25)
        Me.cbMaTB.TabIndex = 193
        '
        'cbMaMB
        '
        Me.cbMaMB.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaMB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbMaMB.Location = New System.Drawing.Point(144, 77)
        Me.cbMaMB.Name = "cbMaMB"
        Me.cbMaMB.Size = New System.Drawing.Size(219, 25)
        Me.cbMaMB.TabIndex = 193
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label8.Location = New System.Drawing.Point(39, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 23)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "Ngày khởi hành"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label9.Location = New System.Drawing.Point(375, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 23)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Ngày đến"
        '
        'MaChuyenBay
        '
        Me.MaChuyenBay.DataPropertyName = "MaChuyenBay"
        Me.MaChuyenBay.HeaderText = "Mã chuyến bay"
        Me.MaChuyenBay.Name = "MaChuyenBay"
        Me.MaChuyenBay.Width = 105
        '
        'MaTuyenBay
        '
        Me.MaTuyenBay.DataPropertyName = "MaTuyenBay"
        Me.MaTuyenBay.HeaderText = "Mã tuyến bay"
        Me.MaTuyenBay.Name = "MaTuyenBay"
        '
        'MaMayBay
        '
        Me.MaMayBay.DataPropertyName = "MaMayBay"
        Me.MaMayBay.HeaderText = "Mã máy bay"
        Me.MaMayBay.Name = "MaMayBay"
        '
        'NgayKhoiHanh
        '
        Me.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh"
        Me.NgayKhoiHanh.HeaderText = "Ngày khởi hành"
        Me.NgayKhoiHanh.Name = "NgayKhoiHanh"
        Me.NgayKhoiHanh.Width = 105
        '
        'NgayDen
        '
        Me.NgayDen.DataPropertyName = "NgayDen"
        Me.NgayDen.HeaderText = "Ngày đến"
        Me.NgayDen.Name = "NgayDen"
        Me.NgayDen.Width = 80
        '
        'GioDi
        '
        Me.GioDi.DataPropertyName = "GioDi"
        Me.GioDi.HeaderText = "Giờ đi"
        Me.GioDi.Name = "GioDi"
        Me.GioDi.Width = 70
        '
        'GioDen
        '
        Me.GioDen.DataPropertyName = "GioDen"
        Me.GioDen.HeaderText = "Giờ đến"
        Me.GioDen.Name = "GioDen"
        Me.GioDen.Width = 70
        '
        'TongTien
        '
        Me.TongTien.DataPropertyName = "TongTien"
        Me.TongTien.HeaderText = "Số tiền"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.Width = 70
        '
        'dtpNgayDi
        '
        Me.dtpNgayDi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayDi.Location = New System.Drawing.Point(144, 141)
        Me.dtpNgayDi.Name = "dtpNgayDi"
        Me.dtpNgayDi.Size = New System.Drawing.Size(219, 22)
        Me.dtpNgayDi.TabIndex = 194
        '
        'dtpNgayDen
        '
        Me.dtpNgayDen.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayDen.Location = New System.Drawing.Point(481, 141)
        Me.dtpNgayDen.Name = "dtpNgayDen"
        Me.dtpNgayDen.Size = New System.Drawing.Size(219, 22)
        Me.dtpNgayDen.TabIndex = 195
        '
        'ChuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 436)
        Me.Controls.Add(Me.dtpNgayDen)
        Me.Controls.Add(Me.dtpNgayDi)
        Me.Controls.Add(Me.cbMaMB)
        Me.Controls.Add(Me.cbMaTB)
        Me.Controls.Add(Me.txtGioDen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTien)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGioDi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvThongTinCB)
        Me.Name = "ChuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chuyến bay"
        CType(Me.dgvThongTinCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvThongTinCB As DataGridView
    Friend WithEvents txtTien As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGioDi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaCB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGioDen As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbMaTB As ComboBox
    Friend WithEvents cbMaMB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MaChuyenBay As DataGridViewTextBoxColumn
    Friend WithEvents MaTuyenBay As DataGridViewTextBoxColumn
    Friend WithEvents MaMayBay As DataGridViewTextBoxColumn
    Friend WithEvents NgayKhoiHanh As DataGridViewTextBoxColumn
    Friend WithEvents NgayDen As DataGridViewTextBoxColumn
    Friend WithEvents GioDi As DataGridViewTextBoxColumn
    Friend WithEvents GioDen As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents dtpNgayDi As DateTimePicker
    Friend WithEvents dtpNgayDen As DateTimePicker
End Class
