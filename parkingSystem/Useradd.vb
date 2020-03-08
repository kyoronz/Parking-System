Imports System.Text.RegularExpressions
Public Class Useradd
    Dim con As OleDb.OleDbConnection
    Dim flag As Integer = 0 'use for validation
    Dim times() As Integer = {0, 0, 0, 0, 0} 'use to detect the times of leaving textbox
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        validation()
        If flag = 0 Then
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()
            Dim ds As New DataSet
            Dim sql As String = "SELECT * FROM UserList"
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "User")
            Dim Maxrows As Integer = ds.Tables("User").Rows.Count
            Dim counter As Integer = 0
            While Not counter = Maxrows
                If txtusr.Text = ds.Tables("User").Rows(counter).Item(0) Then
                    MessageBox.Show("Same username is used by other user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                    Exit Sub
                Else
                    Label2.Text = ""
                End If
                counter += 1
            End While
            'Add new account into the database
            Dim newrows As DataRow = ds.Tables("User").NewRow
            newrows.Item(0) = txtusr.Text
            newrows.Item(1) = txtpsw.Text
            newrows.Item(2) = txtname.Text
            newrows.Item(3) = cboxacctype.Text


            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            ds.Tables("User").Rows.Add(newrows)
            da.Update(ds, "User")
            MessageBox.Show("User is added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnclear.PerformClick()
            con.Close()
        Else
            MessageBox.Show("Please complete the form correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtusr.Clear()
        txtpsw.Clear()
        txtrepsw.Clear()
        cboxacctype.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
    End Sub

    Private Sub Useradd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Clear()
        txtusr.Clear()
        txtpsw.Clear()
        txtrepsw.Clear()
        cboxacctype.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        cboxacctype.Items.Clear()
        cboxacctype.Items.Add("admin")
        cboxacctype.Items.Add("user")
        times = {0, 0, 0, 0, 0}
    End Sub
    'to allow auto validation after leaving same textbox twice
    Private Sub validation()
        flag = 0
        If txtname.Text = "" Then
            flag = 1
            Label1.Text = ""
        Else
            If Not Regex.Match(txtname.Text, "^[0-9a-zA-Z]*$").Success Then
                Label1.Text = "Only alphanumeric characters is allowed"
                flag = 1
            Else
                Label1.Text = ""
            End If
        End If

        If txtusr.Text = "" Then
            flag = 1
            Label2.Text = ""
        Else
            If Not Regex.Match(txtusr.Text, "^[0-9a-zA-Z]*$").Success Then
                Label2.Text = "Only alphanumeric characters is allowed"
                flag = 1
            Else
                Label2.Text = ""
            End If
        End If

        If txtpsw.Text = "" Then
            flag = 1
            Label3.Text = ""
        Else
            If txtpsw.TextLength < 6 Then
                Label3.Text = "Password must be in alphanumeric and at least 6 characters"
                flag = 1
            Else
                Label3.Text = ""
            End If
        End If

        If txtrepsw.Text = "" Then
            flag = 1
            Label4.Text = ""
        Else
            If Not txtpsw.Text = txtrepsw.Text Then
                Label4.Text = "Password is not matched with the previous password"
                flag = 1
            Else
                Label4.Text = ""
            End If
        End If

        If cboxacctype.Text = "" Then
            flag = 1
        End If
    End Sub

    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
        times(0) += 1
        If times(0) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtusr_Leave(sender As Object, e As EventArgs) Handles txtusr.Leave
        times(1) += 1
        If times(1) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtpsw_Leave(sender As Object, e As EventArgs) Handles txtpsw.Leave
        times(2) += 1
        If times(2) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtrepsw_Leave(sender As Object, e As EventArgs) Handles txtrepsw.Leave
        times(3) += 1
        If times(3) > 2 Then
            validation()
        End If
    End Sub
    Private Sub cboxacctype_Leave(sender As Object, e As EventArgs) Handles cboxacctype.Leave
        times(4) += 1
        If times(4) > 2 Then
            validation()
        End If
    End Sub

    Private Sub grpuserinfo_Enter(sender As Object, e As EventArgs) Handles grpuserinfo.Enter

    End Sub
End Class