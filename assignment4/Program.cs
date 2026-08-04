namespace assignment4
{
    enum Genre { Fiction, NonFiction, Science }
    internal class Book
    {
        #region Question01_outside main 
        private string password = "secret";
        #endregion

        #region Question02_outside main
        //internal int copiesInStock = 5;
        #endregion

        #region Question03_outside main
        //public string Title;
        #endregion

        #region Question04_outside main
        //public Genre Genre;
        #endregion

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            {
                // Console.WriteLine(book.password);
                //  what happened? => This line does NOT compile: 'Book.password' is inaccessible
                //  why? => due to its protection level "private" restricts access to code
                // inside the Book class itself, so Main cannot reach it directly.
            }
            #endregion

            #region Question02
            {
                //Console.WriteLine(book.copiesInStock);
                //  does it compile? => Yes, this compiles. "internal" allows access from anywhere within
                //  why? => the same assembly (project), and Main is part of that same assembly,
                // so it's allowed to read copiesInStock even though it's outside the class.
            }
            #endregion

            #region Question03
            {
                //book.Title = "Clean Code";
                //Console.WriteLine(book.Title);
            }
            #endregion

            #region Question04
            {
                //book.Genre = Genre.Science;
               // Console.WriteLine(book.Genre);
            }
            #endregion

            #region Question05
            {
                //Console.WriteLine((int)Genre.Fiction);
                //Console.WriteLine((int)Genre.NonFiction);
                //Console.WriteLine((int)Genre.Science);
            }
            #endregion

            #region Question06
            {
                //int? genreNumber = 1;
                //Genre? result = (Genre)genreNumber;
                //Console.WriteLine($"the genre is: {result}");
            }
            #endregion

            #region Question07
            {
                //Genre? genre = Genre.Fiction;
                //string? genreString = genre.ToString();
                //Console.WriteLine(genreString);
            }
            #endregion

            #region Question08
            {
                //string? genreText = "Science";
                //Genre? genre = (Genre)Enum.Parse(typeof(Genre), genreText);
                //Console.WriteLine(genre);
            }
            #endregion

            #region Question09
            {
                //string? genreText = "Science";
                //Genre? genre;
                //if (Enum.TryParse(genreText, out genre))
                //{
                //    Console.WriteLine($"Parsed successfully: {genre}");
                //}
                //else
                //{
                //    Console.WriteLine("Failed to parse the genre :( ");
                //}
            }
            #endregion


        }
    }
}
