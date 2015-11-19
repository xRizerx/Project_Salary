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
        public int ID { get; set; }
        public int MINISTRY_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public string TITLE_ID { get; set; }
        public string CITIZEN_ID { get; set; }
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
        public string PERSON_NAME { get; set; }
        public string PERSON_LASTNAME { get; set; }

        public ClassPerson() { }
        public ClassPerson(int ID, int MINISTRY_ID, string DEPARTMENT_NAME, string TITLE_ID, string CITIZEN_ID, string FATHER_NAME, string FATHER_LASTNAME, string MOTHER_NAME, string MOTHER_LASTNAME, string MOTHER_OLD_LASTNAME, string COUPLE_NAME, string COUPLE_LASTNAME, string COUPLE_OLD_LASTNAME, DateTime BIRTHDATE, string BIRTHDATE_LONG, DateTime INWORK_DATE, int STAFFTYPE_ID, DateTime RETIRE_DATE, string RETIRE_DATE_LONG, string PERSON_NAME, string PERSON_LASTNAME)
        {
            this.ID = ID;
            this.MINISTRY_ID = MINISTRY_ID;
            this.DEPARTMENT_NAME = DEPARTMENT_NAME;
            this.TITLE_ID = TITLE_ID;
            this.CITIZEN_ID = CITIZEN_ID;
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
            this.PERSON_NAME = PERSON_NAME;
            this.PERSON_LASTNAME = PERSON_LASTNAME;

        }

        public int InsertPerson()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_PERSON (CITIZEN_ID,BIRTHDATE,INWORK_DATE,RETIRE_DATE,DEPARTMENT_NAME,MINISTRY_ID,TITLE_ID,BIRTHDATE_LONG,RETIRE_DATE_LONG,STAFFTYPE_ID,FATHER_NAME,FATHER_LASTNAME,MOTHER_NAME,MOTHER_LASTNAME,MOTHER_OLD_LASTNAME,COUPLE_NAME,COUPLE_LASTNAME,COUPLE_OLD_LASTNAME,PERSON_LASTNAME,PERSON_NAME) VALUES (:CITIZEN_ID,:BIRTHDATE,:INWORK_DATE,:RETIRE_DATE,:DEPARTMENT_NAME,:MINISTRY_ID,:TITLE_ID,:BIRTHDATE_LONG,:RETIRE_DATE_LONG,:STAFFTYPE_ID,:FATHER_NAME,:FATHER_LASTNAME,:MOTHER_NAME,:MOTHER_LASTNAME,:MOTHER_OLD_LASTNAME,:COUPLE_NAME,:COUPLE_LASTNAME,:COUPLE_OLD_LASTNAME,:PERSON_LASTNAME,:PERSON_NAME)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("BIRTHDATE", BIRTHDATE));
                command.Parameters.Add(new OracleParameter("INWORK_DATE", INWORK_DATE));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE", RETIRE_DATE));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new OracleParameter("BIRTHDATE_LONG", BIRTHDATE_LONG));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE_LONG", RETIRE_DATE_LONG));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("FATHER_NAME", FATHER_NAME));
                command.Parameters.Add(new OracleParameter("FATHER_LASTNAME", FATHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_NAME", MOTHER_NAME));
                command.Parameters.Add(new OracleParameter("MOTHER_LASTNAME", MOTHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_OLD_LASTNAME", MOTHER_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_NAME", COUPLE_NAME));
                command.Parameters.Add(new OracleParameter("COUPLE_LASTNAME", COUPLE_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_OLD_LASTNAME", COUPLE_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("PERSON_LASTNAME", PERSON_LASTNAME));
                command.Parameters.Add(new OracleParameter("PERSON_NAME", PERSON_NAME));


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

        public bool UpdatePerson()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_PERSON Set ";
            query += " CITIZEN_ID = :CITIZEN_ID ,";
            query += " BIRTHDATE = :BIRTHDATE ,";
            query += " INWORK_DATE = :INWORK_DATE ,";
            query += " RETIRE_DATE = :RETIRE_DATE ,";
            query += " DEPARTMENT_NAME = :DEPARTMENT_NAME ,";
            query += " MINISTRY_ID = :MINISTRY_ID ,";
            query += " TITLE_ID = :TITLE_ID ,";
            query += " BIRTHDATE_LONG = :BIRTHDATE_LONG ,";
            query += " RETIRE_DATE_LONG = :RETIRE_DATE_LONG ,";
            query += " STAFFTYPE_ID = :STAFFTYPE_ID ,";
            query += " FATHER_NAME = :FATHER_NAME ,";
            query += " FATHER_LASTNAME = :FATHER_LASTNAME ,";
            query += " MOTHER_NAME = :MOTHER_NAME ,";
            query += " MOTHER_LASTNAME = :MOTHER_LASTNAME ,";
            query += " MOTHER_OLD_LASTNAME = :MOTHER_OLD_LASTNAME ,";
            query += " COUPLE_NAME = :COUPLE_NAME ,";
            query += " COUPLE_LASTNAME = :COUPLE_LASTNAME ,";
            query += " COUPLE_OLD_LASTNAME = :COUPLE_OLD_LASTNAME ,";
            query += " PERSON_LASTNAME = :PERSON_LASTNAME ,";
            query += " PERSON_NAME = :PERSON_NAME ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("BIRTHDATE", BIRTHDATE));
                command.Parameters.Add(new OracleParameter("INWORK_DATE", INWORK_DATE));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE", RETIRE_DATE));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new OracleParameter("BIRTHDATE_LONG", BIRTHDATE_LONG));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE_LONG", RETIRE_DATE_LONG));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("FATHER_NAME", FATHER_NAME));
                command.Parameters.Add(new OracleParameter("FATHER_LASTNAME", FATHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_NAME", MOTHER_NAME));
                command.Parameters.Add(new OracleParameter("MOTHER_LASTNAME", MOTHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_OLD_LASTNAME", MOTHER_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_NAME", COUPLE_NAME));
                command.Parameters.Add(new OracleParameter("COUPLE_LASTNAME", COUPLE_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_OLD_LASTNAME", COUPLE_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("PERSON_LASTNAME", PERSON_LASTNAME));
                command.Parameters.Add(new OracleParameter("PERSON_NAME", PERSON_NAME));
                command.Parameters.Add(new OracleParameter("ID", ID));
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


    }
}
