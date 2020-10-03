namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.operasi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textnilaiA = new System.Windows.Forms.TextBox();
            this.textnilaiB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.texthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operasi.Location = new System.Drawing.Point(105, 46);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(121, 21);
            this.operasi.TabIndex = 1;
            this.operasi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai B";
            // 
            // textnilaiA
            // 
            this.textnilaiA.Location = new System.Drawing.Point(105, 103);
            this.textnilaiA.Name = "textnilaiA";
            this.textnilaiA.Size = new System.Drawing.Size(121, 20);
            this.textnilaiA.TabIndex = 4;
            // 
            // textnilaiB
            // 
            this.textnilaiB.Location = new System.Drawing.Point(105, 145);
            this.textnilaiB.Name = "textnilaiB";
            this.textnilaiB.Size = new System.Drawing.Size(121, 20);
            this.textnilaiB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil";
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(138, 253);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(87, 27);
            this.hitung.TabIndex = 8;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // texthasil
            // 
            this.texthasil.Location = new System.Drawing.Point(104, 186);
            this.texthasil.Name = "texthasil";
            this.texthasil.ReadOnly = true;
            this.texthasil.ShortcutsEnabled = false;
            this.texthasil.Size = new System.Drawing.Size(121, 20);
            this.texthasil.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 305);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.texthasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnilaiB);
            this.Controls.Add(this.textnilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nilai A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnilaiA;
        private System.Windows.Forms.TextBox textnilaiB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.TextBox texthasil;
    }
}

