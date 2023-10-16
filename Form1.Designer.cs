
namespace ExchangeRateConvertor_v1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.kynkTutarTxt = new System.Windows.Forms.TextBox();
            this.kaynakCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hedefCmb = new System.Windows.Forms.ComboBox();
            this.hedefTutarTxt = new System.Windows.Forms.TextBox();
            this.hedefKurTxt = new System.Windows.Forms.TextBox();
            this.kaynakKurTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tarihlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Exchange Amount:";
            // 
            // kynkTutarTxt
            // 
            this.kynkTutarTxt.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kynkTutarTxt.Location = new System.Drawing.Point(222, 41);
            this.kynkTutarTxt.Name = "kynkTutarTxt";
            this.kynkTutarTxt.Size = new System.Drawing.Size(339, 26);
            this.kynkTutarTxt.TabIndex = 1;
            // 
            // kaynakCmb
            // 
            this.kaynakCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kaynakCmb.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakCmb.FormattingEnabled = true;
            this.kaynakCmb.Items.AddRange(new object[] {
            "TRY - TÜRK LİRASI",
            "USD - ABD DOLARI",
            "AUD - AVUSTRALYA DOLARI",
            "DKK - DANİMARKA KRONU",
            "EUR - EURO",
            "GBP - İNGİLİZ STERLİNİ",
            "CHF - İSVİÇRE FRANGI",
            "SEK - İSVEÇ KRONU",
            "CAD - KANADA DOLARI",
            "KWD - KUVEYT DİNARI",
            "NOK - NORVEÇ KRONU",
            "SAR - SUUDİ ARABİSTAN RİYALİ",
            "JPY - JAPON YENİ"});
            this.kaynakCmb.Location = new System.Drawing.Point(222, 94);
            this.kaynakCmb.Name = "kaynakCmb";
            this.kaynakCmb.Size = new System.Drawing.Size(339, 26);
            this.kaynakCmb.TabIndex = 2;
            this.kaynakCmb.SelectedIndexChanged += new System.EventHandler(this.kaynakCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "(Kaynak Değişim Tutarı)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source Currency Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Kaynak Para Birimi)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Source Exchange Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "(Kaynak Döviz Kuru)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Target Exchange Code: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "(Hedef Para Birimi)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Target Exchange Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "(Hedef Döviz Kuru)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Target Exchange Amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(24, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "(Hedef Değişim Tutarı)";
            // 
            // hedefCmb
            // 
            this.hedefCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hedefCmb.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedefCmb.FormattingEnabled = true;
            this.hedefCmb.Items.AddRange(new object[] {
            "TRY - TÜRK LİRASI",
            "USD - ABD DOLARI",
            "AUD - AVUSTRALYA DOLARI",
            "DKK - DANİMARKA KRONU",
            "EUR - EURO",
            "GBP - İNGİLİZ STERLİNİ",
            "CHF - İSVİÇRE FRANGI",
            "SEK - İSVEÇ KRONU",
            "CAD - KANADA DOLARI",
            "KWD - KUVEYT DİNARI",
            "NOK - NORVEÇ KRONU",
            "SAR - SUUDİ ARABİSTAN RİYALİ",
            "JPY - JAPON YENİ"});
            this.hedefCmb.Location = new System.Drawing.Point(222, 194);
            this.hedefCmb.Name = "hedefCmb";
            this.hedefCmb.Size = new System.Drawing.Size(339, 26);
            this.hedefCmb.TabIndex = 14;
            this.hedefCmb.SelectedIndexChanged += new System.EventHandler(this.hedefCmb_SelectedIndexChanged);
            // 
            // hedefTutarTxt
            // 
            this.hedefTutarTxt.Enabled = false;
            this.hedefTutarTxt.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedefTutarTxt.Location = new System.Drawing.Point(222, 290);
            this.hedefTutarTxt.Name = "hedefTutarTxt";
            this.hedefTutarTxt.Size = new System.Drawing.Size(339, 26);
            this.hedefTutarTxt.TabIndex = 15;
            // 
            // hedefKurTxt
            // 
            this.hedefKurTxt.Enabled = false;
            this.hedefKurTxt.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hedefKurTxt.Location = new System.Drawing.Point(222, 244);
            this.hedefKurTxt.Name = "hedefKurTxt";
            this.hedefKurTxt.Size = new System.Drawing.Size(339, 26);
            this.hedefKurTxt.TabIndex = 16;
            // 
            // kaynakKurTxt
            // 
            this.kaynakKurTxt.Enabled = false;
            this.kaynakKurTxt.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakKurTxt.Location = new System.Drawing.Point(222, 144);
            this.kaynakKurTxt.Name = "kaynakKurTxt";
            this.kaynakKurTxt.Size = new System.Drawing.Size(339, 26);
            this.kaynakKurTxt.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(567, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 170);
            this.button1.TabIndex = 18;
            this.button1.Text = "C\r\nO\r\nN\r\nV\r\nE\r\nR\r\nT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarihlbl
            // 
            this.tarihlbl.AutoSize = true;
            this.tarihlbl.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihlbl.Location = new System.Drawing.Point(485, 12);
            this.tarihlbl.Name = "tarihlbl";
            this.tarihlbl.Size = new System.Drawing.Size(46, 18);
            this.tarihlbl.TabIndex = 19;
            this.tarihlbl.Text = "Tarih:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(0, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 56);
            this.panel1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(607, 39);
            this.label13.TabIndex = 0;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(615, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tarihlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kaynakKurTxt);
            this.Controls.Add(this.hedefKurTxt);
            this.Controls.Add(this.hedefTutarTxt);
            this.Controls.Add(this.hedefCmb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaynakCmb);
            this.Controls.Add(this.kynkTutarTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Source Exchange Rate Convertor v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kynkTutarTxt;
        private System.Windows.Forms.ComboBox kaynakCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox hedefCmb;
        private System.Windows.Forms.TextBox hedefTutarTxt;
        private System.Windows.Forms.TextBox hedefKurTxt;
        private System.Windows.Forms.TextBox kaynakKurTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tarihlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
    }
}

