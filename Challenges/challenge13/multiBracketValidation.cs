using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.challenge13
{
    class MultiBracketValidation
    {
        public static void Main()
        {
            Stack<string> brackets = new Stack<string>();
            brackets.Push("{");
            brackets.Push("{");
            brackets.Push("{");
            brackets.Push("}");
            brackets.Push("}");
            brackets.Push("}");

            // A stack can be enumerated without disturbing its contents.
            foreach (string bracket in brackets)
            {
                Console.WriteLine(bracket);
            }

            Console.WriteLine("\nPopping '{0}'", brackets.Pop());
            Console.WriteLine("Peek at next item to destack: {0}",
                brackets.Peek());
            Console.WriteLine("Popping '{0}'", brackets.Pop());

            // Create a copy of the stack, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Stack<string> stack2 = new Stack<string>(brackets.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.
            string[] array2 = new string[brackets.Count * 2];
            brackets.CopyTo(array2, brackets.Count);

            // Create a second stack, using the constructor that accepts an
            // IEnumerable(Of T).
            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in stack3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }
    }
}

