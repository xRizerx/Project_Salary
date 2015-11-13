using Rmutto.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class ClassPerson
    {

        public int MINISTRY_ID { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public int TITLE_ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public string NAME { get; set; }
        public string LASTNAME { get; set; }
        public string FATHER_NAME { get; set; }
        public string FATHER_LASTNAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string MOTHER_LASTNAME { get; set; }
        public string MOTHER_OLD_LASTNAME { get; set; }
        public string COUPLE_NAME { get; set; }
        public string COUPLE_LASTNAME { get; set; }
        public string COUPLE_OLD_LASTNAME { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string BIRTHDATE_LONG { get; set; }
        public DateTime INWORK_DATE { get; set; }
        public int STAFFTYPE_ID { get; set; }
        public DateTime RETIRE_DATE { get; set; }
        public string RETIRE_DATE_LONG { get; set; }


        public ClassPerson() { }
        public ClassPerson(int MINISTRY_ID, string DEPARTMENT_ID, int TITLE_ID, string CITIZEN_ID, string NAME, string LASTNAME, string FATHER_NAME, string FATHER_LASTNAME, string MOTHER_NAME, string MOTHER_LASTNAME, string MOTHER_OLD_LASTNAME, string COUPLE_NAME, string COUPLE_LASTNAME, string COUPLE_OLD_LASTNAME, DateTime BIRTHDATE, string BIRTHDATE_LONG, DateTime INWORK_DATE, int STAFFTYPE_ID, DateTime RETIRE_DATE, string RETIRE_DATE_LONG)
        {
            this.MINISTRY_ID = MINISTRY_ID;
            this.DEPARTMENT_ID = DEPARTMENT_ID;
            this.TITLE_ID = TITLE_ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.NAME = NAME;
            this.LASTNAME = LASTNAME;
            this.FATHER_NAME = FATHER_NAME;
            this.FATHER_LASTNAME = FATHER_LASTNAME;
            this.MOTHER_NAME = MOTHER_NAME;
            this.MOTHER_LASTNAME = MOTHER_LASTNAME;
            this.MOTHER_OLD_LASTNAME = MOTHER_OLD_LASTNAME;
            this.COUPLE_NAME = COUPLE_NAME;
            this.COUPLE_LASTNAME = COUPLE_LASTNAME;
            this.BIRTHDATE = BIRTHDATE;
            this.BIRTHDATE_LONG = BIRTHDATE_LONG;
            this.INWORK_DATE = INWORK_DATE;
            this.STAFFTYPE_ID = STAFFTYPE_ID;
            this.RETIRE_DATE = RETIRE_DATE;
            this.RETIRE_DATE_LONG = RETIRE_DATE_LONG;

        }
        //get ไว้ก่อนยังไม่ได้ทำ
        public DataTable GetPerson(string SEMINAR_NAME, string SEMINAR_DATETIME_FROM, string SEMINAR_DATETIME_TO)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_SEMINAR ";
            if (!string.IsNullOrEmpty(SEMINAR_NAME) || !string.IsNullOrEmpty(SEMINAR_DATETIME_FROM) || !string.IsNullOrEmpty(SEMINAR_DATETIME_TO))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    query += " and SEMINAR_NAME like :SEMINAR_NAME ";
                }
                if (!string.IsNullOrEmpty(SEMINAR_DATETIME_FROM))
                {
                    query += " and CONVERT(varchar(10),LP_Date,103) = @SEMINAR_DATETIME_FROM ";
                }
                if (!string.IsNullOrEmpty(SEMINAR_DATETIME_TO))
                {
                    query += " and CONVERT(varchar(10),LP_Date,103) = @SEMINAR_DATETIME_TO ";
                }
            }
            OracleCommand command = new OracleCommand(query, conn);
            // Create the command
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    command.Parameters.Add(new OracleParameter("SEMINAR_NAME", SEMINAR_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(SEMINAR_DATETIME_FROM))
                {
                    command.Parameters.Add(new OracleParameter("SEMINAR_DATETIME_FROM", SEMINAR_DATETIME_FROM));
                }
                if (!string.IsNullOrEmpty(SEMINAR_DATETIME_TO))
                {
                    command.Parameters.Add(new OracleParameter("SEMINAR_DATETIME_TO", SEMINAR_DATETIME_TO));
                }
                OracleDataAdapter sd = new OracleDataAdapter(command);
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
        //get ไว้ก่อนยังไม่ได้ทำ
        public DataTable GetPersonSearch(string SEMINAR_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_SEMINAR ";
            if (!string.IsNullOrEmpty(SEMINAR_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    query += " and SEMINAR_NAME like :SEMINAR_NAME ";
                }
            }
            OracleCommand command = new OracleCommand(query, conn);
            // Create the command
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                if (!string.IsNullOrEmpty(SEMINAR_NAME))
                {
                    command.Parameters.Add(new OracleParameter("SEMINAR_NAME", SEMINAR_NAME + "%"));
                }
                OracleDataAdapter sd = new OracleDataAdapter(command);
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

        public int InsertPerson()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_PERSON (MINISTRY_ID, DEPARTMENT_ID, TITLE_ID, CITIZEN_ID, NAME, LASTNAME, FATHER_NAME, FATHER_LASTNAME, MOTHER_NAME, MOTHER_LASTNAME, MOTHER_OLD_LASTNAME, COUPLE_NAME, COUPLE_LASTNAME, COUPLE_OLD_LASTNAME, BIRTHDATE, BIRTHDATE_LONG, INWORK_DATE, STAFFTYPE_ID, RETIRE_DATE, RETIRE_DATE_LONG) VALUES (:MINISTRY_ID, :DEPARTMENT_ID, :TITLE_ID, :CITIZEN_ID, :NAME, :LASTNAME, :FATHER_NAME, :FATHER_LASTNAME, :MOTHER_NAME, :MOTHER_LASTNAME, :MOTHER_OLD_LASTNAME, :COUPLE_NAME, :COUPLE_LASTNAME, :COUPLE_OLD_LASTNAME, :BIRTHDATE, :BIRTHDATE_LONG, :INWORK_DATE, :STAFFTYPE_ID, :RETIRE_DATE, :RETIRE_DATE_LONG)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID));
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("NAME;", NAME));
                command.Parameters.Add(new OracleParameter("LASTNAME", LASTNAME));
                command.Parameters.Add(new OracleParameter("FATHER_NAME", FATHER_NAME));
                command.Parameters.Add(new OracleParameter("FATHER_LASTNAME", FATHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_NAME", MOTHER_NAME));
                command.Parameters.Add(new OracleParameter("MOTHER_LASTNAME", MOTHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_OLD_LASTNAME", MOTHER_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_NAME", COUPLE_NAME));
                command.Parameters.Add(new OracleParameter("COUPLE_LASTNAME", COUPLE_LASTNAME));
                command.Parameters.Add(new OracleParameter("BIRTHDATE", BIRTHDATE));
                command.Parameters.Add(new OracleParameter("BIRTHDATE_LONG", BIRTHDATE_LONG));
                command.Parameters.Add(new OracleParameter("INWORK_DATE", INWORK_DATE));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE", RETIRE_DATE));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE_LONG", RETIRE_DATE_LONG));

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
        //get ไว้ก่อนยังไม่ได้ทำ
        public bool UpdateSEMINAR()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_SEMINAR Set ";
            query += " SEMINAR_NAME = :SEMINAR_NAME ,";
            query += " SEMINAR_LASTNAME = :SEMINAR_LASTNAME ,";
            query += " SEMINAR_POSITION = :SEMINAR_POSITION ,";
            query += " SEMINAR_DEGREE = :SEMINAR_DEGREE ,";
            query += " SEMINAR_CAMPUS = :SEMINAR_CAMPUS ,";
            query += " SEMINAR_NAMEOFPROJECT = :SEMINAR_NAMEOFPROJECT ,";
            query += " SEMINAR_PLACE = :SEMINAR_PLACE ,";
            query += " SEMINAR_DATETIME_FROM = :SEMINAR_DATETIME_FROM ,";
            query += " SEMINAR_DATETIME_TO = :SEMINAR_DATETIME_TO ,";
            query += " SEMINAR_DAY = :SEMINAR_DAY ,";
            query += " SEMINAR_MONTH = :SEMINAR_MONTH ,";
            query += " SEMINAR_YEAR = :SEMINAR_YEAR ,";
            query += " SEMINAR_BUDGET = :SEMINAR_BUDGET ,";
            query += " SEMINAR_SUPPORT_BUDGET = :SEMINAR_SUPPORT_BUDGET ,";
            query += " SEMINAR_CERTIFICATE = :SEMINAR_CERTIFICATE ,";
            query += " SEMINAR_ABSTRACT = :SEMINAR_ABSTRACT ,";
            query += " SEMINAR_RESULT = :SEMINAR_RESULT ,";
            query += " SEMINAR_SHOW_1 = :SEMINAR_SHOW_1 ,";
            query += " SEMINAR_SHOW_2 = :SEMINAR_SHOW_2 ,";
            query += " SEMINAR_SHOW_3 = :SEMINAR_SHOW_3 ,";
            query += " SEMINAR_SHOW_4 = :SEMINAR_SHOW_4 ,";
            query += " SEMINAR_PROBLEM = :SEMINAR_PROBLEM ,";
            query += " SEMINAR_COMMENT = :SEMINAR_COMMENT ,";
            query += " SEMINAR_SIGNED_DATETIME = :SEMINAR_SIGNED_DATETIME ";
            query += " where SEMINAR_ID  = :SEMINAR_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("SEMINAR_NAME", SEMINAR_NAME));
                command.Parameters.Add(new OracleParameter("SEMINAR_LASTNAME", SEMINAR_LASTNAME));
                command.Parameters.Add(new OracleParameter("SEMINAR_POSITION", SEMINAR_POSITION));
                command.Parameters.Add(new OracleParameter("SEMINAR_DEGREE", SEMINAR_DEGREE));
                command.Parameters.Add(new OracleParameter("SEMINAR_CAMPUS", SEMINAR_CAMPUS));
                command.Parameters.Add(new OracleParameter("SEMINAR_NAMEOFPROJECT", SEMINAR_NAMEOFPROJECT));
                command.Parameters.Add(new OracleParameter("SEMINAR_PLACE", SEMINAR_PLACE));
                command.Parameters.Add(new OracleParameter("SEMINAR_DATETIME_FROM", SEMINAR_DATETIME_FROM));
                command.Parameters.Add(new OracleParameter("SEMINAR_DATETIME_TO", SEMINAR_DATETIME_TO));
                command.Parameters.Add(new OracleParameter("SEMINAR_DAY", SEMINAR_DAY));
                command.Parameters.Add(new OracleParameter("SEMINAR_MONTH", SEMINAR_MONTH));
                command.Parameters.Add(new OracleParameter("SEMINAR_YEAR", SEMINAR_YEAR));
                command.Parameters.Add(new OracleParameter("SEMINAR_BUDGET", SEMINAR_BUDGET));
                command.Parameters.Add(new OracleParameter("SEMINAR_SUPPORT_BUDGET", SEMINAR_SUPPORT_BUDGET));
                command.Parameters.Add(new OracleParameter("SEMINAR_CERTIFICATE", SEMINAR_CERTIFICATE));
                command.Parameters.Add(new OracleParameter("SEMINAR_ABSTRACT", SEMINAR_ABSTRACT));
                command.Parameters.Add(new OracleParameter("SEMINAR_RESULT", SEMINAR_RESULT));
                command.Parameters.Add(new OracleParameter("SEMINAR_SHOW_1", SEMINAR_SHOW_1));
                command.Parameters.Add(new OracleParameter("SEMINAR_SHOW_2", SEMINAR_SHOW_2));
                command.Parameters.Add(new OracleParameter("SEMINAR_SHOW_3", SEMINAR_SHOW_3));
                command.Parameters.Add(new OracleParameter("SEMINAR_SHOW_4", SEMINAR_SHOW_4));
                command.Parameters.Add(new OracleParameter("SEMINAR_PROBLEM", SEMINAR_PROBLEM));
                command.Parameters.Add(new OracleParameter("SEMINAR_COMMENT", SEMINAR_COMMENT));
                command.Parameters.Add(new OracleParameter("SEMINAR_SIGNED_DATETIME", SEMINAR_SIGNED_DATETIME));
                command.Parameters.Add(new OracleParameter("SEMINAR_ID", SEMINAR_ID));
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
        //get ไว้ก่อนยังไม่ได้ทำ
        public bool DeleteSEMINAR()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_SEMINAR where SEMINAR_ID = :SEMINAR_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("SEMINAR_ID", SEMINAR_ID));
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
