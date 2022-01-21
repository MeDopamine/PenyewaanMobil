<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penyewa
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.DataGridPenyewa = New System.Windows.Forms.DataGridView()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RtxAlamat = New System.Windows.Forms.RichTextBox()
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(226, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 51)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Penyewa"
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(545, 250)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(117, 30)
        Me.BtnKembali.TabIndex = 21
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'DataGridPenyewa
        '
        Me.DataGridPenyewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPenyewa.Location = New System.Drawing.Point(235, 103)
        Me.DataGridPenyewa.Name = "DataGridPenyewa"
        Me.DataGridPenyewa.Size = New System.Drawing.Size(427, 141)
        Me.DataGridPenyewa.TabIndex = 20
        '
        'BtnUbah
        '
        Me.BtnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(128, 250)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(110, 30)
        Me.BtnUbah.TabIndex = 19
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(12, 250)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(110, 30)
        Me.BtnTambah.TabIndex = 18
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(83, 135)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(134, 20)
        Me.TxtNama.TabIndex = 16
        '
        'TxtNIK
        '
        Me.TxtNIK.Location = New System.Drawing.Point(83, 103)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(134, 20)
        Me.TxtNIK.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NIK"
        '
        'RtxAlamat
        '
        Me.RtxAlamat.Location = New System.Drawing.Point(83, 166)
        Me.RtxAlamat.Name = "RtxAlamat"
        Me.RtxAlamat.Size = New System.Drawing.Size(134, 70)
        Me.RtxAlamat.TabIndex = 23
        Me.RtxAlamat.Text = ""
        '
        'Penyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 305)
        Me.Controls.Add(Me.RtxAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.DataGridPenyewa)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Penyewa"
        Me.Text = "Penyewa"
        CType(Me.DataGridPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents DataGridPenyewa As DataGridView
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RtxAlamat As RichTextBox
End Class
