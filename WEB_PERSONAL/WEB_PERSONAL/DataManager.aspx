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
            <span>จัดการข้อมูลระบบ</span>
            <div style="height: 20px;"></div>
            <a href="AdminPosition-ADMIN.aspx">AdminPosition</a>
            <a href="Amphur-ADMIN.aspx">Amphur</a>
            <a href="Branch-ADMIN.aspx">Branch</a>
            <a href="Budget-ADMIN.aspx">Budget</a>
            <a href="Department-ADMIN.aspx">Department</a>
            <a href="District-ADMIN.aspx">District</a>
            <a href="Gender-ADMIN.aspx">Gender</a>
            <a href="GradCountry-ADMIN.aspx">GradCountry</a>
            <a href="GradISCED-ADMIN.aspx">GradISCED</a>
            <a href="GradLev-ADMIN.aspx">GradLev</a>
            <a href="GradProgram-ADMIN.aspx">GradProgram</a>
            <a href="Ministry-GENERAL.aspx">Ministry</a>
            <a href="Month-ADMIN.aspx">Month</a>
            <a href="National-ADMIN.aspx">National</a>
            <a href="Position-ADMIN.aspx">Position</a>
            <a href="PositionWork-ADMIN.aspx">PositionWork</a>
            <a href="Province-ADMIN.aspx">Province</a>
            <a href="PositionWork-ADMIN.aspx">PositionWork</a>
            <a href="Staff-ADMIN.aspx">Staff</a>
            <a href="StaffType-ADMIN.aspx">StaffType</a>
            <a href="SubStaffType-ADMIN.aspx">SubStaffType</a>
            <a href="TeachISCED-ADMIN.aspx">TeachISCED</a>
            <a href="TimeContact-ADMIN.aspx">TimeContact</a>
            <a href="TitleName-ADMIN.aspx">TitleName</a>
            <a href="UNIVERSITY-ADMIN.aspx">UNIVERSITY</a>
            <a href="Year-ADMIN.aspx">Year</a>
        </div>

    </div>
</asp:Content>
