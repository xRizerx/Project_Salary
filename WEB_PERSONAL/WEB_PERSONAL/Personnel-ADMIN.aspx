<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Personnel-ADMIN.aspx.cs" Inherits="WEB_PERSONAL.Personnel_ADMIN" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <asp:ScriptManager ID="ScriptManager1" runat="server">
   </asp:ScriptManager>
   <div>
       <asp:UpdatePanel ID="PROVINCEpanel" runat="server">
          <ContentTemplate >
              <span class="style1"><strong>เลือกจังหวัด:</strong></span>
             <asp:DropDownList ID="ddlPROVINCE" AutoPostBack ="true" AppendDataBoundItems
="true" runat="server" Height="20px" Width="156px"   
onselectedindexchanged="ddlPROVINCE_SelectedIndexChanged" BackColor="#3399FF"
                  ForeColor="#FF9999">
           </asp:DropDownList>
       </ContentTemplate>
 
     <Triggers>
      <asp:AsyncPostBackTrigger ControlID ="ddlPROVINCE" />
     </Triggers>
  </asp:UpdatePanel>
       <br />
 
 <asp:UpdatePanel ID="AMPHURpanel" runat="server">    
    <ContentTemplate >
        <span class="style1"><strong>เลือกอำเภอ:</strong></span>
      <asp:DropDownList ID="ddlAMPHUR" AutoPostBack ="true"
       AppendDataBoundItems ="true"  runat="server" Height="20px" Width="155px"
          onselectedindexchanged="ddlAMPHUR_SelectedIndexChanged"
            BackColor="#FF3399" ForeColor="Maroon">
      </asp:DropDownList>
    </ContentTemplate>
    <Triggers >
       <asp:AsyncPostBackTrigger ControlID ="ddlAMPHUR" />
       </Triggers>
    </asp:UpdatePanel>
       <br />
 
<asp:UpdatePanel ID="DISTRICTpanel" runat="server">     
   <ContentTemplate >      
       <span class="style1"><strong>เลือกตำล:</strong></span>      
     <asp:DropDownList ID="ddlDISTRICT" AutoPostBack ="true"
   AppendDataBoundItems ="true" runat="server" Height="20px" Width="155px"
           BackColor="#66FFFF" ForeColor="#006666">
     </asp:DropDownList>
  </ContentTemplate>
  <Triggers >
    <asp:AsyncPostBackTrigger ControlID ="ddlDISTRICT" />         </Triggers>  
 </asp:UpdatePanel>
 </div>

</asp:Content>
