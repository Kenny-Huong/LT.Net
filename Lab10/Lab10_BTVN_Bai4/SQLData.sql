CREATE DATABASE dbQLChiSoCongTo;

USE dbQLChiSoCongTo;

CREATE TABLE tbCongTo(
	maCongTo NVARCHAR(10) PRIMARY KEY,
	tenChuHo NVARCHAR(50),
	soCu int,
	soMoi int,
	donGia int
);	
-- Thêm một số bản ghi mẫu vào bảng tbDiemHocSinh
INSERT INTO tbCongTo (maCongTo, tenChuHo, soCu, soMoi, donGia) VALUES 
('CT001', N'Nguyễn Văn An', 100, 150, 3000),
('CT002', N'Trần Thị Bình', 200, 250, 3000),
('CT003', N'Phạm Văn Cường', 150, 220, 3000),
('CT004', N'Lê Thị Dung', 120, 180, 3000),
('CT005', N'Vũ Văn Hoàng', 180, 240, 3000);
