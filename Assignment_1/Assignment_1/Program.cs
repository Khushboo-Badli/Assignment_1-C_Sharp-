using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ----------------------------------
            1.Write a program in C# Sharp to find the sum of all elements of the array.  

            Test Data : 

            Input the number of elements to be stored in the array :3 

            Input 3 elements in the array : 

            element - 0 : 2 

            element - 1 : 5 

            element - 2 : 8 

            Expected Output : 

            Sum of all elements stored in the array is : 15 

            */

            Console.WriteLine("Question 1");
            int[] array = { 2, 5, 8 };
            int sum = 0;
            foreach (var item in array)
            {
                sum = sum + item;
            }
            Console.WriteLine($"the sum of an array is {sum}");

            /*
            ----------------------------------------------------------------------
            2.Write a program in C# SharpCo 

            Test Data : 

            Input the number of elements to be stored in the array :3 

            Input 3 elements in the array : 

            element - 0 : 1 

            element - 1 : 5 

            element - 2 : 1 

            Expected Output : 

            The unique elements found in the array are : 

            5 

             */
            Console.WriteLine("Question 2");
            int[] array2 = { 1, 5, 1 };
            
            
            foreach (var i in array2.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key))
                 Console.WriteLine("Unique array element: " + i);




            /*
            -------------------------------------------------------------------------------------
            3.Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.  

            Test Data : 

            Input elements in the matrix : 

            element - [0],[0] : 1 

            element - [0],[1] : 2 

            element - [0],[2] : 3 

            element - [1],[0] : 4 

            element - [1],[1] : 5 

            element - [1],[2] : 6 

            element - [2],[0] : 7 

            element - [2],[1] : 8 

            element - [2],[2] : 9 

            Expected Output : 

            The matrix is : 



            1 2 3 

            4 5 6 

            7 8 9 

            */

            
            Console.WriteLine("Question 3");
            int[,] array3 =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            int[,] myArray = new int[3 , 3];
            Console.WriteLine("the matrix is:\n");

            for (int i = 0; i <= array3.GetLength(0); i++)
            {
                for (int j = 0; j <= array3.GetLength(1); j++)
                {
                    Console.Write(array3[i ,j] + " ");
                }
                Console.WriteLine();
            }

            


            /*


            ------------------------------------------------------------------

             4. Write a program in C# Sharp to check the username and password.  
            Test Data : 
            username : abcd 
            and 
            Password  : 1234 
            After 3 Wrong attempts user is locked  


            Test Data : 

            Input a username: uesr 

            Input a password: pass 

            Input a username: abcd 

            Input a password: 1234 

            Expected Output : 

            Password entered successfully! 

            */
            Console.WriteLine("Question 4");
            string userName = "abcd";
            int passWord = 1234;
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Input a Username:");
                string user = Console.ReadLine();
                Console.Write("Input a Password");
                int pass = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input a Username: {user}");
                Console.WriteLine($"Input a Password: {pass} ");
                count++;
                if (user == userName && pass == passWord)
                {
                    Console.WriteLine("Password entered successfully! ");
                    break;
                }
                else if (count >3)
                {
                    Console.WriteLine("User is locked");
                }
            }



            /*
            -------------------------------------------------------------------------------------
            5. Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures. 

            Note : The strings "encyclopedia" and "encyclopedia" are considered equivalent in the en-US culture but not in the Sami (Northern Sweden) culture. 

            Expected Output : 

               case = Case (CurrentCulture): False                                            
               case = Case (CurrentCultureIgnoreCase): True                                   
               case = Case (InvariantCulture): False                                          
               case = Case (InvariantCultureIgnoreCase): True                                 




            Write a program in C# Sharp to ch

            */
            Console.WriteLine("Question 5");
            String[] cultureNames = { "en-AU", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia",
                            "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia",
                            "encyclopedia" , "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                          strs2[ctr], comparison,
                                          String.Equals(strs1[ctr], strs2[ctr], comparison));

                    Console.WriteLine();
                }
                Console.WriteLine();
            }



            /*
            -------------------------------------------------------------------------------

            6. Write a C# Sharp program to convert a given integer value to Roman numerals.  

            Expected Output: 

            Original integer value: 2365 

            Roman numerals of the said integer value: 

            MMCCCLXV 

            Original integer value: 254 

            Roman numerals of the said integer value: 

            CCLIV 

            Original integer value: 45 

            Roman numerals of the said integer value: 

            XLV 

            Original integer value: 8 

            Roman numerals of the said integer value: 

            VIII 


            */
            Console.WriteLine("Question 6");
            int n;
            n = 2365;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine("Roman numerals of the said integer value:");
            Console.WriteLine(int_to_Roman(n));
            n = 254;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine("Roman numerals of the said integer value:");
            Console.WriteLine(int_to_Roman(n));
            n = 45;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine("Roman numerals of the said integer value:");
            Console.WriteLine(int_to_Roman(n));
            n = 8;
            Console.WriteLine("Original integer value: " + n);
            Console.WriteLine("Roman numerals of the said integer value:");
            Console.WriteLine(int_to_Roman(n));

            /*

            ------------------------------------------------------------------------------------------
            7.Write a program in C# Sharp to generate all possible permutations of an array using recursion.  

            Test Data : 

            Input the number of elements to store in the array [maximum 5 digits ] :3 

            Input 3 number of elements in the array : 

            element - 0 : 1 

            element - 1 : 2 

            element - 2 : 3 

            Expected Output : 

            The Permutations with a combination of 3 digits are : 

            123 132 213 231 321 312

                         */


        }

        //---------- ques 6----------------------
        public static string int_to_Roman(int n)
        {
            string[] roman_symbol = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] int_value = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var roman_numerals = new StringBuilder();
            var index_num = 0;
            while (n != 0)
            {
                if (n >= int_value[index_num])
                {
                    n -= int_value[index_num];
                    roman_numerals.Append(roman_symbol[index_num]);
                }
                else
                {
                    index_num++;
                }
            }

            return roman_numerals.ToString();
        }
    
    }
}
