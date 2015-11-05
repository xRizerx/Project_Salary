<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote 2.aspx.cs" Inherits="WEB_PERSONAL.insignia_recordnote_2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Panel ID="Panel2" runat="server" Height="925px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CITIZEN_ID" DataSourceID="SqlDataSource1" AutoGenerateEditButton="True">
            <Columns>
                <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" ReadOnly="True" SortExpression="CITIZEN_ID" />
                <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" />
                <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="POSITION_WORK_NAME" SortExpression="POSITION_WORK_NAME" />
                <asp:BoundField DataField="POSITION_NAME" HeaderText="POSITION_NAME" SortExpression="POSITION_NAME" />
                <asp:BoundField DataField="GRADEINSIGNIA_NAME" HeaderText="GRADEINSIGNIA_NAME" SortExpression="GRADEINSIGNIA_NAME" />
                <asp:BoundField DataField="GAZETTE_LAM" HeaderText="GAZETTE_LAM" SortExpression="GAZETTE_LAM" />
                <asp:BoundField DataField="GAZETTE_TON" HeaderText="GAZETTE_TON" SortExpression="GAZETTE_TON" />
                <asp:BoundField DataField="GAZETTE_NA" HeaderText="GAZETTE_NA" SortExpression="GAZETTE_NA" />
                <asp:BoundField DataField="GAZETTE_DATE" HeaderText="GAZETTE_DATE" SortExpression="GAZETTE_DATE" />
                <asp:BoundField DataField="INVOICE" HeaderText="INVOICE" SortExpression="INVOICE" />
                <asp:BoundField DataField="DECORATION" HeaderText="DECORATION" SortExpression="DECORATION" />
                <asp:BoundField DataField="NOTES" HeaderText="NOTES" SortExpression="NOTES" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_RECORDNOTE&quot;"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>

