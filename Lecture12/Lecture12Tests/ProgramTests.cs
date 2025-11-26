namespace Lecture12.Tests;

using Lecture12;


[TestClass]
public class ProgramTests
{
	[TestMethod]
	public void ReadLinesTest()
	{
		string input = "First line\nSecond line\nThird line\n";
		using TextReader reader = new StringReader(input);

		string[] expected = ["First line", "Second line", "Third line"];
		string[] actual = Program.ReadLines(reader);
		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void ReadLinesTestNoTrailing()
	{
		string input = "First line\nSecond line";
		using TextReader reader = new StringReader(input);

		string[] expected = ["First line", "Second line"];
		string[] actual = Program.ReadLines(reader);
		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void ReadLinesTestEmpty()
	{
		string[] expected = [];
		string[] actual = Program.ReadLines(TextReader.Null);
		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void ReadLinesTestEmptyString()
	{
		using TextReader reader = new StringReader("");

		string[] expected = [];
		string[] actual = Program.ReadLines(reader);
		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void ReadFileTest()
	{
		using (TextWriter writer = new StreamWriter("ReadFileTest.txt")) {
			writer.Write("Line 1\nLine 2\nLine 3\n");
		}

		string[] expected = ["Line 1", "Line 2", "Line 3"];
		string[] actual = Program.ReadFile("ReadFileTest.txt");
		File.Delete("ReadFileTest.txt");

		CollectionAssert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void ReadFileTestNonExisting()
	{
		Assert.ThrowsException<FileNotFoundException>(() => {
			Program.ReadFile("NonExistingFile.txt");
		});
	}


	[TestMethod]
	public void WriteLinesTest()
	{
		string[] lines = ["Line 1", "Line 2", "Line 3"];
		using TextWriter writer = new StringWriter();
		Program.WriteLines(writer, lines);

		string expected = $"Line 1{Environment.NewLine}Line 2{Environment.NewLine}Line 3{Environment.NewLine}";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void WriteLinesTestEmptyArray()
	{
		string[] lines = [];
		using TextWriter writer = new StringWriter();
		Program.WriteLines(writer, lines);

		string expected = "";
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void WriteLinesTestEmptyString()
	{
		string[] lines = [""];
		using TextWriter writer = new StringWriter();
		Program.WriteLines(writer, lines);

		string expected = Environment.NewLine;
		string actual = writer.ToString();
		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void WriteFileTest()
	{
		string[] lines = ["Line 1", "Line 2", "Line 3"];
		Program.WriteFile("WriteFileTest.txt", lines);
		
		
		string expected = $"Line 1{Environment.NewLine}Line 2{Environment.NewLine}Line 3{Environment.NewLine}";
		string actual;
		using (TextReader reader = new StreamReader("WriteFileTest.txt")) {
  			actual = reader.ReadToEnd();
		}
		File.Delete("WriteFileTest.txt");

		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void WriteFileTestExisting()
	{
		using (TextWriter writer = new StreamWriter("WriteFileTestExisting.txt")) {
			writer.Write($"Old line 1{Environment.NewLine}Old line 2{Environment.NewLine}");
		}

		string[] lines = ["Line 1", "Line 2", "Line 3"];
		Program.WriteFile("WriteFileTestExisting.txt", lines);

		string expected = $"Line 1{Environment.NewLine}Line 2{Environment.NewLine}Line 3{Environment.NewLine}";
		string actual;
		using (TextReader reader = new StreamReader("WriteFileTestExisting.txt")) {
			actual = reader.ReadToEnd();
		}
		File.Delete("WriteFileTestExisting.txt");

		Assert.AreEqual(expected, actual);
	}


	[TestMethod]
	public void WriteFileTestAppend()
	{
		using (TextWriter writer = new StreamWriter("WriteFileTestAppend.txt")) {
			writer.Write($"Old line 1{Environment.NewLine}Old line 2{Environment.NewLine}");
		}

		string[] lines = ["Line 1", "Line 2", "Line 3"];
		Program.WriteFile("WriteFileTestAppend.txt", lines, append: true);

		string expected = $"Old line 1{Environment.NewLine}Old line 2{Environment.NewLine}Line 1{Environment.NewLine}Line 2{Environment.NewLine}Line 3{Environment.NewLine}";
		string actual;
		using (TextReader reader = new StreamReader("WriteFileTestAppend.txt")) {
			actual = reader.ReadToEnd();
		}
		File.Delete("WriteFileTestAppend.txt");

		Assert.AreEqual(expected, actual);
	}
}