Imports System.Data.SqlClient
Public Class SanBay

    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from SanBay"
    Private Sub SanBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        dgvThongTinSB.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinSB.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaSanBay.Text = danh_sach.Current("MaSanBay")
        txtTenSanBay.Text = danh_sach.Current("TenSanBay")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaSanBay.Text = "" Or txtTenSanBay.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = "Insert into SanBay(MaSanBay,TenSanBay) 
                       values('" & txtMaSanBay.Text & "',N'" & txtTenSanBay.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinSB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinSB.DataSource)
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
            If (txtMaSanBay.Text = "" Or txtTenSanBay.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = " update SanBay Set MaSanBay= '" & txtMaSanBay.Text & "',TenSanBay= '" & txtTenSanBay.Text & "' 
                        where MaSanBay = '" & (txtMaSanBay.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinSB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinSB.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaSanBay.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from SanBay where MaSanBay = '" & (txtMaSanBay.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinSB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinSB.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtMaSanBay.Text = ""
        txtTenSanBay.Text = ""
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