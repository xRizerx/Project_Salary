<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Study-IN.aspx.cs" Inherits="WEB_PERSONAL.Study_IN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $("#ContentPlaceHolder1_TextBox2,#ContentPlaceHolder1_TextBox7,#ContentPlaceHolder1_TextBox8").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        });
    </script>

    <link href="CSS/Study.css" rel="stylesheet" />

 

    <style type="text/css">
        .auto-style26 {
            width: 450px;
        }
        .auto-style27 {
            width: 620px;
        }
    </style>

 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel8" runat="server" CssClass="pan">
        <div class="master_light_page_header">
            การลาศึกษาต่อภายในและภายนอกประเทศ
        </div>
        <div class="master_light_div_sec">
            <div class="master_light_div_sec_title">
                เพิ่มข้อมูลการลาศึกษาต่อ
            </div>
            <div class="master_light_div_sec_pre_in">


                <div class="master_light_div_sec_in">


                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label36" runat="server" Text="ค้นหาเอกสาร"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox23" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                                <asp:LinkButton ID="LinkButton15" runat="server" CssClass="master_light_button" OnClick="LinkButton15_Click">ค้นหา</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label8" runat="server" Text="รหัสเอกสาร"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox1" runat="server" Enabled="False" CssClass="master_light_textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label10" runat="server" Text="รหัสผู้ลาศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                                <asp:LinkButton ID="LinkButton18" runat="server" CssClass="master_light_button" OnClick="LinkButton18_Click">ตรวจสอบ</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label35" runat="server" Text="ชื่อผู้ลาศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="Label37" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label38" runat="server" Text="ประเภทผู้ลาศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="Label39" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label40" runat="server" Text="ตำแหน่งผู้ลาศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:Label ID="Label41" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">&nbsp;</td>
                            <td class="auto-style27">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label47" runat="server" Text="ปีที่ศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox28" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label12" runat="server" Text="ระดับ"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NAME" DataValueField="ID" CssClass="master_light_dropdown" OnDataBound="DropDownList1_DataBound">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_STUDY_DEGREE&quot;"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label13" runat="server" Text="สาขา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox29" runat="server" CssClass="master_light_textbox" Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label14" runat="server" Text="สถานที่"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="master_light_textbox" Width="400px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label42" runat="server" Text="หลักสูตร"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="NAME" DataValueField="ID" CssClass="master_light_dropdown" OnDataBound="DropDownList3_DataBound">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_STUDY_COURSE&quot;"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label43" runat="server" Text="ระยะเวลาที่ศึกษา"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox24" runat="server" Width="40px" CssClass="master_light_textbox"></asp:TextBox>
                                <asp:Label ID="Label44" runat="server" Text="ทั้งสิ้น"></asp:Label>
                                <asp:TextBox ID="TextBox25" runat="server" Width="40px" CssClass="master_light_textbox"></asp:TextBox>
                                <asp:Label ID="Label48" runat="server" Text="ปี"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label15" runat="server" Text="จากวันที่"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox7" runat="server" CssClass="master_light_textbox" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label16" runat="server" Text="ถึงวันที่"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox8" runat="server" CssClass="master_light_textbox" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label45" runat="server" Text="ระยะเวลาที่ศึกษาตามหลักสูตร"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox26" runat="server" CssClass="master_light_textbox" Width="50px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">
                                <asp:Label ID="Label46" runat="server" Text="หมายเหตุ"></asp:Label>
                            </td>
                            <td class="auto-style27">
                                <asp:TextBox ID="TextBox27" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style25">&nbsp;</td>
                            <td class="auto-style27">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style25">&nbsp;</td>
                            <td class="auto-style27">
                                <div class="login_button_div">
                                    <ul>
                                        <li>
                                            <asp:LinkButton ID="LinkButton16" runat="server" CssClass="master_light_button" OnClick="LinkButton16_Click">เพิ่ม</asp:LinkButton>
                                        </li>
                                        <li>
                                            <asp:LinkButton ID="LinkButton17" runat="server" CssClass="master_light_button" OnClick="LinkButton17_Click">แก้ไข</asp:LinkButton>
                                        </li>
                                    </ul>

                                </div>


                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <br />
        <div class="dpl_7c" style="height: 1px; margin: 20px 0;"></div>

        <div class="master_light_div_sec">
            <div class="master_light_div_sec_title">
                ข้อมูลการลาศึกษาต่อ
            </div>
            <div class="master_light_div_sec_pre_in">


                <div class="master_light_div_sec_in">

                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>


                </div>
            </div>

        </div>



    </asp:Panel>
</asp:Content>
