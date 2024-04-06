using System;
namespace Tutorial
{
    public class Program
    {
        #region Functions
        public static void PrintArray(int[] intArray, string message)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0} : {1}", message, i);
            }
        }
        #endregion
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

            int[] intArray = new int[3];
            intArray[0] = 10; 
            intArray[1] = 20; 
            intArray[2] = 30;
            Console.WriteLine("Int at index 0 : {0}", intArray[0]);

            string[] customers = { "Bob", "Sally", "Sue" };
            var emplyees = new[] {"Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234, "Hello" };
            Console.WriteLine("randomArray at index 0 : {0}", randomArray[0].GetType());  
            Console.WriteLine("Array size : {0}", randomArray.Length);  
        

            for(int i = 0; i < randomArray.Length; i++) 
            {
                Console.WriteLine("Array index : {0} - Value : {1}", i, randomArray[i]);
            }

            //multi-dimensional arrays
            Console.WriteLine("----------------------");
            string[,] customerNames = new string[2, 2] {{ "Bob", "Smith" }, { "Candy", "Smith" }};
            Console.WriteLine("multi-dimesional value : {0}", customerNames.GetValue(1, 0));

            for(int i = 0; i < customerNames.GetLength(0); i++)
            {
                for(int j = 0; j < customerNames.GetLength(1); j++)
                {
                    Console.WriteLine("{0}", customerNames[i, j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 8, 2 };
            PrintArray(randNums, "ForEach");
            Console.WriteLine("----------------------");
            //Sort Arrays
            Array.Sort(randNums);
            PrintArray(randNums, "ForEach");
            //Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0}", Array.IndexOf(randNums, 1));
            PrintArray(randNums, "ForEach");

            randNums.SetValue(0, 1);
            PrintArray(randNums, "ForEach");

            int[] srcArray = { 1, 2, 3, };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            
            srcArray.CopyTo(anotherArray, 5);

            foreach (int i in anotherArray)
            {
                Console.WriteLine("Copy to : {0}", i);
            } 



            #endregion 


        }
    }
}

