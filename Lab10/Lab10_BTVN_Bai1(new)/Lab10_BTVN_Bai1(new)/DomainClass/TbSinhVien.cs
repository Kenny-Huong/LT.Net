using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_BTVN_Bai1_new_.DomainClass
{
    [Table("tbSinhVien")]
    public partial class TbSinhVien
    {
        public TbSinhVien()
        {
            TbDiem = new HashSet<TbDiem>();
        }

        [Key]
        [Column("MaSV")]
        public int MaSv { get; set; }
        [StringLength(100)]
        public string Ten { get; set; }
        [StringLength(10)]
        public string GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }
        [Column("SDT")]
        [StringLength(15)]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Số điện thoại phải là dãy số từ 10 đến 15 ký tự.")]
        public string Sdt { get; set; }
        [StringLength(200)]
        public string DiaChi { get; set; }
        [Column("MaCS")]
        public int? MaCs { get; set; }
        public int? MaLop { get; set; }

        [ForeignKey(nameof(MaCs))]
        [InverseProperty(nameof(TbChinhSach.TbSinhVien))]
        public virtual TbChinhSach MaCsNavigation { get; set; }
        [ForeignKey(nameof(MaLop))]
        [InverseProperty(nameof(TbLop.TbSinhVien))]
        public virtual TbLop MaLopNavigation { get; set; }
        [InverseProperty("MaSvNavigation")]
        public virtual ICollection<TbDiem> TbDiem { get; set; }
    }
}
