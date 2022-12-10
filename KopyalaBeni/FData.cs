using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace KopyalaBeni
{
    public partial class FData : Form
    {
        public FData()
        {
            InitializeComponent();
        }
   //     OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\KopyalaBeni\DbCopy.mdb;User ID=Admin;Password=Bhh6ngz1.;");
        OleDbConnection co1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\KopyalaBeni\DbCopy.mdb;Jet OLEDB:System Database=C:\KopyalaBeni\DbCopy.mdb;User ID=Admin;Password=Bhh6ngz1.;");

        private void FData_Load(object sender, EventArgs e)
        {
            //con.Open();
            //OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TBLKOD",con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //gridControl1.DataSource = dt;

        }
    }
}
