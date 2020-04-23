using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength = 3, ErrorMessage = "Kitap adı en az 3 karakter içermelidir")]
        [Required(ErrorMessage = "Kitap Adı alanının doldurulması zorunludur")]
        [Display(Name = "Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        [Display(Name = "Sayfa adedi")]
        [Required(ErrorMessage = "Sayfa adedi alanının doldurulması zorunludur")]
        public int? PageCount { get; set; }
        [Display(Name = "Yazar Adı")]
        [Required(ErrorMessage = "Yazar Adı alanının doldurulması zorunludur.")]
        public string Authors { get; set; }
        [Display(Name = "Açıklama")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Açıklama alanı an az 3 karakter içermelidir.")]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat alanının doldurulması zorunludur, eğer ücretsizse sıfır olarak giriş yapmalısınız.")]
        public Decimal Price { get; set; }

        [Display(Name = "Yayım Yılı")]
        public int PressYear { get; set; }

        [Display(Name = "Stok")]
        [Required(ErrorMessage = "Stok bilgisi alanının doldurulması zorunludur")]
        public int StockCount { get; set; }


        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        [Display(Name = "Kategori Adı")]
        public Category Category { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Yorumlar")]
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;

        }

    }
}
