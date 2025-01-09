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

ALTER TABLE DanhMucSach
ADD TheLoai NVARCHAR(50);

ALTER TABLE MuonSach
	ADD NgayTraThucTe DATETIME NULL,
		SoLuongMuon INT NOT NULL DEFAULT 1;

INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, SoDienThoai, NgaySinh, GioiTinh, Quyen, Email, TenDangNhap, MatKhau)
VALUES ('NV001', N'Thế Hùng', 'TP.HCM', '0961673343', '2004-10-12', 'Nam', 'Admin', 'hungvu01235@gmail.com', 'thehung', '123');

SELECT * FROM NhanVien
SELECT * FROM DocGia
SELECT * FROM DanhMucSach
SELECT * FROM TacGia
SELECT * FROM MuonSach

INSERT INTO TacGia (MaTacGia, TenTacGia, QuocTich, DiaChi, GioiTinh, NgaySinh, SoDienThoai, Email)
VALUES 
    ('TG001', N'Dale Carnegie', N'Mỹ', N'New York', N'Nam', '1888-11-24', '0123456789', 'dale@gmail.com'),
    ('TG002', N'Paulo Coelho', N'Brazil', N'Rio de Janeiro', N'Nam', '1947-08-24', '0987654321', 'paulo@gmail.com'),
    ('TG003', N'Yuval Noah Harari', N'Israel', N'Jerusalem', N'Nam', '1976-02-24', '0112233445', 'yuval@gmail.com'),
    ('TG004', N'J.K. Rowling', N'Vương Quốc Anh', N'London', N'Nữ', '1965-07-31', '0778899000', 'jk@gmail.com'),
    ('TG005', N'Haruki Murakami', N'Nhật Bản', N'Tokyo', N'Nam', '1949-01-12', '0667788999', 'haruki@gmail.com'),
    ('TG006', N'Nguyễn Nhật Ánh', N'Việt Nam', N'Sài Gòn', N'Nam', '1955-05-07', '0555444333', 'nyan@gmail.com'),
    ('TG007', N'Rick Riordan', N'Mỹ', N'San Antonio', N'Nam', '1964-06-05', '0444333222', 'rick@gmail.com'),
    ('TG008', N'George Orwell', N'Vương Quốc Anh', N'Motihari', N'Nam', '1903-06-25', '0333222111', 'george@gmail.com'),
    ('TG009', N'F. Scott Fitzgerald', N'Mỹ', N'Saint Paul', N'Nam', '1896-09-24', '0222111000', 'fitzgerald@gmail.com'),
    ('TG010', N'Nguyễn Huy Thiệp', N'Việt Nam', N'Hà Nội', N'Nam', '1950-01-01', '0111222333', 'nhuy@gmail.com'),
    ('TG011', N'Gabriel García Márquez', N'Colombia', N'Aracataca', N'Nam', '1927-03-06', '0123456782', 'gabriel@gmail.com'),
    ('TG012', N'Chimamanda Ngozi Adichie', N'Nigeria', N'Enugu', N'Nữ', '1977-09-15', '0987654323', 'chimamanda@gmail.com'),
    ('TG013', N'Neil Gaiman', N'Vương Quốc Anh', N'Portsmouth', N'Nam', '1960-11-10', '0112233446', 'neil@gmail.com'),
    ('TG014', N'Stephen King', N'Mỹ', N'Maine', N'Nam', '1947-09-21', '0667788994', 'stephen@gmail.com'),
    ('TG015', N'Isabel Allende', N'Chile', N'Santiago', N'Nữ', '1942-08-02', '0555444335', 'isabel@gmail.com'),
    ('TG016', N'Harper Lee', N'Mỹ', N'Monroeville', N'Nữ', '1926-04-28', '0778899003', 'harper@gmail.com'),
    ('TG017', N'George R.R. Martin', N'Mỹ', N'Santa Fe', N'Nam', '1948-09-20', '0444333225', 'george.martin@gmail.com'),
    ('TG018', N'John Green', N'Mỹ', N'Indianapolis', N'Nam', '1977-08-24', '0333222114', 'john.green@gmail.com'),
    ('TG019', N'Agatha Christie', N'Vương Quốc Anh', N'Torquay', N'Nữ', '1890-09-15', '0222111003', 'agatha@gmail.com'),
    ('TG020', N'Kazuo Ishiguro', N'Nhật Bản', N'Nagasaki', N'Nam', '1954-11-08', '0111222336', 'kazuo@gmail.com'),
    ('TG021', N'Tô Hoài', N'Việt Nam', N'Hà Nội', N'Nam', '1920-09-27', '0123456783', 'tohai@gmail.com'),
    ('TG022', N'Nguyễn Minh Châu', N'Việt Nam', N'Hà Nội', N'Nam', '1930-07-12', '0987654324', 'nguyenminhchau@gmail.com'),
    ('TG023', N'Nguyễn Ngọc Tư', N'Việt Nam', N'Cà Mau', N'Nữ', '1976-04-21', '0112233447', 'nguyennongtu@gmail.com'),
    ('TG024', N'Bảo Ninh', N'Việt Nam', N'Hà Nội', N'Nam', '1970-01-01', '0667788995', 'baoninh@gmail.com'),
    ('TG025', N'Nguyễn Thi Hạnh', N'Việt Nam', N'Sài Gòn', N'Nữ', '1975-11-15', '0555444336', 'nguyenthi@gmail.com'),
    ('TG026', N'Nguyễn Quang Sáng', N'Việt Nam', N'Hà Nội', N'Nam', '1932-04-15', '0778899004', 'nguyenquangsang@gmail.com'),
    ('TG027', N'Nhất Hạnh', N'Việt Nam', N'Thuận An', N'Nam', '1926-10-11', '0444333226', 'nhathanh@gmail.com'),
    ('TG028', N'Nguyễn Huy Thiệp', N'Việt Nam', N'Hà Nội', N'Nam', '1950-01-01', '0333222115', 'nhuythiep@gmail.com'),
    ('TG029', N'Mark Tuan', N'Việt Nam', N'Hà Nội', N'Nam', '1995-09-01', '0222111004', 'marktuan@gmail.com'),
    ('TG030', N'Trần Đăng Khoa', N'Việt Nam', N'Thành phố Hồ Chí Minh', N'Nam', '1980-12-24', '0111222337', 'trandangkhoa@gmail.com');

INSERT INTO DocGia (MaDocGia, TenDocGia, SoDienThoai, GioiTinh, DiaChi, Email)
VALUES 
    ('DG001', N'Nguyễn Văn An', '0123456789', N'Nam', N'Hà Nội', 'nguyenvanan@gmail.com'),
    ('DG002', N'Trần Thị Bình', '0987654321', N'Nữ', N'Hồ Chí Minh', 'tranthibinh@gmail.com'),
    ('DG003', N'Phạm Minh Châu', '0112233445', N'Nam', N'Đà Nẵng', 'phamminhchau@gmail.com'),
    ('DG004', N'Lê Thị Duyên', '0667788999', N'Nữ', N'Hải Phòng', 'lethiduyen@gmail.com'),
    ('DG005', N'Tô Ngọc Hoàng', '0555444333', N'Nam', N'Nhà Bè', 'tonhachoang@gmail.com'),
    ('DG006', N'Nguyễn Thị Hằng', '0778899000', N'Nữ', N'Biên Hòa', 'nguyenthihang@gmail.com'),
    ('DG007', N'Nguyễn Văn Khải', '0444333222', N'Nam', N'Cần Thơ', 'nguyenvankhai@gmail.com'),
    ('DG008', N'Trần Thị Linh', '0333222111', N'Nữ', N'Vinh', 'tranthilinh@gmail.com'),
    ('DG009', N'Phạm Văn Minh', '0222111000', N'Nam', N'Nha Trang', 'phamvanminh@gmail.com'),
    ('DG010', N'Lê Thị Mai', '0111222333', N'Nữ', N'Quy Nhơn', 'lethimai@gmail.com'),
    ('DG011', N'Nguyễn Văn Hùng', '0123456780', N'Nam', N'Hà Nội', 'nguyenhung@gmail.com'),
    ('DG012', N'Trần Thị Hoa', '0987654322', N'Nữ', N'Hồ Chí Minh', 'tranhoa@gmail.com'),
    ('DG013', N'Phạm Văn Khoa', '0112233446', N'Nam', N'Đà Nẵng', 'phamkhoa@gmail.com'),
    ('DG014', N'Lê Thị Lan', '0667788991', N'Nữ', N'Hải Phòng', 'lelan@gmail.com'),
    ('DG015', N'Tô Minh Quân', '0555444334', N'Nam', N'Nhà Bè', 'toquan@gmail.com'),
    ('DG016', N'Nguyễn Thị Lệ', '0778899001', N'Nữ', N'Biên Hòa', 'nguyenle@gmail.com'),
    ('DG017', N'Nguyễn Văn Dũng', '0444333223', N'Nam', N'Cần Thơ', 'nguyendung@gmail.com'),
    ('DG018', N'Trần Thị Bích', '0333222112', N'Nữ', N'Vinh', 'tranbich@gmail.com'),
    ('DG019', N'Phạm Văn Tài', '0222111001', N'Nam', N'Nha Trang', 'phamtai@gmail.com'),
    ('DG020', N'Lê Thị Hạnh', '0111222334', N'Nữ', N'Quy Nhơn', 'lehanh@gmail.com'),
    ('DG021', N'Nguyễn Văn Sơn', '0123456781', N'Nam', N'Hà Nội', 'nguyenson@gmail.com'),
    ('DG022', N'Trần Thị Nhi', '0987654323', N'Nữ', N'Hồ Chí Minh', 'trannhi@gmail.com'),
    ('DG023', N'Phạm Minh Tú', '0112233447', N'Nam', N'Đà Nẵng', 'phamtu@gmail.com'),
    ('DG024', N'Lê Thị Ngọc', '0667788992', N'Nữ', N'Hải Phòng', 'lengoc@gmail.com'),
    ('DG025', N'Tô Văn Phúc', '0555444335', N'Nam', N'Nhà Bè', 'tophuc@gmail.com'),
    ('DG026', N'Nguyễn Thị Tuyết', '0778899002', N'Nữ', N'Biên Hòa', 'nguyentuyet@gmail.com'),
    ('DG027', N'Nguyễn Văn Hòa', '0444333224', N'Nam', N'Cần Thơ', 'nguyenhoa@gmail.com'),
    ('DG028', N'Trần Thị Yến', '0333222113', N'Nữ', N'Vinh', 'tranyen@gmail.com'),
    ('DG029', N'Phạm Văn Hải', '0222111002', N'Nam', N'Nha Trang', 'phamha@gmail.com'),
    ('DG030', N'Lê Thị Thảo', '0111222335', N'Nữ', N'Quy Nhơn', 'lethithao@gmail.com');

INSERT INTO DanhMucSach (MaSach, TenSach, MaTacGia, NhaXuatBan, Gia, SoLuong, HinhAnh, MoTa, NgayXuatBan, TheLoai)
VALUES 
    (4, N'Harry Potter và Hòn Đá Phù Thủy', 'TG004', N'Nhà xuất bản Trẻ', 90000, 20, NULL, N'Cuốn sách đầu tiên trong series Harry Potter', '1997-06-26', N'Fantasy'),
    (5, N'Người Đàn Ông Về Đêm', 'TG005', N'Nhà xuất bản Văn học', 80000, 12, NULL, N'Một cuốn tiểu thuyết về cuộc sống và tình yêu', '1997-07-15', N'Tiểu thuyết'),
    (6, N'To Kill a Mockingbird', 'TG016', N'Nhà xuất bản Harper', 150000, 8, NULL, N'Một câu chuyện về sự bất công trong xã hội', '1960-07-11', N'Tiểu thuyết'),
    (7, N'1984', 'TG008', N'Nhà xuất bản Penguin', 130000, 6, NULL, N'Sách về một tương lai u ám', '1949-06-08', N'Tiểu thuyết'),
    (8, N'The Great Gatsby', 'TG009', N'Nhà xuất bản Scribner', 110000, 5, NULL, N'Một tác phẩm kinh điển của văn học Mỹ', '1925-04-10', N'Tiểu thuyết'),
    (9, N'Chạy Đi Để Sống', 'TG010', N'Nhà xuất bản Lao Động', 95000, 10, NULL, N'Tiểu thuyết về cuộc chiến sinh tồn', '2010-05-01', N'Tiểu thuyết'),
    (10, N'The Alchemist', 'TG002', N'Nhà xuất bản HarperCollins', 75000, 25, NULL, N'Một hành trình tìm kiếm kho báu', '1988-05-01', N'Tiểu thuyết'),
    (11, N'Trên Đường Băng', 'TG018', N'Nhà xuất bản Kim Đồng', 60000, 15, NULL, N'Sách về cuộc sống và những giấc mơ', '2015-09-01', N'Tiểu thuyết'),
    (12, N'Sống Như Những Ngày Cuối', 'TG021', N'Nhà xuất bản Hội Nhà Văn', 85000, 20, NULL, N'Cuốn sách về những giá trị sống', '2018-11-20', N'Tiểu thuyết'),
    (13, N'Đi Tìm Lẽ Sống', 'TG023', N'Nhà xuất bản Thế Giới', 95000, 10, NULL, N'Khám phá ý nghĩa cuộc sống', '2020-01-15', N'Tiểu thuyết'),
    (14, N'Những Cuộc Phiêu Lưu Của Tom Sawyer', 'TG006', N'Nhà xuất bản Thanh Niên', 70000, 30, NULL, N'Một tác phẩm kinh điển của Mark Twain', '1876-04-15', N'Tiểu thuyết'),
    (15, N'Bí Mật Của Người Tìm Kiếm', 'TG013', N'Nhà xuất bản Văn Học', 90000, 5, NULL, N'Một câu chuyện ly kỳ về tình yêu và sự mất mát', '2019-05-18', N'Tiểu thuyết'),
    (16, N'Thế Giới Đã Mất', 'TG015', N'Nhà xuất bản Thời Đại', 120000, 8, NULL, N'Một cuốn sách về tương lai nhân loại', '2021-03-10', N'Tiểu thuyết'),
    (17, N'Văn Học Việt Nam', 'TG019', N'Nhà xuất bản Văn Học', 65000, 12, NULL, N'Tìm hiểu về văn học Việt Nam', '2016-07-30', N'Văn học'),
    (18, N'Những Mảnh Ghép Của Cuộc Đời', 'TG007', N'Nhà xuất bản Thế Giới', 85000, 18, NULL, N'Sách về những câu chuyện đời thường', '2017-04-22', N'Tiểu thuyết'),
    (19, N'Khi Lòng Người Thay Đổi', 'TG022', N'Nhà xuất bản Kim Đồng', 90000, 10, NULL, N'Khám phá tâm lý con người', '2022-12-01', N'Tâm lý'),
    (20, N'Tiếng Hát Giữa Rừng', 'TG024', N'Nhà xuất bản Văn Hóa', 80000, 5, NULL, N'Một cuốn sách về thiên nhiên và con người', '2023-01-15', N'Tiểu thuyết'),
    (21, N'Sống Trong Thế Giới Hiện Đại', 'TG025', N'Nhà xuất bản Tri Thức', 70000, 20, NULL, N'Tìm hiểu về cuộc sống hiện đại', '2023-02-10', N'Tiểu thuyết');