<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEB_PERSONAL.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .wrapper {
            width: unset;
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

        .t1 {
            font-size: 32px;
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
            /*background-color: rgba(128,128,128,0.6);*/
            padding: 20px 0px;
        }
        .div_sec_in span {
            color: #FFFFFF;
            text-shadow: 1px 1px 1px #000000;
        }
        .div_sec img {
            height: 320px;
            padding: 0;
            margin: 0;
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
    <div class="mp">

        <div>
            <asp:Label ID="Label1" runat="server" Text="ทดสอบหน้าหลัก อิอิ" CssClass="t1"></asp:Label>
        </div>

        <div style="height:50px"></div>

        <div class="para">
            <p>
                wqeqpi qwope piepw oeiwqpeo ipwqo ieqpweipwoq iepqwoiwp owqi pwqoe iqpow iepqwe iqwpoe iqwpoeiw pqowiepoqi wqei pqoi pqeiqo wq qweipo wqiepoiqpwoe iwqpeo qiwpoe qwiep oqwie qpwoeiwqpo eiwqpo ei
            </p>
        </div>

        <div class="div_sec" id="sec1">
            <div class="div_sec_in">
                <img src="Image/i1.jpg"/>
                <img src="Image/i2.jpg"/>
                <img src="Image/i3.jpg"/>
            </div>
        </div>

        <div style="height:100px"></div>
   

    </div>
</asp:Content>
