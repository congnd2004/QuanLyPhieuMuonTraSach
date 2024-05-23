using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("BB_NhanLai")]
public partial class BbNhanLai
{
    [Key]
    [Column("MaBBNhanLai")]
    public int MaBbnhanLai { get; set; }

    public int MaTheDocGia { get; set; }

    public int MaNhanVien { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayTra { get; set; }

    [InverseProperty("MaBbnhanLaiNavigation")]
    public virtual ICollection<CtNhanLai> CtNhanLais { get; set; } = new List<CtNhanLai>();

    [ForeignKey("MaNhanVien")]
    [InverseProperty("BbNhanLais")]
    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;

    [ForeignKey("MaTheDocGia")]
    [InverseProperty("BbNhanLais")]
    public virtual DocGium MaTheDocGiaNavigation { get; set; } = null!;

    [InverseProperty("MaBbnhanLaiNavigation")]
    public virtual ICollection<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();
}
