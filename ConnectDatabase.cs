using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SEPCW2
{
    class ConnectDatabase
    {
        public string strcon;//record the connection character string
        public SqlConnection mycon;//the opened connection of SQL Server
        public void Connect()
        {
            try
            {
                strcon = "Data Source=DESKTOP-KEOTT9I;Initial Catalog=SEPCW2;User ID=sa;Password=666666";//connect mainframe of SQL Server
                mycon = new SqlConnection(strcon);//open connection of SQL Server
                mycon.Open();//connect mainframe of SQL Server database
            }
            catch (Exception) { }
            //Data Source=DESKTOP-KEOTT9I;Initial Catalog=SEPCW2;User ID=sa;Password=***********
        }
    }
}
