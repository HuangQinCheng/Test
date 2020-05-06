using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan.Test.Web.DAL
{
    public class SqlHelper
    {
        private string OutConnection;
        private static readonly string ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public string sOutConnection
        {
            get => sOutConnection;
            set => sOutConnection = value;
        }

        public SqlHelper(string ConnStr)
        {
            this.sOutConnection = ConnStr;
        }

        public SqlHelper()
        {

        }

        /// <summary>
        /// 获取数据容器DataTable
        /// </summary>
        /// <param name="sql">结构化查询语句</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static DataTable GetTable(string sql, CommandType cmdType, params OracleParameter[] paras)
        {
            using (OracleConnection con = new OracleConnection())
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = cmdType;
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    using (OracleDataAdapter oda = new OracleDataAdapter())
                    {
                        oda.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL返回影响行数
        /// </summary>
        /// <param name="sql">结构化查询语句</param>
        /// <param name="sqlType">数据库命令类型</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static int ExcuteNonQuery(string sql, CommandType sqlType, params OracleParameter[] paras)
        {
            using (OracleConnection con = new OracleConnection())
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    cmd.CommandType = sqlType;
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 获取第一行第一列的数据
        /// </summary>
        /// <param name="sql">结构化查询语句</param>
        /// <param name="type">数据库命令类型</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static string ExcuteScalar(string sql,CommandType type,params OracleParameter[] paras)
        {
            object obj = null;
            try
            {
                using (OracleConnection con = new OracleConnection(ConnStr))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = type;
                        cmd.CommandText = sql;
                        if (paras != null)
                        {
                            cmd.Parameters.AddRange(paras);
                        }
                        obj = cmd.ExecuteScalar();
                        if (obj == null || Convert.IsDBNull(obj))
                        {
                            obj = "";
                        }
                        return obj.ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
