Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class Sewa

    Public Shared durasi As Integer
    Public Shared totalsewa As Integer
    Public Shared totalbayar As Integer
    Public Shared sewa As Integer
    Public Shared idS As Integer
    Public Shared merek As String
    Public Shared penyewa As String
    Public Shared status As String
    Public Shared keluar As String
    Public Shared masuk As String
    Public Shared lebihpinjam As Integer
    Public Shared totalharga As Integer
    Private harga As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        updateTable()
    End Sub
    Public Sub updateTable()

        connect()

        Dim sqlDts As New DataTable

        sqlCmd.CommandText = "select idSewa as ID, penyewa as 'Penyewa', merekSewa as 'Tipe Mobil', statusSewa as 'Status', rencanaPinjam as 'Durasi Pinjam', 
                              tanggalPinjam as 'Tanggal Pinjam', tanggalKembali as 'Tanggal Kembali', totalSewa as 'Total Harga Sewa', totalBayar as 'Total Bayar', biayaKelebihan as 'Biaya Tambahan' 
                              from sewa"
        sqlDr = sqlCmd.ExecuteReader
        sqlDts.Load(sqlDr)
        sqlDr.Close()
        sqlConn.Close()
        DataGridSewa.DataSource = sqlDts

    End Sub

    Public Sub hargaSewa()

        Try
            connect()
            merek = ComBoxMerk.SelectedItem().ToString()
            sqlQuery = "select hargaSewaMobil from mobil where merekMobil='" & ComBoxMerk.SelectedItem & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlDr = sqlCmd.ExecuteReader
            While sqlDr.Read
                sewa = sqlDr("hargaSewaMobil")
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        sqlDr.Close()
    End Sub

    Private Sub Sewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildatacomboboxnama()
        tampildatacomboboxmerk()
        updateTable()
    End Sub

    Private Sub DataGridSewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSewa.CellClick

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridSewa.Rows(e.RowIndex)
                idS = row.Cells(0).Value.ToString()
                ComBoxPenyewa.SelectedItem() = row.Cells(1).Value.ToString()
                ComBoxMerk.SelectedItem() = row.Cells(2).Value.ToString()
                ComBoxSewa.SelectedItem() = row.Cells(3).Value.ToString()
                TxtBoxDurasi.Text = row.Cells(4).Value.ToString()
                DateTimePinjam.Value = row.Cells(5).Value.ToString()
                DateTimeKembali.Value = row.Cells(6).Value.ToString()
                LblTotalSewa.Text = row.Cells(7).Value.ToString()
                LblLebihPinjam.Text = row.Cells(9).Value.ToString()
                LblTotalBayar.Text = row.Cells(8).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        penyewa = ComBoxPenyewa.SelectedItem
        merek = ComBoxMerk.SelectedItem
        status = ComBoxSewa.SelectedItem
        durasi = TxtBoxDurasi.Text
        masuk = DateTimeKembali.Value.ToString("yyyy-MM-dd HH:mm:ss")
        keluar = DateTimePinjam.Value.ToString("yyyy-MM-dd HH:mm:ss")
        totalharga = LblTotalSewa.Text

        connect()
        sqlCmd.Connection = sqlConn
        sqlQuery = "INSERT INTO sewa(merekSewa, penyewa, rencanaPinjam, tanggalPinjam, tanggalKembali, totalSewa, biayaKelebihan, totalBayar, statusSewa) VALUE('" _
                    & merek & "', '" _
                    & penyewa & "', '" _
                    & durasi & "', '" _
                    & keluar & "', '" _
                    & masuk & "', '" _
                    & totalharga & "', '" _
                    & lebihpinjam & "', '" _
                    & totalbayar & "', '" _
                    & status & "')"
        sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        penyewa = ComBoxPenyewa.SelectedItem
        merek = ComBoxMerk.SelectedItem
        status = ComBoxSewa.SelectedItem
        durasi = TxtBoxDurasi.Text
        masuk = DateTimeKembali.Value.ToString("yyyy-MM-dd HH:mm:ss")
        keluar = DateTimePinjam.Value.ToString("yyyy-MM-dd HH:mm:ss")
        totalharga = LblTotalSewa.Text
        connect()
        Try
            sqlCmd.Connection = sqlConn
            sqlQuery = "UPDATE sewa SET
                        merekSewa='" & merek & "',
                        penyewa='" & penyewa & "',
                        rencanaPinjam='" & durasi & "',
                        tanggalPinjam='" & keluar & "',
                        tanggalKembali='" & masuk & "',
                        totalSewa='" & totalharga & "',
                        biayaKelebihan='" & lebihpinjam & "',
                        totalBayar='" & totalbayar & "',
                        statusSewa='" & status & "'
                        WHERE idSewa='" & idS & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()
            updateTable()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click

        Call CType(DataGridSewa.DataSource, DataTable).Rows.Clear()
        Me.Close()
    End Sub
    Private Sub tampildatacomboboxnama()
        connect()
        Try
            sqlCmd = New MySqlCommand("SELECT namaPenyewa FROM penyewa ORDER BY idPenyewa", sqlConn)
            sqlDr = sqlCmd.ExecuteReader
            While sqlDr.Read
                ComBoxPenyewa.Items.Add(sqlDr("namaPenyewa"))
            End While
            sqlDr.Close()
            sqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tampildatacomboboxmerk()
        connect()
        Try
            sqlCmd = New MySqlCommand("SELECT merekMobil FROM mobil ORDER BY idMobil", sqlConn)
            sqlDr = sqlCmd.ExecuteReader
            While sqlDr.Read
                ComBoxMerk.Items.Add(sqlDr("merekMobil"))
            End While
            sqlDr.Close()
            sqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComBoxMerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBoxMerk.SelectedIndexChanged
        connect()
        sqlCmd.CommandText = "SELECT hargaSewaMobil FROM mobil WHERE merekMobil='" & ComBoxMerk.SelectedItem & "'"
        sqlDr = sqlCmd.ExecuteReader
        sqlDr.Read()
        harga = sqlDr("hargaSewaMobil")
        LblTotalSewa.Text = harga
        sqlDr.Close()
        sqlConn.Close()
    End Sub

    Private Sub TxtBoxDurasi_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDurasi.TextChanged
        If TxtBoxDurasi.Text.Trim.Length = 0 Then
            TxtBoxDurasi.Text = 0
            LblTotalSewa.Text = harga * TxtBoxDurasi.Text
        Else
            LblTotalSewa.Text = harga * TxtBoxDurasi.Text
        End If
        hitung()
    End Sub

    Private Sub DateTimeKembali_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeKembali.ValueChanged
        hitung()
    End Sub

    Private Sub TxtBoxDurasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxDurasi.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function hitung()
        Dim duration As TimeSpan = DateTimeKembali.Value - DateTimePinjam.Value
        Dim i As Integer = duration.TotalHours
        If duration.Minutes > 0 Or duration.Seconds > 0 Or duration.Hours > 0 Then
            lebihpinjam = (i - durasi) * harga
            MessageBox.Show(i)
        Else
            lebihpinjam = 0
        End If
        durasi = TxtBoxDurasi.Text
        totalharga = harga * TxtBoxDurasi.Text

        LblLebihPinjam.Text = lebihpinjam
        totalbayar = totalharga + lebihpinjam
        LblTotalBayar.Text = totalbayar
    End Function
End Class