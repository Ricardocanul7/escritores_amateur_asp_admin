<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfMisHistorias.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfMisHistorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col" style="width: 100%">

            <div class="card">
                <h5 class="card-header">Todas las historias
                    <asp:Button ID="btnAgregarHistoria" runat="server" Text="+ Agregar Historia" OnClick="btnAgregarHistoria_Click" CssClass="float-right btn btn-outline-primary mt-1" />
                </h5>
                <div class="card-body">

                    <asp:DataList ID="dlistMisHistorias" runat="server" DataKeyNames="id_historia" OnItemCommand="dlistMisHistorias_ItemCommand">
                        <ItemTemplate>
                            <div class="card mb-3" style="max-width: 1080px;">
                                <div class="row no-gutters">
                                    <div class="col-md-2">
                                        <img id="imgPortada" class="card-img" src="<%#Eval("portada_url") %>" class="rounded img-thumbnail" />
                                    </div>
                                    <div class="col-md-10">
                                        <div class="card-body">
                                            <h5 class="card-title">
                                                <%#Eval("titulo") %>
                                            </h5>
                                            <p class="card-text"><%#Eval("sinopsis") %></p>
                                            <p class="card-text">
                                                <small class="text-muted">Estado: <%#Eval("estatus") %>
                                                </small>
                                                <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="editar_historia" CommandArgument='<%#Eval("id_historia") %>' CssClass="float-right btn btn-outline-primary mt-1" />
                                                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClientClick="DeleteItem()" CommandName="eliminar_historia" CommandArgument='<%#Eval("id_historia") %>' CssClass="float-right btn btn-outline-primary mt-1" />
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>

            <script type="text/javascript">
                function DeleteItem() {
                    var confirm_value = document.createElement("INPUT");
                    confirm_value.type = "hidden";
                    confirm_value.name = "confirm_value";
                    if (confirm("Estas seguro de eliminar esta historia...?")) {
                        confirm_value.value = "SI";
                    } else {
                        confirm_value.value = "NO";
                    }
                    document.forms[0].appendChild(confirm_value);
                }
            </script>
        </div>
    </div>
</asp:Content>

