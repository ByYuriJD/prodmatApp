using System;
using System.Collections.Generic;

namespace prodmatApp;

public partial class Material
{
    public int Id { get; set; }

    public string NameOfMaterial { get; set; } = null!;

    public int AutoAmount { get; set; }

    public short Hue { get; set; }

    public virtual ICollection<WarehouseMaterial> WarehouseMaterials { get; set; } = new List<WarehouseMaterial>();
}
