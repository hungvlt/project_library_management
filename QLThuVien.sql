-- Tạo cơ sở dữ liệu
CREATE DATABASE QLThuVien;
GO
USE QLThuVien;
GO

-- Tạo bảng DocGia
CREATE TABLE DocGia (
    MaDocGia NVARCHAR(50) PRIMARY KEY,
    TenDocGia NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(15) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    Email NVARCHAR(100) UNIQUE -- Thêm ràng buộc UNIQUE cho Email
);

-- Tạo bảng TacGia
CREATE TABLE TacGia (
    MaTacGia NVARCHAR(50) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL,
    QuocTich NVARCHAR(100),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SoDienThoai NVARCHAR(15) NOT NULL,
    Email NVARCHAR(100) UNIQUE -- Thêm ràng buộc UNIQUE cho Email
);

-- Tạo bảng DanhMucSach
CREATE TABLE DanhMucSach (
    MaSach INT PRIMARY KEY,
    TenSach NVARCHAR(100),
    MaTacGia NVARCHAR(50),
    NhaXuatBan NVARCHAR(100),
    Gia DECIMAL(18, 2),
    SoLuong INT,
    HinhAnh NVARCHAR(200),
    MoTa NVARCHAR(255),
    NgayXuatBan DATE,
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia)
);
	
-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien NVARCHAR(50) PRIMARY KEY,
    TenNhanVien NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    SoDienThoai NVARCHAR(15) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    Quyen NVARCHAR(50) NOT NULL DEFAULT 'ThuThu',
    Email NVARCHAR(100) UNIQUE, -- Thêm ràng buộc UNIQUE cho Email
    TenDangNhap NVARCHAR(50) UNIQUE, -- Thêm cột tên đăng nhập
    MatKhau NVARCHAR(255) NOT NULL -- Thêm cột mật khẩu
);

-- Tạo bảng MuonSach
CREATE TABLE MuonSach (
    MaMuon NVARCHAR(50) PRIMARY KEY,
    MaDocGia NVARCHAR(50),
    MaSach INT,
    MaTacGia NVARCHAR(50),
    MaNhanVien NVARCHAR(50),
    NgayMuon DATE NOT NULL,
    NgayTra DATE,
    TrangThai NVARCHAR(50) DEFAULT 'Đang mượn',
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
    FOREIGN KEY (MaSach) REFERENCES DanhMucSach(MaSach),
    FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, NgaySinh, GioiTinh, Quyen, Email, TenDangNhap, MatKhau)
VALUES ('NV001', 'The Hung', 'TP.HCM', '0961673343', '2004-10-12', 'Nam', 'Admin', 'hungvu01235@gmail.com', 'hungadmin', 'hungadmin123');

SELECT * FROM NhanVien
SELECT * FROM DocGia
SELECT * FROM DanhMucSach
SELECT * FROM TacGia
SELECT * FROM MuonSach

ALTER TABLE DanhMucSach
ADD TheLoai NVARCHAR(50);

ALTER TABLE MuonSach
ADD NgayTraThucTe DATETIME NULL;

-- Thêm dữ liệu vào bảng DocGia
INSERT INTO DocGia (MaDocGia, TenDocGia, SoDienThoai, GioiTinh, DiaChi, Email) VALUES
('DG04', N'Nguyễn Văn A', '0123456789', N'Nam', N'Hà Nội', 'nguyenvana@gmail.com'),
('DG05', N'Trần Thị B', '0987654321', N'Nữ', N'TP. Hồ Chí Minh', 'tranthib@gmail.com'),
('DG06', N'Lê Văn C', '0112233445', N'Nam', N'Đà Nẵng', 'levanc@gmail.com');

-- Thêm dữ liệu vào bảng TacGia
INSERT INTO TacGia (MaTacGia, TenTacGia, QuocTich, DiaChi, GioiTinh, NgaySinh, SoDienThoai, Email) VALUES
('TG006', N'Nguyễn Nhật Ánh', N'Việt Nam', N'Hà Nội', N'Nam', '1955-05-07', '0123456789', 'nguyennhata@gmail.com'),
('TG007', N'Haruki Murakami', N'Nhật Bản', N'Tokyo', N'Nam', '1949-01-12', '0987654321', 'haruki@gmail.com'),
('TG008', N'J.K. Rowling', N'Vương Quốc Anh', N'London', N'Nữ', '1965-07-31', '0112233445', 'jkrowling@gmail.com');

-- Thêm dữ liệu vào bảng DanhMucSach
INSERT INTO DanhMucSach (MaSach, TenSach, MaTacGia, NhaXuatBan, Gia, SoLuong, HinhAnh, MoTa, NgayXuatBan) VALUES
(3, N'Khi Hội Mê', 'TG001', N'NXB Trẻ', 150000, 10, null, N'Một tác phẩm nổi tiếng của tác giả.', '2020-01-01'),
(4, N'Kafka bên bờ biển', 'TG002', N'NXB Văn học', 200000, 5, null, N'Tiểu thuyết độc đáo và sâu sắc.', '2005-05-01'),
(5, N'Harry Potter và viên đá phù thủy', 'TG003', N'NXB Bloomsbury', 250000, 8, null, N'Cuốn sách đầu tiên trong loạt truyện Harry Potter.', '1997-06-26');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, NgaySinh, GioiTinh, Quyen, Email, TenDangNhap, MatKhau) VALUES
('NV004', N'Trần Văn X', N'Hà Nội', '0123456789', '1990-03-15', N'Nam', 'ThuThu', 'tranvanx@gmail.com', 'tranvanx', '123'),
('NV005', N'Nguyễn Thị Y', N'TP. Hồ Chí Minh', '0987654321', '1985-08-20', N'Nữ', 'ThuThu', 'nguyenthiy@gmail.com', 'nguyenthiy', '123'),
('NV006', N'Lê Văn Z', N'Đà Nẵng', '0112233445', '1992-12-30', N'Nam', 'ThuThu', 'levanz@gmail.com', 'levanz', '123');