Public Class InfoUbahPenyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbNama.Text = FormPenyewa.penyewa.GSNamaPenyewa
        LbNIK.Text = FormPenyewa.penyewa.GSNikPenyewa
        LbAlamat.Text = FormPenyewa.penyewa.GSAlamatPenyewa
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        FormPenyewa.penyewa.UpdatePenyewaDatabase(FormPenyewa.id, FormPenyewa.penyewa.GSNamaPenyewa,
                                      FormPenyewa.penyewa.GSNikPenyewa, FormPenyewa.penyewa.GSAlamatPenyewa)

        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class