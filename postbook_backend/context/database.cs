using Microsoft.EntityFrameworkCore;

public class contextDB : DbContext
{
  public DbSet<User> Users { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseSqlServer(@"
          Server=127.0.0.1;
          User=SA;
          Password=Postbook123;
          Database=Postbook;
          trustServerCertificate=true;
      ");
    }
  } 
}