using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("Doctor")]
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Profession { get; set; }
        public int CabinetNumber { get; set; }
        public string StartHour { get; set; }
        public string FinishHour { get; set; }
        public Guid IdHospital { get; set; }
        [ForeignKey(nameof(IdHospital))]
        public Hospital Hospital { get; set; }
    }
}
