using WEB_PERSONAL.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public TITLENAME(int TITLEID, string TITLENAMETH, string TITLENAMETHMIN, string TITLENAMEEN, string TITLENAMEENMIN)
        {
            this.TITLE_ID = TITLEID;
            this.TITLE_NAME_TH = TITLENAMETH;
            this.TITLE_NAME_TH_MIN = TITLENAMETHMIN;
            this.TITLE_NAME_EN = TITLENAMEEN;
            this.TITLE_NAME_EN_MIN = TITLENAMEENMIN;
        }

        public DataTable GetTITLENAME(string TITLENAMETH, string TITLENAMEEN)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            string query = "SELECT * FROM TB_TITLENAME ";
            if (!string.IsNullOrEmpty(TITLENAMETH) || !string.IsNullOrEmpty(TITLENAMEEN))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(TITLE_NAME_TH))
                {
                    query += " and TITLE_NAME_TH like @TITLENAMETH ";
                }
                if (!string.IsNullOrEmpty(TITLE_NAME_EN))
                {
                    query += " and TITLE_NAME_EN like @TITLENAMEEN ";
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

                if (!string.IsNullOrEmpty(TITLENAMETH))
                {
                    command.Parameters.Add(new SqlParameter("TITLENAMETH", TITLENAMETH + "%"));
                }
                if (!string.IsNullOrEmpty(TITLENAMEEN))
                {
                    command.Parameters.Add(new SqlParameter("TITLENAMEEN", TITLENAMEEN));
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

        public int InsertTITLENAME()
        {
            int id = 0;
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("INSERT INTO TB_TITLENAME (TITLE_NAME_TH,TITLE_NAME_TH_MIN,TITLE_NAME_EN,TITLE_NAME_EN_MIN) VALUES (@TITLE_NAME_TH, @TITLE_NAME_TH_MIN, @TITLE_NAME_EN, @TITLE_NAME_EN_MIN)", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("TITLE_NAME_TH", TITLE_NAME_TH));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_TH_MIN", TITLE_NAME_TH_MIN));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_EN", TITLE_NAME_EN));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_EN_MIN", TITLE_NAME_EN_MIN));
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
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            string query = "Update TB_TITLENAME Set ";
            query += " TITLE_NAME_TH = @TITLE_NAME_TH,";
            query += " TITLE_NAME_TH_MIN = @TITLE_NAME_TH_MIN,";
            query += " TITLE_NAME_EN = @TITLE_NAME_EN,";
            query += " TITLE_NAME_EN_MIN = @TITLE_NAME_EN_MIN";
            query += " where TITLE_ID = @TITLE_ID";

            SqlCommand command = new SqlCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("TITLE_NAME_TH", TITLE_NAME_TH));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_TH_MIN", TITLE_NAME_TH_MIN));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_EN", TITLE_NAME_EN));
                command.Parameters.Add(new SqlParameter("TITLE_NAME_EN_MIN", TITLE_NAME_EN_MIN));
                command.Parameters.Add(new SqlParameter("TITLE_ID", TITLE_ID));

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
            SqlConnection conn = ConnectionDB.GetSqlConnection();
            SqlCommand command = new SqlCommand("Delete TB_TITLENAME where TITLE_ID = @TITLE_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new SqlParameter("TITLE_ID", TITLE_ID));
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
        public bool CheckUseTitleName()
        {
            bool result = true;
            SqlConnection conn = ConnectionDB.GetSqlConnection();

            // Create the command
            SqlCommand command = new SqlCommand("SELECT count(TITLE_ID) FROM TB_TITLENAME WHERE TITLE_NAME_TH = @TITLE_NAME_TH ", conn);

            // Add the parameters.
            command.Parameters.Add(new SqlParameter("TITLE_NAME_TH", TITLE_NAME_TH));
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int count = (int)command.ExecuteScalar();
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