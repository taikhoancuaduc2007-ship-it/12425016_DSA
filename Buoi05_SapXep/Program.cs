struct SinhVien
{
    public int MaSV;
    public string HoTen;
    public float Diem1, Diem2, Diem3;
    public float DiemTB;
}
struct SinhVien2
{
    public string MaSV;
    public string Ten;
    public DateTime NgaySinh;
    public string Que;
    public string Lop;
    public float DiemTB;
}

class Program
{
    static void Bai1C7()
    {
        int n;
        do
        {
            do
            {
                Console.Write("Nhập số lượng sinh viên muốn thêm :");
            } while (!int.TryParse(Console.ReadLine(), out n));
        } while (n <= 0);

        SinhVien[] DSSV = new SinhVien[n];
        float NhapDiem(string ten)
        {
            float d;
            do
            {
                Console.Write($"Nhập điểm {ten}: ");
            } while (!float.TryParse(Console.ReadLine(), out d) || d < 0 || d > 10);
            return d;
        }

        SinhVien sv = new SinhVien();
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Nhập mã sinh viên: ");
            } while (!int.TryParse(Console.ReadLine(), out sv.MaSV));
            do
            {
                Console.Write("Nhập họ tên: ");
                sv.HoTen = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.HoTen));

            sv.Diem1 = NhapDiem("Môn 1");
            sv.Diem2 = NhapDiem("Môn 2");
            sv.Diem3 = NhapDiem("Môn 3");

            sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3;
            DSSV[i] = sv;

            
        }
        void InDS(string st)
            {
                Console.WriteLine($"Danh sách sinh viên {st} :");
                Console.WriteLine("{0,-8} {1,-20} {2,6} {3,6} {4,6} {5,8}","Mã SV", "Họ tên", "Điểm 1", "Điểm 2", "Điểm 3", "ĐTB");
                foreach(SinhVien i in DSSV)
                {
                    Console.WriteLine($"{i.MaSV,-8} {i.HoTen,-20} {i.Diem1,6} {i.Diem2,6} {i.Diem3,6} {i.DiemTB,8}");
                }
            }
        InDS("chưa sắp xếp");

        void SelectionSort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (DSSV[j].DiemTB > DSSV[max].DiemTB)
                        max = j;
                }
                if (max != i)
                {
                    SinhVien tmp = DSSV[i];
                    DSSV[i] = DSSV[max];
                    DSSV[max] = tmp;
                }
            }
        }
        SelectionSort();
        InDS("đã sắp xếp giảm dần");
    }
    static void Bai2C7()
    {
        int n;
        do
        {
            do
            {
                Console.Write("Nhập số lượng sinh viên muốn thêm :");
            } while (!int.TryParse(Console.ReadLine(), out n));
        } while (n <= 0);

        SinhVien[] DSSV = new SinhVien[n];
        float NhapDiem(string ten)
        {
            float d;
            do
            {
                Console.Write($"Nhập điểm {ten}: ");
            } while (!float.TryParse(Console.ReadLine(), out d) || d < 0 || d > 10);
            return d;
        }

        SinhVien sv = new SinhVien();
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Nhập mã sinh viên: ");
            } while (!int.TryParse(Console.ReadLine(), out sv.MaSV));
            do
            {
                Console.Write("Nhập họ tên: ");
                sv.HoTen = Console.ReadLine();
            } while (string.IsNullOrEmpty(sv.HoTen));

            sv.Diem1 = NhapDiem("Môn 1");
            sv.Diem2 = NhapDiem("Môn 2");
            sv.Diem3 = NhapDiem("Môn 3");

            sv.DiemTB = (sv.Diem1 + sv.Diem2 + sv.Diem3) / 3;
            DSSV[i] = sv;


        }
        void InDS(string st)
        {
            Console.WriteLine($"Danh sách sinh viên {st} :");
            Console.WriteLine("{0,-8} {1,-20} {2,6} {3,6} {4,6} {5,8}", "Mã SV", "Họ tên", "Điểm 1", "Điểm 2", "Điểm 3", "ĐTB");
            foreach (SinhVien i in DSSV)
            {
                Console.WriteLine($"{i.MaSV,-8} {i.HoTen,-20} {i.Diem1,6} {i.Diem2,6} {i.Diem3,6} {i.DiemTB,8:F2}");
            }
        }
        string LayTen(string hoten)
        {
            hoten = hoten.Trim();
            int vt = hoten.LastIndexOf(' ');
            return hoten.Substring(vt + 1);
        }
        int SoSanh(SinhVien a, SinhVien b)
        {
            int c = LayTen(a.HoTen).CompareTo(LayTen(b.HoTen));
            if (c == 0)
                c = a.HoTen.CompareTo(b.HoTen);
            return c;
        }
        InDS("chưa sắp xếp");

        void SelectionSort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (SoSanh(DSSV[j], DSSV[min]) < 0)
                        min = j;
                }
                if (min != i)
                {
                    SinhVien tmp = DSSV[i];
                    DSSV[i] = DSSV[min];
                    DSSV[min] = tmp;
                }
            }
        }
        SelectionSort();
        InDS("đã sắp xếp theo tên");
    }
    static void BaiBS3()
    {
        int n;
        do
        {
            Console.Write("Nhập số lượng phần tử thêm vào mảng :");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0); Console.WriteLine();
        
        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            Console.Write($"Nhập giá trị phần tử thứ {i + 1}: ");
            bool check = int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine();
            if (check)
            {
                arr[i] = x;
            }
            else { i--; };
        }
        void HienThi(string st)
        {
            Console.Write($"Mảng {st} :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        void SelectionSort()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[max])
                        max = j;
                }
                if (max != i)
                {
                    int tmp = arr[i];
                    arr[i] = arr[max];
                    arr[max] = tmp;
                }
            }
        }

        HienThi("chưa sắp xếp");
        SelectionSort();
        HienThi("đã sắp xếp");

    }
    static void BaiBS4()
    {
        List<SinhVien2> dssv = new List<SinhVien2>();
        string NhapTrong(string st)
        {
            string s;
            do
            {
                Console.Write(st);
                s = Console.ReadLine();
            } while (string.IsNullOrEmpty(s));
            return s;
        }
        DateTime NhapNgay(string st)
        {
            DateTime dt;
            string s;
            do
            {
                Console.Write(st);
                s = Console.ReadLine();
            } while (!DateTime.TryParse(s, out dt) || dt > DateTime.Now);
            return dt;
        }
        float NhapSo(string st)
        {
            float so;
            string s;
            do
            {
                Console.Write(st);
                s = Console.ReadLine();
            } while (!float.TryParse(s, out so) || so < 0);
            return so;
        }

        void NhapDS()
        {
            SinhVien2 sv = new SinhVien2();

            sv.MaSV = NhapTrong("Nhập mã sinh viên: ");
            sv.Ten = NhapTrong("Nhập họ tên: ");
            sv.NgaySinh = NhapNgay("Nhập ngày sinh: ");
            sv.Que = NhapTrong("Nhập quê quán: ");
            sv.Lop = NhapTrong("Nhập lớp: ");
            sv.DiemTB = NhapSo("Nhập điểm trung bình: ");

            dssv.Add(sv);
        }

        void HienThi()
        {
            if (dssv.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }

            Console.WriteLine("{0,-13} {1,-20} {2,-10} {3,-20} {4,-8} {5,-6}",
                "Mã sinh viên", "Họ tên", "Ngày sinh", "Quê quán", "Lớp", "ĐTB");

            foreach (var sv in dssv)
            {
                Console.WriteLine($"{sv.MaSV,-13} {sv.Ten,-20} {sv.NgaySinh,-10:dd/MM/yyyy} {sv.Que,-20} {sv.Lop,-8} {sv.DiemTB,-6:F2}");
            }
        }

        string LayTen(string hoten)
        {
            hoten = hoten.Trim();
            int vt = hoten.LastIndexOf(' ');
            return hoten.Substring(vt + 1);
        }

        void SapxepTen()
        {
            for (int i = 0; i < dssv.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dssv.Count; j++)
                {
                    int c = LayTen(dssv[j].Ten).CompareTo(LayTen(dssv[min].Ten));
                    if (c == 0)
                        c = dssv[j].Ten.CompareTo(dssv[min].Ten);
                    if (c < 0)
                        min = j;
                }
                if (min != i)
                {
                    SinhVien2 tmp = dssv[i];
                    dssv[i] = dssv[min];
                    dssv[min] = tmp;
                }
            }
        }

        void SapXepMaSV()
        {
            for (int i = 0; i < dssv.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < dssv.Count; j++)
                {
                    if (dssv[j].MaSV.CompareTo(dssv[min].MaSV) < 0)
                        min = j;
                }
                if (min != i)
                {
                    SinhVien2 tmp = dssv[i];
                    dssv[i] = dssv[min];
                    dssv[min] = tmp;
                }
            }
        }

        void SapXepDiemTB()
        {
            for (int i = 0; i < dssv.Count - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < dssv.Count; j++)
                {
                    if (dssv[j].DiemTB > dssv[max].DiemTB)
                        max = j;
                }
                if (max != i)
                {
                    SinhVien2 tmp = dssv[i];
                    dssv[i] = dssv[max];
                    dssv[max] = tmp;
                }
            }
        }

        bool run = true;
        while (run)
        {
            Console.WriteLine("=== Danh sách chức năng ===");
            Console.WriteLine("1. Nhập danh sách sinh viên");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Sắp xếp theo tên");
            Console.WriteLine("4. Sắp xêp theo mã sinh viên");
            Console.WriteLine("5. Sắp xếp theo điểm trung bình");
            Console.WriteLine("6. Thoát");
            Console.Write("Nhập lựa chọn: ");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    NhapDS();
                    break;
                case "2":
                    Console.WriteLine("Danh sách sinh viên :");
                    HienThi();
                    break;
                case "3":
                    Console.WriteLine("Danh sách sinh viên (sắp xếp theo tên) :");
                    SapxepTen(); HienThi();
                    break;
                case "4":
                    Console.WriteLine("Danh sách sinh viên (sắp xếp theo mã sinh viên) :");
                    SapXepMaSV(); HienThi();
                    break;
                case "5":
                    Console.WriteLine("Danh sách sinh viên (sắp xếp theo điểm trung bình) :");
                    SapXepDiemTB(); HienThi();
                    break;
                case "0":
                    run = false;
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine("=== Bài 1 Chương 7 ===");
        Bai1C7();
        Console.WriteLine("=== Bài 2 Chương 7 ===");
        Bai2C7();
        Console.WriteLine("=== Bài Bổ Sung 3 ===");
        BaiBS3();
        Console.WriteLine("=== Bài Bổ Sung 4 ===");
        BaiBS4();
    }
}