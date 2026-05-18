CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(100) ,
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    DienThoai NVARCHAR(11),
    Quyen NVARCHAR(20),     -- admin / quanly / nhanvien
    NgayVaoLam DATE,
    Luong DECIMAL(18,2)
);

CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(50),
    Quyen NVARCHAR(20),
    MaNV INT,
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
CREATE  TABLE ChamCong (
    MaCC INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT ,
    Ngay DATE ,
    GioVao TIME,
    GioRa TIME,
    SoCong FLOAT DEFAULT 0,
    TrangThai NVARCHAR(50), -- Đi muộn / Đúng giờ
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) ,
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(200)
);

CREATE TABLE Category (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(100) 
);
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100) ,
    Price DECIMAL(18,2) ,
    Quantity INT ,
    CategoryID INT,
    ImagePath NVARCHAR(MAX),
    Status NVARCHAR(20) DEFAULT N'Còn hàng',

    CONSTRAINT FK_Product_Category
        FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATETIME DEFAULT GETDATE(),
    MaNV INT,
    MaKH INT,
    TotalAmount DECIMAL(18,2),
    AmountReceived DECIMAL(18,2),
    ChangeAmount DECIMAL(18,2),

    CONSTRAINT FK_Orders_NhanVien
        FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),

    CONSTRAINT FK_Orders_KhachHang
        FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);
CREATE TABLE OrderDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT ,
    ProductID INT ,
    Quantity INT ,
    UnitPrice DECIMAL(18,2) ,

    CONSTRAINT FK_OrderDetails_Orders
        FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),

    CONSTRAINT FK_OrderDetails_Product
        FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

CREATE TABLE NhaCungCap (
    MaNCC INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(200) NOT NULL,
    DienThoai NVARCHAR(15),
    DiaChi NVARCHAR(MAX)
);

CREATE TABLE PhieuNhap (
    MaPN INT IDENTITY(1,1) PRIMARY KEY,
    MaNCC INT,
    ProductID INT,
    NgayNhap DATETIME DEFAULT GETDATE(),
    SoLuongNhap INT,
    GiaNhap DECIMAL(18,2),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

INSERT INTO NhanVien VALUES
(1, N'Nguyễn Văn Admin', N'Nam', '1990-01-01', '0901111111', 'admin', '2020-01-01', 300000),
(2, N'Trần Thị Quản Lý', N'Nữ', '1995-05-10', '0902222222', 'quanly', '2021-03-01', 200000),
(3, N'Lê Văn Nhân Viên', N'Nam', '2000-09-20', '0903333333', 'nhanvien', '2023-06-01', 150000);


INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen, MaNV) VALUES
('admin', '123', 'admin', 1),
('ql01', '123', 'quanly', 2),
('nv01', '123', 'nhanvien', 3);
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen, MaNV) 
VALUES ('khachhang', '123', 'khachhang', 1);

INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
(N'Khách Lẻ', '0000000000', N'Không xác định'),
(N'Nguyễn Văn A', '0988888888', N'Hà Nội'),
(N'Trần Thị B', '0977777777', N'Hải Phòng');

INSERT INTO Category VALUES
(1, N'Đồ ăn'),
(2, N'Nước uống');

INSERT INTO Product VALUES
(1, N'Spaghetti', 10000, 100, 1, NULL, N'Còn hàng');



--===============================Nhân viên==================================
CREATE PROC sp_LoadNhanVien
AS
BEGIN
    SELECT MaNV, TenNV
    FROM NhanVien
END
GO


-- 1. Proc Lấy danh sách (Xem)
CREATE PROCEDURE sp_NhanVien_GetList
AS
BEGIN
    SELECT * FROM NhanVien;
END
GO

-- 2. Proc Thêm nhân viên
ALTER PROCEDURE sp_NhanVien_Insert
    @MaNV NVARCHAR(50), @TenNV NVARCHAR(100), @GioiTinh NVARCHAR(10), 
    @NgaySinh DATE, @DienThoai NVARCHAR(20), @Quyen NVARCHAR(50), 
    @NgayVaoLam DATE, @Luong DECIMAL(18, 2),
	@PhuCap DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, Quyen, NgayVaoLam, Luong, PhuCap)
    VALUES (@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DienThoai, @Quyen, @NgayVaoLam, @Luong, @PhuCap);
END
GO

-- 3. Proc Sửa nhân viên
ALTER PROCEDURE sp_NhanVien_Update
    @MaNV NVARCHAR(50), @TenNV NVARCHAR(100), @GioiTinh NVARCHAR(10), 
    @NgaySinh DATE, @DienThoai NVARCHAR(20), @Quyen NVARCHAR(50), 
    @NgayVaoLam DATE, @Luong DECIMAL(18, 2),
    @PhuCap DECIMAL(18, 2) -- Thêm tham số này
AS
BEGIN
    UPDATE NhanVien SET 
        TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, 
        DienThoai = @DienThoai, Quyen = @Quyen, NgayVaoLam = @NgayVaoLam, 
        Luong = @Luong, 
        PhuCap = @PhuCap -- Cập nhật giá trị cột PhuCap tại đây
    WHERE MaNV = @MaNV;
END
GO

ALTER TABLE NhanVien ADD PhuCap DECIMAL(18, 2) DEFAULT 0;

ALTER PROCEDURE sp_TongLuongThang  
    @MaNV INT = NULL  
AS  
BEGIN  
    SELECT   
        nv.MaNV,  
        nv.TenNV,  
        nv.Quyen,  
        SUM(cc.SoCong) AS TongCong,  
        ISNULL(nv.PhuCap, 0) AS PhuCap, -- Lấy giá trị phụ cấp hiển thị ra bảng
        (SUM(cc.SoCong) * nv.Luong) + ISNULL(nv.PhuCap, 0) AS TongLuong -- Công thức lương mới
    FROM NhanVien nv  
    LEFT JOIN ChamCong cc ON nv.MaNV = cc.MaNV  
    WHERE (@MaNV IS NULL OR nv.MaNV = @MaNV)  
    GROUP BY nv.MaNV, nv.TenNV, nv.Quyen, nv.Luong, nv.PhuCap; -- Đã thêm nv.PhuCap vào nhóm gộp
END;
GO

-- 4. Proc Xóa nhân viên và công (Xóa đa năng)
CREATE PROCEDURE sp_NhanVien_Delete
    @MaNV NVARCHAR(50)
AS
BEGIN
    DELETE FROM ChamCong WHERE MaNV = @MaNV;
    DELETE FROM NhanVien WHERE MaNV = @MaNV;
END
GO



-- 5. Proc Xóa lẻ chấm công
CREATE PROCEDURE sp_ChamCong_Delete
    @MaCC INT
AS
BEGIN
    DELETE FROM ChamCong WHERE MaCC = @MaCC;
END
GO

SELECT * FROM NhanVien WHERE MaNV = '987'



  --thủ tục với nhân viên------------------------------------------------------------------  
CREATE PROCEDURE sp_TimNhanVien  
    @TuKhoa NVARCHAR(100)  
AS  
BEGIN  
    SELECT *  
    FROM NhanVien  
    WHERE   
        CAST(MaNV AS NVARCHAR) LIKE '%' + @TuKhoa + '%'  
        OR TenNV LIKE N'%' + @TuKhoa + '%'  
        OR DienThoai LIKE '%' + @TuKhoa + '%'  
        OR Quyen LIKE N'%' + @TuKhoa + '%'  
END  
EXEC sp_helptext 'sp_TimNhanVien'



ALTER PROCEDURE sp_ChamCong
    @MaNV INT,
    @Ngay DATE,
    @Gio TIME, -- Thêm tham số @Gio vào đây
    @Loai NVARCHAR(10) -- VAO / RA
AS
BEGIN
    SET NOCOUNT ON;

    IF @Loai = 'VAO'
    BEGIN
        IF EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay)
        BEGIN
            RAISERROR (N'Đã chấm vào rồi!', 16, 1);
            RETURN;
        END

        INSERT INTO ChamCong (MaNV, Ngay, GioVao, TrangThai)
        VALUES (
            @MaNV,
            @Ngay,
            @Gio, 
            CASE 
                WHEN @Gio > '08:00' THEN N'Đi muộn'
                ELSE N'Đúng giờ'
            END
        );
    END

    IF @Loai = 'RA'
    BEGIN
        -- Kiểm tra xem đã chấm giờ vào chưa
        IF NOT EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioVao IS NOT NULL)
        BEGIN
            RAISERROR (N'Chưa chấm giờ vào!', 16, 1);
            RETURN;
        END

        -- Kiểm tra xem đã chấm giờ ra rồi chưa
        IF EXISTS (SELECT 1 FROM ChamCong WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioRa IS NOT NULL)
        BEGIN
            RAISERROR (N'Đã chấm giờ ra rồi!', 16, 1);
            RETURN;
        END

        UPDATE ChamCong
        SET GioRa = @Gio, 
            SoCong =
                CASE
                    WHEN GioVao <= '08:00' AND @Gio >= '17:30' THEN 1 -- Đúng giờ cả vào và ra: 1 công
                    ELSE 0.5
                END
        WHERE MaNV=@MaNV AND Ngay=@Ngay AND GioRa IS NULL;
    END
END;


-- sửa lại ràng buộc với tính năng ON DELETE CASCADE
ALTER TABLE TaiKhoan ADD MaKH INT;

ALTER TABLE TaiKhoan
ADD CONSTRAINT FK_TaiKhoan_KhachHang
FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
ON DELETE CASCADE;
GO
ALTER TABLE TaiKhoan DROP CONSTRAINT FK_TaiKhoan_KhachHang;

ALTER TABLE dbo.ChamCong
ADD CONSTRAINT FK_ChamCong_MaNV_3E52440B FOREIGN KEY (MaNV)
REFERENCES dbo.NhanVien(MaNV)
ON DELETE CASCADE;


ALTER TABLE PhieuNhap DROP CONSTRAINT FK__PhieuNhap__Produ__71D1E811;
ALTER TABLE PhieuNhap 
ADD CONSTRAINT FK_PhieuNhap_Product 
FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE;


ALTER TABLE OrderDetails DROP CONSTRAINT FK_OrderDetails_Orders;

ALTER TABLE OrderDetails 
ADD CONSTRAINT FK_OrderDetails_Orders_New 
FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE;


-- Tạo View để lấy dữ liệu in hóa đơn dễ dàng hơn
CREATE VIEW v_ChiTietHoaDon AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV, 
    kh.TenKH, 
    p.ProductName, 
    od.Quantity, 
    od.UnitPrice, 
    (od.Quantity * od.UnitPrice) AS ThanhTien, 
    o.TotalAmount
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID;


--==========================SẢN PHẨM====================================

ALTER TABLE Product 
ADD CostPrice DECIMAL(18,2) DEFAULT 0;---thêm cột giá nhập

CREATE PROC sp_LoadCategory
AS
BEGIN
    SELECT * FROM Category
END
GO

CREATE PROC sp_HienThiSanPham
AS
BEGIN
    SELECT * FROM Product
END
GO
exec sp_HienThiSanPham;

ALTER PROCEDURE sp_Product_CRUD 
    @Action NVARCHAR(10), 
    @ProductID INT = NULL,
    @ProductName NVARCHAR(200) = NULL, 
    @Price DECIMAL(18,2) = NULL,    
    @Quantity INT = NULL,        
    @CategoryID INT = NULL,      
    @ImagePath NVARCHAR(255) = NULL, 
    @Status NVARCHAR(50) = NULL        
BEGIN 
    SET NOCOUNT ON; 

    IF @Action = 'SELECT' 
    BEGIN 
        IF @ProductID IS NOT NULL 
            SELECT * FROM Product WHERE ProductID = @ProductID; 
        ELSE 
            SELECT * FROM Product; 
    END 

    -- LỆNH THÊM MỚI
    ELSE IF @Action = 'INSERT' 
    BEGIN 
        INSERT INTO Product (ProductID, ProductName, Price, Quantity, CategoryID, ImagePath, Status) 
        VALUES (@ProductID, @ProductName, @Price, @Quantity, @CategoryID, @ImagePath, @Status) 
    END 

    -- LỆNH CẬP NHẬT
    ELSE IF @Action = 'UPDATE' 
    BEGIN 
        UPDATE Product 
        SET ProductName = ISNULL(@ProductName, ProductName), 
            Price = ISNULL(@Price, Price), 
            Quantity = ISNULL(@Quantity, Quantity), 
            CategoryID = ISNULL(@CategoryID, CategoryID), 
            ImagePath = ISNULL(@ImagePath, ImagePath), 
            Status = ISNULL(@Status, Status) 
        WHERE ProductID = @ProductID 
    END 

    -- LỆNH XÓA
    ELSE IF @Action = 'DELETE' 
    BEGIN 
        DELETE FROM Product WHERE ProductID = @ProductID 
    END 
END

EXEC sp_Product_CRUD @Action = 'SELECT';


ALTER PROC sp_TimSanPham
    @MaSP NVARCHAR(50), -- Đổi từ INT sang NVARCHAR để so sánh được với ''
    @TenSP NVARCHAR(100),
    @Loai INT
AS
BEGIN
    SELECT * FROM Product
    WHERE (CAST(ProductID AS NVARCHAR) LIKE '%' + @MaSP + '%' OR @MaSP = '')
    AND (ProductName LIKE '%' + @TenSP + '%' OR @TenSP = '')
    AND (CategoryID = @Loai OR @Loai IS NULL)
END
EXEC sp_helptext 'sp_TimSanPham';


IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TaiKhoan_KhachHang')
    ALTER TABLE TaiKhoan DROP CONSTRAINT FK_TaiKhoan_KhachHang;


 ALTER VIEW vw_DangNhap
AS
SELECT tk.TenDangNhap, tk.MatKhau, tk.Quyen, 
       tk.MaNV AS IDNguoiDung, nv.TenNV AS HoTen 
FROM TaiKhoan tk
JOIN NhanVien nv ON tk.MaNV = nv.MaNV
UNION ALL
SELECT tk.TenDangNhap, tk.MatKhau, tk.Quyen, 
       tk.MaKH AS IDNguoiDung, kh.TenKH AS HoTen 
FROM TaiKhoan tk
JOIN KhachHang kh ON tk.MaKH = kh.MaKH;
GO

select*from vw_DangNhap;

--=====================================bán hàng====================================
CREATE VIEW v_ChiTietHoaDonst AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV AS [Nhân Viên], 
    kh.TenKH AS [Khách Hàng], 
    p.ProductName AS [Sản Phẩm], 
    ncc.TenNCC AS [Nhà Cung Cấp], -- Lấy từ bảng NhaCungCap
    od.Quantity AS [Số Lượng], 
    pn.GiaNhap AS [Giá Vốn],       -- Lấy từ bảng PhieuNhap
    od.UnitPrice AS [Giá Bán],    -- Lấy từ bảng OrderDetails
    (od.Quantity * od.UnitPrice) AS [Thành Tiền],
    (od.Quantity * (od.UnitPrice - pn.GiaNhap)) AS [Lợi Nhuận] -- Tính nhanh tiền lãi
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID
-- Nối với phiếu nhập gần nhất của sản phẩm đó để lấy giá vốn
JOIN PhieuNhap pn ON pn.ProductID = p.ProductID 
JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
WHERE pn.MaPN = (SELECT MAX(MaPN) FROM PhieuNhap WHERE ProductID = p.ProductID);

select*from v_ChiTietHoaDonst;

CREATE VIEW  v_LoiNhuanHoaDonst AS
SELECT 
    o.OrderID, 
    o.OrderDate, 
    nv.TenNV, 
    kh.TenKH, 
    p.ProductName, 
    od.Quantity AS SoLuongBan, 
    od.UnitPrice AS GiaBan, 
    pn.GiaNhap, 
    (od.Quantity * od.UnitPrice) AS ThanhTien, 
    -- Tính lợi nhuận thực tế dựa trên giá nhập cuối cùng của sản phẩm
    (od.Quantity * (od.UnitPrice - pn.GiaNhap)) AS TienLai
FROM Orders o
JOIN NhanVien nv ON o.MaNV = nv.MaNV
JOIN KhachHang kh ON o.MaKH = kh.MaKH
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Product p ON od.ProductID = p.ProductID
-- Lấy giá nhập từ phiếu nhập gần nhất của mỗi sản phẩm
JOIN PhieuNhap pn ON pn.ProductID = p.ProductID 
WHERE pn.MaPN = (
    SELECT MAX(MaPN) 
    FROM PhieuNhap 
    WHERE ProductID = p.ProductID
);
select*from v_LoiNhuanHoaDonst;

--======================================Chức năng quản lý kho==================
CREATE VIEW v_ThongTinKho AS
SELECT 
    p.ProductID, 
    p.ProductName, 
    p.Price AS GiaBan, 
    p.Quantity AS TonKho, 
    pn.GiaNhap, 
    ncc.TenNCC
FROM Product p
LEFT JOIN PhieuNhap pn ON pn.ProductID = p.ProductID
LEFT JOIN NhaCungCap ncc ON pn.MaNCC = ncc.MaNCC
WHERE pn.MaPN = (SELECT MAX(MaPN) FROM PhieuNhap WHERE ProductID = p.ProductID)
   OR pn.MaPN IS NULL;
   --lấy từ bảng  phiếu nhập và nhà cung cấp

  SELECT*FROM v_ThongTinKho;


  CREATE PROCEDURE sp_NhapHang
    @tenNCC NVARCHAR(200),
    @maSP VARCHAR(50),
    @tenSP NVARCHAR(200),
    @sl INT,
    @giaN DECIMAL(18,2),
    @maLoai INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Nhà cung cấp (Chỉ thêm nếu chưa có)
        DECLARE @maNCC INT;
        SELECT @maNCC = MaNCC FROM NhaCungCap WHERE TenNCC = @tenNCC;
        
        IF @maNCC IS NULL
        BEGIN
            INSERT INTO NhaCungCap (TenNCC) VALUES (@tenNCC);
            SET @maNCC = SCOPE_IDENTITY();
        END

        --  Sản phẩm (Cập nhật hoặc Thêm mới)
        IF EXISTS (SELECT 1 FROM Product WHERE ProductID = @maSP)
        BEGIN
            UPDATE Product SET Quantity = Quantity + @sl WHERE ProductID = @maSP;
        END
        ELSE
        BEGIN
            INSERT INTO Product (ProductID, ProductName, Price, Quantity, CategoryID)
            VALUES (@maSP, @tenSP, 0, @sl, @maLoai);
        END

        -- Thêm Phiếu Nhập
        INSERT INTO PhieuNhap (MaNCC, ProductID, SoLuongNhap, GiaNhap)
        VALUES (@maNCC, @maSP, @sl, @giaN);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
----------------------------------------------------------------------------
-- 1. SP Tính tổng lợi nhuận
CREATE OR ALTER PROCEDURE sp_GetTongLoiNhuan
AS
BEGIN
    SELECT SUM(TienLai) FROM v_LoiNhuanHoaDonst;
END
GO

-- 2. SP Lấy chi tiết hóa đơn
CREATE OR ALTER PROCEDURE sp_GetChiTietHoaDon
AS
BEGIN
    SELECT * FROM v_ChiTietHoaDonst ORDER BY OrderID DESC;
END
GO

-- 3. SP Xóa sản phẩm (Sử dụng tham số để bảo mật)
CREATE OR ALTER PROCEDURE sp_DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Product WHERE ProductID = @ProductID;
END
GO

-- 4. SP Xóa hóa đơn
CREATE OR ALTER PROCEDURE sp_DeleteOrder
    @OrderID INT
AS
BEGIN
    DELETE FROM Orders WHERE OrderID = @OrderID;
END
GO








--==============================================tài khoản=======
ALTER PROCEDURE sp_DangKyTaiKhoan 
(
    @Username NVARCHAR(50),
    @Password NVARCHAR(50),
    @HoTen NVARCHAR(100),
    @Quyen NVARCHAR(20)
)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MaMoi INT;
    DECLARE @Q NVARCHAR(20) = LOWER(TRIM(@Quyen));

    BEGIN TRY
        BEGIN TRANSACTION;
        IF @Q = 'nhanvien'
        BEGIN
            -- Tự tính MaNV tiếp theo: Lấy số lớn nhất + 1 (Nếu chưa có ai thì bắt đầu từ 1)
            SELECT @MaMoi = ISNULL(MAX(MaNV), 0) + 1 FROM NhanVien;

            -- Chèn vào bảng NhanVien
            INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, Quyen, NgayVaoLam, Luong)
            VALUES (@MaMoi, @HoTen, N'Nam', GETDATE(), '0000000000', @Q, GETDATE(), 0);

            -- Chèn vào bảng TaiKhoan (Dùng MaNV vừa tạo)
            INSERT INTO TaiKhoan(TenDangNhap, MatKhau, Quyen, MaNV)
            VALUES(@Username, @Password, @Q, @MaMoi);
        END
        ELSE
        BEGIN
            INSERT INTO KhachHang(TenKH, DienThoai, DiaChi) 
            VALUES(@HoTen, '0000000000', '');
            SET @MaMoi = SCOPE_IDENTITY();

            -- Chèn vào bảng TaiKhoan (Dùng MaKH vừa lấy được)
            INSERT INTO TaiKhoan(TenDangNhap, MatKhau, Quyen, MaKH) 
            VALUES(@Username, @Password, 'khachhang', @MaMoi);
        END

        COMMIT TRANSACTION;
        
        -- Trả về mã để WinForms hiển thị ở ExecuteScalar
        SELECT @MaMoi AS ID; 
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        DECLARE @ErrMsg NVARCHAR(MAX) = 'Lỗi SQL: ' + ERROR_MESSAGE();
        RAISERROR(@ErrMsg, 16, 1);
    END CATCH
END
--====kiểm tra ĐĂNG NHẬP
ALTER PROCEDURE sp_KiemTraDangNhap
    @user NVARCHAR(50),
    @pass NVARCHAR(50),
    @quyen NVARCHAR(20)
AS
BEGIN
    -- Phải lấy đúng tên cột mới từ vw_DangNhap
    SELECT Quyen, IDNguoiDung, HoTen 
    FROM vw_DangNhap 
    WHERE TenDangNhap = @user AND MatKhau = @pass AND Quyen = @quyen
END
--============================Taikhoan=========================
CREATE PROCEDURE sp_TaiKhoan_HanhDong
    @Action NVARCHAR(10), -- 'SELECT', 'INSERT', 'UPDATE', 'DELETE'
    @MaTK INT = NULL,
    @TenDangNhap NVARCHAR(50) = NULL,
    @MatKhau NVARCHAR(50) = NULL,
    @Quyen NVARCHAR(20) = NULL,
    @MaNV INT = NULL,
    @MaKH INT = NULL
AS
BEGIN
    -- 1. Lấy danh sách tài khoản
    IF @Action = 'SELECT'
    BEGIN
        SELECT tk.MaTK, tk.TenDangNhap, tk.MatKhau, tk.Quyen, 
               tk.MaNV, tk.MaKH,
               ISNULL(nv.TenNV, kh.TenKH) AS HoTen
        FROM TaiKhoan tk
        LEFT JOIN NhanVien nv ON tk.MaNV = nv.MaNV
        LEFT JOIN KhachHang kh ON tk.MaKH = kh.MaKH;
    END

    -- 2. Thêm mới tài khoản
    ELSE IF @Action = 'INSERT'
    BEGIN
        INSERT INTO TaiKhoan(TenDangNhap, MatKhau, Quyen, MaNV, MaKH)
        VALUES(@TenDangNhap, @MatKhau, @Quyen, @MaNV, @MaKH);
    END

    -- 3. Cập nhật tài khoản
    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE TaiKhoan
        SET TenDangNhap = @TenDangNhap, 
            MatKhau = @MatKhau, 
            Quyen = @Quyen, 
            MaNV = @MaNV, 
            MaKH = @MaKH
        WHERE MaTK = @MaTK;
    END

    -- 4. Xóa tài khoản
    ELSE IF @Action = 'DELETE'
    BEGIN
        DELETE FROM TaiKhoan WHERE MaTK = @MaTK;
    END
END

--==================================khách hàng========================================
ALTER PROCEDURE sp_LichSuGiaoDich 
    @MaKH INT, 
    @TuNgay DATE, 
    @DenNgay DATE 
AS 
BEGIN 
    SET NOCOUNT ON; 

    SELECT 
        o.OrderID AS [Mã Đơn], 
        o.OrderDate AS [Ngày Mua], 
        p.ProductName AS [Sản Phẩm], 
        od.Quantity AS [Số Lượng], 
        od.UnitPrice AS [Giá Bán], 
        (od.Quantity * od.UnitPrice) AS [Thành Tiền] 
    FROM Orders o 
    JOIN OrderDetails od ON o.OrderID = od.OrderID 
    JOIN Product p ON od.ProductID = p.ProductID 
    WHERE o.MaKH = @MaKH 
      AND o.OrderDate >= @TuNgay 
      AND o.OrderDate <= @DenNgay 
    ORDER BY o.OrderDate DESC; 
END
--========================================chức năng báo cáo===================

-- 1. Báo cáo doanh thu theo tháng
ALTER PROCEDURE sp_BaoCaoDoanhThuThang
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        MONTH(o.OrderDate) AS [Tháng],
        YEAR(o.OrderDate) AS [Năm],
        COUNT(DISTINCT o.OrderID) AS [Số Đơn],
        -- Tổng doanh thu
        SUM(od.Quantity * od.UnitPrice) AS [Doanh Thu],
        -- Tổng giá vốn
        SUM(od.Quantity * gia_von_tam.GiaNhap) AS [Giá Vốn],
        -- Lợi nhuận
        SUM(od.Quantity * od.UnitPrice) - SUM(od.Quantity * gia_von_tam.GiaNhap) AS [Lợi Nhuận],
        -- Lãi suất
        CASE 
            WHEN SUM(od.Quantity * od.UnitPrice) = 0 THEN 0
            ELSE (SUM(od.Quantity * od.UnitPrice) - SUM(od.Quantity * gia_von_tam.GiaNhap)) 
                 / SUM(od.Quantity * od.UnitPrice)
        END AS [Lãi Suất]
    FROM Orders o
    JOIN OrderDetails od ON o.OrderID = od.OrderID
    LEFT JOIN (
        -- Lấy giá nhập mới nhất của mỗi sản phẩm
        SELECT ProductID, GiaNhap
        FROM PhieuNhap p1
        WHERE NgayNhap = (SELECT MAX(NgayNhap) FROM PhieuNhap p2 WHERE p2.ProductID = p1.ProductID)
    ) AS gia_von_tam ON od.ProductID = gia_von_tam.ProductID
    GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)
    ORDER BY [Năm] DESC, [Tháng] DESC;
END
GO
-- 2. Top sản phẩm bán chạy
CREATE OR ALTER PROCEDURE sp_BaoCaoTopSanPham
AS
BEGIN
    SELECT TOP 10
        p.ProductName AS [Sản Phẩm],
        c.CategoryName AS [Danh Mục],
        SUM(od.Quantity) AS [Số Lượng Bán],
        SUM(od.UnitPrice * od.Quantity) AS [Doanh Thu],
        p.Quantity AS [Tồn Kho]
    FROM OrderDetails od
    JOIN Product p ON od.ProductID = p.ProductID
    LEFT JOIN Category c ON p.CategoryID = c.CategoryID
    GROUP BY p.ProductName, c.CategoryName, p.Quantity
    ORDER BY [Số Lượng Bán] DESC
END
GO

-- 3. Thống kê phương thức thanh toán (Đơn hàng)
CREATE OR ALTER PROCEDURE sp_ThongKeDonHang
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        -- 1. Ngày (Gộp theo ngày)
        CAST(o.OrderDate AS DATE) AS [Ngày],
        -- 2. Phương thức (mặc định là Chuyển khoản 
        N'Chuyển Khoản' AS [Phương Thức],
        -- 3. Mã đơn cuối cùng của ngày đó
        MAX(o.OrderID) AS [Mã Đơn Cuối],
        -- 4. Tổng số đơn hàng trong ngày
        COUNT(o.OrderID) AS [Tổng Số Đơn],
        -- 5. Tổng tiền thu được trong ngày
        SUM(o.TotalAmount) AS [Tổng Tiền Thu]
    FROM Orders o
    GROUP BY CAST(o.OrderDate AS DATE)
    ORDER BY [Ngày] DESC;
END
GO

-- 4. Báo cáo lợi nhuận gộp
CREATE OR ALTER PROCEDURE sp_BaoCaoLoiNhuan
AS
BEGIN
    SELECT 
        MONTH(o.OrderDate) AS [Tháng],
        SUM(od.Quantity * od.UnitPrice) AS [Doanh Thu],
        SUM(od.Quantity * ISNULL(pn.GiaNhap, 0)) AS [Giá Vốn],
        SUM(od.Quantity * (od.UnitPrice - ISNULL(pn.GiaNhap, 0))) AS [Lợi Nhuận Gộp]
    FROM Orders o
    JOIN OrderDetails od ON o.OrderID = od.OrderID
    JOIN Product p ON od.ProductID = p.ProductID
    LEFT JOIN (SELECT ProductID, MAX(GiaNhap) as GiaNhap FROM PhieuNhap GROUP BY ProductID) pn ON p.ProductID = pn.ProductID
    WHERE YEAR(o.OrderDate) = YEAR(GETDATE())
    GROUP BY MONTH(o.OrderDate)
    ORDER BY [Tháng]
END
GO

-- 5. Top khách hàng thân thiết
CREATE OR ALTER PROCEDURE sp_KhachHangThanThiet
AS
BEGIN
    SELECT TOP 20
        kh.TenKH AS [Khách Hàng],
        kh.DienThoai AS [ĐT],
        COUNT(o.OrderID) AS [Số Lần Mua],
        SUM(o.TotalAmount) AS [Tổng Chi Tiêu]
    FROM Orders o
    JOIN KhachHang kh ON o.MaKH = kh.MaKH
    WHERE kh.TenKH != N'Khách Lẻ'
    GROUP BY kh.TenKH, kh.DienThoai
    ORDER BY [Tổng Chi Tiêu] DESC
END
GO

--SELECT * FROM sys.triggers;

--EXEC sp_helptext 'trg_Updatekho_BanHang';
--- 1. SP Tạo hóa đơn mới (Trả về ID vừa tạo)
CREATE PROCEDURE sp_InsertOrder
    @MaNV INT,
    @MaKH INT,
    @TotalAmount DECIMAL(18,2)
AS
BEGIN
    INSERT INTO Orders (OrderDate, MaNV, MaKH, TotalAmount)
    VALUES (GETDATE(), @MaNV, @MaKH, @TotalAmount);
    
    SELECT SCOPE_IDENTITY(); -- Trả về ID đơn hàng
END
GO

--- 2. SP Thêm chi tiết hóa đơn 
CREATE PROCEDURE sp_InsertOrderDetail
    @OrderID INT,
    @ProductID INT,
    @Quantity INT,
    @UnitPrice DECIMAL(18,2)
AS
BEGIN
    INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice)
    VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice);
END
GO

--- 3. SP Lấy dữ liệu in hóa đơn
CREATE PROCEDURE sp_GetInvoiceDetails
    @OrderID INT
AS
BEGIN
    SELECT ProductName, Quantity, (Quantity * UnitPrice) AS ThanhTien
    FROM v_ChiTietHoaDon -- Sử dụng View bạn đã có
    WHERE OrderID = @OrderID;
END
GO

Alter TRIGGER trg_Updatekho_BanHang 
ON dbo.OrderDetails
AFTER INSERT 
AS BEGIN    
UPDATE P  
SET P.Quantity = P.Quantity - I.Quantity   
FROM dbo.Product P 
INNER JOIN inserted I ON P.ProductID = I.ProductID;
END; 