<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfAgregarCapitulo.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfAgregarCapitulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col-12">
            <div class="row">
                <div class="card text-white bg-primary mb-3 col-12">
                    <div class="card-header">
                        <asp:Label ID="lblHeaderTitulo_Libro" runat="server"></asp:Label>
                    </div>
                </div>
                <!-- card.// -->
            </div>
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <h5 class="card-header">Capitulos
                            <asp:Button ID="btnAgregarCap" runat="server" Text="+ Agregar capitulo" OnClick="btnAgregarCap_Click" CssClass="float-right btn btn-outline-primary mt-1" />
                        </h5>
                        <asp:DataList ID="dlistCapitulos" runat="server">
                            <ItemTemplate>
                                <div class="card-body">
                                    <h5 class="card-title">
                                        <%#Eval("titulo") %>
                                    </h5>
                                    <p class="card-text">
                                        <%#Eval("contenido") %>
                                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="float-right btn btn-outline-primary mt-1" />
                                    </p>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
        </div>


    </div>
</asp:Content>
