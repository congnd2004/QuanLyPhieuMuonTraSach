using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[PrimaryKey("MaSach", "MaPhieuBanGiao")]
[Table("CT_PBG")]
public partial class CtPbg
{
    [Key]
    public int MaSach { get; set; }

    [Key]
    public int MaPhieuBanGiao { get; set; }

    [StringLength(50)]
    public string ThongTin { get; set; } = null!;

    [ForeignKey("MaPhieuBanGiao")]
    [InverseProperty("CtPbgs")]
    public virtual PhieuBanGiaoSach MaPhieuBanGiaoNavigation { get; set; } = null!;

    [ForeignKey("MaSach")]
    [InverseProperty("CtPbgs")]
    public virtual Sach MaSachNavigation { get; set; } = null!;
}
