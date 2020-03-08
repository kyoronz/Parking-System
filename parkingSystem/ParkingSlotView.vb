Imports System.ComponentModel
Imports System.Data.OleDb
Public Class ParkingSlotView
    Dim tempic As String
    Public parkingslot As String
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand 'run command search database
    Dim dr As OleDbDataReader 'forward reading component

    Public carparklevel As String = "L01-01" 'widely used to determine car park level
    Dim con As OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ps()
        box()
        addbtn.Enabled = False
        revbtn.Enabled = False
        updbtn.Enabled = False
        wtdbtn.Enabled = False
        pcbDown.Enabled = False
    End Sub

    Sub reset() 'reset all setting before switching to next or prev car park level
        Dim i As Integer = 1
        While i <= 50
            Dim btn = Controls.Find("carbtn" & i, True)
            btn(0).BackgroundImage = Nothing
            i += 1
        End While
        addbtn.Enabled = False
        revbtn.Enabled = False
        updbtn.Enabled = False
        wtdbtn.Enabled = False
    End Sub

    Sub cplvl() 'use to determine the button text for the particular car park level
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim sqlstatement As String = "SELECT * FROM Level1 ORDER BY ParkingSlot ASC"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sqlstatement, con)
        da.Fill(ds, "Name")

        Dim Maxrows As Integer = ds.Tables("Name").Rows.Count
        Dim namecounter As Integer = 0
        While Not ds.Tables("Name").Rows(namecounter).Item(0) = carparklevel
            namecounter += 1
        End While
        Dim i As Integer = 1
        While i <= 50
            Dim btn = Controls.Find("carbtn" & i, True)
            btn(0).Text = ds.Tables("Name").Rows(namecounter).Item(0)
            namecounter += 1
            i += 1
        End While
    End Sub

    Sub box()
        txtps.Enabled = False
        txtname.Enabled = False
        txtic.Enabled = False
        txteml.Enabled = False
        txtdr.Enabled = False
        txtdep.Enabled = False
        txtde.Enabled = False
        txtcp.Enabled = False
        txtcn.Enabled = False
    End Sub

    Sub dateexp()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim sql As String = "SELECT * FROM Level1 ORDER BY Parkinglsot ASC"
    End Sub
    Sub ps()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim sqlstatement As String = "SELECT * FROM Level1 ORDER BY ParkingSlot ASC"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sqlstatement, con)
        da.Fill(ds, "Level")
        Dim tempdate As Date
        Dim deposit As Decimal
        Dim Maxrows As Integer = ds.Tables("Level").Rows.Count
        Dim datecounter As Integer = 0
        Dim d1, d2, d3 As Date
        Dim d As DataRow = ds.Tables("Level").Rows(datecounter)
        While Not datecounter = Maxrows
            d = ds.Tables("Level").Rows(datecounter)
            If d.Item(5) = "Unavailable" Then
                d1 = d.Item(4)
                If Date.Compare(d1, Date.Now) < 0 Then
                    d.Item(5) = "Expired"
                    d2 = d.Item(4)
                    d3 = d2.AddDays(10)
                    If Date.Compare(d3, Date.Now) < 0 Then
                        d.Item(1) = "0"
                        d.Item(2) = tempdate
                        d.Item(3) = deposit
                        d.Item(4) = tempdate
                        d.Item(5) = "Available"
                    End If
                End If
            End If
            datecounter += 1
        End While
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Update(ds, "Level")

        Dim statuscounter As Integer = 0
        While Not carbtn1.Text = ds.Tables("Level").Rows(statuscounter).Item(0)
            statuscounter += 1
        End While

        Dim i As Integer = 1
        While i <= 50
            Dim btn = Controls.Find("carbtn" & i, True)
            If ds.Tables("Level").Rows(statuscounter).Item(5) = "Available" Then
                btn(0).BackColor = Color.Transparent
                btn(0).ForeColor = Color.Black
                btn(0).BackgroundImage = Nothing
            ElseIf ds.Tables("Level").Rows(statuscounter).Item(5) = "Unavailable" Then
                btn(0).BackgroundImage = Image.FromFile("car1.png")
                btn(0).ForeColor = Color.White
                btn(0).BackColor = Color.Transparent
            Else
                btn(0).BackgroundImage = Image.FromFile("car.png")
                btn(0).ForeColor = Color.White
                btn(0).BackColor = Color.Red
            End If
            statuscounter += 1
            i += 1
        End While
        con.Close()
    End Sub

    Sub display()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")
        Dim tempdatereg, tempdateexp As DateTime

        Dim sql As String
        sql = "SELECT * FROM Level1 WHERE ParkingSlot=@PS"

        conn.Open()
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@PS", parkingslot)
        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            dr.Read()
            txtps.Text = dr.Item("ParkingSlot")
            'tempic = Convert.ToDecimal(dr.Item("IC"))
            tempic = dr.Item("IC")
            tempdatereg = Convert.ToDateTime(dr.Item("DateRegistered"))
            txtdr.Text = tempdatereg
            txtdep.Text = Convert.ToDecimal(dr.Item("DepositPaid"))
            tempdateexp = Convert.ToDateTime(dr.Item("DateExpired"))
            txtde.Text = tempdateexp
        End If
        conn.Close()

        sql = "SELECT * FROM Customer WHERE IC=@IC"
        conn.Open()
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@IC", tempic)
        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            dr.Read()
            txtname.Text = dr.Item("FullName")
            txtic.Text = dr.Item("IC")
            txtcp.Text = dr.Item("CarNumber")
            txteml.Text = dr.Item("EmailAddress")
            txtcn.Text = dr.Item("ContactNo")
        End If
        conn.Close()

    End Sub
    Private Sub wtdbtn_Click(sender As Object, e As EventArgs) Handles wtdbtn.Click
        Dim withdrawsql As String
        Dim sqlwithdraw As String
        Dim tempdate As DateTime
        Dim currency As Decimal
        Dim deposit As Decimal
        Dim icnum As String
        Dim nr As String = "NR"
        Dim cnt As Integer
        Dim un As String = "Available"
        Dim result As Integer = MessageBox.Show("Are you sure to withdraw?", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        icnum = txtic.Text
        If result = DialogResult.Yes Then
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;Persist Security Info=False;") 'connection string
            Dim sql As String
            sql = "SELECT DepositPaid FROM Level1 WHERE ParkingSlot=@PS"
            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@PS", parkingslot)
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                deposit = dr.Item("DepositPaid")
            End If

            emptyslot_btn()
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;Persist Security Info=False;") 'connection string
            withdrawsql = "UPDATE Level1 SET IC=@ic, DateRegistered=@dtr, DepositPaid=@dpp, DateExpired=@dexp, Status=@stat WHERE ParkingSlot=@slot"
            conn.Open() 'open the connections
            cmd = New OleDbCommand(withdrawsql, conn) 'create the command object
            tempdate = Nothing
            currency = Nothing
            cmd.Parameters.AddWithValue("@ic", txtic.Text)
            cmd.Parameters.AddWithValue("@dtr", tempdate)
            cmd.Parameters.AddWithValue("@dpp", currency)
            cmd.Parameters.AddWithValue("@dexp", tempdate)
            cmd.Parameters.AddWithValue("@stat", un)
            cmd.Parameters.AddWithValue("@slot", txtps.Text)
            cmd.ExecuteNonQuery()
            cnt = cmd.ExecuteNonQuery

            sqlwithdraw = "UPDATE Customer SET Status=@statt WHERE IC=@icc"
            cmd = New OleDbCommand(sqlwithdraw, conn)
            cmd.Parameters.AddWithValue("@statt", nr)
            cmd.Parameters.AddWithValue("@icc", icnum)
            cmd.ExecuteNonQuery()

            conn.Close()

            If cnt = 0 Then
                MessageBox.Show("Unable to withdraw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Withdraw successful. Please return deposit amount RM " & deposit & " to the customer.", "Withdraw successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                box()
                addbtn.Enabled = True
                revbtn.Enabled = False
                updbtn.Enabled = False
                wtdbtn.Enabled = False
                ps()
            End If
        End If
    End Sub

    Private Sub emptyslot_btn() 'code for button available parking slot button
        txtname.Clear()
        txtic.Clear()
        txteml.Clear()
        txtdr.Clear()
        txtdep.Clear()
        txtcp.Clear()
        txtde.Clear()
        txtcn.Clear()
        updbtn.Enabled = False
        wtdbtn.Enabled = False
        addbtn.Enabled = True
        revbtn.Enabled = False
    End Sub

    Private Sub notemptyslot_btn() 'code for button with parking slot with registered user
        updbtn.Enabled = True
        wtdbtn.Enabled = True
        addbtn.Enabled = False
        revbtn.Enabled = False
    End Sub

    Private Sub CarBtn_ClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles carbtn1.Click, carbtn2.Click, carbtn3.Click, carbtn4.Click, carbtn5.Click, carbtn6.Click, carbtn7.Click, carbtn8.Click, carbtn9.Click, carbtn10.Click, carbtn11.Click, carbtn12.Click, carbtn13.Click, carbtn14.Click, carbtn15.Click, carbtn16.Click, carbtn17.Click, carbtn18.Click, carbtn19.Click, carbtn20.Click, carbtn21.Click, carbtn22.Click, carbtn23.Click, carbtn24.Click, carbtn25.Click, carbtn26.Click, carbtn27.Click, carbtn28.Click, carbtn29.Click, carbtn30.Click, carbtn31.Click, carbtn32.Click, carbtn33.Click, carbtn34.Click, carbtn35.Click, carbtn36.Click, carbtn37.Click, carbtn38.Click, carbtn39.Click, carbtn40.Click, carbtn41.Click, carbtn42.Click, carbtn43.Click, carbtn44.Click, carbtn45.Click, carbtn46.Click, carbtn47.Click, carbtn48.Click, carbtn49.Click, carbtn50.Click
        'Custom Sub for Handling all button function
        Dim i As Integer = 1
        Dim clickedbutton As Button = CType(sender, Button)
        parkingslot = clickedbutton.Text
        If clickedbutton.ForeColor = Color.Black Then
            txtps.Text = clickedbutton.Text
            emptyslot_btn()

        ElseIf clickedbutton.BackColor = Color.Red Then
            notemptyslot_btn()
            display()
            revbtn.Enabled = True
            updbtn.Enabled = False
        Else
            notemptyslot_btn()
            display()

        End If
    End Sub

    Private Sub updbtn_Click(sender As Object, e As EventArgs) Handles updbtn.Click
        Dim dialog As frmUpdate
        dialog = New frmUpdate()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")

            Dim sql As String
            sql = "SELECT * FROM Level1 WHERE ParkingSlot=@PS"

            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@PS", parkingslot)
            dr = cmd.ExecuteReader

            If (dr.HasRows) Then
                dr.Read()
                txtps.Text = dr.Item("ParkingSlot")
                txtdr.Text = dr.Item("DateRegistered")
                txtdep.Text = dr.Item("DepositPaid")
                txtde.Text = dr.Item("DateExpired")
            End If

            sql = "SELECT * FROM Customer WHERE IC=@IC"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@IC", tempic)
            dr = cmd.ExecuteReader

            If (dr.HasRows) Then
                dr.Read()
                txtname.Text = dr.Item("FullName")
                txtic.Text = dr.Item("IC")
                txtcp.Text = dr.Item("CarNumber")
                txteml.Text = dr.Item("EmailAddress")
                txtcn.Text = dr.Item("ContactNo")
            End If
            conn.Close()
        End If
    End Sub

    Private Sub revbtn_Click(sender As Object, e As EventArgs) Handles revbtn.Click
        Dim dialog As Renew
        dialog = New Renew()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")

            Dim sql As String
            sql = "SELECT * FROM Level1 WHERE ParkingSlot=@PS"

            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@PS", parkingslot)
            dr = cmd.ExecuteReader

            If (dr.HasRows) Then
                dr.Read()
                txtps.Text = dr.Item("ParkingSlot")
                txtdr.Text = dr.Item("DateRegistered")
                txtdep.Text = dr.Item("DepositPaid")
                txtde.Text = dr.Item("DateExpired")
            End If

            sql = "SELECT * FROM Customer WHERE IC=@IC"
            cmd = New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@IC", tempic)
            dr = cmd.ExecuteReader

            If (dr.HasRows) Then
                dr.Read()
                txtname.Text = dr.Item("FullName")
                txtic.Text = dr.Item("IC")
                txtcp.Text = dr.Item("CarNumber")
                txteml.Text = dr.Item("EmailAddress")
                txtcn.Text = dr.Item("ContactNo")
            End If
            conn.Close()
            ps()
            Payment.Show()
        End If

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Add.ShowDialog()
        ps()
        If Add.canflag = 0 Then
            display()
            addbtn.Enabled = False
            wtdbtn.Enabled = True
            updbtn.Enabled = True
        End If
    End Sub
    Private Sub ParkingSlotView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Welcome.loginflag = 1 Then
            Login.Show()
        Else
            AdminSubMenu.MdiParent = AddminMenu
            AdminSubMenu.WindowState = FormWindowState.Maximized
            AdminSubMenu.Show()
        End If
    End Sub

    Private Sub Previouscarparklevel_Click(sender As Object, e As EventArgs) Handles pcbDown.Click
        If ((lvllbl.Text.Equals("Level 2")) = True) Then
            lvllbl.Text = "Level 1"
            carparklevel = "L01-01"
            cplvl()
            reset()
            box()
            pcbDown.Enabled = False
            ps()
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        ElseIf ((lvllbl.Text.Equals("Level 3")) = True) Then
            lvllbl.Text = "Level 2"
            carparklevel = "L02-01"
            cplvl()
            reset()
            box()
            ps()
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        ElseIf ((lvllbl.Text.Equals("Level 4")) = True) Then
            lvllbl.Text = "Level 3"
            carparklevel = "L03-01"
            cplvl()
            reset()
            box()
            ps()
            pcbUp.Enabled = True
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        End If
    End Sub

    Private Sub Nextcarparklevel_Click(sender As Object, e As EventArgs) Handles pcbUp.Click
        pcbDown.Enabled = True
        If ((lvllbl.Text.Equals("Level 1")) = True) Then
            lvllbl.Text = "Level 2"
            carparklevel = "L02-01"
            cplvl()
            reset()
            box()
            pcbDown.Enabled = True
            ps()
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        ElseIf ((lvllbl.Text.Equals("Level 2")) = True) Then
            lvllbl.Text = "Level 3"
            carparklevel = "L03-01"
            cplvl()
            reset()
            box()
            ps()
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        ElseIf ((lvllbl.Text.Equals("Level 3")) = True) Then
            lvllbl.Text = "Level 4"
            carparklevel = "L04-01"
            cplvl()
            reset()
            box()
            ps()
            pcbUp.Enabled = False
            txtps.Clear()
            emptyslot_btn()
            addbtn.Enabled = False
            revbtn.Enabled = False
        End If
    End Sub
    'for design purpose
    Private Sub pcbDown_MouseHover(sender As Object, e As EventArgs) Handles pcbDown.MouseHover
        pcbDown.BackColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub pcbDown_MouseLeave(sender As Object, e As EventArgs) Handles pcbDown.MouseLeave
        pcbDown.BackColor = SystemColors.Info
    End Sub

    Private Sub pcbUp_MouseHover(sender As Object, e As EventArgs) Handles pcbUp.MouseHover
        pcbUp.BackColor = SystemColors.ControlDarkDark
    End Sub

    Private Sub pcbUp_MouseLeave(sender As Object, e As EventArgs) Handles pcbUp.MouseLeave
        pcbUp.BackColor = SystemColors.Info
    End Sub
End Class
