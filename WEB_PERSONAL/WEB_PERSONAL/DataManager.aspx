<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DataManager.aspx.cs" Inherits="WEB_PERSONAL.DataManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .wrapper {
            width: 1024px;
        }

        .main {
            padding: 20px;
        }
        .link_list {
            padding: 20px;
            border: 1px solid #e0e0e0;
        }
        .link_list span {
            display: inline-block;
            color: #000000;
            font-size: 24px;
            font-weight: bold;
        }
        .link_list a {
            text-decoration: none;
            color: #000000;
            display: inline-block;
            padding: 0 20px;
            height: 50px;
            line-height: 50px;
            margin: 5px;
            background-color: #e0e0e0;
        }
        .link_list a:hover {
            background-color: #c0c0c0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
        <div class="link_list">
            <span>จัดการข้อมูล Drop-down List</span>
            <div style="height: 20px;"></div>
            <a href="Ministry-ADMIN.aspx">การจัดการข้อมูลกระทรวง </a>
            <a href="TitleName-ADMIN.aspx">การจัดการข้อมูลคำนำหน้านาม </a>
            <a href="StaffType-ADMIN.aspx">การจัดการข้อมูลประเภทข้าราชการ </a>
            <a href="Month-ADMIN.aspx">การจัดการข้อมูลเดือน </a>
            <a href="Year-ADMIN.aspx">การจัดการข้อมูลปี </a>
            <a href="Staff-ADMIN.aspx">การจัดการข้อมูลตำแหน่งประเภท </a>
            <a href="Gender-ADMIN.aspx">การจัดการข้อมูลเพศ </a>
            <a href="Province-ADMIN.aspx">การจัดการข้อมูลจังหวัด </a>
            <a href="Amphur-ADMIN.aspx">การจัดการข้อมูลอำเภอ </a>
            <a href="District-ADMIN.aspx">การจัดการข้อมูลตำบล </a>
            <a href="National-ADMIN.aspx">การจัดการข้อมูลสัญชาติ </a>
            <a href="TimeContact-ADMIN.aspx">การจัดการข้อมูลระยะเวลาจ้าง </a>
            <a href="Budget-ADMIN.aspx">การจัดการข้อมูลประเภทเงินจ้าง </a>
            <a href="SubStaffType-ADMIN.aspx">การจัดการข้อมูลประเภทบุคลากรย่อย </a>
            <a href="AdminPosition-ADMIN.aspx">การจัดการข้อมูลตำแหน่งบริหาร </a>
            <a href="PositionWork-ADMIN.aspx">การจัดการข้อมูลตำแหน่งในสายงาน </a>
            <a href="TeachISCED-ADMIN.aspx">การจัดการข้อมูลกลุ่มสาขาวิชาที่สอน </a>
            <a href="GradLev-ADMIN.aspx">การจัดการข้อมูลระดับการศึกษาที่จบการศึกษาสูงสุด </a>
            <a href="GradISCED-ADMIN.aspx">การจัดการข้อมูลกลุ่มสาขาวิชาที่จบสูงสุด </a>
            <a href="GradProgram-ADMIN.aspx">การจัดการข้อมูลสาขาวิชาที่จบการศึกษาสูงสุด </a>
            <a href="GradCountry-ADMIN.aspx">การจัดการข้อมูลประเทศที่จบการศึกษาสูงสุด </a>
            <a href="Campus-ADMIN.aspx">การจัดการข้อมูลวิทยาเขต </a>
            <a href="Faculty-ADMIN.aspx">การจัดการข้อมูลคณะ </a>
            
        </div>

    </div>
</asp:Content>
