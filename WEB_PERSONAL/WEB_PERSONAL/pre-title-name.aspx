<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="pre-title-name.aspx.cs" Inherits="WEB_PERSONAL.pre_title_name" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 102px;
        }
        .auto-style2 {
            width: 107px;
        }
        .auto-style3 {
            width: 270px;
        }
        .auto-style6 {
            width: 6px;
        }
           .auto-style7 {
            width: 1036px;
        }
         .auto-style8 {
             width: 38px;
         }
         .auto-style9 {
             width: 195px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 

    <div>
        <fieldset class="auto-style7">
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style3">ชื่อภาษาไทย :&nbsp;</td>
                        <td style="text-align: left; width: 120px;">
                            <asp:TextBox ID="txtTitleNameTh" runat="server" MaxLength="6"></asp:TextBox>
                        </td>
                        <td style="text-align: right; margin-right: 5px; " class="auto-style9">ชื่อย่อภาษาไทย :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style2">
                            <asp:TextBox ID="txtTitleNameThMin" runat="server" MaxLength="10"></asp:TextBox></td>
                       
                        
                    </tr>
                    <tr>
                        <td style="text-align: right; margin-right: 5px;" class="auto-style3">ชื่อภาษาอังกฤษ :&nbsp;</td>
                        <td style="text-align: left;" class="auto-style1">
                            <asp:TextBox ID="txtTitleNameEn" runat="server"></asp:TextBox>
                        </td>
                        <td style="text-align: right; margin-right: 5px;" class="auto-style9">ชื่อย่อภาษาอังกฤษ :&nbsp;</td>
                        <td style="text-align: left; " class="auto-style2">
                            <asp:TextBox ID="txtTitleNameEnMin" runat="server" MaxLength="10"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px;" class="auto-style6"></td>
                        <td style="text-align: left;" class="auto-style8">
                            <asp:Button ID="btnSubmitPretitle" Text="OK" runat="server" OnClick = "btnSubmitPretitle_Click" /></td>
                        <td style="text-align: left;" class="auto-style1">
                            <asp:Button ID="btnCancelPretitle" Text="Cancel" runat="server" OnClick = "btnCancelPretitle_Click" /></td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset>
            <legend>Data </legend>
            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="false"
                AllowPaging="true"
                DataKeyNames="TITLE_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewPRETITLE_PageIndexChanging" PageSize="10">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อภาษาไทย" ControlStyle-Width="230">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameTh" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameTh" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อย่อภาษไทย" ControlStyle-Width="230">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameThMin" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH_MIN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameThMin" MaxLength="8" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH_MIN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อภาษาอังกฤษ" ControlStyle-Width="230">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameEn" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameEn" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อย่อภาษาอังกฤษ" ControlStyle-Width="230">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameEnMin" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN_MIN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameEnMin" MaxLength="8" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN_MIN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="Modify" />
                    <asp:CommandField ShowDeleteButton="True" HeaderText="Delete" />
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>

</asp:Content>
