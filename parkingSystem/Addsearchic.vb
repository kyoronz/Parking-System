Public Class Addsearchic
    Dim con As OleDb.OleDbConnection
    Dim flag As Integer = 0 'to ensure check button is at least pressed once
    Dim searchpastresult As String 'to store the previous checked result
    Private Sub Addsearchic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Enabled = False
        txtcn.Enabled = False
        txtemail.Enabled = False
        txtcarplate.Enabled = False
        txtenteric.Clear()
        txtname.Clear()
        txtcn.Clear()
        txtemail.Clear()
        txtcarplate.Clear()
        flag = 0
        btnconfirm.Enabled = False
        btncheck.Enabled = True
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM Customer WHERE IC=@ic"
        Dim cmd As New OleDb.OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@ic", txtenteric.Text)
        dr = cmd.ExecuteReader
        If Not (dr.HasRows) Then
            MessageBox.Show("User does not exist. Please proceed to add new user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            searchpastresult = vbNullString
            btnconfirm.Enabled = False
        Else
            dr.Read()
            If Equals(dr.Item(5), "R") Then
                MessageBox.Show("This user has already registered a parking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                searchpastresult = vbNullString
                btnconfirm.Enabled = False
            Else
                txtname.Text = dr.Item(1)
                txtcn.Text = dr.Item(2)
                txtemail.Text = dr.Item(3)
                txtcarplate.Text = dr.Item(4)
                flag = 1
                searchpastresult = txtenteric.Text
                btnconfirm.Enabled = True
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If searchpastresult = vbNullString Or flag = 0 Then
            Add.IC = vbNullString
        Else
            Add.IC = searchpastresult
            Me.Close()
        End If
    End Sub
End Class