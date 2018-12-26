using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mystays.TripAdvisor.Business.Database.Models
{
    [Table("Language")]
    public class Language
    {
        [Key]
        public int ID { get; set; }
        public string LanguageCode { get; set; }
    }
}
