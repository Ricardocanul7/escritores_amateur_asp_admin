<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaSinopsis.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaSinopsis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Sinopsis</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-bottom: 20px;">
        <div class="btn-group" style="margin-right: unset;">
            <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnAgregar_Click"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
        </div>
    </div>

    <div class="row">
        <asp:GridView ID="gvSinopsis" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_sinopsis" OnRowCommand="gvSinopsis_RowCommand">
            <Columns>
                <asp:BoundField DataField="cabecera" HeaderText="Cabecera" />
                <asp:BoundField DataField="contenido" HeaderText="Contenido" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
