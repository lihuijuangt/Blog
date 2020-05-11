using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.DBModel
{
    public class Articles
    {
      public int Id  { get; set; }
      public string Title{ get; set; }
      public int  ReadTimes{ get; set; }
      public string Tags{ get; set; }
      public string SimpleInfo{ get; set; }
      public string Cont{ get; set; }
      public string MainPicUrl{ get; set; }
      public string Source{ get; set; }
      public string Type{ get; set; }
      public DateTime  CreateTime{ get; set; }
      public DateTime PubTime { get; set; }
      public string IsPub{ get; set; }
      public string ShowType{ get; set; }








    }
}