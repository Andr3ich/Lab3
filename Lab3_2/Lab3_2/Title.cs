using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Title
    {
        private string title = "";
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Назва:{title}");
        }
    }
}