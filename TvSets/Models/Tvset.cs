using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TvSets.Models
{
    public class Tvset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1990, 2020, ErrorMessage = "Year must be between 1990 and 2020.")]
        public int Year { get; set; }

        [Required]
        [Range(5, 250, ErrorMessage = "Size must be between 5 and 250.")]
        public int Size { get; set; }

        [Required]
        [RegularExpression(@"^\d+[x]\d+$", ErrorMessage = "Example: 1920x1080")]
        public string Resolution { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Add additional information about TV-set")]
        public string Details { get; set; }

        public int? TechnologyId { get; set; }
        public Technology Technology { get; set; }

        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        public virtual ICollection<TvImage> TvImages { get; set; }
    }
}