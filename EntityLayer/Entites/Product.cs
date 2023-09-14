using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entites
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez.")]
        [Display(Name = "Açıklama")]
        [MaxLength(150, ErrorMessage = "Max 150 Karakter olmalıdır.")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Boş Geçilemez.")]
        [Display(Name="Ad")]
        [MaxLength(150,ErrorMessage ="Max 150 Karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez.")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Required(ErrorMessage ="Boş Geçilemez.")]
        [Display(Name ="Popüler")]
        public bool Popular { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Resim")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Adet")] 
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Cart> Cart { get; set; }
        public virtual List<Sales> Sales { get; set; }
    }
}
