Imports System.Data.SqlClient
Public Class HangVe


    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from HangVe"
    Private Sub HangVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        dgvThongTinHV.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinHV.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaHV.Text = danh_sach.Current("MaHangVe")
        txtTenHV.Text = danh_sach.Current("TenHangVe")
        txtGiaHV.Text = danh_sach.Current("GiaHangVe")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaHV.Text = "" Or txtTenHV.Text = "" Or txtGiaHV.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = "Insert into HangVe(TenHangVe,GiaHangVe) 
                       values(N'" & txtTenHV.Text & "', N'" & txtGiaHV.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinHV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHV.DataSource)
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
            If (txtMaHV.Text = "" Or txtTenHV.Text = "" Or txtGiaHV.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = " update HangVe Set TenHangVe = N'" & txtTenHV.Text & "',GiaHangVe= N'" & txtGiaHV.Text & "'
                        where MaHangVe = '" & (txtMaHV.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinHV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHV.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaHV.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from HangVe where MaHangVe = '" & (txtMaHV.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinHV.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinHV.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtTenHV.Text = ""
        txtMaHV.Text = ""
        btnThem.Enabled = False
        btnSua.Enabled = False
        btnXoa.Enabled = False
        btnLuu.Enabled = True
        btnThoat.Enabled = False
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub btnVeDau_Click(sender As Object, e As EventArgs) Handles btnVeDau.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã về đầu danh sách")
        Else
            danh_sach.Position = 0
        End If
    End Sub
    Private Sub btnTien_Click(sender As Object, e As EventArgs) Handles btnTien.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã về cuối danh sách")
        Else
            danh_sach.Position += 1
        End If
    End Sub
    Private Sub btnVeCuoi_Click(sender As Object, e As EventArgs) Handles btnVeCuoi.Click
        If danh_sach.Position = danh_sach.Count - 1 Then
            MsgBox("Đã về cuối danh sách")
        Else
            danh_sach.Position = danh_sach.Count - 1
        End If
    End Sub
    Private Sub btnLui_Click(sender As Object, e As EventArgs) Handles btnLui.Click
        If danh_sach.Position = 0 Then
            MsgBox("Đã về đầu danh sách")
        Else
            danh_sach.Position -= 1
        End If
    End Sub
End Class