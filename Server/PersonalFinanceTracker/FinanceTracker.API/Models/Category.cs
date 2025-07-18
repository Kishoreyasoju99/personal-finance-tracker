﻿namespace FinanceTracker.API.Models
{
    public class Category
    {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
