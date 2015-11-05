<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Year-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Year_ADMIN" %>
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

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Height="600px" CssClass="divpan">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                ปีการศึกษา :&nbsp<asp:TextBox ID="txtSearchTH" runat="server" Width="100px" MaxLength="4"></asp:TextBox>
                <asp:Button ID="btnSearchTitleName" Text="Search" runat="server" OnClick="btnSearchYear_Click" />
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; width: 350px;"></td>
                        <td style="margin-left: auto; margin-right: auto; text-align: center">ปีการศึกษา :&nbsp;</td>
                        <td style="text-align: left; width: 120px;"><asp:TextBox ID="txtYearName" runat="server" MaxLength="4"></asp:TextBox></td>
                        <td style="text-align: left;"><asp:Button ID="btnSubmitYEAR" Text="OK" runat="server" OnClick = "btnSubmitYEAR_Click" /></td>
                        <td style="text-align: left;"><asp:Button ID="btnCancelYEAR" Text="Cancel" runat="server" OnClick = "btnCancelYEAR_Click" /></td>
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
                DataKeyNames="YEAR_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewYEAR_PageIndexChanging" PageSize="15">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblYearID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.Year_ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ปีการศึกษา" ControlStyle-Width="223">
                            <ItemTemplate>
                            <asp:Label ID="lblYearNameEdit" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.YEAR_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtYearNameEdit" MaxLength="4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.YEAR_NAME") %>'></asp:TextBox>
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
