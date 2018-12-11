using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryData.Models
{
    public class BookModel
    {
        public BookModel()
        {
            //set up dependancies. 
            var author = new AuthorModel();
            var genre = new GenreModel();
            var location = new LocationModel();

            //populate books. 
            Books.Add(new BookModel
            {
                BookId = 1,
                Title = "Harry Potter: The philosipher stone",
                IsRead = true,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Fantasy"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("J.K. Rowling")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            });

            Books.Add(new BookModel
            {
                BookId = 2,
                Title = "Harry Potter and the chamber of secrets",
                IsRead = true,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Fantasy"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("J.K. Rowling")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            });

            Books.Add(new BookModel
            {
                BookId = 3,
                Title = "Harry Potter: The prisoner of Azkaban",
                IsRead = true,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Fantasy"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("J.K. Rowling")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            });

            Books.Add(new BookModel
            {
                BookId = 4,
                Title = "Harry Potter and the Goblet of fire",
                IsRead = true,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Fantasy"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("J.K. Rowling")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            }); // set to unread if user it Tom. 

            Books.Add(new BookModel
            {
                BookId = 5,
                Title = "A brief history of time",
                IsRead = true,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Education"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("Hawking")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            });

            Books.Add(new BookModel
            {
                BookId = 6,
                Title = "Who built the Pyramids",
                IsRead = false,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Education"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("Graham Hancock")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("Edinburgh"))
            });

            Books.Add(new BookModel
            {
                BookId = 6,
                Title = "Ancient Civilisations",
                IsRead = false,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle == "Education"),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("Graham Hancock")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("London"))
            });

            Books.Add(new BookModel
            {
                BookId = 8,
                Title = "Spooky Ghost",
                IsRead = false,
                Genre = genre.Genres.FirstOrDefault(x => x.GenreTitle.Contains("Fiction")),
                Author = author.Authors.FirstOrDefault(x => x.AuthorName.Contains("R.L. Stein")),
                Location = location.Locations.FirstOrDefault(x => x.LocationCityName.Contains("Birmingham"))
            });
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public bool IsRead { get; set; }
        public GenreModel Genre { get; set; }
        public AuthorModel Author { get; set; }
        public LocationModel Location { get; set; }
        public List<BookModel> Books { get; set; } = new List<BookModel>();
    }
}
