<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ex14LoginPage.aspx.cs" Inherits="SampleWebFormsApp.Ex14LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <section>
            Enter the Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Username is required" ForeColor="IndianRed" Display="Dynamic"></asp:RequiredFieldValidator>
</section>
     <section>
     Enter the Password:<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
     <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required" ForeColor="IndianRed"></asp:RequiredFieldValidator>
 </section>
    <section>
        <asp:Button Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    </section>
</asp:Content>
