namespace Lecture12;


public class Program
{
	public static string[] ReadLines(TextReader reader)
	{
		string[] lines = new string[10];
		int count = 0;
		string line;

		// null - chybějící objekt
		// když ReadLine vratí null, znamená to konec vstupu
		while ((line = reader.ReadLine()) != null) {
			if (count >= lines.Length) {
				Array.Resize(ref lines, lines.Length * 2);
			}
			lines[count] = line;
			count += 1;
		}

		Array.Resize(ref lines, count);
		return lines;
	}


	public static string[] ReadFile(string fileName)
	{
		using (TextReader reader = new StreamReader(fileName)) {
			return ReadLines(reader);
		}
	}


	public static void WriteLines(TextWriter writer, string[] lines)
	{
		foreach (string line in lines) {
			writer.WriteLine(line);
		}
	}


	public static void WriteFile(string fileName, string[] lines, bool append = false)
	{
		// druhý parametr StreamWriter - přepsat soubor (false, výchozí), nebo psát na konec (true)
		using (TextWriter writer = new StreamWriter(fileName, append: append)) {
			WriteLines(writer, lines);
		}
	}


	private static void Main(string[] args)
	{
		string baseDir = @"..\..\..\";

		// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement

		// https://learn.microsoft.com/en-us/dotnet/api/system.io.textwriter
		// https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter
		using (TextWriter writer = new StreamWriter(baseDir + "hello.txt")) {
			writer.Write("Hello, ");
			writer.WriteLine("world!");
		}
		// writer.WriteLine(); nelze - writer není vidět

		// https://learn.microsoft.com/en-us/dotnet/api/system.io.textwriter
		// https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader
		using (TextReader reader = new StreamReader(baseDir + "hello.txt")) {
			Console.WriteLine(reader.ReadLine());
		}

		// using je přibližně:
		{
			TextWriter writer = new StreamWriter(baseDir + "lorem.txt");
			try {
				writer.WriteLine("Lorem ipsum");
				writer.WriteLine("Dolor sit amet");
			} finally {
				if (writer != null) {
					writer.Dispose(); // zavře Writer, zapíše na disk
				}
			}
			// writer.WriteLine("Foo"); // nelze - writer je zavřený
		}

		// Vytvoří soubor, pokud neexistuje
		using (TextWriter writer = new StreamWriter(baseDir + "lines.txt", append: true)) {
		}

		string[] fileLines = ReadFile(baseDir + "lines.txt");
		WriteLines(Console.Out, fileLines);

		Console.WriteLine("Enter text lines, enter Ctrl + Z to end:");
		string[] consoleLines = ReadLines(Console.In);
		WriteFile(baseDir + "lines.txt", consoleLines);
		WriteFile(baseDir + "linesAll.txt", consoleLines, append: true);
	}
}
