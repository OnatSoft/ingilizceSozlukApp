
namespace İngilizceSozlukApp_7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Txtİngilizce = new System.Windows.Forms.TextBox();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSkor = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnTekrar = new System.Windows.Forms.Button();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtİngilizce
            // 
            this.Txtİngilizce.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txtİngilizce.Location = new System.Drawing.Point(161, 55);
            this.Txtİngilizce.Name = "Txtİngilizce";
            this.Txtİngilizce.Size = new System.Drawing.Size(192, 27);
            this.Txtİngilizce.TabIndex = 0;
            this.Txtİngilizce.TextChanged += new System.EventHandler(this.Txtİngilizce_TextChanged);
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTurkce.Location = new System.Drawing.Point(161, 86);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.ReadOnly = true;
            this.TxtTurkce.Size = new System.Drawing.Size(192, 27);
            this.TxtTurkce.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İngilizce Kelime =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türkçe Kelime =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(439, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skor =";
            // 
            // LblSkor
            // 
            this.LblSkor.AutoSize = true;
            this.LblSkor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSkor.ForeColor = System.Drawing.SystemColors.Window;
            this.LblSkor.Location = new System.Drawing.Point(527, 55);
            this.LblSkor.Name = "LblSkor";
            this.LblSkor.Size = new System.Drawing.Size(33, 37);
            this.LblSkor.TabIndex = 5;
            this.LblSkor.Text = "0";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCevap.ForeColor = System.Drawing.SystemColors.Window;
            this.LblCevap.Location = new System.Drawing.Point(440, 97);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(55, 20);
            this.LblCevap.TabIndex = 6;
            this.LblCevap.Text = "Kelime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(438, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Süre =";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.ForeColor = System.Drawing.SystemColors.Window;
            this.LblSure.Location = new System.Drawing.Point(526, 9);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(74, 45);
            this.LblSure.TabIndex = 8;
            this.LblSure.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnTekrar
            // 
            this.BtnTekrar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnTekrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTekrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTekrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTekrar.Location = new System.Drawing.Point(161, 142);
            this.BtnTekrar.Name = "BtnTekrar";
            this.BtnTekrar.Size = new System.Drawing.Size(192, 40);
            this.BtnTekrar.TabIndex = 9;
            this.BtnTekrar.Text = "Yeniden Başlat";
            this.BtnTekrar.UseVisualStyleBackColor = false;
            this.BtnTekrar.Visible = false;
            this.BtnTekrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.BackColor = System.Drawing.Color.Tan;
            this.btnKelimeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKelimeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelimeEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeEkle.ForeColor = System.Drawing.Color.Black;
            this.btnKelimeEkle.Location = new System.Drawing.Point(537, 142);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(161, 40);
            this.btnKelimeEkle.TabIndex = 10;
            this.btnKelimeEkle.Text = "Yeni Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = false;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(459, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Durdur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(381, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(2, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Made by EchoSoft. 2023";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(704, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.BtnTekrar);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblSkor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.Txtİngilizce);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İngilizce Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtİngilizce;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSkor;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnTekrar;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

