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

        <div class="master_light_page_header">
                    <asp:Label ID="Label2" runat="server" Text="ระบบบุคลากร (Personnel System)"></asp:Label>
                </div>

            <asp:Panel ID="Panel1" runat="server" CssClass="c1">
                <img src="Image/i1.jpg" />
                <img src="Image/i2.jpg" />
                <img src="Image/i3.jpg" />
                
            </asp:Panel>

            <div class="para_group">
                

                <span style="font-size: 32px; margin-left: 100px">ประกาศ</span>

                <div id="div_announce" runat="server">
                    
                </div>

                <div class="dpl_7c" style="height: 1px; margin: 20px 100px;">

                </div>
                    
            </div>


            <div style="height: 50px"></div>

    </div>
</asp:Content>
