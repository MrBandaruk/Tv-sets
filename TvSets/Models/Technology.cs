using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TvSets.Models
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Technology")]
        public string Name { get; set; }

        public virtual ICollection<Tvset> Tvsets { get; set; }

        public Technology()
        {
            Tvsets = new List<Tvset>();
        }
    }
}