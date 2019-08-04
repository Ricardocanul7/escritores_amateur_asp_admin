<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/mpAdmin.Master" AutoEventWireup="true" CodeBehind="wfEditarUsuario.aspx.cs" Inherits="Escritores_Amateur_ASP.GUI.wfEditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContenido" runat="server">
    <div class="card">
        <div class="card-body">

            <div class="row">       
                <div class="col-md-6" > <!--NOMBRE-->
                    <div class="form-group">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                        <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6" >
                    <div class="form-group"> <!--Avatar-->
                         <asp:Label ID="lblAvatar" runat="server" Text="Avatar:"></asp:Label>
                         <asp:TextBox ID="txtAvatar" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div>
            </div>
            <div class="row">       
                <div class="col-md-6" > <!--Apellido Paterno-->
                    <div class="form-group">
                         <asp:Label ID="lblApellidoPat" runat="server" Text="Apellido Paterno:"></asp:Label>
                         <asp:TextBox ID="txtApellidoPat" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div> 
                <div class="col-md-6" >
                    <div class="form-group"> <!--Apellido Materno-->
                         <asp:Label ID="lblApellidoMat" runat="server" Text="Apellido Materno:"></asp:Label>
                         <asp:TextBox ID="txtApellidoMat" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div> 
            </div>
            <div class="row">       
                <div class="col-md-12" > <!--Correo-->
                    <div class="form-group">
                         <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
                         <asp:TextBox ID="txtCorreo" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div>
            </div>
            <div class="row">       
                <div class="col-md-6" > <!--Telefono-->
                    <div class="form-group">
                         <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
                         <asp:TextBox ID="txtTelefono" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div>
                 <div class="col-md-6" >
                    <div class="form-group"> <!--municipio-->
                         <asp:Label ID="lblMunicipio" runat="server" Text="Municipio:"></asp:Label>
                         <asp:TextBox ID="txtMunicipio" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div>  
            </div>
            <div class="row">       
                <div class="col-md-12" >
                    <div class="form-group"> <!--Sitio web-->
                         <asp:Label ID="lblSitioWeb" runat="server" Text="Sitio web:"></asp:Label>
                         <asp:TextBox ID="txtSitioWeb" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div>
            </div>
            <div class="row">       
                <div class="col-md-6" >
                    <div class="form-group"> <!--Username-->
                         <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                         <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div> 
                <div class="col-md-6" >
                    <div class="form-group"> <!--tipo_usuario-->
                         <asp:Label ID="lblTipoUser" runat="server" Text="Tipo de usuario:"></asp:Label>
                         <asp:DropDownList ID="drpTipoUser" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">       
                <div class="col-md-6" > <!--Contraseña-->
                    <div class="form-group">
                         <asp:Label ID="lblPassword" runat="server" Text="Contraseña:"></asp:Label>
                         <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>                    
                    </div>
                </div> 
            </div>
            <div class="row">       
                <div class="col-md-12" > <!--Biografia-->
                    <div class="form-group">
                         <asp:Label ID="lblBiografia" runat="server" Text="Biografía:"></asp:Label>
                         <asp:TextBox ID="txtBiografia" class="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>                    
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
