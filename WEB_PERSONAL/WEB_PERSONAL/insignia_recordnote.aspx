<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote.aspx.cs" Inherits="WEB_PERSONAL.insignis_recordnote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 876px;
            height: 182px;
        }
        .auto-style6 {
            width: 225px;
        }
        .auto-style9 {
            text-align: center;
            width: 225px;
        }
        .auto-style11 {
        height: 23px;
    }
    .auto-style12 {
        width: 100%;
        margin-top: 0;
            height: 26px;
        }
        .auto-style14 {
            height: 23px;
            text-align: right;
            width: 70px;
        }
        .auto-style15 {
            height: 23px;
            width: 134px;
        }
        .auto-style17 {
            height: 23px;
            width: 25px;
        }
        .auto-style18 {
            height: 23px;
            text-align: right;
            width: 25px;
        }
        .auto-style20 {
            height: 23px;
            width: 215px;
        }
        .auto-style24 {
            width: 54px;
            height: 226px;
        }
        .auto-style25 {
            height: 226px;
        }
        .auto-style40 {
            width: 320px;
        }
        .auto-style41 {
            width: 54px;
        }
        .auto-style42 {
            height: 23px;
            width: 70px;
        }
        .auto-style43 {
            margin-left: 0;
        }
        .auto-style44 {
            height: 23px;
            width: 94px;
        }
        .auto-style45 {
            width: 320px;
            height: 23px;
        }
        .auto-style46 {
            text-align: center;
            width: 225px;
            height: 23px;
        }
        .auto-style49 {
            width: 876px;
            height: 2px;
            text-align: center;
        }
        .auto-style50 {
            height: 2px;
        }
        .auto-style51 {
            text-align: center;
            width: 225px;
            height: 2px;
        }
        .auto-style52 {
            height: 2px;
            text-align: center;
        }
        .auto-style54 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel8" runat="server" Height="1501px">
        <table style="width:100%;">
            <tr>
                <td class="auto-style41">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style41">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style24"></td>
                <td class="auto-style25"><fieldset class="auto-style4">
                        <legend><b>บันทึกประวัติการรับเครื่องราชอิสริยาภรณ์</b></legend>

                        <table class="ui-accordion">
                            <tr>
                                <td class="auto-style40">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style45"></td>
                                <td class="auto-style46">
                                    <asp:Label ID="Label8" runat="server" Text="กรอกเลขประจำตัวประชาชน"></asp:Label>
                                </td>
                                <td class="auto-style11"></td>
                            </tr>
                            <tr>
                                <td class="auto-style40">&nbsp;</td>
                                <td class="auto-style9">
                                    <asp:TextBox ID="TextBox1" style="text-align:center" runat="server"
                                         MaxLength="13" Width="200px" ToolTip="กรุณากรอกรหัสบัตรประจำตัวประชาชน ก่อนตรวจสอบข้อมูล / แก้ไข"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="ค้นหา" OnClick="Button1_Click1" />
                                </td>
                            </tr>
                        </table>

                        <br />
                        <table class="auto-style12">
                            <tr>
                                <td class="auto-style14">
                                    <asp:Label ID="Label9" runat="server" Text="ชื่อ"></asp:Label>
                                </td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="TextBox2" style="text-align:center" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                                </td>
                                <td class="auto-style18">
                                    <asp:Label ID="Label10" runat="server" Text="สกุล"></asp:Label>
                                </td>
                                <td class="auto-style20">
                                    <asp:TextBox ID="TextBox3" style="text-align:center" runat="server" Enabled="False" Width="200px"></asp:TextBox>
                                </td>
                                <td class="auto-style44">
                                    <asp:Label ID="Label11" runat="server" Text="วันที่เริ่มบรรจุ"></asp:Label>
                                </td>
                                <td class="auto-style11">
                                    <asp:TextBox ID="TextBox4" style="text-align:center" runat="server" CssClass="auto-style43" Enabled="False" Width="200px"></asp:TextBox>
                                </td>
                                <td class="auto-style11"></td>
                                <td class="auto-style11"></td>
                                <td class="auto-style11"></td>
                            </tr>
                            <tr>
                                <td class="auto-style42"></td>
                                <td class="auto-style15"></td>
                                <td class="auto-style17"></td>
                                <td class="auto-style20"></td>
                                <td class="auto-style44"></td>
                                <td class="auto-style11"></td>
                                <td class="auto-style11"></td>
                                <td class="auto-style11"></td>
                                <td class="auto-style11"></td>
                            </tr>
                        </table>

                    </fieldset></td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style41">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />

        <asp:Panel ID="Panel1" runat="server" Height="187px" ScrollBars="Both">
        <div>
            <table border="1">
                <caption>
                    <tr>
                        <td class="auto-style9">วัน เดือน ปี</td>
                        <td class="auto-style9">ตำแหน่ง</td>
                        <td class="auto-style54">ระดับ</td>
                        <td class="auto-style9">ได้รับ ชั้น/รายการ</td>
                        <td colspan="4" class="auto-style9">ราชกิจจานุเบกษา </td>
                        <td colspan="2" class="auto-style9">ใบกำกับ</td>
                        <td colspan="2" class="auto-style9">เหรียญตราฯ</td>
                        <td class="auto-style9">หมายเหตุ</td>
                    </tr>
                </caption>
                </tr>
                <tr align="center">
                    <td class="auto-style50"></td>
                    <td class="auto-style50"></td>
                    <td class="auto-style50"></td>
                    <td class="auto-style50"></td>
                    <td class="auto-style51">เล่ม</td>
                    <td class="auto-style51">ตอน</td>
                    <td class="auto-style52">หน้า</td>
                    <td class="auto-style49">วัน เดือน ปี</td>
                    <td class="auto-style51">ได้รับ</td>
                    <td class="auto-style51">ไม่ได้รับ</td>
                    <td class="auto-style52">ได้รับ</td>
                    <td class="auto-style52">ไม่ได้รับ</td>
                </tr>
                 <tr align="center">
                    <td class="auto-style5"> <asp:TextBox ID="TextBox5" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style3"><asp:TextBox ID="TextBox6" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style3"><asp:TextBox ID="TextBox7" runat="server" Width="150px"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox8" runat="server" Width="150px"></asp:TextBox></td>
                     <td><asp:TextBox ID="TextBox9" runat="server" Width="50px"></asp:TextBox></td>
                     <td><asp:TextBox ID="TextBox10" runat="server" Width="50px"></asp:TextBox></td>
                     <td><asp:TextBox ID="TextBox11" runat="server" Width="50px"></asp:TextBox></td><td><asp:TextBox ID="TextBox12" runat="server" Width="100px"></asp:TextBox></td>
                    <td><asp:RadioButton ID="RadioButton2" runat="server" groupname="G1" Width="60px"/></td>
                    <td><asp:RadioButton ID="RadioButton4" runat="server" groupname="G1" Width="60px"/></td>
                    <td><asp:RadioButton ID="RadioButton3" runat="server" groupname="G2" Width="60px"/></td>
                    <td><asp:RadioButton ID="RadioButton1" runat="server" groupname="G2" Width="60px"/></td>
                    <td class="auto-style5"> <asp:TextBox ID="TextBox13" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                </tr>
            </table>
        </div>
    </asp:Panel>

        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="UPDATE" Width="141px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

    </asp:Panel>
</asp:Content>
