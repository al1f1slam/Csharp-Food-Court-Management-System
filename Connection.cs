using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Food_Court_Management_System
{
    class Connection
    {
        public static SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-LPTMJF3;Initial Catalog=FoodCourtManagement;User ID=sa;Password=3473;Pooling=False");

        public static void Open()
        {
                sqlCon.Open();

        }

        public static void Close()
        {
            sqlCon.Close();
        }
    }
}
