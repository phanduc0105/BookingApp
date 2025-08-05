# BookingApp - Hướng dẫn cài đặt và chạy dự án

## 1. Kết nối cơ sở dữ liệu PostgreSQL

### Bước 1: Tạo cơ sở dữ liệu
Tạo một database tên là `BookingApp` trong hệ thống PostgreSQL của bạn.

### Bước 2: Khởi tạo dữ liệu
Chạy file `BookingApp.sql` nằm trong thư mục `Sql` để tạo bảng và dữ liệu mẫu.

### Bước 3: Cấu hình kết nối
Mở file `App.config`, tìm đến mục `<connectionStrings>` và chỉnh sửa các thông số kết nối cho phù hợp với cấu hình PostgreSQL trên máy bạn:

```xml
<connectionStrings>
  <add name="PostgresDb" 
       connectionString="Host=localhost;Port=5432;Username=postgres;Password=your_password;Database=BookingApp" 
       providerName="Npgsql" />
</connectionStrings>
```

🔧 **Lưu ý:** Thay `your_password` bằng mật khẩu thực tế của tài khoản PostgreSQL.

---

## 2. Cách chạy dự án

- Mở file `.sln` bằng Visual Studio.
- Chọn **Build > Build Solution** hoặc nhấn tổ hợp phím `Ctrl+Shift+B`.
- Nhấn `F5` để chạy ứng dụng.

---

## 3. Công nghệ sử dụng

- **Giao diện:** WinForms  
- **Framework:** .NET Framework 4.8.1  
- **Thư viện kết nối PostgreSQL:** Npgsql v8.0.7.0
