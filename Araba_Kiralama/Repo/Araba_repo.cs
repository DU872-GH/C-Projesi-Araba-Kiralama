using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Serialization;

namespace araba_kiralama.Repo
{
    public class Araba_repo
    {
        private readonly string ConnectionString =
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\deniz\Desktop\Yeni klasör\C-Projesi-Araba-Kiralama-main\Araba_Kiralama\Araba_Kiralama\Veritabani\Araclar.mdf;Integrated Security=True;";

        public List<Arabalar> GetAraba()
        {
            var arabalar = new List<Arabalar>();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM arabalar ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Arabalar arabalar1 = new Arabalar();
                                arabalar1.id = reader.GetInt32("id");
                                arabalar1.plaka = reader.GetString("plaka");
                                arabalar1.turu = reader.GetString("turu");
                                arabalar1.marka = reader.GetString("marka");
                                arabalar1.modeli = reader.GetString("modeli");
                                arabalar1.vites = reader.GetString("vites");
                                arabalar1.yil = reader.GetInt32("yil");
                                arabalar1.km = reader.GetInt32("km");
                                arabalar1.kirada = reader.GetBoolean("kirada");
                                arabalar1.gunlukUcret = reader.GetInt32("gunlukUcret");

                                arabalar.Add(arabalar1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }

            return arabalar;
        }

        public Arabalar? GetAraba(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM arabalar WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Arabalar arabalar1 = new Arabalar();
                                arabalar1.id = reader.GetInt32("id");
                                arabalar1.plaka = reader.GetString("plaka");
                                arabalar1.turu = reader.GetString("turu");
                                arabalar1.marka = reader.GetString("marka");
                                arabalar1.modeli = reader.GetString("modeli");
                                arabalar1.vites = reader.GetString("vites");
                                arabalar1.yil = reader.GetInt32("yil");
                                arabalar1.km = reader.GetInt32("km");
                                arabalar1.kirada = reader.GetBoolean("kirada");
                                arabalar1.gunlukUcret = reader.GetInt32("gunlukUcret");

                                return arabalar1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }
            return null;
        }

        public void ArabaEkle(Arabalar arabalar)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO arabalar" +
                                 "(plaka, turu, marka, modeli, vites, yil, km, gunlukUcret, kirada) VALUES " +
                                 "(@plaka, @turu, @marka, @modeli, @vites, @yil, @km, @gunlukUcret, @kirada);";
                    using (SqlCommand  command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", arabalar.plaka);
                        command.Parameters.AddWithValue("@turu", arabalar.turu);
                        command.Parameters.AddWithValue("@marka", arabalar.marka);
                        command.Parameters.AddWithValue("@modeli", arabalar.modeli);
                        command.Parameters.AddWithValue("@vites", arabalar.vites);
                        command.Parameters.AddWithValue("@yil", arabalar.yil);
                        command.Parameters.AddWithValue("@km", arabalar.km);
                        command.Parameters.AddWithValue("@gunlukUcret", arabalar.gunlukUcret);
                        command.Parameters.AddWithValue("@kirada", arabalar.kirada);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "DB Hatası");
            }
        }

        public void UpdateAraba(Arabalar arabalar)
        {
            try {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE arabalar " +
                    "SET plaka=@plaka, turu=@turu, marka=@marka, modeli=@modeli, vites=@vites, yil=@yil, km=@km, gunlukUcret=@gunlukUcret, kirada=@kirada WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", arabalar.id);
                        command.Parameters.AddWithValue("@plaka", arabalar.plaka);
                        command.Parameters.AddWithValue("@turu", arabalar.turu);
                        command.Parameters.AddWithValue("@marka", arabalar.marka);
                        command.Parameters.AddWithValue("@modeli", arabalar.modeli);
                        command.Parameters.AddWithValue("@vites", arabalar.vites);
                        command.Parameters.AddWithValue("@yil", arabalar.yil);
                        command.Parameters.AddWithValue("@km", arabalar.km);
                        command.Parameters.AddWithValue("@gunlukUcret", arabalar.gunlukUcret);
                        command.Parameters.AddWithValue("@kirada", arabalar.kirada);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }
        }

        public void ArabaSil(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM arabalar WHERE id=@id";
                    using (SqlCommand command = new SqlCommand (sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

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