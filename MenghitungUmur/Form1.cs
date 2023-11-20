using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MenghitungUmur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //menentukan hari lahir
            var tgl = dateTimePicker2.Text.ToString();
            String[] hari = tgl.Split(',');
            textBox1.Text = hari[0];
            
            //split tanggal saat ini
            var dtSaatIni = dateTimePicker1.Value.ToString();
            String[] splitTglSaatini = dtSaatIni.Split('/', ' ');
            var tglSaatIni = int.Parse(splitTglSaatini[0]);
            var bulanSaatIni = int.Parse(splitTglSaatini[1]);
            var tahunSaatini = int.Parse(splitTglSaatini[2]);

            //split tanggal lahir
            var dtTglLahir = dateTimePicker2.Value.ToString();
            String[] splitTglLahir = dtTglLahir.Split('/', ' ');
            var tglLahir = int.Parse(splitTglLahir[0]);
            var bulanLahir = int.Parse(splitTglLahir[1]);
            var tahunLahir = int.Parse(splitTglLahir[2]);

            //menghitung umur
            int hasilTanggal = tglSaatIni - tglLahir;
            int hasilTanggal2 = tglLahir - tglSaatIni;
            int hasilBulan = bulanSaatIni - bulanLahir;
            int hasilTahun = tahunSaatini - tahunLahir;
            int cekBulan;

            if (bulanSaatIni < bulanLahir)
            {
                hasilTahun = hasilTahun - 1;
                cekBulan = 12 - bulanLahir + bulanSaatIni;
            }
            if ((tahunSaatini > tglLahir) && (tglSaatIni >= tglLahir) && (bulanSaatIni >= bulanLahir))
            {
                tbUmurTahun.Text = hasilTahun.ToString();
                tbUmurBulan.Text = hasilBulan.ToString();
                tbUmurHari.Text = hasilTanggal.ToString();
            }
            else if ((tahunSaatini > tglLahir) && (tglSaatIni <= tglLahir) && (bulanSaatIni <= bulanLahir)) 
            {
                cekBulan = 12 - bulanLahir + bulanSaatIni;
                tbUmurTahun.Text = hasilTahun.ToString();
                tbUmurBulan.Text = cekBulan.ToString();
                tbUmurHari.Text = hasilTanggal2.ToString();
            }
            else if ((tahunSaatini > tglLahir) && (tglSaatIni >= tglLahir) && (bulanSaatIni <= bulanLahir))
            {
                cekBulan = 12 - bulanLahir + bulanSaatIni;
                tbUmurTahun.Text = hasilTahun.ToString();
                tbUmurBulan.Text = cekBulan.ToString();
                tbUmurHari.Text = hasilTanggal.ToString();
            }
            else if ((tahunSaatini > tglLahir) && (tglSaatIni <= tglLahir) && (bulanSaatIni >= bulanLahir))
            {
                //cekBulan = 12 - bulanLahir + bulanSaatIni;
                tbUmurTahun.Text = hasilTahun.ToString();
                tbUmurBulan.Text = hasilBulan.ToString();
                tbUmurHari.Text = hasilTanggal2.ToString();
            }
            
            //textBox2.Text = tglSaatIni.ToString()+ " " +bulanSaatIni.ToString()+ " " +tahunSaatini.ToString();
            //textBox2.Text = tglLahir.ToString() + " " + bulanLahir.ToString() + " " + tahunLahir.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy";
            dateTimePicker2.CustomFormat = "dddd, dd MMMM yyyy";
        }
        
    }
}
