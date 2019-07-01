﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaCategoria.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Categorias</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="btn-group btn-group-justified" style="margin-bottom: 20px;">
                <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
                <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
                <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-eraser" aria-hidden="true"></i>Eliminar</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary col-sm-6" runat="server"><i class="fa fa-upload" aria-hidden="true"></i>Actualizar</asp:LinkButton>
            </div>
        </div>
        <asp:GridView ID="gvCategorias" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_categoria">
            <Columns>
                <asp:BoundField DataField="id_categoria" HeaderText="Indice" />
                <asp:BoundField DataField="nombre_cat" HeaderText="Nombre" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
