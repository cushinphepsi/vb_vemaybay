Imports System.Data.SqlClient
Public Class TuyenBay

    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Public lenhLoad As String = "Select * from TuyenBay"
    Private Sub TuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
        danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
        Xuat()
    End Sub
    Private Sub Xuat()
        txtMaTB.Text = danh_sach.Current("MaTuyenBay")
        txtSBDi.Text = danh_sach.Current("SanBayDi")
        txtSBDen.Text = danh_sach.Current("SanBayDen")
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If MsgBox("Bạn có muốn lưu không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            If (txtMaTB.Text = "" Or txtSBDi.Text = "" Or txtSBDen.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else

                sql = "Insert into TuyenBay(MaTuyenBay,SanBayDi,SanBayDen) 
                       values('" & txtMaTB.Text & "',N'" & txtSBDi.Text & "',N'" & txtSBDen.Text & "')"
                ketNoi.Excute(sql)
                dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
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
            If (txtMaTB.Text = "" Or txtSBDi.Text = "" Or txtSBDen.Text = "") Then
                MsgBox("Chưa nhập đủ dữ liệu !")
            Else
                sql = " update TuyenBay Set MaTuyenBay= '" & txtMaTB.Text & "',SanBayDi= N'" & txtSBDi.Text & "',
                               SanBayDen=N'" & txtSBDen.Text & "' 
                        where MaTuyenBay = '" & (txtMaTB.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
                MsgBox("Sửa thành công !")
            End If
        End If
    End Sub
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBox("Bạn có muốn xóa không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            If txtMaTB.Text = "" Then
                MsgBox("Chọn mã khách hàng cần xóa !")
            Else
                sql = " delete from TuyenBay where MaTuyenBay = '" & (txtMaTB.Text) & "'"
                ketNoi.Excute(sql)
                dgvThongTinCB.DataSource = ketNoi.LoadDataTable(lenhLoad)
                danh_sach = Me.BindingContext(dgvThongTinCB.DataSource)
                MsgBox("Xóa thành công !")
            End If
        End If
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        txtMaTB.Text = ""
        txtSBDi.Text = ""
        txtSBDen.Text = ""
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