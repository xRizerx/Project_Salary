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
            height: 20px;
            text-align: center;
        }
        .auto-style54 {
            text-align: center;
            height: 30px;
        }
        .auto-style55 {
            height: 531px;
        }
        .auto-style57 {
            height: 15px;
        }
        .auto-style60 {
            margin-bottom: 0;
        }
        .auto-style63 {
            height: 12px;
        }
        .auto-style64 {
            text-align: center;
            width: 225px;
            height: 30px;
        }
        .auto-style77 {
            height: 8px;
        }
        .auto-style81 {
            text-align: center;
            height: 20px;
        }
        .auto-style82 {
            height: 20px;
        }
        .auto-style83 {
            text-align: center;
            width: 225px;
            height: 20px;
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

        <asp:Panel ID="Panel1" runat="server" Height="623px" ScrollBars="Both" CssClass="auto-style60">
        <div>
            <table border="1" class="auto-style55">
                <caption>
                    <tr>
                        <td class="auto-style64" style="background-color: #008080; color: #FFFFFF;">วัน เดือน ปี</td>
                        <td class="auto-style64" style="background-color: #008080; color: #FFFFFF;">ตำแหน่ง</td>
                        <td class="auto-style54" style="background-color: #008080; color: #FFFFFF;">ระดับ</td>
                        <td class="auto-style64" style="background-color: #008080; color: #FFFFFF;">ได้รับ ชั้น/รายการ</td>
                        <td colspan="4" class="auto-style64" style="background-color: #008080; color: #FFFFFF;">ราชกิจจานุเบกษา </td>
                        <td colspan="2" class="auto-style64" style="background-color: #008080; color: #FFFFFF;">ใบกำกับ</td>
                        <td colspan="2" class="auto-style64" style="background-color: #008080; color: #FFFFFF;">เหรียญตราฯ</td>
                        <td class="auto-style64" style="background-color: #008080; color: #FFFFFF;">หมายเหตุ</td>
                    </tr>
                </caption>
                </tr>
                <tr align="center">
                    <td class="auto-style82" style="background-color: #008080; color: #FFFFFF;"></td>
                    <td class="auto-style82" style="background-color: #008080; color: #FFFFFF;"></td>
                    <td class="auto-style82" style="background-color: #008080; color: #FFFFFF;"></td>
                    <td class="auto-style82" style="background-color: #008080; color: #FFFFFF;"></td>
                    <td class="auto-style83" style="background-color: #008080; color: #FFFFFF;">เล่ม</td>
                    <td class="auto-style83" style="background-color: #008080; color: #FFFFFF;">ตอน</td>
                    <td class="auto-style81" style="background-color: #008080; color: #FFFFFF;">หน้า</td>
                    <td class="auto-style49" style="background-color: #008080; color: #FFFFFF;">วัน เดือน ปี</td>
                    <td class="auto-style83" style="background-color: #008080; color: #FFFFFF;">ได้รับ</td>
                    <td class="auto-style83" style="background-color: #008080; color: #FFFFFF;">ไม่ได้รับ</td>
                    <td class="auto-style81" style="background-color: #008080; color: #FFFFFF;">ได้รับ</td>
                    <td class="auto-style81" style="background-color: #008080; color: #FFFFFF;">ไม่ได้รับ</td>
                </tr>
                 <tr align="center">
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox5" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox6" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox7" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox8" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox9" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox10" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox11" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox12" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton2" runat="server" groupname="G1" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton4" runat="server" groupname="G1" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton3" runat="server" groupname="G2" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton1" runat="server" groupname="G2" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox13" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox14" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox15" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox16" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox17" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox18" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox19" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox20" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox21" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton5" runat="server" groupname="G3" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton6" runat="server" groupname="G3" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton7" runat="server" groupname="G4" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton8" runat="server" groupname="G4" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox22" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox23" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox24" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox25" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox26" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox27" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox28" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox29" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox30" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton9" runat="server" groupname="G5" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton10" runat="server" groupname="G5" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton11" runat="server" groupname="G6" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton12" runat="server" groupname="G6" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox31" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox32" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox33" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox34" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox35" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox36" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox37" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox38" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox39" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton13" runat="server" groupname="G7" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton14" runat="server" groupname="G7" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton15" runat="server" groupname="G8" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton16" runat="server" groupname="G8" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox40" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox41" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox42" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox43" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox44" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox45" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox46" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox47" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox48" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton17" runat="server" groupname="G9" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton18" runat="server" groupname="G9" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton19" runat="server" groupname="G10" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton20" runat="server" groupname="G10" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox49" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox50" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox51" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox52" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox53" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox54" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox55" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox56" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox57" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton21" runat="server" groupname="G11" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton22" runat="server" groupname="G11" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton23" runat="server" groupname="G12" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton24" runat="server" groupname="G12" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox58" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox59" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox60" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox61" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox62" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox63" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox64" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox65" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox66" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton25" runat="server" groupname="G13" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton26" runat="server" groupname="G13" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton27" runat="server" groupname="G14" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton28" runat="server" groupname="G14" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox67" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox68" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox69" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox70" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox71" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox72" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox73" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox74" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox75" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton29" runat="server" groupname="G15" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton30" runat="server" groupname="G15" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton31" runat="server" groupname="G16" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton32" runat="server" groupname="G16" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox76" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox77" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox78" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox79" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox80" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox81" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox82" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox83" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox84" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton33" runat="server" groupname="G17" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton34" runat="server" groupname="G17" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton35" runat="server" groupname="G18" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton36" runat="server" groupname="G18" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox85" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox86" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox87" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox88" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox89" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox90" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox91" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox92" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style57" style="background-color: #808080"><asp:TextBox ID="TextBox93" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton37" runat="server" groupname="G19" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton38" runat="server" groupname="G19" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton39" runat="server" groupname="G20" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"><asp:RadioButton ID="RadioButton40" runat="server" groupname="G20" Width="60px"/></td>
                    <td class="auto-style57" style="background-color: #808080"> <asp:TextBox ID="TextBox94" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                 <tr align="center">
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox95" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox96" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox97" runat="server" Width="150px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox98" runat="server" Width="150px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox99" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox100" runat="server" Width="50px"></asp:TextBox></td>
                     <td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox101" runat="server" Width="50px"></asp:TextBox></td><td class="auto-style77" style="background-color: #808080"><asp:TextBox ID="TextBox102" runat="server" Width="100px"></asp:TextBox></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton41" runat="server" groupname="G21" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton42" runat="server" groupname="G21" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton43" runat="server" groupname="G22" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"><asp:RadioButton ID="RadioButton44" runat="server" groupname="G22" Width="60px"/></td>
                    <td class="auto-style77" style="background-color: #808080"> <asp:TextBox ID="TextBox103" runat="server" Width="200px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style63" style="background-color: #808080"></td>
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
