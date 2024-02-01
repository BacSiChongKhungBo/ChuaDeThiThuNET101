using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeThiThu
{
    internal class GiaoVien
    {
        private int iD;
        private string ten;
        private double soGioDay;

        public GiaoVien()
        {
            
        }
        public GiaoVien(int iD, string ten, double soGioDay)
        {
            this.iD = iD;
            this.ten = ten;
            this.soGioDay = soGioDay;
        }

        public int ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }

        public virtual void InThongTin()
        {
            Console.WriteLine($"{iD} | {ten} | {soGioDay}");
        }
    }
}
