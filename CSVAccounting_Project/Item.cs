using System;
using System.Collections.Generic;
using System.Text;

namespace CSVAccounting_Project
{
    public class Item
    {
        public DateTime Date { get; set; }
        public string Note { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public Category CategoryType { get; set; }
    }

    public enum Category
    {
        食,
        衣,
        住,
        行,
        育樂,
        其他
    }
}
