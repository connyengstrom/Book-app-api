using Microsoft.EntityFrameworkCore;

namespace BookQuotesApi.Models
{
    public class BookQuotesContext : DbContext
    {
        public BookQuotesContext(DbContextOptions<BookQuotesContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed a default user
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "user",
                    Password = "password"
                }
            );

            // Seed default quotes
            modelBuilder.Entity<Quote>().HasData(
                new Quote { Id = 1, Text = "The only limit to our realization of tomorrow is our doubts of today.", Author = "Franklin D. Roosevelt" },
                new Quote { Id = 2, Text = "In the end, we will remember not the words of our enemies, but the silence of our friends.", Author = "Martin Luther King Jr." },
                new Quote { Id = 3, Text = "The best way to predict the future is to invent it.", Author = "Alan Key" },
                new Quote { Id = 4, Text = "Life is 10% what happens to us and 90% how we react to it.", Author = "Charles R. Swindoll" },
                new Quote { Id = 5, Text = "I'd like to share a revelation that I've had during my time here. It came to me when I tried to classify your species and I realized that you're not actually mammals. Every mammal on this planet instinctively develops a natural equilibrium with the surrounding environment but you humans do not. You move to an area and you multiply and multiply until every natural resource is consumed and the only way you can survive is to spread to another area. There is another organism on this planet that follows the same pattern. Do you know what it is? A virus. Human beings are a disease, a cancer of this planet. You're a plague and we are the cure.", Author = "Agent Smith" }
            );
        }
    }
}
