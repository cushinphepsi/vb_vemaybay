Imports System.Data.SqlClient

Module ketNoi
    Public maNV, doiCB As String
    Dim cmd As New SqlCommand
    Dim con = New SqlConnection

    Public Sub Connect()
        con = New SqlConnection("Data Source=cushinphepsi;Initial Catalog=QLVeMayBay;Integrated Security=True")
        con.Open()
    End Sub
    Public Function LoadDataTable(sql As String)
        Dim cmd As New SqlCommand(sql, con)
        Dim bang As SqlDataReader = cmd.ExecuteReader
        Dim tbl = New DataTable()
        tbl.Load(bang, LoadOption.OverwriteChanges)
        Return tbl
    End Function


    Public Sub Excute(sql As String)
        cmd = New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub
End Module
