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
    public partial class kelimeoyunu : Form
    {
        List<string> wordList = new List<string>
{
    "KÖPRÜ", "KARTAL", "ÇİÇEK", "YAĞMUR", "ÖĞRENCİ",
    "ŞEMSİYE", "BAHÇE", "KÜTÜPHANE", "GÖZLÜK", "YOLCULUK",
    "SERÜVEN", "TUNÇ", "KASABA", "DENİZ", "PAZARLIK",
    "FENER", "SAKLAMA", "PATİKA", "YERLEŞİM", "KUMSAL",
    "MÜZİSYEN", "YILDIZ", "JAGUAR", "KÜÇÜKÇEKMECE", "GÖKDELEN"
};
        private List<string> foundWords = new List<string>();


        Label[,] letterGrid = new Label[20, 20];
        Random rnd = new Random();
        List<Label> selectedLetters = new List<Label>();

        public kelimeoyunu()
        {
            InitializeComponent();
            CreateBoard();
            LoadWordListToListBox();
        }

        void CreateBoard()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.ColumnCount = 20;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < 20; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Label lbl = new Label();
                    lbl.Text = ""; 
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Font = new Font("Arial", 14, FontStyle.Bold);
                    lbl.BackColor = Color.White;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.Click += Letter_Click;

                    letterGrid[i, j] = lbl;
                    tableLayoutPanel1.Controls.Add(lbl, j, i);
                }
            }

            PlaceWords();
            FillEmptyCells();
        }

        void Letter_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (selectedLetters.Contains(clickedLabel))
            {
                
                if (clickedLabel.BackColor == Color.Yellow)
                {
                    clickedLabel.BackColor = Color.White;
                }
               
                selectedLetters.Remove(clickedLabel);
            }
            else
            {
                selectedLetters.Add(clickedLabel);

                
                if (!foundWordColors.Values.Contains(clickedLabel.BackColor))
                {
                    clickedLabel.BackColor = Color.Yellow;
                }
            }
        }


        void PlaceWords()
        {

            foreach (string word in wordList)
            {
                bool placed = false;
                int attempts = 0;

                while (!placed && attempts < 100)
                {
                    attempts++;

                    int direction = rnd.Next(0, 3);
                    int dRow = 0, dCol = 0;

                    if (direction == 0) { dRow = 0; dCol = 1; }       
                    else if (direction == 1) { dRow = 1; dCol = 0; }  
                    else if (direction == 2) { dRow = 1; dCol = 1; }  

                    int maxStartRow = direction == 1 || direction == 2 ? 20 - word.Length : 20;
                    int maxStartCol = direction == 0 || direction == 2 ? 20 - word.Length : 20;

                    int startRow = rnd.Next(0, maxStartRow);
                    int startCol = rnd.Next(0, maxStartCol);

                    if (CanPlaceWord(word, startRow, startCol, dRow, dCol))
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            letterGrid[startRow + i * dRow, startCol + i * dCol].Text = word[i].ToString();
                        }
                        placed = true;
                    }
                }

                if (!placed)
                {
                    MessageBox.Show($"'{word}' tabloya yerleştirilemedi.");
                }
            }
        }

        bool CanPlaceWord(string word, int row, int col, int dRow, int dCol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                int r = row + i * dRow;
                int c = col + i * dCol;

                if (r < 0 || r >= 20 || c < 0 || c >= 20)
                    return false;

                string existingLetter = letterGrid[r, c].Text;
                if (existingLetter != "" && existingLetter != word[i].ToString())
                    return false;
            }
            return true;
        }

        void FillEmptyCells()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (string.IsNullOrWhiteSpace(letterGrid[i, j].Text))
                    {
                        letterGrid[i, j].Text = ((char)('A' + rnd.Next(0, 26))).ToString();
                    }
                }
            }
        }


        private Dictionary<string, Color> foundWordColors = new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase);

        private Color[] wordColors = new Color[]
        {
             Color.LightGreen,
             Color.LightBlue,
             Color.LightCoral,
             Color.LightGoldenrodYellow,
             Color.Plum
        };


        void LoadWordListToListBox()
        {
            listBox1.Items.Clear();
            foreach (var word in wordList)
                listBox1.Items.Add(word);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedWord = string.Concat(selectedLetters.Select(l => l.Text));
            var foundWord = wordList.FirstOrDefault(w => w.Equals(selectedWord, StringComparison.OrdinalIgnoreCase));

            if (foundWord != null && !foundWordColors.ContainsKey(foundWord))
            {
                Color assignedColor = wordColors[foundWordColors.Count % wordColors.Length];
                foundWordColors[foundWord] = assignedColor;

                foreach (Label lbl in selectedLetters)
                    lbl.BackColor = assignedColor;

                foundWords.Add(foundWord);
                listBox1.Items.Remove(foundWord);
                selectedLetters.Clear();
            }
            else
            {
                foreach (Label lbl in selectedLetters.ToList())
                {
                    if (lbl.BackColor == Color.Yellow) 
                    {
                        lbl.BackColor = Color.White;
                    }
                }

                selectedLetters.Clear();
            }

            if (foundWords.Count == wordList.Count)
            {
                MessageBox.Show("🎉 Tebrikler! Tüm kelimeleri buldunuz.");
                LoadWordListToListBox();
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void kelimeoyunu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelimeOyunuFormu kelimeoyunu = new KelimeOyunuFormu();
            kelimeoyunu.Show();
            this.Hide();
        }
    }
}

