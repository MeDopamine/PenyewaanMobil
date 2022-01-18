Public Class InfoTambahPenyewa

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbNama.Text = FormPenyewa.penyewa.GSNamaPenyewa
        LbNIK.Text = FormPenyewa.penyewa.GSNikPenyewa
        LbAlamat.Text = FormPenyewa.penyewa.GSAlamatPenyewa
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        FormPenyewa.penyewa.AddPenyewaDatabase(FormPenyewa.penyewa.GSNamaPenyewa, FormPenyewa.penyewa.GSNikPenyewa, FormPenyewa.penyewa.GSAlamatPenyewa)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class