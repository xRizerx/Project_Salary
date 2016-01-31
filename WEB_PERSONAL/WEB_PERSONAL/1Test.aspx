<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="1Test.aspx.cs" Inherits="WEB_PERSONAL._1Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">
             <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Button" />
    </asp:Panel>

</asp:Content>
