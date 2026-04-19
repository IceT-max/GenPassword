Imports System.Security.Cryptography

Public Class Form1

    Private Function GeneraPassword(caratteri As String, lunghezza As Integer) As String
        Dim password As New System.Text.StringBuilder(lunghezza)
        Dim buffer(3) As Byte
        For i As Integer = 1 To lunghezza
            RandomNumberGenerator.Fill(buffer)
            Dim indice As Integer = CInt(BitConverter.ToUInt32(buffer, 0) Mod CUInt(caratteri.Length))
            password.Append(caratteri(indice))
        Next
        Return password.ToString()
    End Function

    Private Sub btnGenera_Click(sender As Object, e As EventArgs) Handles btnGenera.Click
        Dim caratteri As String = ""
        If chkMaiuscole.Checked Then caratteri &= "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        If chkMinuscole.Checked Then caratteri &= "abcdefghijklmnopqrstuvwxyz"
        If chkNumeri.Checked Then caratteri &= "0123456789"
        If chkSimboli.Checked Then caratteri &= ",.;:-+*?!$%&()[]"

        If caratteri.Length = 0 Then
            MessageBox.Show("Seleziona almeno un tipo di carattere.", "Attenzione",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim lunghezza As Integer = CInt(numLunghezza.Value)
        Dim quantita As Integer = CInt(numQuantita.Value)
        Dim righe As New System.Text.StringBuilder()

        For i As Integer = 1 To quantita
            righe.AppendLine(GeneraPassword(caratteri, lunghezza))
        Next

        txtPassword.Text = righe.ToString().TrimEnd()
    End Sub

    Private Sub btnCopia_Click(sender As Object, e As EventArgs) Handles btnCopia.Click
        If txtPassword.Text.Length = 0 Then
            MessageBox.Show("Nessuna password da copiare. Generane prima una.", "Attenzione",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Clipboard.SetText(txtPassword.Text)
        MessageBox.Show("Password copiate negli appunti!", "Copiato",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
