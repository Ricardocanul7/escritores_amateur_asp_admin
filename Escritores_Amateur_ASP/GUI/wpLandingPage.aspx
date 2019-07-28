<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wpLandingPage.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wpLandingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <header class="masthead text-center text-white">
        <div class="masthead-content">
            <div class="container">
                <h1 class="masthead-heading mb-0">Crea tus propias historias</h1>
                <h2 class="masthead-subheading mb-0">Explota tu imaginación</h2>
                <a href="#" class="btn btn-primary btn-xl rounded-pill mt-5">Más información</a>
            </div>
        </div>
        <div class="bg-circle-1 bg-circle"></div>
        <div class="bg-circle-2 bg-circle"></div>
        <div class="bg-circle-3 bg-circle"></div>
        <div class="bg-circle-4 bg-circle"></div>
    </header>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
<style type="text/css">
.corta
        {
            width: 250px;
            white-space: nowrap;
            text-overflow: ellipsis;
            overflow: hidden;
        }
</style>
    <div class="row" style="margin-top:80px; margin-bottom:80px;">
        <asp:DataList ID="dlistHistoriasRecientes" runat="server" Width="100%" DataKeyNames="id_historia" RepeatDirection="Horizontal"  RepeatColumns="3" OnItemCommand="dlistHistoriasRecientes_ItemCommand">
            <ItemTemplate>
                <div class="col-sm-4">
                    <div class="card" style="width: 18rem;">
                        <img src="<%#Eval("portada_url") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("titulo") %></h5>
                            <p class="card-text corta"><%#Eval("contenido") %></p>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
