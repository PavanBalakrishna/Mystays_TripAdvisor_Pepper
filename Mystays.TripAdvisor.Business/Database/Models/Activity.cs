using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mystays.TripAdvisor.Business.Database.Models
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        public int ID { get; set; }
        public string ActivityName { get; set; }
        public string LocalName { get; set; }
        [ForeignKey("Location_ID")]
        public Location Location { get; set; }
        [ForeignKey("Language_ID")]
        public Language Language { get; set; }
    }
}
