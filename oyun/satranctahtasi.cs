using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oyun
{
    public partial class satranctahtasi : Form
    {

        private PictureBox seciliOlan = null;
        private string eski = "";
        private string oyunModu;

        public satranctahtasi(string oyunModu)
        {
            InitializeComponent();
            this.oyunModu = oyunModu;
            
        }



        public void TasAc()
        {
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            btn_baslaa.Enabled = false;

            PictureBox[] kareler = { A1,A2,A3,A4,A5,A6,A7,A8,
                                    B1,B2,B3,B4,B5,B6,B7,B8,
                                    C1,C2,C3,C4,C5,C6,C7,C8,
                                    D1,D2,D3,D4,D5,D6,D7,D8,
                                    E1,E2,E3,E4,E5,E6,E7,E8,
                                    F1,F2,F3,F4,F5,F6,F7,F8,
                                    G1,G2,G3,G4,G5,G6,G7,G8,
                                    H1,H2,H3,H4,H5,H6,H7,H8 };
            foreach (var kare in kareler)
            {
                kare.Enabled = true;
            }


        }


        PictureBox ilkTiklanan = null;

        private void KareyeTikla(object sender, EventArgs e)
        {
            PictureBox tiklanan = sender as PictureBox;

            if (ilkTiklanan == null)
            {
                
                ilkTiklanan = tiklanan;
            }
            else
            {
                
                tiklanan.Image = ilkTiklanan.Image;
                ilkTiklanan.Image = null;

               
                HamleKaydet(textBox1.Text, ilkTiklanan.Name, tiklanan.Name);

                
                ilkTiklanan = null;
            }
        }

        private void HamleKaydet(string kullanici, string mevcutKonum, string yeniKonum)
        {
            string connectionString = @"Data Source=MELEK;Initial Catalog=satranc;Integrated Security=True ;TrustServerCertificate=True";
            string query = "INSERT INTO thamle (kullanici, mevcut_konum, yeni_konum) VALUES (@kullanici, @mevcut, @yeni)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanici", kullanici);
                cmd.Parameters.AddWithValue("@mevcut", mevcutKonum);
                cmd.Parameters.AddWithValue("@yeni", yeniKonum);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private DataTable listele(string sql)
        {
            string connectionString = @"Data Source=MELEK;Initial Catalog=satranc;Integrated Security=True;TrustServerCertificate=True";
            DataTable dt = new DataTable();

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    using (SqlDataAdapter komut = new SqlDataAdapter(sql, baglanti))
                    {
                        komut.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            return dt;
        }

        private PictureBox simetriKonumDondur(string mevcut_konum)
        {
            PictureBox simetri = null;

            if (mevcut_konum == "A1") simetri = A8;
            else if (mevcut_konum == "A2") simetri = A7;
            else if (mevcut_konum == "A3") simetri = A6;
            else if (mevcut_konum == "A4") simetri = A5;
            else if (mevcut_konum == "A5") simetri = A4;
            else if (mevcut_konum == "A6") simetri = A3;
            else if (mevcut_konum == "A7") simetri = A2;
            else if (mevcut_konum == "A8") simetri = A1;

            if (mevcut_konum == "B1") simetri = B8;
            else if (mevcut_konum == "B2") simetri = B7;
            else if (mevcut_konum == "B3") simetri = B6;
            else if (mevcut_konum == "B4") simetri = B5;
            else if (mevcut_konum == "B5") simetri = B4;
            else if (mevcut_konum == "B6") simetri = B3;
            else if (mevcut_konum == "B7") simetri = B2;
            else if (mevcut_konum == "B8") simetri = B1;

            if (mevcut_konum == "C1") simetri = C8;
            else if (mevcut_konum == "C2") simetri = C7;
            else if (mevcut_konum == "C3") simetri = C6;
            else if (mevcut_konum == "C4") simetri = C5;
            else if (mevcut_konum == "C5") simetri = C4;
            else if (mevcut_konum == "C6") simetri = C3;
            else if (mevcut_konum == "C7") simetri = C2;
            else if (mevcut_konum == "C8") simetri = C1;

            if (mevcut_konum == "D1") simetri = D8;
            else if (mevcut_konum == "D2") simetri = D7;
            else if (mevcut_konum == "D3") simetri = D6;
            else if (mevcut_konum == "D4") simetri = D5;
            else if (mevcut_konum == "D5") simetri = D4;
            else if (mevcut_konum == "D6") simetri = D3;
            else if (mevcut_konum == "D7") simetri = D2;
            else if (mevcut_konum == "D8") simetri = D1;

            if (mevcut_konum == "E1") simetri = E8;
            else if (mevcut_konum == "E2") simetri = E7;
            else if (mevcut_konum == "E3") simetri = E6;
            else if (mevcut_konum == "E4") simetri = E5;
            else if (mevcut_konum == "E5") simetri = E4;
            else if (mevcut_konum == "E6") simetri = E3;
            else if (mevcut_konum == "E7") simetri = E2;
            else if (mevcut_konum == "E8") simetri = E1;

            if (mevcut_konum == "F1") simetri = F8;
            else if (mevcut_konum == "F2") simetri = F7;
            else if (mevcut_konum == "F3") simetri = F6;
            else if (mevcut_konum == "F4") simetri = F5;
            else if (mevcut_konum == "F5") simetri = F4;
            else if (mevcut_konum == "F6") simetri = F3;
            else if (mevcut_konum == "F7") simetri = F2;
            else if (mevcut_konum == "F8") simetri = F1;

            if (mevcut_konum == "G1") simetri = G8;
            else if (mevcut_konum == "G2") simetri = G7;
            else if (mevcut_konum == "G3") simetri = G6;
            else if (mevcut_konum == "G4") simetri = G5;
            else if (mevcut_konum == "G5") simetri = G4;
            else if (mevcut_konum == "G6") simetri = G3;
            else if (mevcut_konum == "G7") simetri = G2;
            else if (mevcut_konum == "G8") simetri = G1;

            if (mevcut_konum == "H1") simetri = H8;
            else if (mevcut_konum == "H2") simetri = H7;
            else if (mevcut_konum == "H3") simetri = H6;
            else if (mevcut_konum == "H4") simetri = H5;
            else if (mevcut_konum == "H5") simetri = H4;
            else if (mevcut_konum == "H6") simetri = H3;
            else if (mevcut_konum == "H7") simetri = H2;
            else if (mevcut_konum == "H8") simetri = H1;

            return simetri;
        }

        private PictureBox konumdondur(string mevcut_konum)
        {
            PictureBox simetri = null;
            if (mevcut_konum == "A1") simetri = A1;
            else if (mevcut_konum == "A2") simetri = A2;
            else if (mevcut_konum == "A3") simetri = A3;
            else if (mevcut_konum == "A4") simetri = A4;
            else if (mevcut_konum == "A5") simetri = A5;
            else if (mevcut_konum == "A6") simetri = A6;
            else if (mevcut_konum == "A7") simetri = A7;
            else if (mevcut_konum == "A8") simetri = A8;


            if (mevcut_konum == "B1") simetri = B1;
            else if (mevcut_konum == "B2") simetri = B2;
            else if (mevcut_konum == "B3") simetri = B3;
            else if (mevcut_konum == "B4") simetri = B4;
            else if (mevcut_konum == "B5") simetri = B5;
            else if (mevcut_konum == "B6") simetri = B6;
            else if (mevcut_konum == "B7") simetri = B7;
            else if (mevcut_konum == "B8") simetri = B8;

            if (mevcut_konum == "C1") simetri = C1;
            else if (mevcut_konum == "C2") simetri = C2;
            else if (mevcut_konum == "C3") simetri = C3;
            else if (mevcut_konum == "C4") simetri = C4;
            else if (mevcut_konum == "C5") simetri = C5;
            else if (mevcut_konum == "C6") simetri = C6;
            else if (mevcut_konum == "C7") simetri = C7;
            else if (mevcut_konum == "C8") simetri = C8;


            if (mevcut_konum == "D1") simetri = D1;
            else if (mevcut_konum == "D2") simetri = D2;
            else if (mevcut_konum == "D3") simetri = D3;
            else if (mevcut_konum == "D4") simetri = D4;
            else if (mevcut_konum == "D5") simetri = D5;
            else if (mevcut_konum == "D6") simetri = D6;
            else if (mevcut_konum == "D7") simetri = D7;
            else if (mevcut_konum == "D8") simetri = D8;

            if (mevcut_konum == "E1") simetri = E1;
            else if (mevcut_konum == "E2") simetri = E2;
            else if (mevcut_konum == "E3") simetri = E3;
            else if (mevcut_konum == "E4") simetri = E4;
            else if (mevcut_konum == "E5") simetri = E5;
            else if (mevcut_konum == "E6") simetri = E6;
            else if (mevcut_konum == "E7") simetri = E7;
            else if (mevcut_konum == "E8") simetri = E8;

            if (mevcut_konum == "F1") simetri = F1;
            else if (mevcut_konum == "F2") simetri = F2;
            else if (mevcut_konum == "F3") simetri = F3;
            else if (mevcut_konum == "F4") simetri = F4;
            else if (mevcut_konum == "F5") simetri = F5;
            else if (mevcut_konum == "F6") simetri = F6;
            else if (mevcut_konum == "F7") simetri = F7;
            else if (mevcut_konum == "F8") simetri = F8;

            if (mevcut_konum == "G1") simetri = G1;
            else if (mevcut_konum == "G2") simetri = G2;
            else if (mevcut_konum == "G3") simetri = G3;
            else if (mevcut_konum == "G4") simetri = G4;
            else if (mevcut_konum == "G5") simetri = G5;
            else if (mevcut_konum == "G6") simetri = G6;
            else if (mevcut_konum == "G7") simetri = G7;
            else if (mevcut_konum == "G8") simetri = G8;

            if (mevcut_konum == "H1") simetri = H1;
            else if (mevcut_konum == "H2") simetri = H2;
            else if (mevcut_konum == "H3") simetri = H3;
            else if (mevcut_konum == "H4") simetri = H4;
            else if (mevcut_konum == "H5") simetri = H5;
            else if (mevcut_konum == "H6") simetri = H6;
            else if (mevcut_konum == "H7") simetri = H7;
            else if (mevcut_konum == "H8") simetri = H8;

            return simetri;
        }
        private void satranctahtasi_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 1;
            SonHamleIDGuncelle();

            try
            {
                string connectionString = @"Data Source=MELEK;Initial Catalog=satranc;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Veritabanına başarıyla bağlandı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }





            PictureBox[] kareler = {A1,A2,A3,A4,A5,A6,A7,A8,
                                    B1,B2,B3,B4,B5,B6,B7,B8,
                                    C1,C2,C3,C4,C5,C6,C7,C8,
                                    D1,D2,D3,D4,D5,D6,D7,D8,
                                    E1,E2,E3,E4,E5,E6,E7,E8,
                                    F1,F2,F3,F4,F5,F6,F7,F8,
                                    G1,G2,G3,G4,G5,G6,G7,G8,
                                    H1,H2,H3,H4,H5,H6,H7,H8 };
            foreach (var kare in kareler)
            {
                kare.Enabled = false;
            }


            foreach (Control c in this.Controls)
            {
                if (c is PictureBox ) 
                {
                    c.Click += KareyeTikla;
                }
            }
        }
        private void zaman_Tick(object sender, EventArgs e)
        {
            DataTable dt = listele("select * from thamle where ID>" + lbl_0.Text);
            if (dt.Rows.Count > 0)
            {
                listBox1.Items.Add("Kullanıcı:   " + dt.Rows[0]["kullanici"].ToString() +
                                   " Eski konum :   " + dt.Rows[0]["mevcut_konum"].ToString() +
                                   "Yeni Hamle: " + dt.Rows[0]["yeni_konum"].ToString() + "\n");

                lbl_0.Text = dt.Rows[0]["ID"].ToString();



                if (dt.Rows[0]["kullanici"].ToString() != textBox1.Text)
                {
                    string eski_konum = dt.Rows[0]["mevcut_konum"].ToString();
                    string yeni_konum = dt.Rows[0]["yeni_konum"].ToString();
                    konumdondur(yeni_konum).Image = konumdondur(eski_konum).Image;
                    konumdondur(eski_konum).Image = null;

                    Control eski = this.Controls.Find(eski_konum, true).FirstOrDefault();
                    Control yeni = this.Controls.Find(yeni_konum, true).FirstOrDefault();

                    if (eski is PictureBox && yeni is PictureBox)
                    {
                        PictureBox pbEski = (PictureBox)eski;
                        PictureBox pbYeni = (PictureBox)yeni;

                        pbYeni.Image = pbEski.Image;
                        pbEski.Image = null;
                    }

                }
            }
        }

        private bool GecerliHamleMi(PictureBox kaynak, PictureBox hedef)
        {
            
            return true; 
        }


        private void button1_Click(object sender, EventArgs e)
        {


            zaman.Enabled = true;
            if (textBox1.Text != "" && comboBox1.Text != "")
            {

               
                listBox1.Items.Clear();

                
                SonHamleIDGuncelle();
                if (comboBox1.SelectedIndex == 0)
                {
                    TasAc();
                }
                else if (comboBox1.SelectedIndex == 1)
                {


                    TasAc();
                    A8.Location = new Point(844, 844);
                    A7.Location = new Point(844, 732);
                    A6.Location = new Point(844, 624);
                    A5.Location = new Point(844, 517);
                    A4.Location = new Point(844, 405);
                    A3.Location = new Point(844, 298);
                    A2.Location = new Point(844, 191);
                    A1.Location = new Point(844, 80);

                    B8.Location = new Point(732, 844);
                    B7.Location = new Point(732, 732);
                    B6.Location = new Point(732, 624);
                    B5.Location = new Point(732, 517);
                    B4.Location = new Point(732, 405);
                    B3.Location = new Point(732, 298);
                    B2.Location = new Point(732, 191);
                    B1.Location = new Point(732, 80);

                    C8.Location = new Point(624, 844);
                    C7.Location = new Point(624, 732);
                    C6.Location = new Point(624, 624);
                    C5.Location = new Point(624, 517);
                    C4.Location = new Point(624, 405);
                    C3.Location = new Point(624, 298);
                    C2.Location = new Point(624, 191);
                    C1.Location = new Point(624, 80);

                    D8.Location = new Point(513, 844);
                    D7.Location = new Point(513, 732);
                    D6.Location = new Point(513, 624);
                    D5.Location = new Point(513, 517);
                    D4.Location = new Point(513, 405);
                    D3.Location = new Point(513, 298);
                    D2.Location = new Point(513, 191);
                    D1.Location = new Point(513, 80);

                    E8.Location = new Point(402, 844);
                    E7.Location = new Point(402, 732);
                    E6.Location = new Point(402, 624);
                    E5.Location = new Point(402, 517);
                    E4.Location = new Point(402, 405);
                    E3.Location = new Point(402, 298);
                    E2.Location = new Point(402, 191);
                    E1.Location = new Point(402, 80);

                    F8.Location = new Point(291, 844);
                    F7.Location = new Point(291, 732);
                    F6.Location = new Point(291, 624);
                    F5.Location = new Point(291, 517);
                    F4.Location = new Point(291, 405);
                    F3.Location = new Point(291, 298);
                    F2.Location = new Point(291, 191);
                    F1.Location = new Point(291, 80);

                    G8.Location = new Point(185, 844);
                    G7.Location = new Point(185, 732);
                    G6.Location = new Point(185, 624);
                    G5.Location = new Point(185, 517);
                    G4.Location = new Point(185, 405);
                    G3.Location = new Point(185, 298);
                    G2.Location = new Point(185, 191);
                    G1.Location = new Point(185, 80);

                    H8.Location = new Point(74, 844);
                    H7.Location = new Point(74, 732);
                    H6.Location = new Point(74, 624);
                    H5.Location = new Point(74, 517);
                    H4.Location = new Point(74, 405);
                    H3.Location = new Point(74, 298);
                    H2.Location = new Point(74, 191);
                    H1.Location = new Point(74, 80);



                }
                else
                {
                    MessageBox.Show("Lütfen isim ve renk alaını doldurun!");
                }
            }
        }
        private void SonHamleIDGuncelle()
        {
            string connectionString = @"Data Source=MELEK;Initial Catalog=satranc;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT MAX(ID) AS LastID FROM tHamle";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lbl_0.Text = result.ToString(); 
                    }
                    else
                    {
                        lbl_0.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Son ID alınırken hata: " + ex.Message);
                }
            }
        }
        public enum TasTipi
        {
            Piyon,
            Kale,
            At,
            Fil,
            Vezir,
            Sah
        }
        public enum TasRengi
        {
            Beyaz,
            Siyah
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SatrancFormu satrancsecim = new SatrancFormu();
            satrancsecim.Show(); 
        }

        private void A8_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox tiklanan = (PictureBox)sender;
            if (seciliOlan == null || eski == "A1")
            {
                seciliOlan = tiklanan;
                eski = tiklanan.Name;
                
            }
            else if (seciliOlan.Image == null || eski == "A1") 
            {
                seciliOlan = tiklanan;
                eski = tiklanan.Name;
            }
            else
            {
                tiklanan.Image = seciliOlan.Image;
                seciliOlan.Image = null;

                HamleKaydet(textBox1.Text, seciliOlan.Name, tiklanan.Name);

                seciliOlan = null;
                eski= "";
            }

        }
    }
}

