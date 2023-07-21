<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="TrabajoFinal.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
<div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Usuario</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTXT">Rut</label>
                        <asp:TextBox ID="rutTXT" CssClass="form-control" runat="server">Rut</asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <label for="nombreTXT">Nombre</label>
                        <asp:TextBox ID="nombreTXT" CssClass="form-control" runat="server">Nombre</asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="Correo">Correo</label>
                        <asp:TextBox ID="CorreoTXT" CssClass="form-control" runat="server">Correo</asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="contrasenaTXT">Contraseña</label>
                        <asp:TextBox ID="contrasenaTXT" CssClass="form-control" runat="server">Contraseña</asp:TextBox>
                    </div>
                    
                    
                    
                    
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" OnClick="ingresaBtn_Click"/>

                </div>
            </div>

        </div>
    </div>
</asp:Content>
