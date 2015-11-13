<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_PERSONAL.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
		(function($){
			$(window).load(function(){
			    $(".div_sec_in").mCustomScrollbar({
			        axis: "x",
			        theme: "white-thin",
			        autoExpandScrollbar: true,
			        advanced: { autoExpandHorizontalScroll: true }
			    });
			   
				
			});
		})(jQuery);
	</script>

    <style type="text/css">
        .wrapper {
            width: auto;
        }

        .c1 {
            height: 640px;
            margin: 0 auto;
            text-align: center;
            background-size: cover;
        }

        .c2 {
            width: 100%;
        }

        .mp {
            padding: 20px 0;
            text-align: center;
        }

        .i90p {
            width: 90%;
        }

        .i75p {
            width: 75%;
        }

        .i100p {
            width: 100%;
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
            width: 3500px;
        }

        .div_sec_in span {
            color: #FFFFFF;
            text-shadow: 1px 1px 1px #000000;
        }

        .div_sec img {
            height: 320px;
            padding: 0;
            margin: 0;
            box-shadow: #000000 0px 1px 10px;
        }

        #sec1 {
            background-color: #202020;
            background-image: url("Image/333.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        #sec2 {
            background-color: #404040;
        }

        #sec3 {
            background-color: #606060;
        }

        .para {
            width: 1024px;
            margin: 0 auto;
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


        <div style="height: 50px;"></div>

        <div class="div_sec" id="sec1">
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
        </div>

        <div class="para">
            <p>
                wqeqpi qwope piepw oeiwqpeo ipwqo ieqpweipwoq iepqwoiwp owqi pwqoe iqpow iepqwe iqwpoe iqwpoeiw pqowiepoqi wqei pqoi pqeiqo wq qweipo wqiepoiqpwoe iwqpeo qiwpoe qwiep oqwie qpwoeiwqpo eiwqpo ei
            </p>
        </div>

        <div style="height: 50px"></div>


    </div>
</asp:Content>
