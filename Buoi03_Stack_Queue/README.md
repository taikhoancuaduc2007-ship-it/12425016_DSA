# Buổi 03 – Stack và Queue

Họ tên: Nguyễn Tiến Đức · MSV: 12425016

## Bài đã làm
Chương 5: bài 1, 2, 3, 4, 5, 6.
BT Bổ sung: bài 4, 5, 6, 7, 8, 9, 10, 11.

## Cách chạy
```
dotnet run --project Buoi03_Stack_Queue
```

## Kết quả chạy
```
=== Bài 1 ===
Nhập biểu thức: {[()]} + [2 * (3 + 4)]
Chuỗi hợp lệ

=== Bài 2 ===

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web1
Đang truy cập: web1

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web2
Đang truy cập: web2

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web3
Đang truy cập: web3

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 web2 [web3]
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web4
Đang truy cập: web4

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 web2 web3 [web4]
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 2
Bạn chọn: Back
Đang truy cập: web3

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 web2 [web3] web4
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 1
Bạn chọn: truy cập trang mới
Nhập URL: web5
Đang truy cập: web5

1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Thoát
Chọn: 4
Bạn chọn: Xem lịch sử
web1 web2 web3 [web5]

=== Bài 3 ===

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 3
Call Stack:
  - Main ()     - hdh

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 1
Nhập tên hàm: abc
Nhập tham số: c=9
Gọi hàm abc từ hàm Main

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 1
Nhập tên hàm: xyz
Nhập tham số: b=9
Gọi hàm xyz từ hàm abc

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 3
Call Stack:
  - xyz (b=9)     - abc
  - abc (c=9)     - Main
  - Main ()     - hdh

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 2
Hàm xyz kết thúc, trả về hàm abc

1. Gọi hàm
2. Trả về
3. Xem call stack
0. Thoát
Chọn: 3
Call Stack:
  - abc (c=9)     - Main
  - Main ()     - hdh

=== Bài 4 ===

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên yêu cầu: in abc
Nhập số trang: 45
Yêu cầu in abc với 45 trang đã được thêm vào hàng đợi

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên yêu cầu: xyz
Nhập số trang: 99
Yêu cầu xyz với 99 trang đã được thêm vào hàng đợi

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu:
  - in abc (45 trang)
  - xyz (99 trang)

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 2
Yêu cầu in abc với 45 trang đã được xử lý

1. Thêm yêu cầu
2. Xử lý yêu cầu
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu:
  - xyz (99 trang)

=== Bài 5 ===

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập nội dung: ádfghjk
Gói tin 1 với nội dung "ádfghjk" đã được thêm vào hàng đợi

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập nội dung: zxcvbnm,
Gói tin 2 với nội dung "zxcvbnm," đã được thêm vào hàng đợi

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập nội dung: okmhb
Gói tin 3 với nội dung "okmhb" đã được thêm vào hàng đợi

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi gói tin:
  - Gói tin 1: "ádfghjk"
  - Gói tin 2: "zxcvbnm,"
  - Gói tin 3: "okmhb"

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 2
Gói tin 1 với nội dung "ádfghjk" đã được xử lý

1. Thêm gói tin
2. Xử lý gói tin
3. Xem hàng đợi
0. Thoát
Chọn: 3
Hàng đợi gói tin:
  - Gói tin 2: "zxcvbnm,"
  - Gói tin 3: "okmhb"

=== Bài 6 ===

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên khách hàng: đức
Nhập loại dịch vụ: spa
Khách hàng đức đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 1
Nhập tên khách hàng: hiển péo
Nhập loại dịch vụ: ăn uống
Khách hàng hiển péo đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 3
Số khách đang chờ: 2
Khách tiếp theo: đức
Hàng đợi khách hàng:
  - 1. đức (17:45:32) - spa
  - 2. hiển péo (17:46:28) - ăn uống

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 2
Khách hàng đức với loại dịch vụ spa đã được xử lý
Đã chờ 76 giây

1. Thêm khách hàng
2. Xử lý khách hàng
3. Xem hàng đợi
0. Thoát
Chọn: 3
Số khách đang chờ: 1
Khách tiếp theo: hiển péo
Hàng đợi khách hàng:
  - 2. hiển péo (17:46:28) - ăn uống

=== Bài BS 4 ===

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: youtube.com
Đang truy cập: youtube.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: gg.com
Đang truy cập: gg.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: facebook.com
Đang truy cập: facebook.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 4
Trang hiện tại: facebook.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 2
Quay lại: gg.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 3
Tiến lên: facebook.com

=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 0
=== Bài BS 5 ===
Nhập chuỗi chỉ gồm '(' và ')': ()()()(((())((
Xâu sai
=== Bài BS 6 ===

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 1
Nhập tên tài liệu: abc
Yêu cầu in "abc" đã được thêm vào hàng đợi

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 1
Nhập tên tài liệu: xyz
Yêu cầu in "xyz" đã được thêm vào hàng đợi

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu in:
  - abc
  - xyz

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 2
Đã in xong tài liệu "abc"

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 3
Hàng đợi yêu cầu in:
  - xyz

1. Thêm yêu cầu in
2. Xử lý yêu cầu in
3. Hiển thị danh sách hàng đợi
0. Thoát
Chọn: 0
=== Bài BS 7 ===

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 1
Nhập gói dữ liệu: pk1
Đã gửi gói dữ liệu: pk1

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 1
Nhập gói dữ liệu: pk2
Đã gửi gói dữ liệu: pk2

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 3
Các gói dữ liệu trong hàng đợi:
  - pk1
  - pk2

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 2
Đã nhận gói dữ liệu: pk1

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 3
Các gói dữ liệu trong hàng đợi:
  - pk2

1. Gửi dữ liệu
2. Nhận dữ liệu
3. Hiển thị dữ liệu trong hàng đợi
0. Thoát
Chọn: 0
=== Bài BS 8 ===

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: duc
Khách hàng duc đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 1
Nhập tên hoặc số thứ tự khách hàng: duc2
Khách hàng duc2 đã được thêm vào hàng đợi

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 3
Danh sách khách hàng chờ:
  - duc
  - duc2

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 2
Đang phục vụ khách hàng: duc

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 3
Danh sách khách hàng chờ:
  - duc2

1. Thêm khách hàng
2. Phục vụ khách hàng
3. Hiển thị danh sách khách hàng chờ
0. Thoát
Chọn: 0

=== Bài BS 9 ===
Nhập biểu thức hậu tố (cách nhau bởi dấu cách): 3 4 2 * +
Giá trị biểu thức hậu tố là: 11

=== Bài BS 10 ===
Nhập biểu thức: +3 * 4
Chuỗi không hợp lệ

=== Bài BS 11 ===
Nhập biểu thức trung tố: (3 + 4) * 2 - 5 / 2
Biểu thức hậu tố: 3 4 + 2 * 5 2 / -
Kết quả: 11.5