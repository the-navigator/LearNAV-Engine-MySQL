using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace LearNAV_Engine
{

    public class Filter
    {
      /*
        private OleDbConnection db_cn = new
           OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.14.0; Data Source = " +
           Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
           */
            static string db_cn = ConfigurationManager.ConnectionStrings["[NULL, NO DB YET]"].ConnectionString;
       MySQLDataAdapter da;
      public DataTable dt;
      //string table_src = "ResourceDB";

        public void FilterName(string to_filter) 
        {
           db_cn.Open();
           da = new MySQLDataAdapter("SELECT * FROM ResourceDB WHERE ResourceN LIKE '%" + to_filter + "%'", db_cn);
           da.Fill(dt);
           db_cn.Close();
     
        }

    }
}
