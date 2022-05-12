namespace MvcMovie.Models
{
    public class MovieRepository
    {
        private List<Movie> _allMovies = new List<Movie>(){
                    new Movie
                    {
                        Id = 1,
                        Title = "เร็วโหด..เหมือนโกรธเธอ",
                        ReleaseDate = DateTime.Parse("2022-4-6"),
                        Genre = "Romantic Comedy",
                        Price = 11.70M,
                        Url = "https://upload.wikimedia.org/wikipedia/th/b/b3/Fast_and_Feel_Love.jpg",
                        youtube = "https://www.youtube.com/embed/hUqDKKIIm5g"
                    },

                    new Movie
                    {   
                        Id = 2,
                        Title = "วันสุดท้าย..ก่อนบายเธอ",
                        ReleaseDate = DateTime.Parse("2022-2-10"),
                        Genre = "Drama",
                        Price = 70.10M,
                        Url = "https://upload.wikimedia.org/wikipedia/th/8/8c/OnefortheRoad.jpg",
                        youtube = "https://www.youtube.com/embed/MdY6N-RTrPg"
                    },

                    new Movie
                    {
                        Id = 3,
                        Title = "ร่างทรง",
                        ReleaseDate = DateTime.Parse("2021-10-28"),
                        Genre = "thriller",
                        Price = 112.19M,
                        Url = "https://upload.wikimedia.org/wikipedia/th/0/04/TheMediumThaiPoster.jpg",
                        youtube = "https://www.youtube.com/embed/XStLMJu0fI4"
                    },

                    new Movie
                    {
                        Id = 4,
                        Title = "4Kings",
                        ReleaseDate = DateTime.Parse("2021-10-9"),
                        Genre = "Action, Gangster",
                        Price = 170M,
                        Url = "https://lh3.googleusercontent.com/1nf4oCXIOoOh3veQxhhGEGIh9ZFnkz9V9G2Hz3zzA8yMUU9UUmdkmfUaWtj0Ov3ihGED7npQ9yXPXAzsSkGakK3b7YEt4Rdaf7E=w260",
                        youtube = "https://www.youtube.com/embed/3olMNtUaVW4"
                    }
        };
        public List<Movie> GetMovies() => _allMovies;
    }
}