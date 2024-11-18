namespace Blog.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        public IList<Post> Posts { get; set; }
        public IList<Grupo> Roles { get; set; }
    }
}