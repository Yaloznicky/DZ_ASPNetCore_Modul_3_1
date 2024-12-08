using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieSchedule.Services;
using ProgectFilm;

namespace MovieSchedule.Pages
{
    [IgnoreAntiforgeryToken]
    public class ScreeningsModel(IFilmsService list) : PageModel
    {
        public List<Film>? films = list.films;
        public List<Film>? searchFilms = new();

        public void OnGet()
        {
        }

        public IActionResult OnGetEdit(int id)
        {
            return RedirectToPage("Form", list.films![id]);
        }

        public void OnPost(string chapter, string query)
        {
            searchFilms = list.SearchFilms(chapter, query);
        }
    }
}
