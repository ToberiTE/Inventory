using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9]{1,40}$", ErrorMessage = "* Field must contain alphanumeric characters.")]
        public string ReferenceNumber { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "* Field must contain letters.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "* Field must contain letters.")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "* Field must contain letters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[0-9]\d{0,9}(\.\d{1,3})?%?$", ErrorMessage = "* Invalid number format.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "* This field is required.")]
        [RegularExpression(@"^[0-9]{1,10}$", ErrorMessage = "* Field must contain whole numbers.")]
        public int Quantity { get; set; }
    }
}