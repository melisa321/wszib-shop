using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shop.Web1.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name was not provided.")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [Range(1,100000)]
        public decimal Price { get; set; }

        
    }
}
