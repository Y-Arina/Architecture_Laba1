using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("MedicalRecord")]
    public class Medical_Record
    {
        public Guid Id { get; set; }
        public string NumberRecord { get; set; }
        public string Insurance_policy { get; set; }
        public DateTime BirthDate { get; set; }
        public string NumberPhone { get; set; }
        public string Adress { get; set; }
        public Guid IdPatient { get; set; }
        [ForeignKey(nameof(IdPatient))]
        public Patient Patient { get; set; }
    }
}
