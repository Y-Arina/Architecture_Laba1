using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Patients
{
    public interface IPatientManager
    {
        public Task<Patient> AddPatient(PatientManagerClass a);
        public Task<IReadOnlyCollection<Patient>> PrintPatient();
        public Task<Patient> EditPatient1(Guid id);
        public Task<Patient> EditPatient2(PatientManagerClass _doc);
        public Task DeletePatient(Guid id);
        public Task<IReadOnlyCollection<Patient>> SearchPatient(string surname, string name);
    }
}
