﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfEditarCategorias.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfEditarCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">

    <div class="card text-center">
        <div class="card-header">
            <ul class="nav nav-pills card-header-pills">
                <div class="btn-group pull-right espacio">
                    <asp:LinkButton ID="lbtnRegresar" runat="server" class="btn btn-primary" OnClick="lbtnRegresar_Click">
                        Regresar </asp:LinkButton>
                </div>
                <div class="btn-group pull-right espacio">
                    <asp:LinkButton ID="lbtnAgregar" runat="server" class="btn btn-primary" OnClick="lbtnAgregar_Click">
                        Agregar </asp:LinkButton>
                </div>
                &nbsp
                <div class="btn-group pull-right espacio">
                    <asp:LinkButton ID="lbtnEliminar" runat="server" class="btn btn-primary" OnClick="lbtnEliminar_Click">
                        Eliminar </asp:LinkButton>
                </div>

                &nbsp 
                <div class="btn-group pull-right espacio">
                    <asp:LinkButton ID="lbtnModificar" runat="server" class="btn btn-primary" OnClick="lbtnModificar_Click">
                        Modificar</asp:LinkButton>
                </div>
            </ul>
        </div>
        <!-- Body -->
        <div class="card-body">
            <div class="row">
                <div class="col-md-4">
                    <div class="form-group">
                        <asp:Label ID="lblId" runat="server" Text="Id:"></asp:Label>
                        <asp:TextBox ID="txtId" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-10">
                    <!--NOMBRE-->
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
