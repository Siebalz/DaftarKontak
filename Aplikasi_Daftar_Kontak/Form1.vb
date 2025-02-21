Imports System.IO

Public Class Form1
    Private filePath As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mengatur ListView ke mode Detail'
        lvKontak.View = View.Details
        lvKontak.Columns.Add("Nama", 150)
        lvKontak.Columns.Add("Nomor", 100)
        lvKontak.Columns.Add("Email", 200)
    End Sub
    Private Sub Kirim_Click(sender As Object, e As EventArgs) Handles Kirim.Click
        'Mengambil data dari inputan kolom kolom
        Dim nama As String = namaLengkap.Text
        Dim nomorHp As String = nomor.Text
        Dim emailKontak As String = email.Text

        'Membuat percabangan untuk mengisi semua kolom
        If nama <> "" And nomorHp <> "" And emailKontak <> "" Then
            'Buat item baru untuk ListView
            Dim item As New ListViewItem(nama)
            item.SubItems.Add(nomorHp)
            item.SubItems.Add(emailKontak)

            'Tambahkan ke ListView
            lvKontak.Items.Add(item)

            'Kosongkan input setelah ditambahkan
            namaLengkap.Clear()
            nomor.Clear()
            email.Clear()
        Else
            MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnPilihFile_Click(sender As Object, e As EventArgs) Handles btnPilihFile.Click
        ' Membuat OpenFileDialog baru
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "File Teks (*.txt)|*.txt|Semua File (*.*)|*.*"
        ofd.Title = "Pilih File Kontak"

        ' Menampilkan dialog dan memastikan file dipilih
        If ofd.ShowDialog() = DialogResult.OK AndAlso Not String.IsNullOrEmpty(ofd.FileName) Then
            Dim filePath As String = ofd.FileName

            ' Cek apakah ListView sudah diinisialisasi
            If lvKontak Is Nothing Then
                MessageBox.Show("ListView belum tersedia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Bersihkan ListView sebelum menambahkan data baru
            lvKontak.Items.Clear()

            ' Coba baca file
            Try
                Dim lines() As String = File.ReadAllLines(filePath)
                For Each line As String In lines
                    If Not String.IsNullOrWhiteSpace(line) Then
                        Dim data() As String = line.Split(","c)
                        If data.Length >= 3 Then
                            Dim item As New ListViewItem(data(0).Trim()) ' Nama
                            item.SubItems.Add(data(1).Trim()) ' Nomor
                            item.SubItems.Add(data(2).Trim()) ' Email

                            ' Menambahkan ke ListView
                            lvKontak.Items.Add(item)
                        Else
                            MessageBox.Show("Format data salah: " & line, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Next
                MessageBox.Show("Kontak berhasil dimuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membaca file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Tidak ada file yang dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ofdKontak_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdKontak.FileOk
        'Mengatur filter agar hanya menampilkan file teks
        ofdKontak.Filter = "Semua File (*.*)|*.*|File Teks (*.txt)|*.txt"
        ofdKontak.Title = "Pilih File Kontak"

        'Menampilkan dialog dan memeriksa apakah pengguna memilih file
        If ofdKontak.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = ofdKontak.FileName
            MessageBox.Show("File dipilih: " & filePath)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Membuat SaveFileDialog baru
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "File Teks (*.txt)|*.txt|Semua File (*.*)|*.*"
        sfd.Title = "Simpan Kontak"
        sfd.FileName = "kontak.txt"

        ' Menampilkan dialog dan memastikan pengguna memilih lokasi penyimpanan
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                ' Membuka file untuk ditulis
                Using writer As New StreamWriter(sfd.FileName)
                    ' Loop melalui setiap item di ListView dan simpan ke file
                    For Each item As ListViewItem In lvKontak.Items
                        Dim line As String = item.Text & "," & item.SubItems(1).Text & "," & item.SubItems(2).Text
                        writer.WriteLine(line)
                    Next
                End Using

                MessageBox.Show("Kontak berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SimpanKeFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SimpanKeFile.FileOk
        Try
            ' Pastikan filePath tidak kosong
            If String.IsNullOrEmpty(filePath) Then
                MessageBox.Show("Path file belum ditentukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Membuka StreamWriter untuk menulis ke file
            Using writer As New StreamWriter(filePath, False) ' False untuk overwrite
                ' Loop melalui setiap item di ListView dan simpan ke file
                For Each item As ListViewItem In lvKontak.Items
                    Dim line As String = item.Text & "," & item.SubItems(1).Text & "," & item.SubItems(2).Text
                    writer.WriteLine(line)
                Next
            End Using

            MessageBox.Show("Kontak berhasil disimpan ke file!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
