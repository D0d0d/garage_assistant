using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{
    public struct CarInfo
    {
        public string rc, GovNumb, VIN, Mileage;

    }
    public struct OrgInfo
    {
        public string name, adress, phone, numeral;
    }
    public struct Summs
    {
        public double SummD, SummW;
        public double SummT { 
            get {
                return SummD + SummW; 
            }
        }
    }
}
