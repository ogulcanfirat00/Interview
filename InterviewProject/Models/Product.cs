using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Product Start Date")]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Quantity should be greater than 0")]
        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Product Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [Display(Name = "Product Content")]
        public string Content { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Display(Name = "Product City")]
        public int City_Id { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Display(Name = "Product Country")]
        public int Country_Id { get; set; }

        [Required(ErrorMessage = "Media is required")]
        [Display(Name = "Product Media")]
        public int Media_Id { get; set; }
    }
}
