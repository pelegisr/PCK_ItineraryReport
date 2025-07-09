using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Peleg.PrintJobs;

namespace Peleg.PCK_ItineraryReport
{
    public partial class FrmParameters : Form
    {
        private readonly SqlConnection _cn;
        private int _pckID;
        private int _pnr;
        private int _pckItin;
        private int _fltItin;
        private string _pckCode;
        private string _pckName;
        private string _agt_mail;

        public FrmParameters(SqlConnection sqlConnection, int pnr)
        {
            InitializeComponent();
            _cn = sqlConnection;
            _pnr = pnr;

        }

        private void FrmParameters_Load(object sender, EventArgs e)
        {

            SqlDataReader dr = PLG_Pnr_GetPackageName(_pnr).ExecuteReader();
            while (dr.Read())
            {
                _pckID = (int) dr["pck_id"];
                _pckItin = (int)dr["pck_itin"];
                _fltItin = (int)dr["flt_itin"];
                _pckCode = dr["code"].ToString();
                _pckName = dr["name"].ToString();

            }
            dr.Close();

            lblPnr.Text = _pnr.ToString();
            lblPckID.Text = _pckID.ToString();
            lblPckCode.Text = _pckCode;
            lblPckName.Text = _pckName;

        //========== 19/07/23 ===================
            SqlDataReader eml = PLG_GetAgencyCommunication(_pnr, "").ExecuteReader();
            while (eml.Read())
            {
                _agt_mail = eml["agt_email"].ToString();
            }
            eml.Close();


        }

    // ############# SQL PART
    SqlCommand PLG_Pnr_GetPackageName(int Pnr)
        {
            SqlCommand cmd = _cn.CreateCommand();
            cmd.CommandText = "PLG_Pnr_GetPackageName";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Pnr", SqlDbType.Int);
            cmd.Parameters["@Pnr"].Value = Pnr;
            return cmd;
        }
        //=================================================================
        //PLG_GetAgencyCommunication
        SqlCommand PLG_GetAgencyCommunication(int Pnr, string clerk)
        {
            SqlCommand cmd = _cn.CreateCommand();
            cmd.CommandText = "PLG_GetAgencyCommunication";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pnr_pnr", SqlDbType.Int);
            cmd.Parameters["@pnr_pnr"].Value = Pnr;

            cmd.Parameters.Add("@clerk", SqlDbType.VarChar,(25));
            cmd.Parameters["@clerk"].Value = clerk;

            return cmd;
        }

        //=================================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string connstr = UP.Connection.SqlConnectionString;
            string comp = UP.Company.Code;
            string reportPath = Application.StartupPath + @"\PLG_Report\Package_Itinerary.rpt";

            if (!rbEnglish.Checked && !rbHebrew.Checked)
            {
                MessageBox.Show("Please choose language: Hebrew or English");
                return;
            }

            string supplier = "";

            Int16 Lang = 0;
            if (rbHebrew.Checked)
                Lang = 1;

            CRManager rep = new CRManager();
            rep.Parameters.Add("Pnr_Pnr", _pnr);
            rep.Parameters.Add("Hebrew", Lang);
            rep.Parameters.Add("Comp", comp);
            rep.Parameters.Add("PCK_Itin", _pckItin);
            rep.Parameters.Add("Flt_Itin", _fltItin);
            rep.Parameters.Add("Supplier", supplier);

            rep.Details2Send.Recipients.Add(_agt_mail, "");

            rep.ShowReportByName(connstr, reportPath, CRManager.ViewStyleEnum.Full);

        }
    }
}
