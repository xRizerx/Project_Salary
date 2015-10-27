<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote 2.aspx.cs" Inherits="WEB_PERSONAL.insignia_recordnote_2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel2" runat="server" Height="628px">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" DataKeyNames="citizen_id" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="เลขประจำตัวประชาชน" SortExpression="citizen_id">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("citizen_id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("citizen_id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="วัน เดือน ปี" SortExpression="date">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("date") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("date") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="POSITION_WORK_NAME" HeaderText="ตำแหน่ง" SortExpression="POSITION_WORK_NAME" />
                <asp:BoundField DataField="POSITION_NAME" HeaderText="ระดับ" SortExpression="POSITION_NAME" />
                <asp:TemplateField HeaderText="ได้รับ ชั้น/รายการ" SortExpression="GRADEINSIGNIA_NAME">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem> กรุณาเลือกเครื่องราชอิสริยาภรณ์</asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                            <asp:ListItem> </asp:ListItem>
                        
                        <asp:ListItem> </asp:ListItem>
                       </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("GRADEINSIGNIA_NAME") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="gazette_lam" HeaderText="เล่ม" SortExpression="gazette_lam" />
                <asp:BoundField DataField="gazette_ton" HeaderText="ตอน" SortExpression="gazette_ton" />
                <asp:BoundField DataField="gazette_na" HeaderText="หน้า" SortExpression="gazette_na" />
                <asp:BoundField DataField="gazette_date" HeaderText="วัน เดือน ปี" SortExpression="gazette_date" />
                <asp:BoundField DataField="Invoice" HeaderText="ใบกำกับ" SortExpression="Invoice" />
                <asp:BoundField DataField="decoration" HeaderText="เหรียญตราฯ" SortExpression="decoration" />
                <asp:BoundField DataField="Notes" HeaderText="หมายเหตุ" SortExpression="Notes" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:personalConnectionString %>" SelectCommand="SELECT * FROM [TB_recordnote]"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>
