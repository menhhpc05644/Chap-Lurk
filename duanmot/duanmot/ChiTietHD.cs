//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace duanmot
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHD
    {
        public int ID { get; set; }
        public int SoHD { get; set; }
        public string MaThucDon { get; set; }
        public int SoLuong { get; set; }
        public double Dongia { get; set; }
    
        public virtual ThucDon ThucDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }
    }
}
