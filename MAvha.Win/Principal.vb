Imports MAvha.Win.ServicePersonas

Public Class Principal
    Private Sub tsbNew_Click(sender As Object, e As EventArgs) Handles tsbNew.Click
        Dim winPersona As New WinPersona With {
            .Text = "Nueva Persona"
        }
        winPersona.gbPersona.Text = "Nueva Persona"
        winPersona.ShowDialog()
        Using ws As New ServiceSoapClient
            RefreshGrid(ws)
        End Using
    End Sub

    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        EditarPersona()
    End Sub

    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        Dim value As Object = dgvPersonas.SelectedRows.Item(0)
        Dim personaID As Integer = value.Cells("ID").Value.ToString()

        Dim response As DialogResult = MessageBox.Show($"¿Está seguro de querer eliminar a {value.Cells("Nombre").Value.ToString}?", "Eliminar persona", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If response = DialogResult.OK Then
            Using ws As New ServiceSoapClient
                ws.DeletePersona(personaID)
                RefreshGrid(ws)
            End Using
        End If
    End Sub

    Private Sub RefreshGrid(ws As ServiceSoapClient)
        dgvPersonas.DataSource = ws.GetPersonas()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ws As New ServiceSoapClient
            RefreshGrid(ws)
        End Using
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub dgvPersonas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellContentDoubleClick
        EditarPersona()
    End Sub

    Private Sub EditarPersona()
        Dim value As Object = dgvPersonas.SelectedRows.Item(0)

        If Not IsDBNull(value) Then
            Dim winPersona As New WinPersona With {
                .Text = "Editar Persona"
            }

            winPersona.gbPersona.Text = "Editar Persona"
            winPersona.txtEdad.Text = value.Cells("Edad").Value.ToString
            winPersona.txtID.Text = value.Cells("ID").Value.ToString
            winPersona.dtpNacimiento.Value = value.Cells("Nacimiento").Value
            winPersona.txtNombre.Text = value.Cells("Nombre").Value.ToString

            If value.Cells("Sexo").Value.ToString.ToUpper = "FEMENINO" Then
                winPersona.rbFemale.Checked = True
            Else
                winPersona.rbMale.Checked = True
            End If

            winPersona.ShowDialog()
            Using ws As New ServiceSoapClient
                RefreshGrid(ws)
            End Using
        End If
    End Sub
End Class
