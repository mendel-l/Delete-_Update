<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Delete__Update._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Alumnos</h1>
        <p>
            Universidad<asp:DropDownList ID="DropDownListUni" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
                <asp:ListItem>Lndivar</asp:ListItem>
                <asp:ListItem>San Carlos</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Alumno</p>
        <p>
            Nombre<asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </p>
        <p>
            Apellido<asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        </p>
        <p>
            Carné<asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
        </p>
        <p>
            Notas</p>
        <p>
            Curso<asp:TextBox ID="TextBoxCourse" runat="server"></asp:TextBox>
        </p>
        <p>
            Punteo<asp:TextBox ID="TextBoxPTS" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAddNotes" runat="server" OnClick="ButtonAddNotes_Click" Text="Ingresar Notas" />
        </p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="ButtonAddStudentU" runat="server" OnClick="ButtonAddStudentU_Click" Text="Ingresar Alumno Universidad" Width="282px" />
        </p>
        <p>
            <asp:Button ID="ButtonSaveUnivercity" runat="server" OnClick="ButtonSaveUnivercity_Click" Text="Guardar Universidad" Width="282px" />
        </p>
        <h1>&nbsp;</h1>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
