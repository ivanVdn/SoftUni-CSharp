namespace _03.Songs
{
    internal class Program
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var playlist = new List<Song>
            {
                Capacity = n
            };

            for (var i = 0; i < n; i++)
            {
                var songTokens = Console.ReadLine()?
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var song = new Song
                {
                    TypeList = songTokens?[0],
                    Time = songTokens?[2],
                    Name = songTokens?[1]
                };

                playlist.Add(song);
            }

            var playlistToPrint = Console.ReadLine();
            if (playlistToPrint == "all")
            {
                foreach (var song in playlist)
                {
                    Console.WriteLine(song.Name);
                }
                return;
            }

            foreach (var song in playlist.Where(song => song.TypeList == playlistToPrint))
            {
                Console.WriteLine(song.Name);
            }
        }

    }
    public class Song
    {
        public string? TypeList { get; set; }
        public string? Name { get; set; }
        public string? Time { get; set; }
    }
}
