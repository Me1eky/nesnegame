namespace oyun
{
    partial class SatrancFormu
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
            label2 = new Label();
            btn_ikioyunculu = new Button();
            btn_geri = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Viner Hand ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(253, 221, 168);
            label2.Location = new Point(338, 69);
            label2.Name = "label2";
            label2.Size = new Size(270, 76);
            label2.TabIndex = 1;
            label2.Text = "SATRANÇ";
            label2.Click += label2_Click;
            // 
            // btn_ikioyunculu
            // 
            btn_ikioyunculu.BackColor = Color.FromArgb(110, 63, 26);
            btn_ikioyunculu.FlatStyle = FlatStyle.Flat;
            btn_ikioyunculu.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ikioyunculu.ForeColor = Color.FromArgb(253, 221, 168);
            btn_ikioyunculu.Location = new Point(321, 257);
            btn_ikioyunculu.Name = "btn_ikioyunculu";
            btn_ikioyunculu.Size = new Size(287, 112);
            btn_ikioyunculu.TabIndex = 4;
            btn_ikioyunculu.Text = "İKİ OYUNCULU";
            btn_ikioyunculu.UseVisualStyleBackColor = false;
            btn_ikioyunculu.Click += btn_orta_Click;
            // 
            // btn_geri
            // 
            btn_geri.BackColor = Color.Transparent;
            btn_geri.FlatStyle = FlatStyle.Flat;
            btn_geri.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_geri.ForeColor = Color.FromArgb(253, 221, 168);
            btn_geri.Location = new Point(12, 25);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(100, 57);
            btn_geri.TabIndex = 6;
            btn_geri.Text = "GERİ";
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += btn_geri_Click;
            // 
            // SatrancFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.satranc;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 629);
            Controls.Add(btn_geri);
            Controls.Add(btn_ikioyunculu);
            Controls.Add(label2);
            Name = "SatrancFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SatrancFormu";
            Load += SatrancFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_ikioyunculu;
        private Button btn_geri;
    }
}