<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salary-report.aspx.cs" Inherits="WEB_PERSONAL.Salary_report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <style>
        @font-face {
            font-family: THS;
            src: url("Font/THSarabun.ttf");
        }
    </style>
    
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
        <div class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" BorderColor="Black" BorderWidth="2px" Font-Names="THS" ShowHeaderWhenEmpty="True" EmptyDataText="ไม่พบข้อมูลในระบบ" EmptyDataRowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" BorderColor="Black" BorderWidth="2px" />
                <Columns>
                    <asp:BoundField DataField="ROWNUM" HeaderText="ลำดับที่" SortExpression="ROW" />
                    <asp:BoundField DataField="BRANCH_NAME" HeaderText="หน่วยงาน" SortExpression="BRANCH_NAME">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="COUNT_PEOPLE" HeaderText="จำนวนคน ณ 1 มี.ค. 58" SortExpression="COUNT_PEOPLE" />
                    <asp:BoundField DataField="SUM_SALARY" HeaderText="อัตราเงินเดือนรวม ณ 1 มี.ค. 58" SortExpression="SUM_SALARY" />
                    <asp:BoundField DataField="RATE_SUMSALARY" HeaderText="วงเงิน 2.9% ของเงินเดือนรวม" SortExpression="RATE_SUMSALARY" />
                    <asp:BoundField DataField="RATE_MONEY_UP" HeaderText="เงินเดือนที่ใช้เลื่อน ณ 1 เม.ย. 58" SortExpression="RATE_MONEY_UP" />
                    <asp:BoundField DataField="RATE_BALANCE" HeaderText="วงเงินคงเหลือ" SortExpression="RATE_BALANCE" />
                    <asp:BoundField DataField="SUM_PRE_MONTH" HeaderText="วงเงิน 0.1% ของเงินเดือนรวม ณ 1 มี.ค. 58" SortExpression="SUM_PRE_MONTH" />
                    <asp:BoundField DataField="ADMIN_MONEY_ADD" HeaderText="จำนวนเงินที่อธิการบดีเพิ่มให้" SortExpression="ADMIN_MONEY_ADD" />
                    <asp:BoundField DataField="SUM_MONEY_UP" HeaderText="วงเงินใช้เลื่อนทั้งสิ้น (3%)" SortExpression="SUM_MONEY_UP" />
                    <asp:BoundField DataField="SUM_MONEY_TOTAL" HeaderText="เงินที่ใช้เลื่อน ณ 1 เม.ย. 58 ทั้งสิ้น" SortExpression="SUM_MONEY_TOTAL" />
                    <asp:BoundField DataField="SUM_BALANCE" HeaderText="วงเงินคงเหลือทั้งสิ้น" SortExpression="SUM_BALANCE" />
                    <asp:BoundField DataField="COMMENT" HeaderText="หมายเหตุ" SortExpression="COMMENT">
                    <ItemStyle Width="200px" />
                    </asp:BoundField>
                </Columns>
                <EditRowStyle BackColor="#2461BF" BorderColor="Black" BorderWidth="2px" />
                <EmptyDataRowStyle BorderColor="Black" BorderWidth="0px" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderWidth="2px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" BorderColor="Black" BorderWidth="2px" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" SelectCommand="SELECT * FROM (SELECT ROWNUM,TB_BRANCH.BRANCH_NAME,TB_DPIS.COUNT_PEOPLE,TB_DPIS.SUM_SALARY,TB_DPIS.RATE_SUMSALARY,TB_DPIS.RATE_MONEY_UP,TB_DPIS.RATE_BALANCE,TB_DPIS.SUM_PRE_MONTH,TB_DPIS.ADMIN_MONEY_ADD,TB_DPIS.SUM_MONEY_UP,TB_DPIS.SUM_MONEY_TOTAL,TB_DPIS.SUM_BALANCE,nvl(TB_DPIS.&#34;COMMENT&#34;,' ')as &#34;COMMENT&#34; FROM TB_DPIS,TB_BRANCH WHERE TB_DPIS.BRANCH_ID = TB_BRANCH.BRANCH_ID ORDER BY TB_DPIS.DPIS_ID DESC) WHERE ROWNUM=1" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>"></asp:SqlDataSource>
        </asp:Panel>
    </div>

    </form>


</body>
</html>
