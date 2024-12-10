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
        public const string New = "����� �����";
        public const string Edit = "��������� ���������� � ������";
        public const string Delete = "�������� ������";
        public const string Screenings = "����������� ������ �������";
        public const string FilmInfo = "������ ���������� � ������";
    }
}
