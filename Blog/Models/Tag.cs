using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("tag")]
    public class Tag
    {
        [Key]
		[Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("slug")]
        public string Slug { get; set; }
    }
}