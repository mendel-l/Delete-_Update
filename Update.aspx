<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Delete__Update.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar</h1>
<p>
    &nbsp;Carné del alumno&nbsp;
    <asp:TextBox ID="TextBoxSearch" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonSearchStudent" runat="server" Text="Buscar Alumno" OnClick="ButtonSerchStudent_Click" />
</p>
<p>
    Nombre&nbsp;
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
</p>
<p>
    Apellido&nbsp;
    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="ButtonChangeData" runat="server" Text="Modificar Dato" OnClick="ButtonChangeData_Click" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
