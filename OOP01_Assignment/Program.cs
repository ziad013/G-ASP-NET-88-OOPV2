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
        }
    }
}
