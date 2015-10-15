using WEB_PERSONAL.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class Seminar
    {

        public int SEMINAR_ID { get; set; }
        public string SEMINAR_NAME { get; set; }
        public string SEMINAR_LASTNAME { get; set; }
        public string SEMINAR_POSITION { get; set; }
        public string SEMINAR_DEGREE { get; set; }
        public string SEMINAR_CAMPUS { get; set; }
        public string SEMINAR_NAMEOFPROJECT { get; set; }
        public DateTime SEMINAR_DATE_FROM { get; set; }
        public DateTime SEMINAR_DATE_TO { get; set; }
        public int SEMINAR_DAY { get; set; }
        public int SEMINAR_MONTH { get; set; }
        public int SEMINAR_YEAR { get; set; }
        public int SEMINAR_BUDGET { get; set; }
        public string SEMINAR_SUPPORT_BUDGET { get; set; }
        public string SEMINAR_CERTIFICATE { get; set; }
        public string SEMINAR_ABSTRACT { get; set; }
        public string SEMINAR_RESULT { get; set; }
        public string SEMINAR_SHOW_1 { get; set; }
        public string SEMINAR_SHOW_2 { get; set; }
        public string SEMINAR_SHOW_3 { get; set; }
        public string SEMINAR_SHOW_4 { get; set; }
        public string SEMINAR_SHOW_PROBLEM { get; set; }
        public string SEMINAR_SHOW_COMMENT { get; set; }
        public DateTime SEMINAR_SIGNED_DATE { get; set; }

        public Seminar() { }
        public Seminar(int SEMINAR_ID, string SEMINAR_NAME, string SEMINAR_LASTNAME, string SEMINAR_POSITION, string SEMINAR_DEGREE, string SEMINAR_CAMPUS, string SEMINAR_NAMEOFPROJECT,
        DateTime SEMINAR_DATE_FROM, DateTime SEMINAR_DATE_TO, int SEMINAR_DAY, int SEMINAR_MONTH, int SEMINAR_YEAR, int SEMINAR_BUDGET, string SEMINAR_SUPPORT_BUDGET,
        string SEMINAR_CERTIFICATE, string SEMINAR_ABSTRACT, string SEMINAR_RESULT, string SEMINAR_SHOW_1, string SEMINAR_SHOW_2, string SEMINAR_SHOW_3, string SEMINAR_SHOW_4, string SEMINAR_SHOW_PROBLEM,
        string SEMINAR_SHOW_COMMENT, DateTime SEMINAR_SIGNED_DATE)
        {
            this.SEMINAR_ID = SEMINAR_ID;
            this.SEMINAR_NAME = SEMINAR_NAME;
            this.SEMINAR_LASTNAME = SEMINAR_LASTNAME;
            this.SEMINAR_POSITION = SEMINAR_POSITION;
            this.SEMINAR_DEGREE = SEMINAR_DEGREE;
            this.SEMINAR_CAMPUS = SEMINAR_CAMPUS;
            this.SEMINAR_NAMEOFPROJECT = SEMINAR_NAMEOFPROJECT;
            this.SEMINAR_DATE_FROM = SEMINAR_DATE_FROM;
            this.SEMINAR_DATE_TO = SEMINAR_DATE_TO;
            this.SEMINAR_DAY = SEMINAR_DAY;
            this.SEMINAR_MONTH = SEMINAR_MONTH;
            this.SEMINAR_YEAR = SEMINAR_YEAR;
            this.SEMINAR_BUDGET = SEMINAR_BUDGET;
            this.SEMINAR_SUPPORT_BUDGET = SEMINAR_SUPPORT_BUDGET;
            this.SEMINAR_CERTIFICATE = SEMINAR_CERTIFICATE;
            this.SEMINAR_ABSTRACT = SEMINAR_ABSTRACT;
            this.SEMINAR_RESULT = SEMINAR_RESULT;
            this.SEMINAR_SHOW_1 = SEMINAR_SHOW_1;
            this.SEMINAR_SHOW_2 = SEMINAR_SHOW_2;
            this.SEMINAR_SHOW_3 = SEMINAR_SHOW_3;
            this.SEMINAR_SHOW_4 = SEMINAR_SHOW_4;
            this.SEMINAR_SHOW_PROBLEM = SEMINAR_SHOW_PROBLEM;
            this.SEMINAR_SHOW_COMMENT = SEMINAR_SHOW_COMMENT;
            this.SEMINAR_SIGNED_DATE = SEMINAR_SIGNED_DATE;
        }

        public int InsertSEMINAR()
        {
            int id = 0;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("INSERT INTO TB_SEMINAR (seminar_name,seminar_lastname,seminar_position,seminar_degree,seminar_campus,seminar_nameofproject,seminar_place,seminar_date_from,seminar_date_to, seminar_day, seminar_month, seminar_year, seminar_budget, seminar_support_budget, seminar_certificate, seminar_abstract, seminar_result, seminar_show_1, seminar_show_2, seminar_show_3, seminar_problem, seminar_comment) VALUES (@seminar_name,@seminar_lastname,@seminar_position,@seminar_degree,@seminar_campus,@seminar_nameofproject,@seminar_place,@seminar_date_from,@seminar_date_to, @seminar_day, @seminar_month, @seminar_year, @seminar_budget, @seminar_support_budget, @seminar_certificate, @seminar_abstract, @seminar_result, @seminar_show_1, @seminar_show_2, @seminar_show_3, @seminar_problem, @seminar_comment)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("SEMINAR_NAME", SEMINAR_NAME));
                command.Parameters.Add(new SqlParameter("SEMINAR_LASTNAME ", SEMINAR_LASTNAME));
                command.Parameters.Add(new SqlParameter("SEMINAR_POSITION ", SEMINAR_POSITION));
                command.Parameters.Add(new SqlParameter("SEMINAR_DEGREE ", SEMINAR_DEGREE));
                command.Parameters.Add(new SqlParameter("SEMINAR_CAMPUS ", SEMINAR_CAMPUS));
                command.Parameters.Add(new SqlParameter("SEMINAR_NAMEOFPROJECT ", SEMINAR_NAMEOFPROJECT));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATE_FROM ", SEMINAR_DATE_FROM));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATE_TO  ", SEMINAR_DATE_TO));
                command.Parameters.Add(new SqlParameter("SEMINAR_DAY  ", SEMINAR_DAY));
                command.Parameters.Add(new SqlParameter("SEMINAR_MONTH  ", SEMINAR_MONTH));
                command.Parameters.Add(new SqlParameter("SEMINAR_YEAR  ", SEMINAR_YEAR));
                command.Parameters.Add(new SqlParameter("SEMINAR_BUDGET  ", SEMINAR_BUDGET));
                command.Parameters.Add(new SqlParameter("SEMINAR_SUPPORT_BUDGET ", SEMINAR_SUPPORT_BUDGET));
                command.Parameters.Add(new SqlParameter("SEMINAR_CERTIFICATE  ", SEMINAR_CERTIFICATE));
                command.Parameters.Add(new SqlParameter("SEMINAR_ABSTRACT  ", SEMINAR_ABSTRACT));
                command.Parameters.Add(new SqlParameter("SEMINAR_RESULT  ", SEMINAR_RESULT));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_1  ", SEMINAR_SHOW_1));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_2  ", SEMINAR_SHOW_2));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_3  ", SEMINAR_SHOW_3));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_4   ", SEMINAR_SHOW_4));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_PROBLEM   ", SEMINAR_SHOW_PROBLEM));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_COMMENT   ", SEMINAR_SHOW_COMMENT));
                id = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
            return id;
        }

        public bool UpdateSEMINAR()
        {
            bool result = false;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            string query = "Update TB_SEMINAR Set ";
            query += " SEMINAR_NAME = @SEMINAR_NAME ,";
            query += " SEMINAR_LASTNAME = @SEMINAR_LASTNAME ,";
            query += " SEMINAR_POSITION = @SEMINAR_POSITION ,";
            query += " SEMINAR_DEGREE = @SEMINAR_DEGREE ,";
            query += " SEMINAR_CAMPUS = @SEMINAR_CAMPUS ,";
            query += " SEMINAR_NAMEOFPROJECT = @SEMINAR_NAMEOFPROJECT ,";
            query += " SEMINAR_DATE_FROM = @SEMINAR_DATE_FROM ,";
            query += " SEMINAR_DATE_TO = @SEMINAR_DATE_TO ,";
            query += " SEMINAR_DAY = @SEMINAR_DAY ,";
            query += " SEMINAR_MONTH = @SEMINAR_MONTH ,";
            query += " SEMINAR_YEAR = @SEMINAR_YEAR ,";
            query += " SEMINAR_BUDGET = @SEMINAR_BUDGET";
            query += " SEMINAR_SUPPORT_BUDGET = @SEMINAR_SUPPORT_BUDGET ,";
            query += " SEMINAR_CERTIFICATE = @SEMINAR_CERTIFICATE ,";
            query += " SEMINAR_ABSTRACT = @SEMINAR_ABSTRACT ,";
            query += " SEMINAR_RESULT = @SEMINAR_RESULT ,";
            query += " SEMINAR_SHOW_1 = @SEMINAR_SHOW_1 ,";
            query += " SEMINAR_SHOW_2 = @SEMINAR_SHOW_2 ,";
            query += " SEMINAR_SHOW_3 = @SEMINAR_SHOW_3 ,";
            query += " SEMINAR_SHOW_4 = @SEMINAR_SHOW_4 ,";
            query += " SEMINAR_SHOW_PROBLEM = @SEMINAR_SHOW_PROBLEM ,";
            query += " SEMINAR_SHOW_COMMENT = @SEMINAR_SHOW_COMMENT ";
            query += " where SEMINAR_ID  = @SEMINAR_ID ";

            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("SEMINAR_NAME", SEMINAR_NAME));
                command.Parameters.Add(new SqlParameter("SEMINAR_LASTNAME", SEMINAR_LASTNAME));
                command.Parameters.Add(new SqlParameter("SEMINAR_POSITION", SEMINAR_POSITION));
                command.Parameters.Add(new SqlParameter("SEMINAR_DEGREE", SEMINAR_DEGREE));
                command.Parameters.Add(new SqlParameter("SEMINAR_CAMPUS", SEMINAR_CAMPUS));
                command.Parameters.Add(new SqlParameter("SEMINAR_NAMEOFPROJECT", SEMINAR_NAMEOFPROJECT));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATE_FROM", SEMINAR_DATE_FROM));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATE_TO", SEMINAR_DATE_TO));
                command.Parameters.Add(new SqlParameter("SEMINAR_DAY", SEMINAR_DAY));
                command.Parameters.Add(new SqlParameter("SEMINAR_MONTH", SEMINAR_MONTH));
                command.Parameters.Add(new SqlParameter("SEMINAR_YEAR", SEMINAR_YEAR));
                command.Parameters.Add(new SqlParameter("SEMINAR_BUDGET", SEMINAR_BUDGET));
                command.Parameters.Add(new SqlParameter("SEMINAR_SUPPORT_BUDGET", SEMINAR_SUPPORT_BUDGET));
                command.Parameters.Add(new SqlParameter("SEMINAR_CERTIFICATE", SEMINAR_CERTIFICATE));
                command.Parameters.Add(new SqlParameter("SEMINAR_ABSTRACT", SEMINAR_ABSTRACT));
                command.Parameters.Add(new SqlParameter("SEMINAR_RESULT", SEMINAR_RESULT));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_1", SEMINAR_SHOW_1));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_2", SEMINAR_SHOW_2));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_3", SEMINAR_SHOW_3));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_4", SEMINAR_SHOW_4));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_PROBLEM", SEMINAR_SHOW_PROBLEM));
                command.Parameters.Add(new SqlParameter("SEMINAR_SHOW_COMMENT", SEMINAR_SHOW_COMMENT));
                if (command.ExecuteNonQuery() > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
            return result;
        }

        public bool DeleteSEMINAR()
        {
            bool result = false;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("Delete TB_SEMINAR where SEMINAR_ID = @SEMINAR_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("SEMINAR_ID", SEMINAR_ID));
                if (command.ExecuteNonQuery() >= 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                conn.Close();
            }
            return result;
        }
    }
}
 