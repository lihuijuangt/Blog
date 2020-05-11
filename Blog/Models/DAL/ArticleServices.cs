using Blog.Models.DBModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Blog.Models.DAL
{
    public class ArticleServices
    {


        /// <summary>
        /// 查询首页所有文章
        /// </summary>
        /// <returns>文章列表</returns>

        public static List<Articles> GetArticles()
        {
            //sql
            string sql = @"select  Id,Title,SimpleInfo,MainPicUrl
                         from Articles where ShowType = '文章'";
            // DBHelper.ExecuteReader(sql)
            List<Articles> lis = new List<Articles>();
            using (SqlDataReader sdr = DBHelper.ExecuteReader(sql))
            {
                while (sdr.Read())
                {
                    Articles a = new Articles();
                    a.Id = int.Parse(sdr["Id"].ToString());
                    a.Title = sdr["Title"].ToString();
                    a.SimpleInfo = sdr["SimpleInfo"].ToString();
                    a.MainPicUrl = sdr["MainPicUrl"].ToString();
                    lis.Add(a);

                }
            }


            //SqlDataReader sdr = null;
            //try
            //{
            //     sdr = DBHelper.ExecuteReader(sql);
            //    while (sdr.Read())
            //    {
            //        Articles a = new Articles();
            //        a.Id = int.Parse(sdr["Id"].ToString());
            //        a.Title = sdr["Title"].ToString();
            //        a.SimpleInfo = sdr["SimpleInfo"].ToString();
            //        a.MainPicUrl = sdr["MainPicUrl"].ToString();

            //        lis.Add(a);

            //    }
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    sdr.Close();
            //}
            return lis;
        }



    }
}