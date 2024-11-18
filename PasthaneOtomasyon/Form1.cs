using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PasthaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=SerhatDemir\SQLEXPRESS;Initial Catalog=Pasthaneotomasyon;Integrated Security=True;");
       void Urunler()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUNLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
            conn.Close();
        }
        void malzemeler()
        {
           
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEMELER",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt;

            conn.Close();
        }
        void malzemeliste()
        {                         
            SqlDataAdapter da=new SqlDataAdapter("select *from TBLMALZEMELER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select *from TBLKASA", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void urunlistesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLURUNLER ", conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeler();
            malzemeliste();
            Urunler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunlistesi();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            malzemeliste();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMalzemekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER(AD,STOK,FIYAT,NOTLAR) VALUES(@P1,@P2,@P3,@P4)", conn);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2",decimal.Parse( txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFıyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemenot.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("MALZEME SİSTEME EKLENDİ ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            malzemeliste();
            urunlistesi();
            txtMalzemeAd.Text = "";
            txtMalzemeStok.Text = "";
            txtMalzemeFıyat.Text = "";
            txtMalzemenot.Text = "";
        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER(AD) VALUES(@P1)",conn);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("MALZEME SİSTEME EKLENDİ ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlistesi();
            malzemeliste();
            txtUrunAd.Text = "";
        }

        private void btnUrunoluştur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN(URUNID,MALZEMEID,MIKTAR,MALIYET) VALUES(@P1,@P2,@P3,@P4)",conn);
            komut.Parameters.AddWithValue("@p1",CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2",cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3",decimal.Parse( txtMıktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMalıyet.Text));
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("MALZEME SİSTEME EKLENDİ ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add(cmbMalzeme.Text+" - "+txtMalıyet.Text);
            urunlistesi();
            malzemeliste();
        }

        private void txtMıktar_TextChanged(object sender, EventArgs e)
        {
            double malıyet;

            if (txtMıktar.Text == "")
            {
                txtMıktar.Text = "0";
            }
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLMALZEMELER where MALZEMEID=@P1", conn);
            komut.Parameters.AddWithValue("@P1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMalıyet.Text = dr[3].ToString();
            }
            conn.Close();
            malıyet = Convert.ToDouble(txtMalıyet.Text) / 1000 * Convert.ToDouble(txtMıktar.Text);
            txtMalıyet.Text = malıyet.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            conn.Open();
            SqlCommand komut = new SqlCommand("select sum(MALIYET) FROM TBLFIRIN WHERE URUNID=@P1", conn);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunMfıyat.Text = dr[0].ToString();
            }
            conn.Close();
        }

        private void btnurunguncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("update TBLURUNLER set MFIYAT=@p1,SFIYAT=@p2,STOK=@p3 where URUNID=@p4", conn);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtUrunMfıyat.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtUrunSfıyat.Text));
            komut.Parameters.AddWithValue("@p3", txtUrunStok.Text);
            komut.Parameters.AddWithValue("@p4", txtUrunId.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlistesi();
            malzemeliste();

            conn.Open();
            
            SqlCommand komut2 = new SqlCommand("update TBLKASA SET GIRIS=GIRIS+@P1,CIKIS=CIKIS+@P2,KAR=@P3", conn);
            komut2.Parameters.AddWithValue("@P1", Decimal.Parse(txtUrunSfıyat.Text));
            komut2.Parameters.AddWithValue("@P2", Decimal.Parse(txtUrunMfıyat.Text));
            komut2.Parameters.AddWithValue("@P3", Decimal.Parse(txtUrunSfıyat.Text) - Decimal.Parse(txtUrunMfıyat.Text));
            komut2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlistesi();
            malzemeliste();
            txtUrunAd.Text = "";
            txtUrunId.Text = "";
            txtUrunMfıyat.Text = "";
            txtUrunSfıyat.Text = "";
            txtUrunStok.Text = "";
        }

        private void txtUrunStok_TextChanged(object sender, EventArgs e)
        {
           /* double maliyet, satıs;
            if (txtUrunStok.Text == "")
            {
                txtUrunStok.Text = "0";
            }
            maliyet = Convert.ToDouble(txtUrunStok.Text) * Convert.ToDouble(txtUrunMfıyat.Text);
            satıs = Convert.ToDouble(txtUrunStok.Text) * Convert.ToDouble(txtUrunSfıyat.Text);
            label11.Text = maliyet.ToString();
            label16.Text = satıs.ToString();*/
        }
    }
}
