<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateHistory.aspx.cs" Inherits="WEB_PERSONAL.UpdateHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/UpdateHistory.css" rel="stylesheet" />
    <div class="mp">

        <div class="master_light_page_header">
            <asp:Label ID="Label2" runat="server" Text="ประวัติการอัพเดท"></asp:Label>
        </div>

        <div id="div_update_history" runat="server">
        </div>

        <div class="dpl_7c"></div>
    </div>
</asp:Content>
