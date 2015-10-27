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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="รหัสเอกสาร" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="รหัสเอกสาร" HeaderText="รหัสเอกสาร" ReadOnly="True" SortExpression="รหัสเอกสาร"/>
                <asp:BoundField DataField="วันที่เอกสาร" HeaderText="วันที่เอกสาร" SortExpression="วันที่เอกสาร" DataFormatString="{0:dd/MM/yyyy}"/>
                <asp:BoundField DataField="รหัสผู้ลา" HeaderText="รหัสผู้ลา" SortExpression="รหัสผู้ลา" />
                <asp:BoundField DataField="ชื่อผู้ลา" HeaderText="ชื่อผู้ลา" SortExpression="ชื่อผู้ลา" ReadOnly="True" />
                <asp:BoundField DataField="ประเภท" HeaderText="ประเภท" SortExpression="ประเภท" />
                <asp:BoundField DataField="จากวันที่" HeaderText="จากวันที่" SortExpression="จากวันที่" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="ถึงวันที่" HeaderText="ถึงวันที่" SortExpression="ถึงวันที่" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="สถานะ" HeaderText="สถานะ" SortExpression="สถานะ" />
                <asp:BoundField DataField="รหัสผู้อนุมัติ" HeaderText="รหัสผู้อนุมัติ" SortExpression="รหัสผู้อนุมัติ" />
                <asp:BoundField DataField="ชื่อผู้อนุมัติ" HeaderText="ชื่อผู้อนุมัติ" SortExpression="ชื่อผู้อนุมัติ" ReadOnly="True" />
                <asp:BoundField DataField="วันที่อนุมัติ" HeaderText="วันที่อนุมัติ" SortExpression="วันที่อนุมัติ" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="เหตุผล" HeaderText="เหตุผล" SortExpression="เหตุผล" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT TB_LEAVE.PAPER_ID AS 'รหัสเอกสาร', TB_LEAVE.PAPER_DATE AS 'วันที่เอกสาร', TB_LEAVE.CITIZEN_ID AS 'รหัสผู้ลา', a.STF_NAME + ' ' + a.STF_LNAME AS 'ชื่อผู้ลา', TB_LEAVE_TYPE.LEAVE_TYPE_NAME AS 'ประเภท', TB_LEAVE.LEAVE_FROM_DATE AS 'จากวันที่', TB_LEAVE.LEAVE_TO_DATE AS 'ถึงวันที่', TB_LEAVE_STATUS.LEAVE_STATUS_NAME AS 'สถานะ', TB_LEAVE.APPROVER_ID AS 'รหัสผู้อนุมัติ', b.STF_NAME + ' ' + b.STF_LNAME AS 'ชื่อผู้อนุมัติ', TB_LEAVE.APPROVE_DATE AS 'วันที่อนุมัติ', TB_LEAVE.REASON AS 'เหตุผล' FROM TB_PERSONAL AS b INNER JOIN TB_PERSONAL AS a INNER JOIN TB_LEAVE_TYPE INNER JOIN TB_LEAVE ON TB_LEAVE_TYPE.LEAVE_TYPE_ID = TB_LEAVE.LEAVE_TYPE_ID INNER JOIN TB_LEAVE_STATUS ON TB_LEAVE.LEAVE_STATUS_ID = TB_LEAVE_STATUS.LEAVE_STATUS_ID ON a.CITIZEN_ID = TB_LEAVE.CITIZEN_ID ON b.CITIZEN_ID = TB_LEAVE.APPROVER_ID"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
