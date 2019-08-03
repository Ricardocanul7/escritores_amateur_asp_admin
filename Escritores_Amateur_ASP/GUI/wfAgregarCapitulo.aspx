<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfAgregarCapitulo.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfAgregarCapitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col" style="width: 100%">
            <div class="card">
                <h5 class="card-header">Capitulos
                    <asp:Button ID="btnAgregarCap" runat="server" Text="+ Agregar capitulo" OnClick="btnAgregarCap_Click" CssClass="float-right btn btn-outline-primary mt-1" />
                </h5>
                <div class="card-body">
                    <asp:Image ID="imgPortada" CssClass="rounded float-left" runat="server" />
                    <h5 class="card-title">
                        <asp:Label ID="lblTitulo" runat="server" Text="¿Por qué a mi?"></asp:Label>
                    </h5>
                    <p class="card-text">With supporting text below as a natural lead-in to additional content.
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="float-right btn btn-outline-primary mt-1" />
                    </p>
                 </div>
            </div>
        </div>
    </div>
</asp:Content>
