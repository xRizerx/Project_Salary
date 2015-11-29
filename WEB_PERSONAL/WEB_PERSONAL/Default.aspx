<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_PERSONAL.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Default.css" rel="stylesheet" />
    <script>
        (function ($) {
            $(window).load(function () {
                $(".div_sec_in").mCustomScrollbar({
                    axis: "x",
                    theme: "white-thin",
                    //theme: "minimal-dark",
                    autoExpandScrollbar: true,
                    advanced: { autoExpandHorizontalScroll: true }
                });
            });
        })(jQuery);
    </script>

    

    <script>
        /*$(".div_sec_in2").ready(function () {
            alert('dsd');
            var container_width = SINGLE_IMAGE_WIDTH * $(".div_sec_in2 img").length;
            
            alert(container_width);
            $(".div_sec_in2").css("width", container_width);
        });*/

    </script>

    <div class="mp">
        <div class="mp2">

            <!--div style="height: 50px;"></!--div-->

            <!--div class="div_sec" id="sec1">
                <div class="div_sec_in">
                    <div class="div_sec_in2">
                        <img src="Image/i1.jpg" />
                        <img src="Image/i2.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                        <img src="Image/i3.jpg" />
                    </div>

                </div>
            </!--div-->

            <asp:Panel ID="Panel1" runat="server" CssClass="c1">
                <img src="Image/i1.jpg" />
                <img src="Image/i2.jpg" />
                <img src="Image/i3.jpg" />
            </asp:Panel>


            <div class="para_group">
                <div class="para_center">
                    <asp:Label ID="Label2" runat="server" Text="ระบบบุคลากร (Personnel System)" style="font-size: 24px; font-weight: bold;"></asp:Label>
                    <br />
                    <p style="font-size: 24px; font-weight: bold;">
                        
                    </p>
                </div>

                <span style="font-size: 24px; font-weight: bold; color: #FFFFFF; margin-left: 100px">ประกาศ</span>

                <div id="div_announce" runat="server">
                    
                </div>

                <div class="dpl_7c" style="height: 1px; margin: 20px 100px;">

                </div>

                <span style="font-size: 24px; font-weight: bold; color: #FFFFFF; margin-left: 100px">การอัพเดท</span>

                <div id="div_update_history" runat="server">

                </div>

                

                
            </div>


            <div style="height: 50px"></div>

        </div>
    </div>
</asp:Content>
