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
    public partial class sayi_secenek : Form
    {
        public sayi_secenek()
        {
            InitializeComponent();
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
        private void SayiButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                SecilenSayi = int.Parse(btn.Text);
            }
        }

        public int SecilenSayi { get; private set; }


        private void sayi_secenek_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn && btn.Text.All(char.IsDigit))
                {
                    btn.Click += SayiButton_Click;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (SecilenSayi != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Lütfen bir sayı seçiniz.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SecilenSayi = 0; 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}


