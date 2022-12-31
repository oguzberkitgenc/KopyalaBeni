using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace KopyalaBeni
{
    public partial class FDataList : Form
    {
        public FDataList()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kopyala Beni\DbCopy.mdb;Jet OLEDB:Database Password=Bhh6ngz1.;");
        public string Goster = "";
        private void FDataList_Load(object sender, EventArgs e)
        {
        }
        private void bTum_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TBL_KODLAR", con);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            con.Close();
        }

        private void bYedek_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TBL_YEDEK", con);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            con.Close();
        }
    }
}
