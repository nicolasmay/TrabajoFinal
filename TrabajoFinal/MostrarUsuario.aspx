<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuario.aspx.cs" Inherits="TrabajoFinal.MostrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <asp:GridView ID="grillaLectura" 
            AutoGenerateColumns="false" 
            ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" 
            runat="server">
            <Columns>
                <asp:BoundField HeaderText="Rut" DataField="Rut" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Correo" DataField="Correo" />
                <asp:BoundField HeaderText="Contrasena" DataField="Contrasena" />
               
                
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

