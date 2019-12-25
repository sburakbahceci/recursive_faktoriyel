Public Class Form1
    Private Function faktoriyel(ByVal b As Integer) As Integer
        If b <= 1 Then
            Return 1
        Else
            Return faktoriyel(b - 1) * b
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deger As Integer
        deger = Val(TextBox1.Text)

        Try
            If TextBox1.Text <> " " Or TextBox1.Text <> 0 Then
                TextBox1.Text = faktoriyel(deger)
            End If
        Catch ex As Exception
            MessageBox.Show("Lütfen boşluğu doldurunuz", "Değer Yok", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
