<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SEMINAR-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.SEMINAR_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 303px;
        }
         .divpan{
            background-image: url("Image/sky.jpg");
            text-align:center;
        }
        .textmode {
            font-family: ths;
            font-size: 16px;
        }

        .textmodeb {
            font-family: thsb;
            font-size: 24px;
            padding: 20px;
        }

        .textmodebi {
            font-size: 20px;
        }

        .textmodei {
            font-family: thsi;
            font-size: 20px;
        }

        .pancen {
            text-align:center;
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
	        background-image:url(images/form_bg.jpg);
	        background-repeat:repeat-x;
	        border:1px solid #d1c7ac;
	        width: 230px;
	        color:#333333;
	        padding:3px;
	        margin-right:4px;
	        margin-bottom:8px;
	        font-family:tahoma, arial, sans-serif;
            border-radius:10px;
              }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Horizontal" Height="512px" CssClass="divpan">
        <div class="divover">
        <fieldset class="auto-style2">
            <legend>Search</legend>
            <div>
                ชื่อ :
                <asp:TextBox ID="txtSearchNameSeminar" runat="server" CssClass="tb5"></asp:TextBox>
               
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


                    	<asp:TemplateField HeaderText="ชื่อ" ControlStyle-Width="150">
                        	 <ItemTemplate>
                            	 <asp:Label ID="lblSEMINAR_NAME" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAME") %>'></asp:Label>
                       		 </ItemTemplate>
                       			 <EditItemTemplate>
                           		 <asp:TextBox ID="txtName" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAME") %>'></asp:TextBox>
                        		 </EditItemTemplate>
                   	</asp:TemplateField>


                   	<asp:TemplateField HeaderText="นามสกุล" ControlStyle-Width="150">
                       		 <ItemTemplate>
                           	 <asp:Label ID="lblSEMINAR_LASTNAME" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_LASTNAME") %>'></asp:Label>
                       		 </ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtLastName" MaxLength="150" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_LASTNAME") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="ตำแหน่ง" ControlStyle-Width="150">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_POSITION" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_POSITION") %>'></asp:Label>
                      		</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtPosition" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_POSITION") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="ระดับ" ControlStyle-Width="150">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_DEGREE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DEGREE") %>'></asp:Label>
                       	 	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDegree" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DEGREE") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>


                    	<asp:TemplateField HeaderText="สังกัด" ControlStyle-Width="150">
                        	<ItemTemplate>
                            	<asp:Label ID="lblSEMINAR_CAMPUS" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CAMPUS") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtCampus" MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CAMPUS") %>'></asp:TextBox>
                        		</EditItemTemplate>
                    	</asp:TemplateField>

                    	<asp:TemplateField HeaderText="ชื่อโครงการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="300">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_NAMEOFPROJECT" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAMEOFPROJECT") %>'></asp:Label>
                        	</ItemTemplate> 
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtNameOfProject"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_NAMEOFPROJECT") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="สถานที่ฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="300">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_PLACE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PLACE") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtPlace"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PLACE") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="วันที่เริ่ม" ControlStyle-Width="180">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DATETIME_FROM" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_FROM","{0:dd/MM/yyyy}") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDateFrom"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_FROM") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="วันที่สิ้นสุด" ControlStyle-Width="180">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DATETIME_TO" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_TO","{0:dd/MM/yyyy}") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDateTO"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DATETIME_TO") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : วัน " ControlStyle-Width="200">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_DAY" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DAY") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtDay"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_DAY") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : เดือน " ControlStyle-Width="200">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_MONTH" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_MONTH") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtMonth"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_MONTH") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                    <asp:TemplateField HeaderText="รวมระยะเวลา : ปี " ControlStyle-Width="200">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_YEAR" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtYear"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_YEAR") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ค่าใช้จ่ายตลอดโครงการ" ControlStyle-Width="200">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_BUDGET" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_BUDGET") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtBudget"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_BUDGET") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="แหล่งงบประมาณที่ได้รับการสนับสนุน" ControlStyle-Width="300">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_SUPPORT_BUDGET" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SUPPORT_BUDGET") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtSupportBudget"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SUPPORT_BUDGET") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ประกาศนียบัตรที่ได้รับ" ControlStyle-Width="300">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_CERTIFICATE" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CERTIFICATE") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtCertificate"  MaxLength="100" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_CERTIFICATE") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="สรุปผลการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_ABSTRACT" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_ABSTRACT") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtAbstract"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_ABSTRACT") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ผลที่ได้รับจากการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_RESULT" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_RESULT") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtResult"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_RESULT") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการเรียนการสอน" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_SHOW_1" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_1") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtShow1"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_1") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการวิจัย" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_SHOW_2" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_2") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtShow2"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_2") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านการบริการวิชาการ" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_SHOW_3" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_3") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtShow3"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_3") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ด้านอื่นๆ" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_SHOW_4" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_4") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtShow4"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SHOW_4") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ปัญหาอุปสรรคในการฝึกอบรม/สัมมนา/ดูงาน" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_PROBLEM" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PROBLEM") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtProblem"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_PROBLEM") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>


                    <asp:TemplateField HeaderText="ความคิดเห็น/ข้อเสนอแนะอื่นๆ" ControlStyle-Width="400">
                        	<ItemTemplate>
                           	<asp:Label ID="lblSEMINAR_COMMENT" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_COMMENT") %>'></asp:Label>
                        	</ItemTemplate>
                        		<EditItemTemplate>
                            		<asp:TextBox ID="txtComment"  MaxLength="1000" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_COMMENT") %>'></asp:TextBox>
                        		</EditItemTemplate>
                   	 </asp:TemplateField>

                        <asp:TemplateField HeaderText="วันที่กรอกฟรอม" Visible="True" ControlStyle-Width="200">
                       		 <ItemTemplate>
                            		<asp:Label ID="lblSEMINAR_SIGNED_DATETIME" runat="server" Text='<%# DataBinder.Eval(Container, "DataItem.SEMINAR_SIGNED_DATETIME") %>'></asp:Label>
                       		 </ItemTemplate>
                  	    </asp:TemplateField>

                    	<asp:CommandField ShowEditButton="True" CancelText="Cancel" DeleteText="Delete" EditText="Edit" UpdateText="Update" HeaderText="แก้ไข" />
                    	<asp:CommandField ShowDeleteButton="True" HeaderText="ลบ" />
                </Columns>
            </asp:GridView>

        </fieldset>
    </div>
           
    </asp:Panel>
</asp:Content>
