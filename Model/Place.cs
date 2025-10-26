using System.ComponentModel.DataAnnotations;

namespace UrbexForum.Model
{
    public class Place
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string? Name { get; set; }
        //[Display(Name = "Kraj")]
        public string? Country { get; set; }
        [Display(Name = "Opis")]
        public string? Description { get; set; }
        [Display(Name = "Zdjęcie")]
        public byte[]? Image { get; set; }

    }
}
