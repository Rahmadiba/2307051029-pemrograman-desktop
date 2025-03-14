Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim tugas, uts, uas, nilaiAkhir As Double
        Dim grade As String

        If Not Double.TryParse(txtTugas.Text, tugas) OrElse
           Not Double.TryParse(txtUTS.Text, uts) OrElse
           Not Double.TryParse(txtUAS.Text, uas) Then

            MessageBox.Show("Masukkan nilai yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        nilaiAkhir = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)

        Select Case nilaiAkhir
            Case Is >= 78
                grade = "A"
            Case 65 To 77
                grade = "B"
            Case 50 To 64
                grade = "C"
            Case 40 To 49
                grade = "D"
            Case Else
                grade = "E"
        End Select

        Dim gender As String = "Tidak dipilih"
        If rb1.Checked Then
            gender = rb1.Text
        ElseIf rb2.Checked Then
            gender = rb2.Text
        End If

        MessageBox.Show("Hai: " & txtnama.Text & vbCrLf &
                        "NIP: " & txtnip.Text & vbCrLf &
                        "Jenis Kelamin: " & gender & vbCrLf &
                        "Fakultas: " & cbofakultas.Text & vbCrLf &
                        "Jurusan: " & cbojurusan.Text & vbCrLf &
                        "Nilai Akhir: " & nilaiAkhir.ToString("F2") & vbCrLf &
                        "GRADE: " & grade,
                        "Hasil Pengisian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
