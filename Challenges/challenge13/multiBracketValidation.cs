using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.challenge13
{
    class MultiBracketValidation
    {
        public static bool Main()
        {
            Stack<string> brackets = new Stack<string>();
            brackets.Push("{");
            brackets.Push("{");
            brackets.Push("{");
            brackets.Push("}");
            brackets.Push("}");
            brackets.Push("}");

            foreach (string bracket in brackets)
            {
                Console.WriteLine(bracket);
            }

            Console.WriteLine("\nPopping '{0}'", brackets.Pop());
            Console.WriteLine("Peek at next item to destack: {0}",
                brackets.Peek());
            Console.WriteLine("Popping '{0}'", brackets.Pop());
        }
        return TRUE;
    }
}

