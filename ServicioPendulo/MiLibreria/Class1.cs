using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=servicioElPendulo;Integrated Security=True");
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
