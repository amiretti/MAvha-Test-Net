Imports MAvha.Web.ServicePersonas

Public Class Persona
    Inherits System.Web.UI.Page

    Protected strPersonaID As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            strPersonaID = Request.QueryString("ID")
            Dim objPersona As New PersonaApp
            Using ws As New ServiceSoapClient
                objPersona = ws.GetPersona(strPersonaID)
                txtID.Value = objPersona.ID
                txtName.Text = objPersona.Nombre
                txtEdad.Text = objPersona.Edad
                txtNacimiento.Text = objPersona.Nacimiento.ToShortDateString()
                If objPersona.Sexo.ToUpper = "FEMENINO" Then
                    rbFemale.Checked = True
                Else
                    rbMale.Checked = True
                End If
            End Using
        End If
    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Home.aspx")
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim objPersona As New PersonaApp
        Dim resultNac As DateTime

        Using ws As New ServiceSoapClient
            objPersona.ID = txtID.Value
            objPersona.Nombre = txtName.Text
            If DateTime.TryParse(txtNacimiento.Text, resultNac) Then
                objPersona.Nacimiento = resultNac
            End If

            If rbFemale.Checked Then
                objPersona.Sexo = "Femenino"
            Else
                objPersona.Sexo = "Masculino"
            End If

            ws.UpdatePersona(objPersona)
            Response.Redirect("/Home.aspx")
        End Using
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class