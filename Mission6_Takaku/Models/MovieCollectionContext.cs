using Microsoft.EntityFrameworkCore;

namespace Mission6_Takaku.Models
{
    //public class MovieCollectionContext : DbContext
    //{
    //    //This is connecting database with Collection models. By doing this, user can input the value and send them to SQLite database
    //    public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options) //Constructor
    //    {

    //    }

    //    public DbSet<Collection> Collection { get; set; }

        
    //}

    public class JoelHiltonMovieCollection : DbContext
    {
        public JoelHiltonMovieCollection(DbContextOptions<JoelHiltonMovieCollection> options) : base(options) //Constructor
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
