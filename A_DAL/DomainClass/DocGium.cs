using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

public partial class DocGium
{
    [Key]
    public int MaTheDocGia { get; set; }

    [Column("SDT")]
    [StringLength(10)]
    public string Sdt { get; set; } = null!;

    [StringLength(50)]
    public string HoTen { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayLamThe { get; set; }

    [StringLength(100)]
    public string DiaChi { get; set; } = null!;

    [StringLength(50)]
    public string DoiTuongDocGia { get; set; } = null!;

    [InverseProperty("MaTheDocGiaNavigation")]
    public virtual ICollection<BbNhanLai> BbNhanLais { get; set; } = new List<BbNhanLai>();

    [InverseProperty("MaTheDocGiaNavigation")]
    public virtual ICollection<PhieuBanGiaoSach> PhieuBanGiaoSaches { get; set; } = new List<PhieuBanGiaoSach>();
}
