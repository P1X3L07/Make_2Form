
namespace Make_2Form
{
    partial class Form2
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
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.AlamatTxtBox = new System.Windows.Forms.TextBox();
            this.TelpTxtBox = new System.Windows.Forms.TextBox();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnPrevData = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Enabled = false;
            this.NameTxtBox.Location = new System.Drawing.Point(213, 91);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(242, 26);
            this.NameTxtBox.TabIndex = 3;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NamaTxtBox_TextChanged);
            // 
            // AlamatTxtBox
            // 
            this.AlamatTxtBox.Enabled = false;
            this.AlamatTxtBox.Location = new System.Drawing.Point(213, 145);
            this.AlamatTxtBox.Name = "AlamatTxtBox";
            this.AlamatTxtBox.Size = new System.Drawing.Size(242, 26);
            this.AlamatTxtBox.TabIndex = 4;
            // 
            // TelpTxtBox
            // 
            this.TelpTxtBox.Enabled = false;
            this.TelpTxtBox.Location = new System.Drawing.Point(213, 200);
            this.TelpTxtBox.Name = "TelpTxtBox";
            this.TelpTxtBox.Size = new System.Drawing.Size(242, 26);
            this.TelpTxtBox.TabIndex = 5;
            this.TelpTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelpTxtBox_KeyPress);
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(107, 284);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(81, 33);
            this.BtnKembali.TabIndex = 6;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // BtnPrevData
            // 
            this.BtnPrevData.Location = new System.Drawing.Point(232, 283);
            this.BtnPrevData.Name = "BtnPrevData";
            this.BtnPrevData.Size = new System.Drawing.Size(97, 34);
            this.BtnPrevData.TabIndex = 7;
            this.BtnPrevData.Text = "Prev Data";
            this.BtnPrevData.UseVisualStyleBackColor = true;
            this.BtnPrevData.Click += new System.EventHandler(this.BtnPrevData_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(377, 284);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(78, 33);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next Data";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevData);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.TelpTxtBox);
            this.Controls.Add(this.AlamatTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox AlamatTxtBox;
        private System.Windows.Forms.TextBox TelpTxtBox;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnPrevData;
        private System.Windows.Forms.Button BtnNext;
    }
}