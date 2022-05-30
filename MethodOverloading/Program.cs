using System;

namespace MethodOverloading
{
    class Program
    {
        //Create an Add method:
        //This Add method takes 2 integer parameters
        public static int Add(int y, int x)
        {
            return (x + y);
        }
        
        //Create an overload of the Add method:
        //This Add method needs to have 2 decimal parameters
        public static decimal Add(decimal num1, decimal num 2)
        {
            return (num1 + num2);
        }

        //Create another overload of the Add method:
        //This Add method returns a string
        //And this Add method takes 3 parameters
        //2 integer parameters
        //1 boolean parameters
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            //If boolean parameter is equal to true:
            //This Add method will return the sum of the 2 numbers

            //This Add method adds the word “dollar” at the end of the string
            //if the total is equal to 1 dollar

            if (isTrue == true && sum > 1)
            //This Add method adds the word “dollars” at the end of the string
            //if the total is equal to any other amount
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            //If the boolean parameter is not equal to true:
            //This Add method will just return the sum of the 2 numbers
            else
            {
                return sum.ToString();
            }
        }
    }
}


