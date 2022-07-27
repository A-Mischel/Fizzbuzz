using System;


namespace Aryeh 
{ 
 
    internal class Program
    {
        private static int _Duration = 250;
   
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your number");
            GetInput();
        }

        public static void GetInput()
        {
            var UserInput = Console.ReadLine();
            if (UserInput is not null)
            {
                TestInput(UserInput);
            } 

        }

        static void TestInput(string input)
        {
            int number = 0;
            bool passed = true;
            
            try
            {
                number = Int32.Parse(input);
            }
            catch (Exception e)
            {
                var errorMessage = e.Message;
                passed = false;
                Console.WriteLine("Sorry, Please Enter a Valid Number");
            }

            if (!passed)
            {
                GetInput();
            }
            else
            {
                Fizzbuzz(number);
            }
        
        }
        
        public static void Fizzbuzz(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                string result = "";
                
                if(i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (String.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }

                Console.WriteLine(result);
                Task.Delay(_Duration).Wait();
            }
        }
    }
}