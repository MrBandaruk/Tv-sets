using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TvSets.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string Name { get; set; }

        public virtual ICollection<Tvset> Tvsets { get; set; }
    }
}