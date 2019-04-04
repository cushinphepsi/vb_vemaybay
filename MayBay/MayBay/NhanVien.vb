Imports System.Data.SqlClient
Public Class NhanVien

    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from NhanVien"
    Public gtinh As String
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        dgvThongTinNV.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinNV.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaNV.Text = danh_sach.Current("MaNV")
        txtTenNV.Text = danh_sach.Current("TenNV")
        txtDienThoai.Text = danh_sach.Current("SDT")
        txtDiaChi.Text = danh_sach.Current("DiaChi")
        txtEmail.Text = danh_sach.Current("Email")
        txtMatKhau.Text = danh_sach.Current("MatKhau")
        gtinh = danh_sach.Current("GioiTinh")
        If gtinh = "Nam" Then
            rdNam.Checked = True
        ElseIf gtinh = "Nữ" Then
            rdNu.Checked = True
        Else
            rdKhac.Checked = True
        End If
    End Sub
    Private Sub ktGioiTinh()
        If rdNam.Checked = True Then
            gtinh = "Nam"
        ElseIf rdNu.Checked = True Then
            gtinh = "Nữ"
        Else
            gtinh = "Khác"
        End If
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtTenNV.Text = "" Or txtDienThoai.Text = "" Or txtDiaChi.Text = "" Or
                txtEmail.Text = "" Or txtMatKhau.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                ktGioiTinh()
                sql = "Insert into NhanVien(TenNV,GioiTinh,DiaChi,Email,SDT,MatKhau) 
                       values(N'" & txtTenNV.Text & "',N'" & gtinh & "',
                                N'" & txtDiaChi.Text & "','" & txtEmail.Text & "','" & txtDienThoai.Text & "',
                                '" & txtMatKhau.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinNV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinNV.DataSource)
                MsgBox("Thêm thành công !")
                btnThem.Enabled = True
                btnSua.Enabled = True
                btnXoa.Enabled = True
                btnLuu.Enabled = False
                btnThoat.Enabled = True
            End If
        End If
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If MsgBox("Bạn có muốn sửa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaNV.Text = "" Or txtTenNV.Text = "" Or txtDienThoai.Text = "" Or txtDiaChi.Text = "" Or
                txtEmail.Text = "" Or txtMatKhau.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                ktGioiTinh()
                sql = " update NhanVien Set TenNV= N'" & txtTenNV.Text & "', GioiTinh= N'" & gtinh & "',
                        DiaChi= N'" & txtDiaChi.Text & "' ,Email= '" & txtEmail.Text & "' ,
                        SDT= '" & txtDienThoai.Text & "' ,MatKhau= '" & txtMatKhau.Text & "' 
                        where MaNV = '" & (txtMaNV.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinNV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinNV.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaNV.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from NhanVien where MaNV = '" & (txtMaNV.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinNV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinNV.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtMaNV.Text = ""
        txtTenNV.Text = ""
        btnThem.Enabled = False
        btnSua.Enabled = False
        btnXoa.Enabled = False
        btnLuu.Enabled = True
        btnThoat.Enabled = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class