using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture13;
namespace Lecture13.Tests;


[TestClass]
public class ProgramTests
{
	[TestMethod]
	public void InputTestSuccess()
	{
		TextReader reader = new StringReader("10\n20\n");
		bool result = Program.Input(reader, out int a, out int b);
		Assert.IsTrue(result);
		Assert.AreEqual(10, a);
		Assert.AreEqual(20, b);
	}


	[TestMethod]
	public void InputTestFailure()
	{
		TextReader reader = new StringReader("abc\n20\n");
		bool result = Program.Input(reader, out int a, out int b);
		Assert.IsFalse(result);
		Assert.AreEqual(0, a);
		Assert.AreEqual(0, b);
	}


	[TestMethod]
	public void InputLoopTestSuccess()
	{
		TextReader reader = new StringReader("10\n20\n");
		Program.InputLoop(reader, out int a, out int b);
		Assert.AreEqual(10, a);
		Assert.AreEqual(20, b);
	}


	[TestMethod]
	public void InputLoopTestRetry()
	{
		TextReader reader = new StringReader("1\nb\n42\n24\n");
		Program.InputLoop(reader, out int a, out int b);
		Assert.AreEqual(42, a);
		Assert.AreEqual(24, b);
	}


	[TestMethod]
	public void InputLoopTestFailure()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			TextReader reader = new StringReader("1\nb\n42\n"); ;
			Program.InputLoop(reader, out int a, out int b);
		});
	}


	[TestMethod()]
	public void ComputeTestSuccess()
	{
		int result = Program.Compute(20, 4);
		Assert.AreEqual(5, result);
	}


	[TestMethod()]
	public void ComputeTestDivisionByZero()
	{
		int result = Program.Compute(20, 0);
		Assert.AreEqual(0, result);
	}


	[TestMethod()]
	public void ComputeTestDivisionByOne()
	{
		ArgumentException e = Assert.ThrowsException<ArgumentException>(() =>
		{
			Program.Compute(20, 1);
		});
		Assert.AreEqual("Why do you divide by one?", e.Message);
	}


	[TestMethod]
	public void D6Test()
	{
		Random rnd = new Random(0); // fixed seed for reproducibility
		int result = Program.D6(0, rnd); // 5
		Assert.AreEqual(5, result);

		Assert.ThrowsException<CustomException>(() => {
			Program.D6(5, rnd);  // 5
		});

		Assert.ThrowsException<CustomException>(() => {
			Program.D6(5, rnd); // 5
		});

		result = Program.D6(5, rnd); // 4
		Assert.AreEqual(4, result);
	}


	[TestMethod]
	public void CastDiceTest()
	{
		Random rnd = new Random(0); // fixed seed for reproducibility

		Assert.ThrowsException<CustomException>(() => {
			Program.CastDice(2, rnd); // 5, 5
		});

		int result = Program.CastDice(5, rnd); // 5, 4, 2, 4, 6
		Assert.AreEqual(21, result);
	}


	[TestMethod]
	public void CastDiceTestBust()
	{
		Random rnd = new Random(0); // fixed seed for reproducibility

		Assert.ThrowsException<CustomException>(() => {
			Program.CastDice(3, rnd); // 5, 5
		});

		int result = Program.CastDice(6, rnd); // 5, 4, 2, 4, 6, 3
		Assert.AreEqual(-1, result);
	}
}