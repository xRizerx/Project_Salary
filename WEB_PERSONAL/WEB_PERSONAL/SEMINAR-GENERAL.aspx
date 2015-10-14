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
                            <asp:TextBox ID="txtPlace" runat="server" MaxLength="100" Width="720px"></asp:TextBox></td>
                      </tr>
                </table>       
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style8">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน&nbsp;&nbsp;&nbsp; </td>
                        <td style="text-align: left; " class="auto-style5">
                             ตั้งแต่วันที่
                            <asp:TextBox ID="txtDateFrom" runat="server" CssClass="auto-style9"></asp:TextBox>
                            ถึงวันที่
                              <asp:TextBox ID="txtDateTO" runat="server"></asp:TextBox></td>
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
