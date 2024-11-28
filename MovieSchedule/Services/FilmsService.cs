using ProgectFilm;
using ProgectListFilms;

namespace MovieSchedule.Services
{
    public interface IFilmsService
    {
        public List<Film>? films { get;}
    }

    public class FilmsService(IDbService db) : IFilmsService
    {
        List<Film>? IFilmsService.films 
        { 
            get => db.GetFilmList();
        }

    }

    public static class ServiceProviderFilmsExtentions
    {
        public static void AddFilmsService(this IServiceCollection services)
        {
            services.AddScoped<IFilmsService, FilmsService>();
        }
    }

}
