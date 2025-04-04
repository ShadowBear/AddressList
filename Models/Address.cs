using System.ComponentModel.DataAnnotations;

namespace AddressList.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int FileID { get; set; }
        public string Aktenzeichen { get; set; }

        public string Rechtsform { get; set; }

        public string Anrede { get; set; }

        public string Titel { get; set; }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }

        public string Import { get; set; }
        public string Datenquelle { get; set; }

        public bool AktuelleAnschrift { get; set; }

        public string AddressStatus { get; set; }
    }
}
