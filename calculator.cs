class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;

		Console.WriteLine("Penambahan", a,b, Penambahan(a,b));
		Console.WriteLine("Pengurangan", a,b Pengurangan(a,b));

		Console.WriteLine("\n Press any key");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}

}
