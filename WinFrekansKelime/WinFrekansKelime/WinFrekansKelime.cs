using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFrekansKelime
{
    public partial class WinFrekansKelime : Form
    {
        public WinFrekansKelime()
        {
            InitializeComponent();
        }
        private char[] gelenKarakterVeriler,gelenKarakterVerilerSonHali,gelenKarakterSon;
        private int[] boslukKarakterDurumu;
        private int boslukSay=0,index=0,tamIndex=0,gelenKarakterFarkSay=0;
        private void WinFrekansKelime_Load(object sender, EventArgs e)
        {
            cbDurumSec.SelectedIndex = 0;
            dgvDataGridViewAyarlama();
        }

        private void dgvDataGridViewAyarlama() 
        {
         dGV.Columns.Add("KARAKTER","KARAKTER");
         dGV.Columns.Add("FREKANS","FREKANS");
         dGV.Columns.Add("YÜZDE","YÜZDE");

        }
        private void temizle()
        {
            dGV.Rows.Clear();
            txtFrekansDosyasi.Text = "";
        }
        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            index = 0;
            gelenKarakterVeriler = txtFrekansDosyasi.Text.ToLower().ToCharArray();
            for (int i = 0; i < gelenKarakterVeriler.Length; i++)
            {
                if (gelenKarakterVeriler[i] == ' ')
                    boslukSay++;
            }
            boslukKarakterDurumu = new int[boslukSay];
            for (int i = 0; i < gelenKarakterVeriler.Length; i++)
            {
                if (gelenKarakterVeriler[i] == ' ')
                {
                    boslukKarakterDurumu[index] = i;
                    index++;
                }
            }
            gelenKarakterVerilerSonHali = new char[gelenKarakterVeriler.Length - boslukSay];
            for (int i = 0; i < gelenKarakterVeriler.Length; i++)
            {
                if (gelenKarakterVeriler[i] != ' ')
                {
                    gelenKarakterVerilerSonHali[tamIndex] = gelenKarakterVeriler[i];
                    tamIndex++;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////

            gelenKarakterSon = new char[gelenKarakterVerilerSonHali.Length];

            gelenKarakterSon[0] = gelenKarakterVerilerSonHali[0];
            for (int i = 1; i < gelenKarakterVerilerSonHali.Length; i++)
            {
                char gelen = karakterEkleme(gelenKarakterVerilerSonHali[i], i);
                if (gelen != ' ')
                    gelenKarakterSon[i] = gelen;
            }

            ////////////////////////////////////////////////////////////////////////////////////////

            int iYer=0;
            for (int i = 0; i < gelenKarakterSon.Length; i++)
            {
                if (gelenKarakterSon[i] != '\0' && gelenKarakterSon[i] != '\n') 
                {
                    dGV.Rows.Add();
                    dGV[0, iYer].Value = gelenKarakterSon[i];
                    iYer++;
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            int sayac = 0;
            for (int i = 0; i < gelenKarakterSon.Length; i++)
            {
                if (gelenKarakterSon[i] == '\0' || gelenKarakterSon[i] == '\n')
                    sayac++;
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            int karakterSayac=0;
            char[] karakterAnaliz=new char[gelenKarakterSon.Length-sayac];
            int[] karakterSayaci=new int[gelenKarakterSon.Length-sayac];
            for (int i = 0; i < gelenKarakterSon.Length; i++)
            {
                if (gelenKarakterSon[i] != '\0' && gelenKarakterSon[i] != '\n')
                {
                    karakterAnaliz[karakterSayac] = gelenKarakterSon[i];
                    karakterSayac++;
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            iYer = 0;
            int karakterTutucu = 0;
            gelenKarakterFarkSay = 0;

            for (int i = karakterTutucu; i < karakterAnaliz.Length; i++)
            {
                for (int j = 0; j < gelenKarakterVerilerSonHali.Length; j++)
                {
                    if (karakterAnaliz[i] == gelenKarakterVerilerSonHali[j])
                        gelenKarakterFarkSay++;
                }
                karakterSayaci[iYer] = gelenKarakterFarkSay;
                karakterTutucu++;
                iYer++;
                gelenKarakterFarkSay = 0;
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < dGV.Rows.Count - 1; i++)
                dGV[1, i].Value = karakterSayaci[i];

            ///////////////////////////////////////////////////////////////////////////////////////

            double toplam = 0;
            for (int i = 0; i < dGV.Rows.Count-1; i++)
            {
                toplam += Convert.ToDouble(dGV[1,i].Value);
            }

            double yuzdeOrani = 0;
            double oran=0;
            for (int i = 0; i < dGV.Rows.Count - 1; i++)
            {
                double gelenDeger=Convert.ToDouble(dGV[1,i].Value.ToString());
                oran=(gelenDeger*100)/toplam;
                yuzdeOrani = Convert.ToDouble(oran);
                dGV[2, i].Value = "%"+Math.Round(yuzdeOrani,2);
            }
         

            ///////////////////////////////////////////////////////////////////////////////////////

        }

        private char karakterEkleme(char p, int index)
        {
            bool farkDurum = true;
            for (int i = 0; i < gelenKarakterSon.Length; i++)
            {

                if (gelenKarakterSon[i] == p)
                {
                    farkDurum = false;
                    break;
                }
                else
                    farkDurum = true;

            }
            if (farkDurum)
                return p;
            else
                return ' ';
        }

        private void btnDosyadan_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Title = "KELİME FREKANS İŞLEMİNİ AÇIN";
            opn.Multiselect = false;
            opn.AddExtension = true;
            opn.Filter ="Metin Dosyası(*.txt)|*.txt|Word Dosyası|*.doc| KralMachine(*.docx)|*.docx";
            opn.FilterIndex = 1;
            opn.InitialDirectory = Environment.CommandLine;
            if (opn.ShowDialog() == DialogResult.OK) 
            {
                StreamReader sr = new StreamReader(opn.FileName);
                txtFrekansDosyasi.Text = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
        }
    }
}
