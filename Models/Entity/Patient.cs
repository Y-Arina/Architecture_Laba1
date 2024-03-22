using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("Patient")]
    public class Patient
    {
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Guid IdDoctor { get; set; }
        [ForeignKey(nameof(IdDoctor))]
        public Doctor Doctor { get; set; }
    }
}
