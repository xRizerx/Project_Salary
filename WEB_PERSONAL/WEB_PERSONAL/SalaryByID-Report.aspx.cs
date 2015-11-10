using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.OracleClient;
using System.Data;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace WEB_PERSONAL
{
    public partial class SalaryByID_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Util.OC();
            using (OracleCommand command = new OracleCommand("Select CITIZEN_ID,STF_NAME || ' ' || STF_LNAME as NAME From TB_PERSONAL", conn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        ExcelPackage p = new ExcelPackage();

                        p.Workbook.Properties.Author = "Prakasit Janta";
                        p.Workbook.Properties.Title = "Salary Report";
                        p.Workbook.Properties.Company = "RMUTTO";
                        p.Workbook.Properties.Manager = "Prakasit Janta";
                        p.Workbook.Worksheets.Add("รายละเอียดการขึ้นเงินเดือนข้าราชกาลในมหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออกวิทยาเขตบางพระ");
                        ExcelWorksheet ws = p.Workbook.Worksheets[1]; // 1 is the position of the worksheet
                        ws.Name = "รายละเอียดการขึ้นเงินเดือนข้าราชกาลในมหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออกวิทยาเขตบางพระ";
                        int c = 0;
                        {
                            var cell_head1 = ws.Cells[1, 1];
                            var fill = cell_head1.Style.Fill;
                            fill.PatternType = ExcelFillStyle.Solid;
                            fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                            cell_head1.Value = "รหัสประชาชน";
                        }
                        {
                            var cell_head2 = ws.Cells[1, 2];
                            var fill = cell_head2.Style.Fill;
                            fill.PatternType = ExcelFillStyle.Solid;
                            fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                            cell_head2.Value = "ชื่อ - นามสกุล";
                        }
                        {
                            var cell_head3 = ws.Cells[1, 3];
                            var fill = cell_head3.Style.Fill;
                            fill.PatternType = ExcelFillStyle.Solid;
                            fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                            cell_head3.Value = "รหัสเลขที่ตำแหน่ง";
                        }
                        
                        
                        while (reader.Read())
                        {
                            String a = reader.GetString(0);
                            String b = reader.GetString(1);

                            int rowIndex = 2+c++;
                            int colIndex = 1;

                            do
                            {
                                // Set the background colours
                                var cell = ws.Cells[rowIndex, colIndex];
                                var fill1 = cell.Style.Fill;
                                fill1.PatternType = ExcelFillStyle.Solid;
                                fill1.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                                colIndex++;
                                
                            }
                            while (colIndex != 4);
                            // Set the cell values
                            var cell_actionName = ws.Cells[rowIndex, 1];
                            var cell_timeTaken = ws.Cells[rowIndex, 2];
                            var cell_processorsUsed = ws.Cells[rowIndex, 3];
                            cell_actionName.Value = a;
                            cell_timeTaken.Value = b;
                            cell_processorsUsed.Value = "อิอิ";
                            ws.Column(1).Width = 15;
                            ws.Column(2).Width = 30;
                            ws.Column(3).Width = 20;                           
                        }
                        // Save the Excel file
                        Byte[] bin = p.GetAsByteArray();
                        File.WriteAllBytes(@"D:\Report.xlsx", bin);
                        Util.Alert(this, "CREATE EXCEL COMPLETE!");
                    }
                }
            }
            

        }




    }
}