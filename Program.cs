using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Text;
namespace Tutorial
{
    public class Program
    {
        #region Functions
        public static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine(message);
                Console.WriteLine("{0} : {1}", message, i);
            }
        }

        public static double DoDivision(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new System.DivideByZeroException();
            }

            return num1 / num2;
        }

        private static void SayHello()
        {
            Console.Write("What is your name?: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }

        private static double GetSum(double x = 0, double y = 0)
        {
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }
        public static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static double GetSomeMore(params double[] nums)
        {
            double sum = 0;
            foreach (double i in nums)
            {
                sum += i; 
            }

            return sum;
        }

        public static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        public static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        } 
        
        public static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }

        public static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}.", cc, (int)cc);
        }

        #endregion

        public enum CarColor : byte
        {
            Orange = 1,
            Blue = 2,
            Green = 3,
            Red = 4,
            Yellow = 5,
        }



        public static void Main(string[] args)
        {
            #region basic data types, string methods
            //Console.Clear();

            //Console.WriteLine("Hello");
            //Console.Write("What is your name? ");
            ////Console.ForegroundColor = ConsoleColor.Black;
            ////Console.BackgroundColor = ConsoleColor.White;

            //string? name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //Console.WriteLine("The biggest integer is: {0}", int.MaxValue);
            //Console.WriteLine("The smallest integer is: {0}", int.MinValue);

            //Console.WriteLine("The biggest long is: {0}", long.MaxValue);
            //Console.WriteLine("The smallest long is: {0}", long.MinValue);


            //decimal decPiVal = 3.144355465466788713246878978978779777m;
            //decimal decBigNum = 3.00000000000000000000000000000000011m;

            //Console.WriteLine("Dec : PI + BigNum = {0}", decPiVal + decBigNum);

            //Console.WriteLine("The biggest decimal is: {0}", decimal.MaxValue);

            //Console.WriteLine("The biggest double is: {0}", double.MaxValue);
            //Console.WriteLine("The smallest double is: {0}", double.MinValue);

            //bool boolFromStr = bool.Parse("true");
            //Console.WriteLine(boolFromStr);

            //int intFromStr = int.Parse("1000");
            //Console.WriteLine(intFromStr);

            //double dblFromStr = double.Parse("1.234");
            //Console.WriteLine(dblFromStr);

            //string strVal = dblFromStr.ToString();
            //Console.WriteLine(strVal);

            //Console.WriteLine($"Data type : {strVal.GetType()}");
            //double dblNum = 12.345;
            //Console.WriteLine($"Integer : {(int)dblNum}");

            //int intNum = 10;
            //long longNum = (long)intNum;

            //Console.WriteLine("Currency : {0:c}", 23.455);
            //Console.WriteLine("Pad with zeroes : {0:d4}", 23);
            //Console.WriteLine("3 decimals : {0:f3}", 23.455456898987);
            //Console.WriteLine("Commas : {0:n4}", 2300);

            //string randStr = "This is a string.";
            //Console.WriteLine("String length : {0}", randStr.Length);
            //Console.WriteLine("String contains 'is' : {0}", randStr.Contains("is"));
            //Console.WriteLine("Index of 'is' : {0}", randStr.IndexOf("is"));
            //Console.WriteLine("Remove string : {0}", randStr.Remove(10, 7));
            //Console.WriteLine("Insert string : {0}", randStr.Insert(10, "short "));
            //Console.WriteLine("Replace string : {0}", randStr.Replace("string", "sentence"));
            //Console.WriteLine("Compare A to B : {0}",
            //    string.Compare("b", "B", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Pad Left : {0}", randStr.PadLeft(30, '.'));
            //Console.WriteLine("Pad Right: {0}", randStr.PadRight(30, '.'));
            //Console.WriteLine("Trim: {0}", randStr.Trim());
            //Console.WriteLine("Uppercase: {0}", randStr.ToUpper());
            //Console.WriteLine("Uppercase: {0}", randStr.ToLower());

            //string newString = String.Format("{0} saw a {1} {2} in the {3}.", "Paul", "rabbit", "eating", "field");

            //Console.Write(newString + '\n');
            //// \' \" \\ \t \a
            //Console.WriteLine(@"Exactly what I typed\n");
            #endregion

            #region Arrays, for loop, function basics, foreach

            //int[] intArray = new int[3];
            //intArray[0] = 10; 
            //intArray[1] = 20; 
            //intArray[2] = 30;
            //Console.WriteLine("Int at index 0 : {0}", intArray[0]);

            //string[] customers = { "Bob", "Sally", "Sue" };
            //var emplyees = new[] {"Mike", "Paul", "Rick" };
            //object[] randomArray = { "Paul", 45, 1.234, "Hello" };
            //Console.WriteLine("randomArray at index 0 : {0}", randomArray[0].GetType());  
            //Console.WriteLine("Array size : {0}", randomArray.Length);  


            //for(int i = 0; i < randomArray.Length; i++) 
            //{
            //    Console.WriteLine("Array index : {0} - Value : {1}", i, randomArray[i]);
            //}

            ////multi-dimensional arrays
            //Console.WriteLine("----------------------");
            //string[,] customerNames = new string[2, 2] {{ "Bob", "Smith" }, { "Candy", "Smith" }};
            //Console.WriteLine("multi-dimesional value : {0}", customerNames.GetValue(1, 0));

            //for(int i = 0; i < customerNames.GetLength(0); i++)
            //{
            //    for(int j = 0; j < customerNames.GetLength(1); j++)
            //    {
            //        Console.WriteLine("{0}", customerNames[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] randNums = { 1, 4, 8, 2 };
            //PrintArray(randNums, "ForEach");
            //Console.WriteLine("----------------------");
            ////Sort Arrays
            //Array.Sort(randNums);
            //PrintArray(randNums, "ForEach");
            ////Array.Reverse(randNums);
            //Console.WriteLine("1 at index : {0}", Array.IndexOf(randNums, 1));
            //PrintArray(randNums, "ForEach");

            //randNums.SetValue(0, 1);
            //PrintArray(randNums, "ForEach");

            //int[] srcArray = { 1, 2, 3, };
            //int[] destArray = new int[2];
            //int startInd = 0;
            //int length = 2;

            //Array.Copy(srcArray, startInd, destArray, 0, length);
            //PrintArray(destArray, "Copy");

            //Array anotherArray = Array.CreateInstance(typeof(int), 10);

            //srcArray.CopyTo(anotherArray, 5);

            //foreach (int i in anotherArray)
            //{
            //    Console.WriteLine("Copy to : {0}", i);
            //}

            #endregion

            #region Control flow (conditionals, ternary operator, switch statement, while, do while
            //int age = 1;

            /*if (age >= 5 && age <= 7)
            {
                Console.WriteLine("Go to elementary school");

            }
            if (age > 7 && age <= 13)
            {
                Console.WriteLine("Go to middle school");
            }
            if (age > 13 && age < 19)
            {
                Console.WriteLine("Go to high school");
            }
            else
            {
                Console.WriteLine("Go to college");

            }

            if (age < 14 || age > 67)
            {
                Console.WriteLine("You should not work");
            }*/

            /* bool canDrive = age >= 16 ? true : false;
             Console.WriteLine(canDrive);

             switch (age)
             {
                 case 1:
                 case 2:
                     Console.WriteLine("Go to day care!");
                     break;
                 case 3:
                 case 4:
                     Console.WriteLine("Go to pre school!");
                     break;
                 case 5:
                 case 6:
                     Console.WriteLine("Go to kindergarten!");
                     break;
                 default:
                     Console.WriteLine("Go to another school");
                     break;
             }*/

            /*int i = 1;
            int range = 100;
            Console.WriteLine("Odd numbers: ");
            while (i <= range)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;*/
            #endregion

            #region Random, Exception Handling, StringBuilder, Functions, Access Specifier, Out parameter, Pass by reference


            // Random number guessing game with instructions if guessed number is higher or lower than secret number 
            /* Random random = new Random();
             int secretNumber = random.Next(1, 1001);
             int userNumber;
             int guessCounter = 0;
             Console.WriteLine("Random Num: ", secretNumber);

             do
             {
                 Console.WriteLine("Enter a number between 1 and 1000: ");
                 userNumber = Convert.ToInt32(Console.ReadLine());
                 if (userNumber > secretNumber)
                 {
                     Console.WriteLine("The secret number is lower");
                 } else if (userNumber < secretNumber)
                 {
                     Console.WriteLine("The secret number is higher");

                 }
                 guessCounter++;
             } while (secretNumber != userNumber);

             Console.WriteLine("You guessed it, it was {0}", secretNumber);
             Console.WriteLine($"You had {guessCounter} guesses.");*/

            //Exception handling

            /*double num = 5;
            double y = 0;*/

            /*try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num, y));
            } 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide by zero.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }

            finally
            {
                Console.WriteLine("Cleaning up");
            }*/

            //String builders

            /*StringBuilder sb = new("Random Text");
            StringBuilder sb2 = new("More stuff that is very important", 256);

            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length: {0}", sb2.Length);
            sb2.AppendLine("\nMore important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCustomer = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer: {0}", bestCustomer);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, " that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());*/

            //Functions

            // <Access Modofier> <Return Type> <Method Name>(Parameters)
            // {<Body>}

            /* double x = 4;
             double y = 5;
             Console.WriteLine("4 + 5 = {0}", GetSum(x, y));
             Console.WriteLine("x = {0}", x);
             Console.WriteLine("y = {0}", y);*/

            /*int solution;
            DoubleIt(15, out solution);
            Console.WriteLine(solution);

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before swap num1 : {0} - num2 : {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After swap num1 : {0} - num2 : {1}", num3, num4);*/

            #endregion

            #region Passing Unknown Number of Parameters, Method Overloading, DateTime / TimeSpan,  Enumerated Types

            // passing unknown amount of parameters

            /* Console.WriteLine(GetSomeMore(1, 3, 4, 5, 6, 7));*/

            // named parameters
            // named parameters, the order does not matter, it can differ from the order 
            // specified in the argument list

            /*PrintInfo(zipCode: 1135, name: "Kurucsai György"); */

            // method overloading - same method name, but different amount of arguments, or different types of arguments

            /* double sum1 = GetSum2(10, 20);
             double sum2 = GetSum2("10", "1000");
             Console.WriteLine($"{sum1} - {sum2}");*/

            // DateTime, TimeSpan example

            /*DateTime myDate = new(1974, 12, 31);
            Console.WriteLine("Day of the week : {0}", myDate.DayOfWeek);
            myDate = myDate.AddDays(4);
            myDate = myDate.AddMonths(1);
            myDate = myDate.AddYears(21);
            Console.WriteLine("New Date : {0}", myDate.Date);

            TimeSpan lunchTime = new(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());  */

            // Enumerated Types

            CarColor car1 = CarColor.Orange;
            CarColor car2 = CarColor.Blue;
            PaintCar(car1);
            PaintCar(car2);
            
            #endregion



        }
    }
}
 

