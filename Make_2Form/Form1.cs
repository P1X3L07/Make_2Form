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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int indexInputArray = 0;
        public static int indexArray = 10;
        public static string[] Nama = new string[indexArray];
        public static string[] Alamat = new string[indexArray];
        public static string[] Telp = new string[indexArray];
        

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            indexInputArray = indexInputArray + 1;
            Nama[indexInputArray - 1] = TxtBoxNama.Text;
            Alamat[indexInputArray - 1] = TxtBoxAlamat.Text;
            Telp[indexInputArray - 1] = TxtBoxTelp.Text;
            TxtBoxNama.Clear();
            TxtBoxAlamat.Clear();
            TxtBoxTelp.Clear();
            if(indexInputArray> 10)
            {
                MessageBox.Show("Data Penuh");
            }


        }

        private void TxtBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLihatData_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}
