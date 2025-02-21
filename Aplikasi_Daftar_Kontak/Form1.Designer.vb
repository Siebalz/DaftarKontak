<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        lvKontak = New ListView()
        email = New TextBox()
        Kirim = New Button()
        Label5 = New Label()
        nomor = New TextBox()
        Label4 = New Label()
        namaLengkap = New TextBox()
        Label3 = New Label()
        ofdKontak = New OpenFileDialog()
        btnPilihFile = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        btnSimpan = New Button()
        SimpanKeFile = New SaveFileDialog()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(28, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 1
        Label1.Text = "DAFTAR KONTAK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(498, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 15)
        Label2.TabIndex = 2
        Label2.Text = "TAMBAH KONTAK"
        ' 
        ' lvKontak
        ' 
        lvKontak.Location = New Point(12, 84)
        lvKontak.Name = "lvKontak"
        lvKontak.Size = New Size(461, 221)
        lvKontak.TabIndex = 9
        lvKontak.UseCompatibleStateImageBehavior = False
        lvKontak.View = View.Details
        ' 
        ' email
        ' 
        email.Location = New Point(600, 189)
        email.Name = "email"
        email.Size = New Size(100, 23)
        email.TabIndex = 6
        ' 
        ' Kirim
        ' 
        Kirim.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Kirim.Location = New Point(542, 234)
        Kirim.Name = "Kirim"
        Kirim.Size = New Size(75, 23)
        Kirim.TabIndex = 8
        Kirim.Text = "Kirim"
        Kirim.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(498, 193)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 7
        Label5.Text = "Email : "
        ' 
        ' nomor
        ' 
        nomor.Location = New Point(600, 160)
        nomor.Name = "nomor"
        nomor.Size = New Size(100, 23)
        nomor.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(498, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 5
        Label4.Text = "Nomor : "
        ' 
        ' namaLengkap
        ' 
        namaLengkap.Location = New Point(600, 131)
        namaLengkap.Name = "namaLengkap"
        namaLengkap.Size = New Size(100, 23)
        namaLengkap.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(498, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nama Lengkap : "
        ' 
        ' ofdKontak
        ' 
        ofdKontak.FileName = "ofdKontak"
        ofdKontak.Filter = """File Teks (*.txt)|*.txt"""
        ' 
        ' btnPilihFile
        ' 
        btnPilihFile.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPilihFile.Location = New Point(12, 323)
        btnPilihFile.Name = "btnPilihFile"
        btnPilihFile.Size = New Size(119, 23)
        btnPilihFile.TabIndex = 10
        btnPilihFile.Text = "Muat Data"
        btnPilihFile.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(494, 263)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(247, 96)
        RichTextBox1.TabIndex = 11
        RichTextBox1.Text = "Jika ingin menambah kontak : " & vbLf & "1. Masukkan semua form di menu ""TAMBAH KONTAK""" & vbLf & "2. Jika sudah pencet tombol Kirim"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(189, 311)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(284, 78)
        RichTextBox2.TabIndex = 12
        RichTextBox2.Text = "Jika ingin memuat data :" & vbLf & "1. Pencet tombol ""Muat Data""" & vbLf & "2. Pilih file yang berisi data dengan ekstensi .txt"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(12, 352)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(119, 23)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan Data"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' SimpanKeFile
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(753, 401)
        Controls.Add(btnSimpan)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(btnPilihFile)
        Controls.Add(lvKontak)
        Controls.Add(Kirim)
        Controls.Add(Label5)
        Controls.Add(email)
        Controls.Add(Label4)
        Controls.Add(nomor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(namaLengkap)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "Form1"
        Text = "HOME"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvKontak As ListView
    Friend WithEvents email As TextBox
    Friend WithEvents Kirim As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents nomor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents namaLengkap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ofdKontak As OpenFileDialog
    Friend WithEvents btnPilihFile As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SimpanKeFile As SaveFileDialog
End Class
