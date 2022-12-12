using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KopyalaBeni
{
    public partial class FGrupIslemleri : Form
    {
        public FGrupIslemleri()
        {
            InitializeComponent(); //Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Kopyala Beni\DbCopy.mdb"
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Kopyala Beni\DbCopy.mdb;Jet OLEDB:Database Password=Bhh6ngz1.;");

        void Clear()
        {
            TGrup.Text = "";
            TPaket.Text = "";
            LId.Text = "";
        }
        void Listele()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT GRUPAD as GRUP,GRUPTL AS PAKET,ID FROM TBL_GRUPLAR";
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            gridView1.Columns[2].Visible = false;
            con.Close();
        }
        private void FGrupIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            Clear();
        }


        private void BKaydet_Click(object sender, EventArgs e)
        {
            if (TGrup.Text != "" && TPaket.Text != "")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO TBL_GRUPLAR (GRUPAD,GRUPTL) VALUES (@P1,@P2)", con);
                cmd.Parameters.AddWithValue("@P1", TGrup.Text);
                cmd.Parameters.AddWithValue("@P2", TPaket.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Listele();
                Clear();
            }
            else
            {
                MessageBox.Show("Geçersiz Değer", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TGrup.Text = dr["GRUP"].ToString();
            TPaket.Text = Convert.ToString(dr["PAKET"]).ToString();
            LId.Text = dr["ID"].ToString();
        }

        private void BYokEt_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "DELETE FROM TBL_GRUPLAR WHERE ID=@P1";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@P1", LId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Listele();
            Clear();
        }

        private void BDuzenle_Click(object sender, EventArgs e)
        {
            if (TGrup.Text != "" && TPaket.Text != "" && LId.Text != "")
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE TBL_GRUPLAR SET GRUPAD=@P1,GRUPTL=@P2 WHERE ID=@P3", con);
                cmd.Parameters.AddWithValue("@P1", TGrup.Text);
                cmd.Parameters.AddWithValue("@P2", TPaket.Text);
                cmd.Parameters.AddWithValue("@P3", LId.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Listele();
                Clear();
                MessageBox.Show("Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Geçersiz Değer", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
