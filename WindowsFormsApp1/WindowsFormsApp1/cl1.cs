using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class cl1
    {
        public static String Login(String username, String password)
        {
            using (DUAN1lamlaiEntities csharpDB = new DUAN1lamlaiEntities())
            {
                NhanVien found = csharpDB.NhanViens
                    .FirstOrDefault(row => row.TenDN.Equals(username));
                if (found != null && found.Matkhau.Equals(password))
                {
                    return found.Quyen;
                }
                return null;
            }
        }
       

    }
}
