﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaSinopsis.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaSinopsis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Sinopsis</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-bottom: 20px;">
        <div class="btn-group" style="margin-right: unset;">
            <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-eraser" aria-hidden="true"></i>Eliminar</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary col-sm-6" runat="server"><i class="fa fa-upload" aria-hidden="true"></i>Actualizar</asp:LinkButton>
        </div>
    </div>

    <div class="row">
        <asp:GridView ID="gvSinopsis" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_sinopsis">
            <Columns>
                <asp:BoundField DataField="cabecera" HeaderText="Cabecera" />
                <asp:BoundField DataField="contenido" HeaderText="Contenido" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>