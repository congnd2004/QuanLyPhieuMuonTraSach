using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("PhieuBanGiaoSach")]
public partial class PhieuBanGiaoSach
{
    [Key]
    public int MaPhieuBanGiao { get; set; }

    public int MaNhanVien { get; set; }

    public int MaTheDocGia { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayMuon { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayDuKienTra { get; set; }

    [StringLength(50)]
    public string TinhTrangKhiTrao { get; set; } = null!;

    [InverseProperty("MaPhieuBanGiaoNavigation")]
    public virtual ICollection<CtPbg> CtPbgs { get; set; } = new List<CtPbg>();

    [ForeignKey("MaNhanVien")]
    [InverseProperty("PhieuBanGiaoSaches")]
    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;

    [ForeignKey("MaTheDocGia")]
    [InverseProperty("PhieuBanGiaoSaches")]
    public virtual DocGium MaTheDocGiaNavigation { get; set; } = null!;
}
