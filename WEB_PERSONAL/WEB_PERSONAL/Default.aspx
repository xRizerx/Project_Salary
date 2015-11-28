<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_PERSONAL.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

    <style type="text/css">
        .wrapper {
            width: auto;
            background-color: #202020;
        }

        .mp {
            background-color: #202020;
        }

        .c1 {
            padding: 20px;
            padding-bottom: 10px;
            background-color: #101010;
            margin: 0 auto;
            text-align: center;
        }

            .c1 img {
                height: 200px;
            }

        .div_sec {
            background-color: #202020;
            margin: 0;
        }

        .div_sec_in {
            background-color: rgba(128,128,128,0.6);
            padding: 10px 10px;
            padding-bottom: 0px;
            /*width: 80%;*/
            /*overflow-x: scroll;*/
        }

        .div_sec_in2 {
            width: 2500px;
        }

        .div_sec_in span {
            color: #FFFFFF;
            text-shadow: 1px 1px 1px #000000;
        }

        .div_sec img {
            height: 240px;
            padding: 0;
            margin: 0;
            box-shadow: #000000 0px 1px 10px;
        }

        #sec1 {
            background-color: #202020;
            /*background-image: url("Image/333.jpg");
            background-size: cover;
            background-repeat: no-repeat;*/
        }

        .para_group {
            padding-left: 100px;
        }
        .para {
            /*width: 1024px;
            margin: 0 auto;*/
            
            color: #FFFFFF;
        }
    </style>

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

            <div style="height: 50px;"></div>

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
                <div class="para">
                    <p>
                        VERSION ALPHA
                    </p>
                </div>

                <div class="para">
                    <p>
                        <strong>-= UPDATED 28 พ.ย. 2558 =-</strong>
                        <br />
                        <span style="display: inline-block; width: 20px"></span>- CHANGED TO DARK THEME
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- ADDED FADE IN
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- NEW MENU CONTENT DESIGN
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- UPDATED DEFAULT.ASPX
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- CHANGED FOOTER COLOR
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- MINOR IMPROVED AND BUG FIXED
                    <br />
                        <span style="display: inline-block; width: 20px"></span>- กูขัม
                    </p>
                </div>

                <div class="para">
                    <p>
                        c# is real
                    </p>
                </div>

                <div class="para">
                    <p>
                        wqeqpi qwope piepw oeiwqpeo ipwqo ieqpweipwoq iepqwoiwp owqi pwqoe iqpow iepqwe iqwpoe iqwpoeiw pqowiepoqi wqei pqoi pqeiqo wq qweipo wqiepoiqpwoe iwqpeo qiwpoe qwiep oqwie qpwoeiwqpo eiwqpo ei
                    </p>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
            </div>


            <div style="height: 50px"></div>

        </div>
    </div>
</asp:Content>
