Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Mobil

    Public Shared id As Integer
    Public Shared jenis As String
    Public Shared merek As String
    Public Shared jumlah As Integer
    Public Shared harga As Integer
    Public Shared tahun As Integer
    Public Shared status As String
    Public Shared img As String
    Public Shared idHapus As Integer

    Private Sub updateTable()

        connect()

        Dim sqlDtm As New DataTable

        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "select idMobil as ID, jenisMobil as 'Jenis Mobil', merekMobil as Brand,
                              jumlahMobil as Jumlah, hargaSewaMobil as 'Harga Sewa', tahunPembuatanMobil 'Tahun Pembuatan',
                              statusSewaMobil as 'Status Sewa' from dbpenyewaanmobil.mobil"
        sqlDr = sqlCmd.ExecuteReader
        sqlDtm.Load(sqlDr)
        sqlDr.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDtm

    End Sub

    Private Sub Mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateTable()
        Try
            connect()
            sqlQuery = "select namaJenis from dbpenyewaanmobil.jenismobil order by idJenis"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlDr = sqlCmd.ExecuteReader

            While sqlDr.Read
                ComboBox1.Items.Add(sqlDr("namaJenis"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        sqlDr.Close()

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True
        DataGridView1.Columns(6).ReadOnly = True

    End Sub

    Private Sub getData()

        id = Integer.Parse(TextBox1.Text)
        jenis = ComboBox1.SelectedItem().ToString()
        merek = TextBox2.Text.ToString()
        jumlah = Integer.Parse(TextBox3.Text)
        harga = Integer.Parse(TextBox4.Text)
        tahun = Integer.Parse(TextBox5.Text)
        status = ComboBox2.SelectedItem().ToString()
        img = imgPath

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(0).Value
            ComboBox1.SelectedItem() = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            TextBox3.Text = DataGridView1.SelectedRows(0).Cells(3).Value
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(4).Value
            TextBox5.Text = DataGridView1.SelectedRows(0).Cells(5).Value
            ComboBox2.SelectedItem() = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
            idHapus = DataGridView1.SelectedRows(0).Cells(0).Value
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        getData()

        Try

            connect()
            sqlQuery = "insert into mobil(idMobil, jenisMobil, merekMobil, jumlahMobil, hargaSewaMobil, tahunPembuatanMobil, statusSewaMobil, fotoMobil) 
                        value('" & id & "','" & jenis & "','" & merek &
                            "','" & jumlah & "','" & harga & "','" & tahun &
                            "','" & status & "','" & img & "')"
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
                sqlQuery = "delete from dbpenyewaanmobil.mobil where idMobil='" & idHapus & "'"
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

        getData()

        Try
            connect()
            sqlQuery = "update mobil set " & "idMobil='" & id & "', " & "jenisMobil='" & jenis & "', " & "merekMobil='" & merek & "', " &
                       "jumlahMobil='" & jumlah & "', " & "hargaSewaMobil='" & harga & "', " & "tahunPembuatanMobil='" & tahun & "', " &
                       "statusSewaMobil='" & status & "', " & "fotoMobil='" & img & "' " &
                       "WHERE idMobil='" & id & "'"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            ofd = New OpenFileDialog()

            ofd.Title = "Open"
            ofd.Filter = "All Format|*.*"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgPath = ofd.FileName
                PictureBox1.ImageLocation = imgPath
                img = imgPath

                PictureBox1.Load(img)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If

            ofd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Call CType(DataGridView1.DataSource, DataTable).Rows.Clear()
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class