class NodeTree
{
    public int data;
    public NodeTree left;
    public NodeTree right;
    public NodeTree(int data)
    {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}
class Program
{
    static NodeTree GanGT()
    {
        NodeTree root = new NodeTree(8);
        root.left = new NodeTree(3);
        root.right = new NodeTree(10);
        root.left.left = new NodeTree(1);
        root.left.right = new NodeTree(22);
        root.right.right = new NodeTree(14);
        root.right.left = new NodeTree(6);
        root.left.right.left = new NodeTree(4);
        return root;
    }
    static void Bai1()
    {
        NodeTree root = GanGT();
        void InCay(NodeTree node, int sau)
        {
            
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        int DemNode(NodeTree node)
        {
            if (node == null)
                return 0;
            return 1 + DemNode(node.left) + DemNode(node.right);
        }
        
        Console.WriteLine("Cây (nằm ngang)");
        InCay(root, 0);
        int tong = DemNode(root);
        Console.WriteLine("Số nút trên cây: " + tong);
    }
    static void Bai2()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {

            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        int TinhGTNode(NodeTree node)
        {
            if (node == null)
                return 0;
            return node.data + TinhGTNode(node.left) + TinhGTNode(node.right);
        }

        Console.WriteLine("Cây (nằm ngang)");
        InCay(root, 0);
        int tong = TinhGTNode(root);
        Console.WriteLine("Tổng giá trị các nút trên cây: " + tong);
    }
    static void Bai3()
    {
        NodeTree root = GanGT();
        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }
        
        Console.WriteLine("Cây (nằm ngang)");
        InCay(root, 0);
    }
    static void Bai4()
    {
        NodeTree root = GanGT();
        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            if (node.data % 2 == 0)
            {
                Console.Write($"{node.data}" + " ");
            }
            InCay(node.left, sau + 1);
        }

        Console.Write("Giá trị các nút chẵn trên cây: ");
        InCay(root, 0);
        Console.WriteLine();

    }
    static void Bai5()
    {
        NodeTree root = GanGT();
        int TinhGTNodeChan(NodeTree node)
        {
            if (node == null)
                return 0;
            int tong = 0;
            if (node.data % 2 == 0)
                tong = node.data;
            return tong + TinhGTNodeChan(node.left) + TinhGTNodeChan(node.right);
        }
        Console.WriteLine("Tổng giá trị các nút chẵn trên cây: " + TinhGTNodeChan(root));
    }
    static void Bai6()
    {
        NodeTree root = GanGT();
        void InCay(NodeTree node, int sau)
        {

            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }
        Console.WriteLine("Cây (nằm ngang)");
        InCay(root, 0);

        int x;
        do
        {
            Console.Write("Nhập giá trị cần tìm: ");
        }while (!int.TryParse(Console.ReadLine(), out x));

        NodeTree  TimKiemNode(NodeTree node, int x)
        {
            if (node == null)
                return null;
            if (node.data == x)
            {
                return node;
            }
            NodeTree leftResult = TimKiemNode(node.left, x);
            if (leftResult != null)
                return leftResult;
            return TimKiemNode(node.right, x);
        }

        int count = 0;
        NodeTree NodeDem = TimKiemNode(root, x);
        if (NodeDem == null)
        {
            Console.WriteLine($"Không tìm thấy nút có giá trị {x}");
        }
        else
        {
            if (NodeDem.left != null)
                count += 1;
            if (NodeDem.right != null)
                count += 1;
            Console.WriteLine($"Số nút con của nút có giá trị {x}: {count}");
        }
    }
    static void Bai7()
    {
        NodeTree root = GanGT();
        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }
        Console.WriteLine("Cây nhị phân hoàn chỉnh (nằm ngang)");
        InCay(root, 0);
        
        Console.WriteLine("Cây con trái của cây nhị phân:");
        InCay(root.left, 0);
    }
    static void Bai8()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        void DuyetNLR(NodeTree node)
        {
            if (node == null)
                return;
            Console.Write(node.data + " ");
            DuyetNLR(node.left);
            DuyetNLR(node.right);
        }

        void DuyetLNR(NodeTree node)
        {
            if (node == null)
                return;
            DuyetLNR(node.left);
            Console.Write(node.data + " ");
            DuyetLNR(node.right);
        }

        void DuyetLRN(NodeTree node)
        {
            if (node == null)
                return;
            DuyetLRN(node.left);
            DuyetLRN(node.right);
            Console.Write(node.data + " ");
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);

        Console.Write("\nDuyệt NLR: ");
        DuyetNLR(root);
        Console.WriteLine();

        Console.Write("Duyệt LNR: ");
        DuyetLNR(root);
        Console.WriteLine();

        Console.Write("Duyệt LRN: ");
        DuyetLRN(root);
        Console.WriteLine();
    }
    static void BaiBS3()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        int Count(NodeTree node)
        {
            if (node == null)
                return 0;
            return 1 + Count(node.left) + Count(node.right);
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);
        Console.WriteLine("Tổng số nút của cây: " + Count(root));
    }
    static void BaiBS4()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        void Preorder(NodeTree node)
        {
            if (node == null)
                return;
            Console.Write(node.data + " ");
            Preorder(node.left);
            Preorder(node.right);
        }

        void Inorder(NodeTree node)
        {
            if (node == null)
                return;
            Inorder(node.left);
            Console.Write(node.data + " ");
            Inorder(node.right);
        }

        void Postorder(NodeTree node)
        {
            if (node == null)
                return;
            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.data + " ");
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);

        Console.Write("\nNLR (Pre-order):  ");
        Preorder(root);
        Console.WriteLine();

        Console.Write("LNR (In-order):   ");
        Inorder(root);
        Console.WriteLine();

        Console.Write("LRN (Post-order): ");
        Postorder(root);
        Console.WriteLine();
    }
    static void BaiBS5()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        long Sum(NodeTree node)
        {
            if (node == null)
                return 0;
            return node.data + Sum(node.left) + Sum(node.right);
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);
        Console.WriteLine("Tổng giá trị các nút: " + Sum(root));
    }
    static void BaiBS6()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        void PrintEven(NodeTree node)
        {
            if (node == null)
                return;
            if (node.data % 2 == 0)
                Console.Write(node.data + " ");
            PrintEven(node.left);
            PrintEven(node.right);
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);
        Console.Write("Các nút chẵn (NLR): ");
        PrintEven(root);
        Console.WriteLine();
    }
    static void BaiBS7()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        int CountEven(NodeTree node)
        {
            if (node == null)
                return 0;
            int dem = 0;
            if (node.data % 2 == 0)
                dem = 1;
            return dem + CountEven(node.left) + CountEven(node.right);
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);
        Console.WriteLine("Số nút có giá trị chẵn: " + CountEven(root));
    }
    static void BaiBS8()
    {
        NodeTree root = GanGT();

        void InCay(NodeTree node, int sau)
        {
            if (node == null)
                return;
            InCay(node.right, sau + 1);
            Console.WriteLine(new string(' ', 4 * sau) + node.data);
            InCay(node.left, sau + 1);
        }

        void Inorder(NodeTree node)
        {
            if (node == null)
                return;
            Inorder(node.left);
            Console.Write(node.data + " ");
            Inorder(node.right);
        }

        void PrintLeftSubtree(NodeTree node)
        {
            if (node == null || node.left == null)
            {
                Console.WriteLine("Cây rỗng hoặc gốc không có cây con trái!");
                return;
            }
            Inorder(node.left);
            Console.WriteLine();
        }

        Console.WriteLine("Cây (xoay ngang, gốc bên trái):");
        InCay(root, 0);
        Console.Write("Cây con trái của gốc (LNR): ");
        PrintLeftSubtree(root);
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
        Console.WriteLine("=== Bài 7 ===");
        Bai7();
        Console.WriteLine("=== Bài 8 ===");
        Bai8();
        Console.WriteLine("=== Bài Bổ Sung 3 ===");
        BaiBS3();
        Console.WriteLine("=== Bài Bổ Sung 4 ===");
        BaiBS4();
        Console.WriteLine("=== Bài Bổ Sung 5 ===");
        BaiBS5();
        Console.WriteLine("=== Bài Bổ Sung 6 ===");
        BaiBS6();
        Console.WriteLine("=== Bài Bổ Sung 7 ===");
        BaiBS7();
        Console.WriteLine("=== Bài Bổ Sung 8 ===");
        BaiBS8();
        Console.ReadKey();
    }
}