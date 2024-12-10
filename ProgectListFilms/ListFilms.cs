using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using ProgectFilm;

namespace ProgectListFilms
{
    public class ListFilms
    {
        string connectionString = "../ProgectListFilms/dbFilms/dbFilms.json";


        public List<Film>? GetFilmList()
        {
            return ReadDB();
        }

        public List<Film>? ReadDB()
        {
            // чтение данных из базы данных
            using (FileStream fs = new FileStream(connectionString, FileMode.Open))
            {
                return JsonSerializer.Deserialize<List<Film>>(fs);
            }
        }


        public void WriteDB(List<Film> filmList)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true, //добавляем пробелы для красоты
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //не экранируем символы в строках
            };

            // сохранение данных в базу
            using (FileStream fs = new FileStream(connectionString, FileMode.Create))
            {
                JsonSerializer.Serialize<List<Film>>(fs, filmList, options);
            }
        }
    }
}
