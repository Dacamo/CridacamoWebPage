using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CridacamoWebPage.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}