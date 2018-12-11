using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData.Models
{
    public class AuthorModel
    {
        public AuthorModel()
        {
            Authors.Add(new AuthorModel {AuthorId = 1, AuthorName = "J.K. Rowling" });
            Authors.Add(new AuthorModel { AuthorId = 2, AuthorName = "Stephen Hawking" });
            Authors.Add(new AuthorModel { AuthorId = 3, AuthorName = "R.L. Stein" });
            Authors.Add(new AuthorModel { AuthorId = 4, AuthorName = "Graham Hancock" });
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<AuthorModel> Authors { get; set; } = new List<AuthorModel>();
    }
}
