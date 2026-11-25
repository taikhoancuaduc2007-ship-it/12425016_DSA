# Buổi 05 – Sắp xếp

Họ tên: Nguyễn Tiến Đức · MSV: 12425016

## Bài đã làm
Chương 7: bài 1, 2.
BT Bổ sung: bài 3, 4.

## Cách chạy
```
dotnet run --project Buoi05_SapXep

```

## Kết quả chạy
```
=== Bài 1 Chương 7 ===

Nhập số lượng sinh viên muốn thêm :3
Nhập mã sinh viên: 1
Nhập họ tên: đức
Nhập điểm Môn 1: 9
Nhập điểm Môn 2: 8
Nhập điểm Môn 3: 7
Nhập mã sinh viên: 2
Nhập họ tên: hiển
Nhập điểm Môn 1: 9
Nhập điểm Môn 2: 9
Nhập điểm Môn 3: 9
Nhập mã sinh viên: 3
Nhập họ tên: đạt
Nhập điểm Môn 1: 10
Nhập điểm Môn 2: 8
Nhập điểm Môn 3: 7

Danh sách sinh viên chưa sắp xếp :
Mã SV    Họ tên               Điểm 1 Điểm 2 Điểm 3      ĐTB
1        đức                       9      8      7        8
2        hiển                      9      9      9        9
3        đạt                      10      8      7 8.333333

Danh sách sinh viên đã sắp xếp giảm dần :
Mã SV    Họ tên               Điểm 1 Điểm 2 Điểm 3      ĐTB
2        hiển                      9      9      9        9
3        đạt                      10      8      7 8.333333
1        đức                       9      8      7        8

=== Bài 2 Chương 7 ===

Nhập số lượng sinh viên muốn thêm :3
Nhập mã sinh viên: 5
Nhập họ tên: Văn D
Nhập điểm Môn 1: 9
Nhập điểm Môn 2: 9
Nhập điểm Môn 3: 9
Nhập mã sinh viên: 1
Nhập họ tên: Tiến A
Nhập điểm Môn 1: 8
Nhập điểm Môn 2: 8
Nhập điểm Môn 3: 7
Nhập mã sinh viên: 2
Nhập họ tên: Thị C
Nhập điểm Môn 1: 10
Nhập điểm Môn 2: 8
Nhập điểm Môn 3: 7

Danh sách sinh viên chưa sắp xếp :
Mã SV    Họ tên               Điểm 1 Điểm 2 Điểm 3      ĐTB
5        Văn D                     9      9      9     9.00
1        Tiến A                    8      8      7     7.67
2        Thị C                    10      8      7     8.33

Danh sách sinh viên đã sắp xếp theo tên :
Mã SV    Họ tên               Điểm 1 Điểm 2 Điểm 3      ĐTB
1        Tiến A                    8      8      7     7.67
2        Thị C                    10      8      7     8.33
5        Văn D                     9      9      9     9.00

=== Bài Bổ Sung 3 ===

Nhập số lượng phần tử thêm vào mảng :5

Nhập giá trị phần tử thứ 1: 2

Nhập giá trị phần tử thứ 2: 8

Nhập giá trị phần tử thứ 3: 3

Nhập giá trị phần tử thứ 4: 99

Nhập giá trị phần tử thứ 5: 71

Mảng chưa sắp xếp :2 8 3 99 71
Mảng đã sắp xếp :99 71 8 3 2

=== Bài Bổ Sung 4 ===

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 1

Nhập mã sinh viên: 01
Nhập họ tên: đức
Nhập ngày sinh: 01/05/2007
Nhập quê quán: hà nội
Nhập lớp: 124251
Nhập điểm trung bình: 8.0

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 1

Nhập mã sinh viên: 02
Nhập họ tên: hiển béo
Nhập ngày sinh: 01/01/2007
Nhập quê quán: hưng yên
Nhập lớp: 124251
Nhập điểm trung bình: 9.0

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 2

Danh sách sinh viên :
Mã sinh viên  Họ tên               Ngày sinh  Quê quán             Lớp      ĐTB
01            đức                  05/01/2007 hà nội               124251   8.00
02            hiển béo             01/01/2007 hưng yên             124251   9.00

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 3

Danh sách sinh viên (sắp xếp theo tên) :
Mã sinh viên  Họ tên               Ngày sinh  Quê quán             Lớp      ĐTB
02            hiển béo             01/01/2007 hưng yên             124251   9.00
01            đức                  05/01/2007 hà nội               124251   8.00

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 4

Danh sách sinh viên (sắp xếp theo mã sinh viên) :
Mã sinh viên  Họ tên               Ngày sinh  Quê quán             Lớp      ĐTB
01            đức                  05/01/2007 hà nội               124251   8.00
02            hiển béo             01/01/2007 hưng yên             124251   9.00

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 5

Danh sách sinh viên (sắp xếp theo điểm trung bình) :
Mã sinh viên  Họ tên               Ngày sinh  Quê quán             Lớp      ĐTB
02            hiển béo             01/01/2007 hưng yên             124251   9.00
01            đức                  05/01/2007 hà nội               124251   8.00

=== Danh sách chức năng ===
1. Nhập danh sách sinh viên
2. Hiển thị danh sách
3. Sắp xếp theo tên
4. Sắp xêp theo mã sinh viên
5. Sắp xếp theo điểm trung bình
6. Thoát
Nhập lựa chọn: 0