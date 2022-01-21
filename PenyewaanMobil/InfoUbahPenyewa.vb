﻿Public Class InfoUbahPenyewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LbNama.Text = Penyewa.penyewa.GSNamaPenyewa
        LbNIK.Text = Penyewa.penyewa.GSNikPenyewa
        LbAlamat.Text = Penyewa.penyewa.GSAlamatPenyewa
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Penyewa.penyewa.UpdatePenyewaDatabase(Penyewa.id, Penyewa.penyewa.GSNamaPenyewa,
                                      Penyewa.penyewa.GSNikPenyewa, Penyewa.penyewa.GSAlamatPenyewa)

        Penyewa.TxtNama.Clear()
        Penyewa.TxtNIK.Clear()
        Penyewa.RtxAlamat.Clear()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class