<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col-lg-3"></div>
        <div class="col">

            <div class="card">
                <div id="alerta_error_login" class="alert alert-danger" role="alert" runat="server">
                    Error al iniciar sesion, usuario o contraseña incorrecta!
                </div>
                <article class="card-body">
                    <a href="" class="float-right btn btn-outline-primary">Registrarse</a>
                    <h4 class="card-title mb-4 mt-1">Iniciar Sesión</h4>
                    <form>
                        <div class="form-group">
                            <label>Usuario</label>
                            <input id="input_username" name="" class="form-control" placeholder="Usuario" type="text" runat="server">
                        </div>
                        <!-- form-group// -->
                        <div class="form-group">
                            <a class="float-right" href="#">Olvidaste tu contraseña?</a>
                            <label>Contraseña</label>
                            <input id="input_password" class="form-control" placeholder="******" type="password" runat="server">
                        </div>
                        <!-- form-group// -->
                        <div class="form-group">
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox">
                                    Guardar contraseña
                                </label>
                            </div>
                            <!-- checkbox .// -->
                        </div>
                        <!-- form-group// -->
                        <div class="form-group">
                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary btn-block" Text="Iniciar sesión" OnClick="btnLogin_Click" />
                            <%--<button type="submit" class="btn btn-primary btn-block">Iniciar sesión  </button>--%>
                        </div>
                        <!-- form-group// -->
                    </form>
                </article>
            </div>
            <!-- card.// -->

        </div>
        <div class="col-lg-3"></div>
    </div>
</asp:Content>
