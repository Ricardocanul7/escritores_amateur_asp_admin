<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaGenero.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Genero</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row col-12">
        <div class="btn-group btn-group-justified" style="margin-right: unset;">
            <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-2" runat="server" OnClick="lbtnBuscar_Click" ><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-2" runat="server"><i class="fa fa-plus" aria-hidden="true"></i>Buscar</asp:LinkButton>
        </div>
    </div>

    <div class="row">
        <asp:GridView ID="gvGenero" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_genero">
            <Columns>
                <asp:BoundField DataField="id_genero" HeaderText="Indice" />
                <asp:BoundField DataField="nombre_genero" HeaderText="Nombre" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
