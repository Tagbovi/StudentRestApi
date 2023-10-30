
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;

namespace StudentRestAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

       

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");



            //send Student Table
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Akash",
                    LastName = "Gupa",
                    Email="Kwase@gmail.com",
                    DateOfBirth = DateTime.SpecifyKind (new DateTime(1942, 1, 1), DateTimeKind.Utc),
                    Gender=Gender.Male,
                    DepartmentId=1,
                    PhotoPath="images/Akaash.png"


                }

                
                );


            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   StudentId = 2,
                   FirstName = "Mia",
                   LastName = "Gupa",
                   Email = "Mia@gmail.com",
                   DateOfBirth = DateTime.SpecifyKind(new DateTime(1994, 3, 1), DateTimeKind.Utc),

                   
                   Gender = Gender.Female,
                   DepartmentId = 2,
                   PhotoPath = "images/Akaash.png"


               }


               );


            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   StudentId = 3,
                   FirstName = "Kua",
                   LastName = "Gupa",
                   Email = "Kua@gmail.com",
                  
                   DateOfBirth = DateTime.SpecifyKind(new DateTime(1992, 4, 4), DateTimeKind.Utc),

                   Gender = Gender.Male,
                   DepartmentId =3,
                   PhotoPath = "images/Akaash.png"


               }


               );



            modelBuilder.Entity<Student>().HasData(
               new Student
               {
                   StudentId = 4,
                   FirstName = "Ama",
                   LastName = "Gupa",
                   Email = "Ama@gmail.com",
                   DateOfBirth = DateTime.SpecifyKind(new DateTime(1955, 6, 9), DateTimeKind.Utc),

                   
                   Gender = Gender.Female,
                   DepartmentId = 4,
                   PhotoPath = "images/Akaash.png"


               }


               );

        }

       


    }
}
