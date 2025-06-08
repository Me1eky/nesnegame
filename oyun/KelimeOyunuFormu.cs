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
    public partial class KelimeOyunuFormu : Form
    {
        public KelimeOyunuFormu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 anaMenu = new Form1();
            anaMenu.Show(); 
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kelimeoyunu kelimeoyunu = new kelimeoyunu();
            kelimeoyunu.Show();
            this.Hide();
        }

        private void KelimeOyunuFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
