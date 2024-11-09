using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Lab10_QLThuVien_110824.DomainClass
{
    [Table("tbAdmin")]
    public partial class TbAdmin
    {
        [Key]
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string PassWord { get; set; }
    }
}
