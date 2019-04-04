Imports System.Data.SqlClient
Public Class MayBay

    Private WithEvents danh_sach, ds As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from MayBay"
    Private Sub MayBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        sql = "Select MaSoDo from SoDoGhe"
        dgvThongTinMB.DataSource = ketNoi.LoadDataTable(sql)
        ds = Me.BindingContext(dgvThongTinMB.DataSource)

        cbSoDo.Text = ds.Current("MaSoDo")
        For i = 0 To ds.Count - 1
            ds.Position = i
            cbSoDo.Items.Add(ds.Current("MaSoDo"))
        Next

        sql = "Select MaHang from HangHangKhong"
        dgvThongTinMB.DataSource = ketNoi.LoadDataTable(sql)
        ds = Me.BindingContext(dgvThongTinMB.DataSource)
        cbMaHang.Text = ds.Current("MaHang")
        For i = 0 To ds.Count - 1
            ds.Position = i
            cbMaHang.Items.Add(ds.Current("MaHang"))
        Next

        dgvThongTinMB.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinMB.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaMB.Text = danh_sach.Current("MaMayBay")
        cbMaHang.Text = danh_sach.Current("MaHang")
        txtTenMB.Text = danh_sach.Current("TenMayBay")
        cbSoDo.Text = danh_sach.Current("MaSoDo")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaMB.Text = "" Or cbMaHang.Text = "" Or txtTenMB.Text = "" Or cbSoDo.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = "Insert into MayBay(MaMayBay,MaHang,TenMayBay,MaSoDo) 
                       values(N'" & txtMaMB.Text & "','" & cbMaHang.Text & "', N'" & txtTenMB.Text & "','" & cbSoDo.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinMB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinMB.DataSource)
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
            If (txtMaMB.Text = "" Or cbMaHang.Text = "" Or txtTenMB.Text = "" Or cbSoDo.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = " update MayBay Set MaMayBay= '" & txtMaMB.Text & "',MaHang= '" & cbMaHang.Text & "',
                        TenMayBay= N'" & txtTenMB.Text & "' ,MaSoDo= '" & cbSoDo.Text & "' 
                        where MaMayBay = '" & (txtMaMB.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinMB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinMB.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaMB.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from MayBay where MaMayBay = '" & (txtMaMB.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinMB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinMB.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        cbMaHang.Text = ""
        txtMaMB.Text = ""
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