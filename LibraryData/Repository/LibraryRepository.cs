using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryData.Repository
{
    public class LibraryRepository
    {
        public List<BookModel> TomsBooks ()
        {
            //Tom has read most of the harry potter books. Except for the goblet of fire. 
            var bookModel = new BookModel();
            bookModel.Books.FirstOrDefault(x => x.Title.Contains("Goblet of fire")).IsRead = false;
            var tomsBooks = bookModel.Books.Where(book => book.Title.Contains("Harry Potter"));
            return tomsBooks.ToList();
        }

        public List<BookModel> SarahsBooks()
        {
            //sarah has a search history of educational books. 
            var bookModel = new BookModel();
            var sarahsBooks = bookModel.Books.Where(book => book.Genre.GenreTitle.Contains("Education"));
            return sarahsBooks.ToList();
        }

        public List<BookModel> UnfilteredLondonList()
        {
            var bookModel = new BookModel();
            var londonBooks = bookModel.Books.Where(books => books.Location.LocationCityName.Contains("London"));
            return londonBooks.ToList();
        }

        public List<BookModel> AllBooks()
        {
            var bookModel = new BookModel();
            return bookModel.Books.ToList();
        }
    }
}
