using System;
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
    public partial class SatrancFormu : Form
    {
        public SatrancFormu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 anaMenu = new Form1();
            anaMenu.Show(); 
        }

        private void btn_orta_Click(object sender, EventArgs e)
        {
            satranctahtasi satranctahtasi = new satranctahtasi(oyunModu: "İKİ_OYUNCULU");
            satranctahtasi.Show();
            this.Hide();

        }

       

        private void SatrancFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
