using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        [Display(Name = "Scheduled Date")]
        [DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }
        public string Notes { get; set; }
    }
}
