using System;
using System.Collections.Generic;

namespace prodmatApp.Models;

public partial class Material
{
    public int Id { get; set; }

    public string NameOfMaterial { get; set; } = null!;

    public int AutoAmount { get; set; }

    public string Colour { get; set; } = null!;

    public virtual ICollection<WarehouseMaterial> WarehouseMaterials { get; set; } = new List<WarehouseMaterial>();
}
