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
        .auto-style2 {
            height: 53px;
        }
        .auto-style3 {
            height: 172px;
        }
        .wrapper {
    /*height: auto !important;*/
    /*height: 100%;*/
    /*margin: 0 auto -200px;*/
    margin: 0 auto -120px;
    /*width: 1024px;*/
    /*min-height: 100%;
    min-height: 100vh;*/
    /*padding-bottom: 10px;*/
    width: unset;
    /*background-color: #f0f0f0;*/

}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel_main" runat="server" CssClass="Main_pan">
    <div class="head_div">
    <asp:Label ID="Label1" runat="server" Text="แบบข้อตกลงการประเมินผลสัมฤทธิ์ของงานของข้าราชการพลเรือนในสถาบันอุดมศึกษา"></asp:Label>
        <br /><asp:Label ID="Label89" runat="server" Text="หรือพนักงานในสถาบันอุดมศึกษา มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก ตำแหน่งวิชาการ"></asp:Label>
        <br /><asp:Label ID="Label88" runat="server" Text="(องค์ประกอบที่ 1 ผลสัมฤทธิ์ของงาน 70%)"></asp:Label>
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
                <td colspan="3" class="auto-style3">
                    <asp:Label ID="Label85" runat="server" Text="(1) กิจกรรม / โครงการ / งาน"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label86" runat="server" Text="(2) ค่าน้ำหนัก%"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label87" runat="server" Text="(3)  คำอธิบายตัวชี้วัดโดยย่อ"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label90" runat="server" Text="(4) ค่าเป้าหมาย"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label91" runat="server" Text="(5) ข้อมูลพื้นฐาน (Base Line) ในรอบการประเมินที่ผ่านมา"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label92" runat="server" Text="(6) ระดับค่าเป้าหมาย" Width="250px"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label93" runat="server" Text="(7)  ผลดำเนินงาน"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label94" runat="server" Text="(8) ค่าคะแนนที่ได้"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label95" runat="server" Text="(9) ค่าคะแนนถ่วงน้ำหนัก   (8) x (2) /  70"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:Label ID="Label96" runat="server" Text="(10) รายการหลักฐาน" Width="200px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="1. การเรียนการสอน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="1.1 มีจำนวนชั่วโมงสอนไม่น้อยกว่าภาระงานขั้นต่ำ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1.1" Text="1" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1.1" Text="2" />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="1.1" Text="3" />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="1.1" Text="4" />
                    <asp:RadioButton ID="RadioButton5" runat="server" GroupName="1.1" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label97" runat="server" Text="ตารางสอน"></asp:Label>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="1.2 มีประมวลรายวิชา/แผนการสอน โดยมีการ
ดำเนินการดังนี้"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton6" runat="server" GroupName="1.2" Text="1" />
                    <asp:RadioButton ID="RadioButton7" runat="server" GroupName="1.2" Text="2" />
                    <asp:RadioButton ID="RadioButton8" runat="server" GroupName="1.2" Text="3" />
                    <asp:RadioButton ID="RadioButton9" runat="server" GroupName="1.2" Text="4" />
                    <asp:RadioButton ID="RadioButton10" runat="server" GroupName="1.2" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="1 มีประมวลรายวิชา/แผนการสอน"></asp:Label>
                </td>
                <td></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label98" runat="server" Text="ประมวลรายวิชา/แผนการสอน"></asp:Label>
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="2 มีประมวลรายวิชา/แผนการสอนก่อนการเปิดภาค"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label99" runat="server" Text="บันทึกนำส่งประมวลรายวิชา/แผนการสอน"></asp:Label>
                    <asp:FileUpload ID="FileUpload3" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="3 มีประมวลรายวิชา/แผนการสอนที่มีเนื้อหาและรูปแบบตรงตามที่กำหนดในกรอบ TQF/เกณฑ์มาตรฐานหลักสูตรระดับปริญญาตรี ปี 2548"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label100" runat="server" Text="ประมวลรายวิชา/แผนการสอนที่ตรงตามเกณฑ์ TQF"></asp:Label>
                    <asp:FileUpload ID="FileUpload4" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="4 มีประมวลรายวิชา/แผนการสอนที่ส่งเสริมทักษะการเรียนรู้ด้วยตนเองและให้ผู้เรียนได้เรียนรู้จากการปฏิบัติทั้งในและนอกห้องเรียนหรือจากการทำวิจัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label101" runat="server" Text="ประมวลรายวิชา/แผนการสอน  และผลงาน/ชิ้นงานของนักศึกษา"></asp:Label>
                    <asp:FileUpload ID="FileUpload5" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="5 มีประมวลรายวิชา/แผนการสอนที่ให้ผู้มีประสบการณ์ทางวิชาการ/วิชาชีพจากหน่วยงานหรือชุมชนภายนอกเข้ามามีส่วนร่วมในกระบวนการเรียนการสอน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label102" runat="server" Text="หนังสือเชิญผู้มีประสบ การณ์/บุคคลภายนอก/หนังสือขอความร่วมมือเข้าศึกษาดูงาน ฯลฯ"></asp:Label>
                    <asp:FileUpload ID="FileUpload6" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="1.3 มีผลการประเมินความพึงพอใจของผู้เรียนที่มีต่อคุณภาพการจัดการเรียนการสอนไม่ต่ำกว่า 3.51 จากคะแนนเต็ม 5"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton11" runat="server" GroupName="1.3" Text="2.51 - 3" /><br />
                    <asp:RadioButton ID="RadioButton12" runat="server" GroupName="1.3" Text="3.01 - 3.5" /><br />
                    <asp:RadioButton ID="RadioButton13" runat="server" GroupName="1.3" Text="3.51 - 4" /><br />
                    <asp:RadioButton ID="RadioButton14" runat="server" GroupName="1.3" Text="4.01 -4.5" /><br />
                    <asp:RadioButton ID="RadioButton15" runat="server" GroupName="1.3" Text="4.51- 5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label103" runat="server" Text="ผลการประเมินความ พึงพอใจ"></asp:Label>
                    <asp:FileUpload ID="FileUpload7" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label20" runat="server" Text="1.4 มีการเข้ารับการอบรมทางวิชาการหรือวิชาชีพ  เทคนิคการสอนและการวัดผล"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton16" runat="server" GroupName="1.4" Text="1" />
                    <asp:RadioButton ID="RadioButton17" runat="server" GroupName="1.4" Text="2" />
                    <asp:RadioButton ID="RadioButton18" runat="server" GroupName="1.4" Text="3" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label104" runat="server" Text="แบบรายงานผลการเข้ารับการอบรม"></asp:Label>
                    <asp:FileUpload ID="FileUpload8" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="1.5 มีการจัดการเรียนรู้ที่พัฒนาจากการวิจัย หรือจากกระบวนการจัดการความรู้เพื่อพัฒนาการเรียนการสอน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton19" runat="server" GroupName="1.5" Text="1" />
                    <asp:RadioButton ID="RadioButton20" runat="server" GroupName="1.5" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label105" runat="server" Text="แผนการสอน ,ผลงานวิจัย/รายงานผลการจัดการความรู้/เอกสารประกอบการสอน"></asp:Label>
                    <asp:FileUpload ID="FileUpload9" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="1.6 มีการพัฒนาหรือปรับปรุงการจัดการเรียนการสอน กลยุทธ์การสอน หรือการประเมินผลการเรียนรู้ทุกรายวิชา ตามผลการประเมินรายวิชา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton21" runat="server" GroupName="1.6" Text="1" />
                    <asp:RadioButton ID="RadioButton22" runat="server" GroupName="1.6" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label106" runat="server" Text="ตารางสอน,  ผลการประเมินรายวิชา  และประมวลรายวิชา/แผนการสอน"></asp:Label>
                    <asp:FileUpload ID="FileUpload10" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label23" runat="server" Text="1.7 มีผลงานการเป็นอาจารย์ที่ปรึกษา/มีการให้คำปรึกษาทางวิชาการและแนะแนวการใช้ชีวิตแก่นักศึกษา (ทั่วไป)"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton23" runat="server" GroupName="1.7" Text="1" />
                    <asp:RadioButton ID="RadioButton24" runat="server" GroupName="1.7" Text="2" />
                    <asp:RadioButton ID="RadioButton25" runat="server" GroupName="1.7" Text="3" />
                    <asp:RadioButton ID="RadioButton26" runat="server" GroupName="1.7" Text="4" />
                    <asp:RadioButton ID="RadioButton27" runat="server" GroupName="1.7" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="1. มีคำสั่งแต่งตั้งเป็นอาจารย์ที่ปรึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label107" runat="server" Text="คำสั่งแต่งตั้ง อ.ที่ปรึกษา"></asp:Label>
                    <asp:FileUpload ID="FileUpload11" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="2. มีตารางการให้นักศึกษาเข้าพบเพื่อให้คำปรึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label108" runat="server" Text="ตารางเวลาการเข้าพบ"></asp:Label>
                    <asp:FileUpload ID="FileUpload12" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Label ID="Label26" runat="server" Text="3. มีการให้คำปรึกษาทางวิชาการและแนะแนวการใช้ชีวิตแก่นักศึกษา"></asp:Label>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label109" runat="server" Text="แบบบันทึกการให้คำปรึกษา/Print out จากWeb งานทะเบียน"></asp:Label>
                    <asp:FileUpload ID="FileUpload13" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label27" runat="server" Text="4. มีการแจ้งข้อมูลข่าวสารที่เป็นประโยชน์ต่อนักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label110" runat="server" Text="หนังสือเวียนแจ้ง น.ศ./Print out จากWeb งานทะเบียน"></asp:Label>
                    <asp:FileUpload ID="FileUpload14" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label28" runat="server" Text="5. มีการนำนักศึกษาเข้าร่วมกิจกรรมเพื่อพัฒนาประสบการณ์ทางวิชาการและทักษะวิชาชีพแก่นักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label111" runat="server" Text="หลักฐานแสดงการจัดกิจกรรม"></asp:Label>
                    <asp:FileUpload ID="FileUpload15" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label29" runat="server" Text="1.8 มีผลงานการเป็นผู้รับผิดชอบโครงการกิจกรรมนักศึกษา/เป็นคณะกรรมการโครงการกิจกรรมนักศึกษา/เป็นอาจารย์ที่ปรึกษาโครงการ/อาจารย์ที่ปรึกษาชมรม (กิจกรรม/โครงการต่างๆ)"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton28" runat="server" GroupName="1.8" Text="1" />
                    <asp:RadioButton ID="RadioButton29" runat="server" GroupName="1.8" Text="2" />
                    <asp:RadioButton ID="RadioButton30" runat="server" GroupName="1.8" Text="3" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label30" runat="server" Text="1.9 มีการจัดกิจกรรม/โครงการเพื่อพัฒนาประสบการณ์ทางวิชาการหรือทักษะวิชาชีพแก่นักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton31" runat="server" GroupName="1.9" Text="1" />
                    <asp:RadioButton ID="RadioButton32" runat="server" GroupName="1.9" Text="2" />
                    <asp:RadioButton ID="RadioButton33" runat="server" GroupName="1.9" Text="3" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label31" runat="server" Text="1.10 ภาระงานสอนอื่น ๆ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label32" runat="server" Text="2. การวิจัยหรือตำราหรือหนังสือหรือผลงานทางวิชาการหรือบทความทางวิชาการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label33" runat="server" Text="2.1 มีผลงานวิจัยหรืองานสร้างสรรค์"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton34" runat="server" GroupName="2.1" Text="1" />
                    <asp:RadioButton ID="RadioButton35" runat="server" GroupName="2.1" Text="2" />
                    <asp:RadioButton ID="RadioButton36" runat="server" GroupName="2.1" Text="3" />
                    <asp:RadioButton ID="RadioButton37" runat="server" GroupName="2.1" Text="4" />
                    <asp:RadioButton ID="RadioButton38" runat="server" GroupName="2.1" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label34" runat="server" Text="1. มีโครงร่างหัวข้องานวิจัย/งานสร้างสรรค์ที่พร้อมนำเสนอ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label35" runat="server" Text="2. มีการนำเสนอหัวข้องานวิจัย/งานสร้างสรรค์ตามกระบวนการของมหาวิทยาลัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label36" runat="server" Text="3. ได้รับอนุมัติงบประมาณสนับสนุนโครงการวิจัย/งานสร้างสรรค์"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label37" runat="server" Text="4. เป็นหัวหน้าโครงการวิจัย/งานสร้างสรรค์ที่ได้รับอนุมัติงบประมาณ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label38" runat="server" Text="5. งานวิจัยหรืองานสร้างสรรค์แล้วเสร็จตามเวลาที่กำหนด"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label39" runat="server" Text="2.2 ระดับคุณภาพของผลงานวิชาการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton39" runat="server" GroupName="2.2" Text="3" />
                    <asp:RadioButton ID="RadioButton40" runat="server" GroupName="2.2" Text="4" />
                    <asp:RadioButton ID="RadioButton41" runat="server" GroupName="2.2" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label40" runat="server" Text="2.3 มีการบูรณาการกระบวนการวิจัยหรืองานสร้างสรรค์กับการจัดการเรียนการสอน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton42" runat="server" GroupName="2.3" Text="1" />
                    <asp:RadioButton ID="RadioButton43" runat="server" GroupName="2.3" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label41" runat="server" Text="2.4 มีผลงานการเผยแพร่งานวิจัยหรืองานสร้างสรรค์ในการประชุมวิชาการหรือการตีพิมพ์ในวารสารระดับชาติ/นานาชาติ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton45" runat="server" GroupName="2.4" Text="สถาบัน" />
                    <asp:RadioButton ID="RadioButton46" runat="server" GroupName="2.4" Text="ชาติ" />
                    <asp:RadioButton ID="RadioButton47" runat="server" GroupName="2.4" Text="นานาชาติ" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label42" runat="server" Text="2.5 จำนวนครั้งในการเผยแพร่งานวิจัยหรืองานสร้างสรรค์ในการประชุมวิชาการหรือการตีพิมพ์ในวารสารระดับชาติ/นานาชาติ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton48" runat="server" GroupName="2.5" Text="1" />
                    <asp:RadioButton ID="RadioButton49" runat="server" GroupName="2.5" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label43" runat="server" Text="2.6 มีการนำผลงานวิจัยหรืองานสร้างสรรค์ไปใช้ให้เกิดประโยชน์ และมีการรับรองการใช้ประโยชน์จริงจากหน่วยงานภายนอกหรือชุมชน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton50" runat="server" GroupName="2.6" Text="1" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label44" runat="server" Text="2.7 มีการจดสิทธิบัตร/อนุสิทธิบัตร"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton51" runat="server" GroupName="2.7" Text="1" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label45" runat="server" Text="2.8 ภาระงานวิชาการอื่น ๆ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label46" runat="server" Text="3. การบริการวิชาการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label47" runat="server" Text="3.1 มีผลงานการบริการทางวิชาการแก่สังคม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton52" runat="server" GroupName="3.1" Text="1" />
                    <asp:RadioButton ID="RadioButton53" runat="server" GroupName="3.1" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label48" runat="server" Text="3.2 มีผลงานการเป็นผู้รับผิดชอบโครงการบริการวิชาการแก่สังคม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton54" runat="server" GroupName="3.2" Text="1" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label49" runat="server" Text="3.3 เป็นคณะกรรมการโครงการบริการวิชาการแก่สังคม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton55" runat="server" GroupName="3.3" Text="1" />
                    <asp:RadioButton ID="RadioButton56" runat="server" GroupName="3.3" Text="2" />
                    <asp:RadioButton ID="RadioButton57" runat="server" GroupName="3.3" Text="3" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label50" runat="server" Text="3.4 มีการบูรณาการงานบริการทางวิชาการแก่สังคม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton58" runat="server" GroupName="3.4" Text="3" />
                    <asp:RadioButton ID="RadioButton59" runat="server" GroupName="3.4" Text="4" />
                    <asp:RadioButton ID="RadioButton60" runat="server" GroupName="3.4" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label51" runat="server" Text="3.5 งานบริการวิชาการอื่น ๆ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label52" runat="server" Text="4. การทำนุบำรุงศิลปวัฒนธรรม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label53" runat="server" Text="4.1 มีผลงานการเป็นผู้รับผิดชอบ/เป็นคณะกรรมการดำเนินโครงการทำนุบำรุงศิลปวัฒนธรรม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton61" runat="server" GroupName="4.1" Text="1" />
                    <asp:RadioButton ID="RadioButton62" runat="server" GroupName="4.1" Text="2" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label54" runat="server" Text="4.2 การเข้าร่วมโครงการทำนุบำรุงศิลปวัฒนธรรม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton63" runat="server" GroupName="4.2" Text="1" />
                    <asp:RadioButton ID="RadioButton64" runat="server" GroupName="4.2" Text="2" />
                    <asp:RadioButton ID="RadioButton65" runat="server" GroupName="4.2" Text="3" />
                    <asp:RadioButton ID="RadioButton66" runat="server" GroupName="4.2" Text="4" />
                    <asp:RadioButton ID="RadioButton67" runat="server" GroupName="4.2" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label55" runat="server" Text="4.3 การปฏิบัติตามระบบและกลไกการทำนุบำรุงศิลปวัฒนธรรม"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton68" runat="server" GroupName="4.3" Text="1" />
                    <asp:RadioButton ID="RadioButton69" runat="server" GroupName="4.3" Text="2" />
                    <asp:RadioButton ID="RadioButton70" runat="server" GroupName="4.3" Text="3" />
                    <asp:RadioButton ID="RadioButton71" runat="server" GroupName="4.3" Text="4" />
                    <asp:RadioButton ID="RadioButton72" runat="server" GroupName="4.3" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label56" runat="server" Text="1. มีการบูรณาการงานด้านทำนุบำรุงกิจกรรมศิลปวัฒนธรรมกับการจัดการเรียนการสอน/นักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label57" runat="server" Text="2. มีการเผยแพร่กิจกรรมหรือบริการด้านทำนุบำรุงศิลปวัฒนธรรมต่อสาธารณชน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label58" runat="server" Text="3. มีการประเมินผลความสำเร็จของการบูรณาการงานด้านทำนุบำรุงศิลปวัฒนธรรมกับการจัดการเรียนการสอน/กิจกรรมนักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label59" runat="server" Text="4. มีการนำผลการประเมินไปปรับปรุงการบูรณาการงานด้านทำนุบำรุงศิลปวัฒนธรรมกับการจัดการเรียนการสอน/กิจกรรมนักศึกษา"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label60" runat="server" Text="5. มีการกำหนดหรือสร้างมาตรฐานคุณภาพด้านศิลปวัฒนธรรมและมีผลงานเป็นที่ยอมรับในระดับชาติ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label61" runat="server" Text="5. งานบริหาร/งานอื่น ๆ  ตามยุทธศาสตร์ นโยบาย ของมหาวิทยาลัย/คณะ/วิทยาลัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label62" runat="server" Text="5.1 การให้ความร่วมมือเข้าร่วมกิจกรรมของวันคณะ/มหาวิทยาลัย เช่น การประชุมปฐมนิเทศ ปัจฉิมนิเทศ กฐินพระราชทาน งานกีฬา ไหว้ครู สำคัญทางศาสนา ฯลฯ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton73" runat="server" GroupName="5.1" Text="1" />
                    <asp:RadioButton ID="RadioButton74" runat="server" GroupName="5.1" Text="2" />
                    <asp:RadioButton ID="RadioButton75" runat="server" GroupName="5.1" Text="3" />
                    <asp:RadioButton ID="RadioButton76" runat="server" GroupName="5.1" Text="4" />
                    <asp:RadioButton ID="RadioButton77" runat="server" GroupName="5.1" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label63" runat="server" Text="5.2 เป็นคณะกรรมการประกันคุณภาพ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton78" runat="server" GroupName="5.2" Text="1" />
                    <asp:RadioButton ID="RadioButton79" runat="server" GroupName="5.2" Text="2" />
                    <asp:RadioButton ID="RadioButton80" runat="server" GroupName="5.2" Text="3" />
                    <asp:RadioButton ID="RadioButton81" runat="server" GroupName="5.2" Text="4" />
                    <asp:RadioButton ID="RadioButton82" runat="server" GroupName="5.2" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label64" runat="server" Text="1 มีคำสั่งแต่งตั้งเป็นคณะกรรมการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label65" runat="server" Text="2 มีการเข้าร่วมประชุมคณะกรรมการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label66" runat="server" Text="3 มีผลการปฏิบัติงาน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label67" runat="server" Text="4 มีรายงานผลการปฎิบัติงาน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label68" runat="server" Text="5 มีการนำผลการประเมิน/ผลการดำเนินงานของปีก่อนมาพัฒนาปรับปรุง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label69" runat="server" Text="5.3 เป็นคณะกรรมการจัดการความรู้"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton83" runat="server" GroupName="5.3" Text="1" />
                    <asp:RadioButton ID="RadioButton84" runat="server" GroupName="5.3" Text="2" />
                    <asp:RadioButton ID="RadioButton85" runat="server" GroupName="5.3" Text="3" />
                    <asp:RadioButton ID="RadioButton86" runat="server" GroupName="5.3" Text="4" />
                    <asp:RadioButton ID="RadioButton87" runat="server" GroupName="5.3" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label70" runat="server" Text="1 มีคำสั่งแต่งตั้งเป็นคณะกรรมการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label71" runat="server" Text="2 มีการกำหนดประเด็นความรู้และเป้าหมายของการจัดการความรู้ที่สอดคล้องกับแผนกลยุทธ์ของสถาบัน อย่างน้อยครอบคลุมพันธกิจด้านการผลิตบัณฑิตและด้านการวิจัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label72" runat="server" Text="3 มีการแบ่งปันและแลกเปลี่ยนเรียนรู้จากผู้มีประสบการณ์ตรง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label73" runat="server" Text="4 มีการรวบรวมความรู้มาพัฒนาและจัดเก็บอย่างเป็นระบบโดยเผยแพร่เป็นลายลักษณ์อักษร"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label74" runat="server" Text="5 มีการนำความรู้ที่ได้จากการจัดการความรู้ที่เป็นแนวปฏิบัติที่ดีมาปรับใช้ในการปฏิบัติงานจริง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label75" runat="server" Text="5.4 เป็นคณะกรรมการบริหารความเสี่ยง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton88" runat="server" GroupName="5.4" Text="1" />
                    <asp:RadioButton ID="RadioButton89" runat="server" GroupName="5.4" Text="2" />
                    <asp:RadioButton ID="RadioButton90" runat="server" GroupName="5.4" Text="3" />
                    <asp:RadioButton ID="RadioButton91" runat="server" GroupName="5.4" Text="4" />
                    <asp:RadioButton ID="RadioButton92" runat="server" GroupName="5.4" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label76" runat="server" Text="1 มีคำสั่งแต่งตั้งเป็นคณะกรรมการ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label77" runat="server" Text="2 มีการวิเคราะห์และระบุความเสียง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label78" runat="server" Text="3 มีการประเมินโอกาสและผลกระทบและจัดลำดับความเสี่ยง"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label79" runat="server" Text="4 มีการจัดทำแผนบริหารความเสี่ยงและดำเนินตามแผน"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label80" runat="server" Text="5 มีการติดตาม ประเมินผลและรายงานผล"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label81" runat="server" Text="5.5 เป็นคณะกรรมการอื่น ๆ ตามคำสั่งคณะ/มหาวิทยาลัย"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton93" runat="server" GroupName="5.5" Text="1" />
                    <asp:RadioButton ID="RadioButton94" runat="server" GroupName="5.5" Text="2" />
                    <asp:RadioButton ID="RadioButton95" runat="server" GroupName="5.5" Text="3" />
                    <asp:RadioButton ID="RadioButton96" runat="server" GroupName="5.5" Text="4" />
                    <asp:RadioButton ID="RadioButton97" runat="server" GroupName="5.5" Text="5" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label82" runat="server" Text="5.6 เป็นอาจารย์ที่ปรึกษาผลงานที่นักศึกษาได้รับรางวัลระดับชาติ/นานาชาติ"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton98" runat="server" GroupName="5.6" Text="1" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label83" runat="server" Text="5.7 มีผลงานการเป็นผู้รับผิดชอบ/เป็นคณะกรรมการดำเนินโครงการเกี่ยวกับการอนุรักษ์สิ่งแวดล้อม/จิตอาสา/บำเพ็ญประโยชน์"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:RadioButton ID="RadioButton99" runat="server" GroupName="5.7" Text="1" />
                    <asp:RadioButton ID="RadioButton100" runat="server" GroupName="5.7" Text="2" />
                    <asp:RadioButton ID="RadioButton101" runat="server" GroupName="5.7" Text="3" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label84" runat="server" Text="5.8 อื่น ๆ..(ผู้ประเมินและผู้รับการประเมินตกลงกันเอง)............."></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
        </asp:Panel>
</asp:Content>
