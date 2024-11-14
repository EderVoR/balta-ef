using Blog.Data;
using Blog.Models;

using (var context = new BlogDataContext())
{
    var tag = new Tag { Name = "ASP.NET", Slug = "aspnet"};
    context.Add(tag); 
    context.SaveChanges();
}