Imports MAvha.Win.ServicePersonas

Public Class WinPersona
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text.Trim() = String.Empty Then
            MessageBox.Show("Por favor complete el campo Nombre", "Complete datos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using ws As New ServiceSoapClient
                    Dim newPersona As New PersonaApp With {
                        .Nombre = txtNombre.Text.Trim(),
                        .Nacimiento = dtpNacimiento.Value,
                        .Sexo = GetSexStr(rbFemale.Checked)
                    }

                    If Not txtID.Text.Trim() = String.Empty Then
                        newPersona.ID = txtID.Text
                        ws.UpdatePersona(newPersona)
                    Else
                        ws.CreatePersona(newPersona)
                    End If

                End Using
                Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al intentar guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetSexStr(femenino As Boolean) As String
        If femenino Then
            Return "Femenino"
        Else
            Return "Masculino"
        End If
    End Function
End Class