using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ProgectFilm;

namespace ProgectListFilms
{
    public class ListFilms
    {
        public List<Film>? GetFilmList()
        {
            return ReadDB();
        }

        public List<Film>? ReadDB()
        {
            // чтение данных из базы данных
            using (FileStream fs = new FileStream("../ProgectListFilms/dbFilms/dbFilms.json", FileMode.Open))
            {
                return JsonSerializer.Deserialize<List<Film>>(fs);
            }
        }


        //public void WriteDB()
        //{
        //    // сохранение данных в базу
        //    using (FileStream fs = new FileStream("db.json", FileMode.OpenOrCreate))
        //    {
        //        JsonSerializer.Serialize<List<Film>>(fs, filmList);
        //    }
        //}
    }
}
