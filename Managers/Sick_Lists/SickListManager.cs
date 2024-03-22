using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Sick_Lists
{
    public class SickListManager:ISickListManager
    {
        readonly DataContext dataconetxt;
        public SickListManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Sick_List> AddSickList(SickListManagerClass a)
        {
            var Lists = new Sick_List
            {
                Id = Guid.NewGuid(),
                PlaceWork = a.PlaceWork,
                StartDate = a.StartDate,
                FinishDate = a.FinishDate,
                IdPatient = a.Id
            };
            dataconetxt.SickLists.Add(Lists);
            await dataconetxt.SaveChangesAsync();
            return Lists;
        }
        public async Task<IReadOnlyCollection<Sick_List>> PrintSickList()
        {
            var lists = dataconetxt.SickLists
                .AsNoTracking()
                .Include(d => d.Patient);
            var entity = await lists.ToListAsync();
            return entity;
        }
        public async Task<Sick_List> EditSickList1(Guid id)
        {
            var entity = await dataconetxt.SickLists.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Sick_List> EditSickList2(SickListManagerClass _doc)
        {
            var entity = await dataconetxt.SickLists.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.PlaceWork = _doc.PlaceWork;
            entity.StartDate = _doc.StartDate;
            entity.FinishDate = _doc.FinishDate;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteStickList(Guid id)
        {
            var entity = await dataconetxt.SickLists.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.SickLists.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Sick_List>> SearchSickList(DateTime sdate, DateTime fdate)
        {
            var lists = dataconetxt.SickLists
                .AsNoTracking()
                .Where(q => q.StartDate==sdate && q.FinishDate==fdate)
                .Include(q => q.Patient);
            var entity = await lists.ToListAsync();
            return entity;
        }
    }
}
