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
}
 