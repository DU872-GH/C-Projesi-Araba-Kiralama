CREATE TABLE musteriler (
    id INT PRIMARY KEY IDENTITY(1,1),
    ad NVARCHAR(50) NOT NULL,
    soyad NVARCHAR(50) NOT NULL,
    tc NVARCHAR(11),
    tel NVARCHAR(11),
    email NVARCHAR(100)
);
CREATE TABLE kiralama (
    id INT PRIMARY KEY IDENTITY(1,1),
    araba_id INT NOT NULL,
    musteri_id INT NOT NULL,
    baslangic_tarihi DATE NOT NULL,
    bitis_tarihi DATE NOT NULL,
    gun_sayisi INT NOT NULL,
    toplam_ucret DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (araba_id) REFERENCES arabalar(id),
    FOREIGN KEY (musteri_id) REFERENCES musteriler(id)
);
