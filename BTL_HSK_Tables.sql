CREATE DATABASE QuanLyMuonTraSach;
GO
USE QuanLyMuonTraSach;
GO

-- Tạo bảng tblUser 
CREATE TABLE tblUser (
    TenDangNhap NVARCHAR(255) PRIMARY KEY,
    MatKhau NVARCHAR(255) NOT NULL,
    VaiTro NVARCHAR(50) NOT NULL  -- Sinh viên hoặc Thủ thư
);
GO

-- Tạo bảng tblTheLoai (Quản lý thể loại sách)
CREATE TABLE tblTheLoai (
    MaTheLoai INT PRIMARY KEY,      -- Mã thể loại
    TenTheLoai NVARCHAR(100)        -- Tên thể loại
);
GO

-- Tạo lại bảng tblSinhVien
CREATE TABLE tblSinhVien (
    MaSV INT IDENTITY(1,1) PRIMARY KEY,  -- Mã sinh viên tự động tăng
    Ten NVARCHAR(255),                   -- Tên sinh viên
    Lop NVARCHAR(50),                    -- Lớp của sinh viên
    Nganh NVARCHAR(100),                 -- Ngành học
    SDT NVARCHAR(15),                    -- Số điện thoại
    Email NVARCHAR(255),                 -- Email
    TenDangNhap NVARCHAR(255) UNIQUE,    -- Tên đăng nhập (liên kết với tblUser)
    FOREIGN KEY (TenDangNhap) REFERENCES tblUser(TenDangNhap)
);
GO

-- Tạo lại bảng tblThuThu
CREATE TABLE tblThuThu (
    MaThuThu INT IDENTITY(1,1) PRIMARY KEY,  -- Mã thủ thư tự động tăng
    HoTen NVARCHAR(255),                     -- Họ tên thủ thư
    Quyen NVARCHAR(50),                      -- Quyền của thủ thư
    SDT NVARCHAR(15),                        -- Số điện thoại
    Email NVARCHAR(255),                     -- Email
    TenDangNhap NVARCHAR(255) UNIQUE,        -- Tên đăng nhập (liên kết với tblUser)
    FOREIGN KEY (TenDangNhap) REFERENCES tblUser(TenDangNhap)
);
GO


-- Tạo bảng tblSach (Thông tin sách)
CREATE TABLE tblSach (
    MaSach INT PRIMARY KEY,         -- Mã sách
    TenSach NVARCHAR(255),          -- Tên sách
    SoLuong INT,                    -- Số lượng sách trong thư viện
    TheLoai INT,                    -- Mã thể loại sách
    FOREIGN KEY (TheLoai) REFERENCES tblTheLoai(MaTheLoai)
);
GO

-- Tạo bảng tblPhieuMuon (Thông tin phiếu mượn)
CREATE TABLE tblPhieuMuon (
    MaPhieuMuon INT PRIMARY KEY,   -- Mã phiếu mượn (Khóa chính)
    MaSV INT,                      -- Mã sinh viên (Khóa ngoại)
    TenSinhVien NVARCHAR(255),     -- Tên sinh viên
    NgayMuon DATE,                 -- Ngày mượn sách
    HanTra DATE,                   -- Ngày hạn trả sách
    MaThuThu INT,                  -- Mã thủ thư
    TenThuThu NVARCHAR(255),       -- Tên thủ thư
    MaSach INT,                    -- Mã sách (Khóa ngoại)
    TenSach NVARCHAR(255),         -- Tên sách
    FOREIGN KEY (MaSV) REFERENCES tblSinhVien(MaSV),
    FOREIGN KEY (MaThuThu) REFERENCES tblThuThu(MaThuThu),
    FOREIGN KEY (MaSach) REFERENCES tblSach(MaSach)
);
GO
