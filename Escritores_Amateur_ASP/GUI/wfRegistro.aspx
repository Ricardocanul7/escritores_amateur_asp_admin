<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfRegistro.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <!-- Se agrega margin-top de 80px para quedar debajo de el navbar -->
    <div class="row" style="margin-top: 110px; margin-bottom:80px;">
        <div class="col-3"></div>
        <div class="col" style="width:100%">

            <div class="card">
                <header class="card-header">
                    <asp:LinkButton ID="lbtnLoginRegitro1" CssClass="float-right btn btn-outline-primary mt-1" OnClick="lbtnLoginRegitro1_Click" runat="server">Iniciar sesión</asp:LinkButton>
                    <h4 class="card-title mt-2">Registrate</h4>
                </header>
                <article class="card-body">
                    <form>
                        <div class="form-row">
                            <div class="col form-group">
                                <label>Nombre(s)</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                        <!-- form-row end.// -->
                        <div class="form-row">
                            <div class="col form-group">
                                <label>Apellido Paterno</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                            <div class="col form-group">
                                <label>Apellido Materno</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row end.// -->
                        <div class="form-group">
                            <label>Correo electrónico</label>
                            <input type="email" class="form-control" placeholder="">
                            <small class="form-text text-muted">Nunca compartiremos su correo electrónico con nadie más.</small>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <label class="form-check form-check-inline">
                                <input class="form-check-input" type="radio" name="gender" value="option1">
                                <span class="form-check-label">Masculino </span>
                            </label>
                            <label class="form-check form-check-inline">
                                <input class="form-check-input" type="radio" name="gender" value="option2">
                                <span class="form-check-label">Femenino</span>
                            </label>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label>País</label>
                                <input type="text" class="form-control">
                            </div>
                            <div class="form-group col-md-6">
                                <label>Estado</label>
                                <input type="text" class="form-control">
                            </div>
                            <!-- form-group end.// -->
                            <div class="form-group col-md-6">
                                <label>Municipio</label>
                                <select id="inputState" class="form-control">
                                    <option selected="">Elegir...</option>
                                    <option>Motul</option>
                                    <option>Izamal</option>
                                    <option>Valladolid</option>
                                    <option>Tekax</option>
                                    <option>Tizimin</option>
                                </select>
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row.// -->
                        <div class="form-group">
                            <label>Nombre de usuario</label>
                            <input class="form-control" type="text">
                        </div>
                        <div class="form-group">
                            <label>Introduzca Contraseña</label>
                            <input class="form-control" type="password">
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <button type="submit" class="btn btn-primary btn-block">Registro  </button>
                        </div>
                        <!-- form-group// -->
                        <small class="text-muted">Al hacer clic en el botón "Registrarse", usted confirma que acepta nuestros
                            <br>
                            Términos de uso y política de privacidad.</small>
                    </form>
                </article>
                <!-- card-body end .// -->
                <div class="border-top card-body text-center">¿Ya tienes una cuenta? <asp:LinkButton ID="lbtnLoginRegistro2" OnClick="lbtnLoginRegitro1_Click" runat="server">Iniciar sesión</asp:LinkButton></div>
            </div>
            <!-- card.// -->

        </div>
        <div class="col-3"></div>
    </div>
</asp:Content>
