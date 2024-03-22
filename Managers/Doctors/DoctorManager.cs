using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Doctors
{
    public class DoctorManager:IDoctorManager
    {
        readonly DataContext dataconetxt;
        public DoctorManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Doctor> AddDoctor(DoctorManagerClass a)
        {
            var doctor = new Doctor
            {
                Id = Guid.NewGuid(),
                Surname = a.Surname,
                Name = a.Name,
                Patronymic = a.Patronymic,
                CabinetNumber = a.CabinetNumber,
                Profession = a.Profession,
                StartHour = a.StartHour,
                FinishHour = a.FinishHour,
                IdHospital = a.Id
            };
            dataconetxt.Doctors.Add(doctor);
            await dataconetxt.SaveChangesAsync();
            return doctor;
        }
        public async Task<IReadOnlyCollection<Doctor>> PrintDoctor()
        {
            var doctors = dataconetxt.Doctors
                .AsNoTracking()
                .Include(d => d.Hospital);
            var entity = await doctors.ToListAsync();
            return entity;
        }
        public async Task<Doctor> EditDoctor1(Guid id)
        {
            var entity = await dataconetxt.Doctors.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Doctor> EditDoctor2(DoctorManagerClass _doc)
        {
            var entity = await dataconetxt.Doctors.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.Surname = _doc.Surname;
            entity.Name = _doc.Name;
            entity.Patronymic = _doc.Patronymic;
            entity.CabinetNumber = _doc.CabinetNumber;
            entity.Profession = _doc.Profession;
            entity.StartHour = _doc.StartHour;
            entity.FinishHour = _doc.FinishHour;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteDoctor(Guid id)
        {
            var entity = await dataconetxt.Doctors.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.Doctors.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Doctor>> SearchDoctor(string surname,string name)
        {
            var doctors = dataconetxt.Doctors
                .AsNoTracking()
                .Where(q => q.Surname == surname && q.Name == name)
                .Include(q => q.Hospital);
            var entity = await doctors.ToListAsync();
            return entity;
        }
    }
}
