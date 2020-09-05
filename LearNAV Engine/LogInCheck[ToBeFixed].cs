using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Data.MySQL;


namespace LearNAV_Engine
{
    
  public class LoadData
    {
     public OleDbConnection db_cn =new 
            OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.14.0; Data Source = " + 
            Environment.CurrentDirectory + "\\" + "LearNAV_DB2.accdb");
      private OleDbDataAdapter da = new OleDbDataAdapter();
      public DataTable dt = new DataTable();
      //Data to return to main application
      public string username_return;
      public string password_return;
      //Data to input in datatable for query
    public  bool log_in_case;
    public string error_message;
      public int rowcount;


      
      public void CheckUserProfile(string username_query, string password_query)
      {
          db_cn.Open();
          try
          {



              try
              {
                  da = new OleDbDataAdapter("SELECT * FROM ProfileDBSt where FirstN= '" + username_query +
                      "' AND LRN= '" + password_query + "'", db_cn);
                  da.Fill(dt);
                  rowcount = dt.Rows.Count;

                  if (rowcount >= 1)
                  {
                      log_in_case = true;
                  }
                  else
                      log_in_case = false;

                  db_cn.Close();
              }
              catch (Exception e)
              {

              }
          }
          catch (Exception e)
          {

          }
         

        
          
              
          
             

          }
           
      }


    }

