using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45.Models.Entity;

namespace Laba45.Managers.Hospitals
{
    public interface IHospitalManager
    {
        public Task<Hospital> AddHospital(HospitalManagerClass a);
        public Task<IReadOnlyCollection<Hospital>> PrintHospital();
        public Task<Hospital> EditHospital1(Guid id);
        Task<Hospital> EditHospital2(Guid id, HospitalManagerClass _hospital);
        public Task DeleteHospital(Guid id);
        public Task<IReadOnlyCollection<Hospital>> SearchHospital(int number, string adress);
    }
}
