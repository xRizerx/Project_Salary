<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryByID-Report.aspx.cs" Inherits="WEB_PERSONAL.SalaryByID_Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT DISTINCT TB_PERSONAL.CITIZEN_ID, TB_TITLENAME.TITLE_NAME_TH, TB_PERSONAL.STF_NAME, TB_PERSONAL.STF_LNAME, TB_POSITION.POSITION_NAME, TB_POSITION_WORK.POSITION_WORK_NAME, TB_ADMIN.ADMIN_POSITION_NAME, TB_SALARY_UP.DETAIL_SALARY, TB_SALARY_UP.DETAIL_MAXSALARY, TB_SALARY_UP.DETAIL_BASEMONEY, TB_SALARY_UP.DETAIL_PERCENT_RATE, TB_SALARY_UP.DETAIL_MONEYNOTROUND, TB_SALARY_UP.DETAIL_MONEYROUND, TB_SALARY_UP.DETAIL_MONEYUP, TB_SALARY_UP.DETAIL_MONEYBONUS, TB_SALARY_UP.DETAIL_SUM_MONEY, TB_SALARY_UP.DETAIL_NEW_SALARY, TB_SALARY_UP.DETAIL_SCORE_TEST, TB_SALARY_UP.DETAIL_LEVEL_TEST, TB_SALARY_UP.ADMIN_RATESUM, TB_SALARY_UP.ADMIN_RATE, TB_SALARY_UP.ADMIN_MONEY_ADD, TB_SALARY_UP.SUM_PERCENT_RATE2, TB_SALARY_UP.SUM_MONEYNOTROUND, TB_SALARY_UP.SUM_MONEYROUND, TB_SALARY_UP.SUM_MONEYUP, TB_SALARY_UP.SUM_MONEYBONUS, TB_SALARY_UP.SUM_MONEYUPTOTAL, TB_SALARY_UP.SUM_NEWSALARY, TB_SALARY_UP.COMMENT FROM TB_PERSONAL INNER JOIN TB_POSITION ON TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID INNER JOIN TB_TITLENAME ON TB_PERSONAL.TITLE_ID = TB_TITLENAME.TITLE_ID INNER JOIN TB_POSITION_WORK ON TB_PERSONAL.POSITION_WORK_ID = TB_POSITION_WORK.POSITION_WORK_ID INNER JOIN TB_ADMIN ON TB_PERSONAL.ADMIN_POSITION_ID = TB_ADMIN.ADMIN_POSITION_ID INNER JOIN TB_SALARY_UP ON TB_PERSONAL.CITIZEN_ID = TB_SALARY_UP.CITIZEN_ID">
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CITIZEN_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" ReadOnly="True" SortExpression="CITIZEN_ID" />
                    <asp:BoundField DataField="TITLE_NAME_TH" HeaderText="TITLE_NAME_TH" SortExpression="TITLE_NAME_TH" />
                    <asp:BoundField DataField="STF_NAME" HeaderText="STF_NAME" SortExpression="STF_NAME" />
                    <asp:BoundField DataField="STF_LNAME" HeaderText="STF_LNAME" SortExpression="STF_LNAME" />
                    <asp:BoundField DataField="POSITION_NAME" HeaderText="POSITION_NAME" SortExpression="POSITION_NAME" />
                    <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="POSITION_WORK_NAME" SortExpression="POSITION_WORK_NAME" />
                    <asp:BoundField DataField="ADMIN_POSITION_NAME" HeaderText="ADMIN_POSITION_NAME" SortExpression="ADMIN_POSITION_NAME" />
                    <asp:BoundField DataField="DETAIL_SALARY" HeaderText="DETAIL_SALARY" SortExpression="DETAIL_SALARY" />
                    <asp:BoundField DataField="DETAIL_MAXSALARY" HeaderText="DETAIL_MAXSALARY" SortExpression="DETAIL_MAXSALARY" />
                    <asp:BoundField DataField="DETAIL_BASEMONEY" HeaderText="DETAIL_BASEMONEY" SortExpression="DETAIL_BASEMONEY" />
                    <asp:BoundField DataField="DETAIL_PERCENT_RATE" HeaderText="DETAIL_PERCENT_RATE" SortExpression="DETAIL_PERCENT_RATE" />
                    <asp:BoundField DataField="DETAIL_MONEYNOTROUND" HeaderText="DETAIL_MONEYNOTROUND" SortExpression="DETAIL_MONEYNOTROUND" />
                    <asp:BoundField DataField="DETAIL_MONEYROUND" HeaderText="DETAIL_MONEYROUND" SortExpression="DETAIL_MONEYROUND" />
                    <asp:BoundField DataField="DETAIL_MONEYUP" HeaderText="DETAIL_MONEYUP" SortExpression="DETAIL_MONEYUP" />
                    <asp:BoundField DataField="DETAIL_MONEYBONUS" HeaderText="DETAIL_MONEYBONUS" SortExpression="DETAIL_MONEYBONUS" />
                    <asp:BoundField DataField="DETAIL_SUM_MONEY" HeaderText="DETAIL_SUM_MONEY" SortExpression="DETAIL_SUM_MONEY" />
                    <asp:BoundField DataField="DETAIL_NEW_SALARY" HeaderText="DETAIL_NEW_SALARY" SortExpression="DETAIL_NEW_SALARY" />
                    <asp:BoundField DataField="DETAIL_SCORE_TEST" HeaderText="DETAIL_SCORE_TEST" SortExpression="DETAIL_SCORE_TEST" />
                    <asp:BoundField DataField="DETAIL_LEVEL_TEST" HeaderText="DETAIL_LEVEL_TEST" SortExpression="DETAIL_LEVEL_TEST" />
                    <asp:BoundField DataField="ADMIN_RATESUM" HeaderText="ADMIN_RATESUM" SortExpression="ADMIN_RATESUM" />
                    <asp:BoundField DataField="ADMIN_RATE" HeaderText="ADMIN_RATE" SortExpression="ADMIN_RATE" />
                    <asp:BoundField DataField="ADMIN_MONEY_ADD" HeaderText="ADMIN_MONEY_ADD" SortExpression="ADMIN_MONEY_ADD" />
                    <asp:BoundField DataField="SUM_PERCENT_RATE2" HeaderText="SUM_PERCENT_RATE2" SortExpression="SUM_PERCENT_RATE2" />
                    <asp:BoundField DataField="SUM_MONEYNOTROUND" HeaderText="SUM_MONEYNOTROUND" SortExpression="SUM_MONEYNOTROUND" />
                    <asp:BoundField DataField="SUM_MONEYROUND" HeaderText="SUM_MONEYROUND" SortExpression="SUM_MONEYROUND" />
                    <asp:BoundField DataField="SUM_MONEYUP" HeaderText="SUM_MONEYUP" SortExpression="SUM_MONEYUP" />
                    <asp:BoundField DataField="SUM_MONEYBONUS" HeaderText="SUM_MONEYBONUS" SortExpression="SUM_MONEYBONUS" />
                    <asp:BoundField DataField="SUM_MONEYUPTOTAL" HeaderText="SUM_MONEYUPTOTAL" SortExpression="SUM_MONEYUPTOTAL" />
                    <asp:BoundField DataField="SUM_NEWSALARY" HeaderText="SUM_NEWSALARY" SortExpression="SUM_NEWSALARY" />
                    <asp:BoundField DataField="COMMENT" HeaderText="COMMENT" SortExpression="COMMENT" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
