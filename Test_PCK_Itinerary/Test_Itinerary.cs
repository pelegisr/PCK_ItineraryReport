using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Peleg.PCK_ItineraryReport;

namespace Peleg.Test_PCK_Itinerary
{
    public partial class FrmTest_Itinerary : Form
    {
        private string connString;

        public FrmTest_Itinerary()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTest_Itinerary_Load(object sender, EventArgs e)
        {
            connString = UP.Connection.SqlConnectionString;

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            int pnr;
            pnr = int.Parse(txtPNR.Text);

            Manager EAF = new Manager();
            EAF.Start(connString,pnr);
        }
    }
}
