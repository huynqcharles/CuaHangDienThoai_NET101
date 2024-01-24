using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangDienThoai
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void MainMenu()
        {
            int luaChon = -1;
            do
            {
                Console.WriteLine("Quan Ly Cua Hang Dien Thoai");
                Console.WriteLine("1. Them dien thoai");
                Console.WriteLine("2. Them dien thoai chi tiet");
                Console.WriteLine("3. Tim dien thoai");
                Console.WriteLine("4. Dang/Ngung kinh doanh");
                Console.WriteLine("5. Thoat");

                Console.Write("Nhap lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Vui long chon tu 1-5.");
                        break;
                }

            } while (luaChon != 5);
        }
    }
}
