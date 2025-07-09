using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Peleg.NaumTools;

namespace Peleg.PCK_ItineraryReport
{
    [ComVisible(true)]
    [Guid("61905D50-2A5D-4982-B7A2-0B939231A14C")]
    public class Manager
    {
        public void Start(string connStr, int pnr)
        {
            try
            {
                string sqlConn = Utils.Ado2Sql(connStr);
                SqlConnection cn = OpenConnection(sqlConn);
                if (cn != null)
                {
                    new FrmParameters(cn, pnr).ShowDialog();

                    cn.Close();
                    cn.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        private static SqlConnection OpenConnection(string connStr)
        {
            try
            {
                SqlConnection cn = new SqlConnection(connStr);
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
