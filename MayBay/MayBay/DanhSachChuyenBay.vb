Imports System.Data.SqlClient
Public Class DanhSachChuyenBay

    Private WithEvents danh_sach, ds As BindingManagerBase
    Public sql, ten, sdt, maChuyenBay, dk, kq, gio As String
    Public cmnd, maVe, tien As Integer
    Public thoiGianBay As TimeSpan
    Private Sub DanhSachChuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sdt = TimKiemChuyenBay.sdt
        ten = TimKiemChuyenBay.ten
        cmnd = TimKiemChuyenBay.cmnd
        maVe = TimKiemChuyenBay.maVe
        ketNoi.Connect()
        If TimKiemChuyenBay.ngayDen = "" Then
            dk = " SanBayDi = N'" & TimKiemChuyenBay.noiDi & "' and SanBayDen = N'" & TimKiemChuyenBay.noiDen & "' 
                              and NgayKhoiHanh = '" & TimKiemChuyenBay.ngayDi & "' "
        Else
            sql = "Select MaChuyenBay,TenHang,GioDi,SanBayDi,GioDen,SanBayDen,TongTien,convert(varchar, NgayKhoiHanh , 103) as NgayKhoiHanh  
                        from TuyenBay tb inner join ChuyenBay cb on tb.MaTuyenBay = cb.MaTuyenBay
                        inner join MayBay mb on mb.MaMayBay = cb.MaMayBay
                        inner join HangHangKhong hhk on mb.MaHang = hhk.MaHang
                        where SanBayDi = N'" & TimKiemChuyenBay.noiDen & "' and SanBayDen = N'" & TimKiemChuyenBay.noiDi & "' 
                              and NgayKhoiHanh = '" & TimKiemChuyenBay.ngayDen & "' "
            Dim data As DataTable
            data = ketNoi.LoadDataTable(sql)
            danh_sach = Me.BindingContext(data)
            If danh_sach.Count = 0 Then
                kq = "No"
                dk = " SanBayDi = N'" & TimKiemChuyenBay.noiDi & "' and SanBayDen = N'" & TimKiemChuyenBay.noiDen & "' 
                              and NgayKhoiHanh = '" & TimKiemChuyenBay.ngayDi & "' "
            Else
                dk = " SanBayDi = N'" & TimKiemChuyenBay.noiDen & "' and SanBayDen = N'" & TimKiemChuyenBay.noiDi & "' 
                              and NgayKhoiHanh = '" & TimKiemChuyenBay.ngayDen & "' union
                   Select MaChuyenBay,TenHang,GioDi,SanBayDi,GioDen,SanBayDen,TongTien,convert(varchar, NgayKhoiHanh , 103) as NgayKhoiHanh  
                        from TuyenBay tb inner join ChuyenBay cb on tb.MaTuyenBay = cb.MaTuyenBay
                        inner join MayBay mb on mb.MaMayBay = cb.MaMayBay
                        inner join HangHangKhong hhk on mb.MaHang = hhk.MaHang
                        where SanBayDi = N'" & TimKiemChuyenBay.noiDi & "' and SanBayDen = N'" & TimKiemChuyenBay.noiDen & "' 
                              and NgayKhoiHanh = '" & TimKiemChuyenBay.ngayDi & "' order by NgayKhoiHanh"
            End If
        End If
        sql = "Select MaChuyenBay,TenHang,GioDi,SanBayDi,GioDen,SanBayDen,TongTien,convert(varchar, NgayKhoiHanh , 103) as NgayKhoiHanh  
                        from TuyenBay tb inner join ChuyenBay cb on tb.MaTuyenBay = cb.MaTuyenBay
                        inner join MayBay mb on mb.MaMayBay = cb.MaMayBay
                        inner join HangHangKhong hhk on mb.MaHang = hhk.MaHang
                        where " & dk & " "
        dgvDanhSachCB.DataSource = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(dgvDanhSachCB.DataSource)
        If danh_sach.Count = 0 Then
            MsgBox("Không có chuyến bay này")
            Me.Close()
        ElseIf kq = "No" Then
            MsgBox("Chuyến bay này chỉ có một chiều , không có khứ hồi")
            Xuat()
            TimKiemChuyenBay.Close()
        Else
            Xuat()
            TimKiemChuyenBay.Close()
        End If

    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TimKiemChuyenBay.Show()
        Me.Close()
    End Sub

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        If doiCB = "Yes" Then
            gio = thoiGianBay.ToString()
            sql = "Select MaVe from NhatKyThanhToan where MaVe = '" & maVe & "' "
            Dim data As DataTable
            data = ketNoi.LoadDataTable(sql)
            danh_sach = Me.BindingContext(data)
            If danh_sach.Count = 0 Then
                sql = "Delete from VeChuyenBay where MaVe = '" & maVe & "' "
                ketNoi.Excute(sql)

                sql = "Insert into VeChuyenBay(CMND,MaChuyenBay,NgayDat,ThoiGianBay,TongTien) 
                       values('" & cmnd & "','" & maChuyenBay & "', getdate(),'" & gio & "','" & tien & "') "
                ketNoi.Excute(sql)
                ThongTinChuyenBay.Show()
                Me.Close()
            Else
                If MsgBox("Bạn phải thanh toán thêm 300000đ để đổi vé . Bạn có muốn tiếp tục ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes Then
                    sql = "Delete from NhatKyThanhToan where MaVe = '" & maVe & "' "
                    ketNoi.Excute(sql)
                    sql = "Delete from VeChuyenBay where MaVe = '" & maVe & "' "
                    ketNoi.Excute(sql)

                    sql = "Insert into VeChuyenBay(CMND,MaChuyenBay,NgayDat,ThoiGianBay,TongTien) 
                       values('" & cmnd & "','" & maChuyenBay & "', getdate(),'" & gio & "','" & tien & "') "
                    ketNoi.Excute(sql)

                    sql = "Select * from VeChuyenBay where CMND = '" & cmnd & "' and MaChuyenBay = '" & maChuyenBay & "' 
                    and ThoiGianBay = '" & gio & "' "
                    data = ketNoi.LoadDataTable(sql)
                    ds = Me.BindingContext(data)
                    Dim veCB As Integer = ds.Current("MaVe")
                    sql = "Insert into NhatKyThanhToan(MaNV,MaVe,TongTien,TrangThai,NgayThanhToan) 
                       values('" & maNV & "','" & veCB & "','" & tien + 300000 & "', N'Đã thanh toán',getdate()) "
                    ketNoi.Excute(sql)
                    ThongTinChuyenBay.Show()
                    Me.Close()
                Else
                End If
            End If
        Else
            ThongTinKhachHang.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Xuat()
        maChuyenBay = danh_sach.Current("MaChuyenBay")
        danh_sach.Current("GioDi").ToString()
        danh_sach.Current("GioDen").ToString()
        thoiGianBay = danh_sach.Current("GioDen") - danh_sach.Current("GioDi")
        tien = danh_sach.Current("TongTien")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub


End Class