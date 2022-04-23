using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Management_System.Models
{
    public class Book
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public Author Author { get; set; }

        [ForeignKey("Author")]
        public long AuthorId { get; set; }

        public Publisher Publisher { get; set; }

        [ForeignKey("Publisher")]
        public long PublisherId { get; set; }

        [StringLength(50)]
        public string PublishDate { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        public string Edition { get; set; }

        public decimal Cost { get; set; }

        public int NoOfPages { get; set; }

        public string Description { get; set; }

        public long ActualStock { get; set; }

        public long CurrentStock { get; set; }

        public string BookImageLink { get; set; }

    }
}