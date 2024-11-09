USE QLThuVien;
GO

-- Dữ liệu cho bảng BANGCAP
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES (1, N'TIẾN SĨ');
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES (2, N'THẠC SĨ');
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES (3, N'ĐẠI HỌC');
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES (4, N'CAO ĐẲNG');
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES (5, N'TRUNG CẤP');
GO

-- Dữ liệu cho bảng NHANVIEN
INSERT INTO NHANVIEN (MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap)
VALUES (1, N'PHẠM MINH VŨ', '1980-01-24', N'163/30 Thành Thái F.14 Q.10 TPHCM', '0905646162', 1);
INSERT INTO NHANVIEN (MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap)
VALUES (2, N'NGUYỄN MINH THÀNH', '1983-04-05', N'41/4 CALMETTE Q1 TPHCM', '0908373612', 2);
INSERT INTO NHANVIEN (MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap)
VALUES (3, N'NGUYỄN HÀ MY', '1985-04-13', N'178 NAM KỲ KHỞI NGHĨA Q4 TPHCM', '0908783274', 3);
GO

-- Dữ liệu cho bảng DOCGIA
INSERT INTO DOCGIA (MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo)
VALUES (1, N'NGUYỄN HOÀNG MINH', '1990-02-23', N'41/4 CALMETTE Q1 TPHCM', N'hoangminh@yahoo.com', '2000-12-30', '2012-12-30', 0);
INSERT INTO DOCGIA (MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo)
VALUES (2, N'TRẦN VĂN CHÂU', '1992-08-29', N'TRẦN HƯNG ĐẠO Q1 TPHCM', N'vanchau@yahoo.com', '2001-11-22', '2013-11-22', 0);
INSERT INTO DOCGIA (MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo)
VALUES (3, N'NGUYỄN HOÀNG NAM', '1980-02-21', N'4 TRẦN ĐÌNH HƯNG Q1 TPHCM', N'hoangmNAM@yahoo.com', '2001-12-22', '2012-12-30', 150000);
INSERT INTO DOCGIA (MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo)
VALUES (4, N'TRẦN THANH PHÚC', '1993-08-19', N'TRƯƠNG ĐỊNH Qtb TPHCM', N'thanhphuc@yahoo.com', '2001-08-09', '2013-11-22', 50000);
GO

-- Dữ liệu cho bảng SACH
INSERT INTO SACH (MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap)
VALUES (1, N'NHAP MON CNPM', N'PHẠM ĐÀO MINH VŨ', 2007, N'NXB THỐNG KÊ', 70000, '2008-12-18');
INSERT INTO SACH (MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap)
VALUES (2, N'KỸ THUẬT LẬP TRÌNH', N'TRẦN MINH THÁI', 2005, N'NXB GIÁO DỤC', 50000, '2006-02-12');
INSERT INTO SACH (MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap)
VALUES (3, N'CÔNG NGHỆ WEB', N'PHẠM ĐÀO MINH VŨ', 2009, N'NXB TRẺ', 90000, '2009-12-01');