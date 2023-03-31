using Interview.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Interview.Api.Infrastructure
{
    public interface IApiContext
    {
        DbSet<Genre> Genres { get; set; }
        DbSet<Media> Media { get; set; }

    }
}
