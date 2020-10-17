using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace oxuAz.Models
{
    public class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// ///
        /// 
        [Required(ErrorMessage = "Enter Title")]
        [StringLength(100, ErrorMessage = "Max 100 char")]
        public string Title { get; set; }
        /// ///
        /// 
        [Required(ErrorMessage = "Content is null")]
        [MinLength(10, ErrorMessage = "Min 10 char")]
        public string Content { get; set; }
        /// ///
        /// 
        [Required]
        public DateTime Date { get; set; }
        /// ///
        /// 
        [Required]
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        /// ///
        /// 
        [NotMapped]
        [Display(Name = "File")]
        [Required(ErrorMessage = "Photo is required")]
        public IFormFile File { get; set; }
        /// ///
        /// 
        public int Likes { get; set; }
        /// ///
        /// 
        public int Dislikes { get; set; }
        /// ///
        /// 
        public int Views { get; set; }
    }
}
