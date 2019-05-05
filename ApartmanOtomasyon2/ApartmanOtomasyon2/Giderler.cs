using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyon2
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper = new SqlHelper();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            string giderIsmi = "";
            giderIsmi += chkElektrik.Checked ? chkElektrik.Text + " " : "";
            giderIsmi += chkSu.Checked ? chkSu.Text + " " : "";
            giderIsmi += chkAsansor.Checked ? chkAsansor.Text + " " : "";
            giderIsmi += chkTemizlik.Checked ? chkTemizlik.Text + " " : "";
            int tutar = (int) nrcTutar.Value;
            DateTime tarih = dtpTarih.Value;

            SqlParameter parameterGiderIsmi = new SqlParameter("GiderIsmi", giderIsmi);
            SqlParameter parameterTutar = new SqlParameter("Para", tutar);
            SqlParameter parameterTarih = new SqlParameter("Tarih", tarih);

            sqlHelper.ExecuteProc("Giderler", parameterGiderIsmi, parameterTarih, parameterTutar);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            nrcTutar.Maximum = int.MaxValue;
            DataTable dt = sqlHelper.GetTable("select * from GiderTablosu");

            foreach (DataRow data in dt.Rows)
            {
                lstGiderler.Items.Add(data["GiderIsmi"]).ToString();
                lstTutar.Items.Add(data["Para"]).ToString();
                lstTarih.Items.Add(data["Tarih"]).ToString();
            }
        }
    }
}
