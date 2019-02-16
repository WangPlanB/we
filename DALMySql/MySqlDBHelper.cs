using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DALMySql
{
    public class MySqlDBHelper
    {
        private static string connStr = "Server=127.0.0.1;Database=tvdata;Uid=root;Pwd=root;";
        /// <summary>
        /// 增删改方法
        /// </summary>
        /// <param name="sql">要执行的增删改语句</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            int result = 0;
            //创建连接对象Connection  连接字符串
            MySqlConnection myconn = new MySqlConnection(connStr);
            try
            {
                //打开数据库
                myconn.Open();
                //创建操作对象Command Sql语句

                MySqlCommand mycmd = new MySqlCommand(sql, myconn);
                //执行Sql操作 ExecuteNonQuery
                result = mycmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //关闭数据库
                myconn.Close();
            }

            return result;
        }
        public static int ExecuteNonQuery(string pro, MySqlParameter[] parms)
        {
            MySqlConnection myconn = new MySqlConnection(connStr);
            MySqlCommand mycmd = new MySqlCommand(pro, myconn);
            mycmd.CommandType = CommandType.StoredProcedure;
            foreach (var item in parms)
            {
                mycmd.Parameters.Add(item);
            }
            int result = 0;
            try
            {
                myconn.Open();
                result = mycmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                myconn.Close();
            }

            return result;


        }
        /// <summary>
        /// 获取DataTable结果的查询
        /// </summary>
        /// <param name="sql">需执行的查询操作</param>
        /// <returns>包含查询结果的DataTable</returns>
        public static DataTable GetTable(string sql)
        {
            MySqlConnection myconn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();//结果
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, myconn);
                MySqlDataAdapter dpt = new MySqlDataAdapter(cmd);
                dpt.Fill(dt);//填充数据
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                myconn.Close();
            }
            return dt;
        }

        public static DataTable GetTable(string sql, MySqlParameter[] parms)
        {
            MySqlConnection myconn = new MySqlConnection(connStr);
            DataTable dt = new DataTable();//结果
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, myconn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var item in parms)
                {
                    cmd.Parameters.Add(item);
                }
                MySqlDataAdapter dpt = new MySqlDataAdapter(cmd);
                dpt.Fill(dt);//填充数据
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                myconn.Close();
            }
            return dt;
        }
    }
}
