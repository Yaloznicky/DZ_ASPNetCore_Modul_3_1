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

        public IActionResult OnGetNewFilm()
        {
            ViewData["Title"] = Title.New;  
            film = new();
            int newId = list.films!.Max(m => Convert.ToInt32(m.id)) + 1;
            film!.id = newId.ToString();
            return Page();
        }

        public void OnGet(int id)
        {
            ViewData["Title"] = Title.Edit;
            film = list.films![id];
        }

        public RedirectToPageResult OnPost(string key)
        {
            Film tmpFilm = new Film(
                Request.Form["id"],
                Request.Form["movieTitle"],
                Request.Form["director"],
                Request.Form["style"],
                Request.Form["shortDescription"],
                new Screenings(Request.Form["date"]!, Request.Form["time"]!)
            );

            switch (key)
            {
                case Title.New: 
                    list.NewFilm(tmpFilm);
                    break;
                case Title.Edit:
                    list.EditFilm(tmpFilm);
                    break;

                default:
                    break;
            }

            return RedirectToPage("Screenings");
        }
    }
}
