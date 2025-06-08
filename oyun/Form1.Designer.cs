namespace oyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_oyunsecim = new Label();
            btn_satranc = new Button();
            btn_sudoku = new Button();
            btn_ko = new Button();
            SuspendLayout();
            // 
            // lbl_oyunsecim
            // 
            lbl_oyunsecim.AutoSize = true;
            lbl_oyunsecim.BackColor = Color.Transparent;
            lbl_oyunsecim.Font = new Font("Verdana", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_oyunsecim.Location = new Point(76, 108);
            lbl_oyunsecim.Name = "lbl_oyunsecim";
            lbl_oyunsecim.Size = new Size(801, 53);
            lbl_oyunsecim.TabIndex = 0;
            lbl_oyunsecim.Text = "Oynamak istediğiniz oyunu seçiniz:";
            lbl_oyunsecim.Click += label1_Click;
            // 
            // btn_satranc
            // 
            btn_satranc.BackColor = Color.FromArgb(174, 122, 71);
            btn_satranc.FlatStyle = FlatStyle.Flat;
            btn_satranc.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_satranc.Location = new Point(100, 244);
            btn_satranc.Name = "btn_satranc";
            btn_satranc.Size = new Size(211, 100);
            btn_satranc.TabIndex = 2;
            btn_satranc.Text = "SATRANÇ";
            btn_satranc.UseVisualStyleBackColor = false;
            btn_satranc.Click += btn_satranc_Click;
            // 
            // btn_sudoku
            // 
            btn_sudoku.BackColor = Color.FromArgb(174, 122, 71);
            btn_sudoku.FlatStyle = FlatStyle.Flat;
            btn_sudoku.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sudoku.Location = new Point(348, 372);
            btn_sudoku.Name = "btn_sudoku";
            btn_sudoku.Size = new Size(211, 100);
            btn_sudoku.TabIndex = 3;
            btn_sudoku.Text = "SUDOKU";
            btn_sudoku.UseVisualStyleBackColor = false;
            btn_sudoku.Click += btn_sudoku_Click;
            // 
            // btn_ko
            // 
            btn_ko.BackColor = Color.FromArgb(174, 122, 71);
            btn_ko.FlatStyle = FlatStyle.Flat;
            btn_ko.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ko.Location = new Point(600, 244);
            btn_ko.Name = "btn_ko";
            btn_ko.Size = new Size(206, 100);
            btn_ko.TabIndex = 4;
            btn_ko.Text = "KELİME OYUNU";
            btn_ko.UseVisualStyleBackColor = false;
            btn_ko.Click += btn_ko_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.giris;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 629);
            Controls.Add(btn_ko);
            Controls.Add(btn_sudoku);
            Controls.Add(btn_satranc);
            Controls.Add(lbl_oyunsecim);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_oyunsecim;
        private Button btn_satranc;
        private Button btn_sudoku;
        private Button btn_ko;
    }
}
