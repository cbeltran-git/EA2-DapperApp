<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="DapperApp.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %>Clientes</h1>  
    <h3>Listado de Clientes</h3>
    <a href="CrearCliente.aspx" class="btn btn-primary">Nuevo Cliente</a>  
    <asp:GridView Class="table table-hover" ID="gvDatos" runat="server" AutoGenerateColumns="False"  GridLines="None">
        <Columns>          
            <asp:HyperLinkField DataNavigateUrlFields="IdCliente" DataNavigateUrlFormatString="~/ActualizarCliente.aspx?IdCliente={0}" DataTextField="NroDocumento" HeaderText="Documento" NavigateUrl="~/ActualizarCliente.aspx" Target="_parent" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
            <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
        </Columns>
    </asp:GridView>       
</asp:Content>
