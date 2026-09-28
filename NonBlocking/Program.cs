internal class Program
{
	private static void Main(string[] args)
	{
		//Run();
	}
	#region Volatile
	/*volatile*/
	//static int i; //bu i değerini data register'dan okuma bellekten oku
	//private static void Run()
	//{
	//	Thread thread1 = new(() =>
	//	{
	//		while (true)
	//			Volatile.Write(ref i, Volatile.Read(ref i) + 1);
	//	});

	//	Thread thread2 = new(() =>
	//	{
	//		while (true)
	//			Console.WriteLine(Volatile.Read(ref i));
	//	});

	//	Thread thread3 = new(() =>
	//	{
	//		while (true)
	//			Volatile.Write(ref i, Volatile.Read(ref i) - 1);
	//	});

	//	thread1.Start();
	//	thread2.Start();
	//	thread3.Start();
	//}
	#endregion
	#region InterLocked Class
	//static int i;	
	//private static void Run()
	//{
	//	var prevValue = Interlocked.Exchange(ref i, 2);
	//	Interlocked.CompareExchange(ref i, 5, 2);
	//	Thread thread1 = new(() =>
	//	{
	//		while (true)
	//			Interlocked.Increment(ref i);
	//	});

	//	Thread thread2 = new(() =>
	//	{
	//		while (true)
	//			Console.WriteLine(i);
	//	});

	//	Thread thread3 = new(() =>
	//	{
	//		while (true)
	//			Interlocked.Decrement(ref i);
	//	});

	//	thread1.Start();
	//	thread2.Start();
	//	thread3.Start();
	//}
	#endregion
	#region MemoryBarrier Method
	//static int i;
	//private static void Run()
	//{
	//	Thread writeThread = new(() =>
	//	{
	//		while (true)
	//		{
	//			Interlocked.Increment(ref i); //Atomik bir davranış ile i değeri üzerindeki işlem yapılır.
	//			Thread.MemoryBarrier(); //Ardından yapılan işlemin güncel durumu diğer threadler'e gönderilir, diğerleri uyarılır.
	//		}				
	//	});

	//	Thread readThread = new(() =>
	//	{
	//		while (true){
	//			Thread.MemoryBarrier(); //Güncel i değerini al
	//			Console.WriteLine(i);
	//		}
	//	});

	//	writeThread.Start();
	//	readThread.Start();
	//}
	#endregion
}