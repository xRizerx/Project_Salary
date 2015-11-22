<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Study-IN.aspx.cs" Inherits="WEB_PERSONAL.Study_IN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $("#ContentPlaceHolder1_TextBox2,#ContentPlaceHolder1_TextBox7,#ContentPlaceHolder1_TextBox8").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        }); 
    </script>
    <style type="text/css">
        .pan {
            padding: 20px;
        }
        #sec1 {
            background-image: url("Image/books.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        #sec2 {
            background-image: url("Image/papers.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        .login_button_div ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            margin-top: 8px;
        }

        .login_button_div li {
            display: inline;
        }

        .cen {
            text-align: center;
        }

        .cen2 {
            margin: 20px auto;
            padding: 20px;
            border: 1px solid #808080;
        }

        .leave_grid_view {
            margin: 0 auto;
            text-align: center;
            border: 1px solid #808080;
            width: 90%;
        }

        .leave_sec2 {
            margin: 20px auto;
            padding: 20px;
            border: 1px solid #808080;
        }

        .bold {
            font-weight: bold;
        }

        .auto-style14 {
            width: 293px;
        }

        .auto-style15 {
            width: 150px;
            text-align: right;
            padding-right: 5px;
            height: 28px;
        }

        .auto-style16 {
            width: 293px;
            height: 28px;
        }

        .auto-style19 {
            width: 150px;
            text-align: right;
            padding-right: 5px;
            height: 33px;
        }
        .auto-style20 {
            width: 293px;
            height: 33px;
        }
        .auto-style25 {
            width: 150px;
            text-align: right;
            padding-right: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel8" runat="server" CssClass="pan">
        <div class="master_default_page_header">
            <asp:Label ID="Label1" runat="server" Text="การลาศึกษาต่อภายในและภายนอกประเทศ" Font-Size="32"></asp:Label>
        </div>
        <div class="master_default_div_sec" id="sec1">
            <div class="master_default_div_sec_header">
                <asp:Label ID="Label2" runat="server" Text="เพิ่มข้อมูลการลาศึกษาต่อ"></asp:Label>
            </div>
            <div class="master_default_div_sec_in">


                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style19">
                            <asp:Label ID="Label36" runat="server" Text="ค้นหาเอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style20">
                            <asp:TextBox ID="TextBox23" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton15" runat="server" CssClass="master_default_button" OnClick="LinkButton15_Click">ดึง</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label8" runat="server" Text="รหัสเอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox1" runat="server" Enabled="False" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label10" runat="server" Text="รหัสผู้ลาศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton18" runat="server" CssClass="master_default_button" OnClick="LinkButton18_Click">ตรวจสอบ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label35" runat="server" Text="ชื่อผู้ลาศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:Label ID="Label37" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label38" runat="server" Text="ประเภทผู้ลาศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:Label ID="Label39" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label40" runat="server" Text="ตำแหน่งผู้ลาศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style16">
                            <asp:Label ID="Label41" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">&nbsp;</td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label47" runat="server" Text="ปีที่ศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox28" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label12" runat="server" Text="ระดับ"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NAME" DataValueField="ID" CssClass="master_default_dropdown" OnDataBound="DropDownList1_DataBound">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_STUDY_DEGREE&quot;"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label13" runat="server" Text="สาขา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox29" runat="server" CssClass="master_default_textbox" Width="400px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label14" runat="server" Text="สถานที่"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox6" runat="server" CssClass="master_default_textbox" Width="400px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label42" runat="server" Text="หลักสูตร"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="NAME" DataValueField="ID" CssClass="master_default_dropdown" OnDataBound="DropDownList3_DataBound">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_STUDY_COURSE&quot;"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label43" runat="server" Text="ระยะเวลาที่ศึกษา"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox24" runat="server" Width="40px" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:Label ID="Label44" runat="server" Text="ทั้งสิ้น"></asp:Label>
                            <asp:TextBox ID="TextBox25" runat="server" Width="40px" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:Label ID="Label48" runat="server" Text="ปี"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label15" runat="server" Text="จากวันที่"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox7" runat="server" CssClass="master_default_textbox" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label16" runat="server" Text="ถึงวันที่"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox8" runat="server" CssClass="master_default_textbox" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label45" runat="server" Text="ระยะเวลาที่ศึกษาตามหลักสูตร"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox26" runat="server" CssClass="master_default_textbox" Width="50px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">
                            <asp:Label ID="Label46" runat="server" Text="หมายเหตุ"></asp:Label>
                        </td>
                        <td class="auto-style14">
                            <asp:TextBox ID="TextBox27" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style25">&nbsp;</td>
                        <td class="auto-style14">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style25">&nbsp;</td>
                        <td class="auto-style14">
                            <div class="login_button_div">
                                <ul>
                                    <li>
                                        <asp:LinkButton ID="LinkButton16" runat="server" CssClass="master_default_button" OnClick="LinkButton16_Click">เพิ่ม</asp:LinkButton>
                                    </li>
                                    <li>
                                        <asp:LinkButton ID="LinkButton17" runat="server" CssClass="master_default_button" OnClick="LinkButton17_Click">แก้ไข</asp:LinkButton>
                                    </li>
                                </ul>

                            </div>


                        </td>
                    </tr>
                </table>
            </div>
        </div>

        <div class="master_default_div_sec" id="sec2">
            <div class="master_default_div_sec_header">
                <asp:Label ID="Label3" runat="server" Text="ข้อมูลการลาศึกษาต่อ"></asp:Label>
            </div>
            <div class="master_default_div_sec_in">
                
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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



    </asp:Panel>
</asp:Content>
