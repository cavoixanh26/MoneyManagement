using System;
using System.Collections.Generic;

namespace MoneyManagementLibrary.DataAccess;

public partial class CateIncome
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Income> Incomes { get; } = new List<Income>();

    public override string ToString()
    {
        return Name;
    }
}
