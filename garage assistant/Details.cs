using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{
    public class Details
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NumType { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double Summ { get; set; }

        public int? DocId { get; set; }
        public Docs Doc { get; set; }
    }
}