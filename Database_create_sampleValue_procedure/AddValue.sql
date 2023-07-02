use QuanLyThuVien

-- Insert sample records into the LoaiDocGia table
INSERT INTO LoaiDocGia (LoaiDocGia) VALUES
('Doc gia X'),
('Doc Gia Y');


-- Insert sample records into the DocGia table
INSERT INTO DocGia (HoTen, NgaySinh, DiaChi, Email, NgayLapThe, MaLoaiDocGia, NgayHetHan, TongNo) VALUES
('Nguyen Van A', '1990-01-01', 'Address 1', 'email1@example.com', '2021-01-01', 1, DATEADD(month, 6, GETDATE()), 0),
('Tran Thi B', '1995-05-05', 'Address 2', 'email2@example.com', '2021-02-01', 2, DATEADD(month, 6, GETDATE()), 1000),
('Le Van C', '1985-10-10', 'Address 3', 'email3@example.com', '2021-03-01', 1, DATEADD(month, 6, GETDATE()), 0),
('Pham Thi D', '1992-03-15', 'Address 4', 'email4@example.com', '2021-04-01', 2, DATEADD(month, 6, GETDATE()), 2000),
('Hoang Van E', '1998-07-20', 'Address 5', 'email5@example.com', '2021-05-01', 1, DATEADD(month, 6, GETDATE()), 0);

-- Insert sample records into the TacGia table
INSERT INTO TacGia (TenTacGia, NgaySinh, QuocTich) VALUES
('Anh Thy', '1980-01-01', 'Country 1'),
('Thy Anh', '1985-02-02', 'Country 2'),
('Christopher Teo', '1990-03-03', 'Country 3'),
('Tommy Teo', '1995-04-04', 'Country 4'),
('Daniel', '2000-05-05', 'Country 5');

-- Insert sample records into the TheLoai table
INSERT INTO TheLoai (TenTheLoai) VALUES
('The loai A'),
('The loai B'),
('The loai C');

-- Insert sample records into the NhaXuatBan table
INSERT INTO NhaXuatBan (TenNXB) VALUES
('NXB Tre'),
('NXB Thanh Nien'),
('NXB Van Hoc'),
('Havard'),
('NXB Kim Dong');

-- Insert sample records into the DauSach table
INSERT INTO DauSach (TenDauSach, MaTheLoai) VALUES
('Book 1', 1),
('Book 2', 2),
('Book 3', 3),
('Book 4', 1),
('Book 5', 2);

-- Insert sample records into the Sach table
INSERT INTO Sach (TenSach, MaDauSach, MaNXB, NamXuatBan, TriGia) VALUES
('Book 1 - Edition 1', 1, 1, 2019, 100),
('Book 1 - Edition 2', 1, 1, 2022, 150),
('Book 2 - Edition 1', 2, 2, 2020, 120),
('Book 2 - Edition 2', 2, 2, 2023, 200),
('Book 3 - Edition 1', 3, 3, 2017, 80);

-- Insert sample records into the CuonSach table
INSERT INTO CuonSach (MaSach, TinhTrang, NgayNhap) VALUES
(1, 1, '2020-06-12'),
(1, 0, '2020-06-12'), --2
(2, 1, '2021-06-13'),
(2, 0, '2018-06-13'), --4
(3, 1, '2020-06-15'),
(3, 1, '2020-06-15'),
(4, 1, '2021-06-13'),
(4, 0, '2021-06-13'), --8
(5, 1, '2019-06-14');

-- Insert sample records into the CT_TacGia table
INSERT INTO CT_TacGia (MaDauSach, MaTacGia) VALUES
(1, 1),
(1, 2),
(2, 2),
(2, 3),
(3, 3),
(4, 4),
(5, 5);

-- Insert sample records into the PhieuMuonTra table
INSERT INTO PhieuMuonTra (MaDocGia, MaCuonSach, NgayMuonSach, TinhTrang) VALUES
(1, 2, '2003-06-12', 1),
(2, 4, '2020-06-13', 1),
(3, 8, '2023-06-14', 1);

-- Insert sample records into the PhieuThu table
INSERT INTO PhieuThu (MaDocGia, NgayLapPhieu, SoTienThu, ConLai) VALUES
(1, '2023-06-12', 100000, 0),
(2, '2023-06-13', 150000, 1000),
(3, '2023-06-14', 200000, 0),
(4, '2023-06-15', 120000, 2000),
(5, '2023-06-15', 180000, 0);

-- Insert sample records into the ThamSo table
INSERT INTO ThamSo (TuoiToiThieu, TuoiToiDa, ThoiHanSuDung, KhoangCachXB, SoSachMuonToiDa, KhoangCachMuonSach, SoNgayMuonToiDa, TienPhatTraTre, SoTheLoai, SoTacGia) VALUES
(18, 55, 6, 8, 5, 4, 4, 1000, 3, 100);

INSERT INTO account (username, password, LoaiTaiKhoan) --1 is admin
VALUES ('admin', 'admin', 1), ('anhthy', 'anhthy', 0), ('hoangtieng', 'hoangtieng',0), ('minhtu', 'minhtu', 0)

