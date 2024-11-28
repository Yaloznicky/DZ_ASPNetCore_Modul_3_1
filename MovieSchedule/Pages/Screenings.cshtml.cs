using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieSchedule.Services;
using ProgectFilm;
using ProgectListFilms;

namespace MovieSchedule.Pages
{
    [IgnoreAntiforgeryToken]
    public class ScreeningsModel(IFilmsService list, ILogger<ScreeningsModel> logger) : PageModel
    {
        public List<Film>? films = list.films;

        public void OnGet()
        {
        }
    }

}
