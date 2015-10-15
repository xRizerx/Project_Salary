<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="Script/jquery-ui-1.8.20.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#ContentPlaceHolder1_txtDateFrom,#ContentPlaceHolder1_txtDateTO").datepicker({
                dateFormat: 'dd/mm/yy',
                beforeShow: function () {
                    $(".ui-datepicker").css('font-size', 14)
                }
            });  
        });
    </script>
    <style type="text/CSS">
        .multext{
            resize:none;
        }
    </style>
    <asp:Panel ID="Panel1" runat="server" Height="1700px">
   <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style1">1. </td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style1">ชื่อ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="148px"></asp:TextBox>
                        </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">นามสกุล :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">ตำแหน่ง :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtPosition" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6">ระดับ :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDegree" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                    </tr>
                    </table> 
                <table>
                    <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style2">สังกัด :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style3">
                            <asp:TextBox ID="txtCampus" runat="server" MaxLength="100" Width="576px"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; " class="auto-style4">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
               </table>
                 <table>
                     <tr>
                          <td style="text-align: right; margin-right: 5px; " class="auto-style1">2. </td>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-styleพ">
                            <asp:TextBox ID="txtNameOfProject" runat="server" MaxLength="100" Width="720px"></asp:TextBox></td>
                      </tr>
                </table>
                <table>
                     <tr>
                         <td style="text-align: right; margin-right: 5px; " class="auto-style1">3. </td>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">สถานที่ฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style">
                            <asp:TextBox ID="txtPlace" runat="server" MaxLength="100" Width="748px"></asp:TextBox></td>
                      </tr>
                </table>       
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style8">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน</td>
                         <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; "class="auto-style5"> ตั้งแต่วันที่ </td>
                            <td style="text-align: left; width: 120px;">

                            <asp:TextBox ID="txtDateFrom" runat="server"></asp:TextBox></td>
                            <td style="text-align: left; width: 10px;"> </td> 
                             <td style="text-align: left; margin-right: 5px; "class="auto-style5"> ถึงวันที่ </td>
                            <td style="text-align: left; width: 120px;">
                                
                            <asp:TextBox ID="txtDateTO" runat="server"></asp:TextBox></td>
                      </tr>
                </table>





               <table>
                   <tr>
                <td style="text-align: right; margin-right: 5px; "> รวมเวลา :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtYear" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>
                            <td style="text-align: left; width: 10px;"> </td> 
                              <td style="text-align: right; margin-right: 5px; "> ปี </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtMonth" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>
                            <td style="text-align: left; width: 10px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; "> เดือน </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtDay" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>

                            <td style="text-align: left; width: 10px;"> </td> 
                            <td style="text-align: left; margin-right: 10px; "> วัน </td>

                         <td style="text-align: right; margin-right: 5px; "> ค่าใช้จ่ายตลอดโครงการ :&nbsp;</td>
                       <td style="text-align:  left; width: 50px;">
                            <asp:TextBox ID="txtBudget" runat="server" MaxLength="100" Width="356px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; "> บาท </td>
                   </tr>
               </table>


                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; "> แหล่งงบประมาณที่ได้รับการสนับสนุน </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtSupportBudget" runat="server" MaxLength="100" Width="702px"></asp:TextBox></td>
                    </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; "> 4. ประกาศนียบัตรที่ได้รับ </td>
                        <td style="text-align: left; width: 40px;"> 
                            <asp:CheckBox ID="chkBox" runat="server" Text="ถ้ามี" OnCheckedChanged="chkBox_CheckedChanged" /> 
                        </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtCertificate" runat="server" MaxLength="100" Width="738px"></asp:TextBox></td>
                    </tr>
                </table>

                  <table>
                    <tr>
                        <td style="text-align: left; margin-right: 10px;" > 5. สรุปผลการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align:  left; width: 50px;">
                            <asp:TextBox ID="txtAbstract" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                </table>

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 6. ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtResult" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
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
                            <asp:TextBox ID="txtShow1" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.2 ด้านการวิจัย </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow2" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.3 ด้านการบริการวิชาการ </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow3" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 7.4 ด้านอื่นๆ </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtShow4" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                  </table>

                 <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 8. ปัญหาอุปสรรคในการฝึกอบรม/สัมมนา/ดูงาน </td>                              
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtProblem" runat="server" MaxLength="1000" Height="100px" Width="947px" TextMode="MultiLine" CssClass="multext"></asp:TextBox></td>
                           </tr>
                  </table>

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;">9. ความคิดเห็น/ข้อเสนอแนะอื่นๆ </td>
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtComment" runat="server" MaxLength="1000" TextMode="MultiLine" Height="100px" Width="947px" CssClass="multext"></asp:TextBox></td>
                    </tr>
                </table>













                   <table>
                       <tr>
                           
                            <td style="text-align: left; width: 50px;"> 
                            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancelCustomer_Click" Width="140px"/></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                          

                            <asp:Button ID="btnSaveCustomer" Text="OK" runat="server" OnClick="btnSubmitCustomer_Click" Width="140px" /></td>
                            
                         
                           </tr>               
                </table>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
    
</asp:Content>
