using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Sick_Lists
{
    public class SickListManagerClass
    {
        public Guid Id;
        public string PlaceWork;
        public DateTime StartDate;
        public DateTime FinishDate;
        public SickListManagerClass(Guid id,string p,DateTime s,DateTime f)
        {
            Id = id;
            PlaceWork = p;
            StartDate = s;
            FinishDate = f;
        }
    }
}
