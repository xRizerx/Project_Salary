using Rmutto.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class ClassMinistry
    {

        public int MINISTRY_ID { get; set; }
        public string MINISTRY_NAME { get; set; }

        public ClassMinistry() { }
        public ClassMinistry(int MINISTRY_ID, string MINISTRY_NAME)
        {
            this.MINISTRY_ID = MINISTRY_ID;
            this.MINISTRY_NAME = MINISTRY_NAME;

        }

        public DataTable GetMinistry(string MINISTRY_ID, string MINISTRY_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_MINISTRY";
            if (!string.IsNullOrEmpty(MINISTRY_ID) || !string.IsNullOrEmpty(MINISTRY_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(MINISTRY_ID))
                {
                    query += " and MINISTRY_ID like :MINISTRY_ID ";
                }
                if (!string.IsNullOrEmpty(MINISTRY_NAME))
                {
                    query += " and MINISTRY_NAME like :MINISTRY_NAME ";
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
                if (!string.IsNullOrEmpty(MINISTRY_ID))
                {
                    command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID + "%"));
                }
                if (!string.IsNullOrEmpty(MINISTRY_NAME))
                {
                    command.Parameters.Add(new OracleParameter("MINISTRY_NAME", "%" + MINISTRY_NAME + "%"));
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

        public DataTable GetMinistrySearch(string MINISTRY_ID, string MINISTRY_NAME)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_MINISTRY";
            if (!string.IsNullOrEmpty(MINISTRY_ID) || !string.IsNullOrEmpty(MINISTRY_NAME))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(MINISTRY_ID))
                {
                    query += " and MINISTRY_ID like :MINISTRY_ID ";
                }
                if (!string.IsNullOrEmpty(MINISTRY_NAME))
                {
                    query += " and MINISTRY_NAME like :MINISTRY_NAME ";
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
                if (!string.IsNullOrEmpty(MINISTRY_ID))
                {
                    command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID + "%"));
                }
                if (!string.IsNullOrEmpty(MINISTRY_NAME))
                {
                    command.Parameters.Add(new OracleParameter("MINISTRY_NAME", "%" + MINISTRY_NAME + "%"));
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


        public int InsertMINISTRY()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_MINISTRY (MINISTRY_ID,MINISTRY_NAME) VALUES (:MINISTRY_ID,:MINISTRY_NAME)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("MINISTRY_NAME", MINISTRY_NAME));

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

        public bool UpdateMINISTRY()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_MINISTRY Set ";
            query += " MINISTRY_ID = :MINISTRY_ID,";
            query += " MINISTRY_NAME = :MINISTRY_NAME";
            query += " where MINISTRY_ID = :MINISTRY_ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
                command.Parameters.Add(new OracleParameter("MINISTRY_NAME", MINISTRY_NAME));

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

        public bool DeleteMINISTRY()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_MINISTRY where MINISTRY_ID = :MINISTRY_ID", conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
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

        public bool CheckUseMINISTRYID()
        {
            bool result = true;
            OracleConnection conn = ConnectionDB.GetOracleConnection();

            // Create the command
            OracleCommand command = new OracleCommand("SELECT count(MINISTRY_ID) FROM TB_MINISTRY WHERE MINISTRY_ID = :MINISTRY_ID ", conn);

            // Add the parameters.
            command.Parameters.Add(new OracleParameter("MINISTRY_ID", MINISTRY_ID));
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
