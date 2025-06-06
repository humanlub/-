using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DataPublished { get; set; }
        public string YearPubl { get { return DataPublished.ToString("yyyy"); } }
    
    public Book(string title, string author, DateTime datePublushed)
        {
            Title = title;
            Author = author;
            DataPublished = datePublushed;
        }
        public override string ToString()
        {
            return "\tBook@" + GetHashCode() + "{\r\n" + "\t\tTitle: " + Title + "\r\n" + "\t\tAuthor: " + Author + "\r\n" + "\t\tDatePublished: " + DataPublished + "\r\n" + "\t\tYearPublished: " + YearPubl + "\r\n" + "\t";
        }
}   } 
