CREATE DATABASE dbQLDiemHocSinh;

USE dbQLDiemHocSinh;

CREATE TABLE tbDiemHocSinh(
	maHocSinh NVARCHAR(10) PRIMARY KEY,
	hoTen NVARCHAR(50),
	diemToan float,
	diemViet float
);	
-- Thêm một số bản ghi mẫu vào bảng tbDiemHocSinh
INSERT INTO tbDiemHocSinh (maHocSinh, hoTen, diemToan, diemViet) VALUES 
('HS001', N'Nguyễn Văn An', 8.5, 7.0),
('HS002', N'Lê Thị Bình', 9.0, 8.5),
('HS003', N'Phạm Minh Hoàng', 7.5, 6.0),
('HS004', N'Vũ Thị Thu', 6.5, 7.5),
('HS005', N'Trần Văn Cường', 8.0, 8.0);