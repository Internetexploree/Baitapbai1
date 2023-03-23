using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Moi nhap ho va ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Moi nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Moi nhap so tuoi: ");
            int soTuoi = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Cac thong tin ma ban vua nhap nhu sau:");
            Console.WriteLine("Ho ten cua ban la:\t {0}", hoTen);
            Console.WriteLine("Gioi tinh cua ban la:\t {0}", gioiTinh);
            Console.WriteLine("So tuoi cua ban la:\t {0}", soTuoi);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Bam phim bat ky de ket thuc!");
            Console.ReadKey();
        }
    }
}
