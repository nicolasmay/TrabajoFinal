<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLectura.aspx.cs" Inherits="TrabajoFinal.MostrarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <asp:GridView ID="grillaLectura" 
            AutoGenerateColumns="false" 
            ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" 
            runat="server">
            <Columns>
                <asp:BoundField HeaderText="Fecha" DataField="Fecha" />
                <asp:BoundField HeaderText="Minutos" DataField="Minuto" />
                <asp:BoundField HeaderText="Hora" DataField="Hora" />
                <asp:BoundField HeaderText="Valor consumo" DataField="Valorconsumo" />
                <asp:BoundField HeaderText="idMedidor" DataField="IdMedidor" />
                
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

