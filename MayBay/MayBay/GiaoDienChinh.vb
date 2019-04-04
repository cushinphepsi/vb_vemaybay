Public Class GiaoDienChinh
    Private Sub menuDangXuat_Click(sender As Object, e As EventArgs) Handles menuDangXuat.Click
        If maNV = "" Then
            If MsgBox("Bạn chưa đăng nhập. Bạn có muốn đăng nhập để tiếp tục", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                DangNhap.Show()
            End If
        Else
            maNV = ""
            MsgBox("Đăng xuất thành công")
        End If
    End Sub

    Private Sub menuDangNhap_Click(sender As Object, e As EventArgs) Handles menuDangNhap.Click
        DangNhap.Show()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        TimKiemChuyenBay.Show()
    End Sub

    Private Sub menuSanBay_Click(sender As Object, e As EventArgs)
        SanBay.Show()
    End Sub

    Private Sub menuChuyenBay_Click(sender As Object, e As EventArgs) Handles menuChuyenBay.Click
        ChuyenBay.Show()
    End Sub

    Private Sub menuTuyenBay_Click(sender As Object, e As EventArgs) Handles menuTuyenBay.Click
        TuyenBay.Show()
    End Sub

    Private Sub menuNhanVien_Click(sender As Object, e As EventArgs) Handles menuNhanVien.Click
        NhanVien.Show()
    End Sub

    Private Sub menuHangVe_Click(sender As Object, e As EventArgs)
        HangVe.Show()
    End Sub

    Private Sub menuHangHangKhong_Click(sender As Object, e As EventArgs) Handles menuHangHangKhong.Click
        HangHangKhong.Show()
    End Sub

    Private Sub menuMayBay_Click(sender As Object, e As EventArgs) Handles menuMayBay.Click
        MayBay.Show()
    End Sub

    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        If maNV = "" Then
            If MsgBox("Bạn chưa đăng nhập. Bạn có muốn đăng nhập để tiếp tục", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                DangNhap.Show()
            End If
        Else
            ThanhToan.Show()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        TraCuuLichBay.Show()
    End Sub

    Private Sub btnXemBaoCao_Click(sender As Object, e As EventArgs) Handles btnXemBaoCao.Click
        If maNV = "" Then
            If MsgBox("Bạn chưa đăng nhập. Bạn có muốn đăng nhập để tiếp tục", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                DangNhap.Show()
            End If
        Else
            XemDoanhThu.Show()
        End If
    End Sub
    Private Sub btnChonGhe_Click(sender As Object, e As EventArgs) Handles btnChonGhe.Click
        ChonChoNgoi.Show()
    End Sub
    Private Sub btnDoiChuyenBay_Click(sender As Object, e As EventArgs) Handles btnDoiChuyenBay.Click
        If maNV = "" Then
            If MsgBox("Bạn chưa đăng nhập. Bạn có muốn đăng nhập để tiếp tục", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                DangNhap.Show()
            End If
        Else
            DoiChuyenBay.Show()
        End If
    End Sub

    Private Sub btnXemMaVe_Click(sender As Object, e As EventArgs) Handles btnXemMaVe.Click
        XemMaDatCho.Show()
    End Sub
End Class
