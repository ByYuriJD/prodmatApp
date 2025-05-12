using System;
using System.Collections.Generic;

namespace prodmatApp.Models;

public partial class WarehouseMaterial
{
    public int Id { get; set; }

    public int IdMaterial { get; set; }

    public int? IdAddedProduct { get; set; }

    public bool IsAdded { get; set; }

    public int Amount { get; set; }

    public bool? IsMultipliedByProduct { get; set; }

    public bool IsCanceled { get; set; }

    public DateOnly? DateOfAddition { get; set; }

    public virtual WarehouseProduct? IdAddedProductNavigation { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;
}
