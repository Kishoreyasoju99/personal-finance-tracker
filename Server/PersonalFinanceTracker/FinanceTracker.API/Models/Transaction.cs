﻿namespace FinanceTracker.API.Models
{
    public class Transaction
    {
        
            public int Id { get; set; }
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; } = null!;

            // Foreign keys
            public int UserId { get; set; }
            public User User { get; set; } = null!;

            public int CategoryId { get; set; }
            public Category Category { get; set; } = null!;

    }
}
