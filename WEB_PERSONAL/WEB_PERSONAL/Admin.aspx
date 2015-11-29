<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WEB_PERSONAL.Admin" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            vertical-align: top;
            text-align: right;
        }

        .auto-style2 {
            width: 522px;
        }

        .auto-style5 {
            width: 300px;
        }

        .auto-style6 {
            width: 118px;
            vertical-align: top;
            text-align: right;
        }

        .auto-style8 {
            width: 120px;
            vertical-align: top;
            text-align: right;
        }
        .auto-style9 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Admin.css" rel="stylesheet" />

    <div class="main">
        <div class="master_dark_div_sec">
            <div class="master_dark_div_sec_title">
                ข้อเสนอแนะ
            </div>
            <div class="master_dark_div_sec_pre_in">
                <div class="master_dark_div_sec_in">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" DataSourceID="SqlDataSource2">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="รหัส" SortExpression="ID" />
                            <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสพนักงาน" SortExpression="CITIZEN_ID" />
                            <asp:BoundField DataField="TB_PERSON.PERSON_NAME||''||TB_PERSON.PERSON_LASTNAME" HeaderText="ชื่อ" SortExpression="TB_PERSON.PERSON_NAME||''||TB_PERSON.PERSON_LASTNAME" />
                            <asp:BoundField DataField="TO_CHAR(TB_COMMENT.COMMENT_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" HeaderText="วันที่" SortExpression="TO_CHAR(TB_COMMENT.COMMENT_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')">
                                <HeaderStyle Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="COMMENT_STRING" HeaderText="คอมเมนต์" SortExpression="COMMENT_STRING" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_COMMENT.ID, TB_COMMENT.CITIZEN_ID, TB_PERSON.PERSON_NAME || ' ' || TB_PERSON.PERSON_LASTNAME, to_char(TB_COMMENT.COMMENT_DATE, 'dd mon yyyy', 'NLS_DATE_LANGUAGE = THAI'), TB_COMMENT.COMMENT_STRING from TB_COMMENT, TB_PERSON WHERE TB_COMMENT.CITIZEN_ID = TB_PERSON.CITIZEN_ID"></asp:SqlDataSource>

                    <div style="height: 20px;"></div>

                    <table class="auto-style9">
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label16" runat="server" Text="ลบข้อมูลตามรหัส"></asp:Label>
                            </td>
                            <td class="auto-style5">
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="master_dark_textbox" placeHolder="รหัส"></asp:TextBox>
                                <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_dark_button" OnClick="LinkButton13_Click">ลบ</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                </div>
            </div>

        </div>

        <div class="master_dark_div_sec">
            <div class="master_dark_div_sec_title">
                ประกาศ
            </div>
            <div class="master_dark_div_sec_pre_in">
                <div class="master_dark_div_sec_in">
                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style6">
                                <asp:Label ID="Label17" runat="server" Text="รายละเอียด"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="master_dark_textbox" Height="200px" Width="500px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">&nbsp;</td>
                            <td>
                                <asp:LinkButton ID="LinkButton14" runat="server" CssClass="master_dark_button" OnClick="LinkButton14_Click">เพิ่ม</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                    <div style="height: 20px;"></div>

                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label18" runat="server" Text="ลบข้อมูลตามรหัส"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="master_dark_textbox" placeHolder="รหัส"></asp:TextBox>
                                <asp:LinkButton ID="LinkButton15" runat="server" CssClass="master_dark_button" OnClick="LinkButton15_Click">ลบ</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                    <div style="height: 20px;"></div>

                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ANNOUNCE_ID" DataSourceID="SqlDataSource3" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ANNOUNCE_ID" HeaderText="รหัส" ReadOnly="True" SortExpression="ANNOUNCE_ID" />
                            <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสพนักงาน" SortExpression="CITIZEN_ID" />
                            <asp:BoundField DataField="PERSON_NAME||''||PERSON_LASTNAME" HeaderText="ชื่อ" SortExpression="PERSON_NAME||''||PERSON_LASTNAME" />
                            <asp:BoundField DataField="TO_CHAR(ANNOUNCE_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" HeaderText="วันที่" SortExpression="TO_CHAR(ANNOUNCE_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')">
                            <HeaderStyle Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="ANNOUNCE_STRING" HeaderText="คำประกาศ" SortExpression="ANNOUNCE_STRING" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>

                    

                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT ANNOUNCE_ID, TB_ANNOUNCE.CITIZEN_ID, PERSON_NAME || ' ' || PERSON_LASTNAME, TO_CHAR(ANNOUNCE_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), ANNOUNCE_STRING FROM TB_ANNOUNCE, TB_PERSON WHERE TB_ANNOUNCE.CITIZEN_ID = TB_PERSON.CITIZEN_ID ORDER BY ANNOUNCE_ID DESC"></asp:SqlDataSource>

                    

                </div>
            </div>

        </div>

        <div class="master_dark_div_sec">
            <div class="master_dark_div_sec_title">
                การแก้ไขข้อมูล
            </div>
            <div class="master_dark_div_sec_pre_in">
                <div class="master_dark_div_sec_in">

                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style1">
                                <asp:Label ID="Label14" runat="server" Text="รายละเอียด"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="master_dark_textbox" Height="200px" Width="500px" TextMode="MultiLine"></asp:TextBox>
                                <asp:Label ID="Label19" runat="server" Text="* เพิ่มข้อโดยการเว้นบรรทัด" style="color:#808080"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp;</td>
                            <td class="auto-style2">
                                <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_dark_button" OnClick="LinkButton11_Click">เพิ่ม</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                    <div style="height: 20px;"></div>

                    <table style="width: 100%;">
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label15" runat="server" Text="ลบข้อมูลตามรหัส"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="master_dark_textbox" placeHolder="รหัส"></asp:TextBox>
                                <asp:LinkButton ID="LinkButton12" runat="server" CssClass="master_dark_button" OnClick="LinkButton12_Click">ลบ</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                    <div style="height: 20px;"></div>

                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="รหัส" SortExpression="ID" />
                            <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสพนักงาน" SortExpression="CITIZEN_ID">
                            </asp:BoundField>
                            <asp:BoundField DataField="PERSON_NAME||''||PERSON_LASTNAME" HeaderText="ชื่อ" SortExpression="PERSON_NAME||''||PERSON_LASTNAME" />
                            <asp:BoundField DataField="TO_CHAR(UPDATE_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" HeaderText="วันที่" SortExpression="TO_CHAR(UPDATE_DATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')">
                            <HeaderStyle Width="100px" />
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>

                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_WEB_UPDATE_HISTORY.ID, TB_WEB_UPDATE_HISTORY.CITIZEN_ID, PERSON_NAME || ' ' || PERSON_LASTNAME, TO_CHAR(UPDATE_DATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI') FROM TB_WEB_UPDATE_HISTORY, TB_PERSON WHERE TB_WEB_UPDATE_HISTORY.CITIZEN_ID = TB_PERSON.CITIZEN_ID ORDER BY TB_WEB_UPDATE_HISTORY.ID DESC"></asp:SqlDataSource>

                </div>
            </div>

        </div>

    </div>
</asp:Content>
