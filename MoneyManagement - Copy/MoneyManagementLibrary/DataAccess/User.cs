using System;
using System.Collections.Generic;

namespace MoneyManagementLibrary.DataAccess;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Borrow> Borrows { get; } = new List<Borrow>();

    public virtual ICollection<Income> Incomes { get; } = new List<Income>();

    public virtual ICollection<Loan> Loans { get; } = new List<Loan>();

    public virtual ICollection<Spend> Spends { get; } = new List<Spend>();
}
