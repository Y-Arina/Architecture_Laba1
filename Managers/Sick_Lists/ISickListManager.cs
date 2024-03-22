using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Sick_Lists
{
    public interface ISickListManager
    {
        public Task<Sick_List> AddSickList(SickListManagerClass a);
        public Task<IReadOnlyCollection<Sick_List>> PrintSickList();
        public Task<Sick_List> EditSickList1(Guid id);
        public Task<Sick_List> EditSickList2(SickListManagerClass _doc);
        public Task DeleteStickList(Guid id);
        public Task<IReadOnlyCollection<Sick_List>> SearchSickList(DateTime sdate, DateTime fdate);
    }
}
