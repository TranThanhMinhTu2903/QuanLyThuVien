Create database QuanLyThuVien
go
Use QuanLyThuVien
go

CREATE TABLE LoaiDocGia (
    MaLoaiDocGia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    LoaiDocGia VARCHAR(50)
);

CREATE TABLE DocGia (
    MaDocGia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    Email NVARCHAR(100),
    NgayLapThe DATE,
    MaLoaiDocGia INT,
    NgayHetHan DATE,
    --SachQuaHan BIT,
    TongNo DECIMAL(10, 2),
    FOREIGN KEY (MaLoaiDocGia) REFERENCES LoaiDocGia (MaLoaiDocGia)
);

CREATE TABLE TacGia (
    MaTacGia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenTacGia NVARCHAR(100),
    NgaySinh DATE,
    QuocTich NVARCHAR(50)
);

CREATE TABLE TheLoai (
    MaTheLoai INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenTheLoai NVARCHAR(50)
);

CREATE TABLE NhaXuatBan (
    MaNXB INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenNXB NVARCHAR(100)
);

CREATE TABLE DauSach (
    MaDauSach INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenDauSach NVARCHAR(100),
    MaTheLoai INT,
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai (MaTheLoai)
);

CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenSach NVARCHAR(100),
    MaDauSach INT,
    MaNXB INT,
    NamXuatBan INT,
    TriGia DECIMAL(10, 2),
    FOREIGN KEY (MaDauSach) REFERENCES DauSach (MaDauSach),
    FOREIGN KEY (MaNXB) REFERENCES NhaXuatBan (MaNXB)
);

CREATE TABLE CuonSach (
    MaCuonSach INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MaSach INT,
    TinhTrang BIT,
	NgayNhap DATE,
    FOREIGN KEY (MaSach) REFERENCES Sach (MaSach)
);

CREATE TABLE CT_TacGia (
    MaDauSach INT NOT NULL,
    MaTacGia INT NOT NULL,
    PRIMARY KEY (MaDauSach, MaTacGia),
    FOREIGN KEY (MaDauSach) REFERENCES DauSach (MaDauSach),
    FOREIGN KEY (MaTacGia) REFERENCES TacGia (MaTacGia)
);

CREATE TABLE PhieuMuonTra (
    MaPhieuMuonTra INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MaDocGia INT,
    MaCuonSach INT,
    NgayMuonSach DATE,
    NgayTraSach DATE,
    TinhTrang BIT,
    FOREIGN KEY (MaDocGia) REFERENCES DocGia (MaDocGia),
    FOREIGN KEY (MaCuonSach) REFERENCES CuonSach (MaCuonSach)
);


CREATE TABLE PhieuThu (
    MaPhieuThu INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    MaDocGia INT,
    NgayLapPhieu DATE,
    SoTienThu DECIMAL(10, 2),
    ConLai DECIMAL(10, 2),
    FOREIGN KEY (MaDocGia) REFERENCES DocGia (MaDocGia)
);

CREATE TABLE ThamSo (
    TuoiToiThieu INT,
    TuoiToiDa INT,
    ThoiHanSuDung INT,
    KhoangCachXB INT,
    SoSachMuonToiDa INT,
	KhoangCachMuonSach INT,
    SoNgayMuonToiDa INT,
    TienPhatTraTre DECIMAL(10, 2),
	SoTheLoai INT,
	SoTacGia INT
);

CREATE TABLE account (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  username NVARCHAR(255) NOT NULL,
  password NVARCHAR(255) NOT NULL,
  LoaiTaiKhoan INT NOT NULL  -- 1 is admin
);
