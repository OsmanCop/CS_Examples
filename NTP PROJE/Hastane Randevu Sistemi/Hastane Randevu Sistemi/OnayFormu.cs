using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class OnayFormu : Form
    {
        public string tel;
        public OnayFormu()
        {
            InitializeComponent();
        }

        private void OnayFormu_Load(object sender, EventArgs e)
        {
            label1.Text ="Sonu " +Form1.tel[7].ToString() + Form1.tel[8].ToString()+Form1.tel[9].ToString()+Form1.tel[10].ToString()+" olan telefon numarası sizinmi?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaydınız başarıyla gerçekleşti");
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar randevu almayı deneyin");
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
