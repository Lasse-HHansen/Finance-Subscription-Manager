using System;

class Expense
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public bool IsMonthly { get; set; }

    public Expense(int id, string name, decimal amount, string category, bool isMonthly)
    {
        Id = id;
        Name = name;
        Amount = amount;
        Category = category;
        IsMonthly = isMonthly;
    }

    public void DisplayExpense()
    {
        Console.WriteLine($"ID: {Id} | Name: {Name} | Amount: {Amount} | Category: {Category} | Monthly: {IsMonthly}");
    }

}