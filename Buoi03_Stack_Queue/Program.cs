using System.Collections;
using System.Security.Cryptography.X509Certificates;

struct FrameStack
{
    public string ten;
    public string thamso;
    public string diachitrave;
}
struct YeuCau
{
    public string ten;
    public int sotrang;
}
struct Goitin
{
    public int STT;
    public string noidung;
}
struct KhachHang
{
    public int STT;
    public string ten;
    public DateTime TGden;
    public string LoaiDV;
}
class Program
{
    static void Bai1()
    {
        Stack<char> stk = new Stack<char>();
        string input;

        do
        {
            Console.Write("Nhập biểu thức: ");
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(' || input[i] == '[' || input[i] == '{')
            {
                stk.Push(input[i]);
            }
            else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
            {
                if (stk.Count == 0)
                {
                    Console.WriteLine("Chuỗi không hợp lệ");
                    return;
                }
                char top = stk.Pop();
                if ((input[i] == ')' && top != '(') ||
                   (input[i] == ']' && top != '[') ||
                   (input[i] == '}' && top != '{'))
                {
                    Console.WriteLine("Chuỗi không hợp lệ");
                    return;
                }
            }
        }
        if (stk.Count == 0)
        {
            Console.WriteLine("Chuỗi hợp lệ");
        }
        else
        {
            Console.WriteLine("Chuỗi không hợp lệ");
        }
    }
    static void Bai2()
    {
        Stack<string> back = new Stack<string>();
        Stack<string> forward = new Stack<string>();
        string current = null;

        int chon;
        do
        {
            Console.WriteLine("\n1. Truy cập trang mới");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("4. Xem lịch sử");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    Console.WriteLine("Bạn chọn: truy cập trang mới");
                    if (current != null)
                    {
                        back.Push(current);
                        forward.Clear();
                    }
                    do
                    {
                        Console.Write("Nhập URL: ");
                        current = Console.ReadLine();
                    }while (string.IsNullOrEmpty(current));
                    Console.WriteLine($"Đang truy cập: {current}");
                    break;
                case 2:
                    Console.WriteLine("Bạn chọn: Back");
                    if (back.Count > 0)
                    {
                        forward.Push(current);
                        current = back.Pop();
                    }
                    else { Console.WriteLine("Không có trang để quay lại"); }
                    Console.WriteLine($"Đang truy cập: {current}");
                    break;
                case 3:
                    Console.WriteLine("Bạn chọn: Forward");
                    if (forward.Count > 0)
                    {
                        back.Push(current);
                        current = forward.Pop();
                    }
                    else { Console.WriteLine("Không có trang để tiến tới"); }
                    Console.WriteLine($"Đang truy cập: {current}");
                    break;
                case 4:
                    Console.WriteLine("Bạn chọn: Xem lịch sử");
                    foreach (var url in back.Reverse())
                    {
                        Console.Write(url + " ");
                    }
                    Console.Write($"[{current}]" + " ");
                    foreach (var url in forward)
                    {
                        Console.Write(url + " ");
                    }
                    break;
            }
        } while (chon != 0);
    }
    static void Bai3()
    {
        Stack<FrameStack> callstack = new Stack<FrameStack>();
        void DefaultFrame()
        {
            FrameStack fsk = new FrameStack();
            fsk.ten = "Main";
            fsk.thamso = "";
            fsk.diachitrave = "hdh";
            callstack.Push(fsk);
        }
        DefaultFrame();
        int chon;
        do
        {
            Console.WriteLine("\n1. Gọi hàm");
            Console.WriteLine("2. Trả về");
            Console.WriteLine("3. Xem call stack");
            Console.WriteLine("0. Thoát");
            
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));
            switch (chon)
            {
                case 1:
                    FrameStack fsk = new FrameStack();
                    Console.Write("Nhập tên hàm: ");
                    fsk.ten = Console.ReadLine();
                    Console.Write("Nhập tham số: ");
                    fsk.thamso = Console.ReadLine();

                    fsk.diachitrave = callstack.Peek().ten;
                    callstack.Push(fsk);
                    Console.WriteLine($"Gọi hàm {fsk.ten} từ hàm {fsk.diachitrave}");
                    break;
                case 2:
                    if (callstack.Count > 1)
                    {
                        Console.WriteLine($"Hàm {callstack.Peek().ten} kết thúc, trả về hàm {callstack.Peek().diachitrave}");
                        callstack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Không thể trả về từ hàm Main");
                    }
                    break;
                case 3:
                    Console.WriteLine("Call Stack:");
                    foreach (var frame in callstack)
                    {
                        Console.WriteLine($"  - {frame.ten} ({frame.thamso})     - {frame.diachitrave}");
                    }
                    break;
            }
        } while (chon != 0);
        
    }
    static void Bai4()
    {
        Queue<YeuCau> q = new Queue<YeuCau>();
        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm yêu cầu");
            Console.WriteLine("2. Xử lý yêu cầu");
            Console.WriteLine("3. Xem hàng đợi");
            Console.WriteLine("0. Thoát");

            do
            {
                Console.Write("Chọn: ");
            }while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    YeuCau yc = new YeuCau();
                    Console.Write("Nhập tên yêu cầu: ");
                    yc.ten = Console.ReadLine();
                    int soTrang;
                    do
                    {
                        Console.Write("Nhập số trang: ");
                    } while (!int.TryParse(Console.ReadLine(), out soTrang) || soTrang <= 0);
                    yc.sotrang = soTrang;
                    q.Enqueue(yc);
                    Console.WriteLine($"Yêu cầu {yc.ten} với {yc.sotrang} trang đã được thêm vào hàng đợi");
                    break;
                case 2:
                    if (q.Count > 0)
                    {
                        YeuCau processed = q.Dequeue();
                        Console.WriteLine($"Yêu cầu {processed.ten} với {processed.sotrang} trang đã được xử lý");
                    }
                    else
                    {
                        Console.WriteLine("Không có yêu cầu nào để xử lý");
                    }
                    break;
                case 3:
                    if (q.Count > 0)
                    {
                        Console.WriteLine("Hàng đợi yêu cầu:");
                        foreach (var item in q)
                        {
                            Console.WriteLine($"  - {item.ten} ({item.sotrang} trang)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hàng đợi yêu cầu trống");
                    }
                    break;
            }
        } while (chon != 0);
    }
    static void Bai5()
    {
        Queue<Goitin> q = new Queue<Goitin>();
        int stt = 0;
        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm gói tin");
            Console.WriteLine("2. Xử lý gói tin");
            Console.WriteLine("3. Xem hàng đợi");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));
            switch (chon)
            {
                case 1:
                    Goitin gt = new Goitin();
                   
                    gt.STT = ++stt;
                    Console.Write("Nhập nội dung: ");
                    gt.noidung = Console.ReadLine();
                    q.Enqueue(gt);
                    Console.WriteLine($"Gói tin {gt.STT} với nội dung \"{gt.noidung}\" đã được thêm vào hàng đợi");
                    break;
                case 2:
                    if (q.Count > 0)
                    {
                        Goitin processed = q.Dequeue();
                        Console.WriteLine($"Gói tin {processed.STT} với nội dung \"{processed.noidung}\" đã được xử lý");
                    }
                    else
                    {
                        Console.WriteLine("Không có gói tin nào để xử lý");
                    }
                    break;
                case 3:
                    if (q.Count > 0)
                    {
                        Console.WriteLine("Hàng đợi gói tin:");
                        foreach (var item in q)
                        {
                            Console.WriteLine($"  - Gói tin {item.STT}: \"{item.noidung}\"");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hàng đợi gói tin trống");
                    }
                    break;
            }
        } while (chon != 0);
    }
    static void Bai6()
    {
        Queue<KhachHang> q = new Queue<KhachHang>();
        int STT = 0;
        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm khách hàng");
            Console.WriteLine("2. Xử lý khách hàng");
            Console.WriteLine("3. Xem hàng đợi");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));
            switch (chon)
            {
                case 1:
                    KhachHang kh = new KhachHang();
                    kh.STT = ++STT;
                    Console.Write("Nhập tên khách hàng: ");
                    kh.ten = Console.ReadLine();
                    kh.TGden = DateTime.Now;
                    Console.Write("Nhập loại dịch vụ: ");
                    kh.LoaiDV = Console.ReadLine();
                    q.Enqueue(kh);
                    Console.WriteLine($"Khách hàng {kh.ten} đã được thêm vào hàng đợi");
                    break;
                case 2:
                    if (q.Count > 0)
                    {
                        KhachHang processed = q.Dequeue();
                        Console.WriteLine($"Khách hàng {processed.ten} với loại dịch vụ {processed.LoaiDV} đã được xử lý");
                        TimeSpan cho = DateTime.Now - processed.TGden;
                        Console.WriteLine($"Đã chờ {cho.TotalSeconds:F0} giây");
                    }
                    else
                    {
                        Console.WriteLine("Không có khách hàng nào để xử lý");
                    }
                    break;
                case 3:
                    if (q.Count > 0)
                    {
                        Console.WriteLine($"Số khách đang chờ: {q.Count}");
                        Console.WriteLine($"Khách tiếp theo: {q.Peek().ten}");
                        Console.WriteLine("Hàng đợi khách hàng:");
                        foreach (var item in q)
                        {
                            Console.WriteLine($"  - {item.STT}. {item.ten} ({item.TGden.ToString("HH:mm:ss")}) - {item.LoaiDV}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hàng đợi khách hàng trống");
                    }
                    break;
            }
        } while (chon != 0);
    }
    static void BaiBS4()
    {
        Stack<string> backStack = new Stack<string>();
        Stack<string> forwardStack = new Stack<string>();
        string currentPage = null;

        void Visit(string url)
        {
            if (currentPage != null)
                backStack.Push(currentPage);
            forwardStack.Clear();
            currentPage = url;
            Console.WriteLine($"Đang truy cập: {currentPage}");
        }


        void Back()
        {
            if (backStack.Count > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
                Console.WriteLine($"Quay lại: {currentPage}");
            }
            else
            {
                Console.WriteLine("Không thể quay lại");
            }
        }


        void Forward()
        {
            if (forwardStack.Count > 0)
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
                Console.WriteLine($"Tiến lên: {currentPage}");
            }
            else
            {
                Console.WriteLine("Không thể tiến lên");
            }
        }

        void ShowCurrentPage()
        {
            if (currentPage != null)
                Console.WriteLine($"Trang hiện tại: {currentPage}");
            else
                Console.WriteLine("Chưa truy cập trang nào");
        }

        int chon;
        do
        {
            Console.WriteLine("\n=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===");
            Console.WriteLine("1. Truy cập trang mới");
            Console.WriteLine("2. Quay lại");
            Console.WriteLine("3. Tiến lên");
            Console.WriteLine("4. Hiển thị trang hiện tại");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    string nhapUrl;
                    do
                    {
                        Console.Write("Nhập URL: ");
                        nhapUrl = Console.ReadLine();
                    } while (string.IsNullOrEmpty(nhapUrl));
                    Visit(nhapUrl);
                    break;
                case 2:
                    Back();
                    break;
                case 3:
                    Forward();
                    break;
                case 4:
                    ShowCurrentPage();
                    break;
            }
        } while (chon != 0);
    }
    static void BaiBS5()
    {
        Stack<char> stk = new Stack<char>();

        string xau;
        bool hopLe;
        do
        {
            Console.Write("Nhập chuỗi chỉ gồm '(' và ')': ");
            xau = Console.ReadLine();
            hopLe = !string.IsNullOrEmpty(xau);
            if (hopLe)
            {
                for (int i = 0; i < xau.Length; i++)
                {
                    if (xau[i] != '(' && xau[i] != ')')
                    {
                        hopLe = false;
                        break;
                    }
                }
            }
            if (!hopLe)
                Console.WriteLine("Chuỗi chỉ được chứa ký tự '(' và ')'");
        } while (!hopLe);

        for (int i = 0; i < xau.Length; i++)
        {
            if (xau[i] == '(')
            {
                stk.Push(xau[i]);
            }
            else
            {
                if (stk.Count == 0)
                {
                    Console.WriteLine("Xâu sai");
                    return;
                }
                stk.Pop();
            }
        }

        if (stk.Count == 0)
            Console.WriteLine("Xâu đúng");
        else
            Console.WriteLine("Xâu sai");
    }
    static void BaiBS6()
    {
        Queue<string> q = new Queue<string>();

        void ThemYeuCauIn()
        {
            string ten;
            do
            {
                Console.Write("Nhập tên tài liệu: ");
                ten = Console.ReadLine();
            } while (string.IsNullOrEmpty(ten));
            q.Enqueue(ten);
            Console.WriteLine($"Yêu cầu in \"{ten}\" đã được thêm vào hàng đợi");
        }

        void XuLyYeuCauIn()
        {
            if (q.Count > 0)
            {
                string processed = q.Dequeue();
                Console.WriteLine($"Đã in xong tài liệu \"{processed}\"");
            }
            else
            {
                Console.WriteLine("Không có yêu cầu in nào!");
            }
        }

        void HienThiHangDoi()
        {
            if (q.Count > 0)
            {
                Console.WriteLine("Hàng đợi yêu cầu in:");
                foreach (var item in q)
                {
                    Console.WriteLine($"  - {item}");
                }
            }
            else
            {
                Console.WriteLine("Hàng đợi yêu cầu in trống");
            }
        }

        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm yêu cầu in");
            Console.WriteLine("2. Xử lý yêu cầu in");
            Console.WriteLine("3. Hiển thị danh sách hàng đợi");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    ThemYeuCauIn();
                    break;
                case 2:
                    XuLyYeuCauIn();
                    break;
                case 3:
                    HienThiHangDoi();
                    break;
            }
        } while (chon != 0);
    }
    static void BaiBS7()
    {
        Queue<string> q = new Queue<string>();

        void GuiDuLieu()
        {
            string goi;
            do
            {
                Console.Write("Nhập gói dữ liệu: ");
                goi = Console.ReadLine();
            } while (string.IsNullOrEmpty(goi));
            q.Enqueue(goi);
            Console.WriteLine($"Đã gửi gói dữ liệu: {goi}");
        }

        void NhanDuLieu()
        {
            if (q.Count > 0)
            {
                string processed = q.Dequeue();
                Console.WriteLine($"Đã nhận gói dữ liệu: {processed}");
            }
            else
            {
                Console.WriteLine("Không có dữ liệu để nhận!");
            }
        }

        void HienThiDuLieu()
        {
            if (q.Count > 0)
            {
                Console.WriteLine("Các gói dữ liệu trong hàng đợi:");
                foreach (var item in q)
                {
                    Console.WriteLine($"  - {item}");
                }
            }
            else
            {
                Console.WriteLine("Hàng đợi trống");
            }
        }

        int chon;
        do
        {
            Console.WriteLine("\n1. Gửi dữ liệu");
            Console.WriteLine("2. Nhận dữ liệu");
            Console.WriteLine("3. Hiển thị dữ liệu trong hàng đợi");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    GuiDuLieu();
                    break;
                case 2:
                    NhanDuLieu();
                    break;
                case 3:
                    HienThiDuLieu();
                    break;
            }
        } while (chon != 0);
    }
    static void BaiBS8()
    {
        Queue<string> q = new Queue<string>();

        void ThemKhachHang()
        {
            string khach;
            do
            {
                Console.Write("Nhập tên hoặc số thứ tự khách hàng: ");
                khach = Console.ReadLine();
            } while (string.IsNullOrEmpty(khach));
            q.Enqueue(khach);
            Console.WriteLine($"Khách hàng {khach} đã được thêm vào hàng đợi");
        }

        void PhucVuKhachHang()
        {
            if (q.Count > 0)
            {
                string processed = q.Dequeue();
                Console.WriteLine($"Đang phục vụ khách hàng: {processed}");
            }
            else
            {
                Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
            }
        }

        void HienThiKhachCho()
        {
            if (q.Count > 0)
            {
                Console.WriteLine("Danh sách khách hàng chờ:");
                foreach (var item in q)
                {
                    Console.WriteLine($"  - {item}");
                }
            }
            else
            {
                Console.WriteLine("Không có khách hàng nào trong hàng đợi!");
            }
        }

        int chon;
        do
        {
            Console.WriteLine("\n1. Thêm khách hàng");
            Console.WriteLine("2. Phục vụ khách hàng");
            Console.WriteLine("3. Hiển thị danh sách khách hàng chờ");
            Console.WriteLine("0. Thoát");
            do
            {
                Console.Write("Chọn: ");
            } while (!int.TryParse(Console.ReadLine(), out chon));

            switch (chon)
            {
                case 1:
                    ThemKhachHang();
                    break;
                case 2:
                    PhucVuKhachHang();
                    break;
                case 3:
                    HienThiKhachCho();
                    break;
            }
        } while (chon != 0);
    }
    static void BaiBS9()
    {
        Stack<float> stk = new Stack<float>();
        string bt;
        do
        {
            Console.Write("Nhập biểu thức hậu tố (cách nhau bởi dấu cách): ");
            bt = Console.ReadLine();
        } while (string.IsNullOrEmpty(bt));

        string[] tokens = bt.Trim().Split(' ');

        foreach (var token in tokens)
        {
            if (float.TryParse(token, out float number))
            {
                stk.Push(number);
            }
            else
            {
                if (stk.Count < 2)
                {
                    Console.WriteLine("Biểu thức không hợp lệ");
                    return;
                }
                float b = stk.Pop();
                float a = stk.Pop();
                
                switch(token)
                {
                    case "+":
                        stk.Push(a + b);
                        break;
                    case "-":
                        stk.Push(a - b);
                        break;
                    case "*":
                        stk.Push(a * b);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Lỗi: Chia cho 0");
                            return;
                        }
                        stk.Push(a / b);
                        break;
                    default:
                        Console.WriteLine($"Toán tử không hợp lệ: {token}");
                        return;
                }
            }
        }
        if (stk.Count != 1)
        {
            Console.WriteLine("Biểu thức không hợp lệ");
            return;
        }

        Console.WriteLine("Giá trị biểu thức hậu tố là: " + stk.Pop());

    }
    static void BaiBS10()
    {
        Stack<char> stk = new Stack<char>();
        string input;

        do
        {
            Console.Write("Nhập biểu thức: ");
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));

        if (input[0] == '+' || input[0] == '-' || input[0] == '*' || input[0] == '/')
        {
            Console.WriteLine("Chuỗi không hợp lệ");
            return;
        }

        bool ToanTu = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
            {
                if (ToanTu)
                {
                    Console.WriteLine("Chuỗi không hợp lệ");
                    return;
                }
                ToanTu = true;
            }
            else if (input[i] == '(' || input[i] == '[' || input[i] == '{')
            {
                stk.Push(input[i]);
            }
            else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
            {
                if (stk.Count == 0)
                {
                    Console.WriteLine("Chuỗi không hợp lệ");
                    return;
                }
                char top = stk.Pop();
                if ((input[i] == ')' && top != '(') ||
                   (input[i] == ']' && top != '[') ||
                   (input[i] == '}' && top != '{'))
                {
                    Console.WriteLine("Chuỗi không hợp lệ");
                    return;
                }
            }
        }
        if (stk.Count == 0)
        {
            Console.WriteLine("Chuỗi hợp lệ");
        }
        else
        {
            Console.WriteLine("Chuỗi không hợp lệ");
        }
    }
    static void BaiBS11()
    {
        string input;
        do
        {
            Console.Write("Nhập biểu thức trung tố: ");
            input = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(input));

        input = input.Trim();

        if (!KiemTraHopLe(input))
        {
            Console.WriteLine("Biểu thức không hợp lệ.");
            return;
        }

        int DoUuTien(char op)
        {
            if (op == '*' || op == '/')
            {
                return 2;
            }
            if (op == '+' || op == '-')
            {
                return 1;
            }
            return 0;
        }
        string TrungToSangHauTo(string expr)
        {
            Stack<char> stk = new Stack<char>();
            string ketQua = "";
            string soTam = "";

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c == ' ')
                {
                    continue;
                }

                if (char.IsDigit(c) || c == '.')
                {
                    soTam += c;
                }
                else
                {
                    if (soTam != "")
                    {
                        ketQua += soTam + " ";
                        soTam = "";
                    }

                    if (c == '(')
                    {
                        stk.Push(c);
                    }
                    else if (c == ')')
                    {
                        while (stk.Count > 0 && stk.Peek() != '(')
                        {
                            ketQua += stk.Pop() + " ";
                        }
                        if (stk.Count == 0)
                        {
                            return "";
                        }
                        stk.Pop();
                    }
                    else if (LaToanTu(c))
                    {
                        while (stk.Count > 0 && stk.Peek() != '(' && DoUuTien(stk.Peek()) >= DoUuTien(c))
                        {
                            ketQua += stk.Pop() + " ";
                        }
                        stk.Push(c);
                    }
                }
            }

            if (soTam != "")
            {
                ketQua += soTam + " ";
            }

            while (stk.Count > 0)
            {
                if (stk.Peek() == '(')
                {
                    return "";
                }
                ketQua += stk.Pop() + " ";
            }

            return ketQua.Trim();
        }
        bool TinhGiaTriHauTo(string hauTo, out float ketQua)
        {
            ketQua = 0;
            string[] tokens = hauTo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<float> stk = new Stack<float>();

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];

                if (float.TryParse(token, out float number))
                {
                    stk.Push(number);
                }
                else
                {
                    if (stk.Count < 2)
                    {
                        return false;
                    }

                    float b = stk.Pop();
                    float a = stk.Pop();

                    if (token == "+")
                    {
                        stk.Push(a + b);
                    }
                    else if (token == "-")
                    {
                        stk.Push(a - b);
                    }
                    else if (token == "*")
                    {
                        stk.Push(a * b);
                    }
                    else if (token == "/")
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Lỗi: Không thể chia cho 0.");
                            return false;
                        }
                        stk.Push(a / b);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stk.Count != 1)
            {
                return false;
            }

            ketQua = stk.Pop();
            return true;
        }
        bool LaToanTu(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
        bool KiemTraHopLe(string str)
        {
            if (LaToanTu(str[0]) || LaToanTu(str[str.Length - 1]))
            {
                return false;
            }

            Stack<char> stk = new Stack<char>();
            bool truocDoLaToanTu = false;
            bool coSo = false;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == ' ')
                {
                    continue;
                }

                if (char.IsDigit(c) || c == '.')
                {
                    coSo = true;
                    truocDoLaToanTu = false;
                }
                else if (LaToanTu(c))
                {
                    if (truocDoLaToanTu)
                    {
                        return false;
                    }
                    truocDoLaToanTu = true;
                }
                else if (c == '(')
                {
                    stk.Push(c);
                    truocDoLaToanTu = false;
                }
                else if (c == ')')
                {
                    if (stk.Count == 0 || stk.Pop() != '(')
                    {
                        return false;
                    }
                    truocDoLaToanTu = false;
                }
                else
                {
                    return false;
                }
            }

            return coSo && stk.Count == 0;
        }
        string hauTo = TrungToSangHauTo(input);

        if (string.IsNullOrEmpty(hauTo))
        {
            Console.WriteLine("Biểu thức không hợp lệ.");
            return;
        }

        if (!TinhGiaTriHauTo(hauTo, out float ketQua))
        {
            Console.WriteLine("Không thể tính giá trị biểu thức.");
            return;
        }

        Console.WriteLine("Biểu thức hậu tố: " + hauTo);
        Console.WriteLine("Kết quả: " + ketQua);
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Bài 1 ===");
        Bai1();
        Console.WriteLine("=== Bài 2 ===");
        Bai2();
        Console.WriteLine("=== Bài 3 ===");
        Bai3();
        Console.WriteLine("=== Bài 4 ===");
        Bai4();
        Console.WriteLine("=== Bài 5 ===");
        Bai5();
        Console.WriteLine("=== Bài 6 ===");
        Bai6();
        Console.WriteLine("=== Bài BS 4 ===");
        BaiBS4();
        Console.WriteLine("=== Bài BS 5 ===");
        BaiBS5();
        Console.WriteLine("=== Bài BS 6 ===");
        BaiBS6();
        Console.WriteLine("=== Bài BS 7 ===");
        BaiBS7();
        Console.WriteLine("=== Bài BS 8 ===");
        BaiBS8();
        Console.WriteLine("=== Bài BS 9 ===");
        BaiBS9();
        Console.WriteLine("=== Bài BS 10 ===");
        BaiBS10();
        Console.WriteLine("=== Bài BS 11 ===");
        BaiBS11();
    }
}

