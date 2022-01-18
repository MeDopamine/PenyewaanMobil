<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sewa
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePinjam = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeKembali = New System.Windows.Forms.DateTimePicker()
        Me.ComBoxPenyewa = New System.Windows.Forms.ComboBox()
        Me.ComBoxMerk = New System.Windows.Forms.ComboBox()
        Me.TxtBoxDurasi = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.DataGridSewa = New System.Windows.Forms.DataGridView()
        Me.ComBoxSewa = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.LblTotalSewa = New System.Windows.Forms.Label()
        Me.LblLebihPinjam = New System.Windows.Forms.Label()
        Me.LblTotalBayar = New System.Windows.Forms.Label()
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penyewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Merk Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status Sewa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Durasi Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Pinjam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Kembali"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Sewa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Lebih Pinjam"
        '
        'DateTimePinjam
        '
        Me.DateTimePinjam.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePinjam.Location = New System.Drawing.Point(131, 226)
        Me.DateTimePinjam.Name = "DateTimePinjam"
        Me.DateTimePinjam.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePinjam.TabIndex = 9
        '
        'DateTimeKembali
        '
        Me.DateTimeKembali.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimeKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeKembali.Location = New System.Drawing.Point(131, 258)
        Me.DateTimeKembali.Name = "DateTimeKembali"
        Me.DateTimeKembali.Size = New System.Drawing.Size(142, 20)
        Me.DateTimeKembali.TabIndex = 10
        '
        'ComBoxPenyewa
        '
        Me.ComBoxPenyewa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxPenyewa.FormattingEnabled = True
        Me.ComBoxPenyewa.Location = New System.Drawing.Point(131, 98)
        Me.ComBoxPenyewa.Name = "ComBoxPenyewa"
        Me.ComBoxPenyewa.Size = New System.Drawing.Size(142, 21)
        Me.ComBoxPenyewa.TabIndex = 11
        '
        'ComBoxMerk
        '
        Me.ComBoxMerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxMerk.FormattingEnabled = True
        Me.ComBoxMerk.Location = New System.Drawing.Point(131, 130)
        Me.ComBoxMerk.Name = "ComBoxMerk"
        Me.ComBoxMerk.Size = New System.Drawing.Size(142, 21)
        Me.ComBoxMerk.TabIndex = 12
        '
        'TxtBoxDurasi
        '
        Me.TxtBoxDurasi.Location = New System.Drawing.Point(131, 194)
        Me.TxtBoxDurasi.Name = "TxtBoxDurasi"
        Me.TxtBoxDurasi.Size = New System.Drawing.Size(110, 20)
        Me.TxtBoxDurasi.TabIndex = 13
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(13, 387)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(123, 30)
        Me.BtnTambah.TabIndex = 18
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(150, 387)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(123, 30)
        Me.BtnUbah.TabIndex = 19
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'DataGridSewa
        '
        Me.DataGridSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSewa.Location = New System.Drawing.Point(293, 98)
        Me.DataGridSewa.Name = "DataGridSewa"
        Me.DataGridSewa.Size = New System.Drawing.Size(495, 276)
        Me.DataGridSewa.TabIndex = 20
        '
        'ComBoxSewa
        '
        Me.ComBoxSewa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxSewa.FormattingEnabled = True
        Me.ComBoxSewa.Items.AddRange(New Object() {"Sedang disewa", "Tidak Sedang disewa"})
        Me.ComBoxSewa.Location = New System.Drawing.Point(131, 162)
        Me.ComBoxSewa.Name = "ComBoxSewa"
        Me.ComBoxSewa.Size = New System.Drawing.Size(142, 21)
        Me.ComBoxSewa.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(247, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Jam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(353, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 51)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Sewa"
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(666, 387)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(122, 30)
        Me.BtnKembali.TabIndex = 24
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'LblTotalSewa
        '
        Me.LblTotalSewa.AutoSize = True
        Me.LblTotalSewa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSewa.Location = New System.Drawing.Point(128, 289)
        Me.LblTotalSewa.Name = "LblTotalSewa"
        Me.LblTotalSewa.Size = New System.Drawing.Size(118, 15)
        Me.LblTotalSewa.TabIndex = 26
        Me.LblTotalSewa.Text = "Label Total Sewa"
        '
        'LblLebihPinjam
        '
        Me.LblLebihPinjam.AutoSize = True
        Me.LblLebihPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLebihPinjam.Location = New System.Drawing.Point(128, 328)
        Me.LblLebihPinjam.Name = "LblLebihPinjam"
        Me.LblLebihPinjam.Size = New System.Drawing.Size(132, 15)
        Me.LblLebihPinjam.TabIndex = 27
        Me.LblLebihPinjam.Text = "Label Lebih Pinjam"
        '
        'LblTotalBayar
        '
        Me.LblTotalBayar.AutoSize = True
        Me.LblTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBayar.Location = New System.Drawing.Point(128, 359)
        Me.LblTotalBayar.Name = "LblTotalBayar"
        Me.LblTotalBayar.Size = New System.Drawing.Size(119, 15)
        Me.LblTotalBayar.TabIndex = 28
        Me.LblTotalBayar.Text = "Label Total Bayar"
        '
        'Sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 429)
        Me.Controls.Add(Me.LblTotalBayar)
        Me.Controls.Add(Me.LblLebihPinjam)
        Me.Controls.Add(Me.LblTotalSewa)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComBoxSewa)
        Me.Controls.Add(Me.DataGridSewa)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtBoxDurasi)
        Me.Controls.Add(Me.ComBoxMerk)
        Me.Controls.Add(Me.ComBoxPenyewa)
        Me.Controls.Add(Me.DateTimeKembali)
        Me.Controls.Add(Me.DateTimePinjam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Sewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sewa"
        CType(Me.DataGridSewa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePinjam As DateTimePicker
    Friend WithEvents DateTimeKembali As DateTimePicker
    Friend WithEvents ComBoxPenyewa As ComboBox
    Friend WithEvents ComBoxMerk As ComboBox
    Friend WithEvents TxtBoxDurasi As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents DataGridSewa As DataGridView
    Friend WithEvents ComBoxSewa As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblTotalSewa As Label
    Friend WithEvents LblLebihPinjam As Label
    Friend WithEvents LblTotalBayar As Label
End Class
