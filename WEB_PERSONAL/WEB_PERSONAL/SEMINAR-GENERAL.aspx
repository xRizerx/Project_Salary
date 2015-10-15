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
  
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style1">ชื่อ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="148px"></asp:TextBox>
                        </td>
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
                        <td style="text-align: right; margin-right: 5px; " class="auto-style4">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
               </table>
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-styleพ">
                            <asp:TextBox ID="txtNameOfProject" runat="server" MaxLength="100" Width="720px"></asp:TextBox></td>
                      </tr>
                </table>
                <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">สถานที่ฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style">
                            <asp:TextBox ID="txtPlace" runat="server" MaxLength="100" Width="748px"></asp:TextBox></td>
                      </tr>
                </table>       
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style8">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน</td>
                        <td style="text-align: left; margin-right: 5px; "class="auto-style5">
                             ตั้งแต่วันที่ </td>
                            <td style="text-align: left; width: 120px;">

                            <asp:TextBox ID="txtDateFrom" runat="server"></asp:TextBox></td>
                            
                             <td style="text-align: left; margin-right: 5px; "class="auto-style5">
                             ถึงวันที่</td>
                            <td style="text-align: left; width: 120px;">
                                
                            <asp:TextBox ID="txtDateTO" runat="server"></asp:TextBox></td>
                      </tr>
                </table>

                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6"> รวมเวลา :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtYear" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>

                              <td style="text-align: right; margin-right: 5px; " class="auto-style6"> ปี </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtMonth" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>

                            <td style="text-align: right; margin-right: 5px; " class="auto-style6"> เดือน </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txtDay" runat="server" MaxLength="100" Width="50px"></asp:TextBox></td>

                         
                            <td style="text-align: right; margin-right: 5px; " class="auto-style6"> วัน </td>

                         <td style="text-align: right; margin-right: 5px; " class="auto-style6"> ค่าใช้จ่ายตลอดโครงการ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="100" Width="441px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6"> บาท </td>
                    </tr>
                </table>

                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6"> แหล่งงบประมาณที่ได้รับการสนับสนุน </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="100" Width="679px"></asp:TextBox></td>
                    </tr>
                </table>

                 <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6"> 4. ประกาศนียบัตรที่ได้รับ </td>
                        <td style="text-align: left; width: 60px;"> 
                            <asp:CheckBox ID="chkBox" runat="server" /> 
                        </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" Width="712px"></asp:TextBox></td>
                    </tr>
                </table>

                  <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 5. สรุปผลการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="100" Height="100px" Width="947px" TextMode="MultiLine"></asp:TextBox></td>
                           </tr>
                </table>

                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px;" > 6. ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน </td>
                                                   
                    </tr>
                       <tr>
                           <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="TextBox5" runat="server" MaxLength="100" Height="100px" Width="947px" TextMode="MultiLine"></asp:TextBox></td>
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
                            <asp:TextBox ID="TextBox6" runat="server" MaxLength="100" Height="100px" Width="947px" TextMode="MultiLine"></asp:TextBox></td>
                           </tr>
                </table>







                   <table>
                       <tr>
                           <td>
                            <asp:Button ID="btnSaveCustomer" Text="OK" runat="server" OnClick="btnSubmitCustomer_Click" />
                            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancelCustomer_Click" />
                           </td>
                           </tr>               
                </table>
            </div>
        </fieldset>
    </div>
    
</asp:Content>
