Imports System.Text.RegularExpressions
Public Class Userpasswordedit
    Dim con As OleDb.OleDbConnection
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Userpasswordedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusr.Clear()
        txtoldpsw.Clear()
        txtnewpsw.Clear()
        txtrepsw.Clear()
        txtusr.Enabled = False
        txtnewpsw.Enabled = False
        txtrepsw.Enabled = False
        txtusr.Text = Userview.tempusr
        btnconfirm.Enabled = False
        btncheck.Enabled = True
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If Not txtnewpsw.Text = txtrepsw.Text Then
            MessageBox.Show("New password is not match with confirm password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Not Regex.Match(txtnewpsw.Text, "^[0-9a-zA-Z]*$").Success Or txtnewpsw.TextLength < 6 Then
            MessageBox.Show("Password must be at least 6 alphanumeric character.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()

            Dim sql As String = "UPDATE UserList SET [Password]=@psw WHERE Username=@usr "
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            Dim flag As Integer
            cmd.Parameters.AddWithValue("@psw", txtnewpsw.Text)
            cmd.Parameters.AddWithValue("@usr", txtusr.Text)
            cmd.ExecuteNonQuery()
            flag = cmd.ExecuteNonQuery()
            If flag = 0 Then
                MessageBox.Show("Password change is fail. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Password is changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Me.Close()
            End If
            con.Close()
        End If
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        If Not Regex.Match(txtnewpsw.Text, "^[0-9a-zA-Z]*$").Success Then
            MessageBox.Show("Only alphanumeric characters is allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()
            Dim dr As OleDb.OleDbDataReader
            Dim sql As String = "SELECT * FROM UserList WHERE Username=@usr AND Password=@psw"
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@usr", txtusr.Text)
            cmd.Parameters.AddWithValue("@psw", txtoldpsw.Text)
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                MessageBox.Show("User account found. Please enter the new password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtoldpsw.Enabled = False
                txtnewpsw.Enabled = True
                txtrepsw.Enabled = True
                btnconfirm.Enabled = True
                btncheck.Enabled = False
            Else
                MessageBox.Show("User account not exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
    End Sub
End Class