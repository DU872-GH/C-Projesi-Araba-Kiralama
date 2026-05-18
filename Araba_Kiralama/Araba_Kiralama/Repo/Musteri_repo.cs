using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace araba_kiralama.Repo
{
    public class Musteri_repo
    {
        private readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\User\Desktop\C# Proje\C-Projesi-Araba-Kiralama\Araba_Kiralama\araba_kiralama\Veritabanı\Araçlar.mdf;
    Integrated Security=True;";
        public List<Musteriler> GetMusteri()
        {
            var musteriler = new List<Musteriler>();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM musteriler ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Musteriler musteriler1 = new Musteriler();
                                musteriler1.id = reader.GetInt32(0);
                                musteriler1.ad = reader.GetString(1);
                                musteriler1.soyad = reader.GetString(2);
                                musteriler1.tc = reader.GetString(3);
                                musteriler1.tel = reader.GetString(4);
                                musteriler1.email = reader.GetString(5);

                                musteriler.Add(musteriler1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }

            return musteriler;
        }

        public Musteriler? GetMusteri(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM musteriler WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Musteriler musteriler1 = new Musteriler();
                                musteriler1.id = reader.GetInt32(0);
                                musteriler1.ad = reader.GetString(1);
                                musteriler1.soyad = reader.GetString(2);
                                musteriler1.tc = reader.GetString(3);
                                musteriler1.tel = reader.GetString(4);
                                musteriler1.email = reader.GetString(5);

                                return musteriler1;
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

        public void MusteriEkle(Musteriler musteriler)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO musteriler" +
                                 "(ad, soyad, tc, tel, email) VALUES " +
                                 "(@ad, @soyad, @tc, @tel, @email);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ad", musteriler.ad);
                        command.Parameters.AddWithValue("@soyad", musteriler.soyad);
                        command.Parameters.AddWithValue("@tc", musteriler.tc);
                        command.Parameters.AddWithValue("@tel", musteriler.tel);
                        command.Parameters.AddWithValue("@email", musteriler.email);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }
        }

        public void UpdateMusteri(Musteriler musteriler)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE musteriler " +
                    "SET ad=@ad, soyad=@soyad, tc=@tc, tel=@tel, email=@email " +
                    "WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ad", musteriler.ad);
                        command.Parameters.AddWithValue("@soyad", musteriler.soyad);
                        command.Parameters.AddWithValue("@tc", musteriler.tc);
                        command.Parameters.AddWithValue("@tel", musteriler.tel);
                        command.Parameters.AddWithValue("@email", musteriler.email);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }
        }

        public void MusteriSil(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM musteriler WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
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
        public bool TcKontrol(string tc, int haricId = 0)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT COUNT(*) FROM musteriler WHERE tc=@tc AND id <> @haricId";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@tc", tc);
                        command.Parameters.AddWithValue("@haricId", haricId);
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
                return false;
            }
        }
    }
}
