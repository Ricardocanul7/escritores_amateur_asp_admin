<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfTablaRevisiones.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfTablaRevisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="btn-group btn-group-justified" style="margin-bottom: 20px;">
                <asp:LinkButton ID="lbtnAgregar" CssClass="btn btn-primary col-sm-5" runat="server"><i class="fa fa-plus" aria-hidden="true"></i>Agregar</asp:LinkButton>
                <asp:LinkButton ID="lbtnBuscar" CssClass="btn btn-primary col-sm-5" runat="server" ><i class="fa fa-search" aria-hidden="true"></i>Buscar</asp:LinkButton>
            </div>
            <div class="row"> <!--BUSCADA FILTRADA-->
                <div class="col-lg-3">
                    <div class="form-group">
                        <span>Nombre</span>
                        <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="form-group">
                        <span>Historia</span>
                        <asp:TextBox ID="txtHistoria" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div> <!--BUSCADA FILTRADA-->
        </div>
        <asp:GridView ID="gvRevisiones" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" DataKeyNames="id_admin" >
            <Columns>
                <asp:BoundField DataField="id_admin" HeaderText="Indice" />
                <asp:BoundField DataField="id_historia" HeaderText="Historia" />
                <asp:BoundField DataField="fecha_aprovacion" HeaderText="Fecha de aprovación" />
                <asp:BoundField DataField="id_estatus" HeaderText="Status" />
                <asp:ButtonField ButtonType="Button" Text="Editar" CommandName="Editar" />
            </Columns>
            <EmptyDataTemplate>
                No hay datos disponibles para mostrar
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
