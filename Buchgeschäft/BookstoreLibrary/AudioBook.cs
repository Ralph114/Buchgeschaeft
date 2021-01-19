using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary
{
    public sealed class AudioBook : Book
    {
        private int Duration;
        public AudioBook(Category cate, int duration, string author, string isbn, decimal price, int stock, string title) :base(cate, author, isbn, price, stock, title)
        {
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Title} ({Author}, {Duration} minutes, {Category} ({(int)Category}))";
        }
    }
}
