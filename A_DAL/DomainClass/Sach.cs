using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("Sach")]
public partial class Sach
{
    [Key]
    public int MaSach { get; set; }

    [Column("MaSachCT")]
    public int MaSachCt { get; set; }

    [StringLength(50)]
    public string TinhTrangSach { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal GiaSach { get; set; }

    [InverseProperty("MaSachNavigation")]
    public virtual ICollection<CtNhanLai> CtNhanLais { get; set; } = new List<CtNhanLai>();

    [InverseProperty("MaSachNavigation")]
    public virtual ICollection<CtPbg> CtPbgs { get; set; } = new List<CtPbg>();

    [InverseProperty("MaSachNavigation")]
    public virtual ICollection<CtPhieuPhat> CtPhieuPhats { get; set; } = new List<CtPhieuPhat>();

    [ForeignKey("MaSachCt")]
    [InverseProperty("Saches")]
    public virtual CtSach MaSachCtNavigation { get; set; } = null!;
}
