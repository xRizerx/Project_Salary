<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TitleName-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.pre_title_name" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
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
	        width: 150px;
	        color:#333333;
	        padding:3px;
	        margin-right:4px;
	        margin-bottom:8px;
	        font-family:tahoma, arial, sans-serif;
            border-radius:10px;
            resize:none;
              }
            .tb6 {
	        background-repeat:repeat-x;
	        border:1px solid #d1c7ac;
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
<asp:Panel ID="Panel1" runat="server" Height="110px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSearchTitleName">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                ชื่อภาษาไทย :&nbsp<asp:TextBox ID="txtSearchTH" runat="server" CssClass="tb6" Width="90px"></asp:TextBox>
                ชื่อย่อภาษาไทย :&nbsp<asp:TextBox ID="txtSearchTHmin" runat="server" CssClass="tb6" Width="90px"></asp:TextBox>
               
            </div>
            <div>
                 ชื่อภาษาอังกฤษ :&nbsp<asp:TextBox ID="txtSearchEN" runat="server" CssClass="tb6" Width="90px"></asp:TextBox>
                ชื่อย่อภาษาอังกฤษ :&nbsp<asp:TextBox ID="txtSearchENmin" runat="server" CssClass="tb6" Width="90px"></asp:TextBox>
                <asp:Button ID="btnSearchTitleName" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="btnSearchTitleName_Click" />
                <asp:Button ID="btnSearchRefresh" Text="Refresh" runat="server" CssClass="master_OAT_button" OnClick="btnSearchRefresh_Click" />
            </div>
        </fieldset>
    </div>
    </asp:Panel>
<asp:Panel ID="Panel2" runat="server" ScrollBars="Horizontal" Height="600px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitPretitle">
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">ชื่อภาษาไทย :&nbsp;</td>
                        <td style="text-align: left; width: 120px;">
                            <asp:TextBox ID="txtTitleNameTh" runat="server" CssClass="tb5" MaxLength="6"></asp:TextBox>
                        </td>
                        <td style="text-align: left; width: 50px;"> </td> 
                        <td style="text-align: right; margin-right: 5px; ">ชื่อย่อภาษาไทย :&nbsp;</td>
                        <td style="text-align: left; ">
                            <asp:TextBox ID="txtTitleNameThMin" runat="server" CssClass="tb5" MaxLength="10"></asp:TextBox></td>  
                    </tr>
                    <tr>
                        <td style="text-align: left; width: 80px;"> </td> 
                        <td style="text-align: right; margin-right: 5px;">ชื่อภาษาอังกฤษ :&nbsp;</td>
                        <td style="text-align: left;">
                            <asp:TextBox ID="txtTitleNameEn" runat="server" CssClass="tb5"></asp:TextBox>
                        </td>
                        <td style="text-align: left; width: 50px;"> </td> 
                        <td style="text-align: right; margin-right: 5px;">ชื่อย่อภาษาอังกฤษ :&nbsp;</td>
                        <td style="text-align: left; "">
                            <asp:TextBox ID="txtTitleNameEnMin" runat="server" MaxLength="10" CssClass="tb5"></asp:TextBox></td>
                        <td style="text-align: right; margin-right: 5px;"></td>
                        <td style="text-align: left;">
                            <asp:Button ID="btnSubmitPretitle" Text="OK" runat="server" CssClass="master_OAT_button" OnClick = "btnSubmitPretitle_Click" /></td>
                        <td style="text-align: left;">
                            <asp:Button ID="btnCancelPretitle" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick = "btnCancelPretitle_Click" /></td>
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
                DataKeyNames="TITLE_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewPRETITLE_PageIndexChanging" PageSize="10" BackColor="White" BorderColor="#999999">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อภาษาไทย" ControlStyle-Width="210" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameTh" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameTh" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อย่อภาษไทย" ControlStyle-Width="210" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameThMin" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH_MIN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameThMin" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_TH_MIN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อภาษาอังกฤษ" ControlStyle-Width="210" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameEn" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameEn" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="ชื่อย่อภาษาอังกฤษ" ControlStyle-Width="210" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lblTitleNameEnMin" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN_MIN") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txtTitleNameEnMin" MaxLength="10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.TITLE_NAME_EN_MIN") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>


                    <asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua" />
                    <asp:CommandField ShowDeleteButton="True" HeaderText="ลบ" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua" />
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>
  </asp:Panel>
</asp:Content>
