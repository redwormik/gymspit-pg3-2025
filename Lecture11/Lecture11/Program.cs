namespace Lecture11;


public class Program
{
	public static int Factorial(int n)
	{
		if (n <= 1) { // ukončující podmínka
			return 1;
		}

		return n * Factorial( // volá sám sebe
			n - 1 // s parametrem blíž ukončující podmínce
		);
	}


	public static int FactorialTail(int n, int acc = 1)
	{
		if (n <= 1) { // ukončující podmínka
			return acc;
		}

		// tail pozice - rovnou vracím, nepotřebuju paměť navíc pro volání
		return FactorialTail( // volá sám sebe
			n - 1, // s parametrem blíž ukončující podmínce
			n * acc
		);
	}


	public static long FactorialIterative(long n)
	{
		long result;
		for (result = 1; n > 1; n -= 1) {
			result *= n;
		}
		return result;
	}


	public static double BrickWeight(int precision)
	{
		if (precision <= 0) { // 1) ukončující podmínka
			return 1.0;
		}

		// 2) funkce volá sebe samu
		// 3) se stavem bliším ukončující podmínce
		return 1.0 + BrickWeight(precision - 1) / 2;
	}


	public static int Fibonacci(int n, ref int count, bool debug = false)
	{
		count += 1;

		int id = count;
		if (debug) {
			Console.WriteLine("[{1}] Fibonacci({0}):", n, id);
		}

		if (n <= 0) {
			if (debug) {
				Console.WriteLine("[{2}] Fibonacci({0}) = {1}", n, 0, id);
			}

			return 0;
		}

		if (n == 1) {
			if (debug) {
				Console.WriteLine("[{2}] Fibonacci({0}) = {1}", n, 1, id);
			}

			return 1;
		}

		int result = Fibonacci(n - 1, ref count, debug) + Fibonacci(n - 2, ref count, debug);
		if (debug) {
			Console.WriteLine("[{2}] Fibonacci({0}) = {1}", n, result, id);
		}

		return result;
	}


	public static int FibonacciIterative(int n)
	{
		int result = 0;
		int next = 1;
		for (int i = 1; i <= n; i += 1) {
			int tmp = result + next;
			result = next;
			next = tmp;
		}
		return result;
	}


	private static void Main(string[] args)
	{
		Console.WriteLine("Factorial({0}) = {1}", 0, Factorial(0));
		Console.WriteLine("Factorial({0}) = {1}", 1, Factorial(1));
		Console.WriteLine("Factorial({0}) = {1}", 2, Factorial(2));
		Console.WriteLine("Factorial({0}) = {1}", 3, Factorial(3));
		Console.WriteLine("Factorial({0}) = {1}", 4, Factorial(4));
		Console.WriteLine("Factorial({0}) = {1}", 5, Factorial(5));
		Console.WriteLine("Factorial({0}) = {1}", 12, Factorial(12));
		Console.WriteLine("Factorial({0}) = {1}", 13, Factorial(13)); // integer overflow
		// Console.WriteLine("Factorial({0}) = {1}", 100000, Factorial(100000)); // stack overflow

		Console.WriteLine("FactorialTail({0}) = {1}", 12, FactorialTail(12));
		Console.WriteLine("FactorialTail({0}) = {1}", 13, FactorialTail(13)); // integer overflow
		// Console.WriteLine("FactorialTail({0}) = {1}", 100000, FactorialTail(100000)); // C# neoptimalizuje

		Console.WriteLine("FactorialIterative({0}) = {1}", 12, FactorialIterative(12));
		Console.WriteLine("FactorialIterative({0}) = {1}", 13, FactorialIterative(13));
		Console.WriteLine("FactorialIterative({0}) = {1}", 20, FactorialIterative(20));
		Console.WriteLine("FactorialIterative({0}) = {1}", 21, FactorialIterative(21)); // long overflow
		Console.WriteLine("FactorialIterative({0}) = {1}", 100000, FactorialIterative(100000));

		Console.WriteLine("BrickWeight({0}) = {1}", 0, BrickWeight(0));
		Console.WriteLine("BrickWeight({0}) = {1}", 1, BrickWeight(1));
		Console.WriteLine("BrickWeight({0}) = {1}", 2, BrickWeight(2));
		Console.WriteLine("BrickWeight({0}) = {1}", 4, BrickWeight(4));
		Console.WriteLine("BrickWeight({0}) = {1}", 8, BrickWeight(8));
		Console.WriteLine("BrickWeight({0}) = {1}", 16, BrickWeight(16));
		Console.WriteLine("BrickWeight({0}) = {1}", 32, BrickWeight(32));
		Console.WriteLine("BrickWeight({0}) = {1}", 52, BrickWeight(52));
		Console.WriteLine("BrickWeight({0}) = {1}", 53, BrickWeight(53));
		Console.WriteLine("BrickWeight({0}) = {1}", 100, BrickWeight(100));
		Console.WriteLine("BrickWeight({0}) = {1}", 1000, BrickWeight(1000));

		int count = 0;
		Console.WriteLine("Fibonacci({0}) = {1}", 5, Fibonacci(5, ref count, debug: true));
		Console.WriteLine("count = {0}", count);

		count = 0;
		Console.WriteLine("Fibonacci({0}) = {1}", 10, Fibonacci(10, ref count, debug: true));
		Console.WriteLine("count = {0}", count);

		count = 0;
		Console.WriteLine("Fibonacci({0}) = {1}", 20, Fibonacci(20, ref count));
		Console.WriteLine("count = {0}", count);

		count = 0;
		Console.WriteLine("Fibonacci({0}) = {1}", 30, Fibonacci(30, ref count));
		Console.WriteLine("count = {0}", count);

		Console.WriteLine("FibonacciIterative({0}) = {1}", 30, FibonacciIterative(30));
	}
}
