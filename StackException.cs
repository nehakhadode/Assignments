using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4thAssignment
{
	internal class StackException
	{


		readonly int MAX = 1000;
		int top;
		int[] stack = new int[1000];

		public StackException()
		{
			top = -1;
		}
		public bool Push(int data)
		{
			if (top + 1 >= MAX)
			{
				Console.WriteLine("Stack is Full");
				return false;
			}
			else
			{
				stack[++top] = data;
				return true;
			}
		}

		public int Pop()
		{
			if (top < 0)
			{
				Console.WriteLine("Stack is Empty");
				return 0;
			}
			else
			{
				int value = stack[top--];
				return value;
			}
		}



		public void PrintStack()
		{
			if (top < 0)
			{
				Console.WriteLine("Stack is empty");
				return;
			}
			else
			{
				Console.WriteLine("Stack  Items are :");
				for (int i = top; i >= 0; i--)
				{
					Console.WriteLine(stack[i]);
				}
			}
		}

		static void Main(string[] args)
		{
			StackException se = new StackException();

			se.Push(21);
			se.Push(56);
			se.Push(49);
			se.Push(34);
			se.Push(92);
			se.Push(75);
			se.PrintStack();
			Console.WriteLine("Item popped from Stack : {0}", se.Pop());
			se.PrintStack();
			Console.ReadKey();
		}
	}
}
