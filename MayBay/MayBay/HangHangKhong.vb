Imports System.Data.SqlClient
Public Class HangHangKhong

    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from HangHangKhong"
    Private Sub HangVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        dgvThongTinHHK.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinHHK.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaHang.Text = danh_sach.Current("MaHang")
        txtTenHang.Text = danh_sach.Current("TenHang")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaHang.Text = "" Or txtTenHang.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = "Insert into HangHangKhong(MaHang,TenHang) 
                       values('" & txtMaHang.Text & "', N'" & txtTenHang.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinHHK.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHHK.DataSource)
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
            If (txtMaHang.Text = "" Or txtTenHang.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = " update HangHangKhong Set TenHang = N'" & txtTenHang.Text & "'
                        where MaHang = '" & (txtMaHang.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinHHK.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHHK.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaHang.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from HangHangKhong where MaHang = '" & (txtMaHang.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinHHK.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHHK.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtTenHang.Text = ""
        txtMaHang.Text = ""
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