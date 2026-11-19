# Buổi 02 – Danh Sách

Họ tên: Nguyễn Tiến Đức · MSV: 12425016

## Bài đã làm
Chương 4: bài 1, 2, 3, 4, 5.
BT Bổ sung: bài 7, 8, 9, 10, 11, 12, 13 , 14, 15, 16, 17 ,18.

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```

## Kết quả chạy
```
=== Bài 1 ===
Nhập n: 3
a[0] = 9
a[1] = 1
a[2] = 5
Danh sách: 9 1 5
Nhập x cần chèn: 23
Nhập vị trí  (1..3 ): 2
Danh sách sau khi chen: 9 23 1 5

=== Bài 2 ===
Nhập số nhân viên: 2
--- Nhân viên 1 ---
Mã NV: 1
Họ tên: đức
Năm sinh: 2007
Phòng ban: it
Lương cơ bản: 2000
Thưởng: 200
--- Nhân viên 2 ---
Mã NV: 2
Họ tên: hiển
Năm sinh: 2007
Phòng ban: mkt
Lương cơ bản: 2000
Thưởng: 200

a. Tổng thực lĩnh tháng: 4400

b. Nhân viên có lương cơ bản thấp nhất:
Mã NV    Họ tên               Năm sinh Phòng ban    Lương CB   Thưởng     Thực lĩnh
1        d?c                  2007   it           2000       200        2200
2        hi?n                 2007   mkt          2000       200        2200

c. Số nhân viên có thưởng >= 1200000: 0

d. Danh sách theo phòng ban tăng dần, mã NV giảm dần:
Mã NV    Họ tên               Năm sinh Phòng ban    Lương CB   Thưởng     Thực lĩnh
1        d?c                  2007   it           2000       200        2200
2        hi?n                 2007   mkt          2000       200        2200

e. Danh sách sau khi tăng lương 5%:
Mã NV    Họ tên               Năm sinh Phòng ban    Lương CB   Thưởng     Thực lĩnh
1        d?c                  2007   it           2100       200        2300
2        hi?n                 2007   mkt          2100       200        2300

=== Bài 3 ===
Nhập n (0 <= n < 100): 5
a[0,0] = 1
a[0,1] = 2
a[0,2] = 5
a[0,3] = 1
a[0,4] = 2
a[1,0] = 7
a[1,1] = 6
a[1,2] = 7
a[1,3] = 6
a[1,4] = 4
a[2,0] = 5
a[2,1] = 5
a[2,2] = 7
a[2,3] = 6
a[2,4] = 4
a[3,0] = 1
a[3,1] = 2
a[3,2] = 8
a[3,3] = 9
a[3,4] = 8
a[4,0] = 7
a[4,1] = 3
a[4,2] = 4
a[4,3] = 5
a[4,4] = 2
Ma trận:
1       2       5       1       2
7       6       7       6       4
5       5       7       6       4
1       2       8       9       8
7       3       4       5       2
a. Tổng tất cả các phần tử: 117
b. Giá trị dương nhỏ nhất: 1
c. Tổng đường chéo phụ: 24
d. Đường chéo chính tăng dần: Không

=== Bài 4 ===
Nhập n: 2
Phần tử thứ 1 = 45
Phần tử thứ 2 = 12
Danh sách đã nhập: 45 12
Nhập x cần tìm: 8
Số lần xuất hiện của 8 trong danh sách: 0
Giá trị nhỏ nhất trong danh sách: 12
Nhập c: 11
Không tìm thấy 11 trong danh sách!
Danh sách sau khi xóa: 45 12

=== Bài 5 ===
Nhập n: 2
Phần tử thứ 1 = 1
Phần tử thứ 2 = 8
Danh sách: 1 8
a. Phần tử lớn nhất: 8
b. Tổng các phần tử: 9
c. Số nguyên tố: 0
d. Số âm: 0, số bằng 0: 0, số dương: 2
Nhập x: 55
e. Số phần tử bằng 55: 0
f. Phần tử dương nhỏ nhất: 1

=== Bài 7 ===
Nhập số ngày n: 8
Nhiệt độ ngày 1: 30
Nhiệt độ ngày 2: 32
Nhiệt độ ngày 3: 35
Nhiệt độ ngày 4: 35
Nhiệt độ ngày 5: 31
Nhiệt độ ngày 6: 28
Nhiệt độ ngày 7: 29
Nhiệt độ ngày 8: 30
Ngày nóng nhất: ngày 3 (35 độ)
Ngày lạnh nhất: ngày 6 (28 độ)
Nhiệt độ trung bình: 31.25 độ

=== Bài 8 ===
Nhập một chuỗi văn bản: khoa công nghệ thông tin

Từ          Số lần
công        1
khoa        1
ngh         1
thông       1
tin         1

=== Bài 9 ===
Nhập số phần tử n: 3
a[0] = 5
a[1] = 7
a[2] = 5
Số nguyên tố: 5 7 5 (3 số)
Số chẵn: (0 số)
Số hoàn hảo: (0 số)

=== Bài 10 ===
Số dòng m: 3
Số cột n: 2
a[0,0] = 12
a[0,1] = 54
a[1,0] = 77
a[1,1] = 1
a[2,0] = 2
a[2,1] = 0
Thứ tự xoắn ốc: 12 54 1 0 2 77

=== Bài 11 ===
Nhập cấp n của ma trận vuông: 2
matrix[0,0] = 1
matrix[0,1] = 5
matrix[1,0] = 7
matrix[1,1] = 9
Ma trận đơn vị: Không
Ma trận đối xứng: Không

=== Bài 12 ===
Số dòng m: 5
Số cột n: 2
Số min (0..10): 2

Bảng Minesweeper (* là min, số là số min xung quanh):
* 1
2 2
* 1
1 1
0 0

=== Bài 13 ===
Số phần tử: 3
Phần tử thứ 1: 2
Phần tử thứ 2: 8
Phần tử thứ 3: 5
Danh sách ban đầu: 2 8 5
Danh sách sau khi đảo ngược: 5 8 2

=== Bài 14 ===
(Nhập các danh sách theo thứ tự tăng dần)
Số phần tử của danh sách 1: 1
  Phần tử thứ 1 (>= tùy ý): 9
Số phần tử của danh sách 2: 5
  Phần tử thứ 1 (>= tùy ý): 4
  Phần tử thứ 2 (>= 4): 8
  Phần tử thứ 3 (>= 8): 9
  Phần tử thứ 4 (>= 9): 99
  Phần tử thứ 5 (>= 99): 555
Danh sách sau khi gộp: 4 8 9 9 99 555

=== Bài 15 ===
Số phần tử: 2
Phần tử thứ 1: 45
Phần tử thứ 2: 46
Nút cuối trỏ về vị trí nào (0..1, -1 = không tạo chu trình): 0
Danh sách CÓ chu trình, bắt đầu tại nút có giá trị 45

=== Bài 16 ===

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 4
Lịch sử rỗng.

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 3
Không thể Forward.

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 1
Nhập địa chỉ trang web: jhjl
Đang ở: jhjl

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 3
Không thể Forward.

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 1
Nhập địa chỉ trang web: jhjkhkhk
Đang ở: jhjkhkhk

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 3
Không thể Forward.

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 1
Nhập địa chỉ trang web: aqwe
Đang ở: aqwe

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 4
Lịch sử: jhjl jhjkhkhk [aqwe]

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 2
Đang ở: jhjkhkhk

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 3
Đang ở: aqwe

1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát
Chọn: 0

=== Bài 17 ===

1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát
Chọn: 1
Tên bài hát: abc
Đã thêm: abc

1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát
Chọn: zyz
Chọn: 5
Playlist: [abc]
Đang phát: abc

1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát
Chọn: 1
Tên bài hát: xyz
Đã thêm: xyz

1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát
Chọn: 5
Playlist: [abc] xyz
Đang phát: abc

1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát
Chọn: 0

=== Bài 18 ===

1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát
Chọn: 1
Mã đơn hàng: 123
Đã thêm đơn 123 (Chờ xử lý).

1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát
Chọn: 1
Mã đơn hàng: 456
Đã thêm đơn 456 (Chờ xử lý).

1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát
Chọn: 3
Mã đơn hàng: 789
Không tìm thấy đơn hàng.

1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát
Chọn: 4
123        Chờ xử lý
456        Chờ xử lý

1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát
Chọn: 0