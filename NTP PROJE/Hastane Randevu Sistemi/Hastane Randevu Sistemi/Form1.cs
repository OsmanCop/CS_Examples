using System.Data;
using System.Data.SqlClient;
namespace Hastane_Randevu_Sistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-53E410H\\PCSQLSERVER;Initial Catalog=Randevu;Integrated Security=True");
        public static string adsoyad, tc, tel;
        public  static DateTime dtarih = new DateTime();
        public static DateTime dtarih2 =DateTime.Now;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BransFormu b=new BransFormu();
            if (textBox1.Text != "" &&textBox1.Text.Length==11&& textBox2.Text !="" && textBox1.Text.Length == 11 && textBox4.Text !=""&&dateTimePicker1.Value<dtarih2)
            {
                dtarih = dateTimePicker1.Value;
                adsoyad = textBox2.Text;
                tc = textBox1.Text;
                tel = textBox4.Text;
                textBox1.Text = null;
                textBox2.Text = null;
                textBox4.Text = null;
                this.Hide();
                b.Show();
            }
            else
                MessageBox.Show("HATALI VERÝ GÝRÝÞÝ");
        }
    }
}