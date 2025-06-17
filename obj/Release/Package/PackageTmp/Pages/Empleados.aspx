<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="pr_web_car.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Formulario de empleados</h1>
    <p class="lead">Ingresa la cedula del empleado para actualizar datos.</p>

    <div class="d-flex justify-content-center mt-5">
        <div class="text-center" style="width: 300px;">
            <asp:Label ID="LblCC" runat="server" Text="Cédula" CssClass="badge bg-secondary mb-2 fs-6"></asp:Label>

            <asp:TextBox ID="TxtCC" runat="server" CssClass="form-control ms-2 mb-3" placeholder="CC" TextMode="Number"></asp:TextBox>
        
            <asp:Button ID="BtnCC" runat="server" CssClass="btn btn-info" Text="Consulta" OnClick="BtnCC_Click" />
        </div>
    </div>




    <asp:Label ID="lblMensaje" runat="server" CssClass="d-flex justify-content-center alert alert-danger mt-3" Visible="false"></asp:Label>

    <asp:Panel ID="pnlFormulario" runat="server" Visible="false">
        <div class="d-flex justify-content-center mt-2 mb-2">
            <div class="card border-primary shadow" style="max-width: 24%; width: 100%;">
                <div class="card-header bg-primary text-white text-center">
                    Información del Vendedor
                </div>
                <div class="card-body">
                    <asp:Label ID="lbl_name" runat="server" Text="Nombre(s)" CssClass="badge bg-primary"></asp:Label>
                    <asp:TextBox ID="txt_name" runat="server" CssClass="form-control mb-3" placeholder="Juan"></asp:TextBox>

                    <asp:Label ID="lbl_lastname" runat="server" Text="Apellidos" CssClass="badge bg-primary"></asp:Label>
                    <asp:TextBox ID="txt_lastname" runat="server" CssClass="form-control mb-3" placeholder="Pérez"></asp:TextBox>

                    <asp:Label ID="lbl_start" runat="server" Text="Fecha de contratación" CssClass="badge bg-primary"></asp:Label>
                    <asp:TextBox ID="txt_start" runat="server" CssClass="form-control mb-3" TextMode="Date"></asp:TextBox>

                    <asp:Label ID="lbl_wage" runat="server" Text="Salario base" CssClass="badge bg-primary"></asp:Label>
                    <asp:TextBox ID="txt_wage" runat="server" CssClass="form-control mb-3" placeholder="1'000.000"></asp:TextBox>

                    <asp:Label ID="lbl_plus" runat="server" Text="Comisión (%)" CssClass="badge bg-primary"></asp:Label>
                    <asp:TextBox ID="txt_plus" runat="server" CssClass="form-control mb-3" placeholder="100"></asp:TextBox>

                    <div class="mt-3 d-grid gap-3">
                        <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-secondary" OnClick="BtnCancel_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Actualizar" CssClass="btn btn-primary" OnClick="BtnUpdate_Click" />
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>

</asp:Content>
