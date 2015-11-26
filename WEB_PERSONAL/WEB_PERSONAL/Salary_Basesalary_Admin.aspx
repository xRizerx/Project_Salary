<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salary_Basesalary_Admin.aspx.cs" Inherits="WEB_PERSONAL.Salary_Basesalary_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .Linkbtn {
            border-radius: 5px;
            padding: 10px;
            background-color: #5971ff;
            text-decoration: none;
            color: white;
        }

        .mGrid {
            width: 100%;
            background-color: #666;
            margin: 5px 0 10px 0;
            border: solid 1px #525252;
            border-collapse: collapse;
        }

            .mGrid td {
                padding: 2px;
                border: solid 1px #c1c1c1;
                color: #fff;
            }

            .mGrid th {
                padding: 4px 2px;
                color: #fff;
                background: #00BFFF;
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
            background-color: #00d8ff;
            border-color: black;
            color: black;
            font: bold;
            text-decoration: none;
            margin-left: 10px;
            line-height: 40px;
            transition: ease 0.25s;
        }

            .button_ui:hover {
                border-radius: 2px;
                padding: 2px 8px;
                background-color: #ff64a2;
                border-color: black;
                color: white;
                font: bold;
                text-decoration: none;
                line-height: 40px;
                margin-left: 10px;
            }

        @font-face {
            font-family: 'WDB_BANGNA';
            src: url('../Font/WDB_Bangna.ttf') format('truetype');
        }

        .bigtuu {
            font-family: WDB_BANGNA;
        }

        .bgtest {
            padding: 20px 25px;
            font-weight: bold;
            background-color: #00BFFF;
        }

        .homemenu {
            width: 100%;
            height: 40px;
            position: fixed;
            z-index: 999;
            background-color: #FFFFFF;
        }

        .hidBtn {
            display: none;
        }

        #eiei {
            background-image: url("/Image/btx1.jpg");
            background-size: 100%;
        }
    </style>
    <link href="CSS/Master.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="homemenu">
            <asp:Table ID="Table3" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click" CssClass="button_ui">กลับเมนูหลัก</asp:LinkButton>
                    </asp:TableCell>
                    <asp:TableCell>
                         <audio controls autoplay>
                            <source src="Entities/Virus.mp3" type="audio/mp3" />
                         </audio> 
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>


        </div>
        <div style="height: 20px"></div>
        <div class="bigtuu">
            <asp:Panel ID="Panel3" runat="server">
                <div class="master_default_div_sec" id="eiei">
                    <div class="bgtest">
                        <asp:Label ID="Label2" runat="server" Text="ระบบฐานเงินเดือน"></asp:Label>
                    </div>
                    <div class="master_default_div_sec_in">
                        <table style="width: 100%;">
                            <tr>
                                <td>
                                    <asp:Panel ID="Panel1" runat="server" DefaultButton="LinkButton2">
                                        <div class="master_default_div_sec_header">
                                            <asp:Label ID="Label1" runat="server" Text="เพิ่มฐานเงินเดือน"></asp:Label>
                                        </div>
                                        <div class="master_default_div_sec_in">
                                            <asp:Table ID="Table1" runat="server" Height="300px">
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Labeli3" runat="server" Text="ตำแหน่ง"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SQL_TB_POSITION" DataTextField="NAME" DataValueField="ID">
                                                        </asp:DropDownList>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label4" runat="server" Text="เงินเดือนสูงสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:Label ID="Label5" runat="server" Text="เงินเดือนต่ำสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label6" runat="server" Text="เงินเดือนล่างสูงสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow>
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label7" runat="server" Text="เงินเดือนล่างต่ำสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableFooterRow>
                                                    <asp:TableCell runat="server" Width="250px" ColumnSpan="2">
                                                        <br />
                                                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="Linkbtn" OnClick="LinkButton2_Click">เพิ่มข้อมูลฐานเงินเดือน</asp:LinkButton>
                                                        <br />
                                                    </asp:TableCell>
                                                </asp:TableFooterRow>
                                            </asp:Table>
                                        </div>
                                    </asp:Panel>
                                </td>
                                <td>
                                    <asp:Panel ID="Panel2" runat="server" DefaultButton="LinkButton1">
                                        <div class="master_default_div_sec_header">
                                            <asp:Label ID="Label3" runat="server" Text="แก้ไขฐานเงินเดือน"></asp:Label>
                                        </div>
                                        <div class="master_default_div_sec_in">
                                            <asp:Table ID="Table2" runat="server" Height="300px">
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:Label ID="Label13" runat="server" Text="ID"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True" BackColor="Gray" ForeColor="White"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:Label ID="Label8" runat="server" Text="ตำแหน่ง"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SQL_TB_POSITION" DataTextField="NAME" DataValueField="ID">
                                                        </asp:DropDownList>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label9" runat="server" Text="เงินเดือนสูงสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label10" runat="server" Text="เงินเดือนต่ำสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label11" runat="server" Text="เงินเดือนล่างสูงสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableRow runat="server">
                                                    <asp:TableCell runat="server" Width="200px" HorizontalAlign="Left">
                                                        <asp:Label ID="Label12" runat="server" Text="เงินเดือนล่างต่ำสุด"></asp:Label>
                                                    </asp:TableCell>
                                                    <asp:TableCell runat="server" HorizontalAlign="Left">
                                                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                                <asp:TableFooterRow>
                                                    <asp:TableCell runat="server" Width="250px" ColumnSpan="2">
                                                        <br />
                                                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="Linkbtn" OnClick="LinkButton1_Click">แก้ไขข้อมูลฐานเงินเดือน</asp:LinkButton>
                                                        <br />
                                                        <br />
                                                    </asp:TableCell>
                                                </asp:TableFooterRow>
                                            </asp:Table>
                                        </div>
                                    </asp:Panel>
                                </td>
                            </tr>
                        </table>

                        <asp:SqlDataSource ID="SQL_TB_POSITION" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT &quot;ID&quot;, &quot;NAME&quot; FROM &quot;TB_POSITION&quot;" UpdateCommand="UPDATE TB_POSITION SET NAME = :1, ST_ID = :2">
                            <UpdateParameters>
                                <asp:Parameter Name="1" />
                                <asp:Parameter Name="2" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RMUTTOORCL %>" DeleteCommand="DELETE FROM &quot;TB_BASESALARY&quot; WHERE &quot;ID&quot; = :ID" InsertCommand="INSERT INTO &quot;TB_BASESALARY&quot; (&quot;ID&quot;, &quot;POSITION_ID&quot;, &quot;MAXSALARY&quot;, &quot;MINSALARY&quot;, &quot;MAXLOWSALARY&quot;, &quot;MINLOWSALARY&quot;) VALUES (:ID, :POSITION_ID, :MAXSALARY, :MINSALARY, :MAXLOWSALARY, :MINLOWSALARY)" ProviderName="<%$ ConnectionStrings:RMUTTOORCL.ProviderName %>" SelectCommand="SELECT TB_BASESALARY.ID,TB_POSITION.NAME, TB_BASESALARY.MAXSALARY, TB_BASESALARY.MINSALARY, TB_BASESALARY.MAXLOWSALARY, TB_BASESALARY.MINLOWSALARY FROM TB_BASESALARY, TB_POSITION WHERE TB_BASESALARY.POSITION_ID = TB_POSITION.ID ORDER BY TB_BASESALARY.ID ASC" UpdateCommand="UPDATE &quot;TB_BASESALARY&quot; SET &quot;POSITION_ID&quot;=:NAME, &quot;MAXSALARY&quot; = :MAXSALARY, &quot;MINSALARY&quot; = :MINSALARY, &quot;MAXLOWSALARY&quot; = :MAXLOWSALARY, &quot;MINLOWSALARY&quot; = :MINLOWSALARY WHERE &quot;ID&quot; = :ID">
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
                                <asp:Parameter Name="MAXSALARY" Type="Decimal" />
                                <asp:Parameter Name="MINSALARY" Type="Decimal" />
                                <asp:Parameter Name="MAXLOWSALARY" Type="Decimal" />
                                <asp:Parameter Name="MINLOWSALARY" Type="Decimal" />
                                <asp:Parameter Name="ID" />
                                <asp:Parameter Name="NAME" />
                            </UpdateParameters>
                        </asp:SqlDataSource>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CssClass="mGrid" DataKeyNames="ID" AllowPaging="True" DataMember="DefaultView" ShowFooter="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <Columns>
                                <asp:CommandField EditText="แก้ไข" UpdateText="อัพเดท" CancelText="ยกเลิก" InsertText="เพิ่ม" NewText="สร้างใหม่" ShowDeleteButton="True" DeleteText="ลบ" SelectText="เลือก" ControlStyle-ForeColor="White" ShowSelectButton="True" HeaderText="เครื่องมือการจัดการ" ItemStyle-HorizontalAlign="Center">
                                    <ControlStyle ForeColor="White" />
                                </asp:CommandField>
                                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                                <asp:BoundField DataField="NAME" HeaderText="NAME" />
                                <asp:BoundField DataField="MAXSALARY" HeaderText="MAXSALARY" SortExpression="MAXSALARY" />
                                <asp:BoundField DataField="MINSALARY" HeaderText="MINSALARY" SortExpression="MINSALARY" />
                                <asp:BoundField DataField="MAXLOWSALARY" HeaderText="MAXLOWSALARY" SortExpression="MAXLOWSALARY" />
                                <asp:BoundField DataField="MINLOWSALARY" HeaderText="MINLOWSALARY" SortExpression="MINLOWSALARY" />

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
