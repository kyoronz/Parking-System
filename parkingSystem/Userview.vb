Public Class Userview
    Dim con As OleDb.OleDbConnection
    Dim currentresult As Integer = 0 'use to detect the ongoing result without continue open the connection
    Public tempusr As String 'use to store username for userpasswordedit
    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        currentresult -= 1
        btnnext.Enabled = True

        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM UserList"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)

        Dim Maxrows As Integer = ds.Tables("User").Rows.Count
        txtusr.Text = d.Item(0)
        txtname.Text = d.Item(2)
        If d.Item(3) = "admin" Then
            cboxacctype.SelectedIndex = 0
        Else
            cboxacctype.SelectedIndex = 1
        End If
        If currentresult - 1 = -1 Then 'check for the possibility of previous result in database
            btnprev.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub Userview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxacctype.Items.Clear()
        cboxacctype.Items.Add("admin")
        cboxacctype.Items.Add("user")
        btnprev.Enabled = False
        currentresult = 0
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM UserList"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")

        Dim Maxrows As Integer = ds.Tables("User").Rows.Count
        If Maxrows = 0 Then
            MessageBox.Show("No account is exist. Please proceed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'normally wont happen
            con.Close()
            Me.Close()
            Exit Sub
        End If
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)
        txtusr.Text = d.Item(0)
        txtname.Text = d.Item(2)
        If d.Item(3) = "admin" Then
            cboxacctype.SelectedIndex = 0
        Else
            cboxacctype.SelectedIndex = 1
        End If
        If currentresult + 1 = Maxrows Then 'check the possibility of next result in database
            btnnext.Enabled = False
        Else
            btnnext.Enabled = True
        End If
        con.Close()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        currentresult += 1
        btnprev.Enabled = True

        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM UserList"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)
        Dim Maxrows As Integer = ds.Tables("User").Rows.Count

        txtusr.Text = d.Item(0)
        txtname.Text = d.Item(2)
        If d.Item(3) = "admin" Then
            cboxacctype.SelectedIndex = 0
        Else
            cboxacctype.SelectedIndex = 1
        End If
        If currentresult + 1 = Maxrows Then 'checking for possibility of next result in database
            btnnext.Enabled = False
        End If
        con.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM UserList WHERE [Account_Type]='admin'"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        'to check the number of admin account to prevent the last admin account from being deleted
        Dim admincounter As Integer = 0
        If (dr.HasRows) Then
            While (dr.Read())
                admincounter += 1
            End While
        End If

        Dim ds As New DataSet
        sql = "SELECT * FROM UserList"
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)
        If admincounter > 1 Then
            If MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                d.Delete()
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                da.Update(ds, "User")
                con.Close()
                deleterefresh() 'return to first account details
                Exit Sub
            End If
        Else
            If d.Item(3) = "user" Then
                If MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    d.Delete()
                    Dim cb As New OleDb.OleDbCommandBuilder(da)
                    cb.QuotePrefix = "["
                    cb.QuoteSuffix = "]"
                    da.Update(ds, "User")
                    con.Close()
                    deleterefresh() 'return to first account details
                    Exit Sub
                End If
            Else
                MessageBox.Show("This is the last admin account. Delete cannot be done on this account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        con.Close()
    End Sub

    Private Sub btneditdetails_Click(sender As Object, e As EventArgs) Handles btneditdetails.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM UserList WHERE Account_Type='admin'"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        Dim admincounter As Integer = 0
        Dim flag As Integer = 0
        If (dr.HasRows) Then
            While (dr.Read())
                admincounter += 1
            End While
            dr.Close()
        End If
        Dim ds As New DataSet
        Dim sql2 As String = "SELECT * FROM UserList"
        Dim da As New OleDb.OleDbDataAdapter(sql2, con)
        da.Fill(ds, "User")
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)

        'to check the changes of data in the textbox. Edit details button will not return any function if there are no changes on textbox
        If Not Equals(d.Item(0), txtusr.Text) Or Not Equals(d.Item(2), txtname.Text) Or Not Equals(d.Item(3), cboxacctype.Text) Then
            flag = 1
        End If

        If flag = 1 Then
            If MessageBox.Show("Do you wish to edit the details of this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If Not admincounter > 1 And cboxacctype.Text = "user" And d.Item(3) = "admin" Then
                    MessageBox.Show("This is the last admin account. Edit account type cannot be done on this account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusr.Text = d.Item(0)
                    txtname.Text = d.Item(2)
                    If d.Item(3) = "admin" Then
                        cboxacctype.SelectedIndex = 0
                    Else
                        cboxacctype.SelectedIndex = 1
                    End If
                    con.Close()
                    Exit Sub
                End If
                If Equals(txtusr.Text, d.Item(0)) Then
                    d.Item(0) = txtusr.Text
                    d.Item(2) = txtname.Text
                    d.Item(3) = cboxacctype.Text
                    Dim cb As New OleDb.OleDbCommandBuilder(da)
                    cb.QuotePrefix = "["
                    cb.QuoteSuffix = "]"
                    da.Update(ds, "User")
                Else
                    sql = "SELECT * FROM UserList WHERE [Username]=@usr"
                    cmd = New OleDb.OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@usr", txtusr.Text)
                    dr.Close()
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        flag = 0
                        MessageBox.Show("Same username is used. Please use another username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtusr.Text = d.Item(0)
                        txtname.Text = d.Item(2)
                        If d.Item(3) = "admin" Then
                            cboxacctype.SelectedIndex = 0
                        Else
                            cboxacctype.SelectedIndex = 1
                        End If
                        Exit Sub
                    End If
                    d.Item(0) = txtusr.Text
                    d.Item(2) = txtname.Text
                    d.Item(3) = cboxacctype.Text
                    Dim cb As New OleDb.OleDbCommandBuilder(da)
                    cb.QuotePrefix = "["
                    cb.QuoteSuffix = "]"
                    da.Update(ds, "User")
                End If
            Else
                txtusr.Text = d.Item(0)
                txtname.Text = d.Item(2)
                If d.Item(3) = "admin" Then
                    cboxacctype.SelectedIndex = 0
                Else
                    cboxacctype.SelectedIndex = 1
                End If
            End If
        End If
        con.Close()
    End Sub

    Private Sub btneditpsw_Click(sender As Object, e As EventArgs) Handles btneditpsw.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM UserList"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")
        Dim d As DataRow = ds.Tables("User").Rows(currentresult)
        tempusr = d.Item(0)
        con.Close()
        Userpasswordedit.ShowDialog()
    End Sub

    Private Sub deleterefresh()
        currentresult = 0
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim ds As New DataSet
        Dim sql As String = "SELECT * FROM UserList"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "User")

        Dim Maxrows As Integer = ds.Tables("User").Rows.Count
        If Maxrows = 0 Then
            MessageBox.Show("No account is exist. Please proceed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'normally wont happen
            con.Close()
            Me.Close()
            Exit Sub
        End If

        Dim d As DataRow = ds.Tables("User").Rows(currentresult)
        txtusr.Text = d.Item(0)
        txtname.Text = d.Item(2)
        If d.Item(3) = "admin" Then
            cboxacctype.SelectedIndex = 0
        Else
            cboxacctype.SelectedIndex = 1
        End If
        If currentresult + 1 = Maxrows Then 'detect the possibility of next result
            btnnext.Enabled = False
        Else
            btnnext.Enabled = True
        End If
        btnprev.Enabled = False 'first result will not have previous result
    End Sub
End Class