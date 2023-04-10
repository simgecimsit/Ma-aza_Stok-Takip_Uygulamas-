using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MagazaUygulamasi
{
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DJS2DJN;Initial Catalog=MagazaUygulaması;Integrated Security=True");
        DataSet daset = new DataSet();


        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" select * from satis ", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void frmSatışListele_Load(object sender, EventArgs e)
            {
            satislistele();
            }
        





    }
}
