using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;

namespace araba_kiralama.Repo
{
    public class Kiralama_repo
    {
        private readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\User\Desktop\C# Proje\C-Projesi-Araba-Kiralama\Araba_Kiralama\araba_kiralama\Veritabanı\Araclar.mdf;
    Integrated Security=True;";

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
    }
}