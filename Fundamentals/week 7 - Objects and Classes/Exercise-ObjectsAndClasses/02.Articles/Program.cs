namespace _02.Articles
{
    public class Article
    {
        public Article(string? title, string? content, string? author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
        

        public void EditContent(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

}

    internal class Program
    {
        internal static void Main()
        {
            var articleString = Console.ReadLine()?
                .Split(", ")
                .ToList();

            var articles = new Article(articleString?[0], articleString?[1], articleString?[2]);

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine()?
                    .Split(": ")
                    .ToList();

                switch (cmd?[0])
                {
                    case "Edit":
                        articles.EditContent(cmd[1]);
                        break;
                    case "ChangeAuthor":
                        articles.ChangeAuthor(cmd[1]);
                        break;
                    case "Rename":
                        articles.Rename(cmd[1]);
                        break;
                }
            }

            Console.WriteLine(articles.ToString());
        }
    }
}
