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

    </style>
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style1">ชื่อ :&nbsp;</td>
                        <td style="text-align: left; width: 50px;">
                            <asp:TextBox ID="txt1" runat="server" MaxLength="12" Width="148px"></asp:TextBox>
                        </td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">นามสกุล :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt2" runat="server" MaxLength="12" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">ตำแหน่ง :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt3" runat="server" MaxLength="12" Width="148px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style2">ระดับ :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txt4" runat="server" MaxLength="12" Width="148px"></asp:TextBox></td>
                    </tr>
                    </table>
                <table>
                    <tr>
                       <td style="text-align: right; margin-right: 5px; " class="auto-style2">สังกัด :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style3">
                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="12" Width="558px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style4">มหาวิทยาลัยเทคโนยีราชมงคลตะวันออก</td>
                    </tr>
                </table>
                   <table>
                       <tr>
                           <td>
                            <asp:Button ID="btnSaveCustomer" Text="OK" runat="server" OnClick="btnSubmitCustomer_Click" />
                            <asp:Button ID="btnCancel" Text="Cancel" runat="server" OnClick="btnCancelCustomer_Click" />
                            <tr>
                           </td>
                        <td class="auto-style2"></td>
                        <td></td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </div>
    
</asp:Content>
