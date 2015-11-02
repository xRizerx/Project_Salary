<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="WEB_PERSONAL.Leave" MaintainScrollPositionOnPostback="true"%>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

        .auto-style2 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $(document).ready(function () {
                $("#ContentPlaceHolder1_TextBox2,#ContentPlaceHolder1_TextBox5,#ContentPlaceHolder1_TextBox6,#ContentPlaceHolder1_TextBox9").datepicker({
                    dateFormat: 'dd/mm/yy',
                    changeMonth: true,
                    changeYear: true,
                    beforeShow: function () {
                        $(".ui-datepicker").css('font-size', 14)
                    }
                });
            });
        });
    </script>
    <style type="text/css">
        .c1 {
            font-family: ths;
            font-size: 32px;
            text-align: center;
        }

        .leave_button_div ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            margin-top: 8px;
        }

        .leave_button_div li {
            display: inline;
            /*555*/
        }

        .leave_button_div a {
            text-decoration: none;
            display: inline;
        }



        .leave_paper_pull {
            text-decoration: none;
            display: inline;
            padding: 3px 20px;
            margin: 0 0px;
            width: 60px;
            color: #202020;
            background-color: #e0e0e0;
            border-radius: 24px;
        }

            .leave_paper_pull:hover {
                color: #000000;
                background-color: #c0c0c0;
            }

        .leave_grid_view {
            margin: 0 auto;
            text-align: center;
            border: 1px solid #808080;
        }

        .leave_sec1 {
            margin: 0 20px;
            border: 1px solid #808080;
        }

        .leave_sec2 {
            margin: 20px;
            border: 1px solid #808080;
        }

        .auto-style23 {
            width: 40px;
        }

        .auto-style24 {
            height: 29px;
            width: 40px;
        }

        .auto-style31 {
            height: 29px;
            width: 121px;
        }

        .auto-style32 {
            width: 121px;
        }

        .auto-style35 {
            width: 110px;
        }

        .auto-style39 {
            width: 176px;
        }

        .auto-style42 {
            width: 40px;
            height: 26px;
        }

        .auto-style43 {
            width: 145px;
            height: 26px;
        }

        .auto-style44 {
            width: 175px;
            height: 26px;
        }

        .auto-style45 {
            width: 110px;
            height: 26px;
        }

        .auto-style46 {
            height: 26px;
        }

        .auto-style47 {
            width: 19px;
        }

        .auto-style50 {
            height: 29px;
            width: 288px;
        }

        .auto-style51 {
            width: 288px;
        }

        .auto-style53 {
            width: 124px;
        }

        .auto-style54 {
            height: 29px;
            width: 124px;
        }

        .auto-style55 {
            width: 109px;
        }
        .auto-style57 {
            width: 198px;
        }
        .auto-style58 {
            width: 180px;
        }
    </style>
    <asp:Panel ID="Panel2" runat="server" Height="1658px">
        <br />
        <div class="c1">
            <asp:Label ID="Label1" runat="server" Text="ระบบการลา"></asp:Label>

        </div>
        <br />
        <div>
            <asp:Panel ID="Panel4" runat="server" CssClass="leave_sec1" Height="518px">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td>
                            <asp:Panel ID="Panel3" runat="server" Height="32px">
                                <asp:Label ID="Label20" runat="server" ForeColor="Red"></asp:Label>
                            </asp:Panel>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>

                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">&nbsp;</td>
                        <td class="auto-style39">&nbsp;</td>
                        <td class="auto-style55">&nbsp;</td>
                        <td class="auto-style35">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td class="auto-style47">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">
                            <asp:Label ID="Label7" runat="server" Text="รหัสเอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style39">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style55">
                            <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_default_button" OnClick="LinkButton11_Click">ดึง</asp:LinkButton>
                        </td>
                        <td class="auto-style35">
                            <asp:Label ID="Label9" runat="server" Text="รหัสพนักงาน"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton14" runat="server" CssClass="master_default_button" OnClick="LinkButton14_Click">ดึง</asp:LinkButton>
                        </td>
                        <td class="auto-style47">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">
                            <asp:Label ID="Label8" runat="server" Text="วันที่เอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style39">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style55">&nbsp;</td>
                        <td class="auto-style35">
                            <asp:Label ID="Label17" runat="server" Text="ชื่อ"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox11" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td class="auto-style47">&nbsp;</td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style42"></td>
                        <td class="auto-style43"></td>
                        <td class="auto-style44"></td>
                        <td class="auto-style45"></td>
                        <td class="auto-style46"></td>
                        <td class="auto-style46"></td>
                    </tr>
                </table>
                <table class="ui-accordion">
                    <tr>
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style54">
                            <asp:Label ID="Label10" runat="server" Text="ประเภทการลา"></asp:Label>
                        </td>
                        <td class="auto-style50">
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
                        <td class="auto-style24">&nbsp;</td>
                        <td class="auto-style54">
                            <asp:Label ID="Label11" runat="server" Text="จากวันที่"></asp:Label>
                        </td>
                        <td class="auto-style50">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style31">
                            <asp:Label ID="Label14" runat="server" Text="รหัสผู้อนุมัติ"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton15" runat="server" CssClass="master_default_button" OnClick="LinkButton15_Click">ดึง</asp:LinkButton>
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">
                            <asp:Label ID="Label12" runat="server" Text="ถึงวันที่"></asp:Label>
                        </td>
                        <td class="auto-style51">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style32">
                            <asp:Label ID="Label19" runat="server" Text="ชื่อ"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">&nbsp;</td>
                        <td class="auto-style51">&nbsp;</td>
                        <td class="auto-style32">
                            <asp:Label ID="Label15" runat="server" Text="วันที่อนุมัติ"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">&nbsp;</td>
                        <td class="auto-style51">&nbsp;</td>
                        <td class="auto-style32">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">
                            <asp:Label ID="Label16" runat="server" Text="เหตุผลที่ลา"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox10" runat="server" Height="74px" TextMode="MultiLine" Width="584px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style23">&nbsp;</td>
                        <td class="auto-style53">&nbsp;</td>
                        <td>
                            <div class="leave_button_div">
                                <ul>
                                    <li>
                                        <asp:LinkButton ID="LinkButton12" runat="server" CssClass="master_default_button" OnClick="LinkButton12_Click">เพิ่ม</asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_default_button" OnClick="LinkButton13_Click">บันทึก</asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="master_default_button" OnClick="LinkButton1_Click">ออกรายงาน 1</asp:LinkButton>
                                    </li>
                                </ul>
                            </div>



                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>


            </asp:Panel>
        </div>

        <div>
            <asp:Panel ID="Panel5" runat="server" CssClass="leave_sec2" Height="996px">

                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Button1_Click1" CssClass="master_default_button">ทดสอบ</asp:LinkButton>

                <table>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label2" runat="server" Text="ค้นหาตามสถานะ"></asp:Label>
                        </td>
                        <td>
                             <asp:LinkButton ID="LinkButton3" runat="server" OnClick="Button2_Click" CssClass="master_default_button">ทั้งหมด</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="Button3_Click" CssClass="master_default_button">ยังไม่ตรวจสอบ</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="Button4_Click" CssClass="master_default_button">อนุมัติ</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton6" runat="server" OnClick="Button5_Click" CssClass="master_default_button">ไม่อนุมัติ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label18" runat="server" Text="ค้นหาตามประเภท"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="LEAVE_TYPE_NAME" DataValueField="LEAVE_TYPE_ID" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                    </tr>
                </table>

                <table>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label3" runat="server" Text="ค้นหาตามรหัสผู้ลา"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton7" runat="server" CssClass="master_default_button" OnClick="LinkButton7_Click">ค้นหา</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label5" runat="server" Text="ค้นหาตามชื่อผู้ลา"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton9" runat="server" CssClass="master_default_button" OnClick="LinkButton9_Click">ค้นหา</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label4" runat="server" Text="ค้นหาตามรหัสผู้อนุมัติ"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton8" runat="server" CssClass="master_default_button" OnClick="LinkButton8_Click">ค้นหา</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label6" runat="server" Text="ค้นหาตามชื่อผู้อนุมัติ"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton10" runat="server" CssClass="master_default_button" OnClick="LinkButton10_Click">ค้นหา</asp:LinkButton>
                        </td>
                    </tr>
                </table>

                <asp:Panel ID="Panel8" runat="server" ScrollBars="Both" CssClass="leave_grid_view" Height="800px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging">
                        <AlternatingRowStyle BackColor="White" />
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
                </asp:Panel>
            </asp:Panel>
        </div>

    </asp:Panel>
</asp:Content>
