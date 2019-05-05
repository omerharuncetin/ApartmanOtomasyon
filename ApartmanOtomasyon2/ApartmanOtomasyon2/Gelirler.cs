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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper = new SqlHelper();
        private void Button1_Click(object sender, EventArgs e)
        {
            int daireno = int.Parse(cmbDaireNo.Text);
            int tutar = (int) nrcTutar.Value;
            DateTime tarih = dtpTarih.Value;

            SqlParameter parameterNO = new SqlParameter("DaireNo",daireno);
            SqlParameter parameterTutar = new SqlParameter("Para", tutar);
            SqlParameter parameterTarih = new SqlParameter("Tarih", tarih);

            sqlHelper.ExecuteProc("OdemeAl", parameterNO, parameterTarih, parameterTutar);
            
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.GetTable("select * from AidatOdemesi");
            nrcTutar.Maximum = int.MaxValue;

            foreach (DataRow data in dt.Rows)
            {
                lstDaireNo.Items.Add(data["DaireNo"]).ToString();
                lstTutar.Items.Add(data["Para"]).ToString();
                lstTarih.Items.Add(data["Tarih"]).ToString();
            }
        }
    }
}
