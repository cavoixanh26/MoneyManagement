using System;
using System.Collections.Generic;

namespace MoneyManagementLibrary.DataAccess;

public partial class CateSpend
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Spend> Spends { get; } = new List<Spend>();

    public override string ToString()
    {
        return Name;
    }
}
