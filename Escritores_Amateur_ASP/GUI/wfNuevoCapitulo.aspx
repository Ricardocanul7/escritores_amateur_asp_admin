<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfNuevoCapitulo.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfNuevoCapitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col" style="width: 100%">

           <article class="card-body">
                    <form>
                        <div class="alert alert-info card-header">
                            <h2>
                                <asp:Label ID="lblCAPITULO" runat="server">  Nuevo capítulo </asp:Label>
                            </h2>
                        </div>
                        <div class="form-row">
                            <div class="col form-group">
                                <label>Nombre del capítulo</label>
                                <asp:TextBox ID="input_nombre" runat="server" CssClass="form-control"></asp:TextBox>
                                <label>Contenido</label>
                                <asp:TextBox ID="input_contenido" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </form>
                </article>

        </div>
    </div>
</asp:Content>
