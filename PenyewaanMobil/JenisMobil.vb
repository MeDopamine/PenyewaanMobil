Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class JenisMobil

    Public Shared idHapusj As Integer

    Private Sub updateTable()

        connect()

        Dim sqlDtj As New DataTable

        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "select idJenis as ID, namaJenis as 'Jenis Mobil', lokasiPembuatan as 'Dibuat di'
                              from dbpenyewaanmobil.jenismobil"
        sqlDr = sqlCmd.ExecuteReader
        sqlDtj.Load(sqlDr)
        sqlDr.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDtj

    End Sub

    Private Sub JenisMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            idHapusj = DataGridView1.SelectedRows(0).Cells(0).Value
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            connect()
            sqlQuery = "insert into jenismobil(namaJenis, lokasiPembuatan) 
                        value('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

            Dim x As Integer
            x = sqlCmd.ExecuteNonQuery()
            If x > 0 Then
                MessageBox.Show("berhasil", "Mysql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("gagal")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        Call CType(DataGridView1.DataSource, DataTable).Rows.Clear()
        updateTable()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim meDelete As DialogResult
        meDelete = MessageBox.Show("Yakin mau hapus? ", "Mysql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If meDelete = DialogResult.Yes Then
            Try
                connect()
                sqlQuery = "delete from dbpenyewaanmobil.jenismobil where idJenis='" & idHapusj & "'"
                sqlCmd = New MySqlCommand(sqlQuery, sqlConn)

                Dim x As Integer
                x = sqlCmd.ExecuteNonQuery()
                If x > 0 Then
                    MessageBox.Show("berhasil", "Mysql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("gagal")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        Else

        End If
        Call CType(DataGridView1.DataSource, DataTable).Rows.Clear()
        updateTable()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Call CType(DataGridView1.DataSource, DataTable).Rows.Clear()
        Me.Close()

    End Sub
End Class