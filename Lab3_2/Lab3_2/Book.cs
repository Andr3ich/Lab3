namespace Lab3_2
{
    class Book
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.Write("Назва:");
            title.SetTitle(Console.ReadLine());
            Console.Write("Автор:");
            author.SetAuthor(Console.ReadLine());
            Console.Write("Змiст:");
            content.SetContent(Console.ReadLine());
            Console.WriteLine("");

            title.Show();
            author.Show();
            content.Show();
        }
    }
}