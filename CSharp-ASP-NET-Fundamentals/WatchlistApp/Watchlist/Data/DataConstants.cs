namespace Watchlist.Data
{
    public static class DataConstants
    {
        public static class Genre
        {
            public const int MaxGenreName = 50;
            public const int MinGenreName = 5;
        }

        public static class Movie
        {
            public const int MaxMovieTitle = 50;
            public const int MinMovieTitle = 5;

            public const int MaxDirectorName = 50;
            public const int MinDirectorName = 5;

            public const decimal MaxRating = 10.00m;
            public const decimal MinRating = 0.00m;
        }

        public static class User
        {
            public const int MaxUsername = 20;
            public const int MinUsername = 5;

            public const int MaxPasswordLength = 20;
            public const int MinPasswordLength = 5;

            public const int MaxEmaildLength = 60;
            public const int MinEmailLength = 10;
        }

        
    }
}
