﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfRegistro.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfRegistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <!-- Se agrega margin-top de 80px para quedar debajo de el navbar -->
    <div class="row" style="margin-top: 110px; margin-bottom:80px;">
        <div class="col-3"></div>
        <div class="col" style="width:100%">

            <div class="card">
                <header class="card-header">
                    <a href="" class="float-right btn btn-outline-primary mt-1">Log in</a>
                    <h4 class="card-title mt-2">Sign up</h4>
                </header>
                <article class="card-body">
                    <form>
                        <div class="form-row">
                            <div class="col form-group">
                                <label>First name</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                            <div class="col form-group">
                                <label>Last name</label>
                                <input type="text" class="form-control" placeholder="">
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row end.// -->
                        <div class="form-group">
                            <label>Email address</label>
                            <input type="email" class="form-control" placeholder="">
                            <small class="form-text text-muted">We'll never share your email with anyone else.</small>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <label class="form-check form-check-inline">
                                <input class="form-check-input" type="radio" name="gender" value="option1">
                                <span class="form-check-label">Male </span>
                            </label>
                            <label class="form-check form-check-inline">
                                <input class="form-check-input" type="radio" name="gender" value="option2">
                                <span class="form-check-label">Female</span>
                            </label>
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <label>City</label>
                                <input type="text" class="form-control">
                            </div>
                            <!-- form-group end.// -->
                            <div class="form-group col-md-6">
                                <label>Country</label>
                                <select id="inputState" class="form-control">
                                    <option>Choose...</option>
                                    <option>Uzbekistan</option>
                                    <option>Russia</option>
                                    <option selected="">United States</option>
                                    <option>India</option>
                                    <option>Afganistan</option>
                                </select>
                            </div>
                            <!-- form-group end.// -->
                        </div>
                        <!-- form-row.// -->
                        <div class="form-group">
                            <label>Create password</label>
                            <input class="form-control" type="password">
                        </div>
                        <!-- form-group end.// -->
                        <div class="form-group">
                            <button type="submit" class="btn btn-primary btn-block">Register  </button>
                        </div>
                        <!-- form-group// -->
                        <small class="text-muted">By clicking the 'Sign Up' button, you confirm that you accept our
                            <br>
                            Terms of use and Privacy Policy.</small>
                    </form>
                </article>
                <!-- card-body end .// -->
                <div class="border-top card-body text-center">Have an account? <a href="">Log In</a></div>
            </div>
            <!-- card.// -->

        </div>
        <div class="col-3"></div>
    </div>
</asp:Content>
