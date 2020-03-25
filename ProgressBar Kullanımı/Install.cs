using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_Kullanımı
{
    public partial class Install : Form
    {
        public Install()
        {
            InitializeComponent();
        }

        private void Install_Load(object sender, EventArgs e)
        {
            timer1.Interval = 700;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            label1.Text = "Kurulum Dosyaları Çıkartılıyor...%"+progressBar1.Value;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value +=  10;

            if (progressBar1.Value<=30)
            {
                label1.Text = "Kurulum Dosyaları Çıkartılıyor...%" + progressBar1.Value;
            }

            else if (progressBar1.Value<=80)
            {
                label1.Text = "Program Dosyaları Kuruluyor...%" + progressBar1.Value;
            }

            else
            {
                label1.Text = "Program Kurulumu 1 Kaç Saniye İçinde Tamamlanacak...%" + progressBar1.Value;
            }

            if (progressBar1.Value==100)
            {
                label1.Text = "Kurulum Tamamlandı...%" + progressBar1.Value;

                timer1.Stop();

               DialogResult Sonuc = new DialogResult();

               Sonuc = MessageBox.Show("Kurulumunuz Başarılı Şekilde Tamamlandı. Kurulumu Kapatmak İstiyor musunuz?","Kurulum",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Information);

                if (Sonuc==DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }
    }
}
