using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class BransFormu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-53E410H\\PCSQLSERVER;Initial Catalog=Randevu;Integrated Security=True");
        DateTime d=DateTime.Now;
        public BransFormu()
        {
            InitializeComponent();
        }

        private void emirinamk(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text = btn.Text;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void BransFormu_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT*FROM BosDolu", baglanti);
            SqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                label1.Text = reader["bos1"] + " Bos".ToString();
                label2.Text = reader["dolu1"] + " Dolu".ToString();
                label4.Text = reader["bos2"] + " Bos".ToString();
                label3.Text = reader["dolu2"] + " Dolu".ToString();
                label6.Text = reader["bos3"] + " Bos".ToString();
                label5.Text = reader["dolu3"] + " Dolu".ToString();
                label8.Text = reader["bos4"] + " Bos".ToString();
                label7.Text = reader["dolu4"] + " Dolu".ToString();
                label10.Text = reader["bos5"] + " Bos".ToString();
                label9.Text = reader["dolu5"] + " Dolu".ToString();
                label12.Text = reader["bos6"] + " Bos".ToString();
                label11.Text = reader["dolu6"] + " Dolu".ToString();
                label14.Text = reader["bos7"] + " Bos".ToString();
                label13.Text = reader["dolu7"] + " Dolu".ToString();
                label16.Text = reader["bos8"] + " Bos".ToString();
                label15.Text = reader["dolu8"] + " Dolu".ToString();
                label18.Text = reader["bos9"] + " Bos".ToString();
                label17.Text = reader["dolu9"] + " Dolu".ToString();
                label20.Text = reader["bos10"] + " Bos".ToString();
                label19.Text = reader["dolu10"] + " Dolu".ToString();
                label22.Text = reader["bos11"] + " Bos".ToString();
                label21.Text = reader["dolu11"] + " Dolu".ToString();
                label24.Text = reader["bos12"] + " Bos".ToString();
                label23.Text = reader["dolu12"] + " Dolu".ToString();
                label26.Text = reader["bos13"] + " Bos".ToString();
                label25.Text = reader["dolu13"] + " Dolu".ToString();
                label28.Text = reader["bos14"] + " Bos".ToString();
                label27.Text = reader["dolu14"] + " Dolu".ToString();
                label30.Text = reader["bos15"] + " Bos".ToString();
                label29.Text = reader["dolu15"]+" Dolu".ToString();
            }
            baglanti.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OnayFormu onay=new OnayFormu();
            if (textBox1.Text != null && dateTimePicker1.Value > d)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO HastaBilgileri(Tc,AdSoyad,TelNo,DTarih,Brans,RTarih) VALUES(@Tc,@AdSoyad,@TelNo,@DTarih,@Brans,@RTarih)", baglanti);
                cmd.Parameters.Add("@Tc", SqlDbType.NVarChar).Value = Form1.tc;
                cmd.Parameters.Add("@AdSoyad", SqlDbType.NVarChar).Value = Form1.adsoyad;
                cmd.Parameters.Add("@TelNo", SqlDbType.NVarChar).Value = Form1.tel;
                cmd.Parameters.Add("@DTarih", SqlDbType.DateTime).Value = Form1.dtarih;
                cmd.Parameters.Add("@Brans", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("@RTarih", SqlDbType.DateTime).Value = dateTimePicker1.Value.ToShortDateString();
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yönlendiriliyorsunuz...");
                if (textBox1.Text == "Beyin ve Sinir Cerrahisi")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos1=bos1-1,dolu1=dolu1+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos1,dolu1 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label1.Text = reader["bos1"].ToString();
                        label2.Text = reader["dolu1"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Kardiyoloji")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos2=bos2-1,dolu2=dolu2+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos2,dolu2 FROM BosDolu",baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    baglanti.Open();
                    while (reader.Read())
                    {
                        label4.Text = reader["bos2"].ToString();
                        label3.Text = reader["dolu2"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Nöroloji")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos3=bos3-1,dolu3=dolu3+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos3,dolu3 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label6.Text = reader["bos3"].ToString();
                        label5.Text = reader["dolu3"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Psikiyatri")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos4=bos4-1,dolu4=dolu4+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos4,dolu4 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label8.Text = reader["bos4"].ToString();
                        label7.Text = reader["dolu4"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "İç Hastalıkları")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos5=bos5-1,dolu5=dolu5+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos5,dolu5 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label10.Text = reader["bos5"].ToString();
                        label9.Text = reader["dolu5"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Göz Hastalıkları")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos6=bos6-1,dolu6=dolu6+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos6,dolu6 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label12.Text = reader["bos6"].ToString();
                        label11.Text = reader["dolu6"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "KBB")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos7=bos7-1,dolu7=dolu7+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos7,dolu7 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label14.Text = reader["bos7"].ToString();
                        label13.Text = reader["dolu7"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Göğüs Hastalıkları")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos8=bos8-1,dolu8=dolu8+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos8,dolu8 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label16.Text = reader["bos8"].ToString();
                        label15.Text = reader["dolu8"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Kalp Damar Hastalıkları")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos9=bos9-1,dolu9=dolu9+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos9,dolu9 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label18.Text = reader["bos9"].ToString();
                        label17.Text = reader["dolu9"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Gastroenteroloji")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos10=bos10-1,dolu10=dolu10+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos10,dolu10 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label20.Text = reader["bos10"].ToString();
                        label19.Text = reader["dolu10"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Plastik ve Estetik Cerrahi")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos11=bos11-1,dolu11=dolu11+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos11,dolu11 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label22.Text = reader["bos11"].ToString();
                        label21.Text = reader["dolu11"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Dermotoloji")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos12=bos12-1,dolu12=dolu12+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos12,dolu12 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label24.Text = reader["bos12"].ToString();
                        label23.Text = reader["dolu12"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Kadın Hastalıkları Ve Doğum")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos13=bos13-1,dolu13=dolu13+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos13,dolu13 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label26.Text = reader["bos13"].ToString();
                        label25.Text = reader["dolu13"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Ortopedi Ve Travma")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos14=bos14-1,dolu14=dolu14+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos14,dolu14 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label28.Text = reader["bos14"].ToString();
                        label27.Text = reader["dolu14"].ToString();
                    }
                    baglanti.Close();
                }
                if (textBox1.Text == "Fiziksel Tıp ve Rehabilitasyon")
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE BosDolu  SET bos15=bos15-1,dolu15=dolu15+1 WHERE bosdoluID=" + 1 + "", baglanti);
                    baglanti.Open();
                    cmd2.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd3 = new SqlCommand("SELECT bos15,dolu15 FROM BosDolu", baglanti);
                    SqlDataReader reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        label30.Text = reader["bos15"].ToString();
                        label29.Text = reader["dolu15"].ToString();
                    }
                    baglanti.Close();
                }
                
                onay.Show();
                this.Hide();
                textBox1.Text = null;

            }
            else
                MessageBox.Show("Geçmiş bir tarihe randevu alınamaz");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
