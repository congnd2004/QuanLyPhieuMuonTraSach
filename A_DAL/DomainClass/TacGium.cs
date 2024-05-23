using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass;

public partial class TacGium
{
    [Key]
    [StringLength(50)]
    public string TenTacGia { get; set; } = null!;

    [StringLength(50)]
    public string VaiTroTacGia { get; set; } = null!;

    [InverseProperty("TenTacGiaNavigation")]
    public virtual ICollection<CtSach> CtSaches { get; set; } = new List<CtSach>();
}
