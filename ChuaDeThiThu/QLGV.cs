using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class QLGV
    {
        List<GiaoVien> lst;

        public QLGV()
        {
            lst = new List<GiaoVien>();
        }

        public void ThemGV()
        {
            string choice;
            do
            {
                //qtrong
                GiaoVien giaoVien = new GiaoVien();
                //
                Console.WriteLine("Xin mời nhập id");
                giaoVien.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Xin mời nhập tên");
                giaoVien.Ten = Console.ReadLine();
                Console.WriteLine("Mời nhập số giờ dạy");
                giaoVien.SoGioDay = double.Parse(Console.ReadLine());
                //
                lst.Add(giaoVien);
                Console.WriteLine("thêm thành công");
                Console.WriteLine("Có nhập tiếp hay ko");
                Console.WriteLine("Ko thì ấn N");
                choice = Console.ReadLine();
            } while (!choice.Equals("N"));
        }

        public void XuatDS()
        {
            foreach (var gv in lst)
            {
                gv.InThongTin();
            }
        }

        public void DSachTheoGioDay()
        {
            double min, max;
            bool isExist = false;
            Console.WriteLine("Xin mời nhập giờ tối thiểu");
            min = double.Parse(Console.ReadLine());
            Console.WriteLine("Xin mời nhập giờ tối đa");
            max = double.Parse(Console.ReadLine());
            foreach (var gv in lst)
            {
                if(gv.SoGioDay >= min && gv.SoGioDay <= max)
                {
                    gv.InThongTin();
                    isExist = true;
                }
            }
            if (!isExist) // isExxist == false
            {
                Console.WriteLine("Không tìm thấy");
            }
        }

        public void TimTheoMa()
        {
            int ma;
            Console.WriteLine("Xin mời nhập ID");
            ma = int.Parse(Console.ReadLine());
            //GiaoVien gv = lst.Find(x => x.ID == ma);
            //GiaoVien gv = lst.Where(x => x.ID == ma).FirstOrDefault();
            foreach (var gv in lst)
            {
                if (gv.ID == ma)
                {
                    gv.InThongTin();
                }
            }
        }

        public void KeThua()
        {
            GiaoVienPoly gvFPL = new GiaoVienPoly(1, "Van A", 50.5, "Đồ họa");
            gvFPL.InThongTin();
        }
    }
}
