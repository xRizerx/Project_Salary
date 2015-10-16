<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Study.aspx.cs" Inherits="WEB_PERSONAL.Study" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .p {
            text-align: center;
            padding: 20px;
        }
        .h {
            font-size: 32px;
        }
        .cen {
            text-align: center;
        }
    </style>
    <asp:Panel ID="Panel8" runat="server" Height="600px" CssClass="p">
        <asp:Label ID="Label1" runat="server" Text="การศึกษาต่อ *ยังไม่ได้ทำ" CssClass="h"></asp:Label>
        <br />
        <br />
        <div class="cen">
            <iframe width="800" height="500" src="https://www.youtube.com/embed/ey3m2iWzkrE" frameborder="0" allowfullscreen></iframe>
        </div>
        
    </asp:Panel>
</asp:Content>
