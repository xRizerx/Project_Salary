<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leave-Report1.aspx.cs" Inherits="WEB_PERSONAL.Leave_Report1" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PAPER_ID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="PAPER_ID" HeaderText="PAPER_ID" ReadOnly="True" SortExpression="PAPER_ID" />
                <asp:BoundField DataField="PAPER_DATE" HeaderText="PAPER_DATE" SortExpression="PAPER_DATE" />
                <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" SortExpression="CITIZEN_ID" />
                <asp:BoundField DataField="LEAVE_TYPE_ID" HeaderText="LEAVE_TYPE_ID" SortExpression="LEAVE_TYPE_ID" />
                <asp:BoundField DataField="LEAVE_FROM_DATE" HeaderText="LEAVE_FROM_DATE" SortExpression="LEAVE_FROM_DATE" />
                <asp:BoundField DataField="LEAVE_TO_DATE" HeaderText="LEAVE_TO_DATE" SortExpression="LEAVE_TO_DATE" />
                <asp:BoundField DataField="LEAVE_STATUS_ID" HeaderText="LEAVE_STATUS_ID" SortExpression="LEAVE_STATUS_ID" />
                <asp:BoundField DataField="APPROVER_ID" HeaderText="APPROVER_ID" SortExpression="APPROVER_ID" />
                <asp:BoundField DataField="APPROVE_DATE" HeaderText="APPROVE_DATE" SortExpression="APPROVE_DATE" />
                <asp:BoundField DataField="REASON" HeaderText="REASON" SortExpression="REASON" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_LEAVE&quot;"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
