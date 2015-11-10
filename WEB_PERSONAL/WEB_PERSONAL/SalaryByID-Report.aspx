<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryByID-Report.aspx.cs" Inherits="WEB_PERSONAL.SalaryByID_Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .button{
            border-radius:5px;
            color:black;
            background-color:#ffaaeb;
            padding:10px;
        }
        .button:hover{
            color:white;
            background-color:green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" SelectCommand="SELECT * FROM (SELECT ROWNUM,TB_PERSONAL.CITIZEN_ID,TB_PERSONAL.STF_NAME,TB_PERSONAL.STF_LNAME,TB_POSITION.POSITION_NAME,TB_POSITION_WORK.POSITION_WORK_NAME,TB_ADMIN_POSITION.ADMIN_POSITION_NAME,
TB_SALARY_UP.detail_salary,TB_SALARY_UP.detail_maxsalary,TB_SALARY_UP.detail_basemoney,TB_SALARY_UP.detail_percent_rate,TB_SALARY_UP.detail_moneynotround,TB_SALARY_UP.detail_moneyround,
TB_SALARY_UP.detail_moneyup,TB_SALARY_UP.detail_moneybonus,TB_SALARY_UP.detail_sum_money,TB_SALARY_UP.detail_new_salary,TB_SALARY_UP.detail_score_test,TB_SALARY_UP.detail_level_test,
TB_SALARY_UP.admin_ratesum,TB_SALARY_UP.admin_rate,TB_SALARY_UP.admin_money_add,TB_SALARY_UP.sum_percent_rate2,TB_SALARY_UP.sum_moneynotround,TB_SALARY_UP.sum_moneyround,
TB_SALARY_UP.sum_moneyup,TB_SALARY_UP.sum_moneybonus,TB_SALARY_UP.sum_moneyuptotal,TB_SALARY_UP.sum_newsalary,TB_SALARY_UP.&quot;COMMENT&quot;
FROM TB_PERSONAL,TB_POSITION,TB_POSITION_WORK,TB_ADMIN_POSITION,TB_SALARY_UP
WHERE TB_PERSONAL.POSITION_ID = TB_POSITION.POSITION_ID AND TB_PERSONAL.POSITION_WORK_ID = TB_POSITION_WORK.POSITION_WORK_ID 
AND TB_PERSONAL.ADMIN_POSITION_ID = TB_ADMIN_POSITION.ADMIN_POSITION_ID AND TB_PERSONAL.citizen_id = TB_SALARY_UP.citizen_id ORDER BY TB_SALARY_UP.ID DESC ) WHERE ROWNUM =1" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>">
            </asp:SqlDataSource>
            <div class="auto-style1">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ROWNUM" HeaderText="ลำดับที่" SortExpression="ROWNUM" />
                        <asp:BoundField DataField="CITIZEN_ID" HeaderText="เลขประจำตัวประชาชน" SortExpression="CITIZEN_ID" />
                        <asp:BoundField DataField="STF_NAME" HeaderText="ชื่อ" SortExpression="STF_NAME" />
                        <asp:BoundField DataField="STF_LNAME" HeaderText="นามสกุล" SortExpression="STF_LNAME" />
                        <asp:BoundField DataField="POSITION_NAME" HeaderText="ชื่อตำแหน่งในสายงาน" SortExpression="POSITION_NAME" />
                        <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="ระดับตำแหน่ง" SortExpression="POSITION_WORK_NAME" />
                        <asp:BoundField DataField="ADMIN_POSITION_NAME" HeaderText="ชื่อตำแหน่งในการบริหาร" SortExpression="ADMIN_POSITION_NAME" />
                        <asp:BoundField DataField="DETAIL_SALARY" HeaderText="เงินเดือนก่อนเลื่อน (ณ 1มี.ค.58)" SortExpression="DETAIL_SALARY" />
                        <asp:BoundField DataField="DETAIL_MAXSALARY" HeaderText="เงินเดือนสูงสุดแต่ละประเภท" SortExpression="DETAIL_MAXSALARY" />
                        <asp:BoundField DataField="DETAIL_BASEMONEY" HeaderText="ฐานในการคำนวณ" SortExpression="DETAIL_BASEMONEY" />
                        <asp:BoundField DataField="DETAIL_PERCENT_RATE" HeaderText="ร้อยละที่ได้เลื่อน" SortExpression="DETAIL_PERCENT_RATE" />
                        <asp:BoundField DataField="DETAIL_MONEYNOTROUND" HeaderText="จำนวนเงินที่คำนวณได้ 3*4 ไม่ปัดเศษ" SortExpression="DETAIL_MONEYNOTROUND" />
                        <asp:BoundField DataField="DETAIL_MONEYROUND" HeaderText="จำนวนเงินที่คำนวณได้ 3*4(ปัดเศษ)" SortExpression="DETAIL_MONEYROUND" />
                        <asp:BoundField DataField="DETAIL_MONEYUP" HeaderText="จำนวนเงินที่ได้เลื่อน" SortExpression="DETAIL_MONEYUP" />
                        <asp:BoundField DataField="DETAIL_MONEYBONUS" HeaderText="เงินตอบแทนพิเศษ 5-7" SortExpression="DETAIL_MONEYBONUS" />
                        <asp:BoundField DataField="DETAIL_SUM_MONEY" HeaderText="รวมใช้เลื่อน 7+8" SortExpression="DETAIL_SUM_MONEY" />
                        <asp:BoundField DataField="DETAIL_NEW_SALARY" HeaderText="เงินเดือนใหม่ 1+7" SortExpression="DETAIL_NEW_SALARY" />
                        <asp:BoundField DataField="DETAIL_SCORE_TEST" HeaderText="คะแนนผลการประเมิน" SortExpression="DETAIL_SCORE_TEST" />
                        <asp:BoundField DataField="DETAIL_SCORE_TEST" HeaderText="ระดับผลการประเมิน" SortExpression="DETAIL_LEVEL_TEST" />
                        <asp:BoundField DataField="DETAIL_SCORE_TEST" HeaderText="ร้อยละที่ได้เลื่อนตามสัดส่วน" SortExpression="ADMIN_RATESUM" />
                        <asp:BoundField DataField="ADMIN_RATE" HeaderText="ร้อยละที่ได้เลื่อน(อธิการบดีเพิ่ม)" SortExpression="ADMIN_RATE" />
                        <asp:BoundField DataField="ADMIN_MONEY_ADD" HeaderText="จำนวนเงินที่ได้เพิ่ม" SortExpression="ADMIN_MONEY_ADD" />
                        <asp:BoundField DataField="SUM_PERCENT_RATE2" HeaderText="ร้อยละที่ได้เลื่อน" SortExpression="SUM_PERCENT_RATE2" />
                        <asp:BoundField DataField="SUM_MONEYNOTROUND" HeaderText="จำนวนเงินที่คำนวณได้ 3*4 (ไม่ปัดเศษ)" SortExpression="SUM_MONEYNOTROUND" />
                        <asp:BoundField DataField="SUM_MONEYROUND" HeaderText="จำนวนเงินที่คำนวณได้ 3*4 (ปัดเศษ)" SortExpression="SUM_MONEYROUND" />
                        <asp:BoundField DataField="SUM_MONEYUP" HeaderText="จำนวนเงินที่ได้เลื่อน" SortExpression="SUM_MONEYUP" />
                        <asp:BoundField DataField="SUM_MONEYBONUS" HeaderText="เงินตอบแทนพิเศษ" SortExpression="SUM_MONEYBONUS" />
                        <asp:BoundField DataField="SUM_MONEYUPTOTAL" HeaderText="รวมใช้เลื่อน" SortExpression="SUM_MONEYUPTOTAL" />
                        <asp:BoundField DataField="SUM_NEWSALARY" HeaderText="เงินเดือนใหม่" SortExpression="SUM_NEWSALARY" />
                        <asp:BoundField DataField="COMMENT" HeaderText="หมายเหตุ" SortExpression="COMMENT" />
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
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Export To Excel" CssClass="button" />
            <br />

        </asp:Panel>
    </div>
    </form>
</body>
</html>
