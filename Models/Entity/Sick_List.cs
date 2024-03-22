using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("SickList")]
    public class Sick_List
    {
        public Guid Id { get; set; }
        public string PlaceWork { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Guid IdPatient { get; set; }
        [ForeignKey(nameof(IdPatient))]
        public Patient Patient { get; set; }
    }
}
