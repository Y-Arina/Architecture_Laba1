using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Hospitals
{
    public class HospitalManagerClass
    {
        public int NumberHospital;
        public string Adress;
        public string NumberPhone;
        public string StartHours;
        public string FinishHours;
        public HospitalManagerClass(int number, string adress, string phone, string shours, string fhours)
        {
            NumberHospital = number;
            Adress = adress;
            NumberPhone = phone;
            StartHours = shours;
            FinishHours = fhours;
        }
    }
}
