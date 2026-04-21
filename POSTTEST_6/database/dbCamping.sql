-- 1. membuat database
CREATE DATABASE IF NOT EXISTS dbcamping;
USE dbcamping;

-- 2. membuat tabel master (tbalat)
CREATE TABLE tbalat (
    kodeAlat VARCHAR(10) PRIMARY KEY,
    namaAlat VARCHAR(50),
    kategori VARCHAR(30),
    harga INT,
    status VARCHAR(20)
);

-- 3. membuat tabel relasi (tbpeminjaman)
CREATE TABLE tbpeminjaman (
    kodePinjam     VARCHAR(10) PRIMARY KEY,
    kodeAlat       VARCHAR(10) NOT NULL,
    namaPeminjam   VARCHAR(50),
    tanggalPinjam  VARCHAR(20),
    tanggalKembali VARCHAR(20),
    CONSTRAINT fk_alat FOREIGN KEY (kodeAlat)
        REFERENCES tbalat(kodeAlat)
        ON DELETE RESTRICT
        ON UPDATE CASCADE
);

-- 4. data peralatan camping
INSERT INTO tbalat (kodeAlat, namaAlat, kategori, harga, status) VALUES 
('TND-004', 'Tenda Dome 4 Orang', 'Tenda', 450000, 'Tersedia'),
('SLP-003', 'Sleeping Bag Polar Tebal', 'Tidur', 95000, 'Tersedia'),
('KMP-001', 'Kompor Portable Kotak', 'Masak', 120000, 'Tersedia'),
('LMP-002', 'Senter Kepala (Headlamp)', 'Penerangan', 35000, 'Tersedia');