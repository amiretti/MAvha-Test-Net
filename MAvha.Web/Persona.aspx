<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Persona.aspx.vb" Inherits="MAvha.Web.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="offset-md-2 col-md-8">
        <div class="col-md-12">
            <label for="txtName">Nombre completo</label>
            <input type="text" name="txtName" id="txtName" placeholder="Ej: Juan Perez" runat="server" class="form-control" />
        </div>
        <div class="col-md-12">
            <label for="txtNacimiento">Fecha de nacimiento</label>
            <asp:TextBox name="txtNacimiento" id="txtNacimiento" runat="server" CssClass="form-control" placeholder="12/12/2018" />
        </div>
        <div class="col-md-3">
            <label for="txtEdad">Edad</label>
            <asp:TextBox name="txtEdad" id="txtEdad" runat="server" CssClass="form-control" Enabled="false" />
        </div>
        <div class="col-md-6">
            <label>Sexo: </label>
            <asp:RadioButton Text="Femenino" GroupName="Sexo" ID="rbFemale" Checked="true" runat="server"/>
            <asp:RadioButton Text="Masculino" GroupName="Sexo" ID="rbMale" runat="server"/>
        </div>
        <div class="col-md-12 text-right">
            <asp:Button ID="btnVolver" Text="Volver" CssClass="btn btn-default" runat="server" OnClick="btnVolver_Click"/>
            <asp:Button ID="btnEliminar" Text="Eliminar" CssClass="btn btn-danger" runat="server" OnClick="btnEliminar_Click"/>
            <asp:Button ID="btnGuardar" Text="Guardar" Width="200" CssClass="btn btn-success" runat="server" OnClick="btnGuardar_Click"/>
        </div>
    </div>
</asp:Content>