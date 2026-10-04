using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=localhost;Database=TaksiDuragiDB;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();

            buttonTaksiEkle.Click += buttonTaksiEkle_Click;
            buttonSeferEkle.Click += buttonSeferEkle_Click;

            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            listBoxSira.Items.Clear();
            listBoxSira.Items.Add("Sıra\tPlaka\t\tToplam Mesafe");
            listBoxSira.Items.Add("------------------------------------------------");

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Plaka, ToplamMesafe FROM Taksiler ORDER BY ToplamMesafe ASC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int sira = 1;
                    while (reader.Read())
                    {
                        string plaka = reader["Plaka"].ToString();
                        double mesafe = Convert.ToDouble(reader["ToplamMesafe"]);

                        listBoxSira.Items.Add($"{sira}\t{plaka}\t\t{mesafe} km");
                        sira++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTaksiEkle_Click(object sender, EventArgs e)
        {
            string plaka = textBoxPlaka.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Lütfen boş bir plaka girmeyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Taksiler (Plaka, ToplamMesafe) VALUES (@plaka, 0)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@plaka", plaka);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{plaka} plakalı taksi durağa eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPlaka.Clear();
                    ListeyiGuncelle();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Bu plaka zaten durakta kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSeferEkle_Click(object sender, EventArgs e)
        {
            string plaka = textBoxPlaka.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(plaka))
            {
                MessageBox.Show("Lütfen önce işlem yapılacak plakayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(textBoxMesafe.Text, out double mesafe) && mesafe >= 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Taksiler SET ToplamMesafe = ToplamMesafe + @mesafe WHERE Plaka = @plaka";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@mesafe", mesafe);
                        cmd.Parameters.AddWithValue("@plaka", plaka);

                        int etkilenenSatir = cmd.ExecuteNonQuery();

                        if (etkilenenSatir > 0)
                        {
                            MessageBox.Show($"{plaka} plakalı taksiye {mesafe} km eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxMesafe.Clear();
                            ListeyiGuncelle();
                        }
                        else
                        {
                            MessageBox.Show("Bu plakaya sahip taksi bulunamadı! Önce ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir mesafe (sayı) girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}