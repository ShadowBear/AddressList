using System.ComponentModel.DataAnnotations;

namespace AddressList.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "FileID ist ein Pflichtfeld")]
        public int FileID { get; set; }
        
        [Required(ErrorMessage = "Aktenzeichen ist ein Pflichtfeld")]
        public string Aktenzeichen { get; set; }
        
        public string Rechtsform { get; set; } = string.Empty;
        public string Anrede { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vorname ist ein Pflichtfeld")]        
        public string Vorname { get; set; }

        [Required(ErrorMessage = "Nachname ist ein Pflichtfeld")]
        public string Nachname { get; set; }

        public string Straße { get; set; } = string.Empty;
        public string Hausnummer { get; set; } = string.Empty;
        public string PLZ { get; set; } = string.Empty;
        public string Ort { get; set; } = string.Empty;
        public string Land { get; set; } = string.Empty;
        public string Import { get; set; } = string.Empty;
        public string Datenquelle { get; set; } = string.Empty;
        public bool AktuelleAnschrift { get; set; }

        [Required(ErrorMessage = "Status ist ein Pflichtfeld")]
        public string AddressStatus { get; set; }
    }
}
