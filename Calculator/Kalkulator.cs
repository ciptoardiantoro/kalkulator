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
    public partial class Kalkulator : Form
    {
        public delegate void Penghubung(int operasi, int a, int b, int c, int Hasil);
        public event Penghubung penghubung;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void ProsesNilai_Click(object sender, EventArgs e)
        {
            string operasi = OperasiPilihan.SelectedItem.ToString();
            int a = Convert.ToInt32(NilaiA.Text);
            int b = Convert.ToInt32(NilaiB.Text);
            int hasil = 0;

            switch (OperasiPilihan.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;

                default:
                    hasil = 0;
                    break;
            }
            this.Penghubung(OperasiPilihan.SelectedIndex, a, b, hasil);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
