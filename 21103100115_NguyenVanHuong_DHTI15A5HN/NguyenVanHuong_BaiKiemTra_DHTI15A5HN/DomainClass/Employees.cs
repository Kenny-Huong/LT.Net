using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NguyenVanHuong_BaiKiemTra_DHTI15A5HN.DomainClass
{
    public partial class Employees
    {
        [Key]
        [Column("EmployeeID")]
        [StringLength(20)]
        public string EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BirthYear { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        [StringLength(50)]
        public string ContractType { get; set; }
        [StringLength(200)]
        public string Address { get; set; }
        [Column("imgUrl")]
        [StringLength(200)]
        public string ImgUrl { get; set; }
    }
}
