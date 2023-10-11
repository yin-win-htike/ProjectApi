

using Microsoft.EntityFrameworkCore;


namespace ProjectApi.Models

{


    public class ProjectsDbContext : DbContext


    {


      //  public DbSet<Project> Projects { get; set; }
        public DbSet<Data> data { get; set; }
        
        

        public ProjectsDbContext(DbContextOptions<ProjectsDbContext> options) : base(options)


        {


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)


        {


     
            modelBuilder.Entity<Data>().ToTable("Devices");
            modelBuilder.Entity<Project>().HasKey(c=>c.Id);
            modelBuilder.Entity<Data>().HasKey(c=>c.Id);


        }


    }

}

