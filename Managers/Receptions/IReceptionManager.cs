using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Receptions
{
    public interface IReceptionManager
    {
        public Task<Reception> AddReceptin(ReceptionManagerClass a);
        public Task<IReadOnlyCollection<Reception>> PrintReception();
        public Task<Reception> EditReception1(Guid id);
        public Task<Reception> EditReception2(ReceptionManagerClass _doc);
        public Task DeleteReception(Guid id);
        public Task<IReadOnlyCollection<Reception>> SearchReception(DateTime date, string time);
    }
}
