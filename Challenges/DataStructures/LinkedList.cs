using System;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Head = new Node(value);
        }



        public bool Include(int valueToFind)
        {
            /*
            Current - Head

            while(Current is null)
            {
                return false;
            }
            else Current.Value == value
            {
                return true;
                Current - Current.Next
            }
            */









            // throw new NotImplementedException();
        }


        public override string ToString()
        {
            // TODO: homework
            return "NULL";
        }
    }
}