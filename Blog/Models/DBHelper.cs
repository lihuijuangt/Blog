using System;
using System.Data.SqlClient;
using System.Data;

namespace Blog.Models
{
    public class DBHelper
    {
        static string ConnectionString = "server=.;database=blog;uid=sa;pwd=123;";

        /// <summary>
        /// 根据指定的sql语句返回一个数据读取器对象。主要用于【查询】操作。
        /// 注意：您必须在使用后显示关闭此读取器对象。
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                //参数CommandBehavior.CloseConnection指明当关闭读取器对象时，自动关闭连接对象。
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                //Logger.WriteLog(string.Format(":{0}:{1}:{2}:{3}", ex.Number, ex.ErrorCode, ex.Message, sql));
                return null;
            }
        }
        /// <summary>
        /// 执行指定的sql语句，并可返回一个数据点（增删改）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                return cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                return null;//异常时返回null
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
        /// <summary>
        /// 执行指定的sql语句，返回此次执行对数据库影响的行数（增删改）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                return ex.Number * -1;//异常时返回错误代码
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
