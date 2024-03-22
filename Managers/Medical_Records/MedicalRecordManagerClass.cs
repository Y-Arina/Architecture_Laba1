using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Medical_Records
{
    public class MedicalRecordManagerClass
    {
        public Guid Id;
        public string NumberRecord;
        public string Insurance_policy;
        public DateTime BirthDate;
        public string NumberPhone;
        public string Adress;
        public MedicalRecordManagerClass(Guid id,string n,string i,DateTime b,string number,string a)
        {
            Id = id;
            NumberRecord = n;
            Insurance_policy = i;
            BirthDate = b;
            NumberPhone = number;
            Adress = a;
        }
    }
}
