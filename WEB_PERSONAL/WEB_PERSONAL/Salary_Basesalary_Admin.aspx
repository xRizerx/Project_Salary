<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salary_Basesalary_Admin.aspx.cs" Inherits="WEB_PERSONAL.Salary_Basesalary_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .panin {
            background-color: rgba(255,255,255,0.8);
            border-radius: 5px;
            border: 2px solid white;
        }

        .panout {
            padding: 20px;
            text-align: center;
            background-color: pink;
        }
        .Linkbtn{
            border-radius:5px;
            padding: 10px;
            background-color:#5971ff;
            text-decoration:none;
            color:white;
            
        }

        .mGrid {
            width: 100%;
            background-color: #fff;
            margin: 5px 0 10px 0;
            border: solid 1px #525252;
            border-collapse: collapse;
        }

            .mGrid td {
                padding: 2px;
                border: solid 1px #c1c1c1;
                color: #717171;
            }

            .mGrid th {
                padding: 4px 2px;
                color: #fff;
                background: #424242;
                border-left: solid 1px #525252;
                font-size: 0.9em;
            }

            .mGrid .alt {
                background: #fcfcfc;
            }

            .mGrid .pgr {
                background: #424242;
            }

                .mGrid .pgr table {
                    margin: 5px 0;
                }

                .mGrid .pgr td {
                    border-width: 0;
                    padding: 0 6px;
                    border-left: solid 1px #666;
                    font-weight: bold;
                    color: #fff;
                    line-height: 12px;
                }

                .mGrid .pgr a {
                    color: #666;
                    text-decoration: none;
                }

                    .mGrid .pgr a:hover {
                        color: #000;
                        text-decoration: none;
                    }

        .button_ui {
            border-radius: 2px;
            padding: 2px 8px;
            background-color: rgb(200, 125, 0);
            border-color: black;
            color: white;
            text-decoration: none;
        }

        @font-face {
            font-family: 'WDB_BANGNA';
            src: url('../Font/WDB_Bangna.ttf') format('truetype');
        }

        .bigtuu {
            font-family: WDB_BANGNA;
        }
        .auto-style1 {
            height: 353px;
        }
        </style>
    <link href="CSS/Master.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bigtuu">
            <asp:Panel ID="Panel1" runat="server" CssClass="panout" Height="500px">
                <asp:Panel ID="Panel2" runat="server" CssClass="panin" Width="100%" Height="100%">

                    <table style="width: 100%;">
                        <tr>
                            <td>&nbsp;</td>
                            <td colspan="10">
                                &nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label1" runat="server" Text="ปรับฐานเงินเดือน [ผู้ดูแลระบบ]" Font-Size="24pt"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="ตำแหน่ง"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SQL_TB_POSITION" DataTextField="NAME" DataValueField="ID">
                                </asp:DropDownList>
                                <asp:SqlDataSource ID="SQL_TB_POSITION" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT &quot;ID&quot;, &quot;NAME&quot; FROM &quot;TB_POSITION&quot;"></asp:SqlDataSource>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="เงินเดือนสูงสุด"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="เงินเดือนต่ำสุด"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="เงินเดือนล่างสูงสุด"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="เงินเดือนล่างต่ำสุด"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:LinkButton ID="LinkButton2" runat="server" CssClass="Linkbtn">เพิ่มข้อมูลฐานเงินเดือน</asp:LinkButton>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style1"></td>
                            <td class="auto-style1" colspan="10">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" DeleteCommand="DELETE FROM &quot;TB_BASESALARY&quot; WHERE &quot;ID&quot; = :ID" InsertCommand="INSERT INTO &quot;TB_BASESALARY&quot; (&quot;ID&quot;, &quot;POSITION_ID&quot;, &quot;MAXSALARY&quot;, &quot;MINSALARY&quot;, &quot;MAXLOWSALARY&quot;, &quot;MINLOWSALARY&quot;) VALUES (:ID, :POSITION_ID, :MAXSALARY, :MINSALARY, :MAXLOWSALARY, :MINLOWSALARY)" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_BASESALARY.ID,TB_POSITION.NAME, TB_BASESALARY.MAXSALARY, TB_BASESALARY.MINSALARY, TB_BASESALARY.MAXLOWSALARY, TB_BASESALARY.MINLOWSALARY FROM TB_BASESALARY, TB_POSITION WHERE TB_BASESALARY.POSITION_ID = TB_POSITION.ID" UpdateCommand="UPDATE &quot;TB_BASESALARY&quot; SET &quot;MAXSALARY&quot; = :MAXSALARY, &quot;MINSALARY&quot; = :MINSALARY, &quot;MAXLOWSALARY&quot; = :MAXLOWSALARY, &quot;MINLOWSALARY&quot; = :MINLOWSALARY WHERE &quot;ID&quot; = :ID">
                                    <DeleteParameters>
                                        <asp:Parameter Name="ID" Type="Decimal" />
                                    </DeleteParameters>
                                    <InsertParameters>
                                        <asp:Parameter Name="ID" Type="Decimal" />
                                        <asp:Parameter Name="POSITION_ID" Type="String" />
                                        <asp:Parameter Name="MAXSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MINSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MAXLOWSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MINLOWSALARY" Type="Decimal" />
                                    </InsertParameters>
                                    <UpdateParameters>
                                        <asp:Parameter Name="ID" />
                                        <asp:Parameter Name="MAXSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MINSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MAXLOWSALARY" Type="Decimal" />
                                        <asp:Parameter Name="MINLOWSALARY" Type="Decimal" />
                                    </UpdateParameters>
                                </asp:SqlDataSource>
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass="mGrid" DataKeyNames="ID" AllowPaging="True" DataMember="DefaultView" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True">
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" EditText="แก้ไข" UpdateText="อัพเดท" CancelText="ยกเลิก" InsertText="เพิ่ม" NewText="สร้างใหม่" ShowDeleteButton="True" />
                                        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                                        <asp:BoundField DataField="NAME" HeaderText="NAME" ReadOnly="True" SortExpression="NAME" />
                                        <asp:BoundField DataField="MAXSALARY" HeaderText="MAXSALARY" SortExpression="MAXSALARY" />
                                        <asp:BoundField DataField="MINSALARY" HeaderText="MINSALARY" SortExpression="MINSALARY" />
                                        <asp:BoundField DataField="MAXLOWSALARY" HeaderText="MAXLOWSALARY" SortExpression="MAXLOWSALARY" />
                                        <asp:BoundField DataField="MINLOWSALARY" HeaderText="MINLOWSALARY" SortExpression="MINLOWSALARY" />
                                        
                                    </Columns>
                                </asp:GridView>

                            </td>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                    </table>

                </asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
