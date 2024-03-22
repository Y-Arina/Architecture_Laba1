using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Doctors
{
    public class DoctorManagerClass
    {
        public Guid Id;
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Profession;
        public int CabinetNumber;
        public string StartHour;
        public string FinishHour;
        public DoctorManagerClass(Guid id,string surname, string name,string pat,string prof,int cab,string sh,string fh)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = pat;
            Profession = prof;
            CabinetNumber = cab;
            StartHour = sh;
            FinishHour = fh;
        }
    }
}
