using System.ComponentModel.DataAnnotations.Schema;

namespace App.Entities
{
    [Table("Artist")]

    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
