using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{
    public class Workers
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Fathers { get; set; }

        public string ShortName
        {
            get
            {
                return  LastName + " " + FirstName[0] + ". " + Fathers[0]+ ".";
            }
        }

        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Fathers;
            }
        }

        public bool IsActive { get; set; }

        public ICollection<Docs> Docs { get; set; }
        public Workers()
        {
            Docs = new List<Docs>();
        }
    }
}
