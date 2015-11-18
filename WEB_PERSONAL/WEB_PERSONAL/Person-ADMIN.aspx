<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Person-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Person_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script type="text/javascript">
        function pageLoad(sender , args) {
            $("#ContentPlaceHolder1_txtBirthDayNumber,#ContentPlaceHolder1_txtDateInWork,#ContentPlaceHolder1_txtAge60Number,#ContentPlaceHolder1_txtDateEnable11,#ContentPlaceHolder1_txtDate14").datepicker($.datepicker.regional["th"]); // Set ภาษาที่เรานิยามไว้ด้านบน
        };
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
        .divpan{
            text-align:center;
        }
        .auto-style3 {
            width: 266px;
        }
    </style>
    <asp:Panel runat="server" CssClass="divpan" Height="780px" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson" >
    <div>                          
        <fieldset>
            <legend style="margin-left: auto; margin-right: auto; text-align: center;">เพิ่มข้อมูลบุคลากร</legend>
            <div>
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
               <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">กระทรวง</td>
                        <td style="text-align: left; width: 30px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">กรม</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:DropDownList ID="DropDownMinistry" runat="server" CssClass="tb5" Width="432px"></asp:DropDownList></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtDepart" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox>
                        </td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">คำนำหน้านาม</td>
                        <td style="text-align: left; width: 30px;"> </td> 
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
                        <td style="text-align: left; width: 30px;"> </td> 
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
                        <td style="text-align: left; width: 30px;"> </td> 
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
                        <td style="text-align: left; width: 30px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">ชื่อมารดา</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 435px;">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtBirthDayNumber" runat="server" MaxLength="10" Width="400px" CssClass="tb5" OnTextChanged="txtBirthDayNumber_TextChanged" AutoPostBack="True"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtBirthDayNumber" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMotherName" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">วัน เดือน ปีเกิด (ตัวบรรจง เต็มบรรทัด)</td>
                        <td style="text-align: left; width: 30px;"> </td> 
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
                        <td style="text-align: left; width: 30px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลมารดาเดิม</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 435px;">
                            <asp:TextBox ID="txtDateInWork" runat="server" MaxLength="10" Width="400px" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: left; width: 10px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtMotherLastNameOld" runat="server" MaxLength="100" Width="425px" CssClass="tb5"></asp:TextBox></td>
                     </tr>
               </table>

                <table>
                   <tr>
                        <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; margin-right: 5px; ">ประเภทข้าราชการ</td>
                        <td style="text-align: left; width: 30px;"> </td> 
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
                        <td style="text-align: left; width: 30px;"> </td> 
                        <td style="text-align: left; margin-right: 5px; ">นามสกุลคู่สมรส</td>
                        
                   </tr>
                   <tr>
                         <td style="text-align: left; width: 30px;"> </td>
                        <td style="text-align: left; width: 435px;">
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtAge60Number" runat="server" MaxLength="10" Width="400px" CssClass="tb5" OnTextChanged="txtAge60Number_TextChanged" AutoPostBack="True" CausesValidation="False"></asp:TextBox>
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
                        <td style="text-align: left; width: 30px;"> </td> 
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

                </div>
        </fieldset>
    </div>
        </asp:Panel>
<asp:Panel ID="Panel2" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson">
    <div>
        <fieldset>
            <legend>ประวัติการศึกษา</legend>
            <div>
                <!-- FOR TABLE 3 ROW -->
                <table>
                   <tr>
                        <td style="text-align: center; margin-right: 5px; ">สถานศึกษา</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; width:500px">ตั้งแต่ - ถึง (เดือน ปี)</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; ">วุฒิ(สาาขาาวิชาเอก)</td>
                   </tr>
                   <tr>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatetxtGrad_Univ" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtGrad_Univ" runat="server" MaxLength="100" Width="290px" CssClass="tb5"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtGrad_Univ" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: left; ">
                            <asp:UpdatePanel ID="UpdateDropDownMonth10From" runat="server">
                                   <ContentTemplate>
                            <asp:DropDownList ID="DropDownMonth10From" runat="server" CssClass="tb5" Width="80px"></asp:DropDownList> <asp:DropDownList ID="DropDownYear10From" runat="server" CssClass="tb5" Width="65"></asp:DropDownList>
                            <asp:DropDownList ID="DropDownMonth10To" runat="server" CssClass="tb5" Width="80px"></asp:DropDownList> <asp:DropDownList ID="DropDownYear10To" runat="server" CssClass="tb5" Width="65px"></asp:DropDownList>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="DropDownMonth10From" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                           <asp:UpdatePanel ID="UpdatetxtMajor" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtMajor" runat="server" MaxLength="100" Width="290px" CssClass="tb5"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtMajor" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: right; margin-right: 5px; ">  
                            <asp:UpdatePanel ID="UpdateButtonPlus10" runat="server">
                                   <ContentTemplate>
                            <asp:Button ID="ButtonPlus10" Text="+" runat="server" Width="36px" CssClass="master_OAT_button" OnClick="ButtonPlus10_Click" />
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="ButtonPlus10" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                     </tr>
               </table>

                <asp:UpdatePanel ID="UpdateGridView1" runat="server">
                                   <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" Width="998px"></asp:GridView>
                                        </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="GridView1" />
                                  </Triggers>
                             </asp:UpdatePanel>
                
            </div>
        </fieldset>
    </div>
        </asp:Panel>
<asp:Panel ID="Panel3" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson">
    <div>
        <fieldset>
            <legend>ใบอนุญาตประกอบวิชาชีพ</legend>
            <div>
                    <table>
                   <tr>
                        <td style="text-align: center; margin-right: 5px; ">สถานศึกษา</td>
                        <td style="text-align: center; margin-right: 5px; ">หน่วยงาน</td>
                        <td style="text-align: center; margin-right: 5px; ">เลขที่ใบอนุญาต</td>
                        <td style="text-align: center; margin-right: 5px; ">วันที่มีผลบังคับใช้ (วัน เดือน ปี)</td>

                   </tr>
                   <tr>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatetxtGrad_Univ11" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtGrad_Univ11" runat="server" MaxLength="100" Width="290px" CssClass="tb5"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtGrad_Univ11" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatetxtDepart11" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtDepart11" runat="server" MaxLength="100" Width="250px" CssClass="tb5"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtDepart11" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: left; width: 170px;">
                           <asp:UpdatePanel ID="UpdatetxtNolicense11" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtNolicense11" runat="server" MaxLength="100" Width="155px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtNolicense11" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: left; width: 220px;">
                           <asp:UpdatePanel ID="UpdatetxtDateEnable11" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtDateEnable11" runat="server" MaxLength="100" Width="160" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtDateEnable11" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: right; margin-right: 5px; ">  
                           <asp:UpdatePanel ID="UpdateButtonPlus11" runat="server">
                                   <ContentTemplate>
                            <asp:Button ID="ButtonPlus11" Text="+" runat="server" Width="36px" CssClass="master_OAT_button" OnClick="ButtonPlus11_Click" />
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="ButtonPlus11" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            
                       </td>
                     </tr>
               </table>

                <asp:UpdatePanel ID="UpdateGridView2" runat="server">
                                   <ContentTemplate>
                <asp:GridView ID="GridView2" runat="server" Width="998px"></asp:GridView>
                                        </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="GridView2" />
                                  </Triggers>
                             </asp:UpdatePanel>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
<asp:Panel ID="Panel4" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson">
    <div>
        <fieldset>
            <legend>ประวัติการฝึกอบรม</legend>
            <div>
                <!-- FOR TABLE 3 ROW -->
                <table>
                   <tr>
                        <td style="text-align: center; margin-right: 5px; ">หลักสูตรฝึกอบรม</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; width:500px">ตั้งแต่ - ถึง (เดือน ปี)</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; ">หน่วยงานที่จัดฝึกอบรม</td>
                   </tr>
                   <tr>
                        <td style="text-align: left; width: 170px;">
                            <asp:UpdatePanel ID="UpdatetxtCourse" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtCourse" runat="server" MaxLength="100" Width="290px" CssClass="tb5"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtCourse" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: left; ">
                            <asp:UpdatePanel ID="UpdateDropDownMonth11From" runat="server">
                                   <ContentTemplate>
                            <asp:DropDownList ID="DropDownMonth12From" runat="server" CssClass="tb5" Width="80px"></asp:DropDownList> <asp:DropDownList ID="DropDownYear12From" runat="server" CssClass="tb5" Width="65"></asp:DropDownList>
                            <asp:DropDownList ID="DropDownMonth12To" runat="server" CssClass="tb5" Width="80px"></asp:DropDownList> <asp:DropDownList ID="DropDownYear12To" runat="server" CssClass="tb5" Width="65px"></asp:DropDownList>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="DropDownMonth12From" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                           <asp:UpdatePanel ID="UpdatetxtBranchTrainning" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtBranchTrainning" runat="server" MaxLength="100" Width="290px" CssClass="tb5"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtBranchTrainning" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: right; margin-right: 5px; ">  
                            <asp:UpdatePanel ID="UpdateButtonPlus12" runat="server">
                                   <ContentTemplate>
                            <asp:Button ID="ButtonPlus12" Text="+" runat="server" Width="36px" CssClass="master_OAT_button" OnClick="ButtonPlus12_Click" />
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="ButtonPlus12" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                     </tr>
               </table>

                <asp:UpdatePanel ID="UpdateGridView3" runat="server">
                                   <ContentTemplate>
                <asp:GridView ID="GridView3" runat="server" Width="998px"></asp:GridView>
                                        </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="GridView3" />
                                  </Triggers>
                             </asp:UpdatePanel>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
<asp:Panel ID="Panel5" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson">
    <div>
        <fieldset>
            <legend>การได้รับโทษทางวินัยและการนิรโทษกรรม</legend>
            <div>
                <!-- FOR TABLE 3 ROW -->
                <table>
                   <tr>
                        <td style="text-align: center; margin-right: 5px; ">พ.ศ.</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; width:500px">รายการ</td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: center; margin-right: 5px; ">เอกสารอ้างอิง</td>
                   </tr>
                   <tr>
                        <td style="text-align: left; width: 100px;">
                            <asp:UpdatePanel ID="UpdateDropDownYear13" runat="server">
                                   <ContentTemplate>
                                       <asp:DropDownList ID="DropDownYear13" runat="server" CssClass="tb5" Width="100px"></asp:DropDownList>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="DropDownYear13" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                        <td style="text-align: left; ">
                            <asp:UpdatePanel ID="UpdatetxtList13" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtList13" runat="server" MaxLength="100" Width="580px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtList13" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            </td>
                        <td style="text-align: left; width: 1px;"> </td> 
                       <td style="text-align: left; width: 170px;">
                           <asp:UpdatePanel ID="UpdatetxtRefDoc13" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtRefDoc13" runat="server" MaxLength="100" Width="220px" CssClass="tb5"></asp:TextBox>
                                       </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtRefDoc13" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: right; margin-right: 5px; ">  
                            <asp:UpdatePanel ID="UpdateButtonPlus13" runat="server">
                                   <ContentTemplate>
                            <asp:Button ID="ButtonPlus13" Text="+" runat="server" Width="36px" CssClass="master_OAT_button" OnClick="ButtonPlus13_Click" />
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="ButtonPlus13" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                     </tr>
               </table>

                <asp:UpdatePanel ID="UpdateGridView4" runat="server">
                                   <ContentTemplate>
                <asp:GridView ID="GridView4" runat="server" Width="998px"></asp:GridView>
                                        </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="GridView4" />
                                  </Triggers>
                             </asp:UpdatePanel>
            </div>
        </fieldset>
    </div>
        </asp:Panel>
<asp:Panel ID="Panel6" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPerson">
    <div>
        <fieldset>
            <legend>ตำแหน่งและเงินเดือน</legend>
            <div>
                    <table>
                   <tr>
                        <td style="text-align: center; margin-right: 5px; " class="auto-style3">วัน เดือน ปี</td>
                        <td style="text-align: center; margin-right: 5px; ">ตำแหน่ง</td>
                        <td style="text-align: center; margin-right: 5px; ">เลขที่ตำแหน่ง</td>
                        <td style="text-align: center; margin-right: 5px; ">ตำแหน่งประเภท</td>
                        <td style="text-align: center; margin-right: 5px; ">ระดับ</td>
                        <td style="text-align: center; margin-right: 5px; ">เงินเดือน</td>
                        <td style="text-align: center; margin-right: 5px; ">เงินประจำตำแหน่ง</td>
                        <td style="text-align: center; margin-right: 5px; ">เอกสารอ้างอิง</td>

                   </tr>
                   <tr>
                        <td style="text-align: left; " class="auto-style3">
                            <asp:UpdatePanel ID="UpdatetxtDate14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtDate14" runat="server" MaxLength="50" Width="90px" CssClass="tb5"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtDate14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                        <td style="text-align: left; width: 50px;">
                            <asp:UpdatePanel ID="UpdatetxtPosition14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtPosition14" runat="server" MaxLength="100" Width="280" CssClass="tb5"></asp:TextBox>
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtPosition14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdatetxtNo_Position14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtNo_Position14" runat="server" MaxLength="100" Width="52px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtNo_Position14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                        <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdateDropDownType_Position14" runat="server">
                                   <ContentTemplate>
                            <asp:DropDownList ID="DropDownType_Position14" runat="server" CssClass="tb5" Width="57px" AutoPostBack="True" OnSelectedIndexChanged="DropDownType_Position14_SelectedIndexChanged"></asp:DropDownList>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="DropDownType_Position14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdatetxtDropDownDegree14" runat="server">
                                   <ContentTemplate>
                            <asp:DropDownList ID="DropDownDegree14" runat="server" CssClass="tb5" Width="57px"></asp:DropDownList>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="DropDownDegree14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                         <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdatetxtSalary14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtSalary14" runat="server" MaxLength="100" Width="52px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtSalary14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                         <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdatetxtSalaryForPosition14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtSalaryForPosition14" runat="server" MaxLength="100" Width="52px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtSalaryForPosition14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                         <td style="text-align: left; width: 50px;">
                           <asp:UpdatePanel ID="UpdatetxtRefDoc14" runat="server">
                                   <ContentTemplate>
                            <asp:TextBox ID="txtRefDoc14" runat="server" MaxLength="100" Width="170px" CssClass="tb5"></asp:TextBox>
                                    </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="txtRefDoc14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                                       </td>
                       <td style="text-align: right; margin-right: 5px; ">  
                           <asp:UpdatePanel ID="UpdateButtonPlus14" runat="server">
                                   <ContentTemplate>
                            <asp:Button ID="ButtonPlus14" Text="+" runat="server" Width="36px" CssClass="master_OAT_button" OnClick="ButtonPlus14_Click" />
                                   </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="ButtonPlus14" />
                                  </Triggers>
                             </asp:UpdatePanel>
                            
                       </td>
                     </tr>
               </table>

                <asp:UpdatePanel ID="UpdateGridView5" runat="server">
                                   <ContentTemplate>
                <asp:GridView ID="GridView5" runat="server" Width="998px"></asp:GridView>
                                        </ContentTemplate>
                                  <Triggers>
                                     <asp:AsyncPostBackTrigger ControlID="GridView5" />
                                  </Triggers>
                             </asp:UpdatePanel>

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

            </div>
        </fieldset>
    </div>
        </asp:Panel>
</asp:Content>