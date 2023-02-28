using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FarjamRayan.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "متن بلاگ")]
        [Required]
        public string Text { get; set; }
        [Display(Name = "تصویر")]
        public string Image { get; set; }
        [Display(Name = "تاریخ پست")]
        [Required]
        public DateTime DateCreated { get; set; }
        [Display(Name = "دسته بندی")]
        [Required]
        public string Categories { get; set; }
        [Required]
        [Display(Name = "نویسنده")]
        public string Author { get; set; }
        [Display(Name = "تگ")]
        [Required]
        public string Tags { get; set; }
    }
}
