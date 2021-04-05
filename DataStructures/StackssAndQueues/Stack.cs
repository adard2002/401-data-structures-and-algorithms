using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackssAndQueues
{
    class Stack
    {


        // Creating a stack



        Stack<string> myStack = new Stack<string>();
        myStack.Push("Billy");
        myStack.Push("Bob");
        myStack.Push("Joe");

            Console.WriteLine("Stack of names:");



        foreach(string item in myStack)
            {
                Console.WriteLine(item);
            }



    }
}
