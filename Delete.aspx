<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Delete__Update.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar</h1>
<p>
    Carné del alumno
    <asp:TextBox ID="TextBoxSerchDelete" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonSearchID" runat="server" Text="Buscar Carné" OnClick="Button1_Click" />
</p>
<p>
    Nombre&nbsp;
    <asp:TextBox ID="TextBoxName" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    Apellido&nbsp;
    <asp:TextBox ID="TextBoxLastName" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonDeleteData" runat="server" Text="Eliminar Dato" OnClick="ButtonDeleteData_Click" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
