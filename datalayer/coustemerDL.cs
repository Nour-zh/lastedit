using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastedit.datalayer
{
    public class coustemerDL
    {
           private static  string  ConnectionString =
             "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:D://connection folder//database3";
            
       private static OleDbConnection connection  =   new OleDbConnection (ConnectionString);



        public static void CreatCoustemer(Coustemer Cousttemer)
        {
            string insertCommand = string.Format("insert into Coustemer(CoustemerNo, CoustemerName)"
                +"values('{0}' , '{1}')", 
                coustemer.CoustemerNo, coustemer.CoustemerName);

            OleDbCommand command = new OleDbCommand("insertcommand ,connection");
            ConnectionString.open();
            command.ExecutNonQuery();
            connction.close();
        }
        
        
        
        
        public static List<USERS> GetALUsers()
        {
            return null;
        }
        public static USERS Login (string username, string password)
        {
            return  null;
        }
    }
}
