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
    
    public partial class PhanQuyen
    {
        public int PhanQuyenID { get; set; }
        public int TaiKhoanID { get; set; }
        public int NhomID { get; set; }
        public string ChucNang { get; set; }
    
        public virtual NhomNguoiDung NhomNguoiDung { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
