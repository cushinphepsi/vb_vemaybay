Imports System.Data.SqlClient
Public Class ThongTinKhachHang
    Private WithEvents danh_sach As BindingManagerBase
    Public lenhLoad As String = "Select * from MayBay"
    Public cmnd, tien As Integer
    Public gtinh, maChuyenBay, gio, sql, ten, sdt As String
    Private Sub ktGioiTinh()
        If rdNam.Checked = True Then
            gtinh = "Nam"
        ElseIf rdNu.Checked = True Then
            gtinh = "Nữ"
        Else
            gtinh = "Khác"
        End If
    End Sub

    Private Sub ThongTinKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maChuyenBay = DanhSachChuyenBay.maChuyenBay
        gio = (DanhSachChuyenBay.thoiGianBay).ToString()
        cmnd = DanhSachChuyenBay.cmnd
        sdt = DanhSachChuyenBay.sdt
        ten = DanhSachChuyenBay.ten
        tien = DanhSachChuyenBay.tien
    End Sub

    Private Sub btnTiepTuc_Click(sender As Object, e As EventArgs) Handles btnTiepTuc.Click
        ketNoi.Connect()
        sql = "Select * from KhachHang where CMND = '" & txtCMND.Text & "'"
        ketNoi.Excute(sql)
        Dim Data As DataTable
        Data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(Data)
        If danh_sach.Count = 0 Then
            ktGioiTinh()
            sql = "Insert into KhachHang(CMND,TenKH,GioiTinh,DiaChi,Email,SDT) 
                       values('" & txtCMND.Text & "',N'" & txtTen.Text & "',N'" & gtinh & "',
                            N'" & txtDiaChi.Text & "',N'" & txtEmail.Text & "',N'" & txtSDT.Text & "')"
            ketNoi.Excute(sql)
            sql = "Insert into VeChuyenBay(CMND,MaChuyenBay,NgayDat,ThoiGianBay,TongTien) 
                       values('" & txtCMND.Text & "','" & maChuyenBay & "', getdate(),'" & gio & "','" & tien & "') "
            ketNoi.Excute(sql)
            ThongTinChuyenBay.Show()
            Me.Close()
        Else
            sql = "Insert into VeChuyenBay(CMND,MaChuyenBay,NgayDat,ThoiGianBay,TongTien) 
                       values('" & txtCMND.Text & "','" & maChuyenBay & "', getdate(),'" & gio & "','" & tien & "') "
            ketNoi.Excute(sql)
            ThongTinChuyenBay.Show()
            Me.Close()
        End If
    End Sub
End Class