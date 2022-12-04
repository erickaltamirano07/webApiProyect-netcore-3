﻿using System.ComponentModel.DataAnnotations;

namespace webApiProyect
{
    public class ProductService
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
