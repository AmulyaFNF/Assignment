<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ex15Register.aspx.cs" Inherits="SampleWebFormsApp.Ex15Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <h1>User List</h1>
        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Username" HeaderText="Username" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Age" HeaderText="Age" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
