using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FarjamRayan.Models.ViewModel
{
    public class BlogViewModel
    {
        [Display(Name = "عنوان")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "متن بلاگ")]
        [Required]
        public string Text { get; set; }
        [Display(Name = "تصویر")]
        public IFormFile Image { get; set; }
        [Display(Name = "تاریخ پست")]
        [Required]
        public DateTime DateCreated { get; set; }
        [Display(Name = "دسته بندی")]
        [Required]
        public string Categories { get; set; }
        [Display(Name = "تگ")]
        [Required]
        public string Tags { get; set; }
        [Required]
        [Display(Name = "نویسنده")]
        public string Author { get; set; }
    }
}
