using System.ComponentModel.DataAnnotations;

namespace Progetto3.Models
{
    public class Articolo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Prezzo { get; set; }

        [Required]
        public string Descrizione { get; set; }

        [Required]
        [Url]
        public string UrlImmagineCopertina { get; set; }

        [Url]
        public string UrlImmagineAggiuntiva1 { get; set; }

        [Url]
        public string UrlImmagineAggiuntiva2 { get; set; }
    }
}