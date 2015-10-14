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
        .auto-style31 {
        width: 239px;
        text-align: left;
    }
        .auto-style36 {
        width: 240px;
        text-align: center;
    }
    .auto-style37 {
        width: 240px;
        text-align: center;
        height: 26px;
    }
    .auto-style38 {
        width: 239px;
        text-align: left;
        height: 26px;
    }
        .auto-style39 {
            width: 330px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="1024px" Width="1024px">
        Salary System<br />
        <br />
        รายละเอียดการเลื่อนเงินเดือนข้าราชการพลเรือนในสถาบันอุคมศึกษา ครั้งที่ 1 วันที่ 1 เมษายน 2558 มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก<br />
        <table style="width:100%;" border="0">
            <tr>
                <td class="auto-style37">ลำดับที่ </td>
                <td class="auto-style38">
                    <asp:TextBox ID="TextBox27" runat="server" Width="30px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">หน่วยงาน </td>
                <td class="auto-style31">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BRANCH_NAME" DataValueField="BRANCH_NAME">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [BRANCH_NAME] FROM [TB_BRANCH]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">จำนวนคน ณ 1 มี.ค. 58&nbsp;&nbsp;</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox31" runat="server" Width="75px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">อัตราเงินเดือนรวม ณ 1 มี.ค. 58</td>
                <td class="auto-style38">
                    <asp:TextBox ID="TextBox32" runat="server" Width="100px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">วงเงิน 2.9 % ของเงินเดือนรวม</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox26" runat="server" Width="105px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">เงินที่ใช้เลื่อน ณ 1 เม.ย. 58</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox25" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">วงเงินที่เหลือ&nbsp;</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox24" runat="server" Width="89px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">วงเงิน 0.1 % ของเงินเดือนรวม ณ 1 มี.ค. 58</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox23" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">จำนวนเงินที่อธิการบดีเพิ่มให้&nbsp;</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox22" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">วงเงินที่ใช้เลื่อนทั้งสิ้น (3%)&nbsp;</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox19" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">เงินที่ใช้เลื่อน ณ 1 เม.ย. 58&nbsp;ทั้งสิ้น</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox20" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style36">วงเงินคงเหลือทั้งสิ้น</td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox33" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style12">Comment</td>
                <td class="auto-style3">
                    <br />
                    <br />
                    &nbsp;<asp:TextBox ID="TextBox18" runat="server" Height="50px" Width="689px" Font-Size="16pt" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <table style="width:100%;">
            <tr>
                <td class="master_footer">
                    <asp:Button ID="Button1" runat="server" Text="บันทึก" Width="140px" />
                </td>
                <td class="master_footer">
                    <asp:Button ID="Button2" runat="server" Text="ยกเลิก" Width="140px" />
                </td>
                <td class="master_footer">
                    <asp:Button ID="Button3" runat="server" Text="ออกรายงาน" Width="140px" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>
