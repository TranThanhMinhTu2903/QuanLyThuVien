use QuanLyThuVien
go

CREATE OR ALTER PROCEDURE ThemDocGia
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(200),
    @Email NVARCHAR(100),
    @MaLoaiDocGia INT,
	@MaDocGia INT OUTPUT
AS
BEGIN
    DECLARE @TuoiToiDa INT
    DECLARE @TuoiToiThieu INT
    DECLARE @ThoiHanSuDung INT

    -- Retrieve TuoiToiDa, TuoiToiThieu, and ThoiHanSuDung values from the ThamSo table
    SELECT @TuoiToiDa = TuoiToiDa, @TuoiToiThieu = TuoiToiThieu, @ThoiHanSuDung = ThoiHanSuDung FROM ThamSo

    -- Calculate the age of the member based on the provided birth date
    DECLARE @Tuoi INT
    SET @Tuoi = DATEDIFF(YEAR, @NgaySinh, GETDATE())

    -- Check if the member's Tuoi is within the allowed range (TuoiToiThieu to TuoiToiDa)
    IF @Tuoi >= @TuoiToiThieu AND @Tuoi <= @TuoiToiDa
    BEGIN
        -- Insert the member's information into the 'DocGia' table
        INSERT INTO DocGia (HoTen, NgaySinh, DiaChi, Email, NgayLapThe, MaLoaiDocGia, NgayHetHan, TongNo)
        VALUES (@HoTen, @NgaySinh, @DiaChi, @Email, GETDATE(), @MaLoaiDocGia, DATEADD(MONTH, @ThoiHanSuDung, GETDATE()), 0)

        -- Get the ID of the newly inserted member
        SET @MaDocGia = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        -- If the member's age is not within the allowed range, return -1 to indicate failure
                RAISERROR('Tuổi không phù hợp.', 16, 1)
        RETURN
    END
END;
GO

-- GetAll
CREATE OR ALTER PROC GetAll
AS
BEGIN
	SELECT b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia, COUNT(c.MaCuonSach) AS SoLuongSachConLai
	FROM Sach b
	INNER JOIN DauSach a ON b.MaDauSach = a.MaDauSach
	LEFT JOIN CuonSach c ON b.MaSach = c.MaSach AND c.TinhTrang = 1
	LEFT JOIN TheLoai e ON a.MaTheLoai = e.MaTheLoai
	LEFT JOIN (
		SELECT f.MaDauSach, STRING_AGG(g.TenTacGia, ', ') AS TacGia
		FROM CT_TacGia f
		INNER JOIN TacGia g ON f.MaTacGia = g.MaTacGia
		GROUP BY f.MaDauSach
	) t ON b.MaDauSach = t.MaDauSach
	GROUP BY b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia
	ORDER BY b.MaSach;
END;
GO

--GetByTheLoai
CREATE OR ALTER PROC GetByTheLoai
    @ten_the_loai NVARCHAR(100)
AS
BEGIN
    SELECT b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia, COUNT(c.MaCuonSach) AS SoLuongSachConLai
	FROM Sach b
	INNER JOIN DauSach a ON b.MaDauSach = a.MaDauSach
	LEFT JOIN CuonSach c ON b.MaSach = c.MaSach AND c.TinhTrang = 1
	LEFT JOIN TheLoai e ON a.MaTheLoai = e.MaTheLoai
	LEFT JOIN (
		SELECT f.MaDauSach, STRING_AGG(g.TenTacGia, ', ') AS TacGia
		FROM CT_TacGia f
		INNER JOIN TacGia g ON f.MaTacGia = g.MaTacGia
		GROUP BY f.MaDauSach
	) t ON b.MaDauSach = t.MaDauSach
    WHERE c.TinhTrang = 1 AND LOWER(REPLACE(e.TenTheLoai, ' ', '')) LIKE '%' + @ten_the_loai + '%'
    GROUP BY b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia;
END
GO

-- GetByTenTacGia
CREATE OR ALTER PROC GetByTenTacGia
    @ten_tac_gia NVARCHAR(100)
AS
BEGIN    
 	SELECT b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia, COUNT(c.MaCuonSach) AS SoLuongSachConLai
	FROM Sach b
	INNER JOIN DauSach a ON b.MaDauSach = a.MaDauSach
	LEFT JOIN CuonSach c ON b.MaSach = c.MaSach AND c.TinhTrang = 1
	LEFT JOIN TheLoai e ON a.MaTheLoai = e.MaTheLoai
	LEFT JOIN (
		SELECT f.MaDauSach, STRING_AGG(g.TenTacGia, ', ') AS TacGia
		FROM CT_TacGia f
		INNER JOIN TacGia g ON f.MaTacGia = g.MaTacGia
		GROUP BY f.MaDauSach
	) t ON b.MaDauSach = t.MaDauSach
    WHERE c.TinhTrang = 1 AND LOWER(REPLACE(t.TacGia, ' ', '')) LIKE '%' + @ten_tac_gia + '%'
    GROUP BY b.MaSach, b.TenSach, e.TenTheLoai, T.TacGia;
END
GO

-- GetByTenSach
CREATE OR ALTER PROC GetByTenSach
    @ten_sach NVARCHAR(100)
AS
BEGIN
 	SELECT b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia, COUNT(c.MaCuonSach) AS SoLuongSachConLai
	FROM Sach b
	INNER JOIN DauSach a ON b.MaDauSach = a.MaDauSach
	LEFT JOIN CuonSach c ON b.MaSach = c.MaSach AND c.TinhTrang = 1
	LEFT JOIN TheLoai e ON a.MaTheLoai = e.MaTheLoai
	LEFT JOIN (
		SELECT f.MaDauSach, STRING_AGG(g.TenTacGia, ', ') AS TacGia
		FROM CT_TacGia f
		INNER JOIN TacGia g ON f.MaTacGia = g.MaTacGia
		GROUP BY f.MaDauSach
	) t ON b.MaDauSach = t.MaDauSach
    WHERE c.TinhTrang = 1 AND LOWER(REPLACE(b.TenSach, ' ', '')) LIKE '%' + @ten_sach + '%'
    GROUP BY b.MaSach, b.TenSach, e.TenTheLoai, t.TacGia;
END
go

CREATE OR ALTER PROCEDURE MuonSach
    @MaDocGia INT,
    @MaCuonSach INT,
    @TenSach NVARCHAR(100) OUTPUT,
    @TenTheLoai NVARCHAR(100) OUTPUT,
    @TenTacGia NVARCHAR(100) OUTPUT,
	@TenDocGia NVARCHAR(100) OUTPUT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
    BEGIN
        THROW 50001, 'Độc giả không tồn tại.', 1;
        RETURN;
    END;
    IF NOT EXISTS (SELECT 1 FROM CuonSach WHERE MaCuonSach = @MaCuonSach)
    BEGIN
        THROW 50002, 'Sách không tồn tại.', 1;
        RETURN;
    END;

    -- Check if the book is available
    DECLARE @TinhTrang BIT
    SELECT @TinhTrang = TinhTrang FROM CuonSach WHERE MaCuonSach = @MaCuonSach

    IF (@TinhTrang = 0)
    BEGIN
        RAISERROR('Hiện tại sách đã được mượn.', 16, 1)
        RETURN
    END

    -- Check if the borrower's card is still valid
    DECLARE @NgayHetHan DATE
    SELECT @NgayHetHan = NgayHetHan FROM DocGia WHERE MaDocGia = @MaDocGia

    IF (@NgayHetHan < GETDATE())
    BEGIN
        RAISERROR('Thẻ độc giả hết hạn.', 16, 1)
        RETURN
    END

    -- Check if the borrower has any expired books
    DECLARE @SoSachQuaHan INT
    SELECT @SoSachQuaHan = COUNT(MaCuonSach)
    FROM PhieuMuonTra
    WHERE MaDocGia = @MaDocGia
        AND DATEADD(MONTH, 6, NgayMuonSach) < GETDATE()

    IF (@SoSachQuaHan > 0)
    BEGIN
        RAISERROR('Độc giả có sách quá hạn, vui lòng trả sách trước khi mượn.', 16, 1)
        RETURN
    END

    -- Get the maximum number of allowed borrowed books and the maximum borrowing days from ThamSo table
    DECLARE @SoSachMuonToiDa INT, @SoNgayMuonToiDa INT
    SELECT @SoSachMuonToiDa = SoSachMuonToiDa, @SoNgayMuonToiDa = SoNgayMuonToiDa FROM ThamSo

    -- Check if the borrower has reached the maximum number of borrowed books within the maximum borrowing days
    DECLARE @SoLuongMuon INT
    SELECT @SoLuongMuon = COUNT(MaCuonSach)
    FROM PhieuMuonTra
    WHERE MaDocGia = @MaDocGia AND NgayMuonSach >= DATEADD(DAY, -@SoNgayMuonToiDa, GETDATE()) AND NgayMuonSach <= GETDATE()

    IF (@SoLuongMuon >= @SoSachMuonToiDa)
    BEGIN
        RAISERROR('Độc giả đạt số lượng sách mượn hàng ngày.', 16, 1)
        RETURN
    END

    -- Insert the borrowing record into CT_PhieuMuon
    INSERT INTO PhieuMuonTra (MaDocGia, NgayMuonSach, MaCuonSach, TinhTrang)
    VALUES (@MaDocGia, GETDATE(), @MaCuonSach, '1') -- 1 là chưa trả

    -- Update the book status to indicate it's borrowed
    UPDATE CuonSach SET TinhTrang = 0 WHERE MaCuonSach = @MaCuonSach

    -- Output to report
	select @TenSach = TenSach, @TenTheLoai =TenTheLoai, @TenTacGia = TacGia
	from cuonsach a
	inner join sach b on a.MaSach = b.MaSach
	inner join DauSach c on b.MaDauSach = c.MaDauSach
	inner join TheLoai d on c.MaTheLoai = d.MaTheLoai
	inner join (
		SELECT f.MaDauSach, STRING_AGG(g.TenTacGia, ', ') AS TacGia
		FROM CT_TacGia f
		INNER JOIN TacGia g ON f.MaTacGia = g.MaTacGia
		GROUP BY f.MaDauSach
	)  t ON b.MaDauSach = t.MaDauSach
	Where a.MaCuonSach = @MaCuonSach

	-- Output TenDocGia
	SELECT @TenDocGia = HoTen FROM DocGia
	WHERE @MaDocGia = MaDocGia
END;
go

-- TraSach
CREATE OR ALTER PROCEDURE TraSach
    @MaDocGia INT,
    @MaCuonSach INT
AS
BEGIN
    -- Check if the reader exists
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
    BEGIN
        THROW 50001, 'Độc giả không tồn tại.', 1;
        RETURN;
    END;

    -- Check if the book exists
    IF NOT EXISTS (SELECT 1 FROM CuonSach WHERE MaCuonSach = @MaCuonSach)
    BEGIN
        THROW 50002, 'Cuốn sách không tồn tại.', 1;
        RETURN;
    END;

    DECLARE @MaPhieuMuonTra INT;

    -- Get the MaPhieuMuon based on the MaDocGia and MaCuonSach
    SELECT @MaPhieuMuonTra = MaPhieuMuonTra
    FROM PhieuMuonTra
    WHERE MaDocGia = @MaDocGia AND MaCuonSach = @MaCuonSach AND TinhTrang = 1;

    IF @MaPhieuMuonTra IS NULL
    BEGIN
        THROW 50003, 'Phiếu mượn không tồn tại hoặc sách đã được trả.', 1;
        RETURN;
    END;

    -- Update NgayTraSach in CT_PhieuMuon
    UPDATE PhieuMuonTra
    SET NgayTraSach = GETDATE(),
        TinhTrang = 0
    WHERE MaPhieuMuonTra = @MaPhieuMuonTra;

    -- Update CuonSach TinhTrang to indicate it's available
    UPDATE CuonSach
    SET TinhTrang = 1 -- 1 là sách có sẵn tại thư viện mà chưa được mượn
    WHERE MaCuonSach = @MaCuonSach;

    -- Calculate the number of days late based on SoNgayMuonToiDa
    DECLARE @SoNgayMuonToiDa INT;
    SELECT @SoNgayMuonToiDa = SoNgayMuonToiDa FROM ThamSo;

    DECLARE @NgayMuonSach DATE;
    SELECT @NgayMuonSach = NgayMuonSach FROM PhieuMuonTra WHERE MaPhieuMuonTra = @MaPhieuMuonTra;

    DECLARE @SoNgayTre INT;
    SET @SoNgayTre = DATEDIFF(DAY, @NgayMuonSach, GETDATE()) - @SoNgayMuonToiDa;

    IF @SoNgayTre > 0
    BEGIN
        -- Calculate the late fee based on TienPhatTraTre
        DECLARE @TienPhatTraTre DECIMAL(10, 2);
        SELECT @TienPhatTraTre = TienPhatTraTre FROM ThamSo;

        DECLARE @TongNo DECIMAL(10, 2);
        SELECT @TongNo = TongNo FROM DocGia WHERE MaDocGia = @MaDocGia;

        -- Update TongNo of DocGia with the late fee
        SET @TongNo = @TongNo + (@SoNgayTre * @TienPhatTraTre);
        UPDATE DocGia
        SET TongNo = @TongNo
        WHERE MaDocGia = @MaDocGia;
    END;
END;
go

-- Create procedure to take cash from DocGia
CREATE OR ALTER PROCEDURE ThuTien
    @MaDocGia INT,
    @SoTien DECIMAL(10, 2)
AS
BEGIN
    -- Check if the provided MaDocGia exists
    IF NOT EXISTS (SELECT 1 FROM DocGia WHERE MaDocGia = @MaDocGia)
    BEGIN
        THROW 5001, 'Độc giả không tồn tại.', 1;
        RETURN;
    END;

    -- Check if the provided SoTien exceeds the outstanding debt of the borrower
    DECLARE @TongNo DECIMAL(10, 2)
    SELECT @TongNo = TongNo FROM DocGia WHERE MaDocGia = @MaDocGia

    IF @SoTien > @TongNo
    BEGIN
        THROW 50003, 'Tiền thu vược quá tổng nợ của độc giả.', 1;
        RETURN;
    END;

    -- Update the outstanding debt of the borrower (DocGia)
    SET @TongNo = @TongNo - @SoTien
    UPDATE DocGia
    SET TongNo = @TongNo
    WHERE MaDocGia = @MaDocGia

    -- Insert a new PhieuThu record
    INSERT INTO PhieuThu (MaDocGia, NgayLapPhieu, SoTienThu, ConLai)
    VALUES (@MaDocGia, GETDATE(), @SoTien, @TongNo)

    -- Print success message
    PRINT 'Thanh toán hoàn tất.'
END
go

--ThemSach
CREATE OR ALTER PROCEDURE ThemSach
    @MaDauSach INT,
    @TenSach NVARCHAR(100),
    @TriGia DECIMAL(18, 2),
    @MaNXB INT,
    @NamXuatBan INT,
    @MaSach INT OUTPUT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM DauSach WHERE MaDauSach = @MaDauSach)
    BEGIN
        THROW 50004, 'Đầu sách không tồn tại.', 1;
        RETURN;
    END;

    IF @NamXuatBan < YEAR(GETDATE()) - (SELECT KhoangCachXB FROM ThamSo)
    BEGIN
        THROW 50004, 'Năm xuất bản không hợp lệ.', 1;
        RETURN;
    END;

    -- Insert a new record into the Sach table
    INSERT INTO Sach (TenSach, MaDauSach, TriGia, MaNXB, NamXuatBan)
    VALUES (@TenSach, @MaDauSach, @TriGia, @MaNXB, @NamXuatBan);
    SET @MaSach = SCOPE_IDENTITY();
END
go


-- Lập báo cáo tháng theo thể loại
CREATE OR ALTER PROCEDURE BaoCaoThangTheLoai
    @TongLuotMuon INT OUTPUT
AS
BEGIN
    SELECT
        TenTheLoai,
        COUNT(d.MaCuonSach) AS SoLuotMuon,
        CAST(COUNT(d.MaCuonSach) AS DECIMAL) / SUM(COUNT(d.MaCuonSach)) OVER () * 100 AS TiLeLuotMuon
    FROM
        TheLoai a
        INNER JOIN DauSach b ON a.MaTheLoai = b.MaTheLoai
        INNER JOIN Sach c ON b.MaDauSach = c.MaDauSach
        INNER JOIN CuonSach d ON c.MaSach = d.MaSach
        INNER JOIN PhieuMuonTra e ON d.MaCuonSach = e.MaCuonSach
    WHERE
        MONTH(e.NgayMuonSach) = MONTH(GETDATE()) AND YEAR(e.NgayMuonSach) = YEAR(GETDATE())
    GROUP BY
        TenTheLoai

    -- Assign the total count of borrowings to @TongLuotMuon
    SELECT @TongLuotMuon = COUNT(d.MaCuonSach)
    FROM
        TheLoai a
        INNER JOIN DauSach b ON a.MaTheLoai = b.MaTheLoai
        INNER JOIN Sach c ON b.MaDauSach = c.MaDauSach
        INNER JOIN CuonSach d ON c.MaSach = d.MaSach
        INNER JOIN PhieuMuonTra e ON d.MaCuonSach = e.MaCuonSach
    WHERE
        MONTH(e.NgayMuonSach) = MONTH(GETDATE()) AND YEAR(e.NgayMuonSach) = YEAR(GETDATE())
END
go

--Báo cáo trả trễ
CREATE OR ALTER PROCEDURE BaoCaoTraTre
AS
BEGIN
    DECLARE @SoNgayTraTre INT
    SELECT @SoNgayTraTre = SoNgayMuonToiDa FROM THAMSO

    SELECT
        d.MaDocGia,
        d.HoTen,
        a.TenSach,
        b.MaCuonSach,
        c.NgayMuonSach,
        DATEDIFF(DAY, c.NgayMuonSach, GETDATE()) AS 'Số ngày trả trễ'
    FROM
        Sach a
        INNER JOIN CuonSach b ON a.MaSach = b.MaSach
        INNER JOIN PhieuMuonTra c ON b.MaCuonSach = c.MaCuonSach
        INNER JOIN DocGia d ON c.MaDocGia = d.MaDocGia
    WHERE
        c.NgayTraSach IS NULL -- Book not yet returned
        AND DATEDIFF(DAY, c.NgayMuonSach, GETDATE()) > (@SoNgayTraTre * 30) -- Convert months to days
    ORDER BY
        DATEDIFF(DAY, c.NgayMuonSach, GETDATE()) DESC;
END
go

-- InsertDauSach
CREATE OR ALTER PROCEDURE ThemDauSach
    @TenDauSach NVARCHAR(100),
	@MaTheLoai INT,
	@MaDauSach int OUTPUT
AS
BEGIN
 -- Insert a new record into the Sach table
    INSERT INTO DauSach (TenDauSach, MaTheLoai)
    VALUES (@TenDauSach, @MaTheLoai)
    SET @MaDauSach = SCOPE_IDENTITY()
END
go


-- InsertDauSach
CREATE OR ALTER PROCEDURE ThemCT_TacGia
	@MaDauSach INT,
	@MaTacGia INT
AS
BEGIN 
 -- Insert a new record into the Sach table
    INSERT INTO CT_TacGia (MADauSach, MaTacGia)
    VALUES (@MaDauSach, @MaTacGia)
END
go

--Trigger tuổi tối đa lớn hơn tuổi tối thiểu
CREATE OR ALTER TRIGGER CheckAgeRange
ON ThamSo
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TuoiToiThieu) OR UPDATE(TuoiToiDa)
    BEGIN
        DECLARE @TuoiToiThieu INT
        DECLARE @TuoiToiDa INT

        SELECT @TuoiToiThieu = TuoiToiThieu, @TuoiToiDa = TuoiToiDa FROM ThamSo

        IF @TuoiToiThieu >= @TuoiToiDa
        BEGIN
            RAISERROR ('Tuổi tối thiểu phải nhỏ hơn tuổi tối đa.', 16, 1)
            ROLLBACK TRANSACTION
            RETURN
        END
    END
END;
go

