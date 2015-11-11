﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Position-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Position_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .divpan {

            text-align: center;
        }
        .panin{
            border:1px solid black;
            margin: 20px;
            background-color:rgba(255,255,255,0.6);
            border-radius: 5px;
        }
         body {
            background-image: url("Image/444.png");
        }
         .tb5 {
	        background-repeat:repeat-x;
	        border:1px solid #d1c7ac;
	        width: 100px;
	        color:#333333;
	        padding:3px;
	        margin-right:4px;
	        margin-bottom:8px;
	        font-family:tahoma, arial, sans-serif;
            border-radius:10px;
            resize:none;
              }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server" Height="70px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSearchPosition">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                รหัสตำแหน่งทางวิชาการ :&nbsp<asp:TextBox ID="txtSearchPositionID" runat="server" CssClass="tb5" Width="100px" MaxLength="4"></asp:TextBox>
                ชื่อตำแหน่งทางวิชาการ  :&nbsp<asp:TextBox ID="txtSearchPositionName" runat="server" CssClass="tb5" Width="100px" MaxLength="100"></asp:TextBox>
                รหัสประเภทบุคลากรย่อย  :&nbsp<asp:TextBox ID="txtSearchSubStaffName" runat="server" CssClass="tb5" Width="100px" MaxLength="4"></asp:TextBox>
                <asp:Button ID="btnSearchPosition" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="btnSearchPosition_Click" />
                <asp:Button ID="btnSearchRefresh" Text="Refresh" runat="server" CssClass="master_OAT_button" OnClick="btnSearchRefresh_Click" />
            </div>
        </fieldset>
    </div>
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server" ScrollBars="Horizontal" Height="600px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPosition">
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">รหัสตำแหน่งทางวิชาการ :</td>
                        <td style="text-align: left; width: 80px;"><asp:TextBox ID="txtInsertPositionID" runat="server" CssClass="tb5" MaxLength="4"></asp:TextBox></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">ชื่อตำแหน่งทางวิชาการ :</td>
                        <td style="text-align: left; width: 80px;"><asp:TextBox ID="txtInsertPositionName" runat="server" CssClass="tb5" MaxLength="100"></asp:TextBox></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">รหัสประเภทบุคลากรย่อย :</td>
                        <td style="text-align: left; width: 80px;"><asp:TextBox ID="txtInsertSubStaffName" runat="server" CssClass="tb5" MaxLength="4"></asp:TextBox></td>
                        <td style="text-align: left;"><asp:Button ID="btnSubmitPosition" Text="OK" runat="server" CssClass="master_OAT_button" OnClick = "btnSubmitPosition_Click" /></td>
                        <td style="text-align: left;"><asp:Button ID="btnCancelPosition" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick = "btnCancelPosition_Click" /></td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset >
            <legend>Data</legend>
            <asp:GridView ID="GridView1" runat="server" style="margin-left: auto; margin-right: auto; text-align: center;"
                AutoGenerateColumns="false"
                AllowPaging="true"
                DataKeyNames="POSITION_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewPosition_PageIndexChanging" PageSize="15" BackColor="White" BorderColor="#999999">
                <Columns>
                    <asp:TemplateField HeaderText="รหัสตำแหน่งทางวิชาการ" ControlStyle-Width="230" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblPositionIDEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_ID") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtPositionIDEdit" MaxLength="4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_ID") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ชื่อตำแหน่งทางวิชาการ" ControlStyle-Width="320" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblPositionNameEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtPositionNameEdit" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="รหัสประเภทบุคลากรย่อย" ControlStyle-Width="320" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblSubStaffNameEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SUBSTAFFTYPE_ID") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtSubStaffNameEdit" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SUBSTAFFTYPE_ID") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua"/>
                    <asp:TemplateField HeaderText="ลบ" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                         <ItemTemplate>
                         <asp:ImageButton ID="DeleteButton" runat="server" ImageUrl="~/Image/x.png" CommandName="Delete" OnClientClick="return confirm('คุณต้องการที่จะลบจริงๆใช่ไหม ?');" AlternateText="Delete" />               
                    </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>
  </asp:Panel>
</asp:Content>