using Abstract_Class_Task.Models;
using Abstract_Class_Task.Product;


namespace Abstract_Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Task 1 Void
            //Console.Write("Username: ");
            //string username = Console.ReadLine();
            //Console.Write("Password: ");
            //string password = Console.ReadLine();

            //Account account = new Account();
            //account.Login(username, password);
            #endregion


            #region Task 2,3
            Console.Write("Kitab Saysini daxil edin ");
            int numBooks = int.Parse(Console.ReadLine());

            Book[] books = new Book[numBooks];

            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine($"Kitab detlarni daxil edin {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());
                Console.Write("Count: ");
                int count = int.Parse(Console.ReadLine());
                Console.Write("Genre: ");
                string genre = Console.ReadLine();

                books[i] = new Book(name, price, count, genre);
            }

         
            foreach (var book in books)
            {
                Console.WriteLine(book.Detail());
            }

         
            Console.Write("Endirim Faizni daxil edin ");
            int discountPercentage = int.Parse(Console.ReadLine());

            foreach (var book in books)
            {
                decimal discountedPrice = book.Discount(discountPercentage);
                Console.WriteLine($"Endrimli Qiymet {book.Name}: {discountedPrice}");
            }
            #endregion

        }
    }
}
