<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiaoDienChinh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiaoDienChinh))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDangNhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýVéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuChuyenBay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTuyenBay = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuNhanVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHangHangKhong = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuMayBay = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnTraCuu = New System.Windows.Forms.Button()
        Me.btnDoiChuyenBay = New System.Windows.Forms.Button()
        Me.btnChonGhe = New System.Windows.Forms.Button()
        Me.btnXemMaVe = New System.Windows.Forms.Button()
        Me.btnXemBaoCao = New System.Windows.Forms.Button()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.QuảnLýVéToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(786, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuDangNhap, Me.menuDangXuat})
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'menuDangNhap
        '
        Me.menuDangNhap.Name = "menuDangNhap"
        Me.menuDangNhap.Size = New System.Drawing.Size(152, 22)
        Me.menuDangNhap.Text = "Đăng nhập"
        '
        'menuDangXuat
        '
        Me.menuDangXuat.Name = "menuDangXuat"
        Me.menuDangXuat.Size = New System.Drawing.Size(152, 22)
        Me.menuDangXuat.Text = "Đăng xuất"
        '
        'QuảnLýVéToolStripMenuItem
        '
        Me.QuảnLýVéToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuChuyenBay, Me.menuTuyenBay, Me.menuNhanVien, Me.menuHangHangKhong, Me.menuMayBay})
        Me.QuảnLýVéToolStripMenuItem.Name = "QuảnLýVéToolStripMenuItem"
        Me.QuảnLýVéToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýVéToolStripMenuItem.Text = "Quản lý"
        '
        'menuChuyenBay
        '
        Me.menuChuyenBay.Name = "menuChuyenBay"
        Me.menuChuyenBay.Size = New System.Drawing.Size(173, 22)
        Me.menuChuyenBay.Text = "Chuyến Bay"
        '
        'menuTuyenBay
        '
        Me.menuTuyenBay.Name = "menuTuyenBay"
        Me.menuTuyenBay.Size = New System.Drawing.Size(173, 22)
        Me.menuTuyenBay.Text = "Tuyến Bay"
        '
        'menuNhanVien
        '
        Me.menuNhanVien.Name = "menuNhanVien"
        Me.menuNhanVien.Size = New System.Drawing.Size(173, 22)
        Me.menuNhanVien.Text = "Nhân Viên"
        '
        'menuHangHangKhong
        '
        Me.menuHangHangKhong.Name = "menuHangHangKhong"
        Me.menuHangHangKhong.Size = New System.Drawing.Size(173, 22)
        Me.menuHangHangKhong.Text = "Hãng Hàng Không"
        '
        'menuMayBay
        '
        Me.menuMayBay.Name = "menuMayBay"
        Me.menuMayBay.Size = New System.Drawing.Size(173, 22)
        Me.menuMayBay.Text = "Máy Bay"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnTraCuu)
        Me.GroupBox1.Controls.Add(Me.btnDoiChuyenBay)
        Me.GroupBox1.Controls.Add(Me.btnChonGhe)
        Me.GroupBox1.Controls.Add(Me.btnXemMaVe)
        Me.GroupBox1.Controls.Add(Me.btnXemBaoCao)
        Me.GroupBox1.Controls.Add(Me.btnThanhToan)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 340)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chức năng"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(3, 301)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(170, 34)
        Me.btnThoat.TabIndex = 0
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnTraCuu
        '
        Me.btnTraCuu.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraCuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTraCuu.Location = New System.Drawing.Point(3, 219)
        Me.btnTraCuu.Name = "btnTraCuu"
        Me.btnTraCuu.Size = New System.Drawing.Size(170, 34)
        Me.btnTraCuu.TabIndex = 0
        Me.btnTraCuu.Text = "Tra cứu lịch bay"
        Me.btnTraCuu.UseVisualStyleBackColor = True
        '
        'btnDoiChuyenBay
        '
        Me.btnDoiChuyenBay.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoiChuyenBay.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnDoiChuyenBay.Location = New System.Drawing.Point(3, 98)
        Me.btnDoiChuyenBay.Name = "btnDoiChuyenBay"
        Me.btnDoiChuyenBay.Size = New System.Drawing.Size(170, 34)
        Me.btnDoiChuyenBay.TabIndex = 0
        Me.btnDoiChuyenBay.Text = "Đổi chuyến bay"
        Me.btnDoiChuyenBay.UseVisualStyleBackColor = True
        '
        'btnChonGhe
        '
        Me.btnChonGhe.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChonGhe.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnChonGhe.Location = New System.Drawing.Point(3, 139)
        Me.btnChonGhe.Name = "btnChonGhe"
        Me.btnChonGhe.Size = New System.Drawing.Size(170, 34)
        Me.btnChonGhe.TabIndex = 0
        Me.btnChonGhe.Text = "Chọn và đổi ghế"
        Me.btnChonGhe.UseVisualStyleBackColor = True
        '
        'btnXemMaVe
        '
        Me.btnXemMaVe.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXemMaVe.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXemMaVe.Location = New System.Drawing.Point(3, 58)
        Me.btnXemMaVe.Name = "btnXemMaVe"
        Me.btnXemMaVe.Size = New System.Drawing.Size(170, 34)
        Me.btnXemMaVe.TabIndex = 0
        Me.btnXemMaVe.Text = "Xem mã đặt chỗ"
        Me.btnXemMaVe.UseVisualStyleBackColor = True
        '
        'btnXemBaoCao
        '
        Me.btnXemBaoCao.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXemBaoCao.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXemBaoCao.Location = New System.Drawing.Point(3, 261)
        Me.btnXemBaoCao.Name = "btnXemBaoCao"
        Me.btnXemBaoCao.Size = New System.Drawing.Size(170, 34)
        Me.btnXemBaoCao.TabIndex = 0
        Me.btnXemBaoCao.Text = "Xem báo cáo"
        Me.btnXemBaoCao.UseVisualStyleBackColor = True
        '
        'btnThanhToan
        '
        Me.btnThanhToan.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThanhToan.Location = New System.Drawing.Point(3, 179)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(170, 34)
        Me.btnThanhToan.TabIndex = 0
        Me.btnThanhToan.Text = "Thanh Toán"
        Me.btnThanhToan.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTimKiem.Location = New System.Drawing.Point(3, 20)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(170, 34)
        Me.btnTimKiem.TabIndex = 0
        Me.btnTimKiem.Text = "Tìm kiếm chuyến bay"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(210, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Chào mừng bạn đến với phòng vé máy bay Huy Đức"
        '
        'GiaoDienChinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(786, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GiaoDienChinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giao diện chính"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HệThốngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuDangNhap As ToolStripMenuItem
    Friend WithEvents menuDangXuat As ToolStripMenuItem
    Friend WithEvents QuảnLýVéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXemMaVe As Button
    Friend WithEvents btnXemBaoCao As Button
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnTraCuu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents menuChuyenBay As ToolStripMenuItem
    Friend WithEvents menuTuyenBay As ToolStripMenuItem
    Friend WithEvents menuNhanVien As ToolStripMenuItem
    Friend WithEvents menuHangHangKhong As ToolStripMenuItem
    Friend WithEvents menuMayBay As ToolStripMenuItem
    Friend WithEvents btnChonGhe As Button
    Friend WithEvents btnDoiChuyenBay As Button
End Class
