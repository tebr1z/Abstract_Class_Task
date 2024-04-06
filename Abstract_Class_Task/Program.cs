using Abstract_Class_Task.Models;
using Abstract_Class_Task.Product;
using Auth.Auth;


namespace Abstract_Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Task 1 Void

            Console.WriteLine("User Name Daxil edin");
            string userName = Console.ReadLine();
            Console.WriteLine("Password daxil edin");
            string password = Console.ReadLine();

            AuthService authService = new();
            Console.WriteLine(authService.Login(userName, password));


            #endregion


            #region Task 2,3
            //Console.WriteLine("=====================================");
            //Console.Write("Kitab Saysini daxil edin ");
            //int numBooks = int.Parse(Console.ReadLine());

            //Book[] books = new Book[numBooks];

            //for (int i = 0; i < numBooks; i++)
            //{
            //    Console.WriteLine("=====================================");
            //    Console.WriteLine($"Kitab detlarni daxil edin {i + 1}:");
            //    Console.WriteLine("=====================================");
            //    Console.Write("Ad: ");
            //    Console.WriteLine("=====================================");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("=====================================");
            //    Console.Write("Qiymet: ");
            //    Console.WriteLine("=====================================");
            //    decimal price = decimal.Parse(Console.ReadLine());
            //    Console.WriteLine("=====================================");
            //    Console.Write("Sayi: ");
            //    int count = int.Parse(Console.ReadLine());
            //    Console.WriteLine("=====================================");
            //    Console.Write("Turu: ");
            //    string genre = Console.ReadLine();


            //}


            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Detail());
            //}

            //Console.WriteLine("=====================================");
            //Console.Write("Endirim Faizni daxil edin ");
            //int discountPercentage = int.Parse(Console.ReadLine());

            //foreach (var book in books)
            //{
            //    decimal discountedPrice = book.Discount(discountPercentage);
            //    Console.WriteLine($"Endrimli Qiymet {book.Name}: {discountedPrice}");
            //}
            #endregion


            //int a = 4;


            //int[] b = { 1, 2, 3, 4 };

            //int sum = 0;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    sum = b[i] + b[i++];
            //}
            //Console.WriteLine(sum);
        }
    }
}
