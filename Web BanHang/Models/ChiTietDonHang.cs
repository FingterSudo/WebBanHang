//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_BanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int MaDonHang { get; set; }
        public int MaSach { get; set; }
        public Nullable<int> MaNXB { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
