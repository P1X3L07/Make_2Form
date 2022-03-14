
namespace Make_2Form
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
            this.LblNama = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblTelp = new System.Windows.Forms.Label();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.TxtBoxNama = new System.Windows.Forms.TextBox();
            this.TxtBoxAlamat = new System.Windows.Forms.TextBox();
            this.TxtBoxTelp = new System.Windows.Forms.TextBox();
            this.BtnLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(58, 57);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(59, 20);
            this.LblNama.TabIndex = 0;
            this.LblNama.Text = "Nama: ";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(58, 119);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(67, 20);
            this.LblAlamat.TabIndex = 1;
            this.LblAlamat.Text = "Alamat: ";
            // 
            // LblTelp
            // 
            this.LblTelp.AutoSize = true;
            this.LblTelp.Location = new System.Drawing.Point(74, 178);
            this.LblTelp.Name = "LblTelp";
            this.LblTelp.Size = new System.Drawing.Size(43, 20);
            this.LblTelp.TabIndex = 2;
            this.LblTelp.Text = "Telp:";
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(131, 242);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(85, 30);
            this.BtnSimpan.TabIndex = 3;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // TxtBoxNama
            // 
            this.TxtBoxNama.Location = new System.Drawing.Point(131, 57);
            this.TxtBoxNama.Name = "TxtBoxNama";
            this.TxtBoxNama.Size = new System.Drawing.Size(223, 26);
            this.TxtBoxNama.TabIndex = 4;
            this.TxtBoxNama.TextChanged += new System.EventHandler(this.TxtBoxNama_TextChanged);
            // 
            // TxtBoxAlamat
            // 
            this.TxtBoxAlamat.Location = new System.Drawing.Point(131, 113);
            this.TxtBoxAlamat.Name = "TxtBoxAlamat";
            this.TxtBoxAlamat.Size = new System.Drawing.Size(223, 26);
            this.TxtBoxAlamat.TabIndex = 5;
            // 
            // TxtBoxTelp
            // 
            this.TxtBoxTelp.Location = new System.Drawing.Point(131, 172);
            this.TxtBoxTelp.Name = "TxtBoxTelp";
            this.TxtBoxTelp.Size = new System.Drawing.Size(223, 26);
            this.TxtBoxTelp.TabIndex = 6;
            // 
            // BtnLihatData
            // 
            this.BtnLihatData.Location = new System.Drawing.Point(248, 242);
            this.BtnLihatData.Name = "BtnLihatData";
            this.BtnLihatData.Size = new System.Drawing.Size(106, 30);
            this.BtnLihatData.TabIndex = 7;
            this.BtnLihatData.Text = "Lihat Data";
            this.BtnLihatData.UseVisualStyleBackColor = true;
            this.BtnLihatData.Click += new System.EventHandler(this.BtnLihatData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 357);
            this.Controls.Add(this.BtnLihatData);
            this.Controls.Add(this.TxtBoxTelp);
            this.Controls.Add(this.TxtBoxAlamat);
            this.Controls.Add(this.TxtBoxNama);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.LblTelp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.Label LblTelp;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.TextBox TxtBoxNama;
        private System.Windows.Forms.TextBox TxtBoxAlamat;
        private System.Windows.Forms.TextBox TxtBoxTelp;
        private System.Windows.Forms.Button BtnLihatData;
    }
}

