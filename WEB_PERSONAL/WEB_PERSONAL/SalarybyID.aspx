<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SalaryByID.aspx.cs" Inherits="WEB_PERSONAL.SalaryByID" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 130px;
        }
        .auto-style4 {
            width: 228px;
        }
        .auto-style6 {
            width: 250px;
        }
        .auto-style7 {
            width: 240px;
        }
        .auto-style8 {
            width: 507px;
        }
        .auto-style9 {
            width: 228px;
            height: 24px;
        }
        .auto-style10 {
            width: 250px;
            height: 24px;
        }
        .auto-style11 {
            width: 240px;
            height: 24px;
        }
        .auto-style12 {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel6" runat="server" Height="1024px" Width="1024px">
        <asp:Label ID="Label7" runat="server" Text="การขึ้นเงินเดือนรายบุคคล" BackColor="Red" BorderColor="Black" Font-Bold="True" Font-Size="20pt" Font-Underline="True"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="กรุณาป้อนรหัสบัตรประชาชน"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" MaxLength="13" Height="24px" Width="100px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="ค้นหา" OnClick="Button1_Click" Height="24px" Width="100px" />
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">ชื่อ - นามสกุล :</td>
                <td class="auto-style6"><asp:Label ID="Label11" runat="server" Text="-"></asp:Label>
                    &nbsp;<asp:Label ID="Label13" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label14" runat="server" Text="ชื่อตำแหน่งในสายงาน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label15" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label16" runat="server" Text="ระดับตำแหน่ง"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label18" runat="server" Text="ชื่อตำแหน่งในการบริหาร"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label19" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label55" runat="server" Text="รายละเอียดการบริหารวงเงินร้อยละ 2.9"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label20" runat="server" Text="เงินเดือนก่อนเลื่อน (ณ 1 มี.ค. 58)"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label21" runat="server" Text="เงินเดือนสูงสุดแต่ละประเภท"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label23" runat="server" Text="ฐานในการคำนวณ"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label24" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label25" runat="server" Text="ร้อยละที่ได้เลื่อน"></asp:Label>
                </td>
                <td>
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
                <td class="auto-style4">
                    <asp:Label ID="Label28" runat="server" Text="จำนวนเงินที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label29" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label30" runat="server" Text="เงินตอบแทนพิเศษ"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label31" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label32" runat="server" Text="รวมได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label33" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label34" runat="server" Text="เงินเดือนใหม่"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label35" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label36" runat="server" Text="คะแนนผลประเมิน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label37" runat="server" Text="ระดับการประเมิน"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="Label56" runat="server" Text="อธิการบดีเพิ่มให้"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label38" runat="server" Text="ร้อยละได้เลื่อน(ตามสัดส่วน)"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label39" runat="server" Text="ร้อยละที่ได้เลื่อน(อธิการบดีเพิ่มให้)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label40" runat="server" Text="จำนวนเงินที่ได้เพิ่ม"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label58" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label57" runat="server" Text="รวมได้เลื่อนทั้งสิ้น"></asp:Label>
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label41" runat="server" Text="ร้อยละที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label42" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label43" runat="server" Text="จำนวนเงินที่คำนวณได้"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label44" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label45" runat="server" Text="จำนวนเงินที่คำนวณได้(ปัดเศษ)"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label46" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label47" runat="server" Text="จำนวนเงินที่ได้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label48" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label49" runat="server" Text="เงินตอบแทนพิเศษ"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label50" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label51" runat="server" Text="รวมใช้เลื่อน"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label52" runat="server" Text="-"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label53" runat="server" Text="เงินเดือนใหม่"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label54" runat="server" Text="-"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">หมายเหตุ</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox9" runat="server" Height="100px" TextMode="MultiLine" Width="500px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" Text="คำนวณเงินเดือน" OnClick="Button2_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button3" runat="server" Text="บันทึก" OnClick="Button3_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="แก้ไขข้อมูล" />
                </td>
            </tr>
        </table>

    </asp:Panel>
</asp:Content>

