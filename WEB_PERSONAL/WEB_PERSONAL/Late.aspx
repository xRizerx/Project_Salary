﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Late.aspx.cs" Inherits="WEB_PERSONAL.Late" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $("#ContentPlaceHolder1_TextBox11,#ContentPlaceHolder1_TextBox1").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        });
    </script>
    
    <link href="CSS/Late.css" rel="stylesheet" />

    <div class="mp">


        <div>
            <table class="t1">
                <tr>
                    <td>
                        <div class="master_dark_div_sec" id="sec1">
                            <div>
                                <asp:Label ID="Label36" runat="server" Text="เพิ่มเวลาเข้างาน" CssClass="master_dark_div_sec_title"></asp:Label>
                            </div>
                            <div class="master_dark_div_sec_pre_in" id="sec1_pre_in">
                                <div class="master_dark_div_sec_in" id="sec1_in">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style83">
                                                <asp:Label ID="Label41" runat="server" Text="วันที่"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox11" runat="server" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style83">
                                                <asp:Label ID="Label44" runat="server" Text="รหัสพนักงาน"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox21" runat="server" CssClass="master_dark_textbox" placeHolder="รหัสประชาชน"></asp:TextBox>
                                                <asp:LinkButton ID="LinkButton20" runat="server" CssClass="master_dark_button" OnClick="LinkButton20_Click">ตรวจสอบ</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style83">
                                                <asp:Label ID="Label47" runat="server" Text="ชื่อพนักงาน"></asp:Label>

                                            </td>
                                            <td class="auto-style67">
                                                <asp:Label ID="Label45" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style83">
                                                <asp:Label ID="Label39" runat="server" Text="เวลาเข้า"></asp:Label>
                                            </td>
                                            <td class="auto-style64">
                                                <asp:TextBox ID="TextBox22" runat="server" Width="50px" placeholder="ชั่วโมง" CssClass="master_dark_textbox"></asp:TextBox>
                                                <asp:TextBox ID="TextBox23" runat="server" Width="50px" placeholder="นาที" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style83">
                                                <asp:Label ID="Label40" runat="server" Text="เวลาออก"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox24" runat="server" placeholder="ชั่วโมง" Width="50px" CssClass="master_dark_textbox"></asp:TextBox>
                                                <asp:TextBox ID="TextBox25" runat="server" placeholder="นาที" Width="50px" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style81"></td>
                                            <td class="auto-style64">
                                                <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_dark_button" OnClick="LinkButton11_Click">เพิ่ม</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style83">&nbsp;</td>
                                            <td class="auto-style67">&nbsp;</td>
                                        </tr>
                                    </table>

                                </div>
                            </div>


                        </div>
                    </td>
                    <td>
                        <div class="master_dark_div_sec" id="sec2">
                            <div>
                                <asp:Label ID="Label1" runat="server" Text="แก้ไขเวลาเข้างาน" CssClass="master_dark_div_sec_title"></asp:Label>
                            </div>
                            <div class="master_dark_div_sec_pre_in" id="sec2_pre_in">
                                <div class="master_dark_div_sec_in" id="sec2_in">

                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style85">&nbsp;</td>
                                            <td class="auto-style67">
                                                <asp:Label ID="Label50" runat="server" CssClass="error_text"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label49" runat="server" Text="ค้นหารหัสเอกสาร"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox27" runat="server" CssClass="master_dark_textbox"></asp:TextBox>
                                                <asp:LinkButton ID="LinkButton21" runat="server" CssClass="master_dark_button" OnClick="LinkButton21_Click">ค้นหา</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label48" runat="server" Text="รหัสเอกสาร"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox26" runat="server" CssClass="master_dark_textbox" Enabled="False"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label2" runat="server" Text="วันที่"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label3" runat="server" Text="รหัสพนักงาน"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox2" runat="server" CssClass="master_dark_textbox" placeHolder="รหัสประชาชน"></asp:TextBox>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="master_dark_button" OnClick="LinkButton1_Click">ตรวจสอบ</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label4" runat="server" Text="ชื่อพนักงาน"></asp:Label>

                                            </td>
                                            <td class="auto-style67">
                                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label6" runat="server" Text="เวลาเข้า"></asp:Label>
                                            </td>
                                            <td class="auto-style64">
                                                <asp:TextBox ID="TextBox3" runat="server" Width="50px" placeholder="ชั่วโมง" CssClass="master_dark_textbox"></asp:TextBox>
                                                <asp:TextBox ID="TextBox4" runat="server" Width="50px" placeholder="นาที" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">
                                                <asp:Label ID="Label7" runat="server" Text="เวลาออก"></asp:Label>
                                            </td>
                                            <td class="auto-style67">
                                                <asp:TextBox ID="TextBox5" runat="server" placeholder="ชั่วโมง" Width="50px" CssClass="master_dark_textbox"></asp:TextBox>
                                                <asp:TextBox ID="TextBox6" runat="server" placeholder="นาที" Width="50px" CssClass="master_dark_textbox"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style84"></td>
                                            <td class="auto-style64">
                                                <asp:LinkButton ID="LinkButton2" runat="server" CssClass="master_dark_button" OnClick="LinkButton2_Click">แก้ไข</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style85">&nbsp;</td>
                                            <td class="auto-style67">&nbsp;</td>
                                        </tr>
                                    </table>

                                </div>
                            </div>

                        </div>
                    </td>
                </tr>
            </table>




        </div>





        <div class="master_dark_div_sec" id="sec3">
            <div>
                <asp:Label ID="Label37" runat="server" Text="รายชื่อการเข้างาน" CssClass="master_dark_div_sec_title"></asp:Label>
            </div>
            <div class="master_dark_div_sec_pre_in" id="sec3_pre_in">


                <div class="master_dark_div_sec_in" id="sec3_in">

                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" OnPageIndexChanged="GridView1_PageIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="รหัส" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="TO_CHAR(DDATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" HeaderText="วันที่" SortExpression="TO_CHAR(DDATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" />
                            <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสพนักงาน" SortExpression="CITIZEN_ID" />
                            <asp:BoundField DataField="PERSON_NAME||''||PERSON_LASTNAME" HeaderText="ชื่อพนักงาน" SortExpression="PERSON_NAME||''||PERSON_LASTNAME" />
                            <asp:BoundField DataField="HOUR_IN||':'||MINUTE_IN" HeaderText="เวลาเข้า" SortExpression="HOUR_IN||':'||MINUTE_IN" />
                            <asp:BoundField DataField="HOUR_OUT||':'||MINUTE_OUT" HeaderText="เวลาออก" SortExpression="HOUR_OUT||':'||MINUTE_OUT" />
                            <asp:CommandField ShowSelectButton="True" SelectText="เลือก" HeaderText="เลือก" ControlStyle-CssClass="master_default_gridview_select_button" />
                            <asp:CommandField ShowDeleteButton="true" DeleteText="ลบ" HeaderText="ลบ" ControlStyle-CssClass="master_default_gridview_select_button" />
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
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_WORK_CHECK_IN.ID, TO_CHAR(DDATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), TB_WORK_CHECK_IN.CITIZEN_ID, PERSON_NAME || ' ' || PERSON_LASTNAME, HOUR_IN || ':' || MINUTE_IN, HOUR_OUT || ':' || MINUTE_OUT FROM TB_WORK_CHECK_IN, TB_PERSON WHERE TB_WORK_CHECK_IN.CITIZEN_ID = TB_PERSON.CITIZEN_ID ORDER BY TB_WORK_CHECK_IN.ID DESC" DeleteCommand="DELETE TB_WORK_CHECK_IN WHERE ID = :ID">
                        <DeleteParameters>
                            <asp:Parameter Name="ID" />
                        </DeleteParameters>
                    </asp:SqlDataSource>



                </div>
            </div>
        </div>

        <div class="master_dark_div_sec">
            <div>
                <asp:Label ID="Label38" runat="server" Text="รายชื่อการมาสาย" CssClass="master_dark_div_sec_title"></asp:Label>
            </div>
            <div class="master_dark_div_sec_pre_in" id="sec4_pre_in">
                <div class="master_dark_div_sec_in">

                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="รหัส" ReadOnly="True" SortExpression="ID" />
                            <asp:BoundField DataField="TO_CHAR(DDATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" HeaderText="วันที่" SortExpression="TO_CHAR(DDATE,'DDMONYYYY','NLS_DATE_LANGUAGE=THAI')" />
                            <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสพนักงาน" SortExpression="CITIZEN_ID" />
                            <asp:BoundField DataField="PERSON_NAME||''||PERSON_LASTNAME" HeaderText="ชื่อพนักงาน" SortExpression="PERSON_NAME||''||PERSON_LASTNAME" />
                            <asp:BoundField DataField="HOUR_IN||':'||MINUTE_IN" HeaderText="เวลาเข้า" SortExpression="HOUR_IN||':'||MINUTE_IN" />
                            <asp:BoundField DataField="HOUR_OUT||':'||MINUTE_OUT" HeaderText="เวลาออก" SortExpression="HOUR_OUT||':'||MINUTE_OUT" />
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_WORK_CHECK_IN.ID, TO_CHAR(DDATE, 'DD MON YYYY', 'NLS_DATE_LANGUAGE = THAI'), TB_WORK_CHECK_IN.CITIZEN_ID, PERSON_NAME || ' ' || PERSON_LASTNAME, HOUR_IN || ':' || MINUTE_IN, HOUR_OUT || ':' || MINUTE_OUT FROM TB_WORK_CHECK_IN, TB_PERSON WHERE TB_WORK_CHECK_IN.CITIZEN_ID = TB_PERSON.CITIZEN_ID AND tb_work_check_in.hour_in*60 + tb_work_check_in.minute_in > 510 ORDER BY TB_WORK_CHECK_IN.ID DESC">
                        <DeleteParameters>
                            <asp:Parameter Name="ID" />
                        </DeleteParameters>
                    </asp:SqlDataSource>

                </div>
            </div>
        </div>

    </div>
</asp:Content>
