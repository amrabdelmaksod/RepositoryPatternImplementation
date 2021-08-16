using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternDemo.Core.Models
{
   public class Article
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }

        // Navigation properties 

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
