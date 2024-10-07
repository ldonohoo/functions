using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace functions 
{
    public class Program
    {
        static void Main(string[] args)
        {
           var number = int.TryParse("123", out int result);

           var shoppingList = new List<string> { "Coffee", "Milk"};


           int index = -1;
           for (int i = 0; i< shoppingList.Count; i++)
           {
            if (shoppingList[i].ToLower().Equals("milk"))
            {
                index = i;
            }

           }
           float width = Convert.ToInt64(Console.ReadLine());
           float height = Convert.ToInt64(Console.ReadLine());
           
           Console.WriteLine($"Area: {AreaOfTriangle(10, 20 )}");
           var numbers = new List<int> { 1, 2, 3, 4, 5, 6};
           if (SumOfArray(numbers, out int sum)) {
                Console.WriteLine($"Sum is: {sum}");
           } else 
           {
            System.Console.WriteLine("Empty array!");
           }

        }
        static float AreaOfTriangle(float width, float height)
        {
            return 0.5F *(width * height);
        }
        static bool SumOfArray(List<int> numbers, out int arraySum) 
        {
            arraySum = 0;
            if (numbers.Count == 0) {
                return false;
            }
            foreach( int num in numbers) 
            {
                arraySum += num;
            };
            return true;
        }
    }
}
