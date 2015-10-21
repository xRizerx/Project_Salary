<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personnel-GENERAL.aspx.cs" Inherits="WEB_PERSONAL.Personnel_GENERAL" %>
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
              }
    </style>
    <asp:Panel ID="Panel1" runat="server" Height="1500px" CssClass="divpan">
   <div>
        <fieldset>
            <legend>เพิ่มข้อมูลบุคลากร</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; margin-right: 5px; ">รหัสประจำตัวประชาชน*</td>
                        <tr>
                             <td style="text-align: left; width: 100px;">
                            <asp:TextBox ID="txtName" runat="server" MaxLength="100" Width="200px" CssClass="tb5"></asp:TextBox>
                        </td>
                        </tr>
                       
                        <td style="text-align: left; width: 10px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">นามสกุล :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtLastName" runat="server" MaxLength="100" Width="200px"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px; ">ตำแหน่ง :&nbsp;</td>
                        <td style="text-align: left; width: 170px;">
                            <asp:TextBox ID="txtPosition" runat="server" MaxLength="100" Width="200px"></asp:TextBox></td>
                    </tr>
                    </table> 
            </div>
        </fieldset>
    </div>
        </asp:Panel>
    
</asp:Content>
