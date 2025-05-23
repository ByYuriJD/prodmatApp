using System;
using System.Collections.Generic;

namespace prodmatApp.Models;

public partial class WarehouseProduct
{
    public int Id { get; set; }

    public int IdProduct { get; set; }

    public bool IsAdded { get; set; }

    public float Amount { get; set; }

    public bool IsCanceled { get; set; }

    public bool IsTemplateOnly { get; set; }

    public DateOnly? DateOfAddition { get; set; }

    public virtual Product IdProductNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<WarehouseMaterial> WarehouseMaterials { get; set; } = new List<WarehouseMaterial>();
}
