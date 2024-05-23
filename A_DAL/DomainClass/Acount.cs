using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

[Keyless]
[Table("Acount")]
public partial class Acount
{
    [StringLength(50)]
    public string Gmail { get; set; } = null!;

    public int Pass { get; set; }

    public int MaNhanVien { get; set; }

    public int Quyen { get; set; }

    [ForeignKey("MaNhanVien")]
    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;
}
