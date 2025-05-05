using System;
using System.Collections.Generic;

namespace prodmatApp;

public partial class Product
{
    public int Id { get; set; }

    public int? IdTemplate { get; set; }

    public string NameOfProduct { get; set; } = null!;

    public short Hue { get; set; }

    public virtual WarehouseProduct? IdTemplateNavigation { get; set; }

    public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new List<WarehouseProduct>();
}
