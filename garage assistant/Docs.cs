using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace garage_assistant
{

    public class Docs
    {

        public int Id { get; set; }

        public CarInfo CrInfo;

        public double TotalDetails
        {
            get
            {

                if (this.Details != null)
                {
                    return (double)(this.Details.Select(u => u.Summ).Sum());
                }
                else
                {
                    return 0;
                };

            }
        }
        public double TotalWorks
        {
            get
            {
                if (this.Works != null)
                {
                    return (double)(this.Works.Select(u => u.Summ).Sum());
                }
                else
                {
                    return 0;
                };

            }
        }
        public double Total { get { return this.TotalWorks+this.TotalDetails; } }
        public List<Work> Works { get; set; }
        public List<Details> Details { get; set; }

        public DateTime date { get; set; }
        public int WorkersId { get; set; }
        public Workers Worker { get; set; }
        public Docs()
        {
            Works = new List<Work>();
            Details = new List<Details>();

        }

    }
}
