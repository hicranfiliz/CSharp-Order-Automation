
namespace Siparis_Otomasyon
{
    partial class FrmMusteriGor
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
            this.dataGridViewmusterigor = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusterigor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmusterigor
            // 
            this.dataGridViewmusterigor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.dataGridViewmusterigor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewmusterigor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmusterigor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.dataGridViewmusterigor.Location = new System.Drawing.Point(0, 23);
            this.dataGridViewmusterigor.Name = "dataGridViewmusterigor";
            this.dataGridViewmusterigor.Size = new System.Drawing.Size(326, 462);
            this.dataGridViewmusterigor.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button4.Location = new System.Drawing.Point(302, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 27);
            this.button4.TabIndex = 31;
            this.button4.Text = "x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmMusteriGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(326, 487);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewmusterigor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMusteriGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMusteriGor";
            this.Load += new System.EventHandler(this.FrmMusteriGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmusterigor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmusterigor;
        private System.Windows.Forms.Button button4;
    }
}