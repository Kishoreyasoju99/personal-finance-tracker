﻿namespace FinanceTracker.API.Models
{
    public class User
    {

            public int Id { get; set; }
            public string Username { get; set; } = null!;
            public string Email { get; set; } = null!;
            public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        
    }
}

