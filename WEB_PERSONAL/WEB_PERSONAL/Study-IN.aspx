<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Study-IN.aspx.cs" Inherits="WEB_PERSONAL.Study_IN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 331px;
        }
        
        .auto-style5 {
            width: 189px;
        }

        .sin_a {
            font-size: 32px;
        }

        .pan {
            text-align: center;
            padding: 20px;
        }

        .tb {
            text-align: left;
            border: 1px solid #808080;
            margin: 0 auto;
            padding: 20px;
        }

        .login_button_div ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            margin-top: 8px;
        }

        .login_button_div li {
            display: inline;
            /*555*/
        }

        .login_button_div a {
            text-decoration: none;
            display: inline;
            padding: 5px 20px;
            margin: 0 0px;
            margin-top: 5px;
            width: 60px;
            color: #c0c0c0;
            background-color: #000000;
            text-shadow: 0px 0px 0px #000000;
            border-radius: 24px;
            transition: color 0.5s ease, background-color 0.5s ease, text-shadow 0.5s ease;
        }

            .login_button_div a:hover {
                color: #ffffff;
                background-color: #cc2939;
                text-shadow: 1px 1px 16px #ffffff;
            }



        .cen {
            text-align: center;
        }

        .cen2 {
            margin: 20px auto;
            padding: 20px;
            border: 1px solid #808080;
        }
        .leave_grid_view {
            margin: 0 auto;
            text-align: center;
            border: 1px solid #808080;
            width: 90%;
        }
        .leave_sec2 {
            margin: 20px auto;
            width: 90%;
            padding: 20px;
            border: 1px solid #808080;
        }
        .bold {
            font-weight: bold;
        }
        .auto-style6 {
            width: 280px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel8" runat="server" Height="1983px" CssClass="pan">

        <div>
            <asp:Label ID="Label1" runat="server" Text="การลาศึกษาต่อภายในและภายนอกประเทศ" CssClass="sin_a"></asp:Label>
        </div>
        <br />

        <asp:Panel ID="Panel1" runat="server" CssClass="cen">
            <iframe width="800" height="500" src="https://www.youtube.com/embed/ey3m2iWzkrE" frameborder="0" allowfullscreen></iframe>
        </asp:Panel>

        <br />

        <div class="tb">
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label8" runat="server" Text="รหัสเอกสาร"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton15" runat="server" OnClick="LinkButton15_Click" CssClass="master_default_button">ดึง</asp:LinkButton>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label9" runat="server" Text="วันที่เอกสาร"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label10" runat="server" Text="รหัสพนักงาน"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label31" runat="server" Text="ประเภท"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_STUDY_TYPE]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label11" runat="server" Text="ศึกษาต่อ" CssClass="bold"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label12" runat="server" Text="ระดับ"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label13" runat="server" Text="สาขา"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label14" runat="server" Text="สถานที่"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label15" runat="server" Text="จากวันที่"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label16" runat="server" Text="ถึงวันที่"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label32" runat="server" Text="กรณีต่างประเทศ" CssClass="bold"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label33" runat="server" Text="ทุนประเภท"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label34" runat="server" Text="ประเทศ"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label17" runat="server" Text="สัญญา" CssClass="bold"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label18" runat="server" Text="ผู้รับสัญญา"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label19" runat="server" Text="ผู้ให้สัญญา"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label20" runat="server" Text="พยาน 1"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label21" runat="server" Text="พยาน 2"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label22" runat="server" Text="คู่สมรส (ถ้ามี)" CssClass="bold"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label23" runat="server" Text="ชื่อคู่สมรส"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label24" runat="server" Text="พยาน 1"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label25" runat="server" Text="พยาน 2"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label26" runat="server" Text="ผู้รับรอง" CssClass="bold"></asp:Label>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label27" runat="server" Text="นิติกร/ผู้ปฏิบัติงานกฎหมาย"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label28" runat="server" Text="ฝ่ายการเจ้าหน้าที่"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label29" runat="server" Text="ผู้อำนวยการสำนักงานอธิการบดี"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label30" runat="server" Text="รองอธิการบดีฝ่ายบริหาร"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style5">
                        <div class="login_button_div">
                            <ul>
                                <li>
                                    <asp:LinkButton ID="LinkButton16" runat="server" OnClick="LinkButton16_Click">เพิ่ม</asp:LinkButton>
                                </li>
                                <li>
                                    <asp:LinkButton ID="LinkButton17" runat="server" OnClick="LinkButton17_Click">แก้ไข</asp:LinkButton>
                                </li>
                            </ul>

                        </div>


                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>

        <asp:Panel ID="Panel3" runat="server" CssClass="leave_sec2">
            <asp:Panel ID="Panel2" runat="server" ScrollBars="Both" CssClass="leave_grid_view">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="DATE" HeaderText="DATE" SortExpression="DATE" />
                    <asp:BoundField DataField="CITIZEN_ID" HeaderText="CITIZEN_ID" SortExpression="CITIZEN_ID" />
                    <asp:BoundField DataField="LEVEL" HeaderText="LEVEL" SortExpression="LEVEL" />
                    <asp:BoundField DataField="BRANCH_NAME" HeaderText="BRANCH_NAME" SortExpression="BRANCH_NAME" />
                    <asp:BoundField DataField="LOCATION_NAME" HeaderText="LOCATION_NAME" SortExpression="LOCATION_NAME" />
                    <asp:BoundField DataField="FROM_DATE" HeaderText="FROM_DATE" SortExpression="FROM_DATE" />
                    <asp:BoundField DataField="TO_DATE" HeaderText="TO_DATE" SortExpression="TO_DATE" />
                    <asp:BoundField DataField="CONTRACT_GIVER_NAME" HeaderText="CONTRACT_GIVER_NAME" SortExpression="CONTRACT_GIVER_NAME" />
                    <asp:BoundField DataField="CONTRACT_RECEIVER_NAME" HeaderText="CONTRACT_RECEIVER_NAME" SortExpression="CONTRACT_RECEIVER_NAME" />
                    <asp:BoundField DataField="CONTRACT_WITNESS1_NAME" HeaderText="CONTRACT_WITNESS1_NAME" SortExpression="CONTRACT_WITNESS1_NAME" />
                    <asp:BoundField DataField="CONTRACT_WITNESS2_NAME" HeaderText="CONTRACT_WITNESS2_NAME" SortExpression="CONTRACT_WITNESS2_NAME" />
                    <asp:BoundField DataField="MATE_NAME" HeaderText="MATE_NAME" SortExpression="MATE_NAME" />
                    <asp:BoundField DataField="MATE_WITNESS1_NAME" HeaderText="MATE_WITNESS1_NAME" SortExpression="MATE_WITNESS1_NAME" />
                    <asp:BoundField DataField="MATE_WITNESS2_NAME" HeaderText="MATE_WITNESS2_NAME" SortExpression="MATE_WITNESS2_NAME" />
                    <asp:BoundField DataField="LAWYER_NAME" HeaderText="LAWYER_NAME" SortExpression="LAWYER_NAME" />
                    <asp:BoundField DataField="DEPARTMENT_OFFICIAL_NAME" HeaderText="DEPARTMENT_OFFICIAL_NAME" SortExpression="DEPARTMENT_OFFICIAL_NAME" />
                    <asp:BoundField DataField="DIRECTOR_NAME" HeaderText="DIRECTOR_NAME" SortExpression="DIRECTOR_NAME" />
                    <asp:BoundField DataField="DEPUTY_DIRECTOR_NAME" HeaderText="DEPUTY_DIRECTOR_NAME" SortExpression="DEPUTY_DIRECTOR_NAME" />
                    <asp:BoundField DataField="TYPE_ID" HeaderText="TYPE_ID" SortExpression="TYPE_ID" />
                    <asp:BoundField DataField="FUND_TYPE" HeaderText="FUND_TYPE" SortExpression="FUND_TYPE" />
                    <asp:BoundField DataField="COUNTRY_NAME" HeaderText="COUNTRY_NAME" SortExpression="COUNTRY_NAME" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_STUDY]"></asp:SqlDataSource>
        </asp:Panel>
        </asp:Panel>
        


    </asp:Panel>
</asp:Content>
