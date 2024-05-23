using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Table("CT_Sach")]
public partial class CtSach
{
    [Key]
    [Column("MaSachCT")]
    public int MaSachCt { get; set; }

    [StringLength(50)]
    public string TenDauSach { get; set; } = null!;

    public int SoLuong { get; set; }

    public int SoTrang { get; set; }

    [StringLength(50)]
    public string TenTacGia { get; set; } = null!;

    [InverseProperty("MaSachCtNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();

    [ForeignKey("TenTacGia")]
    [InverseProperty("CtSaches")]
    public virtual TacGium TenTacGiaNavigation { get; set; } = null!;
}
