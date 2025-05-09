Public Class AlgorithmControl
    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click
        Try
            Dim param1 As Double = CDbl(txtIfA.Text)
            Dim param2 As Double = CDbl(txtIfB.Text)
            Dim result As String
            If param1 > param2 Then
                result = "Parameter 1 Lebih Besar dari Parameter 2"
            ElseIf param1 < param2 Then
                result = "Parameter 1 Lebih Kecil dari Parameter 2"
            ElseIf param1 = param2 Then
                result = "Parameter 1 dan Parameter 2 sama besar"
            Else
                result = "Parameter 1 masuk blok else"
            End If

            txtIfResult.Text = result
        Catch ex As Exception
            If txtIfA.Text = txtIfB.Text Then
                txtIfResult.Text = "Alphabet sama"
            Else
                txtIfResult.Text = "Alphabet beda"
            End If
        End Try
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Try
            Select Case CDbl(txtSwitchA.Text)
                Case 10
                    txtSwitchResult.Text = "Dapet 10"
                Case 20
                    txtSwitchResult.Text = "Dapet 20"
                Case 30
                    txtSwitchResult.Text = "Dapet 30"
                Case Else
                    txtSwitchResult.Text = "Dapet Else"
            End Select

        Catch ex As Exception
            txtSwitchResult.Text = "Bukan Numeric"
        End Try
    End Sub
End Class
