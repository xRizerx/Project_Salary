<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_GENERAL" %>
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
    </style>
    <asp:Panel ID="Panel1" runat="server" Height="1593px" CssClass="divpan">
   <div>
        <fieldset>
            <legend>เพิ่มข้อมูลการฝึกอบรม/สัมมนา/ดูงาน</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; ">1. </td>
                        <td style="text-align: right; margin-right: 5px; ">ชื่อ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">นามสกุล :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; ">ตำแหน่ง :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtPosition" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; ">ระดับ :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDegree" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                    </table> 
                <table>
                    <tr>
                       <td style="text-align: right; margin-right: 5px; ">สังกัด :&nbsp;</td>
                        <td style="text-align: left;">
                            <asp:TextBox ID="txtCampus" runat="server" MaxLength="100" Width="576px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
               </table>
                 <table>
                     <tr>
                          <td style="text-align: right; margin-right: 5px; ">2. </td>
                       <td style="text-align: right; margin-right: 5px; ">ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; ">
                            <asp:TextBox ID="txtNameOfProject" runat="server" MaxLength="100" Width="690px" CssClass="tb5"></asp:TextBox></td>
                      </tr>
                </table>
                <table>
                     <tr>
                         <td style="text-align: right; margin-right: 5px; ">3. </td>
                       <td style="text-align: right; margin-right: 5px; ">สถานที่ฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; ">
                            <asp:TextBox ID="txtPlace" runat="server" MaxLength="100" Width="718px" CssClass="tb5"></asp:TextBox></td>
                      </tr>
                </table>       
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; ">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน</td>
                         <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "> ตั้งแต่วันที่ </td>
                            <td style="text-align: left; width: 120px;">

                            <asp:TextBox ID="txtDateFrom" runat="server" Width="155px" CssClass="tb5"></asp:TextBox></td>
                            <td style="text-align: left; width: 10px;"> </td> 
                             <td style="text-align: left; margin-right: 5px;"> ถึงวันที่ 
                                
                         </td>
                            <td style="text-align: left; width: 120px;">
                                
                            <asp:TextBox ID="txtDateTO" runat="server" Width="155px" OnTextChanged="txtDateTO_TextChanged" CssClass="tb5"></asp:TextBox></td>
                          <td style="text-align: left; width: 10px;"></td>
                                <td style="text-align: left; width: 120px;">
                         <asp:Button ID="Button1" runat="server" Text="คำนวณวัน/เดือน/ปี" Width="180px" CssClass="master_OAT_button" /></td>


                      </tr>
                </table>





               <table>
                   <tr>
                <td style="text-align: right; margin-right: 5px; "> รวมเวลา :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtYear" runat="server" MaxLength="100" Width="50px" Enabled="False" CssClass="tb5"></asp:TextBox></td>
                           
                              <td style="text-align: left; margin-right: 5px; "> ปี </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtMonth" runat="server" MaxLength="100" Width="50px" Enabled="False" CssClass="tb5"></asp:TextBox></td>
                            
                            <td style="text-align: left; margin-right: 5px; "> เดือน </td>
                       <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtDay" runat="server" MaxLength="100" Width="50px" Enabled="False" CssClass="tb5"></asp:TextBox></td>

                            <td style="text-align: left; margin-right: 10px; "> วัน </td>
                       <td style="text-align: left; width: 10px;"> </td> 
                         <td style="text-align: right; margin-right: 5px; "> ค่าใช้จ่ายตลอดโครงการ :&nbsp;</td>
                       <td style="text-align:  left; width: 50px;">
                            <asp:TextBox ID="txtBudget" runat="server" MaxLength="100" Width="356px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; "> บาท </td>
                   </tr>
               </table>


                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; "> แหล่งงบประมาณที่ได้รับการสนับสนุน </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtSupportBudget" runat="server" MaxLength="100" Width="702px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; "> 4. ประกาศนียบัตรที่ได้รับ </td>
                        <td style="text-align: left; width: 40px;"> 
                            <asp:CheckBox ID="chkBox" runat="server" Text="ถ้ามี" OnCheckedChanged="chkBox_CheckedChanged" /> 
                        </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtCertificate" runat="server" MaxLength="100" Width="739px" Enabled="False" Text="ไม่มี" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                </table>

                  <table>
                    <tr>
                        <td style="text-align: left; margin-right: 10px;" > 5. สรุปผลการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align:  left; width: 50px;">
                            <asp:TextBox ID="txtAbstract" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                </table>

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 6. ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtResult" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                </table>
                

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7. การนำผลงานที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน </td>                              
                    </tr>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.1 ด้านการเรียนการสอน </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow1" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.2 ด้านการวิจัย </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow2" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.3 ด้านการบริการวิชาการ </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow3" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.4 ด้านอื่นๆ </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow4" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 8. ปัญหาอุปสรรคในการฝึกอบรม/สัมมนา/ดูงาน </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtProblem" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="tb5"></asp:TextBox></td>
                           </tr>
                  </table>

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;">9. ความคิดเห็น/ข้อเสนอแนะอื่นๆ </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtComment" runat="server" MaxLength="1000" TextMode="MultiLine" Height="100px" Width="947px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                </table>


                   <table>
                       <tr>
                           
                            <td style="text-align: left; width: 50px;"> 
                            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancelSeminar_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                          

                            <asp:Button ID="btnSaveCustomer" Text="OK" runat="server" OnClick="btnSubmitSeminar_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            
                         
                           </tr>               
                </table>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
    
</asp:Content>
