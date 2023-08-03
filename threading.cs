using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// create a new thread
		Thread t = new Thread(Worker);

		// start the thread
		t.Start();

		// do some other work in the main thread
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Main thread doing some work");
			Thread.Sleep(100);
		}

		// wait for the worker thread to complete
		t.Join();

		Console.WriteLine("Done");
	}

	static void Worker()
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Worker thread doing some work");
			Thread.Sleep(100);
		}
	}
}
