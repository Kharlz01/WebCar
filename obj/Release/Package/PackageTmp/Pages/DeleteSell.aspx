<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteSell.aspx.cs" Inherits="pr_web_car.Pages.DeleteSell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>General de Ventas</h1>
    <p class="lead">A continuacion se muestra una vista de todas las ventas, elimina las ventas incorrectas.</p>

    <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger fw-bold"></asp:Label>

    <asp:GridView ID="GvSells" runat="server" AutoGenerateColumns="False" CssClass="table table-borderer border-secondary text-center table-striped"
        OnRowCommand="GvSells_RowCommand" DataKeyNames="SellID">
        <Columns>
            <asp:BoundField DataField="CustomerName" HeaderText="Cliente" />
            <asp:BoundField DataField="CustomerCC" HeaderText="Cédula" />
            <asp:BoundField DataField="SellDate" HeaderText="Fecha de Venta" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="SellPrice" HeaderText="Precio" DataFormatString="{0:C}" />
            <asp:BoundField DataField="TypePay" HeaderText="Método de Pago" />
            <asp:BoundField DataField="Comission" HeaderText="Comisión (%)" />

            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger btn-sm"
                        CommandName="EliminarVenta" CommandArgument='<%# Eval("SellID") %>' OnClientClick="return confirm('¿Estás seguro de eliminar esta venta?');" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
