<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangHangKhong
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
        Me.txtTenHang = New System.Windows.Forms.TextBox()
        Me.txtMaHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvThongTinHHK = New System.Windows.Forms.DataGridView()
        Me.mahang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenhang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvThongTinHHK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenHang
        '
        Me.txtTenHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenHang.Location = New System.Drawing.Point(154, 77)
        Me.txtTenHang.Name = "txtTenHang"
        Me.txtTenHang.Size = New System.Drawing.Size(219, 26)
        Me.txtTenHang.TabIndex = 163
        '
        'txtMaHang
        '
        Me.txtMaHang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHang.Location = New System.Drawing.Point(154, 43)
        Me.txtMaHang.Name = "txtMaHang"
        Me.txtMaHang.Size = New System.Drawing.Size(219, 26)
        Me.txtMaHang.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(73, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tên hãng"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(73, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mã hãng"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(402, 121)
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
        Me.btnXoa.Location = New System.Drawing.Point(306, 121)
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
        Me.btnSua.Location = New System.Drawing.Point(209, 121)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 153
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(116, 121)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 154
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(17, 121)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 155
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvThongTinHHK
        '
        Me.dgvThongTinHHK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinHHK.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinHHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinHHK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mahang, Me.tenhang})
        Me.dgvThongTinHHK.Location = New System.Drawing.Point(1, 169)
        Me.dgvThongTinHHK.Name = "dgvThongTinHHK"
        Me.dgvThongTinHHK.Size = New System.Drawing.Size(489, 192)
        Me.dgvThongTinHHK.TabIndex = 151
        '
        'mahang
        '
        Me.mahang.DataPropertyName = "MaHang"
        Me.mahang.HeaderText = "Mã hãng hàng không"
        Me.mahang.Name = "mahang"
        Me.mahang.Width = 200
        '
        'tenhang
        '
        Me.tenhang.DataPropertyName = "TenHang"
        Me.tenhang.HeaderText = "Tên hãng hàng không"
        Me.tenhang.Name = "tenhang"
        Me.tenhang.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(96, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "QUẢN LÝ HÃNG HÀNG KHÔNG"
        '
        'HangHangKhong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 357)
        Me.Controls.Add(Me.txtTenHang)
        Me.Controls.Add(Me.txtMaHang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvThongTinHHK)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HangHangKhong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hãng hàng không"
        CType(Me.dgvThongTinHHK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTenHang As TextBox
    Friend WithEvents txtMaHang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvThongTinHHK As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents mahang As DataGridViewTextBoxColumn
    Friend WithEvents tenhang As DataGridViewTextBoxColumn
End Class
