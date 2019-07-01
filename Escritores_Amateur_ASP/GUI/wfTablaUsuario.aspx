<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaUsuario.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Usuarios</h1>
    <a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i>Generar Reporte</a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-bottom:20px;">
        <div class="btn-group">
            <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i><span>Buscar</span></asp:LinkButton>
            <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-eraser" aria-hidden="true"></i>Eliminar</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" CssClass="btn btn-primary col-sm-6" runat="server"><i class="fa fa-upload" aria-hidden="true"></i>Actualizar</asp:LinkButton>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="gvUsuarios" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_usuario">
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
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
