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
    
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        public int MaDonHang { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DiaChiNhanHang { get; set; }
        public string EmailKH { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public string DienThoaiKH { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<bool> TinhTrangThanhToan { get; set; }
        public Nullable<bool> TinhTrangGiaoHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
