using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Author
    {
        private string author = "";
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор:{author}");
        }
    }
}