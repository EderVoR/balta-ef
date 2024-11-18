using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

// context.Users.Add(new Usuario
// {
//     Bio = "teste",
//     Email = "mail@",
//     Image = "wwwwwww",
//     Name = "Eder",
//     PasswordHash = "jffjjlgçdg97987",
//     Slug = "eder"
// });

// context.SaveChanges();

var user = context.Users.FirstOrDefault();
var categoria = new Category
    {
        Name = "Back-end",
        Slug = "backend"
    };
var post = new Post
{
    Author = user,
    Title = "titulo",
    Category = categoria,
    Body = "teste de bnovo",
    Summary = "1 teste",
    Slug = "mais-um"
};

context.Posts.Add(post);
context.SaveChanges();