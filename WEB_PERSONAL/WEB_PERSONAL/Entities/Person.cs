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
        public string CITIZEN_ID { get; set; }
        public int TITLE_ID { get; set; }
        public string PERSON_NAME { get; set; }
        public string PERSON_LASTNAME { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string BIRTHDATE_LONG { get; set; }
        public DateTime RETIRE_DATE { get; set; }
        public string RETIRE_DATE_LONG { get; set; }
        public DateTime INWORK_DATE { get; set; }
        public int STAFFTYPE_ID { get; set; }
        public string FATHER_NAME { get; set; }
        public string FATHER_LASTNAME { get; set; }
        public string MOTHER_NAME { get; set; }
        public string MOTHER_LASTNAME { get; set; }
        public string MOTHER_OLD_LASTNAME { get; set; }
        public string COUPLE_NAME { get; set; }
        public string COUPLE_LASTNAME { get; set; }
        public string COUPLE_OLD_LASTNAME { get; set; }
        public int MINISTRY_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public int GENDER_ID { get; set; }
        public string NATION_ID { get; set; }
        public string HOMEADD { get; set; }
        public string MOO { get; set; }
        public string STREET { get; set; }
        public int DISTRICT_ID { get; set; }
        public int AMPHUR_ID { get; set; }
        public int PROVINCE_ID { get; set; }
        public int ZIPCODE_ID { get; set; }
        public string TELEPHONE { get; set; }
        public int TIME_CONTACT_ID { get; set; }
        public int BUDGET_ID { get; set; }
        public int SUBSTAFFTYPE_ID { get; set; }
        public string ADMIN_POSITION_ID { get; set; }
        public string POSITION_WORK_ID { get; set; }
        public string SPECIAL_NAME { get; set; }
        public string TEACH_ISCED_ID { get; set; }
        public string GRAD_ISCED_ID { get; set; }
        public string GRAD_PROG_ID { get; set; }
        public string GRAD_UNIV { get; set; }
        public int GRAD_COUNTRY_ID { get; set; }
        public int FACULTY_ID { get; set; }
        public int CAMPUS_ID { get; set; }

        public ClassPerson() { }
        public ClassPerson(int ID, string CITIZEN_ID, int TITLE_ID, string PERSON_NAME, string PERSON_LASTNAME, DateTime BIRTHDATE, string BIRTHDATE_LONG, DateTime RETIRE_DATE, string RETIRE_DATE_LONG, DateTime INWORK_DATE, int STAFFTYPE_ID,
            string FATHER_NAME, string FATHER_LASTNAME, string MOTHER_NAME, string MOTHER_LASTNAME, string MOTHER_OLD_LASTNAME, string COUPLE_NAME, string COUPLE_LASTNAME, string COUPLE_OLD_LASTNAME, int MINISTRY_ID, string DEPARTMENT_NAME,
            int GENDER_ID, string NATION_ID, string HOMEADD, string MOO, string STREET, int DISTRICT_ID, int AMPHUR_ID, int PROVINCE_ID, int ZIPCODE_ID, string TELEPHONE, int TIME_CONTACT_ID, int BUDGET_ID, int SUBSTAFFTYPE_ID, string ADMIN_POSITION_ID,
            string POSITION_WORK_ID, string SPECIAL_NAME, string TEACH_ISCED_ID, string GRAD_ISCED_ID, string GRAD_PROG_ID, string GRAD_UNIV, int GRAD_COUNTRY_ID, int FACULTY_ID, int CAMPUS_ID)
        {
            this.ID = ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.TITLE_ID = TITLE_ID;
            this.PERSON_NAME = PERSON_NAME;
            this.PERSON_LASTNAME = PERSON_LASTNAME;
            this.BIRTHDATE = BIRTHDATE;
            this.BIRTHDATE_LONG = BIRTHDATE_LONG;
            this.RETIRE_DATE = RETIRE_DATE;
            this.RETIRE_DATE_LONG = RETIRE_DATE_LONG;
            this.INWORK_DATE = INWORK_DATE;
            this.STAFFTYPE_ID = STAFFTYPE_ID;
            this.FATHER_NAME = FATHER_NAME;
            this.FATHER_LASTNAME = FATHER_LASTNAME;
            this.MOTHER_NAME = MOTHER_NAME;
            this.MOTHER_LASTNAME = MOTHER_LASTNAME;
            this.MOTHER_OLD_LASTNAME = MOTHER_OLD_LASTNAME;
            this.COUPLE_NAME = COUPLE_NAME;
            this.COUPLE_LASTNAME = COUPLE_LASTNAME;
            this.COUPLE_OLD_LASTNAME = COUPLE_OLD_LASTNAME;
            this.MINISTRY_ID = MINISTRY_ID;
            this.DEPARTMENT_NAME = DEPARTMENT_NAME;
            this.GENDER_ID = GENDER_ID;
            this.NATION_ID = NATION_ID;
            this.HOMEADD = HOMEADD;
            this.MOO = MOO;
            this.STREET = STREET;
            this.DISTRICT_ID = DISTRICT_ID;
            this.AMPHUR_ID = AMPHUR_ID;
            this.PROVINCE_ID = PROVINCE_ID;
            this.ZIPCODE_ID = ZIPCODE_ID;
            this.TELEPHONE = TELEPHONE;
            this.TIME_CONTACT_ID = TIME_CONTACT_ID;
            this.BUDGET_ID = BUDGET_ID;
            this.SUBSTAFFTYPE_ID = SUBSTAFFTYPE_ID;
            this.ADMIN_POSITION_ID = ADMIN_POSITION_ID;
            this.POSITION_WORK_ID = POSITION_WORK_ID;
            this.SPECIAL_NAME = SPECIAL_NAME;
            this.TEACH_ISCED_ID = TEACH_ISCED_ID;
            this.GRAD_ISCED_ID = GRAD_ISCED_ID;
            this.GRAD_PROG_ID = GRAD_PROG_ID;
            this.GRAD_UNIV = GRAD_UNIV;
            this.GRAD_COUNTRY_ID = GRAD_COUNTRY_ID;
            this.FACULTY_ID = FACULTY_ID;
            this.CAMPUS_ID = CAMPUS_ID;
        }

        public DataTable GetPersonSearch(string TITLE_ID, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_PERSON ";
            if (!string.IsNullOrEmpty(TITLE_ID) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(TITLE_ID))
                {
                    query += " and TITLE_ID like :TITLE_ID ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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

                if (!string.IsNullOrEmpty(TITLE_ID))
                {
                    command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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
            OracleCommand command = new OracleCommand("INSERT INTO TB_PERSON (CITIZEN_ID,TITLE_ID,PERSON_NAME,PERSON_LASTNAME,BIRTHDATE,BIRTHDATE_LONG,RETIRE_DATE,RETIRE_DATE_LONG,INWORK_DATE,STAFFTYPE_ID,FATHER_NAME,FATHER_LASTNAME,MOTHER_NAME,MOTHER_LASTNAME,MOTHER_OLD_LASTNAME,COUPLE_NAME,COUPLE_LASTNAME,COUPLE_OLD_LASTNAME,MINISTRY_ID,DEPARTMENT_NAME,GENDER_ID,NATION_ID,HOMEADD,MOO,STREET,DISTRICT_ID,AMPHUR_ID,PROVINCE_ID,ZIPCODE_ID,TELEPHONE,TIME_CONTACT_ID,BUDGET_ID,SUBSTAFFTYPE_ID,ADMIN_POSITION_ID,POSITION_WORK_ID,SPECIAL_NAME,TEACH_ISCED_ID,GRAD_ISCED_ID,GRAD_PROG_ID,GRAD_UNIV,GRAD_COUNTRY_ID,FACULTY_ID,CAMPUS_ID) VALUES (:CITIZEN_ID,:TITLE_ID,:PERSON_NAME,:PERSON_LASTNAME,:BIRTHDATE,:BIRTHDATE_LONG,:RETIRE_DATE,:RETIRE_DATE_LONG,:INWORK_DATE,:STAFFTYPE_ID,:FATHER_NAME,:FATHER_LASTNAME,:MOTHER_NAME,:MOTHER_LASTNAME,:MOTHER_OLD_LASTNAME,:COUPLE_NAME,:COUPLE_LASTNAME,:COUPLE_OLD_LASTNAME,:MINISTRY_ID,:DEPARTMENT_NAME,:GENDER_ID,:NATION_ID,:HOMEADD,:MOO,:STREET,:DISTRICT_ID,:AMPHUR_ID,:PROVINCE_ID,:ZIPCODE_ID,:TELEPHONE,:TIME_CONTACT_ID,:BUDGET_ID,:SUBSTAFFTYPE_ID,:ADMIN_POSITION_ID,:POSITION_WORK_ID,:SPECIAL_NAME,:TEACH_ISCED_ID,:GRAD_ISCED_ID,:GRAD_PROG_ID,:GRAD_UNIV,:GRAD_COUNTRY_ID,:FACULTY_ID,:CAMPUS_ID)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new OracleParameter("PERSON_NAME", PERSON_NAME));
                command.Parameters.Add(new OracleParameter("PERSON_LASTNAME", PERSON_LASTNAME));
                command.Parameters.Add(new OracleParameter("BIRTHDATE", BIRTHDATE));
                command.Parameters.Add(new OracleParameter("BIRTHDATE_LONG", BIRTHDATE_LONG));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE", RETIRE_DATE));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE_LONG", RETIRE_DATE_LONG));
                command.Parameters.Add(new OracleParameter("INWORK_DATE", INWORK_DATE));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("FATHER_NAME", FATHER_NAME));
                command.Parameters.Add(new OracleParameter("FATHER_LASTNAME", FATHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_NAME", MOTHER_NAME));
                command.Parameters.Add(new OracleParameter("MOTHER_LASTNAME", MOTHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_OLD_LASTNAME", MOTHER_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_NAME", COUPLE_NAME));
                command.Parameters.Add(new OracleParameter("COUPLE_LASTNAME", COUPLE_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_OLD_LASTNAME", COUPLE_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));
                command.Parameters.Add(new OracleParameter("GENDER_ID", GENDER_ID));
                command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID));
                command.Parameters.Add(new OracleParameter("HOMEADD", HOMEADD));
                command.Parameters.Add(new OracleParameter("MOO", MOO));
                command.Parameters.Add(new OracleParameter("STREET", STREET));
                command.Parameters.Add(new OracleParameter("DISTRICT_ID", DISTRICT_ID));
                command.Parameters.Add(new OracleParameter("AMPHUR_ID", AMPHUR_ID));
                command.Parameters.Add(new OracleParameter("PROVINCE_ID", PROVINCE_ID));
                command.Parameters.Add(new OracleParameter("ZIPCODE_ID", ZIPCODE_ID));
                command.Parameters.Add(new OracleParameter("TELEPHONE", TELEPHONE));
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
                command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
                command.Parameters.Add(new OracleParameter("SPECIAL_NAME", SPECIAL_NAME));
                command.Parameters.Add(new OracleParameter("TEACH_ISCED_ID", TEACH_ISCED_ID));
                command.Parameters.Add(new OracleParameter("GRAD_ISCED_ID", GRAD_ISCED_ID));
                command.Parameters.Add(new OracleParameter("GRAD_PROG_ID", GRAD_PROG_ID));
                command.Parameters.Add(new OracleParameter("GRAD_UNIV", GRAD_UNIV));
                command.Parameters.Add(new OracleParameter("GRAD_COUNTRY_ID", GRAD_COUNTRY_ID));
                command.Parameters.Add(new OracleParameter("FACULTY_ID", FACULTY_ID));
                command.Parameters.Add(new OracleParameter("CAMPUS_ID", CAMPUS_ID));

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
            query += " TITLE_ID = :TITLE_ID ,";
            query += " PERSON_NAME = :PERSON_NAME ,";
            query += " PERSON_LASTNAME = :PERSON_LASTNAME ,";
            query += " BIRTHDATE = :BIRTHDATE ,";
            query += " BIRTHDATE_LONG = :BIRTHDATE_LONG ,";
            query += " RETIRE_DATE = :RETIRE_DATE ,";
            query += " RETIRE_DATE_LONG = :RETIRE_DATE_LONG ,";
            query += " INWORK_DATE = :INWORK_DATE ,";
            query += " STAFFTYPE_ID = :STAFFTYPE_ID ,";
            query += " FATHER_NAME = :FATHER_NAME ,";
            query += " FATHER_LASTNAME = :FATHER_LASTNAME ,";
            query += " MOTHER_NAME = :MOTHER_NAME ,";
            query += " MOTHER_LASTNAME = :MOTHER_LASTNAME ,";
            query += " MOTHER_OLD_LASTNAME = :MOTHER_OLD_LASTNAME ,";
            query += " COUPLE_NAME = :COUPLE_NAME ,";
            query += " COUPLE_LASTNAME = :COUPLE_LASTNAME ,";
            query += " COUPLE_OLD_LASTNAME = :COUPLE_OLD_LASTNAME ,";
            query += " MINISTRY_ID = :MINISTRY_ID ,";
            query += " DEPARTMENT_NAME = :DEPARTMENT_NAME ,";
            query += " GENDER_ID = :GENDER_ID ,";
            query += " NATION_ID = :NATION_ID ,";
            query += " HOMEADD = :HOMEADD ,";
            query += " MOO = :MOO ,";
            query += " STREET = :STREET ,";
            query += " DISTRICT_ID = :DISTRICT_ID ,";
            query += " AMPHUR_ID = :AMPHUR_ID ,";
            query += " PROVINCE_ID = :PROVINCE_ID ,";
            query += " ZIPCODE_ID = :ZIPCODE_ID ,";
            query += " TELEPHONE = :TELEPHONE ,";
            query += " TIME_CONTACT_ID = :TIME_CONTACT_ID ,";
            query += " BUDGET_ID = :BUDGET_ID ,";
            query += " SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID ,";
            query += " ADMIN_POSITION_ID = :ADMIN_POSITION_ID ,";
            query += " POSITION_WORK_ID = :POSITION_WORK_ID ,";
            query += " SPECIAL_NAME = :SPECIAL_NAME ,";
            query += " TEACH_ISCED_ID = :TEACH_ISCED_ID ,";
            query += " GRAD_ISCED_ID = :GRAD_ISCED_ID ,";
            query += " GRAD_PROG_ID = :GRAD_PROG_ID ,";
            query += " GRAD_UNIV = :GRAD_UNIV ,";
            query += " GRAD_COUNTRY_ID = :GRAD_COUNTRY_ID ,";
            query += " FACULTY_ID = :FACULTY_ID ,";
            query += " CAMPUS_ID = :CAMPUS_ID ";
            query += " where CITIZEN_ID  = :CITIZEN_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
                command.Parameters.Add(new OracleParameter("PERSON_NAME", PERSON_NAME));
                command.Parameters.Add(new OracleParameter("PERSON_LASTNAME", PERSON_LASTNAME));
                command.Parameters.Add(new OracleParameter("BIRTHDATE", BIRTHDATE));
                command.Parameters.Add(new OracleParameter("BIRTHDATE_LONG", BIRTHDATE_LONG));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE", RETIRE_DATE));
                command.Parameters.Add(new OracleParameter("RETIRE_DATE_LONG", RETIRE_DATE_LONG));
                command.Parameters.Add(new OracleParameter("INWORK_DATE", INWORK_DATE));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("FATHER_NAME", FATHER_NAME));
                command.Parameters.Add(new OracleParameter("FATHER_LASTNAME", FATHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_NAME", MOTHER_NAME));
                command.Parameters.Add(new OracleParameter("MOTHER_LASTNAME", MOTHER_LASTNAME));
                command.Parameters.Add(new OracleParameter("MOTHER_OLD_LASTNAME", MOTHER_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_NAME", COUPLE_NAME));
                command.Parameters.Add(new OracleParameter("COUPLE_LASTNAME", COUPLE_LASTNAME));
                command.Parameters.Add(new OracleParameter("COUPLE_OLD_LASTNAME", COUPLE_OLD_LASTNAME));
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));
                command.Parameters.Add(new OracleParameter("GENDER_ID", GENDER_ID));
                command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID));
                command.Parameters.Add(new OracleParameter("HOMEADD", HOMEADD));
                command.Parameters.Add(new OracleParameter("MOO", MOO));
                command.Parameters.Add(new OracleParameter("STREET", STREET));
                command.Parameters.Add(new OracleParameter("DISTRICT_ID", DISTRICT_ID));
                command.Parameters.Add(new OracleParameter("AMPHUR_ID", AMPHUR_ID));
                command.Parameters.Add(new OracleParameter("PROVINCE_ID", PROVINCE_ID));
                command.Parameters.Add(new OracleParameter("ZIPCODE_ID", ZIPCODE_ID));
                command.Parameters.Add(new OracleParameter("TELEPHONE", TELEPHONE));
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
                command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
                command.Parameters.Add(new OracleParameter("SPECIAL_NAME", SPECIAL_NAME));
                command.Parameters.Add(new OracleParameter("TEACH_ISCED_ID", TEACH_ISCED_ID));
                command.Parameters.Add(new OracleParameter("GRAD_ISCED_ID", GRAD_ISCED_ID));
                command.Parameters.Add(new OracleParameter("GRAD_PROG_ID", GRAD_PROG_ID));
                command.Parameters.Add(new OracleParameter("GRAD_UNIV", GRAD_UNIV));
                command.Parameters.Add(new OracleParameter("GRAD_COUNTRY_ID", GRAD_COUNTRY_ID));
                command.Parameters.Add(new OracleParameter("FACULTY_ID", FACULTY_ID));
                command.Parameters.Add(new OracleParameter("CAMPUS_ID", CAMPUS_ID));
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
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

    public class ClassPersonStudyGraduateTop
    {
        public int STUDY_GRADUATE_TOP_ID { get; set; }
        public string GRAD_LEV_ID { get; set; }
        public string GRAD_CURR { get; set; }
        public string CITIZEN_ID { get; set; }
        




        public ClassPersonStudyGraduateTop() { }
        public ClassPersonStudyGraduateTop(int STUDY_GRADUATE_TOP_ID, string GRAD_LEV_ID, string GRAD_CURR, string CITIZEN_ID)
        {
            this.STUDY_GRADUATE_TOP_ID = STUDY_GRADUATE_TOP_ID;
            this.GRAD_LEV_ID = GRAD_LEV_ID;
            this.GRAD_CURR = GRAD_CURR;
            this.CITIZEN_ID = CITIZEN_ID;
            
        }

        public DataTable GetPersonStudyGraduateTop(string GRAD_LEV_ID, string GRAD_CURR, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_STUDY_GRADUATE_TOP ";
            if (!string.IsNullOrEmpty(GRAD_LEV_ID) || !string.IsNullOrEmpty(GRAD_CURR) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(GRAD_LEV_ID))
                {
                    query += " and GRAD_LEV_ID like :GRAD_LEV_ID ";
                }
                if (!string.IsNullOrEmpty(GRAD_CURR))
                {
                    query += " and GRAD_CURR like :GRAD_CURR ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(GRAD_LEV_ID))
                {
                    command.Parameters.Add(new OracleParameter("GRAD_LEV_ID", GRAD_LEV_ID + "%"));
                }
                if (!string.IsNullOrEmpty(GRAD_CURR))
                {
                    command.Parameters.Add(new OracleParameter("GRAD_CURR", "%" + GRAD_CURR + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonStudyGraduateTop()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_STUDY_GRADUATE_TOP (GRAD_LEV_ID,CITIZEN_ID,GRAD_CURR) VALUES (:GRAD_LEV_ID,:CITIZEN_ID,:GRAD_CURR)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("GRAD_LEV_ID", GRAD_LEV_ID));
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("GRAD_CURR", GRAD_CURR));

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

        public bool UpdatePersonStudyGraduateTop()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_STUDY_GRADUATE_TOP Set ";
            query += " GRAD_LEV_ID = :GRAD_LEV_ID ,";
            query += " GRAD_CURR = :GRAD_CURR ";
            query += " where STUDY_GRADUATE_TOP_ID  = :STUDY_GRADUATE_TOP_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("GRAD_LEV_ID", GRAD_LEV_ID));
                command.Parameters.Add(new OracleParameter("GRAD_CURR", GRAD_CURR));
                command.Parameters.Add(new OracleParameter("STUDY_GRADUATE_TOP_ID", STUDY_GRADUATE_TOP_ID));
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

        public bool DeletePersonStudyGraduateTop()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_STUDY_GRADUATE_TOP where STUDY_GRADUATE_TOP_ID = :STUDY_GRADUATE_TOP_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("STUDY_GRADUATE_TOP_ID", STUDY_GRADUATE_TOP_ID));
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

    public class ClassPersonStudyHistory
    {
        public int ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public string GRAD_UNIV { get; set; }
        public int MONTH_FROM { get; set; }
        public int YEAR_FROM { get; set; }
        public int MONTH_TO { get; set; }
        public int YEAR_TO { get; set; }
        public string MAJOR { get; set; }



        public ClassPersonStudyHistory() { }
        public ClassPersonStudyHistory(int ID, string CITIZEN_ID, string GRAD_UNIV, int MONTH_FROM, int YEAR_FROM, int MONTH_TO, int YEAR_TO, string MAJOR)
        {
            this.ID = ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.GRAD_UNIV = GRAD_UNIV;
            this.MONTH_FROM = MONTH_FROM;
            this.YEAR_FROM = YEAR_FROM;
            this.MONTH_TO = MONTH_TO;
            this.YEAR_TO = YEAR_TO;
            this.MAJOR = MAJOR;

        }

        public DataTable GetPersonStudyHistory(string GRAD_UNIV, string MONTH_FROM, string YEAR_FROM, string MONTH_TO, string YEAR_TO, string MAJOR, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_STUDY_HISTORY ";
            if (!string.IsNullOrEmpty(GRAD_UNIV) || !string.IsNullOrEmpty(MONTH_FROM) || !string.IsNullOrEmpty(YEAR_FROM) || !string.IsNullOrEmpty(MONTH_TO) || !string.IsNullOrEmpty(YEAR_TO) || !string.IsNullOrEmpty(MAJOR) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(GRAD_UNIV))
                {
                    query += " and GRAD_UNIV like :GRAD_UNIV ";
                }
                if (!string.IsNullOrEmpty(MONTH_FROM))
                {
                    query += " and MONTH_FROM like :MONTH_FROM ";
                }
                if (!string.IsNullOrEmpty(YEAR_FROM))
                {
                    query += " and YEAR_FROM like :YEAR_FROM ";
                }
                if (!string.IsNullOrEmpty(MONTH_TO))
                {
                    query += " and MONTH_TO like :MONTH_TO ";
                }
                if (!string.IsNullOrEmpty(YEAR_TO))
                {
                    query += " and YEAR_TO like :YEAR_TO ";
                }
                if (!string.IsNullOrEmpty(MAJOR))
                {
                    query += " and MAJOR like :MAJOR ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(GRAD_UNIV))
                {
                    command.Parameters.Add(new OracleParameter("GRAD_UNIV", "%" + GRAD_UNIV + "%"));
                }
                if (!string.IsNullOrEmpty(MONTH_FROM))
                {
                    command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM + "%"));
                }
                if (!string.IsNullOrEmpty(YEAR_FROM))
                {
                    command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM + "%"));
                }
                if (!string.IsNullOrEmpty(MONTH_TO))
                {
                    command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO + "%"));
                }
                if (!string.IsNullOrEmpty(YEAR_TO))
                {
                    command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO + "%"));
                }
                if (!string.IsNullOrEmpty(MAJOR))
                {
                    command.Parameters.Add(new OracleParameter("MAJOR", "%" + MAJOR + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonStudyHistory()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_STUDY_HISTORY (CITIZEN_ID,GRAD_UNIV,MONTH_FROM,YEAR_FROM,MONTH_TO,YEAR_TO,MAJOR) VALUES (:CITIZEN_ID,:GRAD_UNIV,:MONTH_FROM,:YEAR_FROM,:MONTH_TO,:YEAR_TO,:MAJOR)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("GRAD_UNIV", GRAD_UNIV));
                command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM));
                command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM));
                command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO));
                command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO));
                command.Parameters.Add(new OracleParameter("MAJOR", MAJOR));

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

        public bool UpdatePersonStudyHistory()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_STUDY_HISTORY Set ";
            query += " GRAD_UNIV = :GRAD_UNIV ,";
            query += " MONTH_FROM = :MONTH_FROM ,";
            query += " YEAR_FROM = :YEAR_FROM ,";
            query += " MONTH_TO = :MONTH_TO ,";
            query += " YEAR_TO = :YEAR_TO ,";
            query += " MAJOR = :MAJOR ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("GRAD_UNIV", GRAD_UNIV));
                command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM));
                command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM));
                command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO));
                command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO));
                command.Parameters.Add(new OracleParameter("MAJOR", MAJOR));
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

        public bool DeletePersonStudyHistory()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_STUDY_HISTORY where ID = :ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ID", ID));
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

    public class ClassPersonJobLisence
    {
        public int ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public string LICENCE_NAME { get; set; }
        public string BRANCH { get; set; }
        public string LICENCE_NO { get; set; }
        public DateTime DDATE { get; set; }



        public ClassPersonJobLisence() { }
        public ClassPersonJobLisence(int ID, string CITIZEN_ID, string LICENCE_NAME, string BRANCH, string LICENCE_NO, DateTime DDATE)
        {
            this.ID = ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.LICENCE_NAME = LICENCE_NAME;
            this.BRANCH = BRANCH;
            this.LICENCE_NO = LICENCE_NO;
            this.DDATE = DDATE;

        }

        public DataTable GetPersonJobLisence(string LICENCE_NAME, string BRANCH, string LICENCE_NO, string DDATE, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_JOB_LICENSE ";
            if (!string.IsNullOrEmpty(LICENCE_NAME) || !string.IsNullOrEmpty(BRANCH) || !string.IsNullOrEmpty(LICENCE_NO) || !string.IsNullOrEmpty(DDATE) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(LICENCE_NAME))
                {
                    query += " and LICENCE_NAME like :LICENCE_NAME ";
                }
                if (!string.IsNullOrEmpty(BRANCH))
                {
                    query += " and BRANCH like :BRANCH ";
                }
                if (!string.IsNullOrEmpty(LICENCE_NO))
                {
                    query += " and LICENCE_NO like :LICENCE_NO ";
                }
                if (!string.IsNullOrEmpty(DDATE))
                {
                    query += " and CONVERT(varchar(10),DDATE,103) = :DDATE ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(LICENCE_NAME))
                {
                    command.Parameters.Add(new OracleParameter("LICENCE_NAME", "%" + LICENCE_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(BRANCH))
                {
                    command.Parameters.Add(new OracleParameter("BRANCH", "%" + BRANCH + "%"));
                }
                if (!string.IsNullOrEmpty(LICENCE_NO))
                {
                    command.Parameters.Add(new OracleParameter("LICENCE_NO", "%" + LICENCE_NO + "%"));
                }
                if (!string.IsNullOrEmpty(DDATE))
                {
                    command.Parameters.Add(new OracleParameter("DDATE", DDATE));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonJobLisence()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_JOB_LICENSE (CITIZEN_ID,LICENCE_NAME,BRANCH,LICENCE_NO,DDATE) VALUES (:CITIZEN_ID,:LICENCE_NAME,:BRANCH,:LICENCE_NO,:DDATE)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                DateTime d = DDATE;
                d = d.AddYears(543);
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("LICENCE_NAME", LICENCE_NAME));
                command.Parameters.Add(new OracleParameter("BRANCH", BRANCH));
                command.Parameters.Add(new OracleParameter("LICENCE_NO", LICENCE_NO));
                command.Parameters.Add(new OracleParameter("DDATE", d));

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

        public bool UpdatePersonJobLisence()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_JOB_LICENSE Set ";
            query += " LICENCE_NAME = :LICENCE_NAME ,";
            query += " BRANCH = :BRANCH ,";
            query += " LICENCE_NO = :LICENCE_NO ,";
            query += " DDATE = :DDATE ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                DateTime d = DDATE;
                d = d.AddYears(543);
                command.Parameters.Add(new OracleParameter("LICENCE_NAME", LICENCE_NAME));
                command.Parameters.Add(new OracleParameter("BRANCH", BRANCH));
                command.Parameters.Add(new OracleParameter("LICENCE_NO", LICENCE_NO));
                command.Parameters.Add(new OracleParameter("DDATE", d));
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

        public bool DeletePersonJobLisence()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_JOB_LICENSE where ID = :ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ID", ID));
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

    public class ClassPersonTraining
    {
        public int ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public string COURSE { get; set; }
        public int MONTH_FROM { get; set; }
        public int YEAR_FROM { get; set; }
        public int MONTH_TO { get; set; }
        public int YEAR_TO { get; set; }
        public string BRANCH_TRAINING { get; set; }



        public ClassPersonTraining() { }
        public ClassPersonTraining(int ID, string CITIZEN_ID, string COURSE, int MONTH_FROM, int YEAR_FROM, int MONTH_TO, int YEAR_TO, string BRANCH_TRAINING)
        {
            this.ID = ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.COURSE = COURSE;
            this.MONTH_FROM = MONTH_FROM;
            this.YEAR_FROM = YEAR_FROM;
            this.MONTH_TO = MONTH_TO;
            this.YEAR_TO = YEAR_TO;
            this.BRANCH_TRAINING = BRANCH_TRAINING;

        }

        public DataTable GetPersonTraining(string COURSE, string MONTH_FROM, string YEAR_FROM, string MONTH_TO, string YEAR_TO, string BRANCH_TRAINING, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_TRAINING_HISTORY ";
            if (!string.IsNullOrEmpty(COURSE) || !string.IsNullOrEmpty(MONTH_FROM) || !string.IsNullOrEmpty(YEAR_FROM) || !string.IsNullOrEmpty(MONTH_TO) || !string.IsNullOrEmpty(YEAR_TO) || !string.IsNullOrEmpty(BRANCH_TRAINING) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(COURSE))
                {
                    query += " and COURSE like :COURSE ";
                }
                if (!string.IsNullOrEmpty(MONTH_FROM))
                {
                    query += " and MONTH_FROM like :MONTH_FROM ";
                }
                if (!string.IsNullOrEmpty(YEAR_FROM))
                {
                    query += " and YEAR_FROM like :YEAR_FROM ";
                }
                if (!string.IsNullOrEmpty(MONTH_TO))
                {
                    query += " and MONTH_TO like :MONTH_TO ";
                }
                if (!string.IsNullOrEmpty(YEAR_TO))
                {
                    query += " and YEAR_TO like :YEAR_TO ";
                }
                if (!string.IsNullOrEmpty(BRANCH_TRAINING))
                {
                    query += " and BRANCH_TRAINING like :BRANCH_TRAINING ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(COURSE))
                {
                    command.Parameters.Add(new OracleParameter("COURSE", "%" + COURSE + "%"));
                }
                if (!string.IsNullOrEmpty(MONTH_FROM))
                {
                    command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM + "%"));
                }
                if (!string.IsNullOrEmpty(YEAR_FROM))
                {
                    command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM + "%"));
                }
                if (!string.IsNullOrEmpty(MONTH_TO))
                {
                    command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO + "%"));
                }
                if (!string.IsNullOrEmpty(YEAR_TO))
                {
                    command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO + "%"));
                }
                if (!string.IsNullOrEmpty(BRANCH_TRAINING))
                {
                    command.Parameters.Add(new OracleParameter("BRANCH_TRAINING", "%" + BRANCH_TRAINING + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonTraining()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_TRAINING_HISTORY (CITIZEN_ID,COURSE,MONTH_FROM,YEAR_FROM,MONTH_TO,YEAR_TO,BRANCH_TRAINING) VALUES (:CITIZEN_ID,:COURSE,:MONTH_FROM,:YEAR_FROM,:MONTH_TO,:YEAR_TO,:BRANCH_TRAINING)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("COURSE", COURSE));
                command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM));
                command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM));
                command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO));
                command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO));
                command.Parameters.Add(new OracleParameter("BRANCH_TRAINING", BRANCH_TRAINING));

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

        public bool UpdatePersonTraining()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_TRAINING_HISTORY Set ";
            query += " COURSE = :COURSE ,";
            query += " MONTH_FROM = :MONTH_FROM ,";
            query += " YEAR_FROM = :YEAR_FROM ,";
            query += " MONTH_TO = :MONTH_TO ,";
            query += " YEAR_TO = :YEAR_TO ,";
            query += " BRANCH_TRAINING = :BRANCH_TRAINING ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("COURSE", COURSE));
                command.Parameters.Add(new OracleParameter("MONTH_FROM", MONTH_FROM));
                command.Parameters.Add(new OracleParameter("YEAR_FROM", YEAR_FROM));
                command.Parameters.Add(new OracleParameter("MONTH_TO", MONTH_TO));
                command.Parameters.Add(new OracleParameter("YEAR_TO", YEAR_TO));
                command.Parameters.Add(new OracleParameter("BRANCH_TRAINING", BRANCH_TRAINING));
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

        public bool DeletePersonTraining()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_TRAINING_HISTORY where ID = :ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ID", ID));
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

    public class ClassPersonDISCIPLINARY
    {
        public int ID { get; set; }
        public string CITIZEN_ID { get; set; }
        public int YEAR { get; set; }
        public string MENU { get; set; }
        public string REF_DOC { get; set; }



        public ClassPersonDISCIPLINARY() { }
        public ClassPersonDISCIPLINARY(int ID, string CITIZEN_ID, int YEAR, string MENU, string REF_DOC)
        {
            this.ID = ID;
            this.CITIZEN_ID = CITIZEN_ID;
            this.YEAR = YEAR;
            this.MENU = MENU;
            this.REF_DOC = REF_DOC;

        }

        public DataTable GetPersonDISCIPLINARY(string YEAR, string MENU, string REF_DOC, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_DISCIPLINARY_AND_AMNESTY ";
            if (!string.IsNullOrEmpty(YEAR) || !string.IsNullOrEmpty(MENU) || !string.IsNullOrEmpty(REF_DOC) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(YEAR))
                {
                    query += " and YEAR like :YEAR ";
                }
                if (!string.IsNullOrEmpty(MENU))
                {
                    query += " and MENU like :MENU ";
                }
                if (!string.IsNullOrEmpty(REF_DOC))
                {
                    query += " and REF_DOC like :REF_DOC ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(YEAR))
                {
                    command.Parameters.Add(new OracleParameter("YEAR", "%" + YEAR + "%"));
                }
                if (!string.IsNullOrEmpty(MENU))
                {
                    command.Parameters.Add(new OracleParameter("MENU", "%" + MENU + "%"));
                }
                if (!string.IsNullOrEmpty(REF_DOC))
                {
                    command.Parameters.Add(new OracleParameter("REF_DOC", "%" + REF_DOC + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonDISCIPLINARY()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_DISCIPLINARY_AND_AMNESTY (CITIZEN_ID,YEAR,MENU,REF_DOC) VALUES (:CITIZEN_ID,:YEAR,:MENU,:REF_DOC)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("YEAR", YEAR));
                command.Parameters.Add(new OracleParameter("MENU", MENU));
                command.Parameters.Add(new OracleParameter("REF_DOC", REF_DOC));

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

        public bool UpdatePersonDISCIPLINARY()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_DISCIPLINARY_AND_AMNESTY Set ";
            query += " YEAR = :YEAR ,";
            query += " MENU = :MENU ,";
            query += " REF_DOC = :REF_DOC ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("YEAR", YEAR));
                command.Parameters.Add(new OracleParameter("MENU", MENU));
                command.Parameters.Add(new OracleParameter("REF_DOC", REF_DOC));
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

        public bool DeletePersonDISCIPLINARY()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_DISCIPLINARY_AND_AMNESTY where ID = :ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ID", ID));
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

    public class ClassPersonPosiSalary
    {
        public int ID { get; set; }
        public DateTime DDATE { get; set; }
        public string POSITION_NAME { get; set; }
        public string PERSON_ID { get; set; }
        public int ST_ID { get; set; }
        public string POSITION_ID { get; set; }
        public int SALARY { get; set; }
        public int POSITION_SALARY { get; set; }
        public string REFERENCE_DOCUMENT { get; set; }
        public string CITIZEN_ID { get; set; }



        public ClassPersonPosiSalary() { }
        public ClassPersonPosiSalary(int ID, DateTime DDATE, string POSITION_NAME, string PERSON_ID, int ST_ID, string POSITION_ID, int SALARY, int POSITION_SALARY, string REFERENCE_DOCUMENT, string CITIZEN_ID)
        {
            this.ID = ID;
            this.DDATE = DDATE;
            this.POSITION_NAME = POSITION_NAME;
            this.PERSON_ID = PERSON_ID;
            this.ST_ID = ST_ID;
            this.POSITION_ID = POSITION_ID;
            this.SALARY = SALARY;
            this.POSITION_SALARY = POSITION_SALARY;
            this.REFERENCE_DOCUMENT = REFERENCE_DOCUMENT;
            this.CITIZEN_ID = CITIZEN_ID;
        }

        public DataTable GetPersonPosiSalary(string DDATE, string POSITION_NAME, string PERSON_ID, string ST_ID, int POSITION_ID, int SALARY, int POSITION_SALARY, string REFERENCE_DOCUMENT, string CITIZEN_ID)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_POSITION_AND_SALARY ";
            if (!string.IsNullOrEmpty(DDATE) || !string.IsNullOrEmpty(POSITION_NAME) || !string.IsNullOrEmpty(PERSON_ID) || !string.IsNullOrEmpty(ST_ID) || POSITION_ID != 0 || SALARY != 0 || POSITION_SALARY != 0 || !string.IsNullOrEmpty(REFERENCE_DOCUMENT) || !string.IsNullOrEmpty(CITIZEN_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(DDATE))
                {
                    query += " and CONVERT(varchar(10),DDATE,103) = :DDATE ";
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    query += " and POSITION_NAME like :POSITION_NAME ";
                }
                if (!string.IsNullOrEmpty(PERSON_ID))
                {
                    query += " and PERSON_ID like :PERSON_ID ";
                }
                if (!string.IsNullOrEmpty(ST_ID))
                {
                    query += " and ST_ID like :ST_ID ";
                }
                if (POSITION_ID != 0)
                {
                    query += " and POSITION_ID like :POSITION_ID ";
                }
                if (SALARY != 0)
                {
                    query += " and SALARY like :SALARY ";
                }
                if (POSITION_SALARY != 0)
                {
                    query += " and POSITION_SALARY like :POSITION_SALARY ";
                }
                if (!string.IsNullOrEmpty(REFERENCE_DOCUMENT))
                {
                    query += " and REFERENCE_DOCUMENT like :REFERENCE_DOCUMENT ";
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
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
                if (!string.IsNullOrEmpty(DDATE))
                {
                    command.Parameters.Add(new OracleParameter("DDATE", DDATE));
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_NAME", "%" + POSITION_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(PERSON_ID))
                {
                    command.Parameters.Add(new OracleParameter("PERSON_ID", PERSON_ID + "%"));
                }
                if (!string.IsNullOrEmpty(ST_ID))
                {
                    command.Parameters.Add(new OracleParameter("ST_ID", ST_ID + "%"));
                }
                if (POSITION_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID + "%"));
                }
                if (SALARY != 0)
                {
                    command.Parameters.Add(new OracleParameter("SALARY", SALARY + "%"));
                }
                if (POSITION_SALARY != 0)
                {
                    command.Parameters.Add(new OracleParameter("POSITION_SALARY", POSITION_SALARY + "%"));
                }
                if (!string.IsNullOrEmpty(REFERENCE_DOCUMENT))
                {
                    command.Parameters.Add(new OracleParameter("REFERENCE_DOCUMENT", "%" + REFERENCE_DOCUMENT + "%"));
                }
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID + "%"));
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

        public int InsertPersonPosiSalary()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_POSITION_AND_SALARY (DDATE,POSITION_NAME,PERSON_ID,ST_ID,POSITION_ID,SALARY,POSITION_SALARY,REFERENCE_DOCUMENT,CITIZEN_ID) VALUES (:DDATE,:POSITION_NAME,:PERSON_ID,:ST_ID,:POSITION_ID,:SALARY,:POSITION_SALARY,:REFERENCE_DOCUMENT,:CITIZEN_ID)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                DateTime d = DDATE;
                d = d.AddYears(543);
                command.Parameters.Add(new OracleParameter("DDATE", d));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("PERSON_ID", PERSON_ID));
                command.Parameters.Add(new OracleParameter("ST_ID", ST_ID));
                command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
                command.Parameters.Add(new OracleParameter("SALARY", SALARY));
                command.Parameters.Add(new OracleParameter("POSITION_SALARY", POSITION_SALARY));
                command.Parameters.Add(new OracleParameter("REFERENCE_DOCUMENT", REFERENCE_DOCUMENT));
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));

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

        public bool UpdatePersonPosiSalary()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_POSITION_AND_SALARY Set ";
            query += " DDATE = :DDATE ,";
            query += " POSITION_NAME = :POSITION_NAME ,";
            query += " PERSON_ID = :PERSON_ID ,";
            query += " ST_ID = :ST_ID ,";
            query += " POSITION_ID = :POSITION_ID ,";
            query += " SALARY = :SALARY ,";
            query += " POSITION_SALARY = :POSITION_SALARY ,";
            query += " REFERENCE_DOCUMENT = :REFERENCE_DOCUMENT ";
            query += " where ID  = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                DateTime d = DDATE;
                d = d.AddYears(543);
                command.Parameters.Add(new OracleParameter("DDATE", d));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("PERSON_ID", PERSON_ID));
                command.Parameters.Add(new OracleParameter("ST_ID", ST_ID));
                command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
                command.Parameters.Add(new OracleParameter("SALARY", SALARY));
                command.Parameters.Add(new OracleParameter("POSITION_SALARY", POSITION_SALARY));
                command.Parameters.Add(new OracleParameter("REFERENCE_DOCUMENT", REFERENCE_DOCUMENT));
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

        public bool DeletePersonPosiSalary()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_POSITION_AND_SALARY where ID = :ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ID", ID));
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
