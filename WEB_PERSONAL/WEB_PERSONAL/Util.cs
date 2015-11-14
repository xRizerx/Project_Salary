using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;
using System.Web.UI;
using System.Globalization;

namespace WEB_PERSONAL {

    public class Util {
        public static System.Data.DataTable dt;
        /*public static string YearDown543(DateTime date) {

        }*/
        public static string ToOracleDate(string date) {
            string[] s = date.Split('/');
            return s[0] + " " + ToOracleMonth(s[1]) + " " + s[2];
        }
        public static string ToOracleDate(DateTime date) {
            return date.Day.ToString("00") + " " + ToOracleMonth(date.Month) + " " + date.Year.ToString("0000");
        }
        public static DateTime toOracleDateTime(string date) {
            return DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        public static DateTime toOracleDateTime(DateTime date) {
            return DateTime.ParseExact(date.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
        public static string ToThaiWord(string s) {
            string[] ss = s.Split('-');
            string s_day = ss[0];
            string s_month = ss[1];
            string s_year = ss[2];
            return "วันที่" + NormalizeThaiWord(NumberToThaiWord(s_day)) + "เดือน" + ToThaiMonth(s_month) + "ปี" + NormalizeThaiWord(NumberToThaiWord(s_year));
        }
        public static string ToThaiMonth(string s) {
            int month = Int32.Parse(s.Trim());
            switch(month) {
                case 1: return "มกราคม";
                case 2: return "กุมภาพันธ์";
                case 3: return "มีนาคม";
                case 4: return "เมษายน";
                case 5: return "พฤษภาคม";
                case 6: return "มิถุนายน";
                case 7: return "กรกฎาคม";
                case 8: return "สิงหาคม";
                case 9: return "กันยายน";
                case 10: return "ตุลาคม";
                case 11: return "พฤศจิกายน";
                case 12: return "ธันวาคม";
                default: return "[ERROR]";
            }
        }
        public static string NormalizeThaiWord(string s) {
            s = s.Replace("หนึ่งสิบ","สิบ");
            s = s.Replace("สองสิบ", "ยี่สิบ");
            s = s.Replace("สิบหนึ่ง", "สิบเอ็ด");
            return s;
        }
        public static string NumberToThaiWord(string s) {
            string sout = "";
            for (int i = 0; i < s.Length; ++i) {
                if(s[i] != '0')
                    sout += SingleNumberToThaiWord(s[i]) + ColumnNumberToThaiWord(s.Length-i-1);
            }
            return sout;
        }
        public static string SingleNumberToThaiWord(char c) {
            switch(c) {
                case '0': return "ศูนย์";
                case '1': return "หนึ่ง";
                case '2': return "สอง";
                case '3': return "สาม";
                case '4': return "สี่";
                case '5': return "ห้า";
                case '6': return "หก";
                case '7': return "เจ็ด";
                case '8': return "แปด";
                case '9': return "เก้า";
                default: return "[ERROR]";
            }
        }
        public static string ColumnNumberToThaiWord(int column) {
            if(column == 0) {
                return "";
            } else {
                column = column % 6;
            }
            switch (column) {
                case 0: return "ล้าน";
                case 1: return "สิบ";
                case 2: return "ร้อย";
                case 3: return "พัน";
                case 4: return "หมื่น";
                case 5: return "แสน";
                default: return "[ERROR]";
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