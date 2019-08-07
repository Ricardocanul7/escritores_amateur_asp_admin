<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaUsuario.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Usuarios</h1>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-bottom:20px;">
        <div class="col-12">
            <div class="btn-group btn-group-justified" style="margin-bottom: 20px;">
                <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnAgregar_Click"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
                <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            </div>
            <div class="row">
            <!--BUSCADA FILTRADA-->
            <div class="col-lg-3">
                <div class="form-group">
                    <span>Nombre</span>
                    <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="form-group">
                    <span>Correo</span>
                    <asp:TextBox ID="txtCorreo" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="col-lg-3">
                <div class="form-group">
                    <span>Telefono</span>
                    <asp:TextBox ID="txtTelefono" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <!--BUSCADA FILTRADA-->
        </div>
    </div>
    
    <div class="row">
        <asp:GridView ID="gvUsuarios" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_usuario" OnRowCommand="gvUsuarios_RowCommand">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="apellido_pat" HeaderText="Apellido Paterno" />
                <asp:BoundField DataField="apellido_mat" HeaderText="Apellido Materno" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="avatar" HeaderText="Avatar" />
                <asp:BoundField DataField="municipio" HeaderText="Municipio" />
                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="sitio_web" HeaderText="Sitio Web" />
                <asp:BoundField DataField="biografia" HeaderText="Biografia" />
                <asp:BoundField DataField="username" HeaderText="Username" />
                <asp:BoundField DataField="contrasenia" HeaderText="Contraseña" />
                <asp:BoundField DataField="tipo_usuario" HeaderText="Tipo de usuario" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
