// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
// https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-9.0

static void StringLiterals()
{
	string regular = "This is a string in double quotes.\nBackslashes (\\) have \"special\" meaning";
	string concatenated = "I cannot write multiple line string literal," + "\n" +
		"but I can concat the string!";
	string verbatim = @"This is a verbatim literal. Backslashes (\) have no special meaning. Double the ""quotes"" to escape them.
		It can have multiple lines, but the indents count.";
	string rawSingleLine = """This is a single-line "raw string literal".""";
	string rawMultiLine = """
		This is a multi-line "raw string literal".
		It can span multiple lines without needing to escape quotes or backslashes.
			It also preserves indentation (but removes whitespace left of the closing quotes) and line breaks exactly as written.
		""";

	string formatted = String.Format("String.Format function works like {0}. It formats string with {1} or more arguments (like {0}).", "Console.WriteLine", 1);

	Console.WriteLine(regular);
	Console.WriteLine(concatenated);
	Console.WriteLine(verbatim);
	Console.WriteLine(formatted);
	Console.WriteLine(rawSingleLine);
	Console.WriteLine(rawMultiLine);
	Console.WriteLine();
}

static void StringArrayConversion()
{
	char[] charArray = ['f', 'r', 'o', 'm', ' ', 'a', 'n', ' ', 'a', 'r', 'r', 'a', 'y'];
	string fromArray = new string(charArray);
	Console.WriteLine(fromArray);

	char[] backToArray = fromArray.ToCharArray();
	foreach (char c in backToArray) {
		Console.WriteLine(c);
	}
}

static void StringCaseChange(string str)
{
	Console.WriteLine(str.ToUpper());
	Console.WriteLine(str.ToLower());
	Console.WriteLine();
}

static void StringComparison(string str, string strLess, string strMore)
{
	Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str, str.CompareTo(str));
	Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str.ToLower(), str.CompareTo(str.ToLower()));
	Console.WriteLine("str.CompareTo(\"{0}\") = {1}", strLess, str.CompareTo(strLess));
	Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str.ToUpper(), str.CompareTo(str.ToUpper()));
	Console.WriteLine("str.CompareTo(\"{0}\") = {1}", strMore, str.CompareTo(strMore));
	Console.WriteLine();
}

static void StringSearch(string str, string needle)
{
	Console.WriteLine("str.Contains(\"{0}\") = {1}", needle, str.Contains(needle));
	Console.WriteLine("str.IndexOf(\"{0}\") = {1}", needle, str.IndexOf(needle));
	Console.WriteLine("str.LastIndexOf(\"{0}\") = {1}", needle, str.LastIndexOf(needle));
	Console.WriteLine();
}

static void StringSplit(string str)
{
	string[] words = str.Split(' ');
	foreach (string word in words) {
		Console.WriteLine(word);
	}
	Console.WriteLine();
}

static void StringJoin(string[] words)
{
	Console.WriteLine(String.Join(", ", words));
	Console.WriteLine();
}

static void StringIndexing(string str)
{
	for (int i = 0; i < str.Length; i += 1) {
		Console.WriteLine("str[{0}] = '{1}'", i, str[i]);
		// str[i] = 'x'; // does not compile
	}
	Console.WriteLine();
}

static string BuildString(string str)
{
	// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline?view=net-9.0
	System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(str);

	Console.WriteLine(strBuilder);

	for (int i = 1; i < strBuilder.Length; i += 2) {
		strBuilder[i] = '*'; // does compile
	}
	strBuilder[^1] = '@'; // strBuilder[strBuilder.Length - 1] = '@';
	strBuilder[^3] = '#'; // strBuilder[strBuilder.Length - 3] = '#';
	Console.WriteLine(strBuilder);

	strBuilder.Remove(strBuilder.Length / 2, 10);
	Console.WriteLine(strBuilder);

	strBuilder.Insert(strBuilder.Length / 3, "<insert>");
	Console.WriteLine(strBuilder);

	strBuilder.Append("..");

	return strBuilder.ToString();
}

static void TypeCasting()
{
	int two = 2;
	double number = two; // can do
	double pi = Math.PI;
	// int engineeringPi = pi; // cannot do
	int engineeringPi = (int) pi; // can do, but i lose information
	Console.WriteLine("{0} {1} {2} {3}", two, number, pi, engineeringPi);

	int i = 'A'; // can do
	// char c = 42; // cannot do
	char c = (char) 42; // can do
	Console.WriteLine("{0} {1}", i, c);

	// https://en.wikipedia.org/wiki/List_of_Unicode_characters#Basic_Latin
	Console.WriteLine("Type-casting chars to ints: {0} {1} {2} {3}", (int) 'A', (int) 'Z', (int) 'a', (int) 'z');
	Console.WriteLine("Type-casting ints to chars: {0} {1} {2} {3}", (char) 0x41, (char) 0x5a, (char) 0x61, (char) 0x7a);
	Console.WriteLine("Type-casting ints to chars: {0} {1} {2} {3}", (char) 0xc1, (char) 0xfd, (char) 0x160, (char) 0x17e);
	Console.WriteLine();
}

StringLiterals();
StringArrayConversion();

string str = "This is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy.";
string strLess = "that is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy.";
string strMore = "This is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy..";

StringCaseChange(str);
StringComparison(str, strLess, strMore);
StringSearch(str, "kůň");
StringSearch(str, "KŮŇ");
StringSearch(str, " ");
StringSplit(str);
StringJoin(["list", "of", "words"]);
// see documentation for more String methods

StringIndexing("this is a text");
Console.WriteLine(BuildString(str));

TypeCasting();