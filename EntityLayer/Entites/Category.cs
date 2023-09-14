using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Boş Geçilemez")]
        [Display(Name ="Ad")]
        [MaxLength(50,ErrorMessage ="Max 50 Karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [MaxLength(50, ErrorMessage = "Max 50 Karakter olmalıdır.")]
        public string Description { get; set; }

        public virtual List <Product> Products { get; set; }

    }
}
