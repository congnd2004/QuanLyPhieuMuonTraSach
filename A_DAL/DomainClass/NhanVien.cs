using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    public int MaNhanVien { get; set; }

    [StringLength(50)]
    public string TenNhanVien { get; set; } = null!;

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<BbNhanLai> BbNhanLais { get; set; } = new List<BbNhanLai>();

    [InverseProperty("MaNhanVienNavigation")]
    public virtual ICollection<PhieuBanGiaoSach> PhieuBanGiaoSaches { get; set; } = new List<PhieuBanGiaoSach>();
}
