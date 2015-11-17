<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote2.aspx.cs" Inherits="WEB_PERSONAL.insignia_recordnote_2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       .GridPanel
       {
            overflow:scroll;
        }

 </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Panel ID="Panel2" runat="server" CssClass="GridPanel">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CITIZEN_ID" DataSourceID="SqlDataSource1" AutoGenerateEditButton="True" OnRowCreated="GridView1_RowCreated">
            <Columns>
                <asp:BoundField DataField="CITIZEN_ID" HeaderText="เลขประจำตัวประชาชน" ReadOnly="True" SortExpression="CITIZEN_ID" />
                <asp:BoundField DataField="DATE" HeaderText="วัน เดือน ปี" SortExpression="DATE" />
                <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="ตำแหน่ง" SortExpression="POSITION_WORK_NAME" />
                <asp:BoundField DataField="POSITION_NAME" HeaderText="ระดับ" SortExpression="POSITION_NAME" />
                <asp:BoundField DataField="GRADEINSIGNIA_NAME" HeaderText="ได้รับ ชั้น/รายการ" SortExpression="GRADEINSIGNIA_NAME" />
                <asp:BoundField DataField="GAZETTE_LAM" HeaderText="เล่ม" SortExpression="GAZETTE_LAM" />
                <asp:BoundField DataField="GAZETTE_TON" HeaderText="ตอน" SortExpression="GAZETTE_TON" />
                <asp:BoundField DataField="GAZETTE_NA" HeaderText="หน้า" SortExpression="GAZETTE_NA" />
                <asp:BoundField DataField="GAZETTE_DATE" HeaderText="วัน เดือน ปั" SortExpression="GAZETTE_DATE" />
                <asp:BoundField DataField="INVOICE" HeaderText="สถานะ" SortExpression="INVOICE" />
                <asp:BoundField DataField="DECORATION" HeaderText="สถานะ" SortExpression="DECORATION" />
                <asp:BoundField DataField="NOTES" HeaderText="หมายเหตุ" SortExpression="NOTES" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_RECORDNOTE&quot;"></asp:SqlDataSource>
        
    </asp:Panel>
</asp:Content>

