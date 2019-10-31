namespace WindowsFormsApp3
{
    partial class ÖDEV
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
            this.maashesaplabtn = new System.Windows.Forms.Button();
            this.tckimliktext = new System.Windows.Forms.Label();
            this.maas = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tctextbox = new System.Windows.Forms.TextBox();
            this.dosyasec = new System.Windows.Forms.Button();
            this.maasgroupbox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.netmaaslbl = new System.Windows.Forms.Label();
            this.brütmaaslbl = new System.Windows.Forms.Label();
            this.damgavergisilbl = new System.Windows.Forms.Label();
            this.emeklikesintisilbl = new System.Windows.Forms.Label();
            this.gelirvergisilbl = new System.Windows.Forms.Label();
            this.brütsonuclbl = new System.Windows.Forms.Label();
            this.damgavergisisonuclbl = new System.Windows.Forms.Label();
            this.gelirvergisisonuclbl = new System.Windows.Forms.Label();
            this.emeklikesintisisonuclbl = new System.Windows.Forms.Label();
            this.maasgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maashesaplabtn
            // 
            this.maashesaplabtn.Location = new System.Drawing.Point(163, 118);
            this.maashesaplabtn.Name = "maashesaplabtn";
            this.maashesaplabtn.Size = new System.Drawing.Size(137, 82);
            this.maashesaplabtn.TabIndex = 0;
            this.maashesaplabtn.Text = "MAAŞ HESAPLA";
            this.maashesaplabtn.UseVisualStyleBackColor = true;
            this.maashesaplabtn.Click += new System.EventHandler(this.maashesaplabtn_Click);
            // 
            // tckimliktext
            // 
            this.tckimliktext.AutoSize = true;
            this.tckimliktext.Location = new System.Drawing.Point(13, 62);
            this.tckimliktext.Name = "tckimliktext";
            this.tckimliktext.Size = new System.Drawing.Size(102, 17);
            this.tckimliktext.TabIndex = 1;
            this.tckimliktext.Text = "TC KİMLİK NO:";
            // 
            // maas
            // 
            this.maas.AutoSize = true;
            this.maas.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maas.Location = new System.Drawing.Point(28, 40);
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(0, 42);
            this.maas.TabIndex = 3;
            this.maas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 225);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1665, 336);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tctextbox
            // 
            this.tctextbox.Location = new System.Drawing.Point(121, 62);
            this.tctextbox.MaxLength = 11;
            this.tctextbox.Name = "tctextbox";
            this.tctextbox.Size = new System.Drawing.Size(179, 22);
            this.tctextbox.TabIndex = 5;
            this.tctextbox.TextChanged += new System.EventHandler(this.tctextbox_TextChanged);
            this.tctextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tctextbox_KeyPress);
            // 
            // dosyasec
            // 
            this.dosyasec.Location = new System.Drawing.Point(1551, 590);
            this.dosyasec.Name = "dosyasec";
            this.dosyasec.Size = new System.Drawing.Size(130, 82);
            this.dosyasec.TabIndex = 6;
            this.dosyasec.Text = "DOSYA SEÇ";
            this.dosyasec.UseVisualStyleBackColor = true;
            this.dosyasec.Click += new System.EventHandler(this.dosyasec_Click);
            // 
            // maasgroupbox
            // 
            this.maasgroupbox.Controls.Add(this.maas);
            this.maasgroupbox.Location = new System.Drawing.Point(565, 31);
            this.maasgroupbox.Name = "maasgroupbox";
            this.maasgroupbox.Size = new System.Drawing.Size(196, 130);
            this.maasgroupbox.TabIndex = 7;
            this.maasgroupbox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(1069, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // netmaaslbl
            // 
            this.netmaaslbl.AutoSize = true;
            this.netmaaslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.netmaaslbl.Location = new System.Drawing.Point(363, 80);
            this.netmaaslbl.Name = "netmaaslbl";
            this.netmaaslbl.Size = new System.Drawing.Size(169, 31);
            this.netmaaslbl.TabIndex = 9;
            this.netmaaslbl.Text = "NET MAAŞ:";
            // 
            // brütmaaslbl
            // 
            this.brütmaaslbl.AutoSize = true;
            this.brütmaaslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brütmaaslbl.Location = new System.Drawing.Point(816, 41);
            this.brütmaaslbl.Name = "brütmaaslbl";
            this.brütmaaslbl.Size = new System.Drawing.Size(102, 17);
            this.brütmaaslbl.TabIndex = 10;
            this.brütmaaslbl.Text = "BRÜT MAAŞ:";
            // 
            // damgavergisilbl
            // 
            this.damgavergisilbl.AutoSize = true;
            this.damgavergisilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.damgavergisilbl.Location = new System.Drawing.Point(816, 71);
            this.damgavergisilbl.Name = "damgavergisilbl";
            this.damgavergisilbl.Size = new System.Drawing.Size(134, 17);
            this.damgavergisilbl.TabIndex = 11;
            this.damgavergisilbl.Text = "DAMGA VERGİSİ:";
            // 
            // emeklikesintisilbl
            // 
            this.emeklikesintisilbl.AutoSize = true;
            this.emeklikesintisilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emeklikesintisilbl.Location = new System.Drawing.Point(816, 131);
            this.emeklikesintisilbl.Name = "emeklikesintisilbl";
            this.emeklikesintisilbl.Size = new System.Drawing.Size(146, 17);
            this.emeklikesintisilbl.TabIndex = 13;
            this.emeklikesintisilbl.Text = "EMEKLİ KESİNTİSİ:";
            // 
            // gelirvergisilbl
            // 
            this.gelirvergisilbl.AutoSize = true;
            this.gelirvergisilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirvergisilbl.Location = new System.Drawing.Point(816, 101);
            this.gelirvergisilbl.Name = "gelirvergisilbl";
            this.gelirvergisilbl.Size = new System.Drawing.Size(125, 17);
            this.gelirvergisilbl.TabIndex = 12;
            this.gelirvergisilbl.Text = "GELİR VERGİSİ:";
            // 
            // brütsonuclbl
            // 
            this.brütsonuclbl.AutoSize = true;
            this.brütsonuclbl.Location = new System.Drawing.Point(926, 41);
            this.brütsonuclbl.Name = "brütsonuclbl";
            this.brütsonuclbl.Size = new System.Drawing.Size(0, 17);
            this.brütsonuclbl.TabIndex = 14;
            // 
            // damgavergisisonuclbl
            // 
            this.damgavergisisonuclbl.AutoSize = true;
            this.damgavergisisonuclbl.Location = new System.Drawing.Point(958, 71);
            this.damgavergisisonuclbl.Name = "damgavergisisonuclbl";
            this.damgavergisisonuclbl.Size = new System.Drawing.Size(0, 17);
            this.damgavergisisonuclbl.TabIndex = 15;
            // 
            // gelirvergisisonuclbl
            // 
            this.gelirvergisisonuclbl.AutoSize = true;
            this.gelirvergisisonuclbl.Location = new System.Drawing.Point(949, 101);
            this.gelirvergisisonuclbl.Name = "gelirvergisisonuclbl";
            this.gelirvergisisonuclbl.Size = new System.Drawing.Size(0, 17);
            this.gelirvergisisonuclbl.TabIndex = 16;
            // 
            // emeklikesintisisonuclbl
            // 
            this.emeklikesintisisonuclbl.AutoSize = true;
            this.emeklikesintisisonuclbl.Location = new System.Drawing.Point(969, 131);
            this.emeklikesintisisonuclbl.Name = "emeklikesintisisonuclbl";
            this.emeklikesintisisonuclbl.Size = new System.Drawing.Size(0, 17);
            this.emeklikesintisisonuclbl.TabIndex = 17;
            // 
            // ÖDEV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1803, 1055);
            this.Controls.Add(this.emeklikesintisisonuclbl);
            this.Controls.Add(this.gelirvergisisonuclbl);
            this.Controls.Add(this.damgavergisisonuclbl);
            this.Controls.Add(this.brütsonuclbl);
            this.Controls.Add(this.emeklikesintisilbl);
            this.Controls.Add(this.gelirvergisilbl);
            this.Controls.Add(this.damgavergisilbl);
            this.Controls.Add(this.brütmaaslbl);
            this.Controls.Add(this.netmaaslbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maasgroupbox);
            this.Controls.Add(this.dosyasec);
            this.Controls.Add(this.tctextbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tckimliktext);
            this.Controls.Add(this.maashesaplabtn);
            this.Name = "ÖDEV";
            this.Text = "PERSONEL MAAŞ HESAPLAMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ÖDEV_Load);
            this.maasgroupbox.ResumeLayout(false);
            this.maasgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maashesaplabtn;
        private System.Windows.Forms.Label tckimliktext;
        private System.Windows.Forms.Label maas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tctextbox;
        private System.Windows.Forms.Button dosyasec;
        private System.Windows.Forms.GroupBox maasgroupbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label netmaaslbl;
        private System.Windows.Forms.Label brütmaaslbl;
        private System.Windows.Forms.Label damgavergisilbl;
        private System.Windows.Forms.Label emeklikesintisilbl;
        private System.Windows.Forms.Label gelirvergisilbl;
        private System.Windows.Forms.Label brütsonuclbl;
        private System.Windows.Forms.Label damgavergisisonuclbl;
        private System.Windows.Forms.Label gelirvergisisonuclbl;
        private System.Windows.Forms.Label emeklikesintisisonuclbl;
    }
}

