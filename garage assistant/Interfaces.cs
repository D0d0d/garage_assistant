using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{
    internal interface IDbSet
    {
        string Name { get; }
        string NumType { get; }
        double Price { get; }
    }

}
