<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Home.aspx.vb" Inherits="MAvha.Web.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12" style="text-align:left;">
            <button type="button" class="btn btn-success" data-toggle="modal" data-target="#personaModal" style="float:right;"><img src="Content/Images/add.png" /> Nueva Persona</button>
        </div>
    </div>
    <asp:GridView ID="gvPersonas" runat="server" class="table table-hover" EnableModelValidation="True" DataKeyNames="ID">
        <Columns>
            <asp:CommandField ButtonType="Image" SelectImageUrl="~/Content/Images/edit.png" ShowHeader="True" ShowSelectButton="True" HeaderText="Ver" >
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Content/Images/delete.png" ShowHeader="False" ShowDeleteButton="True" >
            <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>

    </asp:GridView>

    <!-- Modal -->
    <div class="modal fade" id="personaModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Persona</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
              <div class="col-md-12">
                  <label for="txtName">Nombre completo</label>
                  <input type="text" name="txtName" id="txtName" placeholder="Ej: Juan Perez" runat="server" class="form-control" />
              </div>
              <div class="col-md-12">
                  <label for="txtNacimiento">Fecha de nacimiento</label>
                  <asp:TextBox name="txtNacimiento" id="txtNacimiento" runat="server" CssClass="form-control"   placeholder="12/12/2018" />
              </div>
              <div class="col-md-12">
                  <label>Sexo: </label>
                  <asp:RadioButton Text="Femenino" GroupName="Sexo" ID="rbFemale" Checked="true" runat="server"/>
                  <asp:RadioButton Text="Masculino" GroupName="Sexo" ID="rbMale" runat="server"/>
              </div>
          </div>
          <div class="modal-footer">
              <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
              <asp:Button Text="Guardar Cambios" ID="btnSave" class="btn btn-primary" runat="server" OnClick="btnSave_Click"/>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
