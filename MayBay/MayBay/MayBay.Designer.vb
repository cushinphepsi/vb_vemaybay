<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MayBay
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
        Me.txtTenMB = New System.Windows.Forms.TextBox()
        Me.txtMaMB = New System.Windows.Forms.TextBox()
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
        Me.dgvThongTinMB = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMaHang = New System.Windows.Forms.ComboBox()
        Me.cbSoDo = New System.Windows.Forms.ComboBox()
        Me.mamaybay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSoDo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenmaybay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvThongTinMB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenMB
        '
        Me.txtTenMB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenMB.Location = New System.Drawing.Point(104, 74)
        Me.txtTenMB.Name = "txtTenMB"
        Me.txtTenMB.Size = New System.Drawing.Size(162, 26)
        Me.txtTenMB.TabIndex = 163
        '
        'txtMaMB
        '
        Me.txtMaMB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaMB.Location = New System.Drawing.Point(104, 40)
        Me.txtMaMB.Name = "txtMaMB"
        Me.txtMaMB.Size = New System.Drawing.Size(162, 26)
        Me.txtMaMB.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tên máy bay"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mã máy bay"
        '
        'btnVeDau
        '
        Me.btnVeDau.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeDau.Location = New System.Drawing.Point(90, 159)
        Me.btnVeDau.Name = "btnVeDau"
        Me.btnVeDau.Size = New System.Drawing.Size(62, 29)
        Me.btnVeDau.TabIndex = 157
        Me.btnVeDau.Text = "l<"
        Me.btnVeDau.UseVisualStyleBackColor = True
        '
        'btnLui
        '
        Me.btnLui.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLui.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLui.Location = New System.Drawing.Point(173, 159)
        Me.btnLui.Name = "btnLui"
        Me.btnLui.Size = New System.Drawing.Size(62, 29)
        Me.btnLui.TabIndex = 158
        Me.btnLui.Text = "<"
        Me.btnLui.UseVisualStyleBackColor = True
        '
        'btnTien
        '
        Me.btnTien.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTien.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTien.Location = New System.Drawing.Point(261, 159)
        Me.btnTien.Name = "btnTien"
        Me.btnTien.Size = New System.Drawing.Size(62, 29)
        Me.btnTien.TabIndex = 160
        Me.btnTien.Text = ">"
        Me.btnTien.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(398, 118)
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
        Me.btnXoa.Location = New System.Drawing.Point(302, 118)
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
        Me.btnSua.Location = New System.Drawing.Point(205, 118)
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
        Me.btnLuu.Location = New System.Drawing.Point(112, 118)
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
        Me.btnThem.Location = New System.Drawing.Point(13, 118)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 155
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnVeCuoi
        '
        Me.btnVeCuoi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeCuoi.Location = New System.Drawing.Point(346, 159)
        Me.btnVeCuoi.Name = "btnVeCuoi"
        Me.btnVeCuoi.Size = New System.Drawing.Size(62, 29)
        Me.btnVeCuoi.TabIndex = 159
        Me.btnVeCuoi.Text = ">l"
        Me.btnVeCuoi.UseVisualStyleBackColor = True
        '
        'dgvThongTinMB
        '
        Me.dgvThongTinMB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinMB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinMB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mamaybay, Me.MaHang, Me.MaSoDo, Me.tenmaybay})
        Me.dgvThongTinMB.Location = New System.Drawing.Point(1, 206)
        Me.dgvThongTinMB.Name = "dgvThongTinMB"
        Me.dgvThongTinMB.Size = New System.Drawing.Size(547, 198)
        Me.dgvThongTinMB.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(148, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "QUẢN LÝ MÁY BAY"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(281, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Mã hãng"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(281, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 23)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Mã sơ đồ"
        '
        'cbMaHang
        '
        Me.cbMaHang.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaHang.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbMaHang.Location = New System.Drawing.Point(353, 38)
        Me.cbMaHang.Name = "cbMaHang"
        Me.cbMaHang.Size = New System.Drawing.Size(162, 25)
        Me.cbMaHang.TabIndex = 172
        '
        'cbSoDo
        '
        Me.cbSoDo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSoDo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbSoDo.Location = New System.Drawing.Point(353, 75)
        Me.cbSoDo.Name = "cbSoDo"
        Me.cbSoDo.Size = New System.Drawing.Size(162, 25)
        Me.cbSoDo.TabIndex = 172
        '
        'mamaybay
        '
        Me.mamaybay.DataPropertyName = "MaMayBay"
        Me.mamaybay.HeaderText = "Mã máy bay"
        Me.mamaybay.Name = "mamaybay"
        Me.mamaybay.Width = 120
        '
        'MaHang
        '
        Me.MaHang.DataPropertyName = "MaHang"
        Me.MaHang.HeaderText = "Mã hãng"
        Me.MaHang.Name = "MaHang"
        Me.MaHang.Width = 80
        '
        'MaSoDo
        '
        Me.MaSoDo.DataPropertyName = "MaSoDo"
        Me.MaSoDo.HeaderText = "Mã sơ đồ ghế"
        Me.MaSoDo.Name = "MaSoDo"
        '
        'tenmaybay
        '
        Me.tenmaybay.DataPropertyName = "TenMayBay"
        Me.tenmaybay.HeaderText = "Tên máy bay"
        Me.tenmaybay.Name = "tenmaybay"
        Me.tenmaybay.Width = 200
        '
        'MayBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 401)
        Me.Controls.Add(Me.cbSoDo)
        Me.Controls.Add(Me.cbMaHang)
        Me.Controls.Add(Me.txtTenMB)
        Me.Controls.Add(Me.txtMaMB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
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
        Me.Controls.Add(Me.dgvThongTinMB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MayBay"
        Me.Text = "MayBay"
        CType(Me.dgvThongTinMB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTenMB As TextBox
    Friend WithEvents txtMaMB As TextBox
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
    Friend WithEvents dgvThongTinMB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbMaHang As ComboBox
    Friend WithEvents cbSoDo As ComboBox
    Friend WithEvents mamaybay As DataGridViewTextBoxColumn
    Friend WithEvents MaHang As DataGridViewTextBoxColumn
    Friend WithEvents MaSoDo As DataGridViewTextBoxColumn
    Friend WithEvents tenmaybay As DataGridViewTextBoxColumn
End Class
