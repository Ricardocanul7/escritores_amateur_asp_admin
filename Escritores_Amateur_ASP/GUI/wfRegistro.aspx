<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfRegistro.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <!-- Se agrega margin-top de 80px para quedar debajo de el navbar -->
    <div class="row" style="margin-top: 110px; margin-bottom: 80px;">
        <div class="col-3"></div>
        <div class="col" style="width: 100%">

            <div class="alert alert-primary" role="alert" id="alerta_exito" runat="server" visible="false">
                Registro exitoso!
            </div>

            <div class="card" id="form_registro" runat="server">
                <div class="alert alert-danger" role="alert" runat="server" id="alerta_fallo" visible="false">
                    Error al registrar usuario nuevo!
                </div>
                <header class="card-header">
                    <asp:LinkButton ID="lbtnLoginRegitro1" CssClass="float-right btn btn-outline-primary mt-1" OnClick="lbtnLoginRegitro1_Click" runat="server">Iniciar sesión</asp:LinkButton>
                    <h4 class="card-title mt-2">Registrate</h4>
                </header>
                <article class="card-body">
                    <form>
                        <div class="form-row">
                            <div class="col form-group">
                                <label>Nombre(s)</label>
                                <input id="input_nombre" runat="server" type="text" class="form-control" placeholder="">
                            </div>
                        </div>
                        <!-- form-row end.// -->
                        <div class="form-row">
                            <div class="col form-group">
                                <label>Apellido Paterno</label>
                                <input id="input_apellido_pat" runat="server" type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                            <div class="col form-group">
                                <label>Apellido Materno</label>
                                <input id="input_apellido_mat" runat="server" type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row end.// -->
                        <div class="form-group">
                            <label>Correo electrónico</label>
                            <input id="input_correo" runat="server" type="email" class="form-control" placeholder="">
                            <small class="form-text text-muted">Nunca compartiremos su correo electrónico con nadie más.</small>
                        </div>
                        <div class="form-group">
                            <label>Teléfono</label>
                            <input id="input_telefono" runat="server" type="tel" class="form-control" placeholder="">
                            <small class="form-text text-muted">Nunca compartiremos su teléfono con nadie más.</small>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <label class="form-check form-check-inline">
                                <input id="input_radio_masculino" runat="server" class="form-check-input" type="radio" name="gender" value="option1">
                                <span class="form-check-label">Masculino </span>
                            </label>
                            <label class="form-check form-check-inline">
                                <input id="input_radio_femenino" runat="server" class="form-check-input" type="radio" name="gender" value="option2">
                                <span class="form-check-label">Femenino</span>
                            </label>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label>País</label>
                                <asp:ListBox ID="input_pais" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="input_pais_SelectedIndexChanged">
                                </asp:ListBox>
                            </div>
                            <div class="form-group col-md-6">
                                <label>Estado</label>
                                <asp:ListBox ID="input_estado" runat="server" CssClass="form-control">
                                </asp:ListBox>
                            </div>
                            <!-- form-group end.// -->
                            <div class="form-group col-md-6">
                                <label>Municipio</label>
                                <asp:ListBox ID="input_ciudad" runat="server" CssClass="form-control">
                                </asp:ListBox>
                                <%--<select id="inputState" class="form-control">
                                    <option selected="">Elegir...</option>
                                    <option>Motul</option>
                                    <option>Izamal</option>
                                    <option>Valladolid</option>
                                    <option>Tekax</option>
                                    <option>Tizimin</option>
                                </select>--%>
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row.// -->
                        <div class="form-group">
                            <label>Nombre de usuario</label>
                            <input id="input_username" runat="server" class="form-control" type="text">
                        </div>
                        <div class="form-group">
                            <label>Contraseña</label>
                            <input id="input_password" runat="server" class="form-control" type="password">
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <asp:LinkButton ID="lbtnRegistro" runat="server" OnClick="lbtnRegistro_Click"></asp:LinkButton>
                            <button type="submit" class="btn btn-primary btn-block">Registro  </button>
                        </div>
                        <!-- form-group// -->
                        <small class="text-muted">Al hacer clic en el botón "Registro", usted confirma que acepta nuestros
                            <br>
                            Términos de uso y política de privacidad.</small>
                    </form>
                </article>
                <!-- card-body end .// -->
                <div class="border-top card-body text-center">
                    ¿Ya tienes una cuenta?
                    <asp:LinkButton ID="lbtnLoginRegistro2" OnClick="lbtnLoginRegitro1_Click" runat="server">Iniciar sesión</asp:LinkButton>
                </div>
            </div>
            <!-- card.// -->

        </div>
        <div class="col-3"></div>
    </div>
</asp:Content>
