
namespace OrtalamaHesaplamaUygulamasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ders_ismi_giris = new System.Windows.Forms.TextBox();
            this.sinavgiris1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sinavgiris2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.performansgiris1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.performansgiris2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hesaplabutton = new System.Windows.Forms.Button();
            this.sonuc_yazi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bait ilkokul, ortaokul, lise ders ortalaması hesaplama uyguaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Adı:";
            // 
            // Ders_ismi_giris
            // 
            this.Ders_ismi_giris.Location = new System.Drawing.Point(77, 45);
            this.Ders_ismi_giris.Name = "Ders_ismi_giris";
            this.Ders_ismi_giris.Size = new System.Drawing.Size(138, 23);
            this.Ders_ismi_giris.TabIndex = 2;
            // 
            // sinavgiris1
            // 
            this.sinavgiris1.Location = new System.Drawing.Point(77, 74);
            this.sinavgiris1.Name = "sinavgiris1";
            this.sinavgiris1.Size = new System.Drawing.Size(138, 23);
            this.sinavgiris1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "1. Sınav:";
            // 
            // sinavgiris2
            // 
            this.sinavgiris2.Location = new System.Drawing.Point(77, 103);
            this.sinavgiris2.Name = "sinavgiris2";
            this.sinavgiris2.Size = new System.Drawing.Size(138, 23);
            this.sinavgiris2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "2. Sınav:";
            // 
            // performansgiris1
            // 
            this.performansgiris1.Location = new System.Drawing.Point(106, 132);
            this.performansgiris1.Name = "performansgiris1";
            this.performansgiris1.Size = new System.Drawing.Size(138, 23);
            this.performansgiris1.TabIndex = 8;
            this.performansgiris1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "1. Performans:";
            // 
            // performansgiris2
            // 
            this.performansgiris2.Location = new System.Drawing.Point(106, 161);
            this.performansgiris2.Name = "performansgiris2";
            this.performansgiris2.Size = new System.Drawing.Size(138, 23);
            this.performansgiris2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. Performans:";
            // 
            // hesaplabutton
            // 
            this.hesaplabutton.Location = new System.Drawing.Point(106, 213);
            this.hesaplabutton.Name = "hesaplabutton";
            this.hesaplabutton.Size = new System.Drawing.Size(138, 31);
            this.hesaplabutton.TabIndex = 11;
            this.hesaplabutton.Text = "HESAPLA";
            this.hesaplabutton.UseVisualStyleBackColor = true;
            this.hesaplabutton.Click += new System.EventHandler(this.hesaplabutton_Click_1);
            // 
            // sonuc_yazi
            // 
            this.sonuc_yazi.AutoSize = true;
            this.sonuc_yazi.Location = new System.Drawing.Point(17, 263);
            this.sonuc_yazi.Name = "sonuc_yazi";
            this.sonuc_yazi.Size = new System.Drawing.Size(267, 30);
            this.sonuc_yazi.TabIndex = 12;
            this.sonuc_yazi.Text = "Hesaplama yapmak için gerekli alanları doldurun.\r\nDaha sonra HESAPLA butonuna bas" +
    "ınız";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "NBlackDev";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "github.com/nblackdev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 386);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sonuc_yazi);
            this.Controls.Add(this.hesaplabutton);
            this.Controls.Add(this.performansgiris2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.performansgiris1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sinavgiris2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinavgiris1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ders_ismi_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Ortalama Hesaplama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ders_ismi_giris;
        private System.Windows.Forms.TextBox sinavgiris1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sinavgiris2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox performansgiris1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox performansgiris2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hesaplabutton;
        private System.Windows.Forms.Label sonuc_yazi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}

