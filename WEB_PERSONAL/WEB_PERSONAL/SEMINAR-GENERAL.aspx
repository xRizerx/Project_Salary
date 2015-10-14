<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_GENERAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 135px;
        }
        .auto-style2 {
            width: 96px;
        }

        .auto-style3 {
            width: 205px;
        }

        .auto-style4 {
            width: 267px;
        }

        .auto-style6 {
            width: 104px;
        }
        .auto-style7 {
            width: 265px;
        }

        .auto-style8 {
            width: 324px;
        }

    </style>
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style1">ชื่อ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txt1" runat="server" MaxLength="100" Width="148px"></asp:TextBox>
                        </td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">นามสกุล :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt2" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">ตำแหน่ง :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt3" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style6">ระดับ :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt4" runat="server" MaxLength="100" Width="148px"></asp:TextBox></td>
                    </tr>
                    </table>
                <table>
                    <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style2">สังกัด :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style3">
                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="100" Width="626px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style4">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
               </table>
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-styleพ">
                            <asp:TextBox ID="txt5" runat="server" MaxLength="100" Width="720px"></asp:TextBox></td>
                      </tr>
                </table>
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style7">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน :&nbsp;</td>
                        <td style="text-align: left; " class="auto-styleพ">
                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="100" Width="720px"></asp:TextBox></td>
                      </tr>
                </table>
                 <table>
                     <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style8">ระยะเวลาการฝึกอบรม/สัมมนา/ดูงาน ตั้งแต่วันที่</td>
                        <td style="text-align: left; " class="auto-styleพ">
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" Width="200px"></asp:TextBox></td>
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
