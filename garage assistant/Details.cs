using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{
    public class Details : IDbSet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NumType { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double? Summ
        {
            get
            {
                if (Amount != null && Price != null) { return Amount * Price; } else { return 0; };
            }
        }
        public int? DocId { get; set; }
        public Docs Doc { get; set; }
        
        public Details()
        {
            this.Name = "";
            this.NumType = "";
            this.Amount = 0;
            this.Price = 0;
        }
        public Details(string Name, string NumType, int Amount, double Price, double Summ)
        {
            this.Name = Name;
            this.NumType = NumType;
            this.Amount = Amount;
            this.Price = Price;
        }
    }
}