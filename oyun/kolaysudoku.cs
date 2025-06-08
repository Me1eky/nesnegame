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
    public partial class kolaysudoku : Form
    {
        public kolaysudoku()
        {
            InitializeComponent();
        }
        Button[,] butonlar = new Button[9, 9];
        int[,] dogruCozum = new int[9, 9]
        {
        {9,6,4,8,3,2,7,1,5},
        {7,5,8,6,4,1,9,2,3},
        {2,1,3,5,9,7,8,6,4},
        {5,2,7,3,6,8,4,9,1},
        {3,9,1,4,2,5,6,7,8},
        {8,4,6,7,1,9,5,3,2},
        {1,7,5,9,8,3,2,4,6},
        {4,8,2,1,7,6,3,5,9},
        {6,3,9,2,5,4,1,8,7},

         };
        private void kolaysudoku_Load(object sender, EventArgs e)
        {
            butonlar[0, 1] = button2;
            butonlar[0, 2] = button3;

            butonlar[1, 0] = button10;
            butonlar[1, 4] = button4;

            butonlar[2, 2] = button11;
            butonlar[2, 3] = button28;
            butonlar[2, 6] = button5;

            butonlar[3, 0] = button8;
            butonlar[3, 2] = button12;
            butonlar[3, 3] = button13;
            butonlar[3, 4] = button14;
            butonlar[3, 5] = button15;

            butonlar[4, 1] = button16;
            butonlar[4, 7] = button7;

            butonlar[5, 7] = button17;
            butonlar[5, 8] = button18;

            butonlar[6, 2] = button6;
            butonlar[6, 8] = button9;

            butonlar[7, 0] = button19;
            butonlar[7, 1] = button20;
            butonlar[7, 5] = button21;
            butonlar[7, 6] = button22;

            butonlar[8, 2] = button23;
            butonlar[8, 3] = button24;
            butonlar[8, 6] = button25;
            butonlar[8, 7] = button26;


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            CozumKontrol kontrol = new CozumKontrol(butonlar, dogruCozum);
            kontrol.KontrolEt();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {

            SudokuFormu sudok = new SudokuFormu();
            sudok.Show();
            this.Hide();
        }

       
        }
    }

