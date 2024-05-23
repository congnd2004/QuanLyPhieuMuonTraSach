using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("PhieuPhat")]
public partial class PhieuPhat
{
    [Key]
    public int MaPhieuPhat { get; set; }

    [Column("MaBBNhanLai")]
    public int MaBbnhanLai { get; set; }

    [Column(TypeName = "money")]
    public decimal? TongTien { get; set; }

    [InverseProperty("MaPhieuPhatNavigation")]
    public virtual ICollection<CtPhieuPhat> CtPhieuPhats { get; set; } = new List<CtPhieuPhat>();

    [ForeignKey("MaBbnhanLai")]
    [InverseProperty("PhieuPhats")]
    public virtual BbNhanLai MaBbnhanLaiNavigation { get; set; } = null!;
}
