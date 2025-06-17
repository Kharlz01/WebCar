<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="pr_web_car.Pages.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consulta de Ventas por Vendedor</h1>
    <p class="lead">Ingresa la cedula del empleado para revisar el historial de ventas.</p>

    <div class="d-flex justify-content-center mt-5">
        <div class="text-center" style="width: 300px;">
            <asp:Label ID="LblCC" runat="server" Text="Cédula" CssClass="badge bg-secondary mb-2 fs-6"></asp:Label>

            <asp:TextBox ID="TxtCC" runat="server" CssClass="form-control ms-2 mb-3" placeholder="CC" TextMode="Number"></asp:TextBox>
        
            <asp:Button ID="BtnCC" runat="server" CssClass="btn btn-success mb-4" Text="Consulta" OnClick="BtnConsulta" />
        </div>
    </div>

    <asp:Label ID="lblMensaje" runat="server" CssClass="d-flex justify-content-center alert alert-danger mt-3" Visible="false"></asp:Label>

    <asp:GridView ID="gvVehiculos" runat="server" AutoGenerateColumns="False" CssClass="table table-borderer border-secondary text-center table-striped-columns">
        <Columns>
            <asp:BoundField DataField="Marca" HeaderText="Marca" />
            <asp:BoundField DataField="Model" HeaderText="Modelo" />
            <asp:BoundField DataField="Year" HeaderText="Año" />
            <asp:BoundField DataField="Color" HeaderText="Color" />
            <asp:BoundField DataField="SellPrice" HeaderText="Precio de Venta" />
            <asp:BoundField DataField="SellDate" HeaderText="Fecha de Venta" DataFormatString="{0:yyyy-MM-dd}" HtmlEncode="false" />
            <asp:BoundField DataField="CustomerName" HeaderText="Nombre del Cliente" />
            <asp:BoundField DataField="CustomerCC" HeaderText="Cedula del Cliente" />
        </Columns>
    </asp:GridView>

</asp:Content>
