using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Patients
{
    public class PatientManager: IPatientManager
    {
        readonly DataContext dataconetxt;
        public PatientManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Patient> AddPatient(PatientManagerClass a)
        {
            var patient = new Patient
            {
                Id = Guid.NewGuid(),
                Surname = a.Surname,
                Name = a.Name,
                Patronymic = a.Patronymic,
                IdDoctor = a.Id
            };
            dataconetxt.Patients.Add(patient);
            await dataconetxt.SaveChangesAsync();
            return patient;
        }
        public async Task<IReadOnlyCollection<Patient>> PrintPatient()
        {
            var patients = dataconetxt.Patients
                .AsNoTracking()
                .Include(d => d.Doctor);
            var entity = await patients.ToListAsync();
            return entity;
        }
        public async Task<Patient> EditPatient1(Guid id)
        {
            var entity = await dataconetxt.Patients.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Patient> EditPatient2(PatientManagerClass _doc)
        {
            var entity = await dataconetxt.Patients.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.Surname = _doc.Surname;
            entity.Name = _doc.Name;
            entity.Patronymic = _doc.Patronymic;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeletePatient(Guid id)
        {
            var entity = await dataconetxt.Patients.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.Patients.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Patient>> SearchPatient(string surname, string name)
        {
            var patients = dataconetxt.Patients
                .AsNoTracking()
                .Where(q => q.Surname == surname && q.Name == name)
                .Include(q => q.Doctor);
            var entity = await patients.ToListAsync();
            return entity;
        }
    }
}
