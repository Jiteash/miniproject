using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using Dapper;


namespace miniproject.TestdataAccess
{
    class ExceldataAccess
    {
        public static string Testdatafileconnection()
        {
            var filename = ConfigurationManager.AppSettings["TestdatasheetPath"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", filename);
            return con;
        }
        public static Userdata GetUserdata(string Keyname)
        {
            using (var connection = new OleDbConnection(Testdatafileconnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key='{0}'", Keyname);
                var value = connection.Query<Userdata>(query).FirstOrDefault();
                connection.Close();
                return value;



            }
        }

    }
}
