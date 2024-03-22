using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Nurses
{
    public interface INurseManager
    {
        public Task<Nurse> AddPNurse(NurseManagerClass a);
        public Task<IReadOnlyCollection<Nurse>> PrintNurse();
        public Task<Nurse> EditNurse1(Guid id);
        public Task<Nurse> EditNurse2(NurseManagerClass _doc);
        public Task DeleteNurse(Guid id);
        public Task<IReadOnlyCollection<Nurse>> SearchNurse(string surname, string name);
    }
}
