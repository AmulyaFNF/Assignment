<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ex16HomePage.aspx.cs" Inherits="SampleWebFormsApp.Ex16HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>HomePage</h1>
    <asp:Button Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
    <asp:Button Text="Register" ID="btnRegister" runat="server" OnClick="btnRegister_Click" />
</asp:Content>
