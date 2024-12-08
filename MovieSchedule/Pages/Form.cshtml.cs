using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieSchedule.Services;
using ProgectFilm;

namespace MovieSchedule.Pages
{
    [IgnoreAntiforgeryToken]
    public class FormModel(IFilmsService list) : PageModel
    {
        public Film? film = new();

        public void OnGet(int id)
        {
            film = list.films![id];
        }

        public RedirectToPageResult OnPost()
        {
            Film editFilm = new Film(
                Request.Form["id"],
                Request.Form["movieTitle"],
                Request.Form["director"],
                Request.Form["style"],
                Request.Form["shortDescription"],
                new Screenings(Request.Form["date"]!, Request.Form["time"]!)
            );

            list.EditFilm(editFilm);

            return RedirectToPage("Screenings");
        }
    }
}
