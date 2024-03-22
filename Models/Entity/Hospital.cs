using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("Hospital")]
    public class Hospital
    {
        public Guid Id { get; set; }
        public int NumberHospital { get; set; }
        public string Adress { get; set; }
        public string NumberPhone { get; set; }
        public string StartHours { get; set; }
        public string FinishHours { get; set; }
    }
}
