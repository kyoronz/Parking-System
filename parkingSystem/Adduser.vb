Imports System.Text.RegularExpressions
Public Class Adduser
    Dim con As OleDb.OleDbConnection
    Dim flag As Integer = 0 'use to detect validation
    Dim times() As Integer = {0, 0, 0, 0, 0} 'use to count the times of leaving the same textbox
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM Customer"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Customer")

        Dim counter As Integer = 0
        Dim maxrows As Integer = ds.Tables("Customer").Rows.Count
        If counter = maxrows Then
            validation()
            If flag = 1 Then
                MessageBox.Show("Format of insertted details is not valid. Please follow the format given", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                con.Close()
                Exit Sub
            End If
            'add owner details to database and the form will be close after done adding
            Dim newrows As DataRow = ds.Tables("Customer").NewRow
            newrows.Item(0) = txtic.Text
            newrows.Item(1) = txtname.Text
            newrows.Item(2) = msktxtcn.Text
            newrows.Item(3) = txtemail.Text
            newrows.Item(4) = txtcarplate.Text
            newrows.Item(5) = "NR"
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            ds.Tables("Customer").Rows.Add(newrows)
            da.Update(ds, "Customer")
            con.Close()
            Add.IC = txtic.Text
            Me.Close()
        Else
            While Not counter = maxrows
                If ds.Tables("Customer").Rows(counter).Item(0) = txtic.Text Then
                    flag = 0
                    Exit While
                End If
                flag = 1
                counter += 1
            End While

            If flag = 1 Then
                validation()
                If flag = 1 Then
                    MessageBox.Show("Format of insertted details is not valid. Please follow the format given", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                    Exit Sub
                End If
                'add owner details to database and the form will be close after done adding
                Dim newrows As DataRow = ds.Tables("Customer").NewRow
                newrows.Item(0) = txtic.Text
                newrows.Item(1) = txtname.Text
                newrows.Item(2) = msktxtcn.Text
                newrows.Item(3) = txtemail.Text
                newrows.Item(4) = txtcarplate.Text
                newrows.Item(5) = "R"
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                ds.Tables("Customer").Rows.Add(newrows)
                da.Update(ds, "Customer")
                Add.IC = txtic.Text
                con.Close()
                Me.Close()
            Else
                MessageBox.Show("The user with same IC is registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        con.Close()
    End Sub

    Private Sub Adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Clear()
        txtic.Clear()
        txtemail.Clear()
        txtcarplate.Clear()
        msktxtcn.Clear()
        lblcarplatealr.Text = ""
        lblemailalr.Text = ""
        lblicalr.Text = ""
        lblcnalr.Text = ""
        lblnamealr.Text = ""
        times = {0, 0, 0, 0, 0}
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Add.IC = vbNullString 'to ensure nothing will be return if the operation is halt 
        Me.Close()
    End Sub
    Private Sub validation()
        flag = 0
        If Not txtname.Text = "" Then
            If Not Regex.Match(txtname.Text, "^[a-zA-Z ]*$").Success Then
                flag = 1
                lblnamealr.Text = "Only alphabet is allowed"
            Else
                lblnamealr.Text = ""
            End If
        End If
        If Not txtic.Text = "" Then
            If Not Regex.Match(txtic.Text, "^[0-9]*$").Success Then
                flag = 1
                lblicalr.Text = "Only 12 numbers is allowed"
            Else
                If Not txtic.Text.Length = 12 Then
                    flag = 1
                    lblicalr.Text = "Only 12 numbers is allowed"
                Else
                    lblicalr.Text = ""
                End If
            End If
        End If
        If Not msktxtcn.MaskCompleted = True Then
            flag = 1
            lblcnalr.Text = "Please complete the contact number"
        Else
            lblcnalr.Text = ""
        End If
        If Not txtemail.Text = "" Then
            If Not Regex.Match(txtemail.Text, "^[A-Za-z]{1}[a-zA-Z]*?([\._]{1})?([a-zA-Z]+)@[a-zA-Z\.]+(c){1}(o){1}(m){1}?([\.]{1}[m]{1}[y]{1})*$").Success Then
                flag = 1
                lblemailalr.Text = "Email format is invalid"
            Else
                lblemailalr.Text = ""
            End If
        End If
        If Not txtcarplate.Text = "" Then
            If Not Regex.Match(txtcarplate.Text, "^[A-Z]{1}?([0-9A-Z ]+)$").Success Then
                flag = 1
                lblcarplatealr.Text = "Only alphanumeric characters are allowed"
            Else
                lblcarplatealr.Text = ""
            End If
        End If
    End Sub
    'to allow auto validation after leaving same textbox twice
    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
        times(0) += 1
        If times(0) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtic_Leave(sender As Object, e As EventArgs) Handles txtic.Leave
        times(1) += 1
        If times(1) > 2 Then
            validation()
        End If
    End Sub
    Private Sub msktxtcn_Leave(sender As Object, e As EventArgs) Handles msktxtcn.Leave
        times(2) += 1
        If times(2) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        times(3) += 1
        If times(3) > 2 Then
            validation()
        End If
    End Sub
    Private Sub txtcarplate_Leave(sender As Object, e As EventArgs) Handles txtcarplate.Leave
        times(4) += 1
        If times(4) > 2 Then
            validation()
        End If
    End Sub
End Class