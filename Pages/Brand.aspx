<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="pr_web_car.Pages.Brand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Creacion de Marcas</h1>
    <p class="lead">Ingresa los datos de la marca que deseas registrar en el sistema.</p>
    
    <asp:Label ID="lbl_name" runat="server" Text="Nombre" CssClass="badge bg-primary"></asp:Label>
    <asp:TextBox ID="txt_name" runat="server" CssClass="form-control" placeholder="Mi Auto SAS..."></asp:TextBox>
    
    <asp:Label ID="lbl_country" runat="server" Text="Pais de Origen" CssClass="badge bg-primary"></asp:Label>
    <asp:TextBox ID="txt_country" runat="server" CssClass="form-control" placeholder="Colombia..."></asp:TextBox>
    
    <asp:Label ID="lbl_start" runat="server" Text="Año de fundacion" CssClass="badge bg-primary"></asp:Label>
    <asp:TextBox ID="txt_start" runat="server" CssClass="form-control" placeholder="yyyy" TextMode="Number"></asp:TextBox>
    
    <asp:Button ID="BtnCancel" runat="server" CssClass="btn btn-secondary my-4" Text="Limpiar" OnClick="BtnLimpiar_Click"/>
    
    <asp:Button ID="BtnUpdate" runat="server" CssClass="btn btn-primary" Text="Crear" OnClick="BtnCrear_Click"/> <br />

    <asp:Label ID="lblMensaje" runat="server" Visible="false"></asp:Label>
</asp:Content>
