
Public Class FormPenyewa
    Public Shared penyewa As New PenyewaClass

    Public Shared id As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridPenyewa.DataSource = penyewa.GetDataPenyewaDatabase
    End Sub
    Private Sub FormPenyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only!")
        End If
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub DataGridViewPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPenyewa.CellClick
        id = DataGridPenyewa.CurrentRow.Index

        Try
            TxtNIK.Text = DataGridPenyewa(1, id).Value
            TxtNama.Text = DataGridPenyewa(2, id).Value
            RtxAlamat.Text = DataGridPenyewa(3, id).Value
        Catch ex As Exception
            TxtNIK.Clear()
            TxtNama.Clear()
            RtxAlamat.Clear()
        End Try

    End Sub


    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click

        Call CType(DataGridPenyewa.DataSource, DataTable).Rows.Clear()
        Me.Close()

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        penyewa.GSNikPenyewa = TxtNIK.Text
        penyewa.GSNamaPenyewa = TxtNama.Text
        penyewa.GSAlamatPenyewa = RtxAlamat.Text

        Dim tambah As New InfoTambahPenyewa
        tambah.Show()

        TxtNIK.Clear()
        TxtNama.Clear()
        RtxAlamat.Clear()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        penyewa.GSNikPenyewa = TxtNIK.Text
        penyewa.GSNamaPenyewa = TxtNama.Text
        penyewa.GSAlamatPenyewa = RtxAlamat.Text

        Dim ubah As New InfoUbahPenyewa
        ubah.Show()

        TxtNIK.Clear()
        TxtNama.Clear()
        RtxAlamat.Clear()
    End Sub

End Class