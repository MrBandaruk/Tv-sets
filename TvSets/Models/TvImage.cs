using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TvSets.Models
{
    public class TvImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int TvId { get; set; }
        public Tvset Tvset { get; set; }
    }
}