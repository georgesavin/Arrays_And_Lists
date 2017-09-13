using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_And_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			// I like this declaration for arrays, calling it int[] and the new it of length 5 at the end makes it easy to give it a length
			int[] numbers = new int[5];

			numbers[0] = 4;
			numbers[1] = 8;
			numbers[2] = 15;
			numbers[3] = 16;
			numbers[4] = 23;
			//numbers[5] = 42;

			Console.WriteLine(numbers.Length);

			/* Set notation for all of numbers in array.
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            String array for strings, makes it easier to see what type of array it is.
            string[] names = new string[] { "Eddie", "Alex", "Micheal", "David Lee" };

            foreach (string name in names) //Much easier than looping through the array with Array.length();
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            
            string zig = "You can get what you want out of life " + 
                "if you help enough other people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
                Console.Write(zigChar);
            */

			Console.ReadLine();

		}
	}
}