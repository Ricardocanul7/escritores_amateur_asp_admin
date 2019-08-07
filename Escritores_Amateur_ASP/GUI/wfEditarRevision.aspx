<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfEditarRevision.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfEditarRevision" %>

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
                        <asp:TextBox ID="txtId_admin" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <!--Historia-->
                    <div class="form-group">
                        <asp:Label ID="lblTitulo" runat="server" Text="Historia:"></asp:Label>
                        <asp:ListBox ID="lboxId_Historia" AutoPostBack="true" class="form-control" runat="server"></asp:ListBox>
                    </div>
                </div>
                
            </div>
            <div class="row">
                <div class="col-md-12">
                    <!--Contenido-->
                    <div class="form-group">
                        <asp:Label ID="lblContenido" runat="server" Text="Estado:"></asp:Label>
                        <asp:ListBox ID="lboxEstado" AutoPostBack="true" class="form-control" runat="server"></asp:ListBox>
                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
