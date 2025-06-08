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
    public partial class SudokuFormu : Form
    {
        public SudokuFormu()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 anaMenu = new Form1();
            anaMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kolaysudoku kolaysudoku = new kolaysudoku();
            kolaysudoku.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ortasudoku ortasudoku = new ortasudoku();
            ortasudoku.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zorsudoku zorsudoku = new zorsudoku();
            zorsudoku.Show();
            this.Hide();
        }

        private void SudokuFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
