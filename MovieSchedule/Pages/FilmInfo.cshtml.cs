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
            int index = list.SearchIndex(id.ToString(), list.films!);
            film = list.films![index];
        }

        public IActionResult OnGetEdit(int id)
        {
            int index = list.SearchIndex(id.ToString(), list.films!);
            return RedirectToPage("Form", list.films![index]);
        }

        public IActionResult OnGetDelete(int id)
        {
            list.DeleteFilm(id.ToString());
            return RedirectToPage("Screenings");
        }
    }
}
