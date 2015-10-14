<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Salary.aspx.cs" Inherits="WEB_PERSONAL.Salary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            text-align: left;
        }
        .auto-style12 {
            text-align: left;
            width: 80px;
        }
        .auto-style16 {
            width: 140px;
            text-align: center;
        }
        .auto-style17 {
            width: 97px;
            text-align: center;
        }
        .auto-style18 {
            width: 118px;
            text-align: center;
        }
        .auto-style20 {
            width: 90px;
            text-align: center;
        }
        .auto-style21 {
            width: 100px;
            text-align: center;
        }
        .auto-style22 {
            width: 135px;
            text-align: center;
        }
        .auto-style24 {
            width: 136px;
            text-align: center;
        }
        .auto-style28 {
            text-align: center;
            width: 40px;
        }
        .auto-style30 {
            text-align: center;
        }
        .auto-style31 {
            width: 239px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="1000px" Width="2000px">
        Salary System<br />
        <br />
        รายละเอียดการเลื่อนเงินเดือนข้าราชการพลเรือนในสถาบันอุคมศึกษา ครั้งที่ 1 วันที่ 1 เมษายน 2558 มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก<br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style28">ลำดับที่ </td>
                <td class="auto-style31">หน่วยงาน </td>
                <td class="auto-style17">จำนวนคน<br /> ณ 1 มี.ค. 58<br /> &nbsp;</td>
                <td class="auto-style16">อัตรา<br /> เงินเดือนรวม<br /> ณ 1 มี.ค. 58</td>
                <td class="auto-style18">วงเงิน 2.9 %<br /> ของเงินเดือนรวม<br /> &nbsp;</td>
                <td class="auto-style20">เงินที่ใช้เลื่อน<br /> ณ 1 เม.ย. 58<br /> &nbsp;</td>
                <td class="auto-style21">วงเงินที่เหลือ<br /> &nbsp;</td>
                <td class="auto-style22">วงเงิน 0.1 %<br /> ของเงินเดือนรวม<br /> ณ 1 มี.ค. 58<br /> &nbsp;</td>
                <td class="auto-style24">จำนวนเงิน<br /> ที่อธิการบดีเพิ่มให้<br /> &nbsp;</td>
                <td class="auto-style20">วงเงินที่<br /> ใช้เลื่อน<br /> ทั้งสิ้น (3%)<br /> &nbsp;</td>
                <td class="auto-style21">เงินที่ใช้เลื่อน
                    <br />
                    ณ 1 เม.ย. 58&nbsp;<br />ทั้งสิ้น<br />&nbsp;&nbsp;</td>
                <td class="auto-style20">วงเงิน<br /> คงเหลือทั้งสิ้น<br /> &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:TextBox ID="TextBox27" runat="server" Width="30px"></asp:TextBox>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox28" runat="server" Width="301px"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox29" runat="server" Width="40px"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="TextBox30" runat="server" Width="100px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="TextBox26" runat="server" Width="105px"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox25" runat="server" Width="90px"></asp:TextBox>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="TextBox24" runat="server" Width="89px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    <asp:TextBox ID="TextBox23" runat="server" Width="90px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:TextBox ID="TextBox22" runat="server" Width="90px"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox19" runat="server" Width="90px"></asp:TextBox>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="TextBox20" runat="server" Width="90px"></asp:TextBox>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBox21" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style12">Comment</td>
                <td class="auto-style3">
                    <br />
                    <br />
                    &nbsp;<asp:TextBox ID="TextBox18" runat="server" Height="85px" Width="689px"></asp:TextBox>
                </td>
            </tr>
        </table>
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
