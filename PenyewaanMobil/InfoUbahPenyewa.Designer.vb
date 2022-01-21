<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoUbahPenyewa
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
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.LbNama = New System.Windows.Forms.Label()
        Me.LbNIK = New System.Windows.Forms.Label()
        Me.LbAlamat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(215, 224)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(81, 23)
        Me.BtnBatal.TabIndex = 62
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(62, 224)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(81, 23)
        Me.BtnOK.TabIndex = 61
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'LbNama
        '
        Me.LbNama.AutoSize = True
        Me.LbNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNama.Location = New System.Drawing.Point(127, 96)
        Me.LbNama.Name = "LbNama"
        Me.LbNama.Size = New System.Drawing.Size(39, 13)
        Me.LbNama.TabIndex = 60
        Me.LbNama.Text = "Nama"
        '
        'LbNIK
        '
        Me.LbNIK.AutoSize = True
        Me.LbNIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNIK.Location = New System.Drawing.Point(127, 129)
        Me.LbNIK.Name = "LbNIK"
        Me.LbNIK.Size = New System.Drawing.Size(39, 13)
        Me.LbNIK.TabIndex = 59
        Me.LbNIK.Text = "Nama"
        '
        'LbAlamat
        '
        Me.LbAlamat.AutoSize = True
        Me.LbAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAlamat.Location = New System.Drawing.Point(127, 168)
        Me.LbAlamat.Name = "LbAlamat"
        Me.LbAlamat.Size = New System.Drawing.Size(39, 13)
        Me.LbAlamat.TabIndex = 58
        Me.LbAlamat.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 25)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Anda akan mengubah..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "NIK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nama"
        '
        'InfoUbahPeyewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 291)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.LbNama)
        Me.Controls.Add(Me.LbNIK)
        Me.Controls.Add(Me.LbAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfoUbahPeyewa"
        Me.Text = "InfoUbahPeyewa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents LbNama As Label
    Friend WithEvents LbNIK As Label
    Friend WithEvents LbAlamat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
