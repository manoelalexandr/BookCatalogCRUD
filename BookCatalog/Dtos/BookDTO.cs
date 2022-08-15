﻿using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dtos
{
    public record BookDTO
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Price { get; set; }
    }
}
