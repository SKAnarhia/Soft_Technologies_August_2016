using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WasteOfTimeTeamProject.Models
{
    public class Post
    { public Post()
        { this.Date = DateTime.Now; }


        [Key]
        public int ID { get; set; }
       
        [Required]
        [StringLength(200)]
        public string Song { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        
        public DateTime Date { get; set; }

        
        
        public ApplicationUser User { get; set; }

    }
}