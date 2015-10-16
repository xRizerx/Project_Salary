<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SalaryByID.aspx.cs" Inherits="WEB_PERSONAL.SalaryByID" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>ระบบเพิ่มเงินเดือนรายบุคคล</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }

        .auto-style3 {
            width: 130px;
        }

        .auto-style4 {
            width: 228px;
        }

        .auto-style6 {
            width: 250px;
            text-align: left;
        }

        .auto-style7 {
            width: 240px;
            text-align: left;
        }

        .auto-style9 {
            width: 228px;
            height: 24px;
            text-align: left;
        }

        .auto-style10 {
            width: 250px;
            height: 24px;
            text-align: left;
        }

        .auto-style11 {
            width: 240px;
            height: 24px;
            text-align: left;
        }

        .auto-style12 {
            height: 24px;
            text-align: left;
        }

        .button_ui {
            background: #939393;
            padding: 5px 10px;
            border-radius: 10px;
            text-decoration: none;
            color: white;
            border-color: black;
            border: 1px solid black;
        }
        .panin{
            background-color:rgba(255,255,255,0.8);
            border-radius: 5px;
            border: 2px solid white;
        }
        .panout {
            padding: 20px;
            text-align: center;
            background-image: url("Image/bgbyid.jpg");
            background-size:100%;
        }
        .auto-style14 {
            text-align: left;
        }
        .auto-style15 {
            width: 507px;
            text-align: center;
        }
        .auto-style18 {
            width: 490px;
            text-align: center;
        }
        .auto-style19 {
            width: 227px;
        }
        .auto-style20 {
            width: 228px;
            text-align: left;
        }
        .auto-style21 {
            width: 227px;
            text-align: left;
        }
        .header-text{
            padding: 10px;
            background-color:rgb(0, 113, 23);
            border-radius: 4px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel6" runat="server" Height="1024px" CssClass="panout">
        <asp:Label ID="Label7" runat="server" Text="การขึ้นเงินเดือนรายบุคคล" Font-Bold="True" Font-Size="20pt" CssClass="header-text"></asp:Label><br /><br /><br />
        <audio controls autoplay loop>
            <source src="Entities/bnn.mp3" type="audio/mpeg">
            Your browser does not support the audio element.
        </audio>
        <asp:Panel ID="Panel1" runat="server" CssClass="panin">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style19">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:Label ID="Label8" runat="server" Text="กรุณาป้อนรหัสบัตรประชาชน"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Height="24px" MaxLength="13" Width="100px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="ค้นหา" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="3">
                    <hr />
                </td>
            </tr>
        </table>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style20">ชื่อ - นามสกุล :</td>
                <td class="auto-style6">
                    <asp:Label ID="Label11" runat="server" Text="-"></asp:Label>
                    &nbsp;<asp:Label ID="Label13" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label14" runat="server" Text="ชื่อตำแหน่งในสายงาน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label15" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label16" runat="server" Text="ระดับตำแหน่ง"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label17" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label18" runat="server" Text="ชื่อตำแหน่งในการบริหาร"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label19" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14">
                    <asp:Label ID="Label55" runat="server" Text="รายละเอียดการบริหารวงเงินร้อยละ 2.9"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label20" runat="server" Text="เงินเดือนก่อนเลื่อน (ณ 1 มี.ค. 58)"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label21" runat="server" Text="เงินเดือนสูงสุดแต่ละประเภท"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label22" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label23" runat="server" Text="ฐานในการคำนวณ"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label24" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label25" runat="server" Text="ร้อยละที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">จำนวนเงินที่คำนวณได้</td>
                <td class="auto-style10">
                    <asp:Label ID="Label26" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style11">จำนวนเงินที่คำนวณได้(ปัดเศษ)</td>
                <td class="auto-style12">
                    <asp:Label ID="Label27" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label28" runat="server" Text="จำนวนเงินที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label29" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label30" runat="server" Text="เงินตอบแทนพิเศษ"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label31" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label32" runat="server" Text="รวมได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label33" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label34" runat="server" Text="เงินเดือนใหม่"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label35" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label36" runat="server" Text="คะแนนผลประเมิน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label37" runat="server" Text="ระดับการประเมิน"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14">
                    <asp:Label ID="Label56" runat="server" Text="อธิการบดีเพิ่มให้"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label38" runat="server" Text="ร้อยละได้เลื่อน (ตามสัดส่วน)"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label39" runat="server" Text="ร้อยละที่ได้เลื่อน (อธิการบดีเพิ่มให้)"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label40" runat="server" Text="จำนวนเงินที่ได้เพิ่ม"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label58" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label57" runat="server" Text="รวมได้เลื่อนทั้งสิ้น"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label41" runat="server" Text="ร้อยละที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label42" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label43" runat="server" Text="จำนวนเงินที่คำนวณได้"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label44" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label45" runat="server" Text="จำนวนเงินที่คำนวณได้(ปัดเศษ)"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label46" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label47" runat="server" Text="จำนวนเงินที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label48" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label49" runat="server" Text="เงินตอบแทนพิเศษ"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label50" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="Label51" runat="server" Text="รวมใช้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label52" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label53" runat="server" Text="เงินเดือนใหม่"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:Label ID="Label54" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">หมายเหตุ</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox9" runat="server" Height="50px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button_ui" OnClick="LinkButton1_Click">คำนวณเงินเดือน</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td colspan="2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </asp:Panel><br />
        <table style="width: 100%;" class="panin">
                <tr>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button_ui" OnClick="LinkButton2_Click">บันทึก</asp:LinkButton>
                    </td>
                    <td class="auto-style15">
                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="button_ui">แก้ไขข้อมูล</asp:LinkButton>
                    </td>
                    <tr>
                        <td class="auto-style18">&nbsp;</td>
                        <td class="auto-style15">&nbsp;</td>
                    </tr>
                </tr>
        </table>

    </asp:Panel>
</asp:Content>

