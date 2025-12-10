namespace Lecture13;

// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
// https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-10.0


public class Program
{
	public static bool Input(TextReader reader, out int a, out int b)
	{
		string input = "";

		try {
			Console.Write("Enter a: ");
			a = int.Parse(input = reader.ReadLine());
			Console.Write("Enter b: ");
			b = int.Parse(input = reader.ReadLine());
		} catch (FormatException) {
			Console.WriteLine("Invalid input: {0}", input);

			a = 0;
			b = 0;
			return false;
		}

		// pokud se program dostane sem, tak se čtení podařilo
		return true;
	}


	public static void InputLoop(TextReader reader, out int a, out int b)
	{
		bool success;

		do {
			success = Input(reader, out a, out b);
		} while (!success);
	}


	private static int Div(int a, int b)
	{
		if (b == 1) {
			throw new ArgumentException("Why do you divide by one?");
		}

		return a / b;
	}


	public static int Compute(int a, int b)
	{
		int result;
	
		try {
			result = Div(a, b);
		} catch (DivideByZeroException e) {
			Console.WriteLine("Cannot divide by zero!");
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
			return 0;
		} catch (Exception) {
			Console.WriteLine("Another exception happened!");
			throw;
		} finally {
			Console.WriteLine("Finally, it's over!");
		}

		return result;
	}


	public static int D6(int last, Random rnd)
	{
		int result = rnd.Next(1, 7);
		Console.WriteLine("D6: {0}", result);
		if (result == last) {
			throw new CustomException("Go to jail!");
		}
		return result;
	}



	public static int CastDice(int diceCount, Random rnd)
	{
		int sum = 0;
		int last = 0;

		try {
			for (int i = 0; i < diceCount; i += 1) {
				last = D6(last, rnd);
				sum += last;

				if (sum > 21) {
					Console.WriteLine("Bust!");
					return -1;
				}
			}
		} finally {
			Console.WriteLine("Good luck next time!");
		}

		return sum;
	}


	private static void Game(int diceCount, Random rnd)
	{
		try {
			int result = CastDice(diceCount, rnd);
			Console.WriteLine("Your result: {0}", result);
		} catch (CustomException e) {
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
	}


	private static void Main(string[] args)
	{
		InputLoop(Console.In, out int a, out int b);
		Console.WriteLine("a = {0}, b = {1}", a, b);

		try {
			int result = Compute(a, b);
			Console.WriteLine("{0} / {1} = {2}", a, b, result);
		} catch (Exception e) {
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}

		Random rnd = new Random();
		int diceCount;
		do {
			bool success = false;
			do {
				Console.Write("Enter number of dice to cast (0 to exit): ");
				success = int.TryParse(Console.ReadLine(), out diceCount);
				if (!success) {
					Console.WriteLine("Invalid input, please enter a number.");
				}
			} while (!success);

			Game(diceCount, rnd);
		} while (diceCount > 0);
	}
}
