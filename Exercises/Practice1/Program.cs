using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The result is: {Sum()}");
            Console.WriteLine($"The greater number is: {GetMax()}");
            CalculateAreaAndPerimeter();
            Console.WriteLine($"Numbers div with five: {Div()}");
            OtherMax();
            WrongInput();
            ReadNum();
            NumDiv();
            MaxFromFive();
            Triangle();
            ToBinary();
            RandomNum();
            Multip();
            ReadCompany();



            Console.ReadLine();
        }

        static int Sum ()
        {
            Console.Write("Enter first: ");
            string number = Console.ReadLine();
            int a;
            if (int.TryParse(number, out a))
            {

            }
            Console.Write("Enter second nr: ");
            string num = Console.ReadLine();
            int b;
            if(int.TryParse(num, out b))
            {

            }
            return a + b;
           
        }

        static int GetMax()
        {
            int max = 0;
            Console.Write("First num: ");
            string num1 = Console.ReadLine();
            int a;
            if (int.TryParse(num1, out a)) ;
            {

            }
            Console.Write("Second num: ");
            string num2 = Console.ReadLine();
            int b;
            if (int.TryParse(num2, out b))
            {

            }
            Console.Write("Third num: ");
            string num3 = Console.ReadLine();
            int c;
            if(int.TryParse(num3, out c))
            {

            }
            Console.Write("Fourth num: ");
            string num4 = Console.ReadLine();
            int d;
            if(int.TryParse(num4, out d))
            {

            }
            Console.Write("Fifth num: ");
            string num5 = Console.ReadLine();
            int e;
            if(int.TryParse(num5, out e))
            {

            }

            if (a > b && a > c && a > d && a > e)
            {
                max = a;
            }
            else if (b > a && b >c && b > d && b > e)
            {
                max = b;
            }
            else if (c > a && c > b && c > d && c > e)
            {
                max = c;
            }
            else if (d >a && d > b && d > c && d > e)
            {
                max = d;
            }
            else
            {
                max = e;
            }
            return max;
        }

        static void CalculateAreaAndPerimeter()
        {
            Console.WriteLine("Enter radius of a circle: ");
            string num1 = Console.ReadLine();
            double radius;
            if (!double.TryParse(num1, out radius))
            {
                Console.WriteLine("Not a number!");
            }
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"The area of the circle is: {area}, and perimeter is: {perimeter}");

        }

        static int Div()
        {
            int a = 19;
            int b = 29;
            int count = 0;
            int i = a;
            while (i <= b)
            {
                if (i % 5 == 0)
                {
                    count++;

                }
                i++;
            }
           return count;

        }

        static void OtherMax()
        {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();
            int max = 0;
            int a;
            if (int.TryParse(num1, out a))
            {

            }
            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();
            int b;
            if (int.TryParse(num2, out b))
            {

            }
            max = Math.Max(a, b);
            Console.WriteLine($"The greater is {max}");
            Console.ReadLine();
        }

        static void WrongInput()
        {
            int s = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input number: ");
                string n1 = Console.ReadLine();
                int a;
                if (!int.TryParse(n1, out a))
                {
                    Console.Write("Wrong number,try again: ");
                    n1 = Console.ReadLine();
                    if (!int.TryParse(n1, out a))
                    {
                        return;
                    }

                }
                s = s + a;

            }

            Console.WriteLine(s);
        }

        static void ReadNum()
        {
            Console.WriteLine("Please enter a number: ");
            string num1 = Console.ReadLine();
            int N;
            if (int.TryParse(num1, out N))
            {

            }
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void NumDiv()
        {
            Console.Write("Please enter a number: ");
            string num1 = Console.ReadLine();
            int N;
            if (int.TryParse(num1, out N))
            {

            }
            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void MaxFromFive()
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                string num = Console.ReadLine();
                int a;


                if (int.TryParse(num, out a))
                {

                }
                if (a < min)
                {
                    min = a;
                }
                else if (a > max)
                {
                    max = a;
                }

            }
            Console.WriteLine($"The largest number is {max} and the smallest number is {min}");
           
        }

        static void Triangle()
        {
            Console.Write("Please enter the number:");
            string num1 = Console.ReadLine();
            int i;
            if (int.TryParse(num1, out i))
            {

            }


            for (int a = 1; a <= i; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int a = i - 1; a > 0; a--)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }

        static void ToBinary()
        {
            string binaryNumber = "";
            int a;
            int b;
            Console.Write("Write a number: ");
            string num1 = Console.ReadLine();
            if (!int.TryParse(num1, out a))
            {
                Console.WriteLine("Not a number");
            }
            while (a > 0)
            {
                b = a % 2;
                a = a / 2;
                binaryNumber = binaryNumber + b.ToString();
            }

            Console.WriteLine($"The binary representation of {num1} is {binaryNumber}");
            Console.ReadLine();
        }

        static void RandomNum()
        {


            Console.WriteLine("Enter a number:");
            string num = Console.ReadLine();
            int a;

            if (!int.TryParse(num, out a))
            {
                Console.WriteLine("Not a number!");
            }
            int[] values = new int[a];
            int[] frecvency = new int[a];
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                values[i] = i + 1;
                frecvency[i] = 0;
            }
            System.Random random = new System.Random();
            while (count <= a)
            {
                int numRandom = random.Next(0, a);
                if (frecvency[numRandom] == 0)
                {
                    Console.WriteLine(values[numRandom]);
                    frecvency[numRandom] = 1;
                    count++;
                }

            }

            
        }

        static void Multip()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {

                    string multipBoth = i.ToString();
                    Console.WriteLine(multipBoth.Replace(multipBoth, "FizzBuzz"));


                }
                else if (i % 5 == 0)
                {
                    string multipFive = i.ToString();
                    Console.WriteLine(multipFive.Replace(multipFive, "buzz"));
                }
                else if (i % 3 == 0)
                {
                    string multipThree = i.ToString();

                    Console.WriteLine(multipThree.Replace(multipThree, "fizz"));
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        static void ReadCompany()
        {
            Console.Write("Enter name of the company: ");
            string name = Console.ReadLine();
            Console.Write("Enter address of the company: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Enter fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Enter link for web site: ");
            string link = Console.ReadLine();
            Console.Write("Enter manager of the company: ");
            string manager = Console.ReadLine();
            Console.Write("Enter the manager name: ");
            string managName = Console.ReadLine();
            Console.Write("Enter the manager surname: ");
            string managSurname = Console.ReadLine();
            Console.Write("Enter manager's phone number: ");
            string managPhone = Console.ReadLine();


            Console.WriteLine($"The company has: name {name}, address {address}, phone number {phone}, fax number {fax}, web site {link} and manager {manager}");
            Console.WriteLine($"The manager has: name {managName}, surname {managSurname} and phone number {managPhone} ");


        }

       
    }
}
    

