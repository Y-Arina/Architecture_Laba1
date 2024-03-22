using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Doctors
{
    public interface IDoctorManager
    {
        public Task<Doctor> AddDoctor(DoctorManagerClass a);
        public Task<IReadOnlyCollection<Doctor>> PrintDoctor();
        public Task<Doctor> EditDoctor1(Guid id);
        public Task<Doctor> EditDoctor2(DoctorManagerClass _doc);
        public Task DeleteDoctor(Guid id);
        public Task<IReadOnlyCollection<Doctor>> SearchDoctor(string surname, string name);
    }
}
