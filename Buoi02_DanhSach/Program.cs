using System.Text;

struct NhanVien
{
    public string MaNV;
    public string Hoten;
    public int Namsinh;
    public string Phongban;
    public int LuongCB;
    public int Thuong;
}
class Node
{
    public int Data;
    public Node Next;
}
class DNode
{
    public string Data;
    public DNode Prev;
    public DNode Next;
}

class DonHang
{
    public string Ma;
    public DNode TrangThai;
}
class BaiTap
{
    static void Bai1()
    {
        int[] a;

        void Nhap()
        {
            int n;
            do
            {
                Console.Write("Nhập n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            a = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                do
                {
                    Console.Write($"a[{i}] = ");
                } while (!int.TryParse(Console.ReadLine(), out a[i]) || a[i] <= 0);
            }
        }

        void HienThi()
        {
            for (int i = 0; i <= a.Length - 1; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        void Chen(int vitri, int giatri)
        {
            if (vitri < 1 || vitri > a.Length + 1)
            {
                Console.WriteLine("Vị trí không hợp lệ!");
                return;
            }
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i <= vitri - 1; i++)
                tmp[i] = a[i];
            tmp[vitri - 1] = giatri;
            for (int i = vitri - 1; i <= a.Length - 1; i++)
                tmp[i + 1] = a[i];
            a = tmp;
        }

        Nhap();
        Console.Write("Danh sách: ");
        HienThi();

        Console.Write("Nhập x cần chèn: ");
        int giatri = int.Parse(Console.ReadLine());
        Console.Write($"Nhập vị trí  (1..{a.Length} ): ");
        int vitri = int.Parse(Console.ReadLine());
        Chen(vitri, giatri);
        Console.Write("Danh sách sau khi chen: ");
        HienThi();
    }
    static void Bai2()
    {
        int thuclinh(NhanVien nv) { return nv.LuongCB + nv.Thuong; }

        void inDS(NhanVien[] ds)
        {
            Console.WriteLine("{0,-8} {1,-20} {2,-6} {3,-12} {4,-10} {5,-10} {6,-10}",
                "Mã NV", "Họ tên", "Năm sinh", "Phòng ban", "Lương CB", "Thưởng", "Thực lĩnh");

            for (int i = 0; i < ds.Length; i++)
                Console.WriteLine("{0,-8} {1,-20} {2,-6} {3,-12} {4,-10} {5,-10} {6,-10}",
                    ds[i].MaNV, ds[i].Hoten, ds[i].Namsinh, ds[i].Phongban,
                    ds[i].LuongCB, ds[i].Thuong, thuclinh(ds[i]));
        }

        Console.Write("Nhập số nhân viên: ");
        int n = int.Parse(Console.ReadLine());
        NhanVien[] DS = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"--- Nhân viên {i + 1} ---");
            Console.Write("Mã NV: "); DS[i].MaNV = Console.ReadLine();
            Console.Write("Họ tên: "); DS[i].Hoten = Console.ReadLine();
            Console.Write("Năm sinh: "); DS[i].Namsinh = int.Parse(Console.ReadLine());
            Console.Write("Phòng ban: "); DS[i].Phongban = Console.ReadLine();
            Console.Write("Lương cơ bản: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
            Console.Write("Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
        }

        long tong = 0;
        for (int i = 0; i < n; i++)
            tong += thuclinh(DS[i]);
        Console.WriteLine("\na. Tổng thực lĩnh tháng: " + tong);

        Console.WriteLine("\nb. Nhân viên có lương cơ bản thấp nhất:");
        if (n > 0)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                if (min > DS[i].LuongCB) min = DS[i].LuongCB;

            NhanVien[] kq = new NhanVien[n];
            int m = 0;
            for (int i = 0; i < n; i++)
                if (DS[i].LuongCB == min) kq[m++] = DS[i];
            Array.Resize(ref kq, m);
            inDS(kq);
        }

        int dem = 0;
        for (int i = 0; i < n; i++)
            if (DS[i].Thuong >= 1200000) dem++;
        Console.WriteLine("\nc. Số nhân viên có thưởng >= 1200000: " + dem);

        NhanVien[] b = (NhanVien[])DS.Clone();
        for (int i = 0; i < n - 1; i++)
            for (int j = i + 1; j < n; j++)
            {
                int c = string.Compare(b[i].Phongban, b[j].Phongban);
                if (c > 0 || (c == 0 && string.Compare(b[i].MaNV, b[j].MaNV) < 0))
                {
                    NhanVien tmp = b[i];
                    b[i] = b[j];
                    b[j] = tmp;
                }
            }
        Console.WriteLine("\nd. Danh sách theo phòng ban tăng dần, mã NV giảm dần:");
        inDS(b);

        for (int i = 0; i < n; i++)
            DS[i].LuongCB = DS[i].LuongCB + DS[i].LuongCB * 5 / 100;
        Console.WriteLine("\ne. Danh sách sau khi tăng lương 5%:");
        inDS(DS);
    }
    static void Bai3()
    {
        int n;
        do
        {
            Console.Write("Nhập n (0 <= n < 100): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n >= 100);

        int[,] a = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("Ma trận:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++) Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }

        long t = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                t += a[i, j];
        Console.WriteLine("a. Tổng tất cả các phần tử: " + t);

        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (a[i, j] > 0 && a[i, j] < min) min = a[i, j];
        Console.WriteLine("b. Giá trị dương nhỏ nhất: " +
            (min == int.MaxValue ? "không có số dương" : min.ToString()));

        long tongPhu = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (j == (n - 1) - i) tongPhu += a[i, j];
        Console.WriteLine("c. Tổng đường chéo phụ: " + tongPhu);

        int[] tg = new int[n];
        for (int i = 0; i < n; i++)
            tg[i] = a[i, i];

        bool tangDan = true;
        for (int i = 0; i <= n - 2 && tangDan; i++)
            for (int j = i + 1; j <= n - 1; j++)
                if (tg[i] >= tg[j]) { tangDan = false; break; }
        Console.WriteLine("d. Đường chéo chính tăng dần: " + (tangDan ? "Có" : "Không"));
    }

    static void Bai4()
    {
        Node Phead = null;
        Node Ptail = null;

        void Nhap()
        {
            int n;
            do
            {
                Console.Write("Nhập n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    Console.Write($"Phần tử thứ {i + 1} = ");
                } while (!int.TryParse(Console.ReadLine(), out x) || x <= 0);

                Node p = new Node();
                p.Data = x;
                p.Next = null;

                if (Phead == null)
                {
                    Phead = p;
                    Ptail = p;
                }
                else
                {
                    Ptail.Next = p;
                    Ptail = p;
                }
            }
        }

        void InDS()
        {
            for (Node p = Phead; p != null; p = p.Next)
                Console.Write(p.Data + " ");
            Console.WriteLine();
        }

        void InDSMoi()
        {
            Console.Write("Danh sách sau khi xóa: ");
            InDS();
        }

        Nhap();
        Console.Write("Danh sách đã nhập: ");
        InDS();
        // ý a
        int a;
        do
        {
            Console.Write("Nhập x cần tìm: ");
        } while (!int.TryParse(Console.ReadLine(), out a));
        int dem = 0;
        for (Node p = Phead; p != null; p = p.Next)
            if (p.Data == a)
            {
                dem++;
            }
        Console.WriteLine($"Số lần xuất hiện của {a} trong danh sách: {dem}");
        // ý b
        int min = int.MaxValue;
        for (Node p = Phead; p != null; p = p.Next)
            if (p.Data < min) min = p.Data;
        if (min != int.MaxValue)
            Console.WriteLine($"Giá trị nhỏ nhất trong danh sách: {min}");
        else
            Console.WriteLine("Danh sách rỗng!");
        // ý c
        int c;
        do
        {
            Console.Write("Nhập c: ");
        } while (!int.TryParse(Console.ReadLine(), out c));

        if (Phead == null) { Console.WriteLine("Danh sách rỗng!"); }
        else if (Phead.Data == c)
        {
            Phead = Phead.Next;
            Console.WriteLine($"Đã xóa {c} khỏi danh sách.");
        }
        else
        {
            Node m = Phead;
            Node n = Phead.Next;
            while (n != null && n.Data != c)
            {
                m = n;
                n = n.Next;
            }
            if (n == null)
            {
                Console.WriteLine($"Không tìm thấy {c} trong danh sách!");
            }
            else
            {
                m.Next = n.Next;
                if (m.Next == null) Ptail = m;
                Console.WriteLine($"Đã xóa {c} khỏi danh sách.");

            }
        }
        InDSMoi();

    }
    static void Bai5()
    {
        Node Phead = null;
        Node Ptail = null;

        void Nhap()
        {
            int n;
            do
            {
                Console.Write("Nhập n: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            for (int i = 0; i < n; i++)
            {
                int v;
                do
                {
                    Console.Write($"Phần tử thứ {i + 1} = ");
                } while (!int.TryParse(Console.ReadLine(), out v));

                Node p = new Node();
                p.Data = v;
                p.Next = null;

                if (Phead == null)
                {
                    Phead = p;
                    Ptail = p;
                }
                else
                {
                    Ptail.Next = p;
                    Ptail = p;
                }
            }
        }

        void InDS()
        {
            for (Node p = Phead; p != null; p = p.Next)
                Console.Write(p.Data + " ");
            Console.WriteLine();
        }

        bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        Nhap();
        Console.Write("Danh sách: ");
        InDS();

        if (Phead == null)
        {
            Console.WriteLine("Danh sách rỗng, không có phần tử lớn nhất.");
        }
        else
        {
            int max = int.MinValue;
            for (Node p = Phead; p != null; p = p.Next)
                if (p.Data > max) max = p.Data;
            Console.WriteLine("a. Phần tử lớn nhất: " + max);
        }

        long t = 0;
        for (Node p = Phead; p != null; p = p.Next)
            t += p.Data;
        Console.WriteLine("b. Tổng các phần tử: " + t);

        int demNT = 0;
        for (Node p = Phead; p != null; p = p.Next)
            if (KTNT(p.Data)) demNT++;
        Console.WriteLine("c. Số nguyên tố: " + demNT);

        int demAm = 0, demKhong = 0, demDuong = 0;
        for (Node p = Phead; p != null; p = p.Next)
        {
            if (p.Data < 0) demAm++;
            else if (p.Data > 0) demDuong++;
            else demKhong++;
        }
        Console.WriteLine($"d. Số âm: {demAm}, số bằng 0: {demKhong}, số dương: {demDuong}");

        int x;
        do
        {
            Console.Write("Nhập x: ");
        } while (!int.TryParse(Console.ReadLine(), out x));

        int demX = 0;
        for (Node p = Phead; p != null; p = p.Next)
            if (p.Data == x) demX++;
        Console.WriteLine($"e. Số phần tử bằng {x}: {demX}");

        int minduong = int.MaxValue;
        for (Node p = Phead; p != null; p = p.Next)
            if (p.Data > 0 && p.Data < minduong) minduong = p.Data;

        if (minduong == int.MaxValue)
            Console.WriteLine("f. Không có phần tử dương.");
        else
            Console.WriteLine("f. Phần tử dương nhỏ nhất: " + minduong);
    }
    static void Bai7()
    {
        int n;
        do
        {
            Console.Write("Nhập số ngày n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        double[] nd = new double[n];

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("Nhiệt độ ngày " + (i + 1) + ": ");
            } while (!double.TryParse(Console.ReadLine().Replace(',', '.'),
                     System.Globalization.NumberStyles.Float,
                     System.Globalization.CultureInfo.InvariantCulture, out nd[i]));
        }

        int ngayMax = 0, ngayMin = 0;
        double tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += nd[i];
            if (nd[i] > nd[ngayMax]) ngayMax = i;
            if (nd[i] < nd[ngayMin]) ngayMin = i;
        }

        double tb = tong / n;

        Console.WriteLine("Ngày nóng nhất: ngày {0} ({1} độ)", ngayMax + 1, nd[ngayMax]);
        Console.WriteLine("Ngày lạnh nhất: ngày {0} ({1} độ)", ngayMin + 1, nd[ngayMin]);
        Console.WriteLine("Nhiệt độ trung bình: {0:F2} độ", tb);
    }

    static void Bai8()
    {
        Console.Write("Nhập một chuỗi văn bản: ");
        string s = Console.ReadLine() ?? "";

        s = s.ToLower();
        StringBuilder sb = new StringBuilder();
        foreach (char ch in s)
            sb.Append(char.IsLetterOrDigit(ch) ? ch : ' ');
        s = sb.ToString();

        string[] tu = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dem = new Dictionary<string, int>();
        foreach (string w in tu)
        {
            if (dem.ContainsKey(w)) dem[w]++;
            else dem[w] = 1;
        }

        Console.WriteLine("\nTừ          Số lần");
        foreach (var kv in dem.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            Console.WriteLine("{0,-12}{1}", kv.Key, kv.Value);
    }

    static void Bai9()
    {
        bool ktNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        bool ktHoanHao(int x)
        {
            if (x < 2) return false;
            int tong = 1;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0)
                {
                    tong += i;
                    if (i != x / i) tong += x / i;
                }
            return tong == x;
        }

        int n;
        do
        {
            Console.Write("Nhập số phần tử n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.Write("a[" + i + "] = ");
            } while (!int.TryParse(Console.ReadLine(), out a[i]));
        }

        Console.Write("Số nguyên tố: ");
        int d1 = 0;
        for (int i = 0; i < n; i++)
            if (ktNguyenTo(a[i])) { Console.Write(a[i] + " "); d1++; }
        Console.WriteLine("(" + d1 + " số)");

        Console.Write("Số chẵn: ");
        int d2 = 0;
        for (int i = 0; i < n; i++)
            if (a[i] % 2 == 0) { Console.Write(a[i] + " "); d2++; }
        Console.WriteLine("(" + d2 + " số)");

        Console.Write("Số hoàn hảo: ");
        int d3 = 0;
        for (int i = 0; i < n; i++)
            if (ktHoanHao(a[i])) { Console.Write(a[i] + " "); d3++; }
        Console.WriteLine("(" + d3 + " số)");
    }

    static void Bai10()
    {
        int m, n;
        do
        {
            Console.Write("Số dòng m: ");
        } while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);
        do
        {
            Console.Write("Số cột n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        int[,] a = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                do
                {
                    Console.Write("a[" + i + "," + j + "] = ");
                } while (!int.TryParse(Console.ReadLine(), out a[i, j]));
            }

        int top = 0, bottom = m - 1, left = 0, right = n - 1;

        Console.Write("Thứ tự xoắn ốc: ");
        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
                Console.Write(a[top, j] + " ");
            top++;

            for (int i = top; i <= bottom; i++)
                Console.Write(a[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                    Console.Write(a[bottom, j] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    Console.Write(a[i, left] + " ");
                left++;
            }
        }
        Console.WriteLine();
    }

    static void Bai11()
    {
        int n;
        do
        {
            Console.Write("Nhập cấp n của ma trận vuông: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                do
                {
                    Console.Write("matrix[" + i + "," + j + "] = ");
                } while (!int.TryParse(Console.ReadLine(), out matrix[i, j]));
            }

        bool donVi = true;
        for (int i = 0; i < n && donVi; i++)
            for (int j = 0; j < n; j++)
            {
                int canCo = (i == j) ? 1 : 0;
                if (matrix[i, j] != canCo) { donVi = false; break; }
            }

        bool doiXung = true;
        for (int i = 0; i < n && doiXung; i++)
            for (int j = i + 1; j < n; j++)
                if (matrix[i, j] != matrix[j, i]) { doiXung = false; break; }

        Console.WriteLine("Ma trận đơn vị: " + (donVi ? "Có" : "Không"));
        Console.WriteLine("Ma trận đối xứng: " + (doiXung ? "Có" : "Không"));
    }

    static void Bai12()
    {
        int m, n, k;
        do
        {
            Console.Write("Số dòng m: ");
        } while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);
        do
        {
            Console.Write("Số cột n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
        do
        {
            Console.Write("Số min (0.." + (m * n) + "): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 0 || k > m * n);

        bool[,] min = new bool[m, n];

        Random rd = new Random();
        int daDat = 0;
        while (daDat < k)
        {
            int i = rd.Next(m);
            int j = rd.Next(n);
            if (!min[i, j])
            {
                min[i, j] = true;
                daDat++;
            }
        }

        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        int[,] so = new int[m, n];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if (min[i, j]) continue;
                int dem = 0;
                for (int h = 0; h < 8; h++)
                {
                    int x = i + dx[h];
                    int y = j + dy[h];
                    if (x >= 0 && x < m && y >= 0 && y < n && min[x, y])
                        dem++;
                }
                so[i, j] = dem;
            }

        Console.WriteLine("\nBảng Minesweeper (* là min, số là số min xung quanh):");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write((min[i, j] ? "*" : so[i, j].ToString()) + " ");
            Console.WriteLine();
        }
    }

    static void Bai13()
    {
        int n;
        do
        {
            Console.Write("Số phần tử: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        Node head = null, tail = null;
        for (int i = 0; i < n; i++)
        {
            int v;
            do
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
            } while (!int.TryParse(Console.ReadLine(), out v));

            Node p = new Node();
            p.Data = v;
            p.Next = null;
            if (head == null) { head = p; tail = p; }
            else { tail.Next = p; tail = p; }
        }

        Console.Write("Danh sách ban đầu: ");
        for (Node p = head; p != null; p = p.Next)
            Console.Write(p.Data + " ");
        Console.WriteLine();

        Node prev = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        head = prev;

        Console.Write("Danh sách sau khi đảo ngược: ");
        for (Node p = head; p != null; p = p.Next)
            Console.Write(p.Data + " ");
        Console.WriteLine();
    }

    static void Bai14()
    {
        Node nhapTangDan(string ten)
        {
            int soPT;
            do
            {
                Console.Write("Số phần tử của " + ten + ": ");
            } while (!int.TryParse(Console.ReadLine(), out soPT) || soPT < 0);

            Node dau = null, cuoi = null;
            int truoc = int.MinValue;
            for (int i = 0; i < soPT; i++)
            {
                int v;
                do
                {
                    Console.Write("  Phần tử thứ " + (i + 1) + " (>= " + (i == 0 ? "tùy ý" : truoc.ToString()) + "): ");
                } while (!int.TryParse(Console.ReadLine(), out v) || v < truoc);
                truoc = v;

                Node p = new Node();
                p.Data = v;
                p.Next = null;
                if (dau == null) { dau = p; cuoi = p; }
                else { cuoi.Next = p; cuoi = p; }
            }
            return dau;
        }

        Console.WriteLine("(Nhập các danh sách theo thứ tự tăng dần)");
        Node l1 = nhapTangDan("danh sách 1");
        Node l2 = nhapTangDan("danh sách 2");

        Node ketQua = new Node();
        Node ketCuoi = ketQua;

        Node p1 = l1, p2 = l2;
        while (p1 != null && p2 != null)
        {
            Node moi = new Node();
            if (p1.Data <= p2.Data)
            {
                moi.Data = p1.Data;
                p1 = p1.Next;
            }
            else
            {
                moi.Data = p2.Data;
                p2 = p2.Next;
            }
            ketCuoi.Next = moi;
            ketCuoi = moi;
        }

        for (Node q = (p1 != null ? p1 : p2); q != null; q = q.Next)
        {
            Node moi = new Node();
            moi.Data = q.Data;
            ketCuoi.Next = moi;
            ketCuoi = moi;
        }

        Console.Write("Danh sách sau khi gộp: ");
        for (Node q = ketQua.Next; q != null; q = q.Next)
            Console.Write(q.Data + " ");
        Console.WriteLine();
    }

    static void Bai15()
    {
        int n;
        do
        {
            Console.Write("Số phần tử: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

        Node head = null, tail = null;
        for (int i = 0; i < n; i++)
        {
            int v;
            do
            {
                Console.Write("Phần tử thứ " + (i + 1) + ": ");
            } while (!int.TryParse(Console.ReadLine(), out v));

            Node p = new Node();
            p.Data = v;
            p.Next = null;
            if (head == null) { head = p; tail = p; }
            else { tail.Next = p; tail = p; }
        }

        if (head == null)
        {
            Console.WriteLine("Danh sách rỗng, không có chu trình.");
            return;
        }

        int pos;
        do
        {
            Console.Write("Nút cuối trỏ về vị trí nào (0.." + (n - 1) + ", -1 = không tạo chu trình): ");
        } while (!int.TryParse(Console.ReadLine(), out pos) || pos < -1 || pos >= n);

        if (pos >= 0)
        {
            Node dich = head;
            for (int i = 0; i < pos; i++) dich = dich.Next;
            tail.Next = dich;
        }

        Node slow = head;
        Node fast = head;
        bool coChuTrinh = false;
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if (slow == fast)
            {
                coChuTrinh = true;
                break;
            }
        }

        if (!coChuTrinh)
        {
            Console.WriteLine("Danh sách KHÔNG có chu trình.");
        }
        else
        {
            slow = head;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            Console.WriteLine("Danh sách CÓ chu trình, bắt đầu tại nút có giá trị " + slow.Data);
        }
    }

    static void Bai16()
    {
        DNode current = null;

        int chon;
        do
        {
            Console.WriteLine("\n1. Truy cập trang mới   2. Back   3. Forward   4. Xem lịch sử   0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    {
                        Console.Write("Nhập địa chỉ trang web: ");
                        DNode moi = new DNode();
                        moi.Data = Console.ReadLine();
                        if (current != null)
                        {
                            current.Next = moi;
                            moi.Prev = current;
                        }
                        current = moi;
                        Console.WriteLine("Đang ở: " + current.Data);
                        break;
                    }
                case 2:
                    if (current != null && current.Prev != null)
                    {
                        current = current.Prev;
                        Console.WriteLine("Đang ở: " + current.Data);
                    }
                    else Console.WriteLine("Không thể Back.");
                    break;
                case 3:
                    if (current != null && current.Next != null)
                    {
                        current = current.Next;
                        Console.WriteLine("Đang ở: " + current.Data);
                    }
                    else Console.WriteLine("Không thể Forward.");
                    break;
                case 4:
                    if (current == null) { Console.WriteLine("Lịch sử rỗng."); break; }
                    DNode q = current;
                    while (q.Prev != null) q = q.Prev;
                    Console.Write("Lịch sử: ");
                    for (; q != null; q = q.Next)
                        Console.Write(q == current ? "[" + q.Data + "] " : q.Data + " ");
                    Console.WriteLine();
                    break;
            }
        } while (chon != 0);
    }

    static void Bai17()
    {
        DNode head = null, tail = null, current = null;

        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm bài hát   2. Xóa bài hát   3. Next   4. Previous   5. Xem playlist   0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    {
                        Console.Write("Tên bài hát: ");
                        DNode moi = new DNode();
                        moi.Data = Console.ReadLine();
                        if (head == null)
                        {
                            head = moi; tail = moi; current = moi;
                        }
                        else
                        {
                            tail.Next = moi;
                            moi.Prev = tail;
                            tail = moi;
                        }
                        Console.WriteLine("Đã thêm: " + moi.Data);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Tên bài hát cần xóa: ");
                        string ten = Console.ReadLine();
                        DNode xoa = head;
                        while (xoa != null && xoa.Data != ten) xoa = xoa.Next;

                        if (xoa == null)
                        {
                            Console.WriteLine("Không tìm thấy bài hát.");
                            break;
                        }
                        if (xoa.Prev != null) xoa.Prev.Next = xoa.Next; else head = xoa.Next;
                        if (xoa.Next != null) xoa.Next.Prev = xoa.Prev; else tail = xoa.Prev;
                        if (current == xoa)
                            current = (xoa.Next != null) ? xoa.Next : xoa.Prev;
                        Console.WriteLine("Đã xóa: " + ten);
                        break;
                    }
                case 3:
                    if (current != null && current.Next != null)
                    {
                        current = current.Next;
                        Console.WriteLine("Đang phát: " + current.Data);
                    }
                    else Console.WriteLine("Đây là bài cuối.");
                    break;
                case 4:
                    if (current != null && current.Prev != null)
                    {
                        current = current.Prev;
                        Console.WriteLine("Đang phát: " + current.Data);
                    }
                    else Console.WriteLine("Đây là bài đầu.");
                    break;
                case 5:
                    if (head == null) { Console.WriteLine("Playlist rỗng."); break; }
                    Console.Write("Playlist: ");
                    for (DNode q = head; q != null; q = q.Next)
                        Console.Write(q == current ? "[" + q.Data + "] " : q.Data + " ");
                    Console.WriteLine();
                    Console.WriteLine("Đang phát: " + current.Data);
                    break;
            }
        } while (chon != 0);
    }

    static void Bai18()
    {
        DNode choXuLy = new DNode { Data = "Chờ xử lý" };
        DNode dangGiao = new DNode { Data = "Đang giao" };
        DNode hoanThanh = new DNode { Data = "Hoàn thành" };
        choXuLy.Next = dangGiao; dangGiao.Prev = choXuLy;
        dangGiao.Next = hoanThanh; hoanThanh.Prev = dangGiao;

        List<DonHang> ds = new List<DonHang>();

        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm đơn hàng   2. Chuyển trạng thái tiếp   3. Quay lại trạng thái trước   4. Xem đơn hàng   0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    {
                        Console.Write("Mã đơn hàng: ");
                        string ma = Console.ReadLine();
                        if (ds.Any(x => x.Ma == ma)) { Console.WriteLine("Mã đã tồn tại."); break; }
                        ds.Add(new DonHang { Ma = ma, TrangThai = choXuLy });
                        Console.WriteLine("Đã thêm đơn " + ma + " (Chờ xử lý).");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Mã đơn hàng: ");
                        string ma = Console.ReadLine();
                        DonHang dh = ds.FirstOrDefault(x => x.Ma == ma);
                        if (dh == null) Console.WriteLine("Không tìm thấy đơn hàng.");
                        else if (dh.TrangThai.Next == null) Console.WriteLine("Đơn đã hoàn thành, không thể chuyển tiếp.");
                        else
                        {
                            dh.TrangThai = dh.TrangThai.Next;
                            Console.WriteLine("Đơn {0} -> {1}", dh.Ma, dh.TrangThai.Data);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Write("Mã đơn hàng: ");
                        string ma = Console.ReadLine();
                        DonHang dh = ds.FirstOrDefault(x => x.Ma == ma);
                        if (dh == null) Console.WriteLine("Không tìm thấy đơn hàng.");
                        else if (dh.TrangThai.Prev == null) Console.WriteLine("Đơn đang ở trạng thái đầu, không thể quay lại.");
                        else
                        {
                            dh.TrangThai = dh.TrangThai.Prev;
                            Console.WriteLine("Đơn {0} -> {1}", dh.Ma, dh.TrangThai.Data);
                        }
                        break;
                    }
                case 4:
                    if (ds.Count == 0) Console.WriteLine("Chưa có đơn hàng.");
                    foreach (DonHang it in ds)
                        Console.WriteLine("{0,-10} {1}", it.Ma, it.TrangThai.Data);
                    break;
            }
        } while (chon != 0);
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Bài 1 ===");
        Bai1();
        Console.WriteLine("\n=== Bài 2 ===");
        Bai2();
        Console.WriteLine("\n=== Bài 3 ===");
        Bai3();
        Console.WriteLine("\n=== Bài 4 ===");
        Bai4();
        Console.WriteLine("\n=== Bài 5 ===");
        Bai5();
        Console.WriteLine("\n=== Bài 7 ===");
        Bai7();
        Console.WriteLine("\n=== Bài 8 ===");
        Bai8();
        Console.WriteLine("\n=== Bài 9 ===");
        Bai9();
        Console.WriteLine("\n=== Bài 10 ===");
        Bai10();
        Console.WriteLine("\n=== Bài 11 ===");
        Bai11();
        Console.WriteLine("\n=== Bài 12 ===");
        Bai12();
        Console.WriteLine("\n=== Bài 13 ===");
        Bai13();
        Console.WriteLine("\n=== Bài 14 ===");
        Bai14();
        Console.WriteLine("\n=== Bài 15 ===");
        Bai15();
        Console.WriteLine("\n=== Bài 16 ===");
        Bai16();
        Console.WriteLine("\n=== Bài 17 ===");
        Bai17();
        Console.WriteLine("\n=== Bài 18 ===");
        Bai18();
    }
}