using Laba45.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Managers.Medical_Records
{
    public interface IMedicalRecordManager
    {
        public Task<Medical_Record> AddRecord(MedicalRecordManagerClass a);
        public Task<IReadOnlyCollection<Medical_Record>> PrintRecord();
        public Task<Medical_Record> EditRecord1(Guid id);
        public Task<Medical_Record> EditRecord2(MedicalRecordManagerClass _doc);
        public Task DeleteRecord(Guid id);
        public Task<IReadOnlyCollection<Medical_Record>> SearchRecord(string Insurance_policy);
    }
}
