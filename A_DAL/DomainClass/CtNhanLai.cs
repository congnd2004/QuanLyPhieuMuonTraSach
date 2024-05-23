using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[PrimaryKey("MaBbnhanLai", "MaSach")]
[Table("CT_NhanLai")]
public partial class CtNhanLai
{
    [Key]
    [Column("MaBBNhanLai")]
    public int MaBbnhanLai { get; set; }

    [Key]
    public int MaSach { get; set; }

    [StringLength(50)]
    public string TinhTrangNhanLai { get; set; } = null!;

    [ForeignKey("MaBbnhanLai")]
    [InverseProperty("CtNhanLais")]
    public virtual BbNhanLai MaBbnhanLaiNavigation { get; set; } = null!;

    [ForeignKey("MaSach")]
    [InverseProperty("CtNhanLais")]
    public virtual Sach MaSachNavigation { get; set; } = null!;
}
