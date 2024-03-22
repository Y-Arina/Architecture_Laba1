using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Nurses
{
    public class NurseManagerClass
    {
        public Guid Id;
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Profession;
        public NurseManagerClass(Guid id,string s,string n,string p,string prof)
        {
            Id = id;
            Surname = s;
            Name = n;
            Patronymic = p;
            Profession = prof;
        }
    }
}
