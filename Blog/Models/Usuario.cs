using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("passwordhash")]
        public string PasswordHash { get; set; }
        [Column("bio")]
        public string Bio { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("slug")]
        public string Slug { get; set; }
    }
}