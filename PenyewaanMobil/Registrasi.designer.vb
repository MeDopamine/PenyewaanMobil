<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxUser = New System.Windows.Forms.TextBox()
        Me.TxtBoxPass = New System.Windows.Forms.TextBox()
        Me.BtnDaftar = New System.Windows.Forms.Button()
        Me.PicBoxFoto = New System.Windows.Forms.PictureBox()
        Me.BtnUnggah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtBoxUser
        '
        Me.TxtBoxUser.Location = New System.Drawing.Point(12, 137)
        Me.TxtBoxUser.Name = "TxtBoxUser"
        Me.TxtBoxUser.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxUser.TabIndex = 2
        '
        'TxtBoxPass
        '
        Me.TxtBoxPass.Location = New System.Drawing.Point(12, 195)
        Me.TxtBoxPass.Name = "TxtBoxPass"
        Me.TxtBoxPass.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxPass.TabIndex = 3
        '
        'BtnDaftar
        '
        Me.BtnDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDaftar.Location = New System.Drawing.Point(34, 289)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(100, 30)
        Me.BtnDaftar.TabIndex = 4
        Me.BtnDaftar.Text = "Daftar"
        Me.BtnDaftar.UseVisualStyleBackColor = True
        '
        'PicBoxFoto
        '
        Me.PicBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxFoto.Location = New System.Drawing.Point(167, 112)
        Me.PicBoxFoto.Name = "PicBoxFoto"
        Me.PicBoxFoto.Size = New System.Drawing.Size(160, 176)
        Me.PicBoxFoto.TabIndex = 5
        Me.PicBoxFoto.TabStop = False
        '
        'BtnUnggah
        '
        Me.BtnUnggah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnggah.Location = New System.Drawing.Point(167, 289)
        Me.BtnUnggah.Name = "BtnUnggah"
        Me.BtnUnggah.Size = New System.Drawing.Size(160, 35)
        Me.BtnUnggah.TabIndex = 6
        Me.BtnUnggah.Text = "Unggah"
        Me.BtnUnggah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email"
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(12, 254)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(145, 20)
        Me.TxtBoxEmail.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 51)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Daftar"
        '
        'Registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 336)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBoxEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnUnggah)
        Me.Controls.Add(Me.PicBoxFoto)
        Me.Controls.Add(Me.BtnDaftar)
        Me.Controls.Add(Me.TxtBoxPass)
        Me.Controls.Add(Me.TxtBoxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar"
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxUser As TextBox
    Friend WithEvents TxtBoxPass As TextBox
    Friend WithEvents BtnDaftar As Button
    Friend WithEvents PicBoxFoto As PictureBox
    Friend WithEvents BtnUnggah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents Label4 As Label
End Class
