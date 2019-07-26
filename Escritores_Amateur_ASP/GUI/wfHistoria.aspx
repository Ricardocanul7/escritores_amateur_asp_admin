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
        <h2> Titulo historia
           <h4><small class="text-muted">AUTOR</small></h4> 
        </h2>
          <figure class="figure">
            <img src="..." class="figure-img img-fluid rounded" alt="...">
            <figcaption class="figure-caption text-right">PORTADA DE LA HISTORIA</figcaption>
          </figure>
      </div>
      <div class="alert alert-secondary">
        <div class="card-body">
            <h5 class="card-title text-center"><u>Sinopsis</u> </h5>
            <p class="text-center"><em>Contenido Sinopsis.</em></p>
        </div>
        <div class="card-body">
            <h5 class="card-title text-center"><u>Prólogo</u> </h5>
            <p class="text-center"><em>Contenido Prologo.</em></p>
        </div>
        <div class="card-body">
            <h5 class="card-title text-center"> <u>Nombre Capitulo</u></h5>
            <p class="text-center"><em>Contenido Capitulo.</em></p>
        </div>
      </div>
    </div>

    <hr />
</asp:Content>
