using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace araba_kiralama.Repo
{
    public class Kiralama_repo
    {
        private readonly string ConnectionString =
   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deniz\Desktop\C-Projesi-Araba-Kiralama-main\Araba_Kiralama\Araba_Kiralama\Veritabani\Araclar.mdf;Integrated Security=True;";

        public Kiralama? KiralamaTcPlaka(string tc, string plaka)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Kiralama WHERE musteriTc = @tc AND plaka = @plaka";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@plaka", plaka);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Kiralama
                            {
                                id = Convert.ToInt32(reader["id"]),
                                plaka = reader["plaka"].ToString() ?? "",
                                musteriTc = reader["musteriTc"].ToString() ?? "",
                                baslangicTarihi = Convert.ToDateTime(reader["baslangicTarihi"]),
                                bitisTarihi = Convert.ToDateTime(reader["bitisTarihi"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Kiralama> GetKira()
        {
            var kiralamalar = new List<Kiralama>();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM kiralama ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kiralama kiralamalar1 = new Kiralama();
                                kiralamalar1.id = reader.GetInt32("id");
                                kiralamalar1.plaka = reader.GetString("plaka");
                                kiralamalar1.musteriTc = reader.GetString("musteriTc");
                                kiralamalar1.baslangicTarihi = Convert.ToDateTime(reader["baslangicTarihi"]);
                                kiralamalar1.bitisTarihi = Convert.ToDateTime(reader["bitisTarihi"]);

                                kiralamalar.Add(kiralamalar1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }

            return kiralamalar;
        }

        public List<Kiralama> GetKiraTC(string tcNo)
        {
            var kiralamalar = new List<Kiralama>();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM kiralama ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Kiralama kiralamalar1 = new Kiralama();
                                kiralamalar1.id = reader.GetInt32("id");
                                kiralamalar1.plaka = reader.GetString("plaka");
                                kiralamalar1.musteriTc = reader.GetString("musteriTc");
                                kiralamalar1.baslangicTarihi = Convert.ToDateTime(reader["baslangicTarihi"]);
                                kiralamalar1.bitisTarihi = Convert.ToDateTime(reader["bitisTarihi"]);

                                kiralamalar.Add(kiralamalar1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }

            return kiralamalar;
        }

        public void KiraEkle(Kiralama kira)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO kiralama" +
                                 "(plaka, musteriTc, baslangicTarihi, bitisTarihi) VALUES " +
                                 "(@plaka, @musteriTc, @baslangicTarihi, @bitisTarihi);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", kira.plaka);
                        command.Parameters.AddWithValue("@musteriTc", kira.musteriTc);
                        command.Parameters.AddWithValue("@baslangicTarihi", kira.baslangicTarihi);
                        command.Parameters.AddWithValue("@bitisTarihi", kira.bitisTarihi);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }
        }

        public (string isim, string model, string marka) GetKiralamaDetay(string musteriTc, string plaka)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string sql = "SELECT m.ad + ' ' + m.soyad AS isim, a.modeli, a.marka " +
                             "FROM kiralama k " +
                             "JOIN musteriler m ON m.tc = k.musteriTc " +
                             "JOIN arabalar a ON a.plaka = k.plaka " +
                             "WHERE k.musteriTc = @musteriTc AND k.plaka = @plaka";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@musteriTc", musteriTc);
                command.Parameters.AddWithValue("@plaka", plaka);

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (reader.GetString("isim"), reader.GetString("modeli"), reader.GetString("marka"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }

            return ("", "", "");
        }

        public string GetTarih(string plaka)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();

                string sql = "SELECT bitisTarihi FROM kiralama WHERE plaka = @plaka";

                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@plaka", plaka);

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetDateTime("bitisTarihi").ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }

            return "";
        }

        public void KiraSil(string musteriTc, string plaka)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM kiralama WHERE musteriTc=@musteriTc AND plaka=@plaka";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@musteriTc", musteriTc);
                        command.Parameters.AddWithValue("@plaka", plaka);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }
        }
    }
}