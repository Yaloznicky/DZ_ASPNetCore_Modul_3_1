using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieSchedule.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }

    public static class Title
    {
        public const string New = "Новый фильм";
        public const string Edit = "Изменение информации о фильме";
        public const string Delete = "Удаление фильма";
        public const string Screenings = "Рассписание показа фильмов";
        public const string FilmInfo = "Полная информация о фильме";
    }
}
