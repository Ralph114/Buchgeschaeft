using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary
{
    public class Book : Item
    {
        protected string Author;
        
        protected string Isbn;
        protected Category Category;

        public Book(Category category, string author, string isbn, decimal price, int stock, string title) :base(price, stock, title)
        {
            Category = category;
            Author = author;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Title} ({Author}, {Category} ({(int)Category}))";
        }
    }
}
