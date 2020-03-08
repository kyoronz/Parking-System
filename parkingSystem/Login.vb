Public Class Login
    Dim con As OleDb.OleDbConnection

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()

        Welcome.loginflag = 0
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM UserList WHERE Username=@usr AND Password=@psw"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@usr", txtusr.Text)
        cmd.Parameters.AddWithValue("@psw", txtpsw.Text)
        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            dr.Read()
            If Equals(dr.Item(3), "admin") Then 'if it is admin else user
                con.Close()
                AddminMenu.Show()
                btnclear.PerformClick()
                Me.Close()
            Else
                con.Close()
                Welcome.loginflag = 1
                ParkingSlotView.Show()
                btnclear.PerformClick()
                Me.Close()
            End If
        Else
            Label4.Text = "User with the password is not exist"
            con.Close()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Label4.Text = " "
        txtusr.Clear()
        txtpsw.Clear()
        txtusr.Focus()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnlogin
        CancelButton = btnexit
    End Sub
End Class