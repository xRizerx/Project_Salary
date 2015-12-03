<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WEB_PERSONAL.Profile" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 201px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Profile.css" rel="stylesheet" />

    <script>
        (function ($) {
            $(window).load(function () {
                $(".sec1").mCustomScrollbar({
                    axis: "x",
                    theme: "white-thin",
                    //theme: "minimal-dark",
                    autoExpandScrollbar: true,
                    advanced: { autoExpandHorizontalScroll: true }
                });
            });
        })(jQuery);
    </script>

    <div class="main">
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


                            <div>
                                <asp:Label ID="Label2" runat="server" Text="ข้อมูลผู้ใช้งาน" CssClass="title_a"></asp:Label>
                            </div>
                            <table class="auto-style3">
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label12" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label31" runat="server" Text="คำนำหน้า"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label13" runat="server" Text="ชื่อ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label16" runat="server" Text="นามสกุล"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label45" runat="server" Text="เพศ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label21" runat="server" Text="สถานะ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label29" runat="server" Text="ประเภท"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label23" runat="server" Text="ตำแหน่ง"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label41" runat="server" Text="กระทรวง"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label43" runat="server" Text="แผนก"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label25" runat="server" Text="วันเกิด"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label27" runat="server" Text="เริ่มเข้าทำงาน"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label33" runat="server" Text="วันที่เลิก"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label35" runat="server" Text="ชื่อบิดา"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label36" runat="server" Text="ชื่อมารดา"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label37" runat="server" Text="ชื่อคู่ครอง"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label47" runat="server" Text="สัญชาติ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label48" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label49" runat="server" Text="บ้านเลขที่"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label52" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label50" runat="server" Text="หมู่"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label51" runat="server" Text="ถนน"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label54" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label55" runat="server" Text="ตำบล"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label59" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label56" runat="server" Text="อำเภอ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label60" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label57" runat="server" Text="จังหวัด"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label61" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label58" runat="server" Text="รหัสไปรษณีย์"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label62" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label63" runat="server" Text="เบอร์โทรศัพท์"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label64" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label65" runat="server" Text="Time Contact"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label67" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label66" runat="server" Text="Budget"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label68" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label69" runat="server" Text="Sub Staff Type"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label70" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label71" runat="server" Text="Special name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label73" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label72" runat="server" Text="Teach ISCED"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label74" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label75" runat="server" Text="Grad LEV"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label76" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label77" runat="server" Text="หลักสูตรที่จบการศึกษา"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label78" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label79" runat="server" Text="Grad ISCED"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label80" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label81" runat="server" Text="Grad Prog"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label82" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label83" runat="server" Text="Grad UNIV"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label84" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label85" runat="server" Text="Grad Country"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label86" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label87" runat="server" Text="Branch"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label89" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label88" runat="server" Text="Rank"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label90" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label91" runat="server" Text="Faculty"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label93" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label92" runat="server" Text="Start Position Work"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label94" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label18" runat="server" Text="รหัสผ่านเก่า"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="profile_default_textbox" TextMode="Password" Width="160px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label19" runat="server" Text="รหัสผ่านใหม่"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="profile_default_textbox" TextMode="Password" Width="160px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <asp:Label ID="Label20" runat="server" Text="ยืนยันรหัสผ่านใหม่"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server" CssClass="profile_default_textbox" TextMode="Password" Width="160px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>
                                        <asp:LinkButton ID="LinkButton12" runat="server" CssClass="profile_default_button" OnClick="LinkButton12_Click">เปลี่ยนรหัสผ่าน</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label7" runat="server" Text="ประวัติการศึกษา" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="study_history_div" runat="server">
                                </div>
                            </div>

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label1" runat="server" Text="ใบอนุญาตประกอบวิชาชีพ" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="job_license_div" runat="server">
                                </div>
                            </div>

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label4" runat="server" Text="ประวัติการฝึกอบรม" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="training_history_div" runat="server">
                                </div>
                            </div>

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label5" runat="server" Text="การได้รับโทษทางวินัยและการนิรโทษกรรม" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="disciplinary_and_amnesty" runat="server">
                                </div>
                            </div>

                            <div class="info_div">
                                <div>
                                    <asp:Label ID="Label6" runat="server" Text="ตำแหน่งและเงินเดือน" CssClass="info_div_title"></asp:Label>
                                </div>
                                <div class="info_div_in" id="position_and_salary_div" runat="server">
                                </div>
                            </div>

                            <div>
                                <asp:LinkButton ID="LinkButton11" runat="server" CssClass="profile_default_button" OnClick="LinkButton11_Click">แก้ไขข้อมูล</asp:LinkButton>
                            </div>

                        </div>
                    </td>

                </tr>
                </table>








        </div>

        <div class="profile_image_header">
            <asp:Label ID="Label3" runat="server" Text="รูปภาพ"></asp:Label>
            <span style="display: inline-block; width: 50px;"></span>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="200px" CssClass="uploader"/>
            <asp:LinkButton ID="LinkButton1" runat="server" Text="อัพโหลด" CssClass="profile_default_button" OnClick="LinkButton1_Click"></asp:LinkButton>
        </div>

        <asp:Panel ID="Panel1" runat="server"></asp:Panel>



    </div>
</asp:Content>
