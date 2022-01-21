Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Login
    Public Shared user As New Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtBoxPass.UseSystemPasswordChar = True
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblRegis.LinkClicked
        Registrasi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtBoxUser.Text
        Dim password As String = TxtBoxPass.Text
        Dim database As List(Of String) = user.UserDatabase(username, password)
        If database.Count > 0 Then
            user.usernameProperty = database(1)
            Main.showContent()
            Main.LOGINToolStripMenuItem.Visible = False
            Me.Close()
            Main.Visible = True

        Else
            MessageBox.Show("Username/Password Salah")
        End If
    End Sub

    Private Sub TxtBoxPass_MouseLeave(sender As Object, e As EventArgs) Handles TxtBoxPass.MouseLeave
        If TxtBoxPass.UseSystemPasswordChar = True Then
            TxtBoxPass.UseSystemPasswordChar = False
        Else
            TxtBoxPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtBoxPass_MouseEnter(sender As Object, e As EventArgs) Handles TxtBoxPass.MouseEnter
        If TxtBoxPass.UseSystemPasswordChar = False Then
            TxtBoxPass.UseSystemPasswordChar = True
        Else
            TxtBoxPass.UseSystemPasswordChar = False
        End If
    End Sub
End Class
