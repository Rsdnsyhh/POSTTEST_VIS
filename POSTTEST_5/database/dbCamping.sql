CREATE DATABASE dbcamping;
USE dbcamping;

CREATE TABLE tbalat (
    kodeAlat VARCHAR(10) PRIMARY KEY,
    namaAlat VARCHAR(50),
    kategori VARCHAR(30),
    harga INT,
    status VARCHAR(20)
);

-- Data awal untuk testing
INSERT INTO tbalat VALUES 
('TEN-01', 'Tenda Dome 4 Orang', 'Tenda', 50000, 'Tersedia'),
('SLP-01', 'Sleeping Bag Polar', 'Tidur', 15000, 'Dipinjam');