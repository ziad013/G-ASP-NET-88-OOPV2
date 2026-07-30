using System.Drawing;

namespace OOP01_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // Add a private string password = "secret"; field to a Book class. Try to print it from Main
            // (outside the class). What happens, and why?

            //Book book = new Book();
            //Console.WriteLine(book.password);
            //Can’t Access Because password from Type Private [Access through class only]
            #endregion
            #region Question02
            // Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?
            //Why ?

            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            //Can Access Because copiesInStock from Type internal [Access through class or same project]
            #endregion
            #region Question03
            //Add a public string Title; field to Book. Set it and print it from Main.

            //Book book = new Book();
            //book.Title = "BlaBla";
            //Console.WriteLine(book.Title);

            //Can Access Because Title from Type public [Access from anywhere]

            #endregion
            #region Question04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion
        }
    }
}
