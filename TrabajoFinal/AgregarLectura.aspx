<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLectura.aspx.cs" Inherits="TrabajoFinal.AgregarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="minutoTXT">Minuto</label>
                        <asp:TextBox ID="minutoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <label for="fechaTXT">fecha</label>
                        <asp:Calendar ID="calendarTXT" CssClass="form-control" runat="server"></asp:Calendar>
                    </div>

                    <div class="form-group">
                        <label for="horaTXT">Hora</label>
                        <asp:TextBox ID="horaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="valorConsumotxt">Valor cosumo</label>
                        <asp:TextBox ID="valorConsumotxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    
                    
                    <div class="form-group">
                        <label for="medidorDDL">medidor</label>
                        <asp:DropDownList ID="medidorDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" OnClick="ingresaBtn_Click"/>

                </div>
            </div>

        </div>
    </div>
    
</asp:Content>
