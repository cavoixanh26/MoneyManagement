using System;
using System.Collections.Generic;

namespace MoneyManagementLibrary.DataAccess;

public partial class Income
{
    public int Id { get; set; }

    public string? Describe { get; set; }

    public DateTime Time { get; set; }

    public decimal Money { get; set; }

    public int UserId { get; set; }

    public int? CateId { get; set; }

    public virtual CateIncome? Cate { get; set; }

    public virtual User User { get; set; } = null!;
}
