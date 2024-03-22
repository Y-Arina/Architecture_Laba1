using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Laba45.Managers.Hospitals
{
    public class HospitalManager: IHospitalManager
    {
        readonly DataContext dataconetxt;
        public HospitalManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Hospital> AddHospital(HospitalManagerClass a)
        {
            var hospital = new Hospital
            {
                Id = Guid.NewGuid(),
                NumberHospital = a.NumberHospital,
                Adress = a.Adress,
                NumberPhone = a.NumberPhone,
                StartHours = a.StartHours,
                FinishHours = a.FinishHours
            };
            dataconetxt.Hospitals.Add(hospital);
            await dataconetxt.SaveChangesAsync();
            return hospital;
        }
        public async Task<IReadOnlyCollection<Hospital>> PrintHospital()
        {
            var hotals = dataconetxt.Hospitals.AsNoTracking();
            var entity = await hotals.ToListAsync();
            return entity;
        }
        public async Task<Hospital>  EditHospital1(Guid id)
        {
            var entity = await dataconetxt.Hospitals.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Hospital> EditHospital2(Guid id, HospitalManagerClass _hospital)
        {
            var entity = await dataconetxt.Hospitals.FirstOrDefaultAsync(q => q.Id == id);
            entity.NumberHospital = _hospital.NumberHospital;
            entity.Adress = _hospital.Adress;
            entity.NumberPhone = _hospital.NumberPhone;
            entity.StartHours = _hospital.StartHours;
            entity.FinishHours = _hospital.FinishHours;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteHospital(Guid id)
        {
            var entity = await dataconetxt.Hospitals.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.Hospitals.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Hospital>> SearchHospital(int number,string adress)
        {
            var hospitals = dataconetxt.Hospitals
                .AsNoTracking()
                .Where(q => q.NumberHospital == number && q.Adress == adress);
            var entity = await hospitals.ToListAsync();
            return entity;
        }
    }
}
