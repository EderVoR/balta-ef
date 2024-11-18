namespace Blog.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public IList<Usuario> Users { get; set; }
    }
}