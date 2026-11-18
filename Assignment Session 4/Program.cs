using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}
        #endregion

        #region Q06-Method
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        #endregion

        #region Q07-Method
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}
        #endregion

        #region Q08-Method
        //static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}
        #endregion

        #region Q09-Method
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }

        //    price = 0;
        //    return false;
        //}

        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Title: {title}, Pages: {pages}");
        //}
        #endregion

        #region Q11-Method
        //static void PrintAllTitles(params string[] titles)
        //{
        //    foreach (string title in titles)
        //    {
        //        Console.WriteLine(title);
        //    }
        //}
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

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Q06-Call
            //            Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // Expected output: 20.5.
            // The array reference is passed by value, but it still points to the same array object.
            // Therefore, changing prices[0] inside the method changes the original array.
            #endregion

            #region Q07-Call
            //            Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);

            // Expected output: 450. Using ref allows the method to modify the original variable.
            #endregion

            #region Q08-Call
            //            Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Q09-Call
            //            Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //2
            //and print the price if found
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.Call
            //it once with only a title, and once passing both a title and pages.

            //bool found = TryGetPrice("Clean Code", out double price);

            //if (found)
            //{
            //    Console.WriteLine($"Price: {price}");
            //}

            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Refactoring", 250);


            #endregion

            #region Q10
            //            Using the PrintBookInfo method from the question above, call it by naming the
            //parameters, passing pages before title.
            //PrintBookInfo(pages: 250, title: "Refactoring");
            #endregion

            #region Q11-Call
            //            Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            //Call it with three book titles.

            //PrintAllTitles("Clean Code", "DAN BROWN", "PROGRAMMING BOOK");

            #endregion

        }
    }
}
