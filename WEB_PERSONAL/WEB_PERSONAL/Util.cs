using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;
using System.Web.UI;

namespace WEB_PERSONAL {

    public class Util {

        public static string ToOracleDate(string date) {
            string[] s = date.Split('/');
            return s[0] + " " + ToOracleMonth(s[1]) + " " + s[2];
        }
        public static string ToOracleDate(DateTime date) {
            return date.Day.ToString("00") + " " + ToOracleMonth(date.Month) + " " + date.Year.ToString("0000");
        }
        public static string ToOracleMonth(string month) {
            return ToOracleMonth(Int32.Parse(month));
        }
        public static string ToOracleMonth(int month) {
            switch (month) {
                case 1:
                default:
                    return "ม.ค.";
                case 2:
                    return "ก.พ.";
                case 3:
                    return "มี.ค.";
                case 4:
                    return "เม.ย.";
                case 5:
                    return "พ.ค.";
                case 6:
                    return "มิ.ย.";
                case 7:
                    return "ก.ก.";
                case 8:
                    return "ส.ค.";
                case 9:
                    return "ก.ย.";
                case 10:
                    return "ต.ค.";
                case 11:
                    return "พ.ย.";
                case 12:
                    return "ธ.ค.";
            }
        }
        public static OracleConnection OC() {
            OracleConnection con = new OracleConnection("DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;");
            con.Open();
            return con;
        }
        public static string CS() {
            return "DATA SOURCE=ORCL_RMUTTO;USER ID=RMUTTO;PASSWORD=Zxcvbnm;";
        }
        public static void Alert(Page page, string message) {
            string script2 = "alert('" + message + "');";
            ScriptManager.RegisterStartupScript(page, page.GetType(), "ServerControlScript", script2, true);
        }
    }
    

}