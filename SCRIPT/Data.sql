use QL_HETHONGGIAONHANH
--TAIKHOAN
INSERT INTO TAIKHOAN(ID, USERNAME, PASS, LOAITK) VALUES
('TK001', 'dt1', '123456789', 1),
('TK002', 'dt2', '123456789', 1),
('TK003', 'dt3', '123456789', 1),
('TK004', 'dt4', '123456789', 1),
('TK005', 'dt5', '123456789', 1),
('TK006', 'tx1', '123456789', 2),
('TK007', 'tx2', '123456789', 2),
('TK008', 'tx3', '123456789', 2),
('TK009', 'tx4', '123456789', 2),
('TK010', 'tx5', '123456789', 2),
('TK011', 'nv1', '123456789', 3),
('TK012', 'nv2', '123456789', 3),
('TK013', 'nv3', '123456789', 3),
('TK014', 'nv4', '123456789', 3),
('TK015', 'nv5', '123456789', 3),
('TK016', 'kh1', '123456789', 4),
('TK017', 'kh2', '123456789', 4),
('TK018', 'kh3', '123456789', 4),
('TK019', 'kh4', '123456789', 4),
('TK020', 'kh5', '123456789', -1)
GO
--KHUVUC
INSERT INTO [KHUVUC] VALUES ('kv1', N'Quận 9'),
							('kv2', N'Quận 1'),
							('kv3', N'Quận 12'),
							('kv4', N'Quận 6'),
							('kv5', N'Quận 7')

-- KHACHHANG
insert into khachhang values('KH001','TK016','Nguyen Van A','0988823451','731 Tran Hung Dao, Q5, TpHCM','nguyenvana123@gmail.com')
insert into khachhang values('KH002','TK017','Tran Ngoc Han','090825647','23/5 Nguyen Trai, Q5, TpHCM','han2004986ngoc@gmail.com')
insert into khachhang values('KH003','TK018','Tran Ngoc Linh','093877666','45 Nguyen Canh Chan, Q1, TpHCM','tranngoclinh333123@gmail.com')
insert into khachhang values('KH004','TK019','Tran Minh Long','091732476','50/34 Le Dai Hanh, Q10, TpHCM','longvictory444@gmail.com')
insert into khachhang values('KH005','TK020','Le Nhat Minh','081284608','34 Truong Dinh, Q3, TpHCM','minhnhatle2005@gmail.com')


--DOITAC

insert dbo.DOITAC VALUES('DT001','TK001','826','yzh44188@nezid.com','American Blues',N'Lê văn thanh',N'Hồ chí minh','',N'ăn vặt',N'44 trần hưng đạo, hà nội','093736644','3','9')
insert dbo.DOITAC VALUES('DT002','TK002','756','cry01415@xcoxc.com','Sew In Style',N'Nguyễn hưu thọ',N'Cần thơ','',N'ăn vặt',N'22 trần hưng đạo, hồ chí minh','096667552','2','5')
insert dbo.DOITAC VALUES('DT003','TK003','623','gfs24592@xcoxc.com','First Date',N'Hoàng Xuân đức',N'Hồ chí minh','',N'đồ nướng',N'33 lê thị riêng, hà nội','099982734','6','4')
insert dbo.DOITAC VALUES('DT004','TK004','983','dcf11459@cdfaq.com','Spotlight on Style',N'Tố duy thanh',N'Hà nội','',N'Hải sản',N'178 hữu thạnh, hà nội','093274803','3','8')
insert dbo.DOITAC VALUES('DT005','TK005','834','jqz39886@nezid.com','Gossippa',N'Lê văn long',N'Đà nẵng','',N'Hải sản',N'44 điện biên phủ, hà nội','089968578','4','6')

--CUAHANG

insert dbo.CUAHANG VALUES('001','DT001','Soul spectrum',N'11 lê lợi, Quận 9','20220518 00:00:00', ' ', 'kv1')

insert dbo.CUAHANG VALUES('002','DT001','Rose ne',N'212 Nguyễn Trãi Quận 1','20210102 00:00:00',' ','kv2')

insert dbo.CUAHANG VALUES('002','DT002','Frost Goddess',N'55 kinh dương vương, Quận 12','20220102 00:00:00',' ','kv3')

insert dbo.CUAHANG VALUES('003','DT003','Street Swing',N'22 hoàng văn thụ, Quận 6','20220518 00:00:00',' ','kv4')

insert dbo.CUAHANG VALUES('004','DT004','Apple Blossoms',N'77 Thành thái, Quận 7','20211203 00:00:00',' ','kv5')

insert dbo.CUAHANG VALUES('005','DT005','Apple Blossoms',N'33 cách mạng tháng 8, Quận 9','20220722 00:00:00',' ','kv1')


--MONAN
insert into MONAN values(N'Cơm gà',N'Gà được ướp',45.000,N'Đã xử lý')
insert into MONAN values(N'Cháo gà',N'Cháo gà ta',35.000,N'Đã xử lý')
insert into MONAN values(N'Cơm chiên',N'Có kèm sốt',50.000,N'Đã xử lý')
insert into MONAN values(N'Phở bò',N'Bò Mỹ',50.000,N'Đã xử lý')
insert into MONAN values(N'Bún riêu',N'Có giò',50.000,N'Đã xử lý')

--TUYCHONMON

insert TUYCHONMON values(N'Cơm gà','1')
insert TUYCHONMON values(N'Cháo gà','2')
insert TUYCHONMON values(N'Cơm chiên','3')

--THUCDON

insert dbo.THUCDON VALUES('001','DT001',N'Cơm gà',10)

insert dbo.THUCDON VALUES('001','DT001',N'Cháo gà',100)

insert dbo.THUCDON VALUES('002','DT002',N'Cháo gà',5)

insert dbo.THUCDON VALUES('002','DT001',N'Bún riêu',80)

insert dbo.THUCDON VALUES('002','DT002',N'Bún riêu',100)

insert dbo.THUCDON VALUES('003','DT003',N'Cơm chiên',15)

insert dbo.THUCDON VALUES('004','DT004',N'Phở bò',30)

insert dbo.THUCDON VALUES('005','DT005',N'Bún riêu',100)


-- NHANVIEN---
insert dbo.NhanVien values('241782293', 'TK011',N'Nguyen Nhu Nhut','092734567', N'111 lê đình cẩn,thủ đức','nhutnh@gmail.com')
insert dbo.NhanVien values('257438902', 'TK012',N'Le Thi Phi Yen','098756739', N'464 kinh dương vương,Thủ Đức','lethiphi@gmail.com')
insert dbo.NhanVien values('397354429', 'TK013',N'Nguyen Van B','097047388', N'11 xô viết nghệ tĩnh','vanb122@gmail.com')
insert dbo.NhanVien values('232763452', 'TK014',N'Ngo Thanh Tuan','091375849', N',1100 kha vạn cân,Thủ Đức','ngothanh@gmail.com')
insert dbo.NhanVien values('193635733', 'TK015',N'Nguyen Thi Truc Thanh','091859037', N'444 hoàng văn thụ,Thủ Đức','tructhanh@gmail.com')

--HOPDONG--
insert dbo.HOPDONG values('HD001','20220918 00:00:00','20230222 00:00:00','050776527354',150.000,'DT001','826','241782293',1)
insert dbo.HOPDONG values('HD002','20220918 00:00:00','20230911 00:00:00','046382642222',240.000,'DT002','756','257438902',1)
insert dbo.HOPDONG values('HD003','20220918 00:00:00','20240409 00:00:00','098886353422',450.000,'DT003','623','397354429',0)
insert dbo.HOPDONG values('HD004','20220918 00:00:00','20240218 00:00:00','000753431411',20.000,'DT004','983','232763452',1)
insert dbo.HOPDONG values('HD005','20220918 00:00:00','20230818 00:00:00','007524252622',170.000,'DT005','834','193635733',0)

--TAIXE--
insert dbo.TAIXE values('241782293', 'TK006',N'Chu mạnh trinh','083647462','77 Trần hưng đạo,quận 5',NULL,'58596','078645383',150000, 'kv1')
insert dbo.TAIXE values('257438902', 'TK007',N'Nguyễn hoàng thanh','084635372','99 lê lợi ,quận 4','thanhhoang@gmail.com','59522','02627833',180000,'kv2')
insert dbo.TAIXE values('397354429', 'TK008',N'Hồ ngọc hiểu','093863563','99 bến vân đồn ,quận 4',NULL,'52333','058873644',300000, 'kv3')
insert dbo.TAIXE values('232763452', 'TK009',N'Lương thanh minh','083736833','119 hà huy tập ,quận 10','Minhthanh@gmail.com','44555','056355333',450000, 'kv4')
insert dbo.TAIXE values('256478443', 'TK010',N'Lê thái Văn','087763553','35 đường 3/2 ,quận 10',NULL,'22678','0436555333',340000, 'kv5')



--DONHANG--
insert dbo.DONHANG values('DH001','20210618 00:00:00','Momo',N'06 võ thị sáu, quận bình thạnh',30.000,40.000,0,N'Chờ xác nhận','20210620 00:00:00','KH001','241782293', 'kv1')
insert dbo.DONHANG values('DH002','20221202 00:00:00','COD',N'112 lê van chánh, quận bình chánh',19.2,22.000,0,N'Chờ xác nhận','20211209 00:00:00','KH002','257438902', 'kv2')
insert dbo.DONHANG values('DH003','20210407 00:00:00','ZaloPay',N'500 hoàng văn thụ, quận 9',22.000,25.1,0,N'Đang giao','20220417 00:00:00','KH003','397354429', 'kv3')
insert dbo.DONHANG values('DH004','20220109 00:00:00','Momo',N'115 võ thị sáu, quận bình 7',21.500,24.000,0,N'Đã giao','20210519 00:00:00','KH004','232763452', 'kv4')
insert dbo.DONHANG values('DH005','20221224 00:00:00','COD',N'15 Hai bà trưng, quận bình 8',29.000,29.000,0,N'Đang chuẩn bị','20210226 00:00:00','KH005','256478443', 'kv5')
insert dbo.DONHANG values('DH006','20210618 00:00:00','Momo',N'06 võ thị sáu, quận bình thạnh',30.000,40.000,0,N'Đã xác nhận','20210620 00:00:00','KH004','241782293', 'kv1')
insert dbo.DONHANG values('DH007','20210618 00:00:00','Momo',N'06 võ thị sáu, quận bình thạnh',30.000,40.000,0,N'Đã giao','20210620 00:00:00','KH004','241782293', 'kv1')
--CT_DONHANG
insert dbo.CT_DONHANG VALUES('DH001','001','DT001',N'Cơm gà',6, NULL)
insert dbo.CT_DONHANG VALUES('DH001','001','DT001',N'Cháo gà',2, NULL)
insert dbo.CT_DONHANG VALUES('DH002','002','DT002',N'Cháo gà',3, NULL)
insert dbo.CT_DONHANG VALUES('DH003','002','DT002',N'bún riêu',5, NULL)
insert dbo.CT_DONHANG VALUES('DH004','004','DT004',N'Phở bò',3, NULL)
insert dbo.CT_DONHANG VALUES('DH005','003','DT003',N'Cơm chiên',2, NULL)
insert dbo.CT_DONHANG VALUES('DH006','001','DT001',N'Cơm gà',6, NULL)
insert dbo.CT_DONHANG VALUES('DH007','001','DT001',N'Cơm gà',6, NULL)
--PHANHOI

INSERT INTO PHANHOI(TENMON,MAKHACH,DANHGIA,BINHLUAN) VALUES
('Bún riêu','KH001','LIKE',N'Rất ngon'),
('Cháo gà','KH002','DISLIKE',N'Không ngon')

