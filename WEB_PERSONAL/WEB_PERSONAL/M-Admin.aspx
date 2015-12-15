<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="M-Admin.aspx.cs" Inherits="WEB_PERSONAL.M_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 101px;
            text-align: right;
            vertical-align: top;
        }

        .wrapper {
        }

        .irc_mi {
            text-align: center;
        }

        .auto-style5 {
        }

        .auto-style6 {
            width: 101px;
            text-align: right;
            vertical-align: top;
            height: 162px;
        }

        .auto-style7 {
        }

        .auto-style8 {
            width: 100%;
        }

        .t1 {
            
        }

        .t1 td {
            vertical-align: top;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mp">
        <div class="master_light_page_header">
            ติดต่อผู้ดูแลระบบ
        </div>
        <table class="t1">
            <tr>
                <td class="auto-style8">

                    <div class="master_light_div_sec">
                        <div class="master_light_div_sec_title">
                            ข้อเสนอแนะ
                        </div>
                        <div class="master_light_div_sec_in">

                            <table style="width: 100%;">
                                <tr>
                                    <td class="auto-style6">
                                        <asp:Label ID="Label8" runat="server" Text="ข้อเสนอแนะ"></asp:Label>
                                    </td>
                                    <td class="auto-style7">
                                        <asp:TextBox ID="TextBox1" runat="server" Height="150px" TextMode="MultiLine" Width="500px" CssClass="master_light_textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">&nbsp;</td>
                                    <td class="auto-style5">
                                        <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_light_button" OnClick="LinkButton13_Click">ส่ง</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>

                        </div>
                    </div>



                </td>
                <td>
                    <div class="irc_mi">
                        <img src="http://202.143.129.110/assessment/images/Admin_Womenfund.jpg" width="304" height="328" />
                    </div>
                </td>
            </tr>
        </table>

        <div class="dpl_7c"></div>

    </div>



</asp:Content>
