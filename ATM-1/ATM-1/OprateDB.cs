using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO ;


namespace ATM_1
{
        public sealed  class OprateDB
        {

            #region
            /// <summary>
           /// 获取连接数据库的字符串
           /// </summary>
            public static string ConnString
            {
                get
                {
                    using (StreamReader sr = File.OpenText("Conn2DB.txt"))
                    {
                        return sr.ReadLine();               
                    }
               }
            }

            #endregion 

            #region 
          
           private static void PrepareCommand(SqlCommand cmd,SqlConnection conn,string cmdText)
            {
                
                if(conn.State !=ConnectionState.Open )
                {
                    conn.Open();
                }              
                cmd.Connection = conn;              
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmdText;

            }
            #endregion
            /// <summary>
            /// 执行数据库读取操作
            /// </summary>
            /// <param name="cmdText">SQL语句</param>
            /// <returns>如果获取到值，返回TRUE，否则返回ＦＡＬＳＥ</returns>
            public static  bool ExecuteReader(string cmdText)
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand cmd = new SqlCommand();
                    PrepareCommand(cmd, conn, cmdText);
                    SqlDataReader dr = cmd.ExecuteReader();
                    return dr.Read();
                }      

            }
                   
            /// <summary>
           /// 执行数据增加。删除。或修改等操作（重要）
           /// </summary>
           /// <param name="cmdText">ＳＱＬ语句</param>
           /// <returns>返回的操作影响的行数</returns>
            public static int ExecuteNonQuery(string cmdText)
            {

                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand cmd = new SqlCommand();
                    PrepareCommand(cmd, conn, cmdText);
                    return cmd.ExecuteNonQuery(); 
                  }      

            }










        }
}
