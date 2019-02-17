using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ReqTest
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"\d")]
        public string Name { get; set; }
        [Required]
        [Range(1,2,ErrorMessage ="Must be 1 or 2")]
        public int Category { get; set; }
    }
}