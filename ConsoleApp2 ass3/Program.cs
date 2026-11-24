using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2_ass3;

internal class Program
{
    static void Main(string[] args)
    {
        //q1
        double[] praices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(praices[1]);
        //q2
        int[,] shelfcopies = { { 3, 5 }, { 1, 4 } };
        Console.WriteLine(shelfcopies[1, 0]);
        //q3
        printwelcomemessage();
        //q4
        printbooktitle("clean code");
        //q5
        int pages = 400;
        addbonuspages(pages);
        Console.WriteLine(pages);//400 
        //q6
        double [] prices={25.5, 40.0};
        applydiscount(prices);
        Console.WriteLine(prices[0]);//=20.5
        //q7

        int pages2 = 400;
        addbonuspagesref( ref pages2);
        Console.WriteLine(pages2);//450
        //q8
        replacearray(ref prices);
        Console.WriteLine(prices.Length);//3
        //q9 
        Console.WriteLine("enter the book title :");
        string book = Console.ReadLine();
        if (Trygetprice(book,out double price4))
        {

            Console.WriteLine(price4);
        }
        else
        {
            Console.WriteLine("not found");
        }
        //q10
        printbookinfo("c#");
        printbookinfo("c#",444);
        //q11
        printbookinfo(pages: 444, tit :"c#");
        //q12

        Console.WriteLine("enter title 1 : ");
        string t1 = Console.ReadLine();
        Console.WriteLine("enter title 2 : ");
        string t2 = Console.ReadLine();
        Console.WriteLine("enter title 3 : ");
        string t3 = Console.ReadLine();

        printalltitles (t1,t2,t3);





    }



    static void printwelcomemessage()
    {
        Console.WriteLine("welcome to the library");
    }
    static void printbooktitle (string title)
    {
        Console.WriteLine($"book title : {title}");
    }
   static void addbonuspages(int pages)
    {
        
        pages = pages + 50;
    }
    static void applydiscount(double[] prices)
    {
        prices[0] = prices[0] - 5;
    }
    static void addbonuspagesref( ref int pages2)
    {

        pages2 = pages2 + 50;
    }
    static void replacearray(ref double[]prices)

    {
        prices = new double[] { 10, 12.5, 15 };
    }
    static bool Trygetprice(string titell , out double price4)
    {
        if (titell=="clean code")
        {
            price4 = 25.5;
            return true;
        }
        else
        {
            price4 = 0;
            return false;
        }
        
    }
    static void printbookinfo(string tit,int pages = 300)
    {
        Console.WriteLine($"title is : {tit} and pages is : {pages}");
    }
    static void printalltitles( params string[] titles)
    {
        foreach(string t in titles)
        Console.WriteLine(t);
    }
       
}


