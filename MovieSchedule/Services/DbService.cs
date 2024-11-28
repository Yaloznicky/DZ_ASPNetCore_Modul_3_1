using ProgectFilm;
using ProgectListFilms;

namespace MovieSchedule.Services
{
    public interface IDbService
    {
        public List<Film>? GetFilmList();
    }

    public class DbService : IDbService
    {
        public List<Film>? GetFilmList()
        {
            return new ListFilms().GetFilmList();
        }
    }

    public static class ServiceProviderDataBaseExtentions
    {
        public static void AddDataBaseService(this IServiceCollection services)
        {
            services.AddScoped<IDbService, DbService>();
        }
    }
}
