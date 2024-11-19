using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("post");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Summary)
                .HasColumnName("summary");

            builder.Property(x => x.Body)
                .HasColumnName("body");
            
            builder.Property(x => x.Slug)
                .HasColumnName("slug");

            builder.Property(x => x.AuthorId)
                .HasColumnName("authorid");

            builder.Property(x => x.CategoryId)
                .HasColumnName("categoryid");

            builder.Property(x => x.CreateDate)
                .IsRequired()
                .HasColumnName("createdate")
                .HasColumnType("timestamp(6)")
                .HasMaxLength(60)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.LastUpdateDate)
                .IsRequired()
                .HasColumnName("lastupdatedate")
                .HasColumnType("timestamp(6)")
                .HasMaxLength(60)
                .HasDefaultValue(DateTime.Now);

            builder.HasIndex(x => x.Slug, "IX_Post_Slug")
                .IsUnique();

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Posts)
                .HasConstraintName("FK_Post_Author")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Posts)
                .HasConstraintName("FK_Post_Category")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Posts)
                .UsingEntity<Dictionary<string, object>>(
                    "postag",
                    post => post.HasOne<Tag>()
                        .WithMany()
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_PostTag_PostId")
                        .OnDelete(DeleteBehavior.Cascade),
                    tag => tag.HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK_PostTag_TagId")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}