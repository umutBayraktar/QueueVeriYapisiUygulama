using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152802029_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BasitKuyruk  degerlerKuyrugu = new BasitKuyruk(20);
        BasitKuyruk degerlerKuyrugu2 = new BasitKuyruk(20);
        Random r = new Random();
        private void btnNormal_Click(object sender, EventArgs e)
        {
            BasitKuyruk basitK = new BasitKuyruk(20);
            int i,j;
            float OrtalamaTamamlanmaSuresi;
            for (i = 0; i < 20; i++)
            {
                Musteri temp = new Musteri(i+1);                
                temp.BeklemeSuresi = r.Next(60, 600);
                basitK.Insert(temp);
                degerlerKuyrugu.Insert(temp);
                degerlerKuyrugu2.Insert(temp);// değerlere ulaşmak için 
            }// müşterileri kuyruğa ekleme işlemi
            string beklemeSureleri = "";
            int siradaKalmaSuresi = 0;
            for (j = 0; j < 20; j++)
            {               
                Musteri temp = basitK.Remove();
                siradaKalmaSuresi += temp.BeklemeSuresi;
                beklemeSureleri += "Müşteri No: "+ temp.MusteriNo+ Environment.NewLine +
                                   "Bekleme Süresi: " + temp.BeklemeSuresi +
                                   "  Kuyrukta Kalma Süresi: " + siradaKalmaSuresi + Environment.NewLine;

            }
            OrtalamaTamamlanmaSuresi = siradaKalmaSuresi / 20;
            lblOrtalamaNOrmal.Text=  "Ortalama: "+OrtalamaTamamlanmaSuresi.ToString();
            MessageBox.Show(beklemeSureleri);
        }

        private void btnAz_Click(object sender, EventArgs e)
        {
            AzOncelikliKuyruk A_O_Kuyruk = new AzOncelikliKuyruk(20);
            float OrtalamaTamamlanmaSuresi;
            while (!degerlerKuyrugu.IsEmpty())
            {
                A_O_Kuyruk.Insert(degerlerKuyrugu.Remove());
            }
            string beklemeSureleri = "";
            int i,siradaKalmaSureleri = 0;
            string avantajlilar = "a-Avantaj Kazanan Müşteriler"+Environment.NewLine;
           for(i=1;i<=20;i++)
            {
                Musteri temp = A_O_Kuyruk.Remove();
                if (temp.MusteriNo > i)
                {
                    avantajlilar += "" + temp.MusteriNo + "Nolu Müşteri" + Environment.NewLine;
                }
                siradaKalmaSureleri += temp.BeklemeSuresi;
                beklemeSureleri += "Müşteri No:" + temp.MusteriNo + Environment.NewLine +
                                   "Bekleme Süresi: " + temp.BeklemeSuresi + 
                                   "  Kuyrukta Kalma Süresi" + siradaKalmaSureleri + Environment.NewLine;
            }
            OrtalamaTamamlanmaSuresi = siradaKalmaSureleri / 20;
            lblOrtalamaAz.Text =  "Ortalama:"+OrtalamaTamamlanmaSuresi.ToString();
            MessageBox.Show(beklemeSureleri);
            MessageBox.Show(avantajlilar);
        }

        private void btnCok_Click(object sender, EventArgs e)
        {
            CokOncelikKuyruk C_O_Kuyruk = new CokOncelikKuyruk(20);
            float OrtalamaTamamlanmaSuresi;
            while (!degerlerKuyrugu2.IsEmpty())
            {
                C_O_Kuyruk.Insert(degerlerKuyrugu2.Remove());
            }
            string beklemeSureleri = "";
            int  i,siradaKalmaSureleri = 0;
            string avantajlilar = "Avantaj Kazanan Müşteriler"+Environment.NewLine;
            for(i=1;i<=20;i++)
            {
                Musteri temp = C_O_Kuyruk.Remove();
                if (temp.MusteriNo > i)
                {
                    avantajlilar += "" + temp.MusteriNo + "Nolu Müşteri" + Environment.NewLine;
                }
                siradaKalmaSureleri += temp.BeklemeSuresi;
                beklemeSureleri += "Müşteri No:" + temp.MusteriNo + Environment.NewLine +
                                   "Bekleme Süresi: "+temp.BeklemeSuresi+
                                   "  Kuyrukta Kalma Süresi" + siradaKalmaSureleri + Environment.NewLine;
            }
            OrtalamaTamamlanmaSuresi = siradaKalmaSureleri / 20;
            lblOrtalamaCok.Text = "Ortalama:"+ OrtalamaTamamlanmaSuresi.ToString();
            MessageBox.Show(beklemeSureleri);
            MessageBox.Show(avantajlilar);
        }
    }
}
