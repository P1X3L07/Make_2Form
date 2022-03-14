using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_2Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int counter = 0;

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }

        private void BtnPrevData_Click(object sender, EventArgs e)
        {
            counter = counter - 1;
            if (counter < 0 )
            {
                counter = counter + 1;
                MessageBox.Show("“Data sudah data pertama");
            }
            NameTxtBox.Text = Form1.Nama[counter];
            AlamatTxtBox.Text = Form1.Alamat[counter];
            TelpTxtBox.Text = Form1.Telp[counter];
        }

        private void NamaTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NameTxtBox.Text = Form1.Nama[counter];
            AlamatTxtBox.Text = Form1.Alamat[counter];
            TelpTxtBox.Text = Form1.Telp[counter];
        }

        private void TelpTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            if (counter >= 10)
            {
                MessageBox.Show("Ini Data terakhir :D");
            }
            if (counter > Form1.indexInputArray - 1)
            {
                counter = counter - 1;
                MessageBox.Show("Ini Data terakhir :D");
            }
            NameTxtBox.Text = Form1.Nama[counter];
            AlamatTxtBox.Text = Form1.Alamat[counter];
            TelpTxtBox.Text = Form1.Telp[counter];
        }
    }
}
