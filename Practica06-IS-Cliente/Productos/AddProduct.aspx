<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Practica06_IS_Cliente.Productos.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Crear nuevo producto</h1>
    <br/>
    <div>

        Nombre:&nbsp;&nbsp;
        <asp:TextBox ID="TxtNombre" runat="server" Width="176px"></asp:TextBox>
        <br />
        Precio:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtPrecio" runat="server" OnTextChanged="TextBox2_TextChanged" Width="176px"></asp:TextBox>
        <br />
        Iva:<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>
        <br />
        <asp:RadioButton ID="RadioButtonIva" runat="server" GroupName="RadioButtonList1" Text="Con Iva" />
        <asp:RadioButton ID="RadioButtonNoIva" runat="server" GroupName="RadioButtonList1" Text="Sin iva " />
        <br />
        Id Categoria:&nbsp;
        <asp:TextBox ID="TxtIdCategoria" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="BtnCrear" runat="server" OnClick="BtnCrear_Click" Text="Crear" Width="132px" />

    </div>
</asp:Content>
