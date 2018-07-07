using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CridacamoWebPage.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Author")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }

}