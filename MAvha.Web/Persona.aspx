<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Persona.aspx.vb" Inherits="MAvha.Web.Persona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="offset-md-2 col-md-8">
            <div class="col-md-12">
                <label for="ctl00_ContentPlaceHolder1_txtName">Nombre completo</label>
                <asp:TextBox name="txtName" ID="txtName" runat="server" EnableViewState="True" placeholder="Ej: Juan Perez" CssClass="form-control" />
            </div>
            <div class="col-md-12">
                <label for="ctl00_ContentPlaceHolder1_txtNacimiento">Fecha de nacimiento</label>
                <asp:TextBox name="txtNacimiento" id="txtNacimiento" runat="server" EnableViewState= "true" AutoPostBack="true" CssClass="form-control" placeholder="12/12/2018" />
            </div>
            <div class="col-md-3">
                <label for="txtEdad">Edad</label>
                <asp:TextBox name="txtEdad" id="txtEdad" runat="server" CssClass="form-control" Enabled="false" />
            </div>
            <asp:HiddenField ID="txtID" runat="server" />
            <div class="col-md-6">
                <label>Sexo: </label>
                <asp:RadioButton Text="Femenino" GroupName="Sexo" ID="rbFemale" Checked="true" runat="server"/>
                <asp:RadioButton Text="Masculino" GroupName="Sexo" ID="rbMale" runat="server"/>
            </div>
        
            <div class="col-md-12 text-right">
                <asp:Button ID="btnVolver" Text="Volver" CssClass="btn btn-default" runat="server" OnClick="btnVolver_Click"/>
                <asp:Button ID="btnEliminar" Text="Eliminar" CssClass="btn btn-danger" runat="server" OnClick="btnEliminar_Click"/>
                <asp:Button ID="btnGuardar" Text="Guardar" Width="200" CssClass="btn btn-success" runat="server" OnClientClick="return fnValidate()" OnClick="btnGuardar_Click"/>
            </div>
        </div>
    <script>
        function fnValidate() {
            var isValidated = false;

            if ($("#ctl00_ContentPlaceHolder1_txtName").val().length > 0) {
                if (fnValidateDate($("#ctl00_ContentPlaceHolder1_txtNacimiento").val())) {
                    return true;
                }
                else {
                    alert("Por favor complete el campo de 'Fecha de nacimiento' con un valor válido con el formato DD/MM/AAAA");
                }
            } else {
                alert("Por favor complete el campo 'Nombre completo'");
            }

            return false;
        };

        function fnValidateDate(strDate) {
            // First check for the pattern
            if (!/^\d{1,2}\/\d{1,2}\/\d{4}$/.test(strDate))
                return false;

            // Parse the date parts to integers
            var parts = strDate.split("/");
            var day = parseInt(parts[0], 10);
            var month = parseInt(parts[1], 10);
            var year = parseInt(parts[2], 10);

            // Check the ranges of month and year
            if (year < 1000 || year > 3000 || month == 0 || month > 12)
                return false;

            var monthLength = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

            // Adjust for leap years
            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
                monthLength[1] = 29;

            // Check the range of the day
            return day > 0 && day <= monthLength[month - 1];
        };
    </script>
</asp:Content>