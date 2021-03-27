using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_task2_var2.Entities
{
    public class Book
    {

        public string Name { get; set; }

        public int NumberOfPages { get; set; }

        public string Publisher { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime WritingDate { get; set; }

        public Author BookAuthor { get; set; }
        public Book(string name, int numberOfPages, string publisher, DateTime publicationDate, DateTime writingDate, Author author)
        {
            this.Name = name;
            this.NumberOfPages = numberOfPages;
            this.Publisher = publisher;
            this.PublicationDate = publicationDate;
            this.WritingDate = writingDate;
            this.BookAuthor = author;
        }





    }
}
