<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Promote_Form.aspx.cs" Inherits="WEB_PERSONAL.Promote_Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .head_div{
            text-align:center;
            padding:10px;
            background-color:rgba(0, 148, 255,0.4);
            border-radius:5px;
        }
        .Main_pan{
            background-color:rgba(0, 148, 255,0.2);
            padding:10px;
            border-color:crimson;
            border:solid;
            border-radius:5px;
        }
        .auto-style1 {
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel_main" runat="server" CssClass="Main_pan">
    <div class="head_div">
    <asp:Label ID="Label1" runat="server" Text="แบบข้อตกลงการประเมินผลสัมฤทธิ์ของงานของข้าราชการพลเรือนในสถาบันอุดมศึกษา หรือพนักงานในสถาบันอุดมศึกษา มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก ตำแหน่งวิชาการ (องค์ประกอบที่ 1 ผลสัมฤทธิ์ของงาน 70%)"></asp:Label>
        <br /><asp:Label ID="Label2" runat="server" Text="รอบการประเมิน"></asp:Label>
        <br /><asp:CheckBox ID="CheckBox1" runat="server" Enabled="False" /><asp:Label ID="Label3" runat="server" Text=" รอบที่ 1 (1 ส.ค. 2558 ถึง 31 ม.ค. 2559 )"></asp:Label>
        <br /><asp:CheckBox ID="CheckBox2" runat="server" Enabled="False" /><asp:Label ID="Label4" runat="server" Text=" รอบที่ 2 (1 ก.พ. 2559 ถึง 31 ก.ค. 2559 )"></asp:Label>
        </div>
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="ชื่อผู้รับการประเมิน"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="ตำแหน่ง"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="สังกัด"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
       <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="ชื่อผู้ประเมิน"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="ตำแหน่ง"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="สังกัด"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:Panel ID="Panel_kor1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td><asp:Label ID="Label11" runat="server" Text="1. การเรียนการสอน"></asp:Label></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="1.1 มีจำนวนชั่วโมงสอนไม่น้อยกว่าภาระงานขั้นต่ำ"></asp:Label></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="1.2 มีประมวลรายวิชา/แผนการสอน โดยมีการ
ดำเนินการดังนี้"></asp:Label></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label14" runat="server" Text="1 มีประมวลรายวิชา/แผนการสอน"></asp:Label>
                </td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="2 มีประมวลรายวิชา/แผนการสอนก่อนการเปิดภาค"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="3 มีประมวลรายวิชา/แผนการสอนที่มีเนื้อหาและรูปแบบตรงตามที่กำหนดในกรอบ TQF/เกณฑ์มาตรฐานหลักสูตรระดับปริญญาตรี ปี 2548"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="4 มีประมวลรายวิชา/แผนการสอนที่ส่งเสริมทักษะการเรียนรู้ด้วยตนเองและให้ผู้เรียนได้เรียนรู้จากการปฏิบัติทั้งในและนอกห้องเรียนหรือจากการทำวิจัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
        </asp:Panel>
</asp:Content>
