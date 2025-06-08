namespace oyun
{
    partial class SudokuFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuFormu));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 431);
            label1.Name = "label1";
            label1.Size = new Size(235, 76);
            label1.TabIndex = 0;
            label1.Text = "SUDOKU";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 543);
            button1.Name = "button1";
            button1.Size = new Size(100, 57);
            button1.TabIndex = 1;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Viner Hand ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(639, 79);
            button2.Name = "button2";
            button2.Size = new Size(219, 91);
            button2.TabIndex = 2;
            button2.Text = "KOLAY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Viner Hand ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(590, 189);
            button3.Name = "button3";
            button3.Size = new Size(219, 95);
            button3.TabIndex = 3;
            button3.Text = "ORTA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Viner Hand ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(639, 301);
            button4.Name = "button4";
            button4.Size = new Size(219, 96);
            button4.TabIndex = 4;
            button4.Text = "ZOR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // SudokuFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 629);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "SudokuFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SudokuFormu";
            Load += SudokuFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}