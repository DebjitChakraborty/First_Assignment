using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    internal class Program
    {
        public struct Books
        {
            public int bookId;
            public string title;
            public double price;
            public BookType bookType;
        }
        public enum BookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }
        static void Main(string[] args)
        {

            //Calculator();

            //highestMarks();

            //int[] arr = { 15, 25, 13, 54, 50};
            //arraySum(arr);

            //swapingIntegers(15, 50);

            //Circle(4);

            acceptingBookDetails();

            Console.ReadLine();

        }

        public static void Calculator()
        {
            int a, b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of two numbers       : " + (a + b));
            Console.WriteLine("Subtraction of two numbers     : " + (a - b));
            Console.WriteLine("Multiplication of two numbers  : " + (a * b));
            Console.WriteLine("Division of two numbers        : " + (a / b));
        }
        public static void highestMarks()
        {
            int[] marks = new int[5];
            int flag = 0;
            Console.WriteLine("Enter the marks of the five students");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] > flag)
                    flag = marks[i];
            }
            Console.WriteLine("Highest marks obtained among all students is : " + flag);
        }
        public static void arraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all the elements in the array is : " + sum);
        }
        public static void swapingIntegers(int a, int b)
        {
            Console.WriteLine("Numbers before swapping: a is {0} and b is {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numbers after swapping: a is {0} and b is {1}", a, b);
        }
        public static void Circle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            double circum = 2 * Math.PI * r;
            Console.WriteLine("Area of the circle is {0}", area);
            Console.WriteLine("Circimference of the circle is {0}", circum);
        }
        public static void acceptingBookDetails()
        {
            int bookid, n; string booktitle; double bookprice;
            Console.WriteLine("Enter the details of the book");
            Console.WriteLine("Enter the book id");
            bookid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the title of the book");
            booktitle = Console.ReadLine();
            Console.WriteLine("Enter the price of the book");
            bookprice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the type of the book \n 1. Magazine  2. Novel \n 3. ReferenceBook  4. Miscellaneous");
            n = Convert.ToInt32(Console.ReadLine());
            Books book = new Books();
            book.bookId = bookid;
            book.title = booktitle;
            book.price = bookprice;
            book.bookType = (BookType)n - 1;
            displayBookDetais(book.bookId, book.title, book.price, book.bookType);
        }
        public static void displayBookDetais(int id, string title, double price, BookType type)
        {
            Console.WriteLine("Book Details : ");
            Console.WriteLine("Book Id :" + id);
            Console.WriteLine("Book Title :" + title);
            Console.WriteLine("Book Price :" + price);
            Console.WriteLine("Book Book Type :" + type);
        }
    }
}
