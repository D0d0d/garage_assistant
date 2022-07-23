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

        public Summs Summs;

        public OrgInfo OrgInfo;
        public ICollection<Work> Works { get; set; }


        public ICollection<Details> Details { get; set; }



        public DateTime date { get; set; }
        public int? WorkersId { get; set; }
        public Workers Worker { get; set; }
        public Docs()
        {
            Works = new List<Work>();
            Details = new List<Details>();
        }

    }
}
