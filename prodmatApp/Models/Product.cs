using System;
using System.Collections.Generic;

namespace prodmatApp.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? IdTemplate { get; set; }

    public string NameOfProduct { get; set; } = null!;

    public string Colour { get; set; } = null!;

    public virtual WarehouseProduct? IdTemplateNavigation { get; set; }

    public virtual ICollection<WarehouseProduct> WarehouseProducts { get; set; } = new List<WarehouseProduct>();
}
