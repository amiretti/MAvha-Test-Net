﻿Public Class Persona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs)
        Response.Redirect("/Home.aspx")
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class