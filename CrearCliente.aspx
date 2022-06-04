<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearCliente.aspx.cs" Inherits="DapperApp.CrearCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Nuevo Cliente</h2> 

    <div class="form-group">       
        <label>Nro Documento:</label>
        <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
    </div>
     <div class="form-group">       
        <label>Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
     <div class="form-group">       
        <label>Dirección:</label>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
    </div>
     <div class="form-group">       
        <label>Teléfono:</label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    </div>
    <asp:Button  CssClass="btn btn-primary" ID="Button1" runat="server" Text="Crear Cliente" OnClick="crear"/>
    
    <a href="Clientes.aspx"  class="btn btn-primary" id="Button2" runat="server">Volver</a>
</asp:Content>

