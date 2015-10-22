<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personnel-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.Personnel_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <script src="Script/jquery-ui-1.8.20.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <script>
            $(function () {
                $(document).ready(function () {
                    $("#ContentPlaceHolder1_txtBIRTHDAY,#ContentPlaceHolder1_txtDATE_INWORRK").datepicker({
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
        .input-group-addon{color:#8a6d3b;background-color:#fcf8e3;border-color:#8a6d3b}
    </style>
    <asp:Panel runat="server" CssClass="divpan" Height="1250px">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
        <fieldset>
            <legend>เพิ่มข้อมูลบุคลากร</legend>
            <div>
                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">รหัสประจำตัวประชาชน <span class="textred">*</span></td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทบุคลากร*</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ความพิการ*</td>
                   </tr>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 80px;">
                            <asp:TextBox ID="txtCITIZEN_ID" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="รหัสประจำตัวประชาชน 13 หลัก"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                           <asp:DropDownList ID="DropDownSTAFFTYPE_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_STAFFTYPE" DataTextField="STAFFTYPE_NAME" DataValueField="STAFFTYPE_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_STAFFTYPE" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_STAFFTYPE]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt3" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">มหาวิทยาลัย</td>
                        <td style="text-align: left; "> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ระยะเวลาจ้าง*</td>
                        <td style="text-align: left; "> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เลขที่ตำแหน่ง</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:DropDownList ID="DropDownUNIV_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="SqlDataSource1" DataTextField="UNIV_NAME" DataValueField="UNIV_ID"></asp:DropDownList> 
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_UNIVERSITY]"></asp:SqlDataSource>
                        </td>

                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownTIME_CONTACT_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_TIME_CONTACT" DataTextField="TIME_CONTACT_NAME" DataValueField="TIME_CONTACT_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_TIME_CONTACT" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_TIME_CONTACT]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="เลขที่ตำแหน่ง"></asp:TextBox></td> 

                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">คำนำหน้าชื่อ(ยึดตามบัตรประชาชน)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทเงินจ้าง*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เงินเดือนปัจจุัน</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                           <asp:DropDownList ID="DropDownTITLE_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_TITLENAME" DataTextField="TITLE_NAME_TH" DataValueField="TITLE_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_TITLENAME" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_TITLENAME]"></asp:SqlDataSource>
                        </td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownBUDGET_ID" runat="server" MaxLength="100" Width="250px" CssClass="tb5" DataSourceID="TB_BUDGET" DataTextField="BUDGET_NAME" DataValueField="BUDGET_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_BUDGET" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_BUDGET]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox6" runat="server" MaxLength="100" Width="200px" CssClass="tb5" placeholder="เงินเดือนปัจจุบัน"></asp:TextBox> 
                            <asp:TextBox ID="TextBox44" runat="server" Width="30px" Enabled="false" CssClass="tb5">.00</asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ชื่อ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทตำแหน่ง*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เงินประจำตำแหน่งที่ได้รับ</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtSTF_NAME" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ชื่อ"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownSUBSTAFFTYPE_ID" runat="server" MaxLength="100" Width="250px" CssClass="tb5" DataSourceID="TB_SUBSTAFFTYPE" DataTextField="SUBSTAFFTYPE_ID" DataValueField="SUBSTAFFTYPE_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_SUBSTAFFTYPE" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_SUBSTAFFTYPE]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox9" runat="server" MaxLength="100" Width="200px" CssClass="tb5" placeholder="เงินประจำตำแหน่งที่ได้รับ"></asp:TextBox> 
                            <asp:TextBox ID="TextBox45" runat="server" Width="30px" Enabled="false" CssClass="tb5">.00</asp:TextBox> </td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">นามสกุล*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งบริหาร*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ศาสนา</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtSTF_LNAME" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="นามสกุล"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownADMIN_POSITION_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_ADMIN" DataTextField="ADMIN_POSITION_NAME" DataValueField="ADMIN_POSITION_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_ADMIN" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_ADMIN]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox12" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">เพศ</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งทางวิชาการ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ประเภทการดำรงตำแหน่งปัจจุบัน</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:DropDownList ID="DropDownGENDER_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_GENDER" DataTextField="GENDER_NAME" DataValueField="GENDER_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_GENDER" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_GENDER]"></asp:SqlDataSource>
                        </td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownPOSITION_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_POSITION" DataTextField="POSITION_NAME" DataValueField="POSITION_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_POSITION" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_POSITION]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox15" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วันเกิด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตำแหน่งในสายงาน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">วันที่มีผลบัลคับใช้ตามข้อมูล </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">"การเข้าสู่ตำแหน่งปัจจุบัน"</td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtBIRTHDAY" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownPOSITION_WORK_NAME" runat="server" Width="250px" CssClass="tb5" placeholder="ตำแหน่งในสายงาน" DataSourceID="TB_POSITION_WORK" DataTextField="POSITION_WORK_NAME" DataValueField="POSITION_WORK_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_POSITION_WORK" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_POSITION_WORK]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox18" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">บ้านเลขที่*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">คณะ/หน่วยงานที่สังกัด หรือเทียบเท่า*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เครื่องราชอิสริยาภรณ์สูงสุดที่ได้รับ</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtHOMEADD" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="บ้านเลขที่"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownDEPARTMENT_ID" runat="server" Width="250px" CssClass="tb5" DataSourceID="TB_DEPARTMENT" DataTextField="DEPARTMENT_NAME" DataValueField="FACULTY_ID"></asp:DropDownList>
                            <asp:SqlDataSource ID="TB_DEPARTMENT" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_DEPARTMENT]"></asp:SqlDataSource>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox21" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง 'มหาปรมาภรณ์ช้างเผือก'"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">หมู่</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">วันที่เข้าทำงาน ณ สถานที่ปัจจุบัน*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ข้อความระดับผลการประเมิณรอบงานที่1</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtMOO" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="หมู่บ้าน"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDATE_INWORRK" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox24" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง 'ดีเด่น'"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ถนน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">สาขางานที่เชี่ยวชาญ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ร้อยละการเลื่อนขั้นเงินเดือนตามผลการประเมินรอบที่1</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtSTREET" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ถนน"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtSPECIAL_NAME" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง ความปลอดภัยและประสิทธิภาพของยา"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox27" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง '5.0025'"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">จังหวัด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กลุ่มสาขาวิชาที่สอน(ISCED)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ข้อความระดับผลการประเมิณรอบงานที่2</td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:DropDownList ID="ddlPROVINCE" runat="server" Width="250px" OnSelectedIndexChanged="ddlPROVINCE_SelectedIndexChanged" AutoPostBack="true" CssClass="tb5"></asp:DropDownList></td> 
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox29" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox30" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง 'ดีเด่น'"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">อำเภอ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ระดับการศึกษาที่จบสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ร้อยละการเลื่อนขั้นเงินเดือนตามผลการประเมินรอบที่2</td>
                   </tr>
                    <tr><td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:DropDownList ID="ddlAMPHUR" runat="server" Width="250px" OnSelectedIndexChanged="ddlAMPHUR_SelectedIndexChanged" AutoPostBack="true" CssClass="tb5"></asp:DropDownList></td> 
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox32" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox33" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง '5.0025'"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ตำบล*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">หลักสูตรที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:DropDownList ID="ddlDISTRICT" runat="server" Width="250px" CssClass="tb5"></asp:DropDownList></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox35" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ชื่อหลักสูตร/ชื่อสาขา"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">รหัสไปรษณีย์</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กลุ่มสาขาวิชาที่จบสูงสุด(ISCED)*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtPOST_CODE" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="รหัสไปรษณีย์"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox37" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">หมายเลขโทรศัพท์ที่ทำงาน</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">สาขาวิชาที่จบสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtTELEPHONE" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ตัวอย่าง(0-2456-5789) ต่อ 2240"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox39" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">สัญชาติ*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ชื่อสถาบันที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtNATION_ID" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>  
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox41" runat="server" MaxLength="100" Width="250px" CssClass="tb5" placeholder="ชื่อสถาบันที่จบการศึกษาสูงสุด"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                     <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ประเทศที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 100px;"></td> 
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="TextBox43" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 170px;"> </td> 
                    </tr>
                      <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; width: 90px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ประเทศที่จบการศึกษาสูงสุด*</td>
                        <td style="text-align: left; width: 90px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "></td>
                   </tr>
                    <tr>
                        <td style="text-align: left; width: 30px;"> </td>
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
                            <td style="text-align: left; width:350px; height:50px;"> </td> 
                            <td style="text-align: left; width: 50px;"> 
                            <asp:Button ID="btnCancelPersonnel" Text="Cancel" runat="server" OnClick="btnCancelPersonnel_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                            <asp:Button ID="btnSavePersonnel" Text="OK" runat="server" OnClick="btnSubmitPersonnel_Click" Width="140px" CssClass="master_OAT_button" /></td>
                           </tr>               
                </table>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                    <ProgressTemplate>
                        <div id="ajaxloader">
                            Loading..</div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="ddlPROVINCE" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="ddlAMPHUR" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
                </div>
        </asp:Panel>
</asp:Content>
