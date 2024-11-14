using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("post")]
    public class Post
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("summary")]
        public string Summary { get; set; }
        [Column("body")]
        public string Body { get; set; }
        [Column("slug")]
        public string Slug { get; set; }
        [Column("createdate")]
        public DateTime CreateDate { get; set; }
        [Column("lastupdatedate")]
        public DateTime LastUpdateDate { get; set; }

        [Column("categoryid")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Column("authorid")]
        public int AuthorId { get; set; }
        public Usuario Author { get; set; }
    }
}