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
    public partial class zorsudoku : Form
    {
        public zorsudoku()
        {
            InitializeComponent();
        }

        Button[,] butonlar = new Button[9, 9];
        int[,] dogruCozum = new int[9, 9]

        {

        {9,4,3,7,2,8,1,6,5},
        {2,6,1,4,3,5,9,7,8},
        {7,8,5,1,9,6,2,4,3},
        {4,1,6,3,5,9,8,2,7},
        {5,9,7,8,1,2,6,3,4},
        {8,3,2,6,7,4,5,9,1},
        {6,5,4,2,8,3,7,1,9},
        {1,2,9,5,4,7,3,8,6},
        {3,7,8,9,6,1,4,5,2},

         };
        private void zorsudoku_Load(object sender, EventArgs e)
        {
            butonlar[0, 0] = button40;
            butonlar[0, 2] = button3;
            butonlar[0, 3] = button28;
            butonlar[0, 7] = button31;


            butonlar[1, 0] = button39;
            butonlar[1, 1] = button2;
            butonlar[1, 2] = button10;
            butonlar[1, 5] = button30;
            butonlar[1, 6] = button29;


            butonlar[2, 1] = button11;
            butonlar[2, 4] = button4;
            butonlar[2, 7] = button32;
            butonlar[2, 8] = button33;


            butonlar[3, 3] = button13;
            butonlar[3, 6] = button7;
            butonlar[3, 7] = button5;
            butonlar[3, 8] = button12;



            butonlar[4, 0] = button8;
            butonlar[4, 3] = button1;
            butonlar[4, 4] = button14;
            butonlar[4, 8] = button18;


            butonlar[5, 0] = button34;
            butonlar[5, 1] = button35;
            butonlar[5, 3] = button15;
            butonlar[5, 4] = button36;
            butonlar[5, 5] = button37;
            butonlar[5, 7] = button17;



            butonlar[6, 1] = button6;
            butonlar[6, 2] = button16;
            butonlar[6, 3] = button24;
            butonlar[6, 5] = button21;
            butonlar[6, 7] = button25;


            butonlar[7, 0] = button19;
            butonlar[7, 2] = button23;
            butonlar[7, 5] = button38;
            butonlar[7, 6] = button22;
            butonlar[7, 8] = button9;


            butonlar[8, 1] = button20;
            butonlar[8, 2] = button41;
            butonlar[8, 7] = button26;
            butonlar[8, 8] = button42;

        }
        private void button27_Click(object sender, EventArgs e)
        {
            SudokuFormu sudok = new SudokuFormu();
            sudok.Show();
            this.Hide();
        }






        private void button40_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button40.Text = "";
                }
                else
                {
                    button40.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button3.Text = "";
                }
                else
                {
                    button3.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button28.Text = "";
                }
                else
                {
                    button28.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button31.Text = "";
                }
                else
                {
                    button31.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button39.Text = "";
                }
                else
                {
                    button39.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button2.Text = "";
                }
                else
                {
                    button2.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button10.Text = "";
                }
                else
                {
                    button10.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button30.Text = "";
                }
                else
                {
                    button30.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button29.Text = "";
                }
                else
                {
                    button29.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button11.Text = "";
                }
                else
                {
                    button11.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button4.Text = "";
                }
                else
                {
                    button4.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button32.Text = "";
                }
                else
                {
                    button32.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button33.Text = "";
                }
                else
                {
                    button33.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button13.Text = "";
                }
                else
                {
                    button13.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button7.Text = "";
                }
                else
                {
                    button7.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button5.Text = "";
                }
                else
                {
                    button5.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button12.Text = "";
                }
                else
                {
                    button12.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button8.Text = "";
                }
                else
                {
                    button8.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button1.Text = "";
                }
                else
                {
                    button1.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button14.Text = "";
                }
                else
                {
                    button14.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button18.Text = "";
                }
                else
                {
                    button18.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button34.Text = "";
                }
                else
                {
                    button34.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button35.Text = "";
                }
                else
                {
                    button35.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button15.Text = "";
                }
                else
                {
                    button15.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button36.Text = "";
                }
                else
                {
                    button36.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button37.Text = "";
                }
                else
                {
                    button37.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button17.Text = "";
                }
                else
                {
                    button17.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button6.Text = "";
                }
                else
                {
                    button6.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button16.Text = "";
                }
                else
                {
                    button16.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button24.Text = "";
                }
                else
                {
                    button24.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button21.Text = "";
                }
                else
                {
                    button21.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button25.Text = "";
                }
                else
                {
                    button25.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button19.Text = "";
                }
                else
                {
                    button19.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button23.Text = "";
                }
                else
                {
                    button23.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button38.Text = "";
                }
                else
                {
                    button38.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button22.Text = "";
                }
                else
                {
                    button22.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button9.Text = "";
                }
                else
                {
                    button9.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button20.Text = "";
                }
                else
                {
                    button20.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button41.Text = "";
                }
                else
                {
                    button41.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button26.Text = "";
                }
                else
                {
                    button26.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            sayi_secenek secenekForm = new sayi_secenek();


            if (secenekForm.ShowDialog() == DialogResult.OK)
            {
                if (secenekForm.SecilenSayi == 0)
                {
                    button42.Text = "";
                }
                else
                {
                    button42.Text = secenekForm.SecilenSayi.ToString();
                }
            }
        }
        private void btn_kontrolet_Click(object sender, EventArgs e)
        {
            CozumKontrol kontrol = new CozumKontrol(butonlar, dogruCozum);
            kontrol.KontrolEt();
        }

        
    }
}
