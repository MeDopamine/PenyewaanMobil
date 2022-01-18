Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Registrasi
    Public Shared user As New Users
    Public Shared imgr As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtBoxPass.UseSystemPasswordChar = True
    End Sub
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        If TxtBoxUser.Text.Length > 0 And TxtBoxPass.Text.Length > 0 And TxtBoxEmail.Text.Length > 0 Then
            Login.user.AddUsersDatabase(TxtBoxUser.Text, TxtBoxPass.Text, TxtBoxEmail.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub

    Private Sub BtnUnggah_Click(sender As Object, e As EventArgs) Handles BtnUnggah.Click

        Try
            ofd = New OpenFileDialog()

            ofd.Title = "Open"
            ofd.Filter = "All Format|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgPath = ofd.FileName
                PicBoxFoto.ImageLocation = imgPath
                imgr = imgPath

                PicBoxFoto.Load(imgr)
                PicBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If

            ofd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

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