<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="WEB_PERSONAL.Leave" MaintainScrollPositionOnPostback="true" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
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
            $("#ContentPlaceHolder1_TextBox2,#ContentPlaceHolder1_TextBox5,#ContentPlaceHolder1_TextBox6,#ContentPlaceHolder1_TextBox9,#ContentPlaceHolder1_TextBox17,#ContentPlaceHolder1_TextBox18,#ContentPlaceHolder1_TextBox11").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        });
    </script>
    <style type="text/css">
        .wrapper {
            /*width: auto;
            background-color: #f0f0f0;*/
        }

        .mp {
            padding: 20px;
        }

        .c1 {
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

        .div_sec {
            margin: 50px auto;
            box-shadow: #808080 0px 5px 5px;
        }

        .div_sec_header {
            background-color: rgba(128,128,128,0.8);
            padding: 20px 25px;
            font-weight: bold;
        }

        .div_sec_header span {
            color: #FFFFFF;
            text-shadow: 1px 1px 1px #000000;
        }

        .div_sec_in {
            background-color: rgba(128,128,128,0.6);
            padding: 20px 20px;
        }

        .div_sec_in span {
            color: #FFFFFF;
            text-shadow: 1px 1px 1px #000000;
        }

        #sec1 {
            background-image: url("Image/time_check_in.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        #sec2 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        #sec3 {
            background-image: url("Image/writing-on-paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        #sec4 {
            background-image: url("Image/papers.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        #sec5 {
            background-image: url("Image/report-writing.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        .leave_sec1 {
            padding: 20px 0px;
            margin: 20px 0;
            border-bottom: 1px solid #808080;
        }

        .leave_sec2 {
            padding: 20px 0px;
            margin: 20px 0;
            border-bottom: 1px solid #808080;
        }

        .leave_sec3 {
            padding: 20px 0px;
            margin: 20px 0;
            border-bottom: 1px solid #808080;
        }


        .auto-style58 {
            width: 180px;
        }

        .auto-style64 {
            width: 298px;
            height: 28px;
        }

        .auto-style67 {
            width: 298px;
        }

        .auto-style69 {
            width: 298px;
            height: 95px;
        }

        .auto-style75 {
            width: 192px;
            text-align: right;
        }

        .auto-style77 {
            width: 317px;
        }

        .auto-style78 {
            width: 77px;
            text-align: right;
            height: 29px;
        }

        .auto-style79 {
            width: 317px;
            height: 29px;
        }

        .auto-style81 {
            width: 50px;
            text-align: right;
            height: 28px;
        }

        .auto-style83 {
            width: 50px;
            text-align: right;
        }

        .auto-style92 {
            width: 79px;
            text-align: right;
        }

        .auto-style93 {
            width: 77px;
            text-align: right;
        }
    </style>
    <asp:Panel ID="Panel2" runat="server" CssClass="mp">
        <div class="c1">
            <asp:Label ID="Label1" runat="server" Text="การลา" Font-Size="32"></asp:Label>

        </div>
        <div class="div_sec" id="sec1">
            <div class="div_sec_header">
                <asp:Label ID="Label36" runat="server" Text="เพิ่มเวลาเข้างาน"></asp:Label>
            </div>
            <div class="div_sec_in">
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
            <div class="div_sec_header">
                <asp:Label ID="Label37" runat="server" Text="รายชื่อการเข้างาน" Font-Bold="True"></asp:Label>
                
            </div>
            <div class="div_sec_in">
                <asp:LinkButton ID="LinkButton21" runat="server" CssClass="master_default_button" OnClick="LinkButton21_Click">ดูรายชื่อการเข้างาน</asp:LinkButton>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <div class="div_sec_header">
                <asp:Label ID="Label38" runat="server" Text="รายชื่อการมาสาย" Font-Bold="True"></asp:Label>
                
            </div>
            <div class="div_sec_in">
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="master_default_button" OnClick="LinkButton1_Click1">ดูรายชื่อการลา</asp:LinkButton>
                <asp:GridView ID="GridView3" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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

        <div class="div_sec" id="sec2">
            <div class="div_sec_header">
                <asp:Label ID="Label22" runat="server" Text="เพิ่มเอกสารการลา" Font-Bold="True"></asp:Label>
            </div>
            <div class="div_sec_in">

                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label23" runat="server" Text="รหัสผู้ลา"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox16" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton17" runat="server" CssClass="master_default_button" OnClick="Button1_Click2">ตรวจสอบ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label46" runat="server" Text="ชื่อผู้ลา"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:Label ID="Label24" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label25" runat="server" Text="ประเภทการลา"></asp:Label>
                        </td>
                        <td class="auto-style64">
                            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource3" DataTextField="LEAVE_TYPE_NAME" DataValueField="LEAVE_TYPE_ID" CssClass="master_default_dropdown" OnDataBound="DropDownList5_DataBound">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label26" runat="server" Text="สถานะการลา"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource1" DataTextField="LEAVE_STATUS_NAME" DataValueField="LEAVE_STATUS_ID" CssClass="master_default_dropdown" OnDataBound="DropDownList6_DataBound">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label27" runat="server" Text="จากวันที่"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox17" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label28" runat="server" Text="ถึงวันที่"></asp:Label>
                        </td>
                        <td class="auto-style67">
                            <asp:TextBox ID="TextBox18" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">
                            <asp:Label ID="Label29" runat="server" Text="เหตุผล"></asp:Label>
                        </td>
                        <td class="auto-style69">
                            <asp:TextBox ID="TextBox19" runat="server" Height="85px" TextMode="MultiLine" Width="298px" CssClass="master_default_textbox_multi_line"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style83">&nbsp;</td>
                        <td class="auto-style67">
                            <asp:LinkButton ID="LinkButton16" runat="server" CssClass="master_default_button" OnClick="LinkButton16_Click">เพิ่ม</asp:LinkButton>
                        </td>
                    </tr>
                </table>

            </div>
        </div>

        
        <div class="div_sec" id="sec3">
            <div class="div_sec_header">
                <asp:Label ID="Label30" runat="server" Text="แก้ไขเอกสารการลา" Font-Bold="True"></asp:Label>
            </div>
            <div class="div_sec_in">

                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Label ID="Label20" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                        <td></td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style75">
                            <asp:Label ID="Label21" runat="server" Text="ค้นหาตามรหัสเอกสาร"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox15" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton18" runat="server" CssClass="master_default_button" OnClick="LinkButton18_Click">ดึง</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label7" runat="server" Text="รหัสเอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:Label ID="Label33" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style78">
                            <asp:Label ID="Label8" runat="server" Text="วันที่เอกสาร"></asp:Label>
                        </td>
                        <td class="auto-style79">
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label9" runat="server" Text="รหัสผู้ลา"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton14" runat="server" CssClass="master_default_button" OnClick="LinkButton14_Click">ตรวจสอบ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label17" runat="server" Text="ชื่อผู้ลา"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:Label ID="Label31" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label14" runat="server" Text="รหัสผู้อนุมัติ"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:TextBox ID="TextBox8" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton15" runat="server" CssClass="master_default_button" OnClick="LinkButton15_Click">ตรวจสอบ</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label19" runat="server" Text="ชื่อผู้อนุมัติ"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:Label ID="Label32" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label15" runat="server" Text="วันที่อนุมัติ"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:TextBox ID="TextBox9" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label10" runat="server" Text="ประเภทการลา"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="LEAVE_TYPE_NAME" DataValueField="LEAVE_TYPE_ID" CssClass="master_default_dropdown" OnDataBound="DropDownList1_DataBound">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label13" runat="server" Text="สถานะการลา"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="LEAVE_STATUS_NAME" DataValueField="LEAVE_STATUS_ID" CssClass="master_default_dropdown" OnDataBound="DropDownList2_DataBound">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label11" runat="server" Text="จากวันที่"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:TextBox ID="TextBox5" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style93">
                            <asp:Label ID="Label12" runat="server" Text="ถึงวันที่"></asp:Label>
                        </td>
                        <td class="auto-style77">
                            <asp:TextBox ID="TextBox6" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                </table>

                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style75">
                            <asp:Label ID="Label16" runat="server" Text="เหตุผลที่ลา"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox10" runat="server" Height="74px" TextMode="MultiLine" Width="584px" CssClass="master_default_textbox_multi_line"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style75">&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_default_button" OnClick="LinkButton13_Click">แก้ไข</asp:LinkButton>
                        </td>
                    </tr>
                </table>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_LEAVE_STATUS&quot;"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_LEAVE_TYPE&quot;"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT * FROM &quot;TB_LEAVE&quot;"></asp:SqlDataSource>

            </div>
        </div>

        
        <div class="div_sec" id="sec4">
            <div class="div_sec_header">
                <asp:Label ID="Label34" runat="server" Text="ข้อมูลเอกสารการลา" Font-Bold="True"></asp:Label>
            </div>
            <div class="div_sec_in">

                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Button1_Click1" CssClass="master_default_button">ทดสอบ</asp:LinkButton>

                <table>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label2" runat="server" Text="ค้นหาตามสถานะ"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" CssClass="master_default_button">ทั้งหมด</asp:LinkButton>
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
                            <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="LEAVE_TYPE_NAME" DataValueField="LEAVE_TYPE_ID" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" CssClass="master_default_dropdown" OnDataBound="DropDownList4_DataBound"></asp:DropDownList>
                        </td>
                    </tr>
                </table>

                <table>
                    <tr>
                        <td class="auto-style58">
                            <asp:Label ID="Label3" runat="server" Text="ค้นหาตามรหัสผู้ลา"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" CssClass="master_default_textbox"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox12" runat="server" CssClass="master_default_textbox"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox7" runat="server" CssClass="master_default_textbox"></asp:TextBox>
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
                            <asp:TextBox ID="TextBox14" runat="server" CssClass="master_default_textbox"></asp:TextBox>
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
            </div>
        </div>

        
        <div class="div_sec" id="sec5">
            <div class="div_sec_header">
                <asp:Label ID="Label35" runat="server" Text="ออกรายงานการลา" Font-Bold="True"></asp:Label>
            </div>
            <div class="div_sec_in">
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton19" runat="server" CssClass="master_default_button" OnClick="LinkButton1_Click">ออกรายงาน 1</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>

    </asp:Panel>
</asp:Content>
