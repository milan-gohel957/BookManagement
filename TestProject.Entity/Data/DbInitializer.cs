using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using TestProject.Entity.Models;
namespace TestProject.Entity.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }
    public static string HashPassword(string password)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);

        string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 32
        ));
        return $"{Convert.ToBase64String(salt)}:{hashedPassword}";
    }


    public void Seed()
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
        });
        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
        });
        modelBuilder.Entity<IssuedBook>(entity =>
        {
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone");
        });
        modelBuilder.Entity<User>().HasData(
               new User() { Id = 1, Email = "user1@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 2, Email = "user2@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 3, Email = "user3@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 4, Email = "user4@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 5, Email = "user5@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 6, Email = "user6@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 7, Email = "user7@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 8, Email = "user8@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 9, Email = "user9@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 10, Email = "user10@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 11, Email = "user10@email.com", Password = HashPassword("123456"), RoleId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
               new User() { Id = 12, Email = "admin1@email.com", Password = HashPassword("123456"), RoleId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
        );
        modelBuilder.Entity<Role>().HasData(
            new Role() { Id = 1, RoleName = "Admin" },
            new Role() { Id = 2, RoleName = "User" }
        );
        modelBuilder.Entity<Book>().HasData(
            new Book() {Id = 1, AuthorName = "Chinua Achebe" , BookImageUrl = "https://unsplash.com/photos/9DaOYUYnOls", TotalPages = 209, Title = "Things Fall Apart", PublishedYear = 1958, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, ISBN = "7624133121"},
            new Book() {Id = 2, AuthorName = "Hans Christian Andersen" , BookImageUrl = "https://unsplash.com/photos/CXYPfveiuis", TotalPages = 784, Title = "Fairy tales", PublishedYear = 1836, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, ISBN = "9153676823"}
        );
        modelBuilder.Entity<IssuedBook>().HasData(
            new IssuedBook() {Id = 1, UserId = 1, BookId = 1, IsIssued = true, }
        );
    }
}

