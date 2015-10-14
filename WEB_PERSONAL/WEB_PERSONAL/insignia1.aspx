<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia1.aspx.cs" Inherits="WEB_PERSONAL.insignia1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            height: 23px;
            text-align: center;
        }
        .auto-style4 {
            font-size: xx-large;
        }
        .auto-style5 {
            font-size: large;
        }
        .auto-style8 {
            width: 253px;
        }
        .auto-style9 {
            width: 287px;
        }
        .auto-style10 {
            width: 253px;
            height: 23px;
        }
        .auto-style11 {
            width: 287px;
            height: 23px;
        }
        .auto-style14 {
            width: 276px;
            height: 29px;
        }
        .auto-style15 {
            width: 80px;
            height: 29px;
        }
        .auto-style16 {
            height: 29px;
        }
        .auto-style18 {
            height: 29px;
            width: 179px;
        }
        .auto-style21 {
            width: 53px;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel6" runat="server" Height="1425px">
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" CssClass="auto-style4" Text="บันทึกรายชื่อผู้ขอพระราชทานเครื่องราชอิสริยาภรณ์"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" CssClass="auto-style5" Text="สังกัด มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="ประเภท  "></asp:Label>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="ข้าราชการ    " />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="พนักงานในสถาบันฯ    " />
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="พนักงานราชการ    " />
                    <asp:RadioButton ID="RadioButton4" runat="server" Text="ลูกจ้างประจำ    " />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style3">
                    <asp:Label ID="Label10" runat="server" Text="________________________________________________________________________"></asp:Label>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label11" runat="server" Text="ชื่อหน่วยงานที่ขอพระราชทาน"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label12" runat="server" Text="มาช่วยราชการจากที่ใด (ถ้ามี)"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NAME_COMM" DataValueField="NAME_COMM" Width="269px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [NAME_COMM] FROM [AA_COMMAND]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label13" runat="server" Text="เครื่องราชฯ ที่ขอพระราชทาน ประจำปี"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="ID_BBE" DataValueField="ID_BBE" Width="269px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [ID_BBE] FROM [AA_BUDDHISTERA]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label14" runat="server" Text="คือชั้น"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="NAME_GRADEINSIGNIA_THA" DataValueField="NAME_GRADEINSIGNIA_THA" Width="269px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [NAME_GRADEINSIGNIA_THA], [ABBREVIATIONS_THA] FROM [TB_GRADEINSIGNIA]"></asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label15" runat="server" Text="ชั้นนี้เป็นการขอพระราชทาน"></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="RadioButton5" runat="server" Text="ไม่ซ้ำ" />
                    &nbsp;<asp:RadioButton ID="RadioButton6" runat="server" Text="ซ้ำ กับปีที่แล้วมา" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="Label16" runat="server" Text="________________________________________________________________________"></asp:Label>
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label17" runat="server" Text="ยศ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox2" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label18" runat="server" Text="คำนำหน้าชื่อ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label19" runat="server" Text="ชื่อ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox4" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label20" runat="server" Text="นามสกุล"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox5" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label21" runat="server" Text="เพศ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox6" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label22" runat="server" Text="วัน/เดือน/ปีเกิด"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox7" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label23" runat="server" Text="เลขประจำตัวประชาชน"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox8" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label24" runat="server" Text="วัน/เดือน/ปีที่เริ่มรับราชการ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox9" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label25" runat="server" Text="ตำแหน่งและระดับที่เริ่มรับราชการ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox10" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label26" runat="server" Text="ชื่อตำแหน่งปัจจุบัน"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox11" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label27" runat="server" Text="ประเภท"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox12" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label28" runat="server" Text="ระดับ"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox13" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label29" runat="server" Text="เงินเดือนปัจจุบัน"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox14" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label30" runat="server" Text="บาท"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label33" runat="server" Text="เงินประจำตำแหน่ง"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="TextBox15" runat="server" Enabled="False" Width="269px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label31" runat="server" Text="บาท"></asp:Label>
                </td>
            </tr>
        </table>
        &nbsp;<table style="width:100%;">
            <tr>
                <td class="auto-style14">เงินเดือนย้อนหลัง 5 ปี (ณ วันที่ 1 เมษายน</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox16" runat="server" Enabled="False" Width="63px"></asp:TextBox>
                    <asp:Label ID="Label34" runat="server" Text=")"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox17" runat="server" Enabled="False" Width="159px"></asp:TextBox>
                </td>
                <td class="auto-style21">
                    <asp:Label ID="Label35" runat="server" Text="บาท"></asp:Label>
                </td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
