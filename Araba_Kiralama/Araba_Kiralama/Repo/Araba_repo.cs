using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Serialization;

namespace araba_kiralama.Repo
{
    public class Araba_repo
    {
        private readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=|DataDirectory|\Veritabanı\Araçlar.mdf;
    Integrated Security=True;";

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
                                arabalar1.id = reader.GetInt32(0);
                                arabalar1.plaka = reader.GetString(1);
                                arabalar1.tur = reader.GetString(2);
                                arabalar1.marka = reader.GetString(3);
                                arabalar1.model = reader.GetString(4);
                                arabalar1.yil = reader.GetString(5);

                                arabalar.Add(arabalar1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
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
                                arabalar1.id = reader.GetInt32(0);
                                arabalar1.plaka = reader.GetString(1);
                                arabalar1.tur = reader.GetString(2);
                                arabalar1.marka = reader.GetString(3);
                                arabalar1.model = reader.GetString(4);
                                arabalar1.yil = reader.GetString(5);

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
                                 "(plaka, tur, marka, model, yil) VALUES " +
                                 "(@plaka, @tur, @marka, @model, @yil);";
                    using (SqlCommand  command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", arabalar.plaka);
                        command.Parameters.AddWithValue("@tur", arabalar.tur);
                        command.Parameters.AddWithValue("@marka", arabalar.marka);
                        command.Parameters.AddWithValue("@model", arabalar.model);
                        command.Parameters.AddWithValue("@yil", arabalar.yil);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ayrıcalık: " + ex.ToString());
            }      
        }

        public void UpdateAraba(Arabalar arabalar)
        {
            try {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = "UPDATE arabalar " +
                    "SET plaka=@plaka, tur=@tur, marka=@marka, model=@model, yil=@yil " +
                    "WHERE id=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", arabalar.plaka);
                        command.Parameters.AddWithValue("@tur", arabalar.tur);
                        command.Parameters.AddWithValue("@marka", arabalar.marka);
                        command.Parameters.AddWithValue("@model", arabalar.model);
                        command.Parameters.AddWithValue("@yil", arabalar.yil);

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