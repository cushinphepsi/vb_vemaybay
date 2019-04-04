Imports System.Data.SqlClient
Public Class ThongTinChuyenBay
    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String

    Private Sub DatCho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maChuyenBay, gio As String
        Dim cmnd As Integer
        If doiCB = "Yes" Then
            cmnd = DanhSachChuyenBay.cmnd
            gio = DanhSachChuyenBay.gio
            maChuyenBay = DanhSachChuyenBay.maChuyenBay
        Else
            gio = ThongTinKhachHang.gio
            maChuyenBay = ThongTinKhachHang.maChuyenBay
            cmnd = ThongTinKhachHang.txtCMND.Text
        End If
        sql = "Select MaVe , convert(varchar, NgayDat , 103) as NgayDat ,TenHang,SanBayDi,SanBayDen,GioDi,GioDen,kh.CMND,TenKH,vecb.TongTien 
               from KhachHang kh inner join VeChuyenBay vecb on kh.CMND = vecb.CMND 
                 inner join ChuyenBay cb on vecb.MaChuyenBay = cb.MaChuyenBay
                 inner join TuyenBay tb  on tb.MaTuyenBay = cb.MaTuyenBay
                 inner join MayBay mb on mb.MaMayBay = cb.MaMayBay
                 inner join HangHangKhong hhk on mb.MaHang = hhk.MaHang
               where vecb.CMND = '" & cmnd & "'  and vecb.MaChuyenBay = '" & maChuyenBay & "' and ThoiGianBay = '" & gio & "' "
        ketNoi.Connect()
        Dim data As DataTable
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        txtMaVe.Text = danh_sach.Current("MaVe")
        txtTen.Text = danh_sach.Current("TenKH")
        txtCMND.Text = danh_sach.Current("CMND")
        txtHang.Text = danh_sach.Current("TenHang")
        dtpNgayDat.Text = danh_sach.Current("NgayDat")
        txtTien.Text = danh_sach.Current("TongTien")
        txtNoiDi.Text = danh_sach.Current("SanBayDi")
        txtNoiDen.Text = danh_sach.Current("SanBayDen")
        txtGioDen.Text = danh_sach.Current("GioDen").ToString
        txtGioDi.Text = danh_sach.Current("GioDi").ToString
    End Sub

    Private Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        Me.Close()
    End Sub
End Class