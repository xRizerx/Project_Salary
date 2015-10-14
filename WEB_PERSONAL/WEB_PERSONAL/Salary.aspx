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
        .auto-style37 {
        width: 100px;
        text-align: left;
        height: 26px;
    }
    .auto-style38 {
        width: 239px;
        text-align: left;
        height: 26px;
    }
        .auto-style39 {
            width: 100px;
            text-align: left;
        }
        .auto-style40 {
            margin-top: 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        body {
            background-image: url("333.png");
        }
        
    </style>
    <asp:Panel ID="Panel1" runat="server" Height="1024px" Width="1024px">
        Salary System<br />
        <br />
        รายละเอียดการเลื่อนเงินเดือนข้าราชการพลเรือนในสถาบันอุคมศึกษา ครั้งที่ 1 วันที่ 1 เมษายน 2558 มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก<br />
        <table style="width:100%;" border="0">

            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label4" runat="server" Text="หน่วยงาน"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BRANCH_NAME" DataValueField="BRANCH_NAME">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT [BRANCH_NAME] FROM [TB_BRANCH]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label5" runat="server" Text="จำนวนคน ณ 1 มี.ค. 58"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox31" runat="server" Width="75px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style37">
                    <asp:Label ID="Label6" runat="server" Text="อัตราเงินเดือนรวม ณ 1 มี.ค. 58"></asp:Label>
                </td>
                <td class="auto-style38">
                    <asp:TextBox ID="TextBox32" runat="server" Width="100px" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label7" runat="server" Text="วงเงิน 2.9 % ของเงินเดือนรวม"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label8" runat="server" Text="เงินที่ใช้เลื่อน ณ 1 เม.ย. 58"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox25" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label9" runat="server" Text="วงเงินที่เหลือ"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label10" runat="server" Text="วงเงิน 0.1 % ของเงินเดือนรวม ณ 1 มี.ค. 58"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label11" runat="server" Text="จำนวนเงินที่อธิการบดีเพิ่มให้"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox22" runat="server" Width="90px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label12" runat="server" Text="วงเงินที่ใช้เลื่อนทั้งสิ้น (3%)"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label13" runat="server" Text="เงินที่ใช้เลื่อน ณ 1 เม.ย. 58&nbsp;ทั้งสิ้น"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Label ID="Label14" runat="server" Text="วงเงินคงเหลือทั้งสิ้น"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style12">Comment</td>
                <td class="auto-style3">
                    &nbsp;<asp:TextBox ID="TextBox18" runat="server" Height="50px" Width="689px" Font-Size="16pt" TextMode="MultiLine" CssClass="auto-style40"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="คำนวณเงิน" />
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
