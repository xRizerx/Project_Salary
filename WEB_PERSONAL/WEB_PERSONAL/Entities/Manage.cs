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

        public DataTable GetGender(string Gender_Name)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_GENDER ";
            if (!string.IsNullOrEmpty(Gender_Name))
            {
                query += " where 1=1 ";
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

                if (!string.IsNullOrEmpty(Gender_Name))
                {
                    command.Parameters.Add(new OracleParameter("Gender_Name", Gender_Name + "%"));
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
            OracleCommand command = new OracleCommand("INSERT INTO TB_GENDER (Gender_Name) VALUES (:Gender_Name)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
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
            query += " Gender_Name = :Gender_Name";
            query += " where Gender_ID = :Gender_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("Gender_Name", Gender_Name));
                command.Parameters.Add(new OracleParameter("Gender_ID", Gender_ID));

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
                    query += " and NATION_ID like :NATION_ID ";
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    query += " and NATION_ENG like :NATION_ENG ";
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
                    query += " and NATION_ID like :NATION_ID ";
                }
                if (!string.IsNullOrEmpty(NATION_ENG))
                {
                    query += " and NATION_ENG like :NATION_ENG ";
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

        public DataTable GetStaffType(string STAFFTYPE_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_STAFFTYPE ";
            if (!string.IsNullOrEmpty(STAFFTYPE_NAME))
            {
                query += " where 1=1 ";
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
            OracleCommand command = new OracleCommand("INSERT INTO TB_STAFFTYPE (STAFFTYPE_NAME) VALUES (:STAFFTYPE_NAME)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
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
            query += " STAFFTYPE_NAME = :STAFFTYPE_NAME";
            query += " where STAFFTYPE_ID = :STAFFTYPE_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("STAFFTYPE_NAME", STAFFTYPE_NAME));
                command.Parameters.Add(new OracleParameter("STAFFTYPE_ID", STAFFTYPE_ID));

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
    }

}
 