<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchWord.aspx.cs" Inherits="AssignmentWeb.SearchWord" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Translation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            English Word:
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <asp:Panel ID="pnlAddTranslation" runat="server" Visible="false">
            <br />
            Translation:
            <asp:TextBox ID="txtTranslation" runat="server"></asp:TextBox>
            <asp:Button ID="btnAddTranslation" runat="server" OnClick="btnAddTranslation_Click" Text="Add Translation" />
        </asp:Panel>
        <br /><br />
        <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Key" HeaderText="Word" />
                <asp:BoundField DataField="Value" HeaderText="Translation" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>