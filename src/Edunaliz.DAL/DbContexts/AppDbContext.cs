using Edunaliz.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Edunaliz.DAL.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Result> Results { get; set; }
}
