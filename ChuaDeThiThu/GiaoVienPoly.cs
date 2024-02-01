using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class GiaoVienPoly : GiaoVien
    {
        private string nganhDay;

        public GiaoVienPoly()
        {
            
        }

        public GiaoVienPoly(int iD, string ten, double soGioDay, 
                            string nganhDay) : base (iD, ten, soGioDay)
        {
            this.nganhDay = nganhDay;
        }

        public string NganhDay { get => nganhDay; set => nganhDay = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"{nganhDay}");
        }
    }
}
