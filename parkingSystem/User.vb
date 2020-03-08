Imports System.ComponentModel

Public Class User
    Private Sub User_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AdminSubMenu.MdiParent = AddminMenu
        AdminSubMenu.WindowState = FormWindowState.Maximized
        AdminSubMenu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbAdd.Click
        Useradd.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pcbView.Click
        Userview.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Me.Close()
    End Sub
    'for design purpose
    Private Sub pcbAdd_MouseHover(sender As Object, e As EventArgs) Handles pcbAdd.MouseHover
        pcbAdd.BackColor = SystemColors.InactiveCaption
        lbltext.Text = "Add User"
    End Sub

    Private Sub pcbAdd_MouseLeave(sender As Object, e As EventArgs) Handles pcbAdd.MouseLeave
        pcbAdd.BackColor = SystemColors.Info
        lbltext.Text = ""
    End Sub

    Private Sub pcbView_MouseHover(sender As Object, e As EventArgs) Handles pcbView.MouseHover
        pcbView.BackColor = SystemColors.InactiveCaption
        lbltext.Text = "View User"
    End Sub

    Private Sub pcbView_MouseLeave(sender As Object, e As EventArgs) Handles pcbView.MouseLeave
        pcbView.BackColor = SystemColors.Info
        lbltext.Text = ""
    End Sub

    Private Sub pcbBack_MouseHover(sender As Object, e As EventArgs) Handles pcbBack.MouseHover
        pcbBack.BackColor = SystemColors.InactiveCaption
        lbltext.Text = "Back"
    End Sub

    Private Sub pcbBack_MouseLeave(sender As Object, e As EventArgs) Handles pcbBack.MouseLeave
        pcbBack.BackColor = SystemColors.Info
        lbltext.Text = ""
    End Sub
End Class