USE QuanLyMuonTraSach;
GO

CREATE PROCEDURE sp_ThemUser
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(255),
	@VaiTro NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra nếu tài khoản đã tồn tại
    IF EXISTS (SELECT 1 FROM tblUser WHERE TenDangNhap = @TenDangNhap)
    BEGIN
        RAISERROR('Tài khoản đã tồn tại!', 16, 1);
        RETURN -1;
    END
    -- Nếu chưa tồn tại, chèn dữ liệu mới
    INSERT INTO tblUser (TenDangNhap, MatKhau, VaiTro)
    VALUES (@TenDangNhap, @MatKhau, @VaiTro)
END
GO

-- Kiểm tra thể loại không trùng lặp
CREATE PROCEDURE sp_ThemTheLoai
    @TenTheLoai NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM tblTheLoai WHERE TenTheLoai = @TenTheLoai)
    BEGIN
        RAISERROR('Thể loại đã tồn tại!', 16, 1);
        RETURN -1;
    END

    -- Thêm thể loại vào hệ thống
    INSERT INTO tblTheLoai (TenTheLoai)
    VALUES (@TenTheLoai);
END
GO

-- Thêm thông tin sinh viên
CREATE PROCEDURE sp_ThemSinhVien
    @Ten NVARCHAR(255),
    @Lop NVARCHAR(50),
    @Nganh NVARCHAR(100),
    @SDT NVARCHAR(15),
    @Email NVARCHAR(255),
    @TenDangNhap NVARCHAR(255)
AS
BEGIN
    -- Thêm sinh viên vào bảng tblSinhVien
    INSERT INTO tblSinhVien (Ten, Lop, Nganh, SDT, Email, TenDangNhap)
    VALUES (@Ten, @Lop, @Nganh, @SDT, @Email, @TenDangNhap);
END
GO

-- Thêm thông tin thủ thư
CREATE PROCEDURE sp_ThemThuThu
    @HoTen NVARCHAR(255),
    @Quyen NVARCHAR(50),
    @SDT NVARCHAR(15),
    @Email NVARCHAR(255),
    @TenDangNhap NVARCHAR(255)
AS
BEGIN
    -- Thêm thủ thư vào bảng tblThuThu
    INSERT INTO tblThuThu (HoTen, Quyen, SDT, Email, TenDangNhap)
    VALUES (@HoTen, @Quyen, @SDT, @Email, @TenDangNhap);
END
GO

CREATE PROCEDURE sp_ThemSach
    @TenSach NVARCHAR(255),
    @SoLuong INT,
    @TheLoai INT
AS
BEGIN
    -- Kiểm tra nếu sách đã tồn tại trong hệ thống
    IF EXISTS (SELECT 1 FROM tblSach WHERE TenSach = @TenSach)
    BEGIN
        RAISERROR('Sách đã tồn tại trong hệ thống!', 16, 1);
        RETURN -1;
    END

    -- Thêm sách vào hệ thống
    INSERT INTO tblSach (TenSach, SoLuong, TheLoai)
    VALUES (@TenSach, @SoLuong, @TheLoai);
END
GO

CREATE PROCEDURE sp_ThemTheLoai
    @TenTheLoai NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra nếu thể loại đã tồn tại
    IF EXISTS (SELECT 1 FROM tblTheLoai WHERE TenTheLoai = @TenTheLoai)
    BEGIN
        RAISERROR('Thể loại đã tồn tại!', 16, 1);
        RETURN -1;
    END

    -- Thêm thể loại vào hệ thống
    INSERT INTO tblTheLoai (TenTheLoai)
    VALUES (@TenTheLoai);
END
GO

CREATE PROCEDURE sp_ThemPhieuMuon
    @MaPhieuMuon INT,
    @MaSV INT,
    @TenSinhVien NVARCHAR(255),
    @NgayMuon DATE,
    @HanTra DATE,
    @MaThuThu INT,
    @TenThuThu NVARCHAR(255),
    @MaSach INT,
    @TenSach NVARCHAR(255)
AS
BEGIN
    -- Kiểm tra số phiếu mượn của sinh viên
    DECLARE @PhiếuMượnCount INT;
    SELECT @PhiếuMượnCount = COUNT(DISTINCT MaPhieuMuon) 
    FROM tblPhieuMuon 
    WHERE MaSV = @MaSV AND NgayMuon <= GETDATE() AND HanTra >= GETDATE();

    IF @PhiếuMượnCount >= 3
    BEGIN
        RAISERROR('Sinh viên đã có tối đa 3 phiếu mượn, không thể thêm phiếu mới', 16, 1);
        RETURN;
    END

    -- Thêm phiếu mượn vào hệ thống
    INSERT INTO tblPhieuMuon (MaPhieuMuon, MaSV, TenSinhVien, NgayMuon, HanTra, MaThuThu, TenThuThu, MaSach, TenSach)
    VALUES (@MaPhieuMuon, @MaSV, @TenSinhVien, @NgayMuon, @HanTra, @MaThuThu, @TenThuThu, @MaSach, @TenSach);
END
GO

-- Sửa phiếu mượn
CREATE PROCEDURE sp_SuaPhieuMuon
    @MaPhieuMuon INT,
    @MaSV INT,
    @TenSinhVien NVARCHAR(255),
    @NgayMuon DATE,
    @HanTra DATE,
    @MaThuThu INT,
    @TenThuThu NVARCHAR(255),
    @MaSach INT,
    @TenSach NVARCHAR(255)
AS
BEGIN
    -- Sửa phiếu mượn
    UPDATE tblPhieuMuon
    SET 
        MaSV = @MaSV, 
        TenSinhVien = @TenSinhVien, 
        NgayMuon = @NgayMuon, 
        HanTra = @HanTra, 
        MaThuThu = @MaThuThu, 
        TenThuThu = @TenThuThu, 
        MaSach = @MaSach, 
        TenSach = @TenSach
    WHERE MaPhieuMuon = @MaPhieuMuon;
END
GO

-- Sửa sinh viên
CREATE PROCEDURE sp_SuaSinhVien
    @MaSV INT,
    @Ten NVARCHAR(255),
    @Lop NVARCHAR(50),
    @Nganh NVARCHAR(100),
    @SDT NVARCHAR(15),
    @Email NVARCHAR(255),
    @TenDangNhap NVARCHAR(255)
AS
BEGIN
    UPDATE tblSinhVien
    SET Ten = @Ten, Lop = @Lop, Nganh = @Nganh, SDT = @SDT, Email = @Email, TenDangNhap = @TenDangNhap
    WHERE MaSV = @MaSV;
END
GO

-- Sửa thủ thư
CREATE PROCEDURE sp_SuaThuThu
    @MaThuThu INT,
    @HoTen NVARCHAR(255),
    @Quyen NVARCHAR(50),
    @SDT NVARCHAR(15),
    @Email NVARCHAR(255),
    @TenDangNhap NVARCHAR(255)
AS
BEGIN
    UPDATE tblThuThu
    SET HoTen = @HoTen, Quyen = @Quyen, SDT = @SDT, Email = @Email, TenDangNhap = @TenDangNhap
    WHERE MaThuThu = @MaThuThu;
END
GO

-- Sửa sách
CREATE PROCEDURE sp_SuaSach
    @MaSach INT,
    @TenSach NVARCHAR(255),
    @SoLuong INT,
    @TheLoai INT
AS
BEGIN
    UPDATE tblSach
    SET TenSach = @TenSach, SoLuong = @SoLuong, TheLoai = @TheLoai
    WHERE MaSach = @MaSach;
END
GO

--Sửa thể loại
CREATE PROCEDURE sp_SuaTheLoai
    @MaTheLoai INT,
    @TenTheLoai NVARCHAR(255)
AS
BEGIN
	UPDATE tblTheLoai
	SET MaTheLoai = @MaTheLoai, TenTheLoai = @TenTheLoai
	WHERE MaTheLoai = @MaTheLoai;
END
GO

-- Xóa phiếu mượn
CREATE PROCEDURE sp_XoaPhieuMuon
    @MaPhieuMuon INT
AS
BEGIN
    DELETE FROM tblPhieuMuon WHERE MaPhieuMuon = @MaPhieuMuon;
END
GO

-- Xóa sinh viên
CREATE PROCEDURE sp_XoaSinhVien
    @MaSV INT
AS
BEGIN
    -- Xóa thông tin sinh viên
    DELETE FROM tblSinhVien WHERE MaSV = @MaSV;
    
    -- Xóa tên đăng nhập và mật khẩu trong bảng tblUser
    DELETE FROM tblUser WHERE TenDangNhap = (SELECT TenDangNhap FROM tblSinhVien WHERE MaSV = @MaSV);
END
GO

-- Xóa thủ thư
CREATE PROCEDURE sp_XoaThuThu
    @MaThuThu INT
AS
BEGIN
    -- Xóa thông tin thủ thư
    DELETE FROM tblThuThu WHERE MaThuThu = @MaThuThu;
    
    -- Xóa tên đăng nhập và mật khẩu trong bảng tblUser
    DELETE FROM tblUser WHERE TenDangNhap = (SELECT TenDangNhap FROM tblThuThu WHERE MaThuThu = @MaThuThu);
END
GO

-- Xóa sách
CREATE PROCEDURE sp_XoaSach
    @MaSach INT
AS
BEGIN
    DELETE FROM tblSach WHERE MaSach = @MaSach;
END
GO

