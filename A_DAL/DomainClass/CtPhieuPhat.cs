using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[PrimaryKey("MaPhieuPhat", "MaSach")]
[Table("CT_PhieuPhat")]
public partial class CtPhieuPhat
{
    [Key]
    public int MaPhieuPhat { get; set; }

    [Key]
    public int MaSach { get; set; }

    public int SoNgayQuaHan { get; set; }

    [StringLength(50)]
    public string TinhTrangHong { get; set; } = null!;

    [ForeignKey("MaPhieuPhat")]
    [InverseProperty("CtPhieuPhats")]
    public virtual PhieuPhat MaPhieuPhatNavigation { get; set; } = null!;

    [ForeignKey("MaSach")]
    [InverseProperty("CtPhieuPhats")]
    public virtual Sach MaSachNavigation { get; set; } = null!;
}
