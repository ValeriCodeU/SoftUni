namespace Library.Data
{
    public static class DataConstants
    {
        public static class Category
        {
            public const int MaxCategoryName = 50;
            public const int MinCategoryName = 5;
        }

        public static class Book
        {
            public const int MaxTitleBook = 50;
            public const int MinTitleBook = 10;

            public const int MaxAuthorName = 50;
            public const int MinAuthorName = 5;

            public const int MaxDescription = 5000;
            public const int MinDescription = 5;
        }

        public static class ApplicationUser
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
