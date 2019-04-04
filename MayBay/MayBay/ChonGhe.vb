Imports System.Data.SqlClient
Public Class ChonGhe
    Public maGhe(19) As String
    Public j, sql, choNgoiSo As String
    Private WithEvents danh_sach As BindingManagerBase
    Public maVe As String

    Private Sub btnChon_Click(sender As Object, e As EventArgs) Handles btnChon.Click
        sql = " Update VeChuyenBay set ChoNgoiSo = '" & choNgoiSo & "'
                where MaVe = '" & maVe & "'"
        Dim data As DataTable
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        MsgBox("Chọn chỗ ngồi thành công")
        Me.Close()
    End Sub

    Private Sub ChonGhe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        Dim data As DataTable
        maVe = ChonChoNgoi.txtMaVe.Text
        sql = " select ChoNgoiSo from VeChuyenBay
                where MaVe = '" & maVe & "' "
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        j = danh_sach.Current("ChoNgoiSo").ToString
        If j = Nothing Then

        Else
            If MsgBox("Bạn đã chọn ghế rồi. Bạn có muốn đổi chỗ ngồi không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
            Else
                Me.Close()
            End If
        End If

        sql = " select * from Ghe 
                inner join SoDoGhe sdg on Ghe.MaSoDo = sdg.MaSoDo
                inner join MayBay mb on mb.MaSoDo = sdg.MaSoDo
                inner join ChuyenBay cb on cb.MaMayBay = mb.MaMayBay
                inner join VeChuyenBay vecb on vecb.MaChuyenBay = cb.MaChuyenBay
                where vecb.MaVe = '" & maVe & "' and TinhTrangGhe = N'Chưa đặt'"


        Data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)

        maGhe(0) = danh_sach.Current("MaGhe")
        For i = 0 To danh_sach.Count - 1
            danh_sach.Position = i
            maGhe(i) = danh_sach.Current("MaGhe")
        Next

        For i = 0 To danh_sach.Count - 1
            danh_sach.Position = i
            If maGhe(i) <> "A001" Then
            Else
                A001.BackColor = Color.Gray
            End If

            If maGhe(i) <> "A002" Then
            Else
                A002.BackColor = Color.Gray
            End If

            If maGhe(i) <> "A003" Then
            Else
                A003.BackColor = Color.Gray
            End If

            If maGhe(i) <> "A004" Then
            Else
                A004.BackColor = Color.Gray
            End If

            If maGhe(i) <> "B001" Then
            Else
                B001.BackColor = Color.Gray
            End If

            If maGhe(i) <> "B002" Then
            Else
                B002.BackColor = Color.Gray
            End If

            If maGhe(i) <> "B003" Then
            Else
                B003.BackColor = Color.Gray
            End If

            If maGhe(i) <> "B004" Then
            Else
                B004.BackColor = Color.Gray
            End If

            If maGhe(i) <> "C001" Then
            Else
                C001.BackColor = Color.Gray
            End If

            If maGhe(i) <> "C002" Then
            Else
                C002.BackColor = Color.Gray
            End If

            If maGhe(i) <> "C003" Then
            Else
                C003.BackColor = Color.Gray
            End If

            If maGhe(i) <> "C004" Then
            Else
                C004.BackColor = Color.Gray
            End If

            If maGhe(i) <> "D001" Then
            Else
                D001.BackColor = Color.Gray
            End If

            If maGhe(i) <> "D002" Then
            Else
                D002.BackColor = Color.Gray
            End If

            If maGhe(i) <> "D003" Then
            Else
                D003.BackColor = Color.Gray
            End If

            If maGhe(i) <> "D004" Then
            Else
                D004.BackColor = Color.Gray
            End If

            If maGhe(i) <> "E001" Then
            Else
                E001.BackColor = Color.Gray
            End If

            If maGhe(i) <> "E002" Then
            Else
                E002.BackColor = Color.Gray
            End If

            If maGhe(i) <> "E003" Then
            Else
                E003.BackColor = Color.Gray
            End If

            If maGhe(i) <> "E004" Then
            Else
                E004.BackColor = Color.Gray
            End If
        Next
    End Sub

    Private Sub A001_Click(sender As Object, e As EventArgs) Handles A001.Click
        If A001.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "A001"
        End If
    End Sub

    Private Sub A002_Click(sender As Object, e As EventArgs) Handles A002.Click
        If A002.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "A002"
        End If
    End Sub

    Private Sub A003_Click(sender As Object, e As EventArgs) Handles A003.Click
        If A003.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "A003"
        End If
    End Sub

    Private Sub A004_Click(sender As Object, e As EventArgs) Handles A004.Click
        If A004.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "A004"
        End If
    End Sub

    Private Sub B001_Click(sender As Object, e As EventArgs) Handles B001.Click
        If B001.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "B001"
        End If
    End Sub

    Private Sub B002_Click(sender As Object, e As EventArgs) Handles B002.Click
        If B002.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "B002"
        End If
    End Sub

    Private Sub B003_Click(sender As Object, e As EventArgs) Handles B003.Click
        If B003.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "B003"
        End If
    End Sub

    Private Sub B004_Click(sender As Object, e As EventArgs) Handles B004.Click
        If B004.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "B004"
        End If
    End Sub

    Private Sub C001_Click(sender As Object, e As EventArgs) Handles C001.Click
        If C001.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "C001"
        End If
    End Sub

    Private Sub C002_Click(sender As Object, e As EventArgs) Handles C002.Click
        If C002.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "C002"
        End If
    End Sub

    Private Sub C003_Click(sender As Object, e As EventArgs) Handles C003.Click
        If C003.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "C003"
        End If
    End Sub

    Private Sub C004_Click(sender As Object, e As EventArgs) Handles C004.Click
        If C004.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "C004"
        End If
    End Sub

    Private Sub D001_Click(sender As Object, e As EventArgs) Handles D001.Click
        If D001.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "D001"
        End If
    End Sub

    Private Sub D002_Click(sender As Object, e As EventArgs) Handles D002.Click
        If D002.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "D002"
        End If
    End Sub

    Private Sub D003_Click(sender As Object, e As EventArgs) Handles D003.Click
        If D003.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "D003"
        End If
    End Sub

    Private Sub D004_Click(sender As Object, e As EventArgs) Handles D004.Click
        If D004.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "D004"
        End If
    End Sub

    Private Sub E001_Click(sender As Object, e As EventArgs) Handles E001.Click
        If E001.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "E001"
        End If
    End Sub

    Private Sub E002_Click(sender As Object, e As EventArgs) Handles E002.Click
        If E002.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "E002"
        End If
    End Sub

    Private Sub E003_Click(sender As Object, e As EventArgs) Handles E003.Click
        If E003.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "E003"
        End If
    End Sub

    Private Sub E004_Click(sender As Object, e As EventArgs) Handles E004.Click
        If E004.BackColor = Color.Red Then
            MsgBox("Ghế này đã được đặt")
        Else
            choNgoiSo = "E004"
        End If
    End Sub
End Class
