using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [DisplayName("Titulo")]
        [Required]
        public string Title { get; set; }

        [MaxLength(200, ErrorMessage ="El contenido debe tener menos de 200 letras")]
        [DisplayName("Contenido")]
        [Required]
        public string Content { get; set; }

        [DisplayName("Imagen")]
        public byte[] Image { get; set; }

        [DisplayName("Fecha publicacion")]
        [Required]
        public DateTime CreationDate { get; set; }

        [DisplayName("Categoria")]
        [Range(1, 10)]
        [Required]
        //public virtual List<Category> Categories { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
