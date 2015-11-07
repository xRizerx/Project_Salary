<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Gender-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Gender_ADMIN" %>
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
	        width: 230px;
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
<asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Height="600px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                ชื่อเพศ :&nbsp<asp:TextBox ID="txtSearchGenderName" runat="server" CssClass="tb5" Width="230px" MaxLength="20"></asp:TextBox>
                <asp:Button ID="btnSearchGender" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="btnSearchGender_Click" />
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; width:140px"></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">รหัสเพศ :</td>
                        <td style="text-align: left; width: 120px;"><asp:TextBox ID="txtInsertGenderID" runat="server" CssClass="tb5" MaxLength="4"></asp:TextBox></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">ชื่อเพศ :</td>
                        <td style="text-align: left; width: 120px;"><asp:TextBox ID="txtInsertGenderName" runat="server" CssClass="tb5" MaxLength="20"></asp:TextBox></td>
                        <td style="text-align: left;"><asp:Button ID="btnSubmitGender" Text="OK" runat="server" CssClass="master_OAT_button" OnClick = "btnSubmitGender_Click" /></td>
                        <td style="text-align: left;"><asp:Button ID="btnCancelGender" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick = "btnCancelGender_Click" /></td>
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
                DataKeyNames="GENDER_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewGENDER_PageIndexChanging" PageSize="15" BackColor="White" BorderColor="#999999">
                <Columns>
                    <asp:TemplateField HeaderText="รหัสเพศ" ControlStyle-Width="230" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblGenderIDEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GENDER_ID") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtGenderIDEdit" MaxLength="4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GENDER_ID") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ชื่อเพศ" ControlStyle-Width="600" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblGenderNameEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GENDER_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtGenderNameEdit" MaxLength="20" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GENDER_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua"/>
                    <asp:CommandField ShowDeleteButton="True" HeaderText="ลบ" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua"/>
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>
  </asp:Panel>
</asp:Content>
