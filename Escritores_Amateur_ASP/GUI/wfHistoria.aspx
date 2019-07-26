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
        <h2><asp:Label ID="lblTitulo" runat="server">  </asp:Label>
           <h4><small class="text-muted"><asp:Label ID="lblAutor" runat="server"> </asp:Label></small></h4> 
        </h2>
          <figure class="figure">
            <asp:Image ID="imgPortada" runat="server" CssClass="figure-img img-fluid rounded"/>
          </figure>
      </div>
      <div class="alert alert-secondary">
        <div class="card-body">
            <h5 class="card-title text-center"><u>Sinopsis</u> </h5>
            <p class="text-center"><em><asp:Label ID="lblSinopsis" runat="server"> </asp:Label></em></p>
        </div>
        <div class="card-body">
            <h5 class="card-title text-center"><u>Prólogo</u> </h5>
            <p class="text-center"><em><asp:Label ID="lblPrologo" runat="server"></asp:Label> </em></p>
        </div>
        <div class="card-body">
            <h5 class="card-title text-center"> <u>Nombre Capitulo</u></h5>
            <p class="text-center"><em>Contenido Capitulo.</em></p>
        </div>
      </div>
    </div>

    <hr />
</asp:Content>
