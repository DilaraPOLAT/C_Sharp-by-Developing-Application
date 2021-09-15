
namespace Tapu_Yonetim_Sistemi.app
{
    partial class frmKayitliEmlak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayitliEmlak));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblArsaSay = new System.Windows.Forms.Label();
            this.lblEvSay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapuVeriTabaniDataSet16 = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet16();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.evBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tapuVeriTabaniDataSet17 = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet17();
            this.arsaTableAdapter = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet16TableAdapters.ArsaTableAdapter();
            this.evTableAdapter = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet17TableAdapters.EvTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rAPORLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAPUARSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAPUEVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRaporArsa = new System.Windows.Forms.Button();
            this.btnRaporEv = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapuVeriTabaniDataSet16)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapuVeriTabaniDataSet17)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad Giriniz :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(203, 127);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(233, 36);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kayıtlı Arsa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kayıtlı Ev Sayısı:";
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.LightGray;
            this.btnBul.ForeColor = System.Drawing.Color.Black;
            this.btnBul.Location = new System.Drawing.Point(203, 169);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(233, 58);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblArsaSay
            // 
            this.lblArsaSay.AutoSize = true;
            this.lblArsaSay.Location = new System.Drawing.Point(223, 32);
            this.lblArsaSay.Name = "lblArsaSay";
            this.lblArsaSay.Size = new System.Drawing.Size(25, 29);
            this.lblArsaSay.TabIndex = 5;
            this.lblArsaSay.Text = "0";
            // 
            // lblEvSay
            // 
            this.lblEvSay.AutoSize = true;
            this.lblEvSay.Location = new System.Drawing.Point(209, 32);
            this.lblEvSay.Name = "lblEvSay";
            this.lblEvSay.Size = new System.Drawing.Size(25, 29);
            this.lblEvSay.TabIndex = 6;
            this.lblEvSay.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1206, 208);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARSA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // arsaBindingSource
            // 
            this.arsaBindingSource.DataMember = "Arsa";
            this.arsaBindingSource.DataSource = this.tapuVeriTabaniDataSet16;
            // 
            // tapuVeriTabaniDataSet16
            // 
            this.tapuVeriTabaniDataSet16.DataSetName = "TapuVeriTabaniDataSet16";
            this.tapuVeriTabaniDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(5, 497);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1206, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EV";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1200, 169);
            this.dataGridView2.TabIndex = 0;
            // 
            // evBindingSource
            // 
            this.evBindingSource.DataMember = "Ev";
            this.evBindingSource.DataSource = this.tapuVeriTabaniDataSet17;
            // 
            // tapuVeriTabaniDataSet17
            // 
            this.tapuVeriTabaniDataSet17.DataSetName = "TapuVeriTabaniDataSet17";
            this.tapuVeriTabaniDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arsaTableAdapter
            // 
            this.arsaTableAdapter.ClearBeforeFill = true;
            // 
            // evTableAdapter
            // 
            this.evTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAPORLAToolStripMenuItem,
            this.tAPUARSAToolStripMenuItem,
            this.tAPUEVToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 37);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rAPORLAToolStripMenuItem
            // 
            this.rAPORLAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.kırmızıToolStripMenuItem,
            this.pembeToolStripMenuItem,
            this.sarıToolStripMenuItem,
            this.griToolStripMenuItem});
            this.rAPORLAToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rAPORLAToolStripMenuItem.Name = "rAPORLAToolStripMenuItem";
            this.rAPORLAToolStripMenuItem.Size = new System.Drawing.Size(125, 33);
            this.rAPORLAToolStripMenuItem.Text = "RENKLER";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // pembeToolStripMenuItem
            // 
            this.pembeToolStripMenuItem.Name = "pembeToolStripMenuItem";
            this.pembeToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.pembeToolStripMenuItem.Text = "Pembe";
            this.pembeToolStripMenuItem.Click += new System.EventHandler(this.pembeToolStripMenuItem_Click);
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // tAPUARSAToolStripMenuItem
            // 
            this.tAPUARSAToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAPUARSAToolStripMenuItem.Name = "tAPUARSAToolStripMenuItem";
            this.tAPUARSAToolStripMenuItem.Size = new System.Drawing.Size(154, 33);
            this.tAPUARSAToolStripMenuItem.Text = "TAPU-ARSA";
            this.tAPUARSAToolStripMenuItem.Click += new System.EventHandler(this.tAPUARSAToolStripMenuItem_Click);
            // 
            // tAPUEVToolStripMenuItem
            // 
            this.tAPUEVToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAPUEVToolStripMenuItem.Name = "tAPUEVToolStripMenuItem";
            this.tAPUEVToolStripMenuItem.Size = new System.Drawing.Size(122, 33);
            this.tAPUEVToolStripMenuItem.Text = "TAPU-EV";
            this.tAPUEVToolStripMenuItem.Click += new System.EventHandler(this.tAPUEVToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çIKIŞToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çIKIŞToolStripMenuItem.Image")));
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(101, 33);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // btnRaporArsa
            // 
            this.btnRaporArsa.Location = new System.Drawing.Point(34, 109);
            this.btnRaporArsa.Name = "btnRaporArsa";
            this.btnRaporArsa.Size = new System.Drawing.Size(195, 54);
            this.btnRaporArsa.TabIndex = 10;
            this.btnRaporArsa.Text = "RAPORLA";
            this.btnRaporArsa.UseVisualStyleBackColor = true;
            this.btnRaporArsa.Click += new System.EventHandler(this.btnRaporArsa_Click);
            // 
            // btnRaporEv
            // 
            this.btnRaporEv.Location = new System.Drawing.Point(58, 108);
            this.btnRaporEv.Name = "btnRaporEv";
            this.btnRaporEv.Size = new System.Drawing.Size(176, 55);
            this.btnRaporEv.TabIndex = 11;
            this.btnRaporEv.Text = "RAPORLA";
            this.btnRaporEv.UseVisualStyleBackColor = true;
            this.btnRaporEv.Click += new System.EventHandler(this.btnRaporEv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblArsaSay);
            this.groupBox3.Controls.Add(this.btnRaporArsa);
            this.groupBox3.Location = new System.Drawing.Point(453, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 201);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARSA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRaporEv);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblEvSay);
            this.groupBox4.Location = new System.Drawing.Point(731, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 201);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "EV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(407, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 63);
            this.label4.TabIndex = 14;
            this.label4.Text = "KAYITLI EMLAK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmKayitliEmlak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1239, 713);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKayitliEmlak";
            this.Text = "frmKayitliEmlak";
            this.Load += new System.EventHandler(this.frmKayitliEmlak_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapuVeriTabaniDataSet16)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapuVeriTabaniDataSet17)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblArsaSay;
        private System.Windows.Forms.Label lblEvSay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TapuVeriTabaniDataSet16 tapuVeriTabaniDataSet16;
        private System.Windows.Forms.BindingSource arsaBindingSource;
        private TapuVeriTabaniDataSet16TableAdapters.ArsaTableAdapter arsaTableAdapter;
        private TapuVeriTabaniDataSet17 tapuVeriTabaniDataSet17;
        private System.Windows.Forms.BindingSource evBindingSource;
        private TapuVeriTabaniDataSet17TableAdapters.EvTableAdapter evTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rAPORLAToolStripMenuItem;
        private System.Windows.Forms.Button btnRaporArsa;
        private System.Windows.Forms.Button btnRaporEv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAPUARSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAPUEVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}