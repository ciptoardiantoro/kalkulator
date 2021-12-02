using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Hasil : Form
    {
        public Hasil()
        {
            InitializeComponent();
        }

        private void Ketik(int operasi, int a, int b, int c, int hasil)
        {
            char[] operasi_simbol = { '+', '-', '*', '/' };
            string[] operasi_incor = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            lvwHasilAkhir.Items.Add( $"Hasil {(operasi_incor[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}" );
         }

        private void button1_Click(object sender, EventArgs e)
        {
            Kalkulator hitung = new Kalkulator();
            hitung.penghubung += Ketik;
            hitung.ShowDialog();

        }

        private void HasilAkhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
