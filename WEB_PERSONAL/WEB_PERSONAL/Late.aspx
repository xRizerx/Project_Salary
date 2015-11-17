<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Late.aspx.cs" Inherits="WEB_PERSONAL.Late" MaintainScrollPositionOnPostback="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $("#ContentPlaceHolder1_TextBox11").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        });
    </script>
    <style>
        .mp {
            padding: 20px;
        }
        #sec1 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        #sec1_1 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        #sec1_2 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        .auto-style83 {
            width: 100px;
            text-align: right;
        }
    </style>
    <div class="mp">
        <div class="master_default_div_sec" id="sec1">
            <div class="master_default_div_sec_header">
                <asp:Label ID="Label36" runat="server" Text="เพิ่มเวลาเข้างาน"></asp:Label>
            </div>
            <div class="master_default_div_sec_in">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label41" runat="server" Text="วันที่"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox11" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label44" runat="server" Text="รหัสพนักงาน"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox21" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton20" runat="server" CssClass="master_default_button" OnClick="LinkButton20_Click">ตรวจสอบ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label47" runat="server" Text="ชื่อพนักงาน"></asp:Label>
                            
                        </td>
                        <td class="auto-style67">
                            <asp:Label ID="Label45" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label39" runat="server" Text="เวลาเข้า"></asp:Label>
                        </td>
                        <td class="auto-style64">
                            <asp:TextBox ID="TextBox22" runat="server" Width="50px" placeholder="ชั่วโมง" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:TextBox ID="TextBox23" runat="server" Width="50px" placeholder="นาที" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label40" runat="server" Text="เวลาออก"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox24" runat="server" placeholder="ชั่วโมง" Width="50px" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:TextBox ID="TextBox25" runat="server" placeholder="นาที" Width="50px" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style81"></td>
                        <td class="auto-style64">
                            <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_default_button" OnClick="LinkButton11_Click">เพิ่ม</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">&nbsp;</td>
                        <td class="auto-style67">&nbsp;</td>
                    </tr>
                </table>

            </div>
            
            
        </div>

        <div class="master_default_div_sec" id="sec1_1">
            <div class="master_default_div_sec_header">
                <asp:Label ID="Label37" runat="server" Text="รายชื่อการเข้างาน" Font-Bold="True"></asp:Label>
                
            </div>
            <div class="master_default_div_sec_in">
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView2_PageIndexChanging">
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

                <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>

            </div>
        </div>

        <div class="master_default_div_sec" id="sec1_2">
            <div class="master_default_div_sec_header">
                <asp:Label ID="Label38" runat="server" Text="รายชื่อการมาสาย" Font-Bold="True"></asp:Label>
                
            </div>
            <div class="master_default_div_sec_in">
                <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView3_PageIndexChanging">
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
            </div>
        </div>
    </div>
</asp:Content>
