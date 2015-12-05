<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Person-Detail.aspx.cs" Inherits="WEB_PERSONAL.Person_Detail" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSS/Person-Detail.css" rel="stylesheet" />
    <div class="mp">

        <div class="master_light_page_header">
            รายชื่อบุคลากร
        </div>

        <div class="sec1">

            <table>
                <tr>
                    <td>
                        <div class="sec1_1">
                            <img id="profile_pic" runat="server" src="Image/no_image.png" style="object-fit: contain;" />

                        </div>
                    </td>
                    <td>
                        <div class="sec1_2">

                            <div class="master_light_div_sec">
                                <div class="master_light_div_sec_title">
                                    ข้อมูลส่วนตัว
                                </div>
                                <div class="master_light_div_sec_in">
                                    <table class="auto-style3">
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label12" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label14" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label31" runat="server" Text="คำนำหน้า"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label32" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label88" runat="server" Text="ยศ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label90" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label13" runat="server" Text="ชื่อ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label15" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label16" runat="server" Text="นามสกุล"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label17" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label45" runat="server" Text="เพศ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label46" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label25" runat="server" Text="วันเกิด"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label26" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label47" runat="server" Text="สัญชาติ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label48" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label63" runat="server" Text="เบอร์โทรศัพท์"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label64" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="master_light_div_sec">
                                <div class="master_light_div_sec_title">
                                    ครอบครัว
                                </div>
                                <div class="master_light_div_sec_in">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label35" runat="server" Text="ชื่อบิดา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label38" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label36" runat="server" Text="ชื่อมารดา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label39" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label37" runat="server" Text="ชื่อคู่ครอง"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label40" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />


                            <div class="master_light_div_sec">
                                <div class="master_light_div_sec_title">
                                    ที่อยู่
                                </div>
                                <div class="master_light_div_sec_in">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label49" runat="server" Text="บ้านเลขที่"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label52" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label50" runat="server" Text="หมู่"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label53" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label51" runat="server" Text="ถนน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label54" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label55" runat="server" Text="ตำบล"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label59" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label56" runat="server" Text="อำเภอ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label60" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label57" runat="server" Text="จังหวัด"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label61" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style2">
                                                <asp:Label ID="Label58" runat="server" Text="รหัสไปรษณีย์"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label62" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>





                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="master_light_div_sec">
                                <div class="master_light_div_sec_title">
                                    การงาน
                                </div>
                                <div class="master_light_div_sec_in">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label21" runat="server" Text="สถานะ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label22" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label29" runat="server" Text="ประเภท"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label30" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label23" runat="server" Text="ตำแหน่ง"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label24" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label91" runat="server" Text="คณะ"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label93" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label87" runat="server" Text="Branch"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label89" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label41" runat="server" Text="กระทรวง"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label42" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label43" runat="server" Text="แผนก"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label44" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label65" runat="server" Text="สัญญาจ้าง"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label67" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label66" runat="server" Text="ทุน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label68" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label69" runat="server" Text="Sub Staff Type"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label70" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label71" runat="server" Text="Special name"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label73" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label72" runat="server" Text="กลุ่มวิชาที่สอน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label74" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label92" runat="server" Text="ตำแหน่งทางการงานที่เริ่มเข้าทำงาน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label94" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label27" runat="server" Text="เริ่มเข้าทำงาน"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label28" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label33" runat="server" Text="วันที่เลิก"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label34" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="master_light_div_sec">
                                <div class="master_light_div_sec_title">
                                    การศึกษา
                                </div>
                                <div class="master_light_div_sec_in">
                                    <table style="width: 100%;">
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label75" runat="server" Text="ระดับที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label76" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label79" runat="server" Text="กลุ่มวิชาที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label80" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label81" runat="server" Text="สาขาวิชาที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label82" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label83" runat="server" Text="มหาวิทยาลัยที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label84" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label85" runat="server" Text="ประเทศที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label86" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style6">
                                                <asp:Label ID="Label77" runat="server" Text="หลักสูตรที่จบการศึกษา"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label78" runat="server" Text="-"></asp:Label>
                                            </td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                           
                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label7" runat="server" Text="ประวัติการศึกษา" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="study_history_div" runat="server">
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label1" runat="server" Text="ใบอนุญาตประกอบวิชาชีพ" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="job_license_div" runat="server">
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label4" runat="server" Text="ประวัติการฝึกอบรม" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="training_history_div" runat="server">
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label5" runat="server" Text="การได้รับโทษทางวินัยและการนิรโทษกรรม" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="disciplinary_and_amnesty" runat="server">
                                </div>
                            </div>

                            <div class="dpl_7c" style="height: 1px;"></div>
                            <br />

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label6" runat="server" Text="ตำแหน่งและเงินเดือน" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="position_and_salary_div" runat="server">
                                </div>
                            </div>

                   

                        </div>
                    </td>

                </tr>
            </table>








        </div>

        <div class="dpl_7c" style="height: 1px;"></div>
        <br />

        <div class="master_light_div_sec">
            <div class="master_light_div_sec_title">
                ค้นหาบุคลากร
            </div>
            <div class="master_light_div_sec_in">

                

                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton12" runat="server" CssClass="master_light_button" OnClick="LinkButton12_Click">ค้นหาทั้งหมด</asp:LinkButton>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_light_button" OnClick="LinkButton13_Click">เลือกโดยตรง</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label10" runat="server" Text="รหัสประชาชน"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="master_light_textbox"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_light_button" OnClick="LinkButton11_Click">ค้นหา</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>

                <div class="dpl_7c" style="height: 1px; margin: 20px 0;"></div>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowSorting="True" DataKeyNames="ID,CITIZEN_ID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="รหัส" SortExpression="ID" ReadOnly="True" />
                        <asp:BoundField DataField="CITIZEN_ID" HeaderText="รหัสประชาชน" SortExpression="CITIZEN_ID" ReadOnly="True" />
                        <asp:BoundField DataField="PERSON_NAME" HeaderText="ชื่อ" SortExpression="PERSON_NAME" />
                        <asp:BoundField DataField="PERSON_LASTNAME" HeaderText="นามสกุล" SortExpression="PERSON_LASTNAME" />
                        <asp:BoundField DataField="STAFFTYPE_NAME" HeaderText="ประเภท" SortExpression="STAFFTYPE_NAME" />
                        <asp:BoundField DataField="NAME" HeaderText="ตำแหน่ง" SortExpression="NAME" />
                        <asp:BoundField DataField="MINISTRY_NAME" HeaderText="หน่วยงาน" SortExpression="MINISTRY_NAME" />
                        <asp:BoundField DataField="DEPARTMENT_NAME" HeaderText="แผนก" SortExpression="DEPARTMENT_NAME" />
                        <asp:CommandField HeaderText="เลือก" ShowSelectButton="True" ControlStyle-CssClass="master_default_gridview_select_button" SelectText="เลือก">
<ControlStyle CssClass="master_default_gridview_select_button"></ControlStyle>
                        </asp:CommandField>
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

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_PERSON.ID, TB_PERSON.CITIZEN_ID, PERSON_NAME, PERSON_LASTNAME, TB_STAFFTYPE.STAFFTYPE_NAME, TB_POSITION.NAME, TB_MINISTRY.MINISTRY_NAME, TB_PERSON.DEPARTMENT_NAME FROM TB_PERSON, TB_POSITION, TB_POSITION_AND_SALARY, TB_STAFFTYPE, TB_MINISTRY WHERE TB_PERSON.CITIZEN_ID = TB_POSITION_AND_SALARY.CITIZEN_ID AND TB_POSITION_AND_SALARY.POSITION_ID = TB_POSITION.ID AND TB_PERSON.STAFFTYPE_ID = TB_STAFFTYPE.STAFFTYPE_ID AND TB_PERSON.MINISTRY_ID = TB_MINISTRY.MINISTRY_ID AND ROWNUM = 1 ORDER BY TB_POSITION_AND_SALARY.ID DESC"></asp:SqlDataSource>

            </div>

        </div>
    </div>
</asp:Content>
