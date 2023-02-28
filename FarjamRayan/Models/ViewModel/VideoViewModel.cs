using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FarjamRayan.Models.ViewModel
{
    public class VideoViewModel
    {
        [Display(Name = "عنوان")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "فایل ویدیو")]
        [Required]
        public IFormFile VideoFile { get; set; }
        [Display(Name = "تاریخ")]
        [Required]
        public DateTime UploadedTime { get; set; }
        [Display(Name = "دسته بندی")]
        [Required]
        public string Category { get; set; }
    }
}
