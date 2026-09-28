internal class Program
{
	private static void Main(string[] args)
	{		
		#region SpingLock
		//int value = 0;
		//SpinLock spinLock = new SpinLock();
		//Thread thread1 = new(() =>
		//{
		//	try
		//	{
		//		bool lockTaken = false;
		//		spinLock.Enter(ref lockTaken);
		//		if (lockTaken)
		//		{
		//			for (int i = 0; i < 999; i++)
		//				Console.WriteLine("Thread1 Value :" + (value++));
		//		}
		//	}
		//	finally
		//	{
		//		spinLock.Exit();
		//	}
		//});

		//Thread thread2 = new(() =>
		//{
		//	try
		//	{
		//		bool lockTaken = false;
		//		spinLock.Enter(ref lockTaken);
		//		if (lockTaken)
		//		{
		//			for (int i = 0; i < 999; i++)
		//				Console.WriteLine("Thread2 Value :" + (value++));
		//		}
		//	}
		//	finally
		//	{
		//		spinLock.Exit();
		//	}
		//});

		//thread1.Start();
		//thread2.Start();
		#endregion

		#region SpingWait
		Thread thread1 = new(() =>
		{
			bool wait = false, condition = true;
			while (true)
			{
				if (!wait)
					continue;

				if (!condition)
					continue;

				Console.WriteLine("Thread 1 is processing...");
			}
		});

		Thread thread2 = new(() =>
		{
			bool wait = false, condition = true;
			while (true)
			{
				SpinWait.SpinUntil(() =>
				{
					Thread.MemoryBarrier();
					return !condition || wait;
				});

				Console.WriteLine("Thread 2 is processing...");
			}
		});

		thread1.Start();
		thread2.Start();
		#endregion
	}
}