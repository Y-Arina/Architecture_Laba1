using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Receptions
{
    public class ReceptionManagerClass
    {
        public Guid Id;
        public DateTime Date;
        public string Time;
        public ReceptionManagerClass(Guid id,DateTime d,string t)
        {
            Id = id;
            Date = d;
            Time = t;
        }
    }
}
