using Rmutto.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class TITLENAME
    {

        public int TITLE_ID { get; set; }
        public string TITLE_NAME_TH { get; set; }
        public string TITLE_NAME_TH_MIN { get; set; }
        public string TITLE_NAME_EN { get; set; }
        public string TITLE_NAME_EN_MIN { get; set; }

        public TITLENAME() { }
        public TITLENAME(int TITLE_ID, string TITLE_NAME_TH, string TITLE_NAME_TH_MIN, string TITLE_NAME_EN, string TITLE_NAME_EN_MIN)
        {
            this.TITLE_ID = TITLE_ID;
            this.TITLE_NAME_TH = TITLE_NAME_TH;
            this.TITLE_NAME_TH_MIN = TITLE_NAME_TH_MIN;
            this.TITLE_NAME_EN = TITLE_NAME_EN;
            this.TITLE_NAME_EN_MIN = TITLE_NAME_EN_MIN;
        }

        public DataTable GetTITLENAME(string TITLE_NAME_TH, string TITLE_NAME_TH_MIN, string TITLE_NAME_EN, string TITLE_NAME_EN_MIN)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_TITLENAME ";
            if (!string.IsNullOrEmpty(TITLE_NAME_TH) || !string.IsNullOrEmpty(TITLE_NAME_TH_MIN) || !string.IsNullOrEmpty(TITLE_NAME_EN) || !string.IsNullOrEmpty(TITLE_NAME_EN_MIN))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(TITLE_NAME_TH))
                {
                    query += " and TITLE_NAME_TH like :TITLE_NAME_TH ";
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_TH_MIN))
                {
                    query += " and TITLE_NAME_TH_MIN like :TITLE_NAME_TH_MIN ";
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_EN))
                {
                    query += " and TITLE_NAME_EN like :TITLE_NAME_EN ";
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_EN_MIN))
                {
                    query += " and TITLE_NAME_EN_MIN like :TITLE_NAME_EN_MIN ";
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

                if (!string.IsNullOrEmpty(TITLE_NAME_TH))
                {
                    command.Parameters.Add(new OracleParameter("TITLE_NAME_TH", TITLE_NAME_TH + "%"));
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_TH_MIN))
                {
                    command.Parameters.Add(new OracleParameter("TITLE_NAME_TH_MIN", TITLE_NAME_TH_MIN + "%"));
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_EN))
                {
                    command.Parameters.Add(new OracleParameter("TITLE_NAME_EN", TITLE_NAME_EN + "%"));
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_EN_MIN))
                {
                    command.Parameters.Add(new OracleParameter("TITLE_NAME_EN_MIN", TITLE_NAME_EN_MIN + "%"));
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

        public int InsertTITLENAME()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_TITLENAME (TITLE_NAME_TH,TITLE_NAME_TH_MIN,TITLE_NAME_EN,TITLE_NAME_EN_MIN) VALUES (:TITLE_NAME_TH, :TITLE_NAME_TH_MIN, :TITLE_NAME_EN, :TITLE_NAME_EN_MIN)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TITLE_NAME_TH", TITLE_NAME_TH));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_TH_MIN", TITLE_NAME_TH_MIN));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_EN", TITLE_NAME_EN));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_EN_MIN", TITLE_NAME_EN_MIN));
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

        public bool UpdateTITLENAME()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_TITLENAME Set ";
            query += " TITLE_NAME_TH = :TITLE_NAME_TH,";
            query += " TITLE_NAME_TH_MIN = :TITLE_NAME_TH_MIN,";
            query += " TITLE_NAME_EN = :TITLE_NAME_EN,";
            query += " TITLE_NAME_EN_MIN = :TITLE_NAME_EN_MIN";
            query += " where TITLE_ID = :TITLE_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TITLE_NAME_TH", TITLE_NAME_TH));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_TH_MIN", TITLE_NAME_TH_MIN));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_EN", TITLE_NAME_EN));
                command.Parameters.Add(new OracleParameter("TITLE_NAME_EN_MIN", TITLE_NAME_EN_MIN));
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));

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
            }
            return result;
        }

        public bool DeleteTITLENAME()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_TITLENAME where TITLE_ID = :TITLE_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TITLE_ID", TITLE_ID));
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

    public class ClassYear
    {
        public int Year_ID { get; set; }
        public string Year_Name { get; set; }

        public ClassYear() { }
        public ClassYear(int Year_ID, string Year_Name)
        {
            this.Year_ID = Year_ID;
            this.Year_Name = Year_Name;
        }

        public DataTable GetYear(string Year_Name)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_YEAR order by Year_Name desc ";
            if (!string.IsNullOrEmpty(Year_Name))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(Year_Name))
                {
                    query += " and Year_Name like :Year_Name ";
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

                if (!string.IsNullOrEmpty(Year_Name))
                {
                    command.Parameters.Add(new OracleParameter("Year_Name", Year_Name + "%"));
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

        public DataTable GetYearSearch(string Year_Name)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_YEAR";
            if (!string.IsNullOrEmpty(Year_Name))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(Year_Name))
                {
                    query += " and Year_Name like :Year_Name ";
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

                if (!string.IsNullOrEmpty(Year_Name))
                {
                    command.Parameters.Add(new OracleParameter("Year_Name", Year_Name + "%"));
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

        public int InsertYear()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_YEAR (Year_Name) VALUES (:Year_Name)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Year_Name", Year_Name));
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

        public bool UpdateYear()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_Year Set ";
            query += " Year_Name = :Year_Name";
            query += " where Year_ID = :Year_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Year_Name", Year_Name));
                command.Parameters.Add(new OracleParameter("Year_ID", Year_ID));

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
            }
            return result;
        }

        public bool DeleteYear()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_Year where Year_ID = :Year_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Year_ID", Year_ID));
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

        public bool CheckUseYearName()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(Year_Name) FROM TB_Year WHERE Year_Name = :Year_Name ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("Year_Name", Year_Name));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassUniversity
    {
        public int UNIV_SEQ { get; set; }
        public string UNIV_ID { get; set; }
        public string UNIV_NAME { get; set; }

        public ClassUniversity() { }
        public ClassUniversity(int UNIV_SEQ, string UNIV_ID, string UNIV_NAME)
        {
            this.UNIV_SEQ = UNIV_SEQ;
            this.UNIV_ID = UNIV_ID;
            this.UNIV_NAME = UNIV_NAME;
        }

        public DataTable GetUniversity(string UNIV_ID, string UNIV_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_UNIVERSITY_V2 order by UNIV_ID asc ";
            if (!string.IsNullOrEmpty(UNIV_ID) || !string.IsNullOrEmpty(UNIV_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(UNIV_ID))
                {
                    query += " and UNIV_ID like :UNIV_ID ";
                }
                if (!string.IsNullOrEmpty(UNIV_NAME))
                {
                    query += " and UNIV_NAME like :UNIV_NAME ";
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

                if (!string.IsNullOrEmpty(UNIV_ID))
                {
                    command.Parameters.Add(new OracleParameter("UNIV_ID", UNIV_ID + "%"));
                }
                if (!string.IsNullOrEmpty(UNIV_NAME))
                {
                    command.Parameters.Add(new OracleParameter("UNIV_NAME", "%" + UNIV_NAME + "%"));
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

        public DataTable GetUniversitySearch(string UNIV_ID, string UNIV_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_UNIVERSITY_V2 ";
            if (!string.IsNullOrEmpty(UNIV_ID) || !string.IsNullOrEmpty(UNIV_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(UNIV_ID))
                {
                    query += " and UNIV_ID like :UNIV_ID ";
                }
                if (!string.IsNullOrEmpty(UNIV_NAME))
                {
                    query += " and UNIV_NAME like :UNIV_NAME ";
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

                if (!string.IsNullOrEmpty(UNIV_ID))
                {
                    command.Parameters.Add(new OracleParameter("UNIV_ID", UNIV_ID + "%"));
                }
                if (!string.IsNullOrEmpty(UNIV_NAME))
                {
                    command.Parameters.Add(new OracleParameter("UNIV_NAME", "%" + UNIV_NAME + "%"));
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

        public int InsertUniversity()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_UNIVERSITY_V2 (UNIV_ID,UNIV_NAME) VALUES (:UNIV_ID, :UNIV_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("UNIV_ID", UNIV_ID));
                command.Parameters.Add(new OracleParameter("UNIV_NAME", UNIV_NAME));
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

        public bool UpdateUniversity()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_UNIVERSITY_V2 Set ";
            query += " UNIV_ID = :UNIV_ID,";
            query += " UNIV_NAME = :UNIV_NAME";
            query += " where UNIV_SEQ = :UNIV_SEQ";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("UNIV_ID", UNIV_ID));
                command.Parameters.Add(new OracleParameter("UNIV_NAME", UNIV_NAME));
                command.Parameters.Add(new OracleParameter("UNIV_SEQ", UNIV_SEQ));
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
            }
            return result;
        }

        public bool DeleteUniversity()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_UNIVERSITY_V2 where UNIV_SEQ = :UNIV_SEQ", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("UNIV_SEQ", UNIV_SEQ));
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

        public bool CheckUseUniversityID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(UNIV_ID) FROM TB_UNIVERSITY_V2 WHERE UNIV_ID = :UNIV_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("UNIV_ID", UNIV_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassGender
    {
        public int Gender_ID { get; set; }
        public string Gender_Name { get; set; }

        public ClassGender() { }
        public ClassGender(int Gender_ID, string Gender_Name)
        {
            this.Gender_ID = Gender_ID;
            this.Gender_Name = Gender_Name;
        }

        public DataTable GetGender(int Gender_ID, string Gender_Name)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_GENDER order by Gender_ID asc";
            if (Gender_ID != 0 || !string.IsNullOrEmpty(Gender_Name))
            {
                query += " where 1=1 ";
                if (Gender_ID != 0)
                {
                    query += " and Gender_ID like :Gender_ID ";
                }
                if (!string.IsNullOrEmpty(Gender_Name))
                {
                    query += " and Gender_Name like :Gender_Name ";
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
                if (Gender_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID + "%"));
                }
                if (!string.IsNullOrEmpty(Gender_Name))
                {
                    command.Parameters.Add(new OracleParameter("Gender_Name", "%" + Gender_Name + "%"));
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

        public DataTable GetGenderSearch(int Gender_ID, string Gender_Name)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_GENDER";
            if (Gender_ID != 0 || !string.IsNullOrEmpty(Gender_Name))
            {
                query += " where 1=1 ";
                if (Gender_ID != 0)
                {
                    query += " and Gender_ID like :Gender_ID ";
                }
                if (!string.IsNullOrEmpty(Gender_Name))
                {
                    query += " and Gender_Name like :Gender_Name ";
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
                if (Gender_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID + "%"));
                }
                if (!string.IsNullOrEmpty(Gender_Name))
                {
                    command.Parameters.Add(new OracleParameter("Gender_Name", "%" + Gender_Name + "%"));
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

        public int InsertGender()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_GENDER (Gender_ID,Gender_Name) VALUES (:Gender_ID,:Gender_Name)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID));
                command.Parameters.Add(new OracleParameter("Gender_Name", Gender_Name));
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

        public bool UpdateGender()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_GENDER Set ";
            query += " Gender_ID = :Gender_ID,";
            query += " Gender_Name = :Gender_Name";
            query += " where Gender_ID = :Gender_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID));
                command.Parameters.Add(new OracleParameter("Gender_Name", Gender_Name));

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
            }
            return result;
        }

        public bool DeleteGender()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_GENDER where Gender_ID = :Gender_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID));
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

        public bool CheckUseGenderID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(Gender_ID) FROM TB_GENDER WHERE Gender_ID = :Gender_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassNational
    {
        public int NATION_SEQ { get; set; }
        public string NATION_ID { get; set; }
        public string NATION_ENG { get; set; }
        public string NATION_THA { get; set; }
        

        public ClassNational() { }
        public ClassNational(int NATION_SEQ, string NATION_ID, string NATION_ENG, string NATION_THA)
        {
            this.NATION_SEQ = NATION_SEQ;
            this.NATION_ID = NATION_ID;
            this.NATION_ENG = NATION_ENG;
            this.NATION_THA = NATION_THA;
        }

        public DataTable GetNational(string NATION_ID, string NATION_ENG, string NATION_THA)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_NATIONAL order by NATION_ENG asc ";
            if (!string.IsNullOrEmpty(NATION_ID) || !string.IsNullOrEmpty(NATION_ENG) || !string.IsNullOrEmpty(NATION_THA))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(NATION_ID))
                {
                    query += " and lower(NATION_ID) like lower (:NATION_ID) ";
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    query += " and lower(NATION_ENG) like lower (:NATION_ENG) ";
                }
                if (!string.IsNullOrEmpty(NATION_THA))
                {
                    query += " and NATION_THA like :NATION_THA ";
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

                if (!string.IsNullOrEmpty(NATION_ID))
                {
                    command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    command.Parameters.Add(new OracleParameter("NATION_ENG", "%" + NATION_ENG + "%"));
                }
                if (!string.IsNullOrEmpty(NATION_THA))
                {
                    command.Parameters.Add(new OracleParameter("NATION_THA", "%" + NATION_THA + "%"));
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

        public DataTable GetNationalSearch(string NATION_ID, string NATION_ENG, string NATION_THA)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_NATIONAL ";
            if (!string.IsNullOrEmpty(NATION_ID) || !string.IsNullOrEmpty(NATION_ENG) || !string.IsNullOrEmpty(NATION_THA))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(NATION_ID))
                {
                    query += " and lower(NATION_ID) like lower (:NATION_ID) ";
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    query += " and lower(NATION_ENG) like lower (:NATION_ENG) ";
                }
                if (!string.IsNullOrEmpty(NATION_THA))
                {
                    query += " and NATION_THA like :NATION_THA ";
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

                if (!string.IsNullOrEmpty(NATION_ID))
                {
                    command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    command.Parameters.Add(new OracleParameter("NATION_ENG", "%" + NATION_ENG + "%"));
                }
                if (!string.IsNullOrEmpty(NATION_THA))
                {
                    command.Parameters.Add(new OracleParameter("NATION_THA", "%" + NATION_THA + "%"));
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

        public int InsertNational()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_NATIONAL (NATION_ID,NATION_ENG,NATION_THA) VALUES (:NATION_ID,:NATION_ENG,:NATION_THA)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID));
                command.Parameters.Add(new OracleParameter("NATION_ENG", NATION_ENG));
                command.Parameters.Add(new OracleParameter("NATION_THA", NATION_THA));
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

        public bool UpdateNational()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_NATIONAL Set ";
            query += " NATION_ID = :NATION_ID,";
            query += " NATION_ENG = :NATION_ENG,";
            query += " NATION_THA = :NATION_THA";
            query += " where NATION_SEQ = :NATION_SEQ";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID));
                command.Parameters.Add(new OracleParameter("NATION_ENG", NATION_ENG));
                command.Parameters.Add(new OracleParameter("NATION_THA", NATION_THA));
                command.Parameters.Add(new OracleParameter("NATION_SEQ", NATION_SEQ));
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
            }
            return result;
        }

        public bool DeleteNational()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_NATIONAL where NATION_SEQ = :NATION_SEQ", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("NATION_SEQ", NATION_SEQ));
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

        public bool CheckUseNationID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(NATION_ID) FROM TB_NATIONAL WHERE NATION_ID = :NATION_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("NATION_ID", NATION_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassStaffType
    {
        public int STAFFTYPE_ID { get; set; }
        public string STAFFTYPE_NAME { get; set; }

        public ClassStaffType() { }
        public ClassStaffType(int STAFFTYPE_ID, string STAFFTYPE_NAME)
        {
            this.STAFFTYPE_ID = STAFFTYPE_ID;
            this.STAFFTYPE_NAME = STAFFTYPE_NAME;
        }

        public DataTable GetStaffType(int STAFFTYPE_ID, string STAFFTYPE_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_STAFFTYPE order by STAFFTYPE_ID asc";
            if (STAFFTYPE_ID != 0 || !string.IsNullOrEmpty(STAFFTYPE_NAME))
            {
                query += " where 1=1 ";
                if (STAFFTYPE_ID != 0)
                {
                    query += " and STAFFTYPE_ID like :STAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(STAFFTYPE_NAME))
                {
                    query += " and STAFFTYPE_NAME like :STAFFTYPE_NAME ";
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
                if (STAFFTYPE_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(STAFFTYPE_NAME))
                {
                    command.Parameters.Add(new OracleParameter("STAFFTYPE_NAME", "%" + STAFFTYPE_NAME + "%"));
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

        public DataTable GetStaffTypeSearch(int STAFFTYPE_ID, string STAFFTYPE_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_STAFFTYPE";
            if (STAFFTYPE_ID != 0 || !string.IsNullOrEmpty(STAFFTYPE_NAME))
            {
                query += " where 1=1 ";
                if (STAFFTYPE_ID != 0)
                {
                    query += " and STAFFTYPE_ID like :STAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(STAFFTYPE_NAME))
                {
                    query += " and STAFFTYPE_NAME like :STAFFTYPE_NAME ";
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
                if (STAFFTYPE_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(STAFFTYPE_NAME))
                {
                    command.Parameters.Add(new OracleParameter("STAFFTYPE_NAME", "%" + STAFFTYPE_NAME + "%"));
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

        public int InsertStaffType()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_STAFFTYPE (STAFFTYPE_ID,STAFFTYPE_NAME) VALUES (:STAFFTYPE_ID,:STAFFTYPE_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_NAME", STAFFTYPE_NAME));
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

        public bool UpdateStaffType()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_STAFFTYPE Set ";
            query += " STAFFTYPE_ID = :STAFFTYPE_ID,";
            query += " STAFFTYPE_NAME = :STAFFTYPE_NAME";
            query += " where STAFFTYPE_ID = :STAFFTYPE_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_NAME", STAFFTYPE_NAME));

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
            }
            return result;
        }

        public bool DeleteStaffType()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_STAFFTYPE where STAFFTYPE_ID = :STAFFTYPE_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
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

        public bool CheckUseStaffTypeID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(STAFFTYPE_ID) FROM TB_STAFFTYPE WHERE STAFFTYPE_ID = :STAFFTYPE_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassTimeContact
    {
        public int TIME_CONTACT_ID { get; set; }
        public string TIME_CONTACT_NAME { get; set; }

        public ClassTimeContact() { }
        public ClassTimeContact(int TIME_CONTACT_ID, string TIME_CONTACT_NAME)
        {
            this.TIME_CONTACT_ID = TIME_CONTACT_ID;
            this.TIME_CONTACT_NAME = TIME_CONTACT_NAME;
        }

        public DataTable GetTimeContact(int TIME_CONTACT_ID, string TIME_CONTACT_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_TIME_CONTACT order by TIME_CONTACT_ID asc";
            if (TIME_CONTACT_ID != 0 || !string.IsNullOrEmpty(TIME_CONTACT_NAME))
            {
                query += " where 1=1 ";
                if (TIME_CONTACT_ID != 0)
                {
                    query += " and TIME_CONTACT_ID like :TIME_CONTACT_ID ";
                }
                if (!string.IsNullOrEmpty(TIME_CONTACT_NAME))
                {
                    query += " and TIME_CONTACT_NAME like :TIME_CONTACT_NAME ";
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
                if (TIME_CONTACT_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID + "%"));
                }
                if (!string.IsNullOrEmpty(TIME_CONTACT_NAME))
                {
                    command.Parameters.Add(new OracleParameter("TIME_CONTACT_NAME", "%" + TIME_CONTACT_NAME + "%"));
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

        public DataTable GetTimeContactSearch(int TIME_CONTACT_ID, string TIME_CONTACT_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_TIME_CONTACT";
            if (TIME_CONTACT_ID != 0 || !string.IsNullOrEmpty(TIME_CONTACT_NAME))
            {
                query += " where 1=1 ";
                if (TIME_CONTACT_ID != 0)
                {
                    query += " and TIME_CONTACT_ID like :TIME_CONTACT_ID ";
                }
                if (!string.IsNullOrEmpty(TIME_CONTACT_NAME))
                {
                    query += " and TIME_CONTACT_NAME like :TIME_CONTACT_NAME ";
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
                if (TIME_CONTACT_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID + "%"));
                }
                if (!string.IsNullOrEmpty(TIME_CONTACT_NAME))
                {
                    command.Parameters.Add(new OracleParameter("TIME_CONTACT_NAME", "%" + TIME_CONTACT_NAME + "%"));
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

        public int InsertTimeContact()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_TIME_CONTACT (TIME_CONTACT_ID,TIME_CONTACT_NAME) VALUES (:TIME_CONTACT_ID,:TIME_CONTACT_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_NAME", TIME_CONTACT_NAME));
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

        public bool UpdateTimeContact()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_TIME_CONTACT Set ";
            query += " TIME_CONTACT_ID = :TIME_CONTACT_ID,";
            query += " TIME_CONTACT_NAME = :TIME_CONTACT_NAME";
            query += " where TIME_CONTACT_ID = :TIME_CONTACT_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_NAME", TIME_CONTACT_NAME));

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
            }
            return result;
        }

        public bool DeleteTimeContact()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_TIME_CONTACT where TIME_CONTACT_ID = :TIME_CONTACT_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
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

        public bool CheckUseTimeContactID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(TIME_CONTACT_ID) FROM TB_TIME_CONTACT WHERE TIME_CONTACT_ID = :TIME_CONTACT_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("TIME_CONTACT_ID", TIME_CONTACT_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassBudget
    {
        public int BUDGET_ID { get; set; }
        public string BUDGET_NAME { get; set; }

        public ClassBudget() { }
        public ClassBudget(int BUDGET_ID, string BUDGET_NAME)
        {
            this.BUDGET_ID = BUDGET_ID;
            this.BUDGET_NAME = BUDGET_NAME;
        }

        public DataTable GetBudget(int BUDGET_ID, string BUDGET_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_BUDGET order by BUDGET_ID asc";
            if (BUDGET_ID != 0 || !string.IsNullOrEmpty(BUDGET_NAME))
            {
                query += " where 1=1 ";
                if (BUDGET_ID != 0)
                {
                    query += " and BUDGET_ID like :BUDGET_ID ";
                }
                if (!string.IsNullOrEmpty(BUDGET_NAME))
                {
                    query += " and BUDGET_NAME like :BUDGET_NAME ";
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
                if (BUDGET_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID + "%"));
                }
                if (!string.IsNullOrEmpty(BUDGET_NAME))
                {
                    command.Parameters.Add(new OracleParameter("BUDGET_NAME", "%" + BUDGET_NAME + "%"));
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

        public DataTable GetBudgetSearch(int BUDGET_ID, string BUDGET_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_BUDGET";
            if (BUDGET_ID != 0 || !string.IsNullOrEmpty(BUDGET_NAME))
            {
                query += " where 1=1 ";
                if (BUDGET_ID != 0)
                {
                    query += " and BUDGET_ID like :BUDGET_ID ";
                }
                if (!string.IsNullOrEmpty(BUDGET_NAME))
                {
                    query += " and BUDGET_NAME like :BUDGET_NAME ";
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
                if (BUDGET_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID + "%"));
                }
                if (!string.IsNullOrEmpty(BUDGET_NAME))
                {
                    command.Parameters.Add(new OracleParameter("BUDGET_NAME", "%" + BUDGET_NAME + "%"));
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

        public int InsertBudget()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_BUDGET (BUDGET_ID,BUDGET_NAME) VALUES (:BUDGET_ID,:BUDGET_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
                command.Parameters.Add(new OracleParameter("BUDGET_NAME", BUDGET_NAME));
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

        public bool UpdateBudget()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_BUDGET Set ";
            query += " BUDGET_ID = :BUDGET_ID,";
            query += " BUDGET_NAME = :BUDGET_NAME";
            query += " where BUDGET_ID = :BUDGET_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
                command.Parameters.Add(new OracleParameter("BUDGET_NAME", BUDGET_NAME));

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
            }
            return result;
        }

        public bool DeleteBudget()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_BUDGET where BUDGET_ID = :BUDGET_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
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

        public bool CheckUseBudgetID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(BUDGET_ID) FROM TB_BUDGET WHERE BUDGET_ID = :BUDGET_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("BUDGET_ID", BUDGET_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassSubStaffType
    {
        public int SUBSTAFFTYPE_ID { get; set; }
        public string SUBSTAFFTYPE_NAME { get; set; }


        public ClassSubStaffType() { }
        public ClassSubStaffType(int SUBSTAFFTYPE_ID, string SUBSTAFFTYPE_NAME)
        {
            this.SUBSTAFFTYPE_ID = SUBSTAFFTYPE_ID;
            this.SUBSTAFFTYPE_NAME = SUBSTAFFTYPE_NAME;
        }

        public DataTable GetSubStaffType(int SUBSTAFFTYPE_ID, string SUBSTAFFTYPE_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_SUBSTAFFTYPE order by SUBSTAFFTYPE_ID asc";
            if (SUBSTAFFTYPE_ID != 0 || !string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
            {
                query += " where 1=1 ";
                if (SUBSTAFFTYPE_ID != 0)
                {
                    query += " and SUBSTAFFTYPE_ID like :SUBSTAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
                {
                    query += " and SUBSTAFFTYPE_NAME like :SUBSTAFFTYPE_NAME ";
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

                if (SUBSTAFFTYPE_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_NAME", "%" + SUBSTAFFTYPE_NAME + "%"));
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

        public DataTable GetSubStaffTypeSearch(int SUBSTAFFTYPE_ID, string SUBSTAFFTYPE_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_SUBSTAFFTYPE ";
            if (SUBSTAFFTYPE_ID != 0 || !string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
            {
                query += " where 1=1 ";
                if (SUBSTAFFTYPE_ID != 0)
                {
                    query += " and SUBSTAFFTYPE_ID like :SUBSTAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
                {
                    query += " and SUBSTAFFTYPE_NAME like :SUBSTAFFTYPE_NAME ";
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

                if (SUBSTAFFTYPE_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_NAME))
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_NAME", "%" + SUBSTAFFTYPE_NAME + "%"));
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

        public int InsertSubStaffType()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_SUBSTAFFTYPE (SUBSTAFFTYPE_ID,SUBSTAFFTYPE_NAME) VALUES (:SUBSTAFFTYPE_ID,:SUBSTAFFTYPE_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_NAME", SUBSTAFFTYPE_NAME));
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

        public bool UpdateSubStaffType()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_SUBSTAFFTYPE Set ";
            query += " SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID,";
            query += " SUBSTAFFTYPE_NAME = :SUBSTAFFTYPE_NAME";
            query += " where SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_NAME", SUBSTAFFTYPE_NAME));

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
            }
            return result;
        }

        public bool DeleteSubStaffType()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_SUBSTAFFTYPE where SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
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
        public bool CheckUseSubStaffTypeID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(SUBSTAFFTYPE_ID) FROM TB_SUBSTAFFTYPE WHERE SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassAdminPosition
    {
        public string ADMIN_POSITION_ID { get; set; }
        public string ADMIN_POSITION_NAME { get; set; }

        public ClassAdminPosition() { }
        public ClassAdminPosition(string ADMIN_POSITION_ID, string ADMIN_POSITION_NAME)
        {
            this.ADMIN_POSITION_ID = ADMIN_POSITION_ID;
            this.ADMIN_POSITION_NAME = ADMIN_POSITION_NAME;
        }

        public DataTable GetAdminPosition(string ADMIN_POSITION_ID, string ADMIN_POSITION_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_ADMIN_POSITION order by ADMIN_POSITION_ID asc ";
            if (!string.IsNullOrEmpty(ADMIN_POSITION_ID) || !string.IsNullOrEmpty(ADMIN_POSITION_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(ADMIN_POSITION_ID))
                {
                    query += " and ADMIN_POSITION_ID like :ADMIN_POSITION_ID ";
                }
                if (!string.IsNullOrEmpty(ADMIN_POSITION_NAME))
                {
                    query += " and ADMIN_POSITION_NAME like :ADMIN_POSITION_NAME ";
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
                if (!string.IsNullOrEmpty(ADMIN_POSITION_ID))
                {
                    command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(ADMIN_POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("ADMIN_POSITION_NAME", "%" + ADMIN_POSITION_NAME + "%"));
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

        public DataTable GetAdminPositionSearch(string ADMIN_POSITION_ID, string ADMIN_POSITION_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_ADMIN_POSITION";
            if (!string.IsNullOrEmpty(ADMIN_POSITION_ID) || !string.IsNullOrEmpty(ADMIN_POSITION_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(ADMIN_POSITION_ID))
                {
                    query += " and ADMIN_POSITION_ID like :ADMIN_POSITION_ID ";
                }
                if (!string.IsNullOrEmpty(ADMIN_POSITION_NAME))
                {
                    query += " and ADMIN_POSITION_NAME like :ADMIN_POSITION_NAME ";
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
                if (!string.IsNullOrEmpty(ADMIN_POSITION_ID))
                {
                    command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(ADMIN_POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("ADMIN_POSITION_NAME", "%" + ADMIN_POSITION_NAME + "%"));
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

        public int InsertAdminPosition()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_ADMIN_POSITION (ADMIN_POSITION_ID,ADMIN_POSITION_NAME) VALUES (:ADMIN_POSITION_ID,:ADMIN_POSITION_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_NAME", ADMIN_POSITION_NAME));
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

        public bool UpdateAdminPosition()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_ADMIN_POSITION Set ";
            query += " ADMIN_POSITION_ID = :ADMIN_POSITION_ID,";
            query += " ADMIN_POSITION_NAME = :ADMIN_POSITION_NAME";
            query += " where ADMIN_POSITION_ID = :ADMIN_POSITION_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_NAME", ADMIN_POSITION_NAME));

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
            }
            return result;
        }

        public bool DeleteAdminPosition()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_ADMIN_POSITION where ADMIN_POSITION_ID = :ADMIN_POSITION_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
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

        public bool CheckUseAdminPositionID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(ADMIN_POSITION_ID) FROM TB_ADMIN_POSITION WHERE ADMIN_POSITION_ID = :ADMIN_POSITION_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("ADMIN_POSITION_ID", ADMIN_POSITION_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassPosition
    {
        public int SUBSTAFFTYPE_ID { get; set; }
        public string POSITION_ID { get; set; }
        public string POSITION_NAME { get; set; }
        

        public ClassPosition() { }
        public ClassPosition(string POSITION_ID, string POSITION_NAME, int SUBSTAFFTYPE_ID)
        {
            this.SUBSTAFFTYPE_ID = SUBSTAFFTYPE_ID;
            this.POSITION_ID = POSITION_ID;
            this.POSITION_NAME = POSITION_NAME;
            
        }

        public DataTable GetPosition(int SUBSTAFFTYPE_ID, string POSITION_ID, string POSITION_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_POSITION order by POSITION_ID asc ";
            if (!string.IsNullOrEmpty(POSITION_ID) || !string.IsNullOrEmpty(POSITION_NAME) || SUBSTAFFTYPE_ID != 0)
            {
                query += " where 1=1 ";
                if (SUBSTAFFTYPE_ID != 0)
                {
                    query += " and SUBSTAFFTYPE_ID like :SUBSTAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_ID))
                {
                    query += " and POSITION_ID like :POSITION_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    query += " and POSITION_NAME like :POSITION_NAME ";
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
                if (SUBSTAFFTYPE_ID != 0)
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_ID))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_NAME", "%" + POSITION_NAME + "%"));
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

        public DataTable GetPositionSearch(string SUBSTAFFTYPE_ID, string POSITION_ID, string POSITION_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_POSITION";
            if (!string.IsNullOrEmpty(POSITION_ID) || !string.IsNullOrEmpty(POSITION_NAME) || !string.IsNullOrEmpty(SUBSTAFFTYPE_ID))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_ID))
                {
                    query += " and SUBSTAFFTYPE_ID like :SUBSTAFFTYPE_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_ID))
                {
                    query += " and POSITION_ID like :POSITION_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    query += " and POSITION_NAME like :POSITION_NAME ";
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
                if (!string.IsNullOrEmpty(SUBSTAFFTYPE_ID))
                {
                    command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_ID))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_NAME", "%" + POSITION_NAME + "%"));
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

        public int InsertPosition()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_POSITION (POSITION_ID,POSITION_NAME,SUBSTAFFTYPE_ID) VALUES (:POSITION_ID,:POSITION_NAME,:SUBSTAFFTYPE_ID)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));
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

        public bool UpdatePosition()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_POSITION Set ";
            query += " POSITION_ID = :POSITION_ID,";
            query += " POSITION_NAME = :POSITION_NAME,";
            query += " SUBSTAFFTYPE_ID = :SUBSTAFFTYPE_ID";
            query += " where POSITION_ID = :POSITION_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("SUBSTAFFTYPE_ID", SUBSTAFFTYPE_ID));

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
            }
            return result;
        }

        public bool DeletePosition()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_POSITION where POSITION_ID = :POSITION_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
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

        public bool CheckUsePositionID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(POSITION_ID) FROM TB_POSITION WHERE POSITION_ID = :POSITION_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("POSITION_ID", POSITION_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassPositionWork
    {
        public string POSITION_WORK_ID { get; set; }
        public string POSITION_WORK_NAME { get; set; }

        public ClassPositionWork() { }
        public ClassPositionWork(string POSITION_WORK_ID, string POSITION_WORK_NAME)
        {
            this.POSITION_WORK_ID = POSITION_WORK_ID;
            this.POSITION_WORK_NAME = POSITION_WORK_NAME;
        }

        public DataTable GetPositionWork(string POSITION_WORK_ID, string POSITION_WORK_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_POSITION_WORK order by POSITION_WORK_ID asc ";
            if (!string.IsNullOrEmpty(POSITION_WORK_ID) || !string.IsNullOrEmpty(POSITION_WORK_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(POSITION_WORK_ID))
                {
                    query += " and POSITION_WORK_ID like :POSITION_WORK_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    query += " and POSITION_WORK_NAME like :POSITION_WORK_NAME ";
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
                if (!string.IsNullOrEmpty(POSITION_WORK_ID))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", "%" + POSITION_WORK_NAME + "%"));
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

        public DataTable GetPositionWorkSearch(string POSITION_WORK_ID, string POSITION_WORK_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_POSITION_WORK";
            if (!string.IsNullOrEmpty(POSITION_WORK_ID) || !string.IsNullOrEmpty(POSITION_WORK_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(POSITION_WORK_ID))
                {
                    query += " and POSITION_WORK_ID like :POSITION_WORK_ID ";
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    query += " and POSITION_WORK_NAME like :POSITION_WORK_NAME ";
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
                if (!string.IsNullOrEmpty(POSITION_WORK_ID))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", "%" + POSITION_WORK_NAME + "%"));
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

        public int InsertPositionWork()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_POSITION_WORK (POSITION_WORK_ID,POSITION_WORK_NAME) VALUES (:POSITION_WORK_ID,:POSITION_WORK_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", POSITION_WORK_NAME));
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

        public bool UpdatePositionWork()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_POSITION_WORK Set ";
            query += " POSITION_WORK_ID = :POSITION_WORK_ID,";
            query += " POSITION_WORK_NAME = :POSITION_WORK_NAME";
            query += " where POSITION_WORK_ID = :POSITION_WORK_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", POSITION_WORK_NAME));

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
            }
            return result;
        }

        public bool DeletePositionWork()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_POSITION_WORK where POSITION_WORK_ID = :POSITION_WORK_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
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

        public bool CheckUsePositionWorkID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(POSITION_WORK_ID) FROM TB_POSITION_WORK WHERE POSITION_WORK_ID = :POSITION_WORK_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("POSITION_WORK_ID", POSITION_WORK_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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

    public class ClassDepartment
    {
        public string DEPARTMENT_ID { get; set; }
        public string DEPARTMENT_NAME { get; set; }

        public ClassDepartment() { }
        public ClassDepartment(string DEPARTMENT_ID, string DEPARTMENT_NAME)
        {
            this.DEPARTMENT_ID = DEPARTMENT_ID;
            this.DEPARTMENT_NAME = DEPARTMENT_NAME;
        }

        public DataTable GetDepartment(string DEPARTMENT_ID, string DEPARTMENT_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_DEPARTMENT order by DEPARTMENT_ID asc ";
            if (!string.IsNullOrEmpty(DEPARTMENT_ID) || !string.IsNullOrEmpty(DEPARTMENT_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(DEPARTMENT_ID))
                {
                    query += " and DEPARTMENT_ID like :DEPARTMENT_ID ";
                }
                if (!string.IsNullOrEmpty(DEPARTMENT_NAME))
                {
                    query += " and DEPARTMENT_NAME like :DEPARTMENT_NAME ";
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
                if (!string.IsNullOrEmpty(DEPARTMENT_ID))
                {
                    command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID + "%"));
                }
                if (!string.IsNullOrEmpty(DEPARTMENT_NAME))
                {
                    command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", "%" + DEPARTMENT_NAME + "%"));
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

        public DataTable GetDepartmentSearch(string DEPARTMENT_ID, string DEPARTMENT_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_DEPARTMENT";
            if (!string.IsNullOrEmpty(DEPARTMENT_ID) || !string.IsNullOrEmpty(DEPARTMENT_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(DEPARTMENT_ID))
                {
                    query += " and DEPARTMENT_ID like :DEPARTMENT_ID ";
                }
                if (!string.IsNullOrEmpty(DEPARTMENT_NAME))
                {
                    query += " and DEPARTMENT_NAME like :DEPARTMENT_NAME ";
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
                if (!string.IsNullOrEmpty(DEPARTMENT_ID))
                {
                    command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID + "%"));
                }
                if (!string.IsNullOrEmpty(DEPARTMENT_NAME))
                {
                    command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", "%" + DEPARTMENT_NAME + "%"));
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

        public int InsertDepartment()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_DEPARTMENT (DEPARTMENT_ID,DEPARTMENT_NAME) VALUES (:DEPARTMENT_ID,:DEPARTMENT_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));
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

        public bool UpdateDepartment()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_DEPARTMENT Set ";
            query += " DEPARTMENT_ID = :DEPARTMENT_ID,";
            query += " DEPARTMENT_NAME = :DEPARTMENT_NAME";
            query += " where DEPARTMENT_ID = :DEPARTMENT_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID));
                command.Parameters.Add(new OracleParameter("DEPARTMENT_NAME", DEPARTMENT_NAME));

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
            }
            return result;
        }

        public bool DeleteDepartment()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_DEPARTMENT where DEPARTMENT_ID = :DEPARTMENT_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID));
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

        public bool CheckUseDepartmentID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(DEPARTMENT_ID) FROM TB_DEPARTMENT WHERE DEPARTMENT_ID = :DEPARTMENT_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("DEPARTMENT_ID", DEPARTMENT_ID));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)(decimal)command.ExecuteScalar();
                if (count >= 1)
                {
                    result = false;
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
