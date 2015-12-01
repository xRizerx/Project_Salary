using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Class
{
    public class BaseSalary
    {
        private int id;
        private string position_id;
        private string position_name;
        private double maxsalary;
        private double minsalary;
        private double maxlowsalary;
        private double minlowsalary;
        public BaseSalary(string position_id)
        {
            this.position_id = position_id;
            using (OracleConnection conn = Util.OC())
            {
                using (OracleCommand command = new OracleCommand("select nvl(id,-1) from tb_basesalary where position_id = :1", conn))
                {
                    command.Parameters.AddWithValue("1", position_id);
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            id = reader.GetInt32(0);
                        }
                        else
                        {
                            id = -1;
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("select nvl(tb_position.name,'-') from tb_position,tb_basesalary where tb_basesalary.position_id = :1 and tb_position.id = tb_basesalary.position_id", conn))
                {
                    command.Parameters.AddWithValue("1", position_id);
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            position_name = reader.GetString(0);
                        }
                        else
                        {
                            position_name = "-";
                        }
                    }
                }
                using (OracleCommand command = new OracleCommand("select nvl(maxsalary,-1),nvl(minsalary,-1),nvl(maxlowsalary,-1),nvl(minlowsalary,-1) from tb_basesalary where position_id = :1", conn))
                {
                    command.Parameters.AddWithValue("1", position_id);
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            maxsalary = reader.GetDouble(0);
                            minsalary = reader.GetDouble(1);
                            maxlowsalary = reader.GetDouble(2);
                            minlowsalary = reader.GetDouble(3);
                        }
                        else
                        {
                            maxsalary = -1;
                            minsalary = -1;
                            maxlowsalary = -1;
                            minlowsalary = -1;
                        }
                    }
                }
            }
        }
        public int ID
        {
            get { return id; }
        }
        public string PositionID
        {
            get { return position_id; }
        }
        public string PositionName
        {
            get { return position_id; }
        }
        public double MaxSalary
        {
            get { return maxsalary; }
        }
        public double MinSalary
        {
            get { return minsalary; }
        }
        public double MaxLowSalary
        {
            get { return maxlowsalary; }
        }
        public double MinLowSalary
        {
            get { return minlowsalary; }
        }
    }
}