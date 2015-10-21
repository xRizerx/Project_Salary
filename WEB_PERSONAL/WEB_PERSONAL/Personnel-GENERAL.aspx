<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personnel-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.Personnel_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script src="Script/jquery-ui-1.8.20.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <script>
            $(function () {
                $(document).ready(function () {
                    $("#ContentPlaceHolder1_txtDateFrom,#ContentPlaceHolder1_txtDateTO").datepicker({
                        dateFormat: 'dd/mm/yy',
                        changeMonth: true,
                        changeYear: true,
                        beforeShow: function () {
                            $(".ui-datepicker").css('font-size', 14)
                        }
                    });
                });
            });
  </script>

    <style type="text/CSS">
        .multext{
            resize:none;
        }
         .a1{
            border-radius:20px;
            padding:5px 10px;
            background-color:#00ff21;
            text-decoration:none;
            color:black;
            text-align:center;
        }
         .divpan{
            background-image: url("Image/sky.jpg");
            text-align: center;
        }
        .textmode {
            font-family: ths;
            font-size: 16px;
        }

        .textmodeb {
            font-family: thsb;
            font-size: 24px;
            padding: 20px;
        }

        .textmodebi {
            font-family: thsbi;
            font-size: 20px;
        }

        .textmodei {
            font-family: thsi;
            font-size: 20px;
        }

        .pancen {
            text-align: center;
        }

        .panin{
            border:1px solid black;
            margin: 20px;
            background-color:rgba(255,255,255,0.6);
            border-radius: 5px;
        }
         body {
            background-image: url("Image/444.jpg");
        }
         .tb5 {
	        background-image:url(images/form_bg.jpg);
	        background-repeat:repeat-x;
	        border:1px solid #d1c7ac;
	        width: 230px;
	        color:#333333;
	        padding:3px;
	        margin-right:4px;
	        margin-bottom:8px;
	        font-family:tahoma, arial, sans-serif;
            border-radius:10px;
            resize:none;
              }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 90px;
            height: 23px;
        }
    </style>
    <asp:Panel ID="Panel1" runat="server" Height="1500px" CssClass="divpan">
   <div>
        <fieldset>
            <legend>เพิ่มข้อมูลบุคลากร</legend>
            <div>
                <table>
                   <tr>
                        <td style="text-align: left; margin-right: 5px; ">รหัสประจำตัวประชาชน*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทบุคลากร*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ความพิการ*</td>
                   </tr>
                   <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txt1" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt2" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt3" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; " class="auto-style2">มหาวิทยาลัย</td>
                        <td style="text-align: left; " class="auto-style3"> </td> 
                        <td style="text-align: left; margin-right: 5px; " class="auto-style2">ระยะเวลาจ้าง*</td>
                        <td style="text-align: left; " class="auto-style3"> </td> 
                        <td style="text-align: left; margin-right: 5px; " class="auto-style2">เลขที่ตำแหน่ง</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">คำนำหน้าชื่อ(ยึดตามบัตรประชาชน)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทเงินจ้าง*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เงินเดือนปัจจุัน</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox5" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox6" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">ชื่อ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทตำแหน่ง*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เงินประจำตำแหน่งที่ได้รับ</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox7" runat="server" MaxLength="100" Width="250px" CssClass="tb5" ForeColor="#999999">ชื่อ</asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox8" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox9" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">นามสกุล*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งบริหาร*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ศาสนา</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox10" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox11" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox12" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">เพศ</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งทางวิชาการ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทการดำรงตำแหน่งปัจจุบัน</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox13" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox14" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox15" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">วันเกิด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งในสายงาน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">วันที่มีผลบัลคับใช้ตามข้อมูล </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">"การเข้าสู่ตำแหน่งปัจจุบัน"</td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox16" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox17" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox18" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">บ้านเลขที่*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">คณะ/หน่วยงานที่สังกัด หรือเทียบเท่า*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เครื่องราชอิสริยาภรณ์สูงสุดที่ได้รับ</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox19" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox20" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox21" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">หมู่</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">วันที่เข้าทำงานครั้งแรก*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ข้อความระดับผลการประเมิณรอบงานที่1</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox22" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox23" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox24" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">ถนน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">วันที่เข้าทำงาน ณ สถานที่ปัจจุบัน*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ร้อยละการเลื่อนขั้นเงินเดือนตามผลการประเมินรอบที่1</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox25" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox26" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox27" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">จังหวัด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">สาขางานที่เชี่ยวชาญ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ข้อความระดับผลการประเมิณรอบงานที่2</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox28" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox29" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox30" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">อำเภอ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กลุ่มสาขาวิชาที่สอน(ISCED)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ร้อยละการเลื่อนขั้นเงินเดือนตามผลการประเมินรอบที่2</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox31" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox32" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox33" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; margin-right: 5px; ">ตำบล*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ระดับการศึกษาที่จบสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox34" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox35" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; margin-right: 5px; ">หมายเลขโทรศัพท์ที่ทำงาน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">หลักสูตรที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox36" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox37" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; margin-right: 5px; ">รหัสไปรษณีย์*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กลุ่มสาขาวิชาที่จบสูงสุด(ISCED)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox38" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox39" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; margin-right: 5px; ">สัญชาติ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">สาขาวิชาที่จบสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="TextBox40" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox41" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ชื่อสถาบันที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;"></td> 
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox43" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                      <tr>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ประเทศที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 100px;"></td> 
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox42" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
              </table> 
                 <table>
                    <tr>
                        <td style="text-align: left; width:300px;"> </td> 
                        <td style="text-align: left; width:300px;"> </td> 
                        <td style="text-align: left; width:300px;"> </td> 
                        <td style="text-align: left; width:1024px;"> </td> 
                    </tr> 
                </table>
                <table>
                    <tr>
                         <td style="text-align: left; width:300px;"> </td> 
                    </tr>   
                          <tr>
                            <td style="text-align: left; width:300px;"> </td> 
                            <td style="text-align: left; width: 50px;"> 
                            <asp:Button ID="btnCancelPersonnel" Text="Cancel" runat="server" OnClick="btnCancelPersonnel_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                            <asp:Button ID="btnSavePersonnel" Text="OK" runat="server" OnClick="btnSubmitPersonnel_Click" Width="140px" CssClass="master_OAT_button" /></td>
                           </tr>               
                </table>

            </div>
        </fieldset>
    </div>
        </asp:Panel>
    
</asp:Content>
