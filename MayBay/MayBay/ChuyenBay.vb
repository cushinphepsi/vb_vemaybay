Imports System.Data.SqlClient
Public Class ChuyenBay

    Private WithEvents danh_sach, ds As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from ChuyenBay"
    Private Sub ChuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        sql = "Select MaMayBay from MayBay"
        dgvThongTinCB.DataSource = ketNoi.LoadDataTable(sql)
        ds = Me.BindingContext(dgvThongTinCB.DataSource)
        cbMaMB.Text = ds.Current("MaMayBay")
        For i = 0 To ds.Count - 1
            ds.Position = i
            cbMaMB.Items.Add(ds.Current("MaMayBay"))
        Next

        sql = "Select MaTuyenBay from TuyenBay"
        dgvThongTinCB.DataSource = ketNoi.LoadDataTable(sql)
        ds = Me.BindingContext(dgvThongTinCB.DataSource)
        cbMaTB.Text = ds.Current("MaTuyenBay")
        For i = 0 To ds.Count - 1
            ds.Position = i
            cbMaTB.Items.Add(ds.Current("MaTuyenBay"))
        Next

        dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaCB.Text = danh_sach.Current("MaChuyenBay")
        cbMaMB.Text = danh_sach.Current("MaMayBay")
        cbMaTB.Text = danh_sach.Current("MaTuyenBay")
        dtpNgayDi.Text = danh_sach.Current("NgayKhoiHanh")
        dtpNgayDen.Text = danh_sach.Current("NgayDen")
        txtGioDi.Text = danh_sach.Current("GioDi").ToString()
        txtGioDen.Text = danh_sach.Current("GioDen").ToString()
        txtTien.Text = danh_sach.Current("TongTien")
    End Sub
    Private Sub danh_sach_moi(ByVal sender As Object, ByVal e As System.EventArgs) Handles danh_sach.PositionChanged
        Xuat()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaCB.Text = "" Or cbMaMB.Text = "" Or cbMaTB.Text = "" Or txtTien.Text = "" Or
                    txtGioDi.Text = "" Or txtGioDen.Text = "" Or dtpNgayDi.Text = "" Or dtpNgayDen.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                If Format(dtpNgayDi.Value, "yyyy/MM/dd") <= Format(dtpNgayDen.Value, "yyyy/MM/dd") Then
                    Dim ngayDi, ngayDen As String
                    ngayDi = Format(dtpNgayDi.Value, "yyyy/MM/dd")
                    ngayDen = Format(dtpNgayDen.Value, "yyyy/MM/dd")
                    sql = "Insert into ChuyenBay(MaChuyenBay,MaTuyenBay,MaMayBay,NgayKhoiHanh,NgayDen,GioDi,GioDen,TongTien) 
                       values('" & txtMaCB.Text & "','" & cbMaTB.Text & "','" & cbMaMB.Text & "','" & ngayDi & "',
                       '" & ngayDen & "','" & txtGioDi.Text & "',N'" & txtGioDen.Text & "','" & txtTien.Text & "')"
                    ketNoi.Excute(sql)
                    dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                    danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
                    MsgBox("Thêm thành công !")
                    btnThem.Enabled = True
                    btnSua.Enabled = True
                    btnXoa.Enabled = True
                    btnLuu.Enabled = False
                    btnThoat.Enabled = True
                Else
                    MsgBox("Ngày đến phải lớn hơn hoặc bằng ngày khởi hành")
                End If

            End If
        End If
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If MsgBox("Bạn có muốn sửa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaCB.Text = "" Or cbMaMB.Text = "" Or cbMaTB.Text = "" Or txtTien.Text = "" Or
                    txtGioDi.Text = "" Or txtGioDen.Text = "" Or dtpNgayDi.Text = "" Or dtpNgayDen.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                If Format(dtpNgayDi.Value, "yyyy/MM/dd") <= Format(dtpNgayDen.Value, "yyyy/MM/dd") Then
                    Dim ngayDi, ngayDen As String
                    ngayDi = Format(dtpNgayDi.Value, "yyyy/MM/dd")
                    ngayDen = Format(dtpNgayDen.Value, "yyyy/MM/dd")
                    sql = " update ChuyenBay set MaMayBay= '" & cbMaMB.Text & "',MaTuyenBay='" & cbMaTB.Text & "',
                            GioDi= '" & txtGioDi.Text & "',GioDen='" & txtGioDen.Text & "',NgayKhoiHanh= '" & ngayDi & "',
                            NgayDen= '" & ngayDen & "',TongTien = '" & txtTien.Text & "'
                            where MaChuyenBay = '" & (txtMaCB.Text) & "'"
                    ketNoi.Excute(sql)
                    dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                    danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
                    MsgBox("Sửa thành công !")
                Else
                    MsgBox("Ngày đến phải lớn hơn hoặc bằng ngày khởi hành")
                End If
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaCB.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from ChuyenBay where MaChuyenBay = '" & (txtMaCB.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtMaCB.Text = ""
        cbMaMB.Text = ""
        cbMaTB.Text = ""
        txtGioDi.Text = ""
        txtGioDen.Text = ""
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