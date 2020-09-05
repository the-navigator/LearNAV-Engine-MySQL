using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.MySQL;


namespace LearNAV_Engine
{
    public class DatabaseConnection
    {
      static string sqlConnectionString = ConfigurationManager.ConnectionStrings["[NULL, NO DB YET]"].ConnectionString;
      /*
      [OBSELETE, THIS IS FOR MS ACCESS CONNECTION]
        private OleDbConnection db_cn = new
            OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " +
            Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");

    
        important variables for providing data
        OleDbCommand list_Con = new OleDbCommand();
        OleDbCommand comn = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public DataTable dt = new DataTable();
*/

        //VARIABLES
        MySqlConnection comn = new MySqlConnection(sqlConnectionString);
        MySqlCommand da;
        MySqlDataAdapter dataAdapter;
        public DataTable dt;

        //DATABASE VARIABLES
        string table_src = "ResourceDB";

         //command
           string selectQuery = ($"SELECT * FROM {table_src}");
        // Variables to show for ListView Items

        public int rowcount;
       
       public void ShowFiltered()
       {
           
               db_cn.Open();
               da = new OleDbDataAdapter("SELECT * FROM [ResourceDB]", db_cn);
               da = new MySqlCommand(selectQuery, comn);
               comn.Open();

               dataAdapter = new MySqlDataAdapter(da);
               dt = new DataTable();


               dataAdapter.Fill(dt);
               rowcount = dt.Rows.Count;
               db_cn.Close();
           

       }

      


            
        }
    }

