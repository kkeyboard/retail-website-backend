using System;
using System.Collections.Generic;

namespace web_app_1.Models;

public partial class Customer2
{
    public int Customerid { get; set; }

    public string Customername { get; set; } = null!;

    public double? Customeramount { get; set; }

    public string? City { get; set; }
}
