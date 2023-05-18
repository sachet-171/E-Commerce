﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(0,10000)]
        public double ListPrice { get; set; }
        [Required]
        [Range(0,10000)]
        [Display(Name = "Price for 1-50")]

        public double Price { get; set; }  //price for one book
        [Required]
        [Range(0, 10000)]
        [Display(Name = "Price for 50-100")]

        public double Price50 { get; set; } //price for more than 50 books(buying more than 50 books)

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Price for 100+")]

        public double Price100 { get; set; } //price for more than 100 books
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; } // create a foreign key property
        [Required]
        [Display(Name = "Cover Type" )]
        public int CoverTypeId { get; set; }
        [ValidateNever]

        public CoverType CoverType { get; set; }
    }
}
