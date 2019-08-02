<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfMisHistorias.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfMisHistorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col" style="width: 100%">
            <asp:DataList ID="dlistMisHistorias" runat="server" DataKeyNames="id_historia" Width="100%">
                    <ItemTemplate>
                        <div class="card">
                            <h5 class="card-header">Todas las historias</h5>
                            <div class="card-body">
                                <asp:Image ID="imgPortada" CssClass="rounded float-left" runat="server" />
                                <h5 class="card-title">
                                    <asp:Label ID="lblTitulo" runat="server" Text="Pajaro Loco"></asp:Label>
                                </h5>
                                <p class="card-text">With supporting text below as a natural lead-in to additional content.
                                    <asp:Button ID="Button1" runat="server" Text="Button" CssClass="float-right btn btn-outline-primary mt-1" />
                                </p>
                            </div>
                        </div>
                    </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>

