CREATE DATABASE dbQLDiemHocSinh;

USE dbQLHangHoa;

CREATE TABLE tbHangHoa(
	maHang NVARCHAR(10) PRIMARY KEY,
	tenHang NVARCHAR(50),
	donVi NVARCHAR(10),
	donGia DECIMAL(18,2),
	soLuong INT
);	
-- Thêm một số bản ghi mẫu vào bảng tbHangHoa
INSERT INTO tbHangHoa (maHang, tenHang, donVi, donGia, soLuong)
VALUES
    ('HH001', N'Máy tính xách tay', N'cái', 15000.00, 10),
    ('HH002', N'Thiết bị điện tử', N'cái', 5000.00, 25),
    ('HH003', N'Điện thoại thông minh', N'cái', 8000.00, 50),
    ('HH004', N'Chảo chống dính', N'cái', 300.00, 100),
    ('HH005', N'Máy giặt', N'cái', 5000.00, 5);

-- Kiểm tra dữ liệu đã được thêm
SELECT * FROM tbHangHoa;