using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models.Entity
{
    [Table("Reception")]
    public class Reception
    {
        public Guid Id { get; set; }
        public DateTime Date { get;set; }
        public string Time { get; set; }
        public Guid IdPatient { get; set; }
        [ForeignKey(nameof(IdPatient))]
        public Patient Patient { get; set; }

    }
}
