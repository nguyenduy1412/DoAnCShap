using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnC_
{
    internal class KetNoi
    {
        private string strCon = @"Data Source=DESKTOP-32FOJN8\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";
        private SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection(strCon);
        }
        public DataTable layDuLieu(string query)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(tb);
            return tb;
        }
        public bool thucThi(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();

                return r > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
