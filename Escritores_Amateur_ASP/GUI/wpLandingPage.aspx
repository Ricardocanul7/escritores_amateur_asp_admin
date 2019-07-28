<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wpLandingPage.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wpLandingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <header class="masthead text-center text-white" id="circulos_principal" runat="server">
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
            /*white-space: normal;
            word-wrap: break-word;
            text-overflow: ellipsis;
            overflow: hidden;
            display: -webkit-box;
            -webkit-line-clamp: 3;
            -webkit-box-orient: vertical;*/
        }
        /* mixin for multiline */
        .corta {
          overflow: hidden;
          position: relative;
          line-height: 1.2em;
          max-height: 6em;
          text-align: justify;
          margin-right: -1em;
          padding-right: 1em;
        }
        .corta:before {
          content: '...';
          position: absolute;
          right: 0;
          bottom: 0;
        }
        .corta:after {
          content: '';
          position: absolute;
          right: 0;
          width: 1em;
          height: 1em;
          margin-top: 0.2em;
          background: white;
        }
        .custom-card, .custom-card:hover {
          color: inherit;
          text-decoration: none;
        }
        .card:hover{
          padding: 5px !important;
          background: #ADD8E6 !important;
        }
</style>
    <div class="row" style="margin-top: 80px; margin-bottom: 80px;">
        <asp:DataList ID="dlistHistoriasRecientes" runat="server" Width="100%" DataKeyNames="id_historia" RepeatDirection="Horizontal" RepeatColumns="3" OnItemCommand="dlistHistoriasRecientes_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton ID="click_historia" runat="server" CommandName="ver_historia" CommandArgument='<%# Eval("id_historia") %>' CssClass="custom-card">
                    <div class="col-sm-4">
                    <div class="card" style="width: 18rem;">
                        <img src="<%#Eval("portada_url") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("titulo") %></h5>
                            <p class="card-text corta"><%#Eval("contenido") %></p>
                        </div>
                    </div>
                    </div>
                </asp:LinkButton>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
