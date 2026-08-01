namespace assignment4
{

        internal class Book
    {
        #region Question01_outside main 
        private string password = "secret";
        #endregion

        #region Question02_outside main
        //internal int copiesInStock = 5;
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

        }
    }
}
