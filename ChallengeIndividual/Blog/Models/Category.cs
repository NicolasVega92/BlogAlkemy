using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Categoria")]
        [MaxLength(50, ErrorMessage ="El nombre de la categoia debe ser menor a 50 letras")]
        [Required]
        public string CategoryName { get; set; }
        //public int PostId { get; set; }
        //public virtual  Post Post { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
