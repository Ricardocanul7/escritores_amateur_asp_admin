<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfHistoria.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfHistoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
    <div class="row">
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <br />
    <br />
    <br />
    <hr />

    <div class="card border-light">
        <div class="alert alert-info card-header text-center">
            <h2>
                <asp:Label ID="lblTitulo" runat="server">  </asp:Label>
                <h4><small class="text-muted">
                    <asp:Label ID="lblAutor" runat="server"> </asp:Label></small></h4>
            </h2>
            <figure class="figure">
                <asp:Image ID="imgPortada" runat="server" CssClass="figure-img img-fluid rounded" />
            </figure>
        </div>
        <div class="alert alert-secondary">
            <div class="card-body">
                <h5 class="card-title text-center"><u>Sinopsis</u> </h5>
                <p class="text-center">
                    <em>
                        <asp:Label ID="lblSinopsis" runat="server"> </asp:Label></em>
                </p>
            </div>
            <div class="card-body">
                <h5 class="card-title text-center"><u>Prólogo</u> </h5>
                <p class="text-center">
                    <em>
                        <asp:Label ID="lblPrologo" runat="server"></asp:Label>
                    </em>
                </p>
            </div>
        </div>

        <!-- lista de capitulos -->


        <div class="card">
            <article class="card-group-item">
                <asp:DataList ID="dlistCapitulos" runat="server" DataKeyNames="id_capitulo" Width="100%">
                    <ItemTemplate>
                        <header class="card-header">
                            <a href="#" data-toggle="collapse" data-target="#collapse22" aria-expanded="true" class="">
                                <i class="icon-action fa fa-chevron-down"></i>
                                <h6 class="title"><%#Eval("titulo") %></h6>
                            </a>
                        </header>
                        <div class="collapse show" id="collapse22" style="">
                            <div class="card-body">
                                <p>
                                    <%#Eval("contenido") %>
                                </p>
                            </div>
                            <!-- card-body.// -->
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </article>
        </div>
        <!-- card.// -->



    </div>

    <hr />
</asp:Content>
