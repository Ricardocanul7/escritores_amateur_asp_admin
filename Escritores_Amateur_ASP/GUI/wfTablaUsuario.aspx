<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaUsuario.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Usuarios</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div >

    </div>
    <div class="btn-group btn-group-justified">
        <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-2" runat="server"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
    </div>
</asp:Content>
