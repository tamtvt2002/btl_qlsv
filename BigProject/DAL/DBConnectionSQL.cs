using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject.DAL
{
    class DBConnectionSQL
    {
        string connect;
        public DBConnectionSQL()
        {
            connect = @"Data Source=TRAN_TAM\SQLEXPRESS;Initial Catalog=QLSinhvien;Persist Security Info=True;User ID=sa;Password=123";
        }
        public SqlConnection Connect()
        {
            return new SqlConnection(connect);
        }
    }
}
