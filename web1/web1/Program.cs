using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        double r;
        while (true)
        {
            Console.Write("Nhap ban kinh (r): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out r) && r > 0)
            {
                break; // Nhập đúng, thoát vòng lặp
            }
            else
            {
                Console.WriteLine("KO hop le: ");
            }
        }

        string result = TinhHinhTron(r);
        Console.WriteLine("Kết quả:");
        Console.WriteLine(result);
    }

    static string TinhHinhTron(double r)
    {
        // Tính toán các giá trị
        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        // Tạo đối tượng chứa các giá trị
        var ketQua = new
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        // Chuyển đổi đối tượng thành JSON string
        return JsonSerializer.Serialize(ketQua);
    }
}
