Imports MAvha.Web.ServicePersonas

Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Using ws As New ServiceSoapClient
            gvPersonas.DataSource = ws.GetPersonas()
            gvPersonas.DataBind()
        End Using
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs)
        Using ws As New ServiceSoapClient
            Dim newPersona As New PersonaApp With {
                .Nombre = txtName.Value,
                .Nacimiento = txtNacimiento.Text
            }

            If rbFemale.Checked Then
                newPersona.Sexo = "Femenino"
            Else
                newPersona.Sexo = "Masculino"
            End If

            ws.CreatePersona(newPersona)

            gvPersonas.DataSource = ws.GetPersonas()
            gvPersonas.DataBind()
        End Using
    End Sub

    Protected Sub gvPersonas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvPersonas.RowCommand
        If e.CommandName = "Select" Then
            Dim PersonaID = gvPersonas.DataKeys(e.CommandArgument).Item("ID").ToString()
            Response.Redirect("/Persona.aspx?ID=" + PersonaID)
        End If
    End Sub

    Protected Sub gvPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvPersonas.SelectedIndexChanged

    End Sub

    Protected Sub gvPersonas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles gvPersonas.RowDeleting
        Using ws As New ServiceSoapClient

            Dim PersonaID = gvPersonas.DataKeys(e.RowIndex).Item("ID").ToString()
            ws.DeletePersona(PersonaID)

            gvPersonas.DataSource = ws.GetPersonas()
            gvPersonas.DataBind()
        End Using
    End Sub
End Class