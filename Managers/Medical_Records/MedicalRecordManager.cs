using Laba45.Models;
using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Medical_Records
{
    public class MedicalRecordManager: IMedicalRecordManager
    {
        readonly DataContext dataconetxt;
        public MedicalRecordManager(DataContext a)
        {
            dataconetxt = a;
        }
        public async Task<Medical_Record> AddRecord(MedicalRecordManagerClass a)
        {
            var med = new Medical_Record
            {
                Id = Guid.NewGuid(),
                NumberRecord = a.NumberRecord,
                Insurance_policy = a.Insurance_policy,
                BirthDate = a.BirthDate,
                NumberPhone=a.NumberPhone,
                Adress=a.Adress,
                IdPatient = a.Id
            };
            dataconetxt.MedRecords.Add(med);
            await dataconetxt.SaveChangesAsync();
            return med;
        }
        public async Task<IReadOnlyCollection<Medical_Record>> PrintRecord()
        {
            var med = dataconetxt.MedRecords
                .AsNoTracking()
                .Include(d => d.Patient);
            var entity = await med.ToListAsync();
            return entity;
        }
        public async Task<Medical_Record> EditRecord1(Guid id)
        {
            var entity = await dataconetxt.MedRecords.FirstOrDefaultAsync(q => q.Id == id);
            return entity;
        }
        public async Task<Medical_Record> EditRecord2(MedicalRecordManagerClass _doc)
        {
            var entity = await dataconetxt.MedRecords.FirstOrDefaultAsync(q => q.Id == _doc.Id);
            entity.NumberRecord = _doc.NumberRecord;
            entity.Insurance_policy = _doc.Insurance_policy;
            entity.BirthDate = _doc.BirthDate;
            entity.NumberPhone = _doc.NumberPhone;
            entity.Adress = _doc.Adress;
            await dataconetxt.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteRecord(Guid id)
        {
            var entity = await dataconetxt.MedRecords.FirstOrDefaultAsync(q => q.Id == id);
            dataconetxt.MedRecords.Remove(entity);
            await dataconetxt.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Medical_Record>> SearchRecord(string Insurance_policy)
        {
            var records = dataconetxt.MedRecords
                .AsNoTracking()
                .Where(q => q.Insurance_policy == Insurance_policy)
                .Include(q => q.Patient);
            var entity = await records.ToListAsync();
            return entity;
        }
    }
}
