namespace yakitOtotmasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.alis = new System.Windows.Forms.CheckBox();
            this.satis = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yakit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.benzin = new System.Windows.Forms.TextBox();
            this.dizel = new System.Windows.Forms.TextBox();
            this.lpg = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.yakitMiktar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.benzinbar = new System.Windows.Forms.ProgressBar();
            this.lpgBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.dizelBar = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.personelKazanc = new System.Windows.Forms.ComboBox();
            this.toplamkazanc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kazancKutu = new System.Windows.Forms.ListBox();
            this.tutaragore = new System.Windows.Forms.RadioButton();
            this.litreyegore = new System.Windows.Forms.RadioButton();
            this.kazancgetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alis
            // 
            this.alis.AutoSize = true;
            this.alis.Location = new System.Drawing.Point(12, 27);
            this.alis.Name = "alis";
            this.alis.Size = new System.Drawing.Size(42, 17);
            this.alis.TabIndex = 0;
            this.alis.Text = "Alış";
            this.alis.UseVisualStyleBackColor = true;
            // 
            // satis
            // 
            this.satis.AutoSize = true;
            this.satis.Location = new System.Drawing.Point(12, 51);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(49, 17);
            this.satis.TabIndex = 1;
            this.satis.Text = "Satış";
            this.satis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // personel
            // 
            this.personel.FormattingEnabled = true;
            this.personel.Location = new System.Drawing.Point(138, 36);
            this.personel.Name = "personel";
            this.personel.Size = new System.Drawing.Size(121, 21);
            this.personel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yakıt";
            // 
            // yakit
            // 
            this.yakit.FormattingEnabled = true;
            this.yakit.Location = new System.Drawing.Point(324, 36);
            this.yakit.Name = "yakit";
            this.yakit.Size = new System.Drawing.Size(121, 21);
            this.yakit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Benzin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dizel  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "LPG";
            // 
            // benzin
            // 
            this.benzin.Location = new System.Drawing.Point(600, 16);
            this.benzin.Name = "benzin";
            this.benzin.Size = new System.Drawing.Size(100, 20);
            this.benzin.TabIndex = 9;
            // 
            // dizel
            // 
            this.dizel.Location = new System.Drawing.Point(600, 39);
            this.dizel.Name = "dizel";
            this.dizel.Size = new System.Drawing.Size(100, 20);
            this.dizel.TabIndex = 10;
            // 
            // lpg
            // 
            this.lpg.Location = new System.Drawing.Point(600, 66);
            this.lpg.Name = "lpg";
            this.lpg.Size = new System.Drawing.Size(100, 20);
            this.lpg.TabIndex = 11;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(719, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Güncelle";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(719, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(68, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Güncelle";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(719, 68);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Güncelle";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(816, 12);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(68, 74);
            this.guncelle.TabIndex = 15;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Litre veya Tutar Girişi :\r\n";
            // 
            // yakitMiktar
            // 
            this.yakitMiktar.Location = new System.Drawing.Point(292, 117);
            this.yakitMiktar.Name = "yakitMiktar";
            this.yakitMiktar.Size = new System.Drawing.Size(386, 20);
            this.yakitMiktar.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(501, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "İşlem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Benzin";
            // 
            // benzinbar
            // 
            this.benzinbar.Location = new System.Drawing.Point(84, 249);
            this.benzinbar.Name = "benzinbar";
            this.benzinbar.Size = new System.Drawing.Size(704, 23);
            this.benzinbar.TabIndex = 20;
            // 
            // lpgBar
            // 
            this.lpgBar.Location = new System.Drawing.Point(84, 343);
            this.lpgBar.Name = "lpgBar";
            this.lpgBar.Size = new System.Drawing.Size(704, 23);
            this.lpgBar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "LPG";
            // 
            // dizelBar
            // 
            this.dizelBar.Location = new System.Drawing.Point(84, 295);
            this.dizelBar.Name = "dizelBar";
            this.dizelBar.Size = new System.Drawing.Size(704, 23);
            this.dizelBar.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dizel  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Personel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Toplam";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // personelKazanc
            // 
            this.personelKazanc.FormattingEnabled = true;
            this.personelKazanc.Location = new System.Drawing.Point(131, 401);
            this.personelKazanc.Name = "personelKazanc";
            this.personelKazanc.Size = new System.Drawing.Size(121, 21);
            this.personelKazanc.TabIndex = 27;
            // 
            // toplamkazanc
            // 
            this.toplamkazanc.Location = new System.Drawing.Point(128, 436);
            this.toplamkazanc.Name = "toplamkazanc";
            this.toplamkazanc.Size = new System.Drawing.Size(124, 20);
            this.toplamkazanc.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Kazanç  ";
            // 
            // kazancKutu
            // 
            this.kazancKutu.FormattingEnabled = true;
            this.kazancKutu.Location = new System.Drawing.Point(368, 394);
            this.kazancKutu.Name = "kazancKutu";
            this.kazancKutu.Size = new System.Drawing.Size(383, 95);
            this.kazancKutu.TabIndex = 30;
            // 
            // tutaragore
            // 
            this.tutaragore.AutoSize = true;
            this.tutaragore.Location = new System.Drawing.Point(461, 18);
            this.tutaragore.Name = "tutaragore";
            this.tutaragore.Size = new System.Drawing.Size(85, 17);
            this.tutaragore.TabIndex = 31;
            this.tutaragore.TabStop = true;
            this.tutaragore.Text = "Tutara Göre ";
            this.tutaragore.UseVisualStyleBackColor = true;
            // 
            // litreyegore
            // 
            this.litreyegore.AutoSize = true;
            this.litreyegore.Location = new System.Drawing.Point(461, 51);
            this.litreyegore.Name = "litreyegore";
            this.litreyegore.Size = new System.Drawing.Size(85, 17);
            this.litreyegore.TabIndex = 32;
            this.litreyegore.TabStop = true;
            this.litreyegore.Text = "Litreye Göre ";
            this.litreyegore.UseVisualStyleBackColor = true;
            // 
            // kazancgetir
            // 
            this.kazancgetir.Location = new System.Drawing.Point(147, 466);
            this.kazancgetir.Name = "kazancgetir";
            this.kazancgetir.Size = new System.Drawing.Size(75, 23);
            this.kazancgetir.TabIndex = 33;
            this.kazancgetir.Text = "Getir";
            this.kazancgetir.UseVisualStyleBackColor = true;
            this.kazancgetir.Click += new System.EventHandler(this.kazancgetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 501);
            this.Controls.Add(this.kazancgetir);
            this.Controls.Add(this.litreyegore);
            this.Controls.Add(this.tutaragore);
            this.Controls.Add(this.kazancKutu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toplamkazanc);
            this.Controls.Add(this.personelKazanc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dizelBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lpgBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.benzinbar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yakitMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.lpg);
            this.Controls.Add(this.dizel);
            this.Controls.Add(this.benzin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yakit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.satis);
            this.Controls.Add(this.alis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox alis;
        private System.Windows.Forms.CheckBox satis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox personel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox yakit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox benzin;
        private System.Windows.Forms.TextBox dizel;
        private System.Windows.Forms.TextBox lpg;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yakitMiktar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar benzinbar;
        private System.Windows.Forms.ProgressBar lpgBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar dizelBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox personelKazanc;
        private System.Windows.Forms.TextBox toplamkazanc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox kazancKutu;
        private System.Windows.Forms.RadioButton tutaragore;
        private System.Windows.Forms.RadioButton litreyegore;
        private System.Windows.Forms.Button kazancgetir;
    }
}

