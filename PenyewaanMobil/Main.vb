Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        hideContent()

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True

    End Sub

    Private Sub hideContent()

        Me.MobilToolStripMenuItem.Visible = False
        Me.JenisMobilToolStripMenuItem.Visible = False
        Me.SewaToolStripMenuItem.Visible = False
        Me.PenyewaToolStripMenuItem.Visible = False
        Me.DataGridView1.Visible = False
        Me.Button1.Visible = False
        Me.LOGOUTToolStripMenuItem.Visible = False

    End Sub

    Public Sub showContent()

        Me.MobilToolStripMenuItem.Visible = True
        Me.JenisMobilToolStripMenuItem.Visible = True
        Me.PenyewaToolStripMenuItem.Visible = True
        Me.DataGridView1.Visible = True
        Me.Button1.Visible = True
        Me.LOGOUTToolStripMenuItem.Visible = True

    End Sub

    Public Sub showSewa()

        connect()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "select * from dbpenyewaanmobil.mobil"

        sqlDr = sqlCmd.ExecuteReader
        sqlDt.Load(sqlDr)
        sqlDr.Close()
        sqlConn.Close()

        If sqlDt.Rows.Count > 0 Then
            Me.SewaToolStripMenuItem.Visible = True
        Else
            Me.SewaToolStripMenuItem.Visible = False
        End If

    End Sub

    Public Sub updateTable()

        connect()

        Dim sqlDts As New DataTable

        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "select penyewa as 'Penyewa', merekSewa as 'Tipe Mobil', statusSewa as 'Status', rencanaPinjam as 'Durasi Sewa', 
                              tanggalPinjam as 'Tanggal Pinjam' 
                              from dbpenyewaanmobil.sewa where statusSewa='Sedang disewa'"
        sqlDr = sqlCmd.ExecuteReader
        sqlDts.Load(sqlDr)
        sqlDr.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDts

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        updateTable()
        showSewa()

    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        Login.Show()
        Me.Visible = False
    End Sub

<<<<<<< HEAD
    Private Sub PenyewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyewaToolStripMenuItem.Click
        FormPenyewa.Show()
=======
    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        'Mobil.Show()
    End Sub

    Private Sub JenisMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisMobilToolStripMenuItem.Click
        JenisMobil.Show()
    End Sub

    Private Sub PenyewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyewaToolStripMenuItem.Click
        'Penyewa.Show()
>>>>>>> 4da48483700065c9f01f8b008ec54e34aefb8a01
    End Sub


    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click

        Dim meExit As DialogResult
        meExit = MessageBox.Show("Yakin mau keluar? ", "Mysql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If meExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class