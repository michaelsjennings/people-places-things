using Microsoft.EntityFrameworkCore;
using MSJennings.PeoplePlacesThings.Data.Models;

namespace MSJennings.PeoplePlacesThings.Data.Services.EntityFramework
{
    public class AppDbContext : DbContext
    {
        #region Public Constructors

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Case> Cases { get; set; }

        #endregion Public Properties
    }
}