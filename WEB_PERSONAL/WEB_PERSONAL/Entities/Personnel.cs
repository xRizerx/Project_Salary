﻿using WEB_PERSONAL.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class Personnel
    {
        public int YEAR { get; set; }
        public string UNIV_ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public string TITLE_ID { get; set; }
        public string STF_NAME { get; set; }
        public string STF_LNAME { get; set; }
        public int GENDER_ID { get; set; }
        public DateTime BIRTHDAY { get; set; }
        public string HOMEADD { get; set; }
        public string MOO { get; set; }
        public string STRRET { get; set; }
        public int DISTRICT_ID { get; set; }
        public int AMPHUR_ID { get; set; }
        public int PROVINCE_ID { get; set; }
        public string TELEPHONE { get; set; }
        public int ZIPCODE_ID { get; set; }
        public string NATION_ID { get; set; }
        public int STAFFTYPE_ID { get; set; }
        public int TIME_CONTACT_ID { get; set; }
        public int BUDGET_ID { get; set; }
        public int SUBSTAFFTYPE_ID { get; set; }
        public string ADMIN_POSITION_ID { get; set; }
        public string POSITION_ID { get; set; }
        public string POSITION_WORK_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public DateTime DATETIME_INWORK { get; set; }
        public string SPECIAL_NAME { get; set; }
        public string TEACH_ISCED_ID { get; set; }
        public string GRAD_LEV_ID { get; set; }
        public string GRAD_CURR { get; set; }
        public string GRAD_ISCED_ID { get; set; }
        public string GRAD_PROG_ID { get; set; }
        public string GRAD_UNIV { get; set; }
        public int GRAD_COUNTRY_ID { get; set; }


        public Personnel() { }
        public Personnel(int YEAR, string UNIV_ID, string CITIZEN_ID, string TITLE_ID, string STF_NAME, string STF_LNAME, int GENDER_ID,
        DateTime BIRTHDAY, string HOMEADD, string MOO, string STRRET, int DISTRICT_ID, int AMPHUR_ID, int PROVINCE_ID, string TELEPHONE,
        int ZIPCODE_ID, string NATION_ID, int STAFFTYPE_ID, int TIME_CONTACT_ID, int BUDGET_ID, int SUBSTAFFTYPE_ID, string ADMIN_POSITION_ID, string POSITION_ID,
        string POSITION_WORK_ID, string DEPARTMENT_ID, DateTime DATETIME_INWORK, string SPECIAL_NAME, string TEACH_ISCED_ID, string GRAD_LEV_ID, string GRAD_CURR, string GRAD_ISCED_ID, string GRAD_PROG_ID, string GRAD_UNIV, int GRAD_COUNTRY_ID)
        {
            this.YEAR = YEAR;
            this.UNIV_ID = UNIV_ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.TITLE_ID = TITLE_ID;
            this.STF_NAME = STF_NAME;
            this.STF_LNAME = STF_LNAME;
            this.GENDER_ID = GENDER_ID;
            this.BIRTHDAY = BIRTHDAY;
            this.HOMEADD = HOMEADD;
            this.MOO = MOO;
            this.STRRET = STRRET;
            this.DISTRICT_ID = DISTRICT_ID;
            this.AMPHUR_ID = PROVINCE_ID;
            this.TELEPHONE = TELEPHONE;
            this.ZIPCODE_ID = ZIPCODE_ID;
            this.NATION_ID = NATION_ID;
            this.STAFFTYPE_ID = STAFFTYPE_ID;
            this.TIME_CONTACT_ID = TIME_CONTACT_ID;
            this.BUDGET_ID = BUDGET_ID;
            this.SUBSTAFFTYPE_ID = SUBSTAFFTYPE_ID;
            this.ADMIN_POSITION_ID = ADMIN_POSITION_ID;
            this.POSITION_ID = POSITION_ID;
            this.POSITION_WORK_ID = POSITION_WORK_ID;
            this.DEPARTMENT_ID = DEPARTMENT_ID;
            this.SPECIAL_NAME = SPECIAL_NAME;
            this.TEACH_ISCED_ID = TEACH_ISCED_ID;
            this.GRAD_LEV_ID = GRAD_LEV_ID;
            this.GRAD_CURR = GRAD_CURR;
            this.GRAD_ISCED_ID = GRAD_ISCED_ID;
            this.GRAD_PROG_ID = GRAD_PROG_ID;
            this.GRAD_UNIV = GRAD_UNIV;
            this.GRAD_COUNTRY_ID = GRAD_COUNTRY_ID;
        }


        public DataTable GetPersonnel(string SEMINAR_NAME)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            string query = "SELECT * FROM TB_PERSONAL ";
            if (!string.IsNullOrEmpty(SEMINAR_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    query += " and CITIZEN_ID like @CITIZEN_ID ";
                }
            }
            SqlCommand command = new SqlCommand(query, conn);
            // Create the command
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    command.Parameters.Add(new SqlParameter("CITIZEN_ID", CITIZEN_ID + "%"));
                }
                SqlDataAdapter sd = new SqlDataAdapter(command);
                sd.Fill(dt);

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

            return dt;
        }

        public int InsertPersonnel()
        {
            int id = 0;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("INSERT INTO TB_PERSONAL (YEAR ,UNIV_ID ,CITIZEN_ID ,TITLE_ID ,STF_NAME ,STF_LNAME ,GENDER_ID ,BIRTHDAY ,HOMEADD , MOO , STRRET , DISTRICT_ID , AMPHUR_ID , PROVINCE_ID , TELEPHONE , ZIPCODE_ID , NATION_ID , STAFFTYPE_ID , TIME_CONTACT_ID , BUDGET_ID , SUBSTAFFTYPE_ID , ADMIN_POSITION_ID ,POSITION_ID , POSITION_WORK_ID , DEPARTMENT_ID , DATETIME_INWORK , SPECIAL_NAME , TEACH_ISCED_ID , GRAD_LEV_ID , GRAD_CURR , GRAD_ISCED_ID , GRAD_PROG_ID , GRAD_UNIV , GRAD_COUNTRY_ID ) VALUES (@YEAR ,@UNIV_ID ,@CITIZEN_ID ,@TITLE_ID ,@STF_NAME ,@STF_LNAME ,@GENDER_ID ,@BIRTHDAY ,@HOMEADD , @MOO , @STRRET , @DISTRICT_ID , @AMPHUR_ID , @PROVINCE_ID , @TELEPHONE , @ZIPCODE_ID , @NATION_ID , @STAFFTYPE_ID , @TIME_CONTACT_ID , @BUDGET_ID , @SUBSTAFFTYPE_ID , @ADMIN_POSITION_ID ,@POSITION_ID ,@POSITION_WORK_ID ,@DEPARTMENT_ID ,@DATETIME_INWORK ,@SPECIAL_NAME ,@TEACH_ISCED_ID ,@GRAD_LEV_ID ,@GRAD_CURR ,@GRAD_ISCED_ID ,@GRAD_PROG_ID ,@GRAD_UNIV ,@GRAD_COUNTRY_ID)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("YEAR", YEAR));
                command.Parameters.Add(new SqlParameter("UNIV_ID", UNIV_ID));
                command.Parameters.Add(new SqlParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new SqlParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new SqlParameter("STF_NAME", STF_NAME));
                command.Parameters.Add(new SqlParameter("STF_LNAME", STF_LNAME));
                command.Parameters.Add(new SqlParameter("GENDER_ID", GENDER_ID));
                command.Parameters.Add(new SqlParameter("BIRTHDAY", BIRTHDAY));
                command.Parameters.Add(new SqlParameter("HOMEADD", HOMEADD));
                command.Parameters.Add(new SqlParameter("MOO", MOO));
                command.Parameters.Add(new SqlParameter("STRRET", STRRET));
                command.Parameters.Add(new SqlParameter("DISTRICT_ID", DISTRICT_ID));
                command.Parameters.Add(new SqlParameter("AMPHUR_ID", AMPHUR_ID));
                command.Parameters.Add(new SqlParameter("PROVINCE_ID", PROVINCE_ID));
                command.Parameters.Add(new SqlParameter("TELEPHONE", TELEPHONE));
                command.Parameters.Add(new SqlParameter("ZIPCODE_ID", ZIPCODE_ID));
                command.Parameters.Add(new SqlParameter("NATION_ID", NATION_ID));
                command.Parameters.Add(new SqlParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new SqlParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
                command.Parameters.Add(new SqlParameter("BUDGET_ID", BUDGET_ID));
                command.Parameters.Add(new SqlParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
                command.Parameters.Add(new SqlParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
                command.Parameters.Add(new SqlParameter("POSITION_ID", POSITION_ID));
                command.Parameters.Add(new SqlParameter("POSITION_WORK_ID", POSITION_WORK_ID));
                command.Parameters.Add(new SqlParameter("DEPARTMENT_ID", DEPARTMENT_ID));
                command.Parameters.Add(new SqlParameter("DATETIME_INWORK", DATETIME_INWORK));
                command.Parameters.Add(new SqlParameter("SPECIAL_NAME", SPECIAL_NAME));
                command.Parameters.Add(new SqlParameter("TEACH_ISCED_ID", TEACH_ISCED_ID));
                command.Parameters.Add(new SqlParameter("GRAD_LEV_ID", GRAD_LEV_ID));
                command.Parameters.Add(new SqlParameter("GRAD_CURR", GRAD_CURR));
                command.Parameters.Add(new SqlParameter("GRAD_ISCED_ID", GRAD_ISCED_ID));
                command.Parameters.Add(new SqlParameter("GRAD_PROG_ID", GRAD_PROG_ID));
                command.Parameters.Add(new SqlParameter("GRAD_UNIV", GRAD_UNIV));
                command.Parameters.Add(new SqlParameter("GRAD_COUNTRY_ID", GRAD_COUNTRY_ID));
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
        /*
        public bool UpdatePersonnel()
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
            query += " SEMINAR_PLACE = @SEMINAR_PLACE ,";
            query += " SEMINAR_DATETIME_FROM = @SEMINAR_DATETIME_FROM ,";
            query += " SEMINAR_DATETIME_TO = @SEMINAR_DATETIME_TO ,";
            query += " SEMINAR_DAY = @SEMINAR_DAY ,";
            query += " SEMINAR_MONTH = @SEMINAR_MONTH ,";
            query += " SEMINAR_YEAR = @SEMINAR_YEAR ,";
            query += " SEMINAR_BUDGET = @SEMINAR_BUDGET ,";
            query += " SEMINAR_SUPPORT_BUDGET = @SEMINAR_SUPPORT_BUDGET ,";
            query += " SEMINAR_CERTIFICATE = @SEMINAR_CERTIFICATE ,";
            query += " SEMINAR_ABSTRACT = @SEMINAR_ABSTRACT ,";
            query += " SEMINAR_RESULT = @SEMINAR_RESULT ,";
            query += " SEMINAR_SHOW_1 = @SEMINAR_SHOW_1 ,";
            query += " SEMINAR_SHOW_2 = @SEMINAR_SHOW_2 ,";
            query += " SEMINAR_SHOW_3 = @SEMINAR_SHOW_3 ,";
            query += " SEMINAR_SHOW_4 = @SEMINAR_SHOW_4 ,";
            query += " SEMINAR_PROBLEM = @SEMINAR_PROBLEM ,";
            query += " SEMINAR_COMMENT = @SEMINAR_COMMENT ,";
            query += " SEMINAR_SIGNED_DATETIME = @SEMINAR_SIGNED_DATETIME ";
            query += " where SEMINAR_ID  = @SEMINAR_ID";

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
                command.Parameters.Add(new SqlParameter("SEMINAR_PLACE", SEMINAR_PLACE));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATETIME_FROM", SEMINAR_DATETIME_FROM));
                command.Parameters.Add(new SqlParameter("SEMINAR_DATETIME_TO", SEMINAR_DATETIME_TO));
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
                command.Parameters.Add(new SqlParameter("SEMINAR_PROBLEM", SEMINAR_PROBLEM));
                command.Parameters.Add(new SqlParameter("SEMINAR_COMMENT", SEMINAR_COMMENT));
                command.Parameters.Add(new SqlParameter("SEMINAR_SIGNED_DATETIME", SEMINAR_SIGNED_DATETIME));
                command.Parameters.Add(new SqlParameter("SEMINAR_ID", SEMINAR_ID));
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
        */
        public bool DeletePersonnel()
        {
            bool result = false;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("Delete TB_PERSONAL where CITIZEN_ID = @CITIZEN_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("CITIZEN_ID", CITIZEN_ID));
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
 