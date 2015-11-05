<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salary_Basesalary.aspx.cs" Inherits="WEB_PERSONAL.Salary_Basesalary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .panin{
            background-color:rgba(255,255,255,0.8);
            border-radius: 5px;
            border: 2px solid white;
        }
        .panout {
            padding: 20px;
            text-align: center;
            background-color:pink;
        }
        .button_ui{
            border-radius: 2px;
            padding:5px 8px;
            background-color:rgb(200, 125, 0);
            border-color:black;
            color:white;
            text-decoration:none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" CssClass="panout" Height="250px">
            <asp:Panel ID="Panel2" runat="server" CssClass="panin" Width="100%" Height="100%">

                <table style="width:100%;">
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="POSITION_NAME" DataValueField="BASE_ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" SelectCommand="SELECT BASESALARY.BASE_ID, TB_POSITION.POSITION_NAME FROM BASESALARY, TB_POSITION WHERE BASESALARY.POSITION_ID = TB_POSITION.POSITION_ID" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>"></asp:SqlDataSource>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="ช่วงเงินเดือนสูงสุด"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="บน"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="ล่าง"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="ช่วงเงินเดือนต่ำสุด"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="บน"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="ล่าง"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button_ui" OnClick="LinkButton1_Click">บันทึก</asp:LinkButton>&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button_ui">ยกเลิก</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>

            </asp:Panel>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
