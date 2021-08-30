using System;
using System.Collections.Generic;
namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
			Queue<int> dq = new Queue<int>();
			dq.Enqueue(10);
			dq.Enqueue(23);
			dq.Enqueue(16);
			dq.Enqueue(5);
			dq.Enqueue(29);

			
			Console.WriteLine("The contents of Queue<int>: ");
			foreach (int element in dq)
				Console.WriteLine(element);


			//Calling the Dequeue() 
			Console.WriteLine("Removing the front element = " + dq.Dequeue());
			Console.WriteLine("Removing the next front element = " + dq.Dequeue());


			//Calling the Peek() 
			Console.WriteLine("Peeking at the current front element = " + dq.Peek());


			//Printing the updated contents 
			Console.WriteLine("Updated contents of Queue<int>: ");
			foreach (int element in dq)
				Console.WriteLine(element);
		}
    }
}
