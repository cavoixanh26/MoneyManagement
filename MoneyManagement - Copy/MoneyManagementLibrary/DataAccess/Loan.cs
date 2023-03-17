using System;
using System.Collections.Generic;

namespace MoneyManagementLibrary.DataAccess;

public partial class Loan
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Describe { get; set; }

    public DateTime Time { get; set; }

    public decimal Money { get; set; }

    public int Rate { get; set; }

    public bool Status { get; set; } = false;

    public int UserId { get; set; }

    public DateTime Deadline { get; set; }

    public virtual User User { get; set; } = null!;
}
