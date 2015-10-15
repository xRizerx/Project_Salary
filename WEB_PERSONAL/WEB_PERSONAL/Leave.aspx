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
        .auto-style10 {
            width: 174px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .c1 {
            font-family: ths;
            font-size: 32px;
            text-align: center;
            margin: 20px;
        }
        .auto-style22 {
            width: 145px;
        }
        .auto-style23 {
            width: 40px;
        }
        .auto-style24 {
            height: 29px;
            width: 40px;
        }
        .auto-style27 {
            width: 200px;
        }
        .auto-style31 {
            height: 29px;
            width: 121px;
        }
        .auto-style32 {
            width: 121px;
        }
        .auto-style34 {
            width: 144px;
        }
        .auto-style35 {
            width: 110px;
        }
        .auto-style36 {
            width: 171px;
        }
    </style>
    <asp:Panel ID="Panel2" runat="server" Height="751px">
        <div class="c1">
            <asp:Label ID="Label1" runat="server" Text="ระบบการลา"></asp:Label>
            
        </div>
        <table style="width:100%;">
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:Label ID="Label7" runat="server" Text="รหัสเอกสาร"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style35">
                        <asp:Label ID="Label8" runat="server" Text="วันที่เอกสาร"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:Label ID="Label9" runat="server" Text="รหัสพนักงาน"></asp:Label>
                    </td>
                    <td class="auto-style27">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style35">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <table style="width:100%;">
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style34">
                        <asp:Label ID="Label17" runat="server" Text="ชื่อ"></asp:Label>
                    </td>
                    <td class="auto-style36">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style35">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style35">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style34">&nbsp;</td>
                    <td class="auto-style36">&nbsp;</td>
                    <td class="auto-style35">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        <table class="auto-style3">
            <tr>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label10" runat="server" Text="ประเภทการลา"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="LEAVE_TYPE_NAME" DataValueField="LEAVE_TYPE_ID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [LEAVE_TYPE_ID], [LEAVE_TYPE_NAME] FROM [TB_LEAVE_TYPE]"></asp:SqlDataSource>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label13" runat="server" Text="สถานะการลา"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="LEAVE_STATUS_NAME" DataValueField="LEAVE_STATUS_ID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [LEAVE_STATUS_ID], [LEAVE_STATUS_NAME] FROM [TB_LEAVE_STATUS]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:Label ID="Label11" runat="server" Text="จากวันที่"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label14" runat="server" Text="รหัสผู้อนุมัติ"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text="ถึงวันที่"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style32">
                    <asp:Label ID="Label19" runat="server" Text="ชื่อ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style32">
                    <asp:Label ID="Label15" runat="server" Text="วันที่อนุมัติ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style32">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Label ID="Label16" runat="server" Text="เหตุผลที่ลา"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Height="74px" TextMode="MultiLine" Width="584px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton11" runat="server" OnClick="LinkButton11_Click">ดึง</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>

            

            <asp:Button ID="Button1" runat="server" Text="บันทึก" />

            

        </div>
</asp:Panel>
</asp:Content>
