<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaCapitulo.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaCapitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Capitulo</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="btn-group btn-group-justified" style="margin-bottom: 20px;">
                <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
                <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnAgregar_Click"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
            </div>
        </div>
        <asp:GridView ID="gvCapitulo" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_historia" OnRowCommand="gvCapitulo_RowCommand">
            <Columns>
                <asp:BoundField DataField="titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="contenido" HeaderText="Contenido" />
                <asp:BoundField DataField="id_historia" HeaderText="Historia" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
