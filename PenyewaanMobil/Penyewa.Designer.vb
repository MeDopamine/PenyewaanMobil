<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenyewa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DataGridPenyewa = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RtxAlamat = New System.Windows.Forms.RichTextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(535, 241)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(99, 30)
        Me.BtnKembali.TabIndex = 10
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 51)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Penyewa"
        '
        'BtnUbah
        '
        Me.BtnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(128, 241)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(98, 30)
        Me.BtnUbah.TabIndex = 14
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(12, 241)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(98, 30)
        Me.BtnTambah.TabIndex = 13
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DataGridPenyewa
        '
        Me.DataGridPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenyewa.Location = New System.Drawing.Point(210, 74)
        Me.DataGridPenyewa.Name = "DataGridPenyewa"
        Me.DataGridPenyewa.Size = New System.Drawing.Size(448, 152)
        Me.DataGridPenyewa.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nama"
        '
        'RtxAlamat
        '
        Me.RtxAlamat.Location = New System.Drawing.Point(73, 146)
        Me.RtxAlamat.Name = "RtxAlamat"
        Me.RtxAlamat.Size = New System.Drawing.Size(113, 80)
        Me.RtxAlamat.TabIndex = 17
        Me.RtxAlamat.Text = ""
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(73, 107)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(113, 20)
        Me.TxtNIK.TabIndex = 16
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(73, 71)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(113, 20)
        Me.TxtNama.TabIndex = 15
        '
        'FormPenyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 283)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RtxAlamat)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridPenyewa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnKembali)
        Me.Name = "FormPenyewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penyewa"
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents DataGridPenyewa As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RtxAlamat As RichTextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents TxtNama As TextBox
End Class
