<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 303px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal">
        <div>
        <fieldset class="auto-style2">
            <legend>Search</legend>
            <div>
                ชื่อ :
                <asp:TextBox ID="txtSearchNameSeminar" runat="server"></asp:TextBox>
               
                <asp:Button ID="btnSearchNameSeminar" Text="Search" runat="server" OnClick="btnSearchNameSeminar_Click" />
            </div>
        </fieldset>
      </div>
      <div>
        <fieldset>
            <legend>Data </legend>
            <asp:GridView ID="GridView1" runat="server"
                AutoGenerateColumns="false"
                AllowPaging="true"
                DataKeyNames="SEMINAR_ID"
                OnRowEditing="modEditCommand"
                OnRowCancelingEdit="modCancelCommand"
                OnRowUpdating="modUpdateCommand"
                OnRowDeleting="modDeleteCommand"
                OnRowDataBound="GridView1_RowDataBound"
                OnPageIndexChanging="myGridViewSEMINARADMIN_PageIndexChanging" PageSize="10">
                <Columns>
                    	<asp:TemplateField HeaderText="ID" Visible="false">
                       		 <ItemTemplate>
                            		<asp:Label ID="lblSEMINAR_ID" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_ID") %>'></asp:Label>
                       		 </ItemTemplate>
                  	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="ชื่อ" ControlStyle-Width="120">
                        	 <ItemTemplate>
                            	 <asp:Label ID="lblSEMINAR_NAME" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAME") %>'></asp:Label>
                       		 </ItemTemplate>
                       			 <EditItemTemplate>
                           		 <asp:TextBox ID="txtName" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAME") %>'></asp:TextBox>
                        		 </EditItemTemplate>
                   	</asp:TemplateField>


                   	<asp:TemplateField HeaderText="นามสกุล" ControlStyle-Width="120">
                       		 <ItemTemplate>
                           	 <asp:Label ID="lblSEMINAR_LASTNAME" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_LASTNAME") %>'></asp:Label>
                       		 </ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtLastName" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_LASTNAME") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="ตำแหน่ง" ControlStyle-Width="120">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_POSITION" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_POSITION") %>'></asp:Label>
                      		</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtPosition" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_POSITION") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="ระดับ" ControlStyle-Width="120">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_DEGREE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DEGREE") %>'></asp:Label>
                       	 	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDegree" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DEGREE") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="สังกัด" ControlStyle-Width="120">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_CAMPUS" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CAMPUS") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtCampus" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CAMPUS") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>

                    	<asp:TemplateField HeaderText="ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_NAMEOFPROJECT" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAMEOFPROJECT") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtNameOfProject"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAMEOFPROJECT") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="สถานที่ฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_PLACE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PLACE") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtPlace"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PLACE") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="วันที่เริ่ม" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DATETIME_FROM" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_FROM") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDateFrom"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_FROM") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="วันที่สิ้นสุด" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DATETIME_TO" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_TO") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDateTO"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_TO") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : วัน " ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DAY" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DAY") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDay"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DAY") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : เดือน " ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_MONTH" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_MONTH") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtMonth"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_MONTH") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : ปี " ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ค่าใช้จ่ายตลอดโครงการ" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="แหล่งงบประมาณที่ได้รับการสนับสนุน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ประกาศนียบัตรที่ได้รับ" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="สรุปผลการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการเรียนการสอน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการวิจัย" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการบริการวิชาการ" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านอื่นๆ" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ปัญหาอุปสรรคในการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ความคิดเห็น/ข้อเสนอแนะอื่นๆ" ControlStyle-Width="120">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="140" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
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
