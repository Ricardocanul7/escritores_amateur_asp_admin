<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaMensaje.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaMensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Mensaje</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="btn-group btn-group-justified" style="margin-bottom: 20px;">
                <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnAgregar_Click"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
                <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" OnClick="lbtnBuscar_Click"><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            </div>
            <div class="row"> <!--BUSCADA FILTRADA-->
                <div class="col-lg-3">
                    <div class="form-group">
                        <span>Fecha</span>
                        <asp:TextBox ID="txtFecha" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="form-group">
                        <span>Creador</span>
                        <asp:TextBox ID="txtCreador" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="form-group">
                        <span>Conversación</span>
                        <asp:TextBox ID="txtConversacion" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div> <!--BUSCADA FILTRADA-->
        </div>
        <asp:GridView ID="gvMensaje" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_mensaje" OnRowCommand="gvMensaje_RowCommand">
            <Columns>
                <asp:BoundField DataField="texto" HeaderText="Texto" />
                <asp:BoundField DataField="fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="estado" HeaderText="Estado" />
                <asp:BoundField DataField="id_user_creador" HeaderText="Creador Conversación" />
                <asp:BoundField DataField="id_conversacion" HeaderText="Id Conversación" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>

