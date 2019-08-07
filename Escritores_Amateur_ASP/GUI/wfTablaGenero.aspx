<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaGenero.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaGenero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <h1 class="h3 mb-0 text-gray-800">Genero</h1>
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
                        <span>Nombre</span>
                        <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div> <!--BUSCADA FILTRADA-->
        </div>
        <asp:GridView ID="gvGenero" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_genero" OnRowCommand="gvGenero_RowCommand">
            <Columns>
                <asp:BoundField DataField="id_genero" HeaderText="Indice" />
                <asp:BoundField DataField="nombre_genero" HeaderText="Nombre" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>

</asp:Content>
