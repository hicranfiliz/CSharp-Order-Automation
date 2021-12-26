
namespace Siparis_Otomasyon
{
    partial class FrmMusteriMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSiparisDurunu = new System.Windows.Forms.Button();
            this.btnSepet = new System.Windows.Forms.Button();
            this.btnMagaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mağaza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sepettekiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sipariş Durumu";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button4.Location = new System.Drawing.Point(302, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 27);
            this.button4.TabIndex = 30;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSiparisDurunu
            // 
            this.btnSiparisDurunu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisDurunu.BackgroundImage")));
            this.btnSiparisDurunu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiparisDurunu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisDurunu.Location = new System.Drawing.Point(92, 266);
            this.btnSiparisDurunu.Name = "btnSiparisDurunu";
            this.btnSiparisDurunu.Size = new System.Drawing.Size(133, 143);
            this.btnSiparisDurunu.TabIndex = 4;
            this.btnSiparisDurunu.UseVisualStyleBackColor = true;
            this.btnSiparisDurunu.Click += new System.EventHandler(this.btnSiparisDurunu_Click);
            // 
            // btnSepet
            // 
            this.btnSepet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSepet.BackgroundImage")));
            this.btnSepet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSepet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepet.Location = new System.Drawing.Point(181, 41);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(133, 143);
            this.btnSepet.TabIndex = 2;
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // btnMagaza
            // 
            this.btnMagaza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMagaza.BackgroundImage")));
            this.btnMagaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagaza.Location = new System.Drawing.Point(12, 41);
            this.btnMagaza.Name = "btnMagaza";
            this.btnMagaza.Size = new System.Drawing.Size(133, 143);
            this.btnMagaza.TabIndex = 0;
            this.btnMagaza.UseVisualStyleBackColor = true;
            this.btnMagaza.Click += new System.EventHandler(this.btnMagaza_Click);
            // 
            // FrmMusteriMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(326, 487);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiparisDurunu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMagaza);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMagaza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiparisDurunu;
        private System.Windows.Forms.Button button4;
    }
}