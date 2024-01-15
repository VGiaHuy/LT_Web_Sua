﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnTapDe2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq; 

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.SPtheoMaus = new HashSet<SPtheoMau>();
        }

        [Display(Name = "Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [Display(Name = "Tên sản phẩm")] 
        public string TenSanPham { get; set; }

        [Display(Name = "Mã phân loại")]
        public string MaPhanLoai { get; set; }

        [Display(Name = "Giá nhập")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Đơn giá chỉ được nhập số.")]
        public Nullable<long> GiaNhap { get; set; }

        [Display(Name = "Đơn giá bán nhỏ nhất")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Đơn giá chỉ được nhập số.")]
        public Nullable<long> DonGiaBanNhoNhat { get; set; }

        [Display(Name = "Đơn giá bán lớn nhất")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Đơn giá chỉ được nhập số.")]
        public Nullable<long> DonGiaBanLonNhat { get; set; }

        [Display(Name = "Trạng thái")]
        public Nullable<bool> TrangThai { get; set; }

        [Display(Name = "Mô tả ngắn")]
        public string MoTaNgan { get; set; }

        [FileExtensions(Extensions = "jpg", ErrorMessage = "File ảnh phải có phần mở rộng .jpg.")]
        [Display(Name = "Ảnh đại diện")]
        public string AnhDaiDien { get; set; }

        [Display(Name = "Nổi bật")]
        public Nullable<bool> NoiBat { get; set; }

        [Display(Name = "Mã phân loại phụ")]
        public string MaPhanLoaiPhu { get; set; }
    
        public virtual PhanLoai PhanLoai { get; set; }
        public virtual PhanLoaiPhu PhanLoaiPhu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPtheoMau> SPtheoMaus { get; set; }
    }
}
