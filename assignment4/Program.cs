namespace assignment4
{

        internal class Book
    {
        #region Question01_outside main 
        private string password = "secret";
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

        }
    }
}
