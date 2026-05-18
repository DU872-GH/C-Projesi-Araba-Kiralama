using araba_kiralama.Modüller;
using Microsoft.Data.SqlClient;
using System;

namespace araba_kiralama.Repo
{
    public class Kiralama_repo
    {
        private readonly string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\User\Desktop\C# Proje\C-Projesi-Araba-Kiralama\Araba_Kiralama\araba_kiralama\Veritabanı\Araçlar.mdf;
    Integrated Security=True;";

        public void Kirala(Kiralama kiralama)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sql = @"INSERT INTO kiralama 
                        (plaka, musteri_tc, baslangic_tarihi, bitis_tarihi, gun_sayisi, toplam_ucret)
                        VALUES (@plaka, @musteriTc, @baslangic, @bitis, @gun, @ucret)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@plaka", kiralama.plaka);
                        command.Parameters.AddWithValue("@musteriTc", kiralama.musteriTc);
                        command.Parameters.AddWithValue("@baslangic", kiralama.baslangicTarihi);
                        command.Parameters.AddWithValue("@bitis", kiralama.bitisTarihi);
                        command.Parameters.AddWithValue("@gun", kiralama.gunSayisi);
                        command.Parameters.AddWithValue("@ucret", kiralama.toplamUcret);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}