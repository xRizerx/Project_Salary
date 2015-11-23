<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote2-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.insignia_recordnote2_ADMIN" %>
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
	        width: 130px;
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
<asp:Panel ID="Panel1" runat="server" Height="70px" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSearchNATIONAL">
    <div>
        <fieldset>
            <legend>Search</legend>
            <div>
                รหัสบัตรประชาชน :&nbsp<asp:TextBox ID="txtSearchNationENG" runat="server" CssClass="tb5" Width="150px" MaxLength="100"></asp:TextBox>
                ชื่อ :&nbsp<asp:TextBox ID="txtSearchNationID" runat="server" CssClass="tb5" Width="100px" MaxLength="100"></asp:TextBox>
                นามสกุล :&nbsp<asp:TextBox ID="TextBox1" runat="server" CssClass="tb5" Width="100px" MaxLength="100"></asp:TextBox>
                วันที่เริ่มบรรจุ :&nbsp<asp:TextBox ID="txtSearchNationTHA" runat="server" CssClass="tb5" Width="150px" MaxLength="100"></asp:TextBox>
                <asp:Button ID="btnSearchNATIONAL" Text="Search" runat="server" CssClass="master_OAT_button" OnClick="btnSearchNATIONAL_Click" />
                <asp:Button ID="btnSearchRefresh" Text="Refresh" runat="server" CssClass="master_OAT_button" OnClick="btnSearchRefresh_Click" />
            </div>
        </fieldset>
    </div>
      </asp:Panel>
<asp:Panel ID="Panel2" runat="server" ScrollBars="Horizontal" CssClass="divpan" BackColor="White" ForeColor="#6699FF" BorderColor="Aqua" DefaultButton="btnSubmitNATIONAL">
    <div>
        <fieldset>
            <legend>Insert</legend>
            <div>
                <table>
                    <tr>
                        <td style="text-align: left; width:100px">วัน/เดือน/ปี</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox12" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ตำแหน่ง</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="txtInsertNationENG" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ระดับ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="txtInsertNationTHA" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ได้รับ ชั้น/รายการ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox2" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">เล่ม</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox3" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ตอน</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox4" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">หน้า</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox5" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">วัน/เดือน/ปี</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox6" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ได้รับ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox7" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ไม่ได้รับ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox8" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ได้รับ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox9" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">ไม่ได้รับ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox10" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>
                        <td style="text-align: left; width:100px">หมายเหตุ</td>
                        <td style="text-align: left; width: 50px;"><asp:TextBox ID="TextBox11" runat="server" CssClass="tb5" MaxLength="100" Width="150px"></asp:TextBox></td>

                        <td style="text-align: left;"><asp:Button ID="btnSubmitNATIONAL" Text="OK" runat="server" CssClass="master_OAT_button" OnClick = "btnSubmitNATIONAL_Click" /></td>
                        <td style="text-align: left;"><asp:Button ID="btnCancelNATIONAL" Text="Cancel" runat="server" CssClass="master_OAT_button" OnClick = "btnCancelNATIONAL_Click" /></td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </div>
    <div>
        <fieldset >
            <legend>Data</legend>
            <asp:GridView ID="GridView1" runat="server" style="margin-left: auto; margin-right: auto; text-align: left;"
                AutoGenerateColumns="false"
                AllowPaging="true"
                DataKeyNames="ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridView1_PageIndexChanging" PageSize="15" BackColor="White" BorderColor="#999999">
                <Columns>
                    <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CITIZEN_ID" Visible="false">
                            <ItemTemplate>
                            <asp:Label ID="lblCITIZEN_ID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.CITIZEN_ID") %>'></asp:Label>
                            </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="วัน/เดือน/ปี" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl0" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DATE") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt0" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DATE") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ตำแหน่ง" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_WORK_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt1" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_WORK_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ระดับ" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt2" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.POSITION_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ได้รับ ชั้น/รายการ" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GRADEINSIGNIA_NAME") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt3" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GRADEINSIGNIA_NAME") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="เล่ม" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_LAM") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt4" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_LAM") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ตอน" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl5" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_TON") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt5" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_TON") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="หน้า" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl6" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_NA") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt6" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_NA") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="วัน/เดือน/ปี" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl7" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_DATE") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt7" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.GAZETTE_DATE") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ใบกำกับ" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl8" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.INVOICE") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt8" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.INVOICE") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="เหรียญตรา" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl10" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DECORATION") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt10" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.DECORATION") %>'></asp:TextBox>
                        		    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="หมายเหตุ" ControlStyle-Width="80" HeaderStyle-BackColor="#0099FF" HeaderStyle-ForeColor="Aqua">
                            <ItemTemplate>
                            <asp:Label ID="lbl12" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.NOTES") %>'></asp:Label>
                            </ItemTemplate>
                                    <EditItemTemplate>
                            		<asp:TextBox ID="txt12" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.NOTES") %>'></asp:TextBox>
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