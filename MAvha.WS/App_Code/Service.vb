Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports MAvha.BusinessLogic


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetPersona(ByVal ID As Integer) As PersonaApp
        Dim objPersonaBL As New PersonaBL
        Return objPersonaBL.Load(ID)
    End Function

    <WebMethod()> _
    Public Function GetPersonas() As List(Of PersonaApp)
        Dim objPersonaBL As New PersonaBL
        Return objPersonaBL.LoadActives()
    End Function

    <WebMethod()> _
    Public Sub DeletePersona(ByVal ID As Integer)
        Dim objPersonaBL As New PersonaBL
        objPersonaBL.DeleteLogic(ID)
    End Sub

    <WebMethod()> _
    Public Sub CreatePersona(ByVal newPersona As PersonaApp)
        Dim objPersonaBL As New PersonaBL
        objPersonaBL.Save(newPersona)
    End Sub

    <WebMethod()> _
    Public Sub UpdatePersona(ByVal upPersona As PersonaApp)
        Dim objPersonaBL As New PersonaBL
        objPersonaBL.Save(upPersona)
    End Sub
End Class