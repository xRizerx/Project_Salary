<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        $(function () {
            $("#ContentPlaceHolder1_txtDateFrom,#ContentPlaceHolder1_txtDateTO").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
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
        .divpan {

            text-align: center;
        }
         body {
            background-image: url("Image/444.png");
        }
          .tb5 {
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
          .textred{
            color:red;
        }
    </style>
    <asp:Panel ID="Panel1" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSaveSeminar">
   <div>
        <fieldset>
            <legend>เพิ่มข้อมูลการฝึกอบรม/สัมมนา/ดูงาน</legend>
            <div>
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; ">1. </td>
                        <td style="text-align: right; margin-right: 5px; ">ชื่อ<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">นามสกุล<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; ">ตำแหน่ง<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtPosition" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; ">ระดับ<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDegree" runat="server" MaxLength="100" Width="148px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                    </table> 
                <table>
                    <tr>
                       <td style="text-align: right; margin-right: 5px; ">สังกัด<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left;">
                            <asp:TextBox ID="txtCampus" runat="server" MaxLength="100" Width="576px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
               </table>
                 <table>
                     <tr>
                          <td style="text-align: right; margin-right: 5px; ">2. </td>
                       <td style="text-align: right; margin-right: 5px; ">ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; ">
                            <asp:TextBox ID="txtNameOfProject" runat="server" MaxLength="100" Width="690px" CssClass="tb5"></asp:TextBox></td>
                      </tr>
                </table>
                <table>
                     <tr>
                         <td style="text-align: right; margin-right: 5px; ">3. </td>
                       <td style="text-align: right; margin-right: 5px; ">สถานที่ฝึกอบรม/สัมมนา/ดูงาน<span class="textred">*</span> :&nbsp;</td>
                        <td style="text-align: left; ">
                            <asp:TextBox ID="txtPlace" runat="server" MaxLength="100" Width="718px" CssClass="tb5"></asp:TextBox></td>
                      </tr>
                </table>       
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; ">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน</td>
                         <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ตั้งแต่วันที่<span class="textred">*</span> </td>
                            <td style="text-align: left; width: 190px;">

                            <asp:TextBox ID="txtDateFrom" runat="server" Width="155px" CssClass="tb5"></asp:TextBox></td>
                            <td style="text-align: left; width: 10px;"> </td> 
                             <td style="text-align: left; margin-right: 5px;">ถึงวันที่<span class="textred">*</span></td>
                            <td style="text-align: left; width: 190px;">
                                
                            <asp:TextBox ID="txtDateTO" runat="server" Width="155px" OnTextChanged="txtDateTO_TextChanged" CssClass="tb5"></asp:TextBox></td>
                          <td style="text-align: left; width: 10px;"></td>
                                <td style="text-align: left; width: 120px;">
                         <asp:Button ID="Button1" runat="server" Text="คำนวณวัน/เดือน/ปี" Width="170px" CssClass="master_OAT_button" /></td>


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
                         <td style="text-align: right; margin-right: 5px; ">ค่าใช้จ่ายตลอดโครงการ<span class="textred">*</span> :&nbsp;</td>
                       <td style="text-align:  left; width: 50px;">
                            <asp:TextBox ID="txtBudget" runat="server" MaxLength="100" Width="356px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; "> บาท </td>
                   </tr>
               </table>


                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; ">แหล่งงบประมาณที่ได้รับการสนับสนุน<span class="textred">*</span></td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtSupportBudget" runat="server" MaxLength="100" Width="702px" CssClass="tb5"></asp:TextBox></td>
                    </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; "> 4. ประกาศนียบัตรที่ได้รับ </td>
                        <td style="text-align: left; width: 40px;"> 
                            <asp:UpdatePanel ID="UpdatechkBox" runat="server">
                                   <ContentTemplate>
                            <asp:CheckBox ID="chkBox" runat="server" Text="ถ้ามี" OnCheckedChanged="chkBox_CheckedChanged" AutoPostBack="True" /> 
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="chkBox" />
                                  </Triggers>
                             </asp:UpdatePanel>
                        </td>
                        <td style="text-align: left; width: 50px;">
                             <asp:UpdatePanel ID="UpdatetxtCertificate" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtCertificate" runat="server" MaxLength="100" Width="739px" Enabled="False" Text="ไม่มี" CssClass="tb5" AutoPostBack="True"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtCertificate" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
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
                            <asp:Button ID="btnCancelSeminar" Text="Cancel" runat="server" OnClick="btnCancelSeminar_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                            <asp:Button ID="btnSaveSeminar" Text="OK" runat="server" OnClick="btnSubmitSeminar_Click" Width="140px" CssClass="master_OAT_button" /></td>
                           </tr>               
                </table>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
    
</asp:Content>
