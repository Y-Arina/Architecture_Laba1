using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Patients
{
    public class PatientManagerClass
    {
        public Guid Id;
        public string Surname;
        public string Name;
        public string Patronymic;
        public PatientManagerClass(Guid id,string s,string n,string p)
        {
            Id = id;
            Surname = s;
            Name = n;
            Patronymic = p;
        }
    }
}
