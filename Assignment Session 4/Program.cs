namespace Assignment_Session_4
{
    internal class Program
    {
        #region Q03-Method
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion

        #region Q04-Method
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}
        #endregion

        #region Q05-Method
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            // 1- Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion

            #region Q02
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.

            // int[,] shelfCopies =
            //{
            //     { 3, 5 },
            //     { 1, 4 }
            // };

            // Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            #region Q03-Call
            // Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.

            //PrintWelcomeMessage();

            #endregion

            #region Q04-Call
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with
            //"Clean Code"

            //PrintBookTitle("Clean Code");
            #endregion

            #region Q05-Call
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion
        }
    }
}
