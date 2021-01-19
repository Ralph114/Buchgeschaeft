using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary
{
    public sealed class Newspaper : Item
    {
        private DateTime DateOfIssue;

        public Newspaper (DateTime dateOfIssue, decimal price, int stock, string title):base(price, stock, title)
        {
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Title} ({DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year})";
        }
    }
}
