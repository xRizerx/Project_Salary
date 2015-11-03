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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" SelectCommand="SELECT * FROM &quot;TB_PERSONAL&quot;" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>">
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="CITIZEN_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="YEAR" HeaderText="YEAR" SortExpression="YEAR" />
                    <asp:BoundField DataField="UNIV_ID" HeaderText="UNIV_ID" SortExpression="UNIV_ID" />
                    <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" SortExpression="CITIZEN_ID" ReadOnly="True" />
                    <asp:BoundField DataField="TITLE_ID" HeaderText="TITLE_ID" SortExpression="TITLE_ID" />
                    <asp:BoundField DataField="STF_NAME" HeaderText="STF_NAME" SortExpression="STF_NAME" />
                    <asp:BoundField DataField="STF_LNAME" HeaderText="STF_LNAME" SortExpression="STF_LNAME" />
                    <asp:BoundField DataField="GENDER_ID" HeaderText="GENDER_ID" SortExpression="GENDER_ID" />
                    <asp:BoundField DataField="BIRTHDAY" HeaderText="BIRTHDAY" SortExpression="BIRTHDAY" />
                    <asp:BoundField DataField="HOMEADD" HeaderText="HOMEADD" SortExpression="HOMEADD" />
                    <asp:BoundField DataField="DISTRICT_ID" HeaderText="DISTRICT_ID" SortExpression="DISTRICT_ID" />
                    <asp:BoundField DataField="AMPHUR_ID" HeaderText="AMPHUR_ID" SortExpression="AMPHUR_ID" />
                    <asp:BoundField DataField="PROVINCE_ID" HeaderText="PROVINCE_ID" SortExpression="PROVINCE_ID" />
                    <asp:BoundField DataField="TELEPHONE" HeaderText="TELEPHONE" SortExpression="TELEPHONE" />
                    <asp:BoundField DataField="ZIPCODE_ID" HeaderText="ZIPCODE_ID" SortExpression="ZIPCODE_ID" />
                    <asp:BoundField DataField="NATION_ID" HeaderText="NATION_ID" SortExpression="NATION_ID" />
                    <asp:BoundField DataField="STAFFTYPE_ID" HeaderText="STAFFTYPE_ID" SortExpression="STAFFTYPE_ID" />
                    <asp:BoundField DataField="TIME_CONTACT_ID" HeaderText="TIME_CONTACT_ID" SortExpression="TIME_CONTACT_ID" />
                    <asp:BoundField DataField="BUDGET_ID" HeaderText="BUDGET_ID" SortExpression="BUDGET_ID" />
                    <asp:BoundField DataField="SUBSTAFFTYPE_ID" HeaderText="SUBSTAFFTYPE_ID" SortExpression="SUBSTAFFTYPE_ID" />
                    <asp:BoundField DataField="ADMIN_POSITION_ID" HeaderText="ADMIN_POSITION_ID" SortExpression="ADMIN_POSITION_ID" />
                    <asp:BoundField DataField="POSITION_ID" HeaderText="POSITION_ID" SortExpression="POSITION_ID" />
                    <asp:BoundField DataField="POSITION_WORK_ID" HeaderText="POSITION_WORK_ID" SortExpression="POSITION_WORK_ID" />
                    <asp:BoundField DataField="DEPARTMENT_ID" HeaderText="DEPARTMENT_ID" SortExpression="DEPARTMENT_ID" />
                    <asp:BoundField DataField="DATETIME_INWORK" HeaderText="DATETIME_INWORK" SortExpression="DATETIME_INWORK" />
                    <asp:BoundField DataField="SPECIAL_NAME" HeaderText="SPECIAL_NAME" SortExpression="SPECIAL_NAME" />
                    <asp:BoundField DataField="TEACH_ISCED_ID" HeaderText="TEACH_ISCED_ID" SortExpression="TEACH_ISCED_ID" />
                    <asp:BoundField DataField="GRAD_LEV_ID" HeaderText="GRAD_LEV_ID" SortExpression="GRAD_LEV_ID" />
                    <asp:BoundField DataField="GRAD_CURR" HeaderText="GRAD_CURR" SortExpression="GRAD_CURR" />
                    <asp:BoundField DataField="GRAD_ISCED_ID" HeaderText="GRAD_ISCED_ID" SortExpression="GRAD_ISCED_ID" />
                    <asp:BoundField DataField="GRAD_PROG_ID" HeaderText="GRAD_PROG_ID" SortExpression="GRAD_PROG_ID" />
                    <asp:BoundField DataField="GRAD_UNIV" HeaderText="GRAD_UNIV" SortExpression="GRAD_UNIV" />
                    <asp:BoundField DataField="GRAD_COUNTRY_ID" HeaderText="GRAD_COUNTRY_ID" SortExpression="GRAD_COUNTRY_ID" />
                    <asp:BoundField DataField="BRANCH_ID" HeaderText="BRANCH_ID" SortExpression="BRANCH_ID" />
                    <asp:BoundField DataField="RANK_ID" HeaderText="RANK_ID" SortExpression="RANK_ID" />
                    <asp:BoundField DataField="GOT_ID" HeaderText="GOT_ID" SortExpression="GOT_ID" />
                    <asp:BoundField DataField="GET_ID" HeaderText="GET_ID" SortExpression="GET_ID" />
                    <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" SortExpression="PASSWORD" />
                    <asp:BoundField DataField="SYSTEM_STATUS_ID" HeaderText="SYSTEM_STATUS_ID" SortExpression="SYSTEM_STATUS_ID" />
                    <asp:BoundField DataField="STREET" HeaderText="STREET" SortExpression="STREET" />
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
