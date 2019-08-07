﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfNuevoCapitulo.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfNuevoCapitulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom:80px;">
       <div class="col-12"></div>
          <div class="col" style="width:100%">
            <div class="card">
                <header class="card-header alert alert-info card-header text-center">
                    <h4 class="card-title mt-2">Nuevo Capítulo</h4>
                </header>
                <article class="card-body">
                    <form>
                        <div class="form-row">
                            <div class="col form-group">
                                <label>TITULO</label>
                                <asp:TextBox ID="txtTitulo" CssClass="form-control" textmode="MultiLine" row="3" Columns="125" wrap="true" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>CONTENIDO</label>
                            <asp:TextBox ID="txtContenido" CssClass="form-control" textmode="MultiLine" row="3" Columns="125" wrap="true" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btn_add_capitulo" runat="server" class="btn btn-primary btn-block"  Text="Añadir Capítulo" OnClick="btn_add_capitulo_Click"></asp:Button>
                        </div>
                    </form>
                </article>
            </div>
        <div class="col-3"></div>
    </div>
</asp:Content>
