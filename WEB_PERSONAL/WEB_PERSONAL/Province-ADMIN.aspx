﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Province-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Province_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .divpan {
            text-align: center;
        }

        .panin {
            border: 1px solid black;
            margin: 20px;
            background-color: rgba(255,255,255,0.6);
            border-radius: 5px;
        }

        body {
            background-image: url("Image/444.png");
        }

        .tb5 {
            background-repeat: repeat-x;
            border: 1px solid #d1c7ac;
            width: 130px;
            color: #333333;
            padding: 3px;
            margin-right: 4px;
            margin-bottom: 8px;
            font-family: tahoma, arial, sans-serif;
            border-radius: 10px;
            resize: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSearchProvince">
        <div>
            <fieldset>
                <legend>ค้นหาข้อมูล</legend>
                <div>
                    รหัสจังหวัด :&nbsp<asp:TextBox ID="txtSearchProvinceID" runat="server" CssClass="tb5" Width="50px" MaxLength="2"></asp:TextBox>
                    ชื่อจังหวัดภาษาไทย :&nbsp<asp:TextBox ID="txtSearchProvinceTH" runat="server" CssClass="tb5" Width="150px" MaxLength="100"></asp:TextBox>
                    ชื่อจังหวัดภาษาอังกฤษ :&nbsp<asp:TextBox ID="txtSearchProvinceEN" runat="server" CssClass="tb5" Width="150px" MaxLength="100"></asp:TextBox>
                    <asp:Button ID="btnSearchProvince" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="btnSearchProvince_Click" />
                    <asp:Button ID="btnSearchRefresh" Text="Refresh" runat="server" CssClass="master_OAT_button" OnClick="btnSearchRefresh_Click" />
                </div>
            </fieldset>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" ScrollBars="Horizontal" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitProvince">
        <div>
            <fieldset>
                <legend>เพิ่มข้อมูล</legend>
                <div>
                    <table>
                        <tr>
                            <td style="text-align: left; width: 60px"></td>
                            <td style="margin-left: auto; margin-right: auto; text-align: center">รหัสจังหวัด :</td>
                            <td style="text-align: left; width: 50px;">
                                <asp:TextBox ID="txtInsertProvinceID" runat="server" CssClass="tb5" MaxLength="2" Width="50px"></asp:TextBox></td>
                            <td style="margin-left: auto; margin-right: auto; text-align: center">ชื่อจังหวัดภาษาไทย :</td>
                            <td style="text-align: left; width: 90px;">
                                <asp:TextBox ID="txtInsertProvinceTH" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                            <td style="margin-left: auto; margin-right: auto; text-align: center">ชื่อจังหวัดภาษาอังกฤษ :</td>
                            <td style="text-align: left; width: 80px;">
                                <asp:TextBox ID="txtInsertProvinceEN" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                            <td style="text-align: left;">
                                <asp:Button ID="btnSubmitProvince" Text="OK" runat="server" CssClass="master_OAT_button" OnClick="btnSubmitProvince_Click" /></td>
                            <td style="text-align: left;">
                                <asp:Button ID="btnCancelProvince" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick="btnCancelProvince_Click" /></td>
                        </tr>
                    </table>
                </div>
            </fieldset>
        </div>
        <div>
            <fieldset>
                <legend>ข้อมูล</legend>
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:GridView ID="GridView1" runat="server" Style="margin-left: auto; margin-right: auto; text-align: center; width: 100%"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            DataKeyNames="PROVINCE_ID"
                            OnRowEditing="modEditCommand"
                            OnRowCancelingEdit="modCancelCommand"
                            OnRowUpdating="modUpdateCommand"
                            OnRowDeleting="modDeleteCommand"
                            OnRowDataBound="GridView1_RowDataBound"
                            OnPageIndexChanging="myGridViewProvince_PageIndexChanging" PageSize="15" BackColor="White" BorderColor="#999999">
                            <Columns>
                                <asp:TemplateField HeaderText="รหัสจังหวัด" ControlStyle-Width="120" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                                    <ItemTemplate>
                                        <asp:Label ID="lblProvinceIDEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_ID") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProvinceIDEdit" MaxLength="2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_ID") %>' Enabled="False"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ชื่อจังหวัดภาษาไทย" ControlStyle-Width="380" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                                    <ItemTemplate>
                                        <asp:Label ID="lblProvinceTHEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_TH") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProvinceTHEdit" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_TH") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ชื่อจังหวัดภาษาอังกฤษ" ControlStyle-Width="380" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                                    <ItemTemplate>
                                        <asp:Label ID="lblProvinceENEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_EN") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProvinceENEdit" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.PROVINCE_EN") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua" />
                                <asp:TemplateField HeaderText="ลบ" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="DeleteButton1" runat="server" CausesValidation="false" CommandName="Delete" Text="Delete"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Gridview1" />
                    </Triggers>
                </asp:UpdatePanel>
            </fieldset>
        </div>
    </asp:Panel>
</asp:Content>
