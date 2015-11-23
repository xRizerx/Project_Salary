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
        @font-face {
            font-family: THS;
            src: url("Font/THSarabun.ttf");
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" SelectCommand="SELECT TB_PERSON.ID, TB_PERSON.CITIZEN_ID, TB_PERSON.TITLE_ID, TB_PERSON.PERSON_NAME, TB_PERSON.PERSON_LASTNAME, TB_POSITION.NAME, TB_SALARY_UP.DETAIL_SALARY, TB_SALARY_UP.DETAIL_MAXSALARY, TB_SALARY_UP.DETAIL_BASEMONEY, TB_SALARY_UP.DETAIL_PERCENT_RATE, TB_SALARY_UP.DETAIL_MONEYNOTROUND, TB_SALARY_UP.DETAIL_MONEYROUND, TB_SALARY_UP.DETAIL_MONEYUP, TB_SALARY_UP.DETAIL_MONEYBONUS, TB_SALARY_UP.DETAIL_SUM_MONEY, TB_SALARY_UP.DETAIL_NEW_SALARY, TB_SALARY_UP.DETAIL_SCORE_TEST, TB_SALARY_UP.DETAIL_LEVEL_TEST, TB_SALARY_UP.ADMIN_RATESUM, TB_SALARY_UP.ADMIN_RATE, TB_SALARY_UP.ADMIN_MONEY_ADD, TB_SALARY_UP.SUM_PERCENT_RATE2, TB_SALARY_UP.SUM_MONEYNOTROUND, TB_SALARY_UP.SUM_MONEYROUND, TB_SALARY_UP.SUM_MONEYUP, TB_SALARY_UP.SUM_MONEYBONUS, TB_SALARY_UP.SUM_MONEYUPTOTAL, TB_SALARY_UP.SUM_NEWSALARY, TB_SALARY_UP.&quot;COMMENT&quot; FROM TB_PERSON, TB_POSITION_AND_SALARY, TB_SALARY_UP, TB_POSITION WHERE TB_PERSON.ID = TB_POSITION_AND_SALARY.ID AND TB_PERSON.ID = TB_SALARY_UP.ID AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>">
            </asp:SqlDataSource>
            <div class="auto-style1">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Font-Names="THS" Width="3000px" OnRowCreated="GridView1_RowCreated" DataKeyNames="ID">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ReadOnly="True" />
                        <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" SortExpression="CITIZEN_ID" />
                        <asp:BoundField DataField="TITLE_ID" HeaderText="TITLE_ID" SortExpression="TITLE_ID" >
                        </asp:BoundField>
                        <asp:BoundField DataField="PERSON_NAME" HeaderText="PERSON_NAME" SortExpression="PERSON_NAME" >
                        </asp:BoundField>
                        <asp:BoundField DataField="PERSON_LASTNAME" HeaderText="PERSON_LASTNAME" SortExpression="PERSON_LASTNAME" >
                        </asp:BoundField>
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_SALARY" HeaderText="DETAIL_SALARY" SortExpression="DETAIL_SALARY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_MAXSALARY" HeaderText="DETAIL_MAXSALARY" SortExpression="DETAIL_MAXSALARY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_BASEMONEY" HeaderText="DETAIL_BASEMONEY" SortExpression="DETAIL_BASEMONEY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_PERCENT_RATE" HeaderText="DETAIL_PERCENT_RATE" SortExpression="DETAIL_PERCENT_RATE" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_MONEYNOTROUND" HeaderText="DETAIL_MONEYNOTROUND" SortExpression="DETAIL_MONEYNOTROUND" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_MONEYROUND" HeaderText="DETAIL_MONEYROUND" SortExpression="DETAIL_MONEYROUND" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_MONEYUP" HeaderText="DETAIL_MONEYUP" SortExpression="DETAIL_MONEYUP" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_MONEYBONUS" HeaderText="DETAIL_MONEYBONUS" SortExpression="DETAIL_MONEYBONUS" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_SUM_MONEY" HeaderText="DETAIL_SUM_MONEY" SortExpression="DETAIL_SUM_MONEY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_NEW_SALARY" HeaderText="DETAIL_NEW_SALARY" SortExpression="DETAIL_NEW_SALARY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_SCORE_TEST" HeaderText="DETAIL_SCORE_TEST" SortExpression="DETAIL_SCORE_TEST" >
                        </asp:BoundField>
                        <asp:BoundField DataField="DETAIL_LEVEL_TEST" HeaderText="DETAIL_LEVEL_TEST" SortExpression="DETAIL_LEVEL_TEST" >
                        </asp:BoundField>
                        <asp:BoundField DataField="ADMIN_RATESUM" HeaderText="ADMIN_RATESUM" SortExpression="ADMIN_RATESUM" >
                        </asp:BoundField>
                        <asp:BoundField DataField="ADMIN_RATE" HeaderText="ADMIN_RATE" SortExpression="ADMIN_RATE" >
                        </asp:BoundField>
                        <asp:BoundField DataField="ADMIN_MONEY_ADD" HeaderText="ADMIN_MONEY_ADD" SortExpression="ADMIN_MONEY_ADD" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_PERCENT_RATE2" HeaderText="SUM_PERCENT_RATE2" SortExpression="SUM_PERCENT_RATE2" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_MONEYNOTROUND" HeaderText="SUM_MONEYNOTROUND" SortExpression="SUM_MONEYNOTROUND" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_MONEYROUND" HeaderText="SUM_MONEYROUND" SortExpression="SUM_MONEYROUND" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_MONEYUP" HeaderText="SUM_MONEYUP" SortExpression="SUM_MONEYUP" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_MONEYBONUS" HeaderText="SUM_MONEYBONUS" SortExpression="SUM_MONEYBONUS" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_MONEYUPTOTAL" HeaderText="SUM_MONEYUPTOTAL" SortExpression="SUM_MONEYUPTOTAL" >
                        </asp:BoundField>
                        <asp:BoundField DataField="SUM_NEWSALARY" HeaderText="SUM_NEWSALARY" SortExpression="SUM_NEWSALARY" >
                        </asp:BoundField>
                        <asp:BoundField DataField="COMMENT" HeaderText="COMMENT" SortExpression="COMMENT" >
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Export To Excel" CssClass="button" />
            <br />

        </asp:Panel>
    </div>
    </form>
</body>
</html>
