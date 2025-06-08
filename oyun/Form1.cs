namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbbx_secim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btn_satranc_Click(object sender, EventArgs e)
        {

            SatrancFormu satrancFormu = new SatrancFormu();
            satrancFormu.Show();
            this.Hide();


        }

        private void btn_sudoku_Click(object sender, EventArgs e)
        {
            SudokuFormu sudokuFormu = new SudokuFormu();
            sudokuFormu.Show();
            this.Hide();
        }

        private void btn_ko_Click(object sender, EventArgs e)
        {
            KelimeOyunuFormu kelime = new KelimeOyunuFormu();
            kelime.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

