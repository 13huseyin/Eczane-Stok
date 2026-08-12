using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=eczanestok;Integrated Security=True";

        private void VerileriGoruntule()
        {
            try
            {
                using (SqlConnection baglan = new SqlConnection(connectionString))
                {
                    baglan.Open();
                    string query = "SELECT * FROM dbo.ilaclar";
                    using (SqlCommand komut = new SqlCommand(query, baglan))
                    using (SqlDataReader oku = komut.ExecuteReader())
                    {
                        listView1.Items.Clear();
                        while (oku.Read())
                        {

                            int id = Convert.ToInt32(oku["id"]);
                            ListViewItem ekle = new ListViewItem(id.ToString()); ekle.SubItems.Add(oku["ilacad"].ToString());
                            ekle.SubItems.Add(oku["ilacsirketi"].ToString());
                            ekle.SubItems.Add(oku["ilacturu"].ToString());
                            ekle.SubItems.Add(oku["ilackutuadedi"].ToString());
                            listView1.Items.Add(ekle);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoruntule();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglan = new SqlConnection(connectionString))
                {
                    baglan.Open();

                    string sorgu = "INSERT INTO dbo.ilaclar (id, ilacad, ilacsirketi, ilacturu, ilackutuadedi) " +
                                   "VALUES (@id, @ilacad, @ilacsirketi, @ilacturu, @ilackutuadedi)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglan))
                    {
                        {
                            if (int.TryParse(textBox1.Text, out int id))
                            {
                                komut.Parameters.AddWithValue("@id", id);
                            }
                            else
                            {
                                MessageBox.Show("ID deðeri yalnýzca sayýsal olmalýdýr.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            komut.Parameters.AddWithValue("@ilacad", textBox2.Text);
                            komut.Parameters.AddWithValue("@ilacsirketi", textBox3.Text);
                            komut.Parameters.AddWithValue("@ilacturu", textBox4.Text);
                            komut.Parameters.AddWithValue("@ilackutuadedi", textBox5.Text);


                            int kaydedilensatýr = komut.ExecuteNonQuery();
                        }
                    }


                    VerileriGoruntule();

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "HAta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                using (SqlConnection baglan = new SqlConnection(connectionString))
                {
                    try
                    {
                        baglan.Open();
                        SqlCommand komut = new SqlCommand("DELETE FROM dbo.ilaclar WHERE id = @id", baglan);
                        komut.Parameters.AddWithValue("@id", id);
                        int satirSayisi = komut.ExecuteNonQuery();

                        if (satirSayisi > 0)
                        {
                            MessageBox.Show("Silme iþlemi baþarýlý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Girilen ID'ye sahip bir kayýt bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        VerileriGoruntule();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (baglan.State == ConnectionState.Open)
                            baglan.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        
        {

            if (int.TryParse(textBox1.Text, out int id))
            {
                using (SqlConnection baglan = new SqlConnection(connectionString))
                {
                    try
                    {
                        baglan.Open();

                        string sorgu = "UPDATE dbo.ilaclar " +
                                       "SET ilacad = @ilacad, ilacsirketi = @ilacsirketi, ilacturu = @ilacturu, ilackutuadedi = @ilackutuadedi " +
                                       "WHERE id = @id";

                        using (SqlCommand komut = new SqlCommand(sorgu, baglan))
                        {
                            komut.Parameters.AddWithValue("@id", id);
                            komut.Parameters.AddWithValue("@ilacad", textBox2.Text);
                            komut.Parameters.AddWithValue("@ilacsirketi", textBox3.Text);
                            komut.Parameters.AddWithValue("@ilacturu", textBox4.Text);
                            komut.Parameters.AddWithValue("@ilackutuadedi", textBox5.Text);

                            int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                            if (etkilenenSatirSayisi > 0)
                            {
                                MessageBox.Show("Kayýt baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                VerileriGoruntule(); 
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme baþarýsýz oldu. ID'yi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        

          

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                textBox1.Text = id.ToString(); textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox5.Text = listView1.SelectedItems[0].SubItems[0].Text;




            }
        }

       
    }
}