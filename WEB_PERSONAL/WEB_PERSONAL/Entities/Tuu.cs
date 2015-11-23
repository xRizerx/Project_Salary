using Rmutto.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace WEB_PERSONAL.Entities
{
    public class ClassInsigRecord2
    {
        public string CITIZEN_ID { get; set; }
        public DateTime DATE { get; set; }
        public string POSITION_WORK_NAME { get; set; }
        public string POSITION_NAME { get; set; }
        public string GRADEINSIGNIA_NAME { get; set; }
        public string GAZETTE_LAM { get; set; }
        public string GAZETTE_TON { get; set; }
        public string GAZETTE_NA { get; set; }
        public DateTime GAZETTE_DATE { get; set; }
        public string INVOICE { get; set; }
        public string DECORATION { get; set; }
        public string NOTES { get; set; }
        public int ID { get; set; }

        public ClassInsigRecord2() { }
        public ClassInsigRecord2(string CITIZEN_ID, DateTime DATE, string POSITION_WORK_NAME, string POSITION_NAME, string GRADEINSIGNIA_NAME, string GAZETTE_LAM, string GAZETTE_TON, string GAZETTE_NA, DateTime GAZETTE_DATE, string INVOICE, string DECORATION, string NOTES, int ID)
        {
            this.CITIZEN_ID = CITIZEN_ID;
            this.DATE = DATE;
            this.POSITION_WORK_NAME = POSITION_WORK_NAME;
            this.POSITION_NAME = POSITION_NAME;
            this.GRADEINSIGNIA_NAME = GRADEINSIGNIA_NAME;
            this.GAZETTE_LAM = GAZETTE_LAM;
            this.GAZETTE_TON = GAZETTE_TON;
            this.GAZETTE_NA = GAZETTE_NA;
            this.GAZETTE_DATE = GAZETTE_DATE;
            this.INVOICE = INVOICE;
            this.DECORATION = DECORATION;
            this.NOTES = NOTES;
            this.ID = ID;

        }

        public DataTable GetInsigRecord2(string CITIZEN_ID, string DATE, string POSITION_WORK_NAME, string POSITION_NAME, string GRADEINSIGNIA_NAME, string GAZETTE_LAM, string GAZETTE_TON, string GAZETTE_NA, string GAZETTE_DATE, string INVOICE, string DECORATION, string NOTES)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "SELECT * FROM TB_RECORDNOTE ";
            if (!string.IsNullOrEmpty(CITIZEN_ID) || !string.IsNullOrEmpty(DATE) || !string.IsNullOrEmpty(POSITION_WORK_NAME) || !string.IsNullOrEmpty(POSITION_NAME) || !string.IsNullOrEmpty(GRADEINSIGNIA_NAME) || !string.IsNullOrEmpty(GAZETTE_LAM) || !string.IsNullOrEmpty(GAZETTE_TON) || !string.IsNullOrEmpty(GAZETTE_NA) || !string.IsNullOrEmpty(GAZETTE_DATE) || !string.IsNullOrEmpty(INVOICE) || !string.IsNullOrEmpty(DECORATION) || !string.IsNullOrEmpty(NOTES))
            {
                query += " where 1=1 ";
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    query += " and CITIZEN_ID like :CITIZEN_ID ";
                }
                if (!string.IsNullOrEmpty(DATE))
                {
                    query += " and DATE like :DATE ";
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    query += " and POSITION_WORK_NAME like :POSITION_WORK_NAME ";
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    query += " and POSITION_NAME like :POSITION_NAME ";
                }
                if (!string.IsNullOrEmpty(GRADEINSIGNIA_NAME))
                {
                    query += " and GRADEINSIGNIA_NAME like :GRADEINSIGNIA_NAME ";
                }
                if (!string.IsNullOrEmpty(GAZETTE_LAM))
                {
                    query += " and GAZETTE_LAM like :GAZETTE_LAM ";
                }
                if (!string.IsNullOrEmpty(GAZETTE_TON))
                {
                    query += " and GAZETTE_TON like :GAZETTE_TON ";
                }
                if (!string.IsNullOrEmpty(GAZETTE_NA))
                {
                    query += " and GAZETTE_NA like :GAZETTE_NA ";
                }
                if (!string.IsNullOrEmpty(GAZETTE_DATE))
                {
                    query += " and GAZETTE_DATE like :GAZETTE_DATE ";
                }
                if (!string.IsNullOrEmpty(INVOICE))
                {
                    query += " and INVOICE like :INVOICE ";
                }
                if (!string.IsNullOrEmpty(DECORATION))
                {
                    query += " and DECORATION like :DECORATION ";
                }
                if (!string.IsNullOrEmpty(NOTES))
                {
                    query += " and NOTES like :NOTES ";
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
                if (!string.IsNullOrEmpty(CITIZEN_ID))
                {
                    command.Parameters.Add(new OracleParameter("CITIZEN_ID", "%" + CITIZEN_ID + "%"));
                }
                if (!string.IsNullOrEmpty(DATE))
                {
                    command.Parameters.Add(new OracleParameter("DATE", "%" + DATE + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_WORK_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", "%" + POSITION_WORK_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(POSITION_NAME))
                {
                    command.Parameters.Add(new OracleParameter("POSITION_NAME", "%" + POSITION_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(GRADEINSIGNIA_NAME))
                {
                    command.Parameters.Add(new OracleParameter("GRADEINSIGNIA_NAME", "%" + GRADEINSIGNIA_NAME + "%"));
                }
                if (!string.IsNullOrEmpty(GAZETTE_LAM))
                {
                    command.Parameters.Add(new OracleParameter("GAZETTE_LAM", "%" + GAZETTE_LAM + "%"));
                }
                if (!string.IsNullOrEmpty(GAZETTE_TON))
                {
                    command.Parameters.Add(new OracleParameter("GAZETTE_TON", "%" + GAZETTE_TON + "%"));
                }
                if (!string.IsNullOrEmpty(GAZETTE_NA))
                {
                    command.Parameters.Add(new OracleParameter("GAZETTE_NA", "%" + GAZETTE_NA + "%"));
                }
                if (!string.IsNullOrEmpty(GAZETTE_DATE))
                {
                    command.Parameters.Add(new OracleParameter("GAZETTE_DATE", "%" + GAZETTE_DATE + "%"));
                }
                if (!string.IsNullOrEmpty(INVOICE))
                {
                    command.Parameters.Add(new OracleParameter("INVOICE", "%" + INVOICE + "%"));
                }
                if (!string.IsNullOrEmpty(DECORATION))
                {
                    command.Parameters.Add(new OracleParameter("DECORATION", "%" + DECORATION + "%"));
                }
                if (!string.IsNullOrEmpty(NOTES))
                {
                    command.Parameters.Add(new OracleParameter("NOTES", "%" + NOTES + "%"));
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

        public int InserInsigRecord2()
        {
            int id = 0;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("INSERT INTO TB_RECORDNOTE (CITIZEN_ID,DATE,POSITION_WORK_NAME,POSITION_NAME,GRADEINSIGNIA_NAME,GAZETTE_LAM,GAZETTE_TON,GAZETTE_NA,GAZETTE_DATE,INVOICE,DECORATION,NOTES) VALUES (:CITIZEN_ID,:DATE,:POSITION_WORK_NAME,:POSITION_NAME,:GRADEINSIGNIA_NAME,:GAZETTE_LAM,:GAZETTE_TON,:GAZETTE_NA,:GAZETTE_DATE,:INVOICE,:DECORATION,:NOTES)", conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("CITIZEN_ID", CITIZEN_ID));
                command.Parameters.Add(new OracleParameter("DATE", DATE));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", POSITION_WORK_NAME));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("GRADEINSIGNIA_NAME", GRADEINSIGNIA_NAME));
                command.Parameters.Add(new OracleParameter("GAZETTE_LAM", GAZETTE_LAM));
                command.Parameters.Add(new OracleParameter("GAZETTE_TON", GAZETTE_TON));
                command.Parameters.Add(new OracleParameter("GAZETTE_NA", GAZETTE_NA));
                command.Parameters.Add(new OracleParameter("GAZETTE_DATE", GAZETTE_DATE));
                command.Parameters.Add(new OracleParameter("INVOICE", INVOICE));
                command.Parameters.Add(new OracleParameter("DECORATION", DECORATION));
                command.Parameters.Add(new OracleParameter("NOTES", NOTES));

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

        public bool UpdateInsigRecord2()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            string query = "Update TB_RECORDNOTE Set ";
            query += " DATE = :DATE,";
            query += " POSITION_WORK_NAME = :POSITION_WORK_NAME,";
            query += " POSITION_NAME = :POSITION_NAME,";
            query += " GRADEINSIGNIA_NAME = :GRADEINSIGNIA_NAME,";
            query += " GAZETTE_LAM = :GAZETTE_LAM,";
            query += " GAZETTE_TON = :GAZETTE_TON,";
            query += " GAZETTE_NA = :GAZETTE_NA,";
            query += " GAZETTE_DATE = :GAZETTE_DATE,";
            query += " INVOICE = :INVOICE,";
            query += " DECORATION = :DECORATION,";
            query += " NOTES = :NOTES";
            query += " where ID = :ID";

            OracleCommand command = new OracleCommand(query, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                command.Parameters.Add(new OracleParameter("DATE", DATE));
                command.Parameters.Add(new OracleParameter("POSITION_WORK_NAME", POSITION_WORK_NAME));
                command.Parameters.Add(new OracleParameter("POSITION_NAME", POSITION_NAME));
                command.Parameters.Add(new OracleParameter("GRADEINSIGNIA_NAME", GRADEINSIGNIA_NAME));
                command.Parameters.Add(new OracleParameter("GAZETTE_LAM", GAZETTE_LAM));
                command.Parameters.Add(new OracleParameter("GAZETTE_TON", GAZETTE_TON));
                command.Parameters.Add(new OracleParameter("GAZETTE_NA", GAZETTE_NA));
                command.Parameters.Add(new OracleParameter("GAZETTE_DATE", GAZETTE_DATE));
                command.Parameters.Add(new OracleParameter("INVOICE", INVOICE));
                command.Parameters.Add(new OracleParameter("DECORATION", DECORATION));
                command.Parameters.Add(new OracleParameter("NOTES", NOTES));
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
            }
            return result;
        }

        public bool DeleteInsigRecord2()
        {
            bool result = false;
            OracleConnection conn = ConnectionDB.GetOracleConnection();
            OracleCommand command = new OracleCommand("Delete TB_RECORDNOTE where ID = :ID", conn);
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
