using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mystays.TripAdvisor.Business.Database.Models
{
    [Table("Location")]
    public class Location
    {
        [Key]
        public int ID { get; set; }
        public int Location_ID { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public List<Activity> Activities { get; set; }
        [ForeignKey("Language_ID")]
        public Language Language { get; set; }
    }
}
