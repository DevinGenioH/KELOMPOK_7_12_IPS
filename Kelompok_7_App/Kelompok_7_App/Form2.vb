Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(TxtNama.Text & vbCrLf & CmbKelas.Text & vbCrLf & CmbJenisKelamin.Text & vbCrLf & CmbMataPelajaran.Text, "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNama.TextChanged

    End Sub
End Class