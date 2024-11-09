-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLySinhVien1109;
USE QuanLySinhVien1109;

-- Bảng tbKhoa
CREATE TABLE tbKhoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa VARCHAR(100)
);

-- Bảng tbLop
CREATE TABLE tbLop (
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(100),
    MaKhoa INT,
    FOREIGN KEY (MaKhoa) REFERENCES tbKhoa(MaKhoa)
);

-- Bảng tbChinhSach
CREATE TABLE tbChinhSach (
    MaCS INT PRIMARY KEY,
    TenCS VARCHAR(100),
    CheDo TEXT
);

-- Bảng tbSinhVien
CREATE TABLE tbSinhVien (
    MaSV INT PRIMARY KEY,
    Ten VARCHAR(100),
    GioiTinh VARCHAR(10),
    NgaySinh DATE,
    SDT VARCHAR(15),
    DiaChi VARCHAR(200),
    MaCS INT,
    MaLop INT,
    FOREIGN KEY (MaCS) REFERENCES tbChinhSach(MaCS),
    FOREIGN KEY (MaLop) REFERENCES tbLop(MaLop)
);

-- Bảng tbGiaoVien
CREATE TABLE tbGiaoVien (
    MaGV INT PRIMARY KEY,
    TenGV VARCHAR(100),
    NgaySinh DATE,
    GioiTinh VARCHAR(10),
    DiaChi VARCHAR(200)
);

-- Bảng tbMonHoc
CREATE TABLE tbMonHoc (
    MaMH INT PRIMARY KEY,
    TenMH VARCHAR(100),
    SoTiet INT,
    MaGV INT,
    FOREIGN KEY (MaGV) REFERENCES tbGiaoVien(MaGV)
);

-- Bảng tbDiem
CREATE TABLE tbDiem (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Thêm IDENTITY để tự động tăng giá trị cho cột Id
    MaSV INT,
    MaMH INT,
    Diem FLOAT,
    FOREIGN KEY (MaSV) REFERENCES tbSinhVien(MaSV),
    FOREIGN KEY (MaMH) REFERENCES tbMonHoc(MaMH)
);

-- Bảng tbAdmin
CREATE TABLE tbAdmin (
    UserID VARCHAR(50) PRIMARY KEY,
    PassWord VARCHAR(50)
);
-- Thêm dữ liệu vào bảng tbKhoa
INSERT INTO tbKhoa (MaKhoa, TenKhoa) VALUES 
(1, 'Công nghệ thông tin'),
(2, 'Kinh tế'),
(3, 'Ngôn ngữ Anh');

-- Thêm dữ liệu vào bảng tbChinhSach
INSERT INTO tbChinhSach (MaCS, TenCS, CheDo) VALUES 
(1, 'Chính sách học bổng', 'Miễn giảm học phí 100%'),
(2, 'Chính sách hỗ trợ', 'Hỗ trợ 50% học phí cho sinh viên khó khăn'),
(3, 'Chính sách tài trợ', 'Tài trợ 100% học phí cho sinh viên xuất sắc');

-- Thêm dữ liệu vào bảng tbLop
INSERT INTO tbLop (MaLop, TenLop, MaKhoa) VALUES 
(101, 'CNTT01', 1),
(102, 'CNTT02', 1),
(201, 'KT01', 2),
(301, 'NN01', 3);

-- Thêm dữ liệu vào bảng tbSinhVien
INSERT INTO tbSinhVien (MaSV, Ten, GioiTinh, NgaySinh, SDT, DiaChi, MaCS, MaLop) VALUES 
(1, 'Nguyễn Văn A', 'Nam', '2000-01-01', '0123456789', 'Hà Nội', 1, 101),
(2, 'Trần Thị B', 'Nữ', '2001-02-02', '0987654321', 'Hải Phòng', 2, 102),
(3, 'Lê Văn C', 'Nam', '2002-03-03', '0345678912', 'Đà Nẵng', 3, 201);

-- Thêm dữ liệu vào bảng tbGiaoVien
INSERT INTO tbGiaoVien (MaGV, TenGV, NgaySinh, GioiTinh, DiaChi) VALUES 
(1, 'Phạm Văn D', '1980-04-04', 'Nam', 'TP HCM'),
(2, 'Nguyễn Thị E', '1975-05-05', 'Nữ', 'Hà Nội'),
(3, 'Lê Văn F', '1985-06-06', 'Nam', 'Đà Nẵng');

-- Thêm dữ liệu vào bảng tbMonHoc
INSERT INTO tbMonHoc (MaMH, TenMH, SoTiet, MaGV) VALUES 
(101, 'Lập trình Java', 45, 1),
(102, 'Kinh tế vi mô', 30, 2),
(103, 'Tiếng Anh giao tiếp', 60, 3);

-- Thêm dữ liệu vào bảng tbDiem
INSERT INTO tbDiem (MaSV, MaMH, Diem) VALUES 
(1, 101, 8.5),
(2, 102, 7.0),
(3, 103, 9.0),
(1, 102, 6.5),
(2, 101, 8.0);

-- Thêm dữ liệu vào bảng tbAdmin
INSERT INTO tbAdmin (UserID, PassWord) VALUES 
('admin01', 'password123'),
('admin02', 'adminpass456');
