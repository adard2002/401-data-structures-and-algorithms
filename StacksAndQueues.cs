using System;

public class StacksAndQueues
{
	public StacksAndQueues()
	{

		interface IStack<T>
		{
			void Push(T value);
			T Pop();
			T Peek();
			bool IsEmpty { get; }
		}



		interface IQueue<T>
		{
			void Enqueue(T value);
			T Dequeue();
			T Peek();
			bool IsEmpty { get; }
		}




	}
}
