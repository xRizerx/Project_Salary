<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SubStaffType-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.SubStaffType_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .divpan {
            background-image: url("Image/sky.jpg");
            text-align: center;
        }
        .panin{
            border:1px solid black;
            margin: 20px;
            background-color:rgba(255,255,255,0.6);
            border-radius: 5px;
        }
         body {
            background-image: url("Image/444.jpg");
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
<asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Height="600px" CssClass="divpan">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                ประเภทบุคลากรย่อย :&nbsp<asp:TextBox ID="txtSearchSubStaffTypeName" runat="server" CssClass="tb5" Width="230px" MaxLength="100"></asp:TextBox>
                <asp:Button ID="btnSearchSubStaffType" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="SearchSubStaffType_Click" />
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; width:263px"></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">ประเภทบุคลากรย่อย :</td>
                        <td style="text-align: left; width: 120px;"><asp:TextBox ID="txtInsertSubStaffTypeName" runat="server" CssClass="tb5" MaxLength="100"></asp:TextBox></td>
                        <td style="text-align: left;"><asp:Button ID="btnSubmitSubStaffType" Text="OK" runat="server" CssClass="master_OAT_button" OnClick = "btnSubmitSubStaffType_Click" /></td>
                        <td style="text-align: left;"><asp:Button ID="btnCancelSubStaffType" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick = "btnCancelSubStaffType_Click" /></td>
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
                DataKeyNames="SUBSTAFFTYPE_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewSubStaffType_PageIndexChanging" PageSize="15">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblSubStaffTypeID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SUBSTAFFTYPE_ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ประเภทบุคลากรย่อย" ControlStyle-Width="700">
                            <ItemTemplate>
                            <asp:Label ID="lblSubStaffTypeNameEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SUBSTAFFTYPE_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtSubStaffTypeNameEdit" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SUBSTAFFTYPE_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" />
                    <asp:CommandField ShowDeleteButton="True" HeaderText="ลบ" />
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>
  </asp:Panel>
</asp:Content>
