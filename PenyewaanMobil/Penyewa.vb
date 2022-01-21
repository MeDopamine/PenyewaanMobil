Public Class Penyewa
    Public Shared penyewa As New ClassPenyewa
    Public Shared id As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataGridPenyewa()
    End Sub

    Private Sub ReloadDataGridPenyewa()
        DataGridPenyewa.DataSource = penyewa.GetDataPenyewaDatabase
    End Sub

    Private Sub Penyewa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataGridPenyewa()
    End Sub

    Private Sub DataGridViewPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPenyewa.CellClick
        Dim i As Integer = DataGridPenyewa.CurrentRow.Index

        Try
            id = DataGridPenyewa.Rows(i).Cells(0).Value
            TxtNama.Text = DataGridPenyewa(2, id).Value
            TxtNIK.Text = DataGridPenyewa(1, id).Value
            RtxAlamat.Text = DataGridPenyewa(3, id).Value
        Catch ex As Exception
            TxtNama.Clear()
            TxtNIK.Clear()
            RtxAlamat.Clear()
        End Try

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
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        penyewa.GSNamaPenyewa = TxtNama.Text
        penyewa.GSNikPenyewa = TxtNIK.Text
        penyewa.GSAlamatPenyewa = RtxAlamat.Text

        Dim info As New InfoTambahPenyewa
        info.Show()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        penyewa.GSNamaPenyewa = TxtNama.Text
        penyewa.GSNikPenyewa = TxtNIK.Text
        penyewa.GSAlamatPenyewa = RtxAlamat.Text

        Dim info As New InfoUbahPenyewa()
        info.Show()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub
End Class