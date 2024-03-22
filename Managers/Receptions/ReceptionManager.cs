using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Receptions
{
    public class ReceptionManager: IReceptionManager
    {
        readonly DataContext dataconetxt;
        public ReceptionManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Reception> AddReceptin(ReceptionManagerClass a)
        {
            var recep = new Reception
            {
                Id = Guid.NewGuid(),
                Date = a.Date,
                Time = a.Time,
                IdPatient = a.Id
            };
            dataconetxt.Receptions.Add(recep);
            await dataconetxt.SaveChangesAsync();
            return recep;
        }
        public async Task<IReadOnlyCollection<Reception>> PrintReception()
        {
            var recept = dataconetxt.Receptions
                .AsNoTracking()
                .Include(d => d.Patient)
                .Include(d => d.Patient.Doctor);
            var entity = await recept.ToListAsync();
            return entity;
        }
        public async Task<Reception> EditReception1(Guid id)
        {
            var entity = await dataconetxt.Receptions.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Reception> EditReception2(ReceptionManagerClass _doc)
        {
            var entity = await dataconetxt.Receptions.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.Date = _doc.Date;
            entity.Time = _doc.Time;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteReception(Guid id)
        {
            var entity = await dataconetxt.Receptions.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.Receptions.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Reception>> SearchReception(DateTime date, string time)
        {
            var receptions = dataconetxt.Receptions
                .AsNoTracking()
                .Where(q => q.Date == date && q.Time == time)
                .Include(q => q.Patient)
                .Include(q => q.Patient.Doctor);
            var entity = await receptions.ToListAsync();
            return entity;
        }
    }
}
