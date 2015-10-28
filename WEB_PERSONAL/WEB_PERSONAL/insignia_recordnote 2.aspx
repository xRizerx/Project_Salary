<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote 2.aspx.cs" Inherits="WEB_PERSONAL.insignia_recordnote_2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" Height="628px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="citizen_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="citizen_id" HeaderText="citizen_id" ReadOnly="True" SortExpression="citizen_id" />
                <asp:BoundField DataField="date" HeaderText="date" SortExpression="date" />
                <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="POSITION_WORK_NAME" SortExpression="POSITION_WORK_NAME" />
                <asp:BoundField DataField="POSITION_NAME" HeaderText="POSITION_NAME" SortExpression="POSITION_NAME" />
                <asp:BoundField DataField="GRADEINSIGNIA_NAME" HeaderText="GRADEINSIGNIA_NAME" SortExpression="GRADEINSIGNIA_NAME" />
                <asp:BoundField DataField="gazette_lam" HeaderText="gazette_lam" SortExpression="gazette_lam" />
                <asp:BoundField DataField="gazette_ton" HeaderText="gazette_ton" SortExpression="gazette_ton" />
                <asp:BoundField DataField="gazette_na" HeaderText="gazette_na" SortExpression="gazette_na" />
                <asp:BoundField DataField="gazette_date" HeaderText="gazette_date" SortExpression="gazette_date" />
                <asp:BoundField DataField="Invoice" HeaderText="Invoice" SortExpression="Invoice" />
                <asp:BoundField DataField="decoration" HeaderText="decoration" SortExpression="decoration" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ 
            ConnectionStrings:personalConnectionString %>" 
            SelectCommand="SELECT * FROM [TB_recordnote]" UpdateCommand="UPDATE [TB_recordnote] Set [POSITION_NAME]=@POSITION_NAME  Where [citizen_id]=@citizen_id" DeleteCommand="DELETE from [TB_recordnote] Where [citizen_id]=@citizen_id"></asp:SqlDataSource>

        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:TextBox ID="TextBox2" 
            runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


    </asp:Panel>
</asp:Content>
