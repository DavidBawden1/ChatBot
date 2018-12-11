using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class GenreModel
    {
        public GenreModel()
        {
            Genres.Add(new GenreModel { GenreId = 1, GenreTitle = "Fantasy"});
            Genres.Add(new GenreModel { GenreId = 2, GenreTitle = "Scifi" });
            Genres.Add(new GenreModel { GenreId = 3, GenreTitle = "Education" });
            Genres.Add(new GenreModel { GenreId = 4, GenreTitle = "Fiction" });
        }
        public int GenreId { get; set; }
        public string GenreTitle { get; set; }
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
    }
}
