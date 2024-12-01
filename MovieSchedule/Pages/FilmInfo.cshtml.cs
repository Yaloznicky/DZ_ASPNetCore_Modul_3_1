using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieSchedule.Services;
using ProgectFilm;

namespace MovieSchedule.Pages
{
    public class FilmInfoModel(IFilmsService list) : PageModel
    {
        public Film film = new();

        public void OnGet(int id)
        {
            film = list.films[id];
        }

    }
}
