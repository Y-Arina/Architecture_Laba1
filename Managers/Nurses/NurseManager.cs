using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Nurses
{
    public class NurseManager: INurseManager
    {
        readonly DataContext dataconetxt;
        public NurseManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Nurse> AddPNurse(NurseManagerClass a)
        {
            var n = new Nurse
            {
                Id = Guid.NewGuid(),
                Surname = a.Surname,
                Name = a.Name,
                Patronymic = a.Patronymic,
                Profession=a.Profession,
                IdDoctor = a.Id
            };
            dataconetxt.Nurses.Add(n);
            await dataconetxt.SaveChangesAsync();
            return n;
        }
        public async Task<IReadOnlyCollection<Nurse>> PrintNurse()
        {
            var n = dataconetxt.Nurses
                .AsNoTracking()
                .Include(d => d.Doctor);
            var entity = await n.ToListAsync();
            return entity;
        }
        public async Task<Nurse> EditNurse1(Guid id)
        {
            var entity = await dataconetxt.Nurses.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Nurse> EditNurse2(NurseManagerClass _doc)
        {
            var entity = await dataconetxt.Nurses.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.Surname = _doc.Surname;
            entity.Name = _doc.Name;
            entity.Patronymic = _doc.Patronymic;
            entity.Profession = _doc.Profession;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteNurse(Guid id)
        {
            var entity = await dataconetxt.Nurses.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.Nurses.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Nurse>> SearchNurse(string surname,string name)
        {
            var nurses = dataconetxt.Nurses
                .AsNoTracking()
                .Where(q => q.Surname == surname && q.Name == name)
                .Include(q => q.Doctor);
            var entity = await nurses.ToListAsync();
            return entity;
        }
    }
}
