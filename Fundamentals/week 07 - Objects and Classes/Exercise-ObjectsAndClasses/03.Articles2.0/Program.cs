namespace _03.Articles2._0
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }

    internal class Program
    {
        internal static void Main()
        {
            var articles = new List<Article>();

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var articleString = Console.ReadLine()?
                     .Split(", ")
                     .ToList();

                var article = new Article(articleString?[0], articleString?[1], articleString?[2]);

                articles.Add(article);

                Console.WriteLine(article);
            }
        }
    }
}
