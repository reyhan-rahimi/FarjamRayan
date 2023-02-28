using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FarjamRayan.Models
{
    public class Video
    {
        public int id { get; set; }
        [Display(Name = "عنوان")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "فایل ویدیو")]
        [Required]
        public string VideoFile { get; set; }
        [Display(Name = "تاریخ")]
        [Required]
        public DateTime UploadedTime { get; set; }
        [Display(Name = "دسته بندی")]
        [Required]
        public string Category { get; set; }
    }
}
