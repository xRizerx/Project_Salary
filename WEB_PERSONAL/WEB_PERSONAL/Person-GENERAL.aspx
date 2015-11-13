<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Person-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.Person_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <script src="Script/jquery-ui-1.8.20.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
    function RefreshUpdatePanel() {
        __doPostBack('<%= txtCitizen.ClientID %>', '');
    };
    </script>
    <script>
            $(function () {
                $(document).ready(function () {
                    $("#ContentPlaceHolder1_txtBirthDayNumber,#ContentPlaceHolder1_txtDateInWork,#ContentPlaceHolder1_txtAge60Number").datepicker({
                        dateFormat: 'dd-mm-yy',
                        changeMonth: true,
                        changeYear: true,
                        dayNamesMin: ['อา', 'จ', 'อ', 'พ', 'พฤ', 'ศ', 'ส'],
                        monthNamesShort: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม', 'มิถุนายน', 'กรกฎาคม', 'สิงหาคม', 'กันยายน', 'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
                        yearRange: "-60:+40",
                        beforeShow: function () {
                            $(".ui-datepicker").css('font-size', 14)
                            if ($(this).val() != "") {
                                var arrayDate = $(this).val().split("-");
                                arrayDate[2] = parseInt(arrayDate[2]) - 543;
                                $(this).val(arrayDate[0] + "-" + arrayDate[1] + "-" + arrayDate[2]);
                            }
                            setTimeout(function () {
                                $.each($(".ui-datepicker-year option"), function (j, k) {
                                    var textYear = parseInt($(".ui-datepicker-year option").eq(j).val()) + 543;
                                    $(".ui-datepicker-year option").eq(j).text(textYear);
                                });
                            }, 50);
                        },
                        onChangeMonthYear: function () {
                            setTimeout(function () {
                                $.each($(".ui-datepicker-year option"), function (j, k) {
                                    var textYear = parseInt($(".ui-datepicker-year option").eq(j).val()) + 543;
                                    $(".ui-datepicker-year option").eq(j).text(textYear);
                                });
                            }, 50);
                        },
                        onClose: function () {
                            if (dateBefore == null) {
                                dateBefore = $(this).val();
                            }
                            if ($(this).val() != "" && $(this).val() == dateBefore) {
                                var arrayDate = dateBefore.split("-");
                                arrayDate[2] = parseInt(arrayDate[2]) + 543;
                                $(this).val(arrayDate[0] + "-" + arrayDate[1] + "-" + arrayDate[2]);
                            }
                        },
                        onSelect: function (dateText, inst) {
                            dateBefore = $(this).val();
                            var arrayDate = dateText.split("-");
                            arrayDate[2] = parseInt(arrayDate[2]) + 543;
                            $(this).val(arrayDate[0] + "-" + arrayDate[1] + "-" + arrayDate[2]);
                        }
                    });
                });
            });
        
  </script>
    <style type="text/CSS">
        .ui-datepicker{  
        font-family:tahoma;  
        text-align:center;
        color:dodgerblue;
        }  
        .multext{
            resize:none;
        }
         .a1{
            border-radius:20px;
            padding:5px 10px;
            background-color:#00ff21;
            text-decoration:none;
            color:black;
        }
         body {
            background-image: url("Image/444.png");
        }
        .tb5 {
            background-image: url(images/form_bg.jpg);
            background-repeat: repeat-x;
            border: 1px solid #d1c7ac;
            width: 230px;
            color: #333333;
            padding: 3px;
            margin-right: 4px;
            margin-bottom: 8px;
            font-family: tahoma, arial, sans-serif;
            border-radius: 10px;
            resize: none;
        }
        .textred{
            color:red;
        }
    </style>
    <asp:Panel runat="server" CssClass="divpan" Height="1200px" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson" >
    <div>

        <fieldset>
            <legend style="margin-left: auto; margin-right: auto; text-align: center;">เพิ่มข้อมูลบุคลากร</legend>
            <div>
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
               <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">กระทรวง</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กรม</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownMinistry" runat="server" CssClass="tb5" Width="432px"></asp:DropDownList></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDepart" runat="server" MaxLength="13" Width="425px" CssClass="tb5">มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก</asp:TextBox>
                            <!--<asp:DropDownList ID="DropDownDepart" runat="server" CssClass="tb5" Width="432px"></asp:DropDownList>-->
                        </td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">คำนำหน้านาม</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">เลขบัตรประจำตัวประชาชน</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownTitle" runat="server" CssClass="tb5" Width="432px"></asp:DropDownList></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtCitizen" runat="server" MaxLength="13" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ชื่อ</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ชื่อบิดา</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtFatherName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">นามสกุล</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลบิดา</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtFatherLastName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วัน เดือน ปีเกิด (dd-mm-yyyy)</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ชื่อมารดา</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtBirthDayNumber" runat="server" MaxLength="10" Width="425px" CssClass="tb5" OnTextChanged="txtBirthDayNumber_TextChanged" AutoPostBack="True"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtBirthDayNumber" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMotherName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วัน เดือน ปีเกิด (ตัวบรรจง เต็มบรรทัด)</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลมารดา</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">

                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtBirthDayChar" runat="server" MaxLength="100" Width="425px" CssClass="tb5" AutoPostBack="True" onkeyup="RefreshUpdatePanel();"></asp:TextBox>
                                   </ContentTemplate>
                            </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMotherLastName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วันที่บรรจุ (dd-mm-yyyy)</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลมารดาเดิม</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDateInWork" runat="server" MaxLength="10" Width="425px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMotherLastNameOld" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ประเภทข้าราชการ</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ชื่อคู่สมรส</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownStaffType" runat="server" CssClass="tb5" Width="432px"></asp:DropDownList></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMarriedName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วันครบเกษียณอายุ (dd-mm-yyyy)</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลคู่สมรส</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtAge60Number" runat="server" MaxLength="10" Width="425px" CssClass="tb5" OnTextChanged="txtAge60Number_TextChanged" AutoPostBack="True" CausesValidation="False"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtAge60Number" />
                                  </Triggers>
                             </asp:UpdatePanel>
                         </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMarriedLastName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                 <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วันครบเกษียณอายุ (ตัวบรรจง เต็มบรรทัด)</td>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลเดิมคู่สมรสเดิม</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtAge60Char" runat="server" MaxLength="100" Width="425px" CssClass="tb5" AutoPostBack="True"></asp:TextBox>
                                   </ContentTemplate>
                            </asp:UpdatePanel>
                         </td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMarriedLastNameOld" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                          <tr>
                            <td style="text-align: left; width:350px; height:50px;"> </td> 
                            <td style="text-align: left; width: 50px;"> 
                            <asp:Button ID="btnCancelPerson" Text="Cancel" runat="server" OnClick="btnCancelPerson_Click" Width="140px" CssClass="master_OAT_button" /></td>
                            <td style="text-align: left; width: 50px;"> </td> 
                            <td style="text-align: right; margin-right: 5px; ">  
                            <asp:Button ID="btnSubmitPerson" Text="OK" runat="server" OnClick="btnSubmitPerson_Click" Width="140px" CssClass="master_OAT_button" /></td>
                           </tr>               
                </table>
  
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                    <ProgressTemplate>
                        <div id="ajaxloader">
                            Loading..</div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
                    <ProgressTemplate>
                        <div id="ajaxloader">
                            Loading..</div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="UpdatePanel3">
                    <ProgressTemplate>
                        <div id="ajaxloader">
                            Loading..</div>
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel4">
                    <ProgressTemplate>
                        <div id="ajaxloader">
                            Loading..</div>
                    </ProgressTemplate>
                </asp:UpdateProgress>

            </div>
        </fieldset>
    </div>
        </asp:Panel>
</asp:Content>