using System;

namespace FirstCsharpApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int r = Sum(4, 5);
            //Console.WriteLine(r);

            //if(5 == 5)
            //{
            //    int b = 5;
            //}


            //C# is strongly typed language

            //Data types
            //Variables
            //Conditions
            //Loops
            //Functions


            //string name = "terlan";
            //int number = 10;
            //long longNumber = 20;
            //double doubleNumber = 20.5;
            //float floatNumber = 34.6F;
            //char symbol = 'a';
            //byte byteNumber = 255;
            //decimal decimalNumber = 50.5M;
            //short shortNumber = 19;


            //int a = 5;
            //long b = 3147483647;

            //a = (int)b;

            //short d = 8;

            //a = d;

            //Console.WriteLine(Int32.MaxValue);

            //int number1 = 300;
            //byte number2 = 5;

            //number2 = (byte)number1;

            //Convert.To....


            //string stringNumber = "25";
            //int convertedNumber;
            //bool result = int.TryParse(stringNumber,out convertedNumber);



            //Convert processes

            //Casting
            //Convert to
            //TryParse



            //Console.WriteLine("Zəhmət olmasa rəqəm daxil edin.");
            //string stringNumber = Console.ReadLine();

            //int convertedNumber;

            //if(int.TryParse(stringNumber,out convertedNumber) == true)
            //{
            //    Console.WriteLine("Əməliyyat uğurla başa çatdı: " + convertedNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Düzgün rəqəm daxil edin.");
            //}


            //string password = "admin";
            //string username = "admin";


            //if(password == "admin" && username == "admin")
            //{
            //    Console.WriteLine("test");
            //}


            //for(var i =0; i< 10; i++)
            //{
            //    Console.WriteLine("test");
            //}


            bool exit = false;

            int counter = 0;
            while(exit == false)
            {
                counter++;

                if(counter == 3){
                    continue;
                }
                else if(counter == 10)
                {
                    exit = true;
                }

                Console.WriteLine("Test");
            }

        }

        static void WriteHello()
        {
            Console.WriteLine("Hello world!");
        }

        static int Sum(int a,int b)
        {
            int result = a + b;
            return result;
        }

    }
}
