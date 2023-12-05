using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ok
    {
        public static bool deletethucdon (string mathucdon)
        {
            using (DUAN1Entities1 thucdon = new DUAN1Entities1())
            {
                try
                {
                    ThucDon found = thucdon.ThucDons
                        .FirstOrDefault(sp => sp.MaThucDon.Equals(mathucdon));
                    thucdon.ThucDons.Remove(found);
                    thucdon.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static bool deleteNV(string manhanvien)
        {
            using (DUAN1Entities1 nv = new DUAN1Entities1())
            {
                try
                {
                    NhanVien found = nv.NhanViens
                        .FirstOrDefault(sp => sp.MaNV.Equals(manhanvien));
                    nv.NhanViens.Remove(found);
                    nv.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
