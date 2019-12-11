
use master
drop Database QLCDFood
--Tao CSDL
create database QLCDFood
GO
use QLCDFood
GO

CREATE TABLE ADMINISTRATOR
(
	MaADMIN INT IDENTITY(1,1),
	TenDN Varchar(50),
	MatKhau Varchar(50),
	HoTenADMIN nVarchar(50),
	GioiTinh nvarchar(5),
	NgaySinh date,
	Email Varchar(50),
	DienThoai Varchar(10)
	CONSTRAINT PK_ADMINISTRATOR PRIMARY KEY(MaADMIN)
)
--drop table ADMINISTRATOR

--thêm thông tin administrator
SET IDENTITY_INSERT [dbo].[ADMINISTRATOR] ON
INSERT [dbo].[ADMINISTRATOR] ([MaADMIN], [TenDN], [MatKhau], [HoTenADMIN], [GioiTinh], [NgaySinh], [Email], [DienThoai]) VALUES (1, N'admin', N'202cb962ac59075b964b07152d234b70', N'Lê Sỹ Duy', N'Nam', '1999-03-05', N'duy5399@gmail.com', N'0338486121')
SET IDENTITY_INSERT [dbo].[ADMINISTRATOR] OFF

CREATE TABLE KHACHHANG
(
	MaKH INT IDENTITY(1,1),
	TenDN Varchar(50),
	MatKhau Varchar(50),
	HoTenKH nVarchar(50),
	GioiTinh nvarchar(5),
	NgaySinh date,
	Email Varchar(50),
	DienThoaiKH Varchar(10)
	CONSTRAINT PK_KHACHHANG PRIMARY KEY(MaKH)
)

--drop table KHACHHANG


--thêm thông tin khách hàng
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (1, N'duy123', N'202cb962ac59075b964b07152d234b70', N'Lê Sỹ Duy', N'Nam', '1999-03-05', N'duy5399@gmail.com', N'0338486121')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (2, N'ngoc123', N'202cb962ac59075b964b07152d234b70', N'Lê Nguyễn Bảo Ngọc', N'Nữ', '2012-05-23', N'ngoc2305@gmail.com', N'0338486121')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (3, N'hieu123', N'202cb962ac59075b964b07152d234b70', N'Tăng Trung Hiếu', N'Nam', '1999-08-21', N'tangtrunghieu99@gmail.com', N'0921156997')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (4, N'dong123', N'202cb962ac59075b964b07152d234b70', N'Lê Văn Đông', N'Nam', '1999-08-25', N'dongkun111@gmail.com', N'0363885338')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (5, N'hoai123', N'202cb962ac59075b964b07152d234b70', N'Trần Ngọc Hoài', N'Nam', '1999-03-16', N'tranhoai01255622@gmail.com', N'0857085622')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (6, N'bao123', N'202cb962ac59075b964b07152d234b70', N'Phan Trần Hoài Bảo', N'Nam', '1999-04-18', N'hackerbv1999@gmail.com', N'0328702392')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (7, N'hoang123', N'202cb962ac59075b964b07152d234b70', N'Nguyễn Văn Hoàng', N'Nam', '1999-11-22', N'nguyenhoang41911@gmail.com', N'0962753060')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (8, N'nancy', N'202cb962ac59075b964b07152d234b70', N'Nancy', N'Nữ', '2000-04-13', N'nancy@gmail.com', N'1000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (9, N'yoona', N'202cb962ac59075b964b07152d234b70', N'Yoona', N'Nữ', '1990-05-30', N'yoona@gmail.com', N'2000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (10, N'hani', N'202cb962ac59075b964b07152d234b70', N'Hani', N'Nữ', '1992-05-01', N'hani@gmail.com', N'3000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (11, N'jisoo', N'202cb962ac59075b964b07152d234b70', N'Jisoo', N'Nữ', '1995-01-03', N'jisoo@gmail.com', N'4000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (12, N'tzuyu', N'202cb962ac59075b964b07152d234b70', N'Tzuyu', N'Nữ', '1999-06-14', N'tzuyu@gmail.com', N'5000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (13, N'lisa', N'202cb962ac59075b964b07152d234b70', N'Lisa', N'Nữ', '1997-03-27', N'lisa@gmail.com', N'6000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (14, N'jennie', N'202cb962ac59075b964b07152d234b70', N'Jennie', N'Nữ', '1996-01-16', N'jennie@gmail.com', N'7000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (15, N'taeyeon', N'202cb962ac59075b964b07152d234b70', N'Taeyeon', N'Nữ', '1989-03-09', N'taeyeon@gmail.com', N'8000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (16, N'jessica', N'202cb962ac59075b964b07152d234b70', N'Jessica', N'Nữ', '1989-04-18', N'jessica@gmail.com', N'9000000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (17, N'irene', N'202cb962ac59075b964b07152d234b70', N'Irene', N'Nữ', '1991-03-29', N'irene@gmail.com', N'1100000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (18, N'qri', N'202cb962ac59075b964b07152d234b70', N'Qri', N'Nữ', '1986-12-12', N'qri@gmail.com', N'1200000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (19, N'naeun', N'202cb962ac59075b964b07152d234b70', N'Naeun', N'Nữ', '1994-02-10', N'naeun@gmail.com', N'1300000000')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenDN], [MatKhau], [HoTenKH], [GioiTinh], [NgaySinh], [Email], [DienThoaiKH]) VALUES (20, N'jiyeon', N'202cb962ac59075b964b07152d234b70', N'Jiyeon', N'Nữ', '1993-06-07', N'jiyeon@gmail.com', N'1400000000')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF

CREATE TABLE NHANVIEN
(
	MaNV INT IDENTITY(1,1),
	HoTenNV nVarchar(50),
	ViTri nVarchar(50),
	NgayVaoLam date,
	GioiTinh nvarchar(5),
	NgaySinh date,
	Email Varchar(50),
	DienThoaiNV Varchar(10)
	CONSTRAINT PK_NHANVIEN PRIMARY KEY(MaNV)
)

--drop table NHANVIEN

--thêm thông tin nhân viên
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (1, N'Lê Sỹ Duy', N'Bếp trưởng', '2019-01-01', N'Nam', '1999-03-05', N'duy5399@gmail.com', N'0338486121')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (2, N'Lê Nguyễn Bảo Ngọc', N'Bếp phó', '2019-01-01', N'Nữ', '2012-05-23', N'ngoc2305@gmail.com', N'0338486121')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (3, N'Tăng Trung Hiếu', N'Phục vụ', '2019-02-02', N'Nam', '1999-08-21', N'tangtrunghieu99@gmail.com' , N'0921156997')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (4, N'Trần Ngọc Hoài', N'Phục vụ', '2019-02-02', N'Nam', '1999-03-16', N'tranhoai01255622@gmail.com' , N'0857085622')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (5, N'Phan Trần Hoài Bảo', N'Bảo vệ', '2019-03-03', N'Nam', '1999-04-18', N'hackerbv1999@gmail.com' , N'0328702392')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (6, N'Lê Văn Đông', N'Bảo vệ', '2019-03-03', N'Nam', '1999-08-25', N'dongkun111@gmail.com' , N'0363885338')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (7, N'Nguyễn Văn Hoàng', N'Bảo vệ', '2019-03-03', N'Nam', '1999-11-22', N'nguyenhoang41911@gmail.com' , N'0962753060')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (8, N'Eimi Fukada', N'Thư kí', '2019-01-01', N'Nữ', '1998-03-18', N'fukada@gmail.com' , N'0000000001')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (9, N'Yua Mikami', N'Thư kí', '2019-01-01', N'Nữ', '1993-08-16', N'mikami@gmail.com' , N'0000000002')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (10, N'Ai Uehara', N'Thư kí', '2019-01-01', N'Nữ', '1992-11-12', N'uehara@gmail.com' , N'0000000003')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (11, N'Miku Ohashi', N'Thư kí', '2019-01-01', N'Nữ', '1987-12-24', N'ohashi@gmail.com' , N'0000000004')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (12, N'Kana Momonogi', N'Thư kí', '2019-01-01', N'Nữ', '1998-12-24', N'momonogi@gmail.com' , N'0000000005')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (13, N'Yuu Shinoda', N'Thư kí', '2019-01-01', N'Nữ', '1998-07-21', N'shinoda@gmail.com' , N'0000000006')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (14, N'Kana Momonogi', N'Thư kí', '2019-01-01', N'Nữ', '1998-12-24', N'momonogi@gmail.com' , N'0000000007')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (15, N'Asahi Mizuno', N'Thư kí', '2019-01-01', N'Nữ', '1990-11-12', N'mizuno@gmail.com' , N'0000000008')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (16, N'Emiri Suzuhara', N'Thư kí', '2019-01-01', N'Nữ', '1994-04-20', N'suzuhara@gmail.com' , N'0000000009')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (17, N'Erika Momotani', N'Thư kí', '2019-01-01', N'Nữ', '1994-06-15', N'momotani@gmail.com' , N'0000000010')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [ViTri], [NgayVaoLam], [GioiTinh], [NgaySinh], [Email], [DienThoaiNV]) VALUES (18, N'Rola Takizawa', N'Thư kí', '2019-01-01', N'Nữ', '1992-06-04', N'momotani@gmail.com' , N'0000000011')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF

CREATE TABLE CHUDE
(
	MaCD varchar(10),
	TenChuDe nvarchar(50) NOT NULL,
	CONSTRAINT PK_CHUDE PRIMARY KEY(MaCD)
)

INSERT [dbo].[CHUDE] ([MaCD], [Tenchude]) VALUES ('KR', N'Món ăn Hàn Quốc')
INSERT [dbo].[CHUDE] ([MaCD], [Tenchude]) VALUES ('JP', N'Món ăn Nhật Bản')
INSERT [dbo].[CHUDE] ([MaCD], [Tenchude]) VALUES ('DRINK', N'Thức uống')


CREATE TABLE MONAN
(
	MaMonAn INT IDENTITY(1,1),
	TenMonAn NVARCHAR(100) NOT NULL,
	MaCD varchar(10),
	MoTa NTEXT,
	DonGia MONEY CHECK (DonGia>=0),
	HinhMinhHoa VARCHAR(50),
	NgayCapNhat SMALLDATETIME,
	SoLuongBan INT CHECK(SoLuongBan>=0),
	CONSTRAINT PK_MONAN PRIMARY KEY(MaMonAn)
)
ALTER TABLE MONAN ADD CONSTRAINT FK_MONAN_CHUDE FOREIGN KEY (MaCD) REFERENCES CHUDE(MaCD)

--drop table MONAN
SET IDENTITY_INSERT [dbo].[MONAN] ON
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (1, N'GIMBAB', 'KR', N'Kimbap hoặc gimbap (hangul: 김밥) được làm bằng cơm và các thành phần khác nhau cuộn trong lá rong biển khô (nori).Thường ăn trong những buổi dã ngoại hoặc các sự kiện ngoài trời, hoặc là trong các bữa ăn trưa nhẹ.', 50000, '/Images/doanHanQuoc/gimbab2.jpg', '2019-11-01', 100 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (2, N'BULGOGI', 'KR', N'Bulgogi (hangul: 불고기) được chế biến từ thịt lưng của bò được xắt lát mỏng hoặc từ các loại thịt bò xắt lát khác. Thịt được ướp với một hỗn hợp của nước tương, đường, dầu mè, tỏi và các gia vị khác như hành lá, hoặc nấm, đặc biệt là nấm nút trắng hoặc nấm hương.', 100000, '/Images/doanHanQuoc/bulgogi1.jpg', '2019-11-01', 1300 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (3, N'TOKBOKKI', 'KR', N'Tokbokki (Tteokbokki) là món bánh gạo truyền thống của Hàn Quốc, ngoài ra còn là một món ăn nhanh bình dân thường bán ở các quầy hàng ven đường (pojangmacha). Nó có nguồn gốc từ món tteok jjim (một món ăn cung đình làm từ bánh dày thái mỏng, thịt, trứng và gia vị rồi nướng lên).', 50000, '/Images/doanHanQuoc/tokbokki1.jpg', '2019-11-01', 700 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (4, N'KIMCHI', 'KR', N'Kim chi (Hangeul: 김치) là một trong những món dưa muối truyền thống phổ biến nhất của người Hàn Quốc. Món ăn này được làm bằng cách lên men từ các loại rau củ (chủ yếu là cải thảo và cải bắp) và ớt, có mùi thơm nồng và vị chua cay.', 50000, '/Images/doanHanQuoc/kimchi1.jpg', '2019-11-01', 140 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (5, N'JAJANGMYEON', 'KR', N'Jajangmyeon (hangul: 자장면) là món mì xào của Hàn Quốc. Nguyên liệu để làm Jajangmyeon là sợi mì (làm từ bột mì), tương đen (thứ tương đặc chunjang), thịt và rau cắt nhỏ, tương mùa xuân - nước tương đặc làm từ đậu nành rang và caramel, hành tây thái hạt lựu, thịt xay hoặc hải sản băm nhỏ, và các thành phần khác.', 70000, '/Images/doanHanQuoc/jajangmyeon2.jpg', '2019-11-01', 1000 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (6, N'SUNDUBU-JJIGAE', 'KR', N'Sundubu-jjigae (순두부찌개) hoặc đậu phụ hầm mềm là một jjigae trong ẩm thực Hàn Quốc. Các món ăn được làm với đậu phụ mềm tươi, rau, đôi khi nấm, hành tây, hải sản tùy chọn, thịt tùy chọn, và gochujang hoặc gochu garu', 50000, '/Images/doanHanQuoc/sundubu-jjigae2.jpg', '2019-11-01', 900 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (7, N'BIBIMBAP', 'KR', N'Bibimbap (비빔밥)là một món ăn Triều Tiên, có nghĩa là "cơm trộn". Thành phần chính của món ăn này là cơm, đặt ở trên là namul (rau xào, tuỳ loại theo mùa) và tương ớt Kochuchang. Các thành phần bổ sung phổ biến là trứng sống hoặc rán và thịt thái mỏng (thường là thịt bò).', 60000, '/Images/doanHanQuoc/bibimbap1.jpg', '2019-11-01', 560 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (8, N'SEOLLEONGTANG', 'KR', N'Seolleongtang (설렁탕) hoặc súp xương bò là một loại nước dùng Hàn Quốc được làm từ xương bò, thịt ức và các vết cắt khác. Gia vị thường được thực hiện tại bàn theo sở thích cá nhân bằng cách thêm muối, hạt tiêu đen xay, ớt đỏ, tỏi băm hoặc hành lá xắt nhỏ.', 95000, '/Images/doanHanQuoc/seolleongtang1.jpg', '2019-11-01', 500 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (9, N'SUSHI', 'JP', N'Sushi (すし) là món ăn truyền thống của người Nhật, được làm từ cơm trộn giấm kết hợp với các loại thịt, cá, hải sản và rau củ quả tươi.', 50000, '/Images/doanNhatBan/sushi2.jpg', '2019-11-01', 900 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (10, N'KAISEKI RYORI', 'JP', N'Kaiseki Ryori (懐 石) là tên gọi của một bữa ăn truyền thống được coi là tinh tế và phức tạp nhất trong nghệ thuật ẩm thực Nhật Bản. Kaiseki Ryori sử dụng nguyên liệu theo mùa chủ yếu gồm rau, cá với rong biển và nấm và có hương vị tinh tế đặc trưng.', 125000, '/Images/doanNhatBan/kaiseki_ryori1.jpg', '2019-11-01', 1500 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (11, N'SASHIMI', 'JP', N'Sashimi (刺身|さしみ)là một món ăn truyền thống Nhật Bản mà thành phần chính là các loại hải sản tươi sống được cắt thành từng lát mỏng có chiều rộng khoảng 2.5 cm, chiều dài 4 cm và dày chừng 0.5 cm, ăn cùng với các loại nước chấm như xì dầu, tương, wasabi,...', 50000, '/Images/doanNhatBan/sashimi1.jpg', '2019-11-01', 800 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (12, N'RAMEN', 'JP', N'Ramen (ラーメン) là một món ăn của Nhật Bản. Nó bao gồm Mỳ sợi, phục vụ cùng một loại nước dùng từ thịt - hoặc (đôi khi) từ cá, thường thêm hương vị từ nước tương hoặc miso, và bày thêm đồ ăn kèm như thịt lợn thái lát, rong biển sấy khô, menma, và hành lá.', 50000, '/Images/doanNhatBan/ramen1.jpg', '2019-11-01', 900 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (13, N'TAKOYAKI', 'JP', N'Takoyaki (たこ焼き, 蛸焼) là một loại bánh nướng ăn nhẹ có hình cầu làm bằng bột mì với nhân bạch tuộc, nướng trong chảo takoyakiki. Thành phần chính của nhân bánh là bạch tuộc băm hay thái hạt lựu có thể độn thêm một số thứ khác và rắc thêm một số gia vị cũng như còn được tẩm với nước sốt tùy vào công thức khác nhau.', 50000, '/Images/doanNhatBan/takoyaki2.jpg', '2019-11-01', 1200 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (14, N'UNAGI', 'JP', N'Unagi (ウナギ) là món thịt lươn nước ngọt nướng. Những miếng lươn vàng óng, mềm mại, và ngọt dịu nổi tiếng khắp xứ sở Anh đào.', 45000, '/Images/doanNhatBan/unagi2.jpg', '2019-11-01', 500 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (15, N'TONKATSU', 'JP', N'Tonkatsu ( 豚カ,とんか) hay "thịt lợn cốt lết", là một món ăn Nhật Bản bao gồm một miếng thịt lợn chiên giòn tẩm bột, đây là một món ăn phổ biến ở Nhật, chúng thuộc tuýp thịt chiên xù.', 50000, '/Images/doanNhatBan/tonkatsu1.jpg', '2019-11-01', 800 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (16, N'YAKITORI', 'JP', N'Yakitori (焼き鳥) là một món thịt gà nướng bằng xiên và xâu lại với nhau trên que trong ẩm thực Nhật Bản, ăn kèm với nước sốt Tare.', 45000, '/Images/doanNhatBan/yakitori1.jpeg', '2019-11-01', 700 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (17, N'SMOOTHIES', 'DRINK', N'SMOOTHIES CHANH, SMOOTHIES DÂU TƯƠI', 45000, '/Images/thucuong/smoothies2.jpg', '2019-11-01', 500 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (18, N'AURORA SERIES', 'DRINK', N'DẢI NGÂN HÀ, ÁNH BÌNH MINH', 50000, '/Images/thucuong/thealley1.jpg', '2019-11-01', 1000 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (19, N'FRUIT TEA', 'DRINK', N'TRÀ XANH CAM CHANH, TRÀ XANH DÂU TƯƠI', 45000, '/Images/thucuong/fruit_tea1.jpg', '2019-11-01', 700 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (20, N'COFFEE', 'DRINK', N'PHIN SỮA ĐÁ, PHIN ĐEN ĐÁ', 45000, '/Images/thucuong/coffee1.jpg', '2019-11-01', 500 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (21, N'MILK TEA', 'DRINK', N'TRÀ SỮA TRÂN CHÂU ĐEN, TRÀ SỮA MATCHA ĐẬU ĐỎ', 45000, '/Images/thucuong/milk_tea2.jpg', '2019-11-01', 900 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (22, N'LATTE', 'DRINK', N'MANGO MATCHA LATTE, STRAWBERRY EARL GREY LATTE', 45000, '/Images/images/latte2.jpg', '2019-11-01', 1000 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (23, N'SODA MOJITO', 'DRINK', N'SODA TRÁI CÂY, MOJITO', 45000, '/Images/images/soda_mojito1.jpg', '2019-11-01', 950 )
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [MaCD], [MoTa], [DonGia], [HinhMinhHoa], [NgayCapNhat], [SoLuongBan]) VALUES (24, N'WINE', 'DRINK', N'RƯỢU CHARDONNAY, RƯỢU CHENIN BLANC', 45000, '/Images/images/ruou-van1.jpg', '2019-11-01', 900 )
SET IDENTITY_INSERT [dbo].[MONAN] OFF

CREATE TABLE DONDATHANG
(
	SoDH INT IDENTITY(1,1),
	MaKH INT,
	NgayDH SMALLDATETIME,
	TriGia Money Check (TriGia>0),
	DaGiao Bit Default 0,
	NgayGiaoHang SMALLDATETIME,
	TenNguoiNhan nvarchar(50),
	DiaChiNhan nvarchar(50),
	DienThoaiNhan Varchar(15),
	HTThanhToan nvarchar(50),
	HTGiaoHang  nvarchar(50),
	CONSTRAINT PK_DONDATHANG PRIMARY KEY(SoDH)
)
ALTER TABLE DONDATHANG ADD CONSTRAINT FK_DONDATHANG_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
GO
--drop table DONDATHANG

CREATE TABLE CTDATHANG
(
	SoDH INT,
	MaMonAn INT,
	SoLuong Int Check(SoLuong>0),
	DonGia Decimal(9,2) Check(DonGia>=0),
	ThanhTien AS SoLuong*DonGia ,
	CONSTRAINT FK_CTDATHANG_DONDATHANG FOREIGN KEY (SoDH) REFERENCES DONDATHANG(SoDH),
	CONSTRAINT FK_CTDATHANG_MONAN FOREIGN KEY (MaMonAn) REFERENCES MONAN(MaMonAn),
	CONSTRAINT PK_CTDATHANG PRIMARY KEY(SoDH,MaMonAn)
)
GO
--drop table CTDATHANG

CREATE TABLE GOPY
(
	MaGopY INT IDENTITY(1,1),
	MaKH int,
	NgayGopY date,
	TieuDe nvarchar(100),
	NoiDung ntext,
	CONSTRAINT PK_GOPY PRIMARY KEY(MaGopY)
)
ALTER TABLE GOPY ADD CONSTRAINT FK_GOPY_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

--drop table GOPY
SET IDENTITY_INSERT [dbo].[GOPY] ON
INSERT [dbo].[GOPY] ([MaGopY], [MaKH], [NgayGopY] ,[TieuDe], [NoiDung]) VALUES (1, 8, '2019-11-10' ,N'Anh Bếp trưởng đẹp trai quá!!!', N'Anh Duy "Bếp trưởng" trông thập đẹp trai và phong độ, em yêu anh <3' )
INSERT [dbo].[GOPY] ([MaGopY], [MaKH], [NgayGopY] ,[TieuDe], [NoiDung]) VALUES (2, 9, '2019-11-10' ,N'Anh Bếp trưởng nấu ăn quá!!!', N'Anh Duy "Bếp trưởng" nấu ăn thật ngon, em yêu anh x2 <3' )
INSERT [dbo].[GOPY] ([MaGopY], [MaKH], [NgayGopY] ,[TieuDe], [NoiDung]) VALUES (3, 12, '2019-11-10' ,N'Anh Bếp trưởng ga lăng quá!!!', N'Hôm nay bạn nhân viên vô tình làm đổ nước vào em khi đang bê ra cho khách, nhưng anh Duy "Bếp trưởng" đã nhanh chóng che cho em, để em không bị ướt, em yêu anh x3 <3' )
INSERT [dbo].[GOPY] ([MaGopY], [MaKH], [NgayGopY] ,[TieuDe], [NoiDung]) VALUES (4, 13, '2019-11-10' ,N'Món ăn quá ngon!!!', N'Bếp trưởng nấu quá ngon, em thèm, em yêu anh <3' )
SET IDENTITY_INSERT [dbo].[GOPY] OFF

CREATE TABLE DANHGIAMONAN
(
	MaKH INT,
	MaMonAn int,
	Rate int check(rate>0),
	NoiDungDG ntext,
	NgayDG SMALLDATETIME,
	CONSTRAINT PK_DANHGIAMONAN PRIMARY KEY(MaKH,MaMonAn)
)
ALTER TABLE DANHGIAMONAN ADD CONSTRAINT FK_DANHGIAMONAN_KHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
--drop table DANHGIAMONAN
GO
INSERT [dbo].[DANHGIAMONAN] ([MaKH], [MaMonAn], [Rate] ,[NoiDungDG], [NgayDG]) VALUES (1, 3, 5 ,N'Món ăn ngon', '2019-11-10' )
INSERT [dbo].[DANHGIAMONAN] ([MaKH], [MaMonAn], [Rate] ,[NoiDungDG], [NgayDG]) VALUES (9, 3, 3 ,N'Tạm được', '2019-11-10' )
INSERT [dbo].[DANHGIAMONAN] ([MaKH], [MaMonAn], [Rate] ,[NoiDungDG], [NgayDG]) VALUES (10, 3, 4 ,N'Ngon lắm', '2019-11-10' )
