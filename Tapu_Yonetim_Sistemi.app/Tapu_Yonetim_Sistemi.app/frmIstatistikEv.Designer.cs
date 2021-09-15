
namespace Tapu_Yonetim_Sistemi.app
{
    partial class frmIstatistikEv
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEvSay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBalkonsuz = new System.Windows.Forms.Label();
            this.lblBalkonlu = new System.Windows.Forms.Label();
            this.lblEvUcret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Satılan Ev Ücreti :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Satılan Ev Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balkonlu Ev Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balkonsuz Ev Sayısı :";
            // 
            // lblEvSay
            // 
            this.lblEvSay.AutoSize = true;
            this.lblEvSay.Location = new System.Drawing.Point(326, 97);
            this.lblEvSay.Name = "lblEvSay";
            this.lblEvSay.Size = new System.Drawing.Size(25, 29);
            this.lblEvSay.TabIndex = 4;
            this.lblEvSay.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(123, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 63);
            this.label6.TabIndex = 5;
            this.label6.Text = "İSTATİSTİK";
            // 
            // lblBalkonsuz
            // 
            this.lblBalkonsuz.AutoSize = true;
            this.lblBalkonsuz.Location = new System.Drawing.Point(326, 211);
            this.lblBalkonsuz.Name = "lblBalkonsuz";
            this.lblBalkonsuz.Size = new System.Drawing.Size(25, 29);
            this.lblBalkonsuz.TabIndex = 6;
            this.lblBalkonsuz.Text = "0";
            // 
            // lblBalkonlu
            // 
            this.lblBalkonlu.AutoSize = true;
            this.lblBalkonlu.Location = new System.Drawing.Point(326, 173);
            this.lblBalkonlu.Name = "lblBalkonlu";
            this.lblBalkonlu.Size = new System.Drawing.Size(25, 29);
            this.lblBalkonlu.TabIndex = 7;
            this.lblBalkonlu.Text = "0";
            // 
            // lblEvUcret
            // 
            this.lblEvUcret.AutoSize = true;
            this.lblEvUcret.Location = new System.Drawing.Point(326, 135);
            this.lblEvUcret.Name = "lblEvUcret";
            this.lblEvUcret.Size = new System.Drawing.Size(25, 29);
            this.lblEvUcret.TabIndex = 8;
            this.lblEvUcret.Text = "0";
            // 
            // frmIstatistikEv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(492, 325);
            this.Controls.Add(this.lblEvUcret);
            this.Controls.Add(this.lblBalkonlu);
            this.Controls.Add(this.lblBalkonsuz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEvSay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIstatistikEv";
            this.Text = "frmIstatistikEv";
            this.Load += new System.EventHandler(this.frmIstatistikEv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEvSay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBalkonsuz;
        private System.Windows.Forms.Label lblBalkonlu;
        private System.Windows.Forms.Label lblEvUcret;
    }
}