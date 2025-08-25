<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ex13ValidationControl.aspx.cs" Inherits="SampleWbFormsApp.Ex13ValidationControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <h1>User Registration Page</h1>
        <hr />
        <section>
            Enter the Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Username is required" ForeColor="IndianRed" Display="Dynamic"></asp:RequiredFieldValidator>
        </section>
        <section>
            Enter the Password:<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required" ForeColor="IndianRed"></asp:RequiredFieldValidator>
        </section>
        <section>
            Reenter the Password:<asp:TextBox ID="txtRepassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator runat="server" ErrorMessage="Password not matching" ForeColor="IndianRed" ControlToValidate="txtPassword" ControlToCompare="txtRePassword" ValueToCompare="txtPassword" Display="Dynamic"></asp:CompareValidator>
        </section>
        <section>
            Enter the Email:
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="IndianRed" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" ErrorMessage="Enter in correct format" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="IndianRed" Display="Dynamic"></asp:RegularExpressionValidator>
        </section>
        <section>
            Enter the Age:
            <asp:TextBox ID="txtAge" runat="server"  TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Age is required" ControlToValidate="txtAge" ForeColor="IndianRed">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator runat="server" ControlToValidate="txtAge" MinimumValue="18" MaximumValue="50" ErrorMessage="Age must be between 18 and 50" ForeColor="IndianRed" Type="Integer" Display="Dynamic"></asp:RangeValidator>
        </section>
        <section>
            
            <asp:Button Text="Save" ID="btnSave" runat="server" OnClick="btnSave_Click" />
        </section>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>