﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfAgregarHistoria.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfAgregarHistoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom:80px;">
       <div style="margin:20px;"></div>
          <div class="col" style="width:100%">
            <div class="card">
                <header class="card-header alert alert-info card-header text-center">
                    <h4 class="card-title mt-2">¡Registra una nueva historia!</h4>
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
                            <label>SINOPSIS</label>
                            <asp:TextBox ID="txtSinopsis" CssClass="form-control" textmode="MultiLine" row="3" Columns="125" wrap="true" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>PROLOGO</label>
                            <asp:TextBox ID="txtPrologo" CssClass="form-control" textmode="MultiLine" row="3" Columns="125" wrap="true" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Categoria</label>
                            <asp:ListBox ID="lboxCategoria" runat="server" CssClass="form-control"></asp:ListBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btn_add_story" runat="server" class="btn btn-primary btn-block" OnClick="btn_add_story_Click" Text="Añadir"></asp:Button>
                        </div>
                    </form>
                </article>
            </div>
        <div class="col-3"></div>
    </div>
</asp:Content>
