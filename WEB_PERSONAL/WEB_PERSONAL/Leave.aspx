<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="WEB_PERSONAL.Leave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            width: 78%;
        }
        .auto-style5 {
            height: 29px;
            width: 174px;
        }
        .auto-style7 {
            width: 147px;
        }
        .auto-style8 {
            height: 29px;
            width: 147px;
        }
        .auto-style9 {
            height: 26px;
            width: 147px;
        }
        .auto-style10 {
            width: 174px;
        }
        .auto-style11 {
            height: 26px;
            width: 174px;
        }
        .auto-style12 {
            width: 280px;
        }
        .auto-style13 {
            height: 29px;
            width: 148px;
        }
        .auto-style14 {
            height: 26px;
            width: 280px;
        }
        .auto-style15 {
            width: 64px;
        }
        .auto-style16 {
            height: 29px;
            width: 64px;
        }
        .auto-style17 {
            height: 26px;
            width: 64px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .c1 {
            font-size: 32px;
            text-align: center;
            margin: 20px;
        }
    </style>
    <asp:Panel ID="Panel2" runat="server" Height="437px">
        <div class="c1">
            <asp:Label ID="Label1" runat="server" Text="ระบบการลา"></asp:Label>
        </div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label7" runat="server" Text="รหัสเอกสาร"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label8" runat="server" Text="วันที่เอกสาร"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label9" runat="server" Text="รหัสพนักงาน"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label10" runat="server" Text="ประเภทการลา"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label11" runat="server" Text="จากวันที่"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text="ถึงวันที่"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label13" runat="server" Text="สถานะการลา"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label14" runat="server" Text="รหัสผู้อนุมัติ"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17"></td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label15" runat="server" Text="วันที่อนุมัติ"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17"></td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label16" runat="server" Text="เหตุผลที่ลา"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style1">
                    
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Text="บันทึก" />
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PAPER_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="PAPER_ID" HeaderText="PAPER_ID" ReadOnly="True" SortExpression="PAPER_ID" />
                    <asp:BoundField DataField="PAPER_DATETIME" HeaderText="PAPER_DATETIME" SortExpression="PAPER_DATETIME" />
                    <asp:BoundField DataField="EMP_ID" HeaderText="EMP_ID" SortExpression="EMP_ID" />
                    <asp:BoundField DataField="LEAVE_TYPE_ID" HeaderText="LEAVE_TYPE_ID" SortExpression="LEAVE_TYPE_ID" />
                    <asp:BoundField DataField="LEAVE_FROM_DATETIME" HeaderText="LEAVE_FROM_DATETIME" SortExpression="LEAVE_FROM_DATETIME" />
                    <asp:BoundField DataField="LEAVE_TO_DATETIME" HeaderText="LEAVE_TO_DATETIME" SortExpression="LEAVE_TO_DATETIME" />
                    <asp:BoundField DataField="LEAVE_STATUS_ID" HeaderText="LEAVE_STATUS_ID" SortExpression="LEAVE_STATUS_ID" />
                    <asp:BoundField DataField="APPROVER_ID" HeaderText="APPROVER_ID" SortExpression="APPROVER_ID" />
                    <asp:BoundField DataField="APPROVE_DATETIME" HeaderText="APPROVE_DATETIME" SortExpression="APPROVE_DATETIME" />
                    <asp:BoundField DataField="REASON" HeaderText="REASON" SortExpression="REASON" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [PAPER_ID], [PAPER_DATETIME], [EMP_ID], [LEAVE_TYPE_ID], [LEAVE_FROM_DATETIME], [LEAVE_TO_DATETIME], [LEAVE_STATUS_ID], [APPROVER_ID], [APPROVE_DATETIME], [REASON] FROM [TB_LEAVE]"></asp:SqlDataSource>

        </div>
</asp:Panel>
</asp:Content>
