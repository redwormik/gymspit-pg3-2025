using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture11;

namespace Lecture11.Tests;

using Lecture11;


[TestClass]
public class ProgramTests
{
	[TestMethod]
	public void FactorialTest()
	{
		Assert.AreEqual(1, Program.Factorial(0));
		Assert.AreEqual(1, Program.Factorial(1));
		Assert.AreEqual(2, Program.Factorial(2));
		Assert.AreEqual(6, Program.Factorial(3));
		Assert.AreEqual(24, Program.Factorial(4));
		Assert.AreEqual(120, Program.Factorial(5));
		Assert.AreEqual(479001600, Program.Factorial(12));
	}


	[TestMethod]
	public void FactorialTailTest()
	{
		Assert.AreEqual(1, Program.FactorialTail(0));
		Assert.AreEqual(1, Program.FactorialTail(1));
		Assert.AreEqual(2, Program.FactorialTail(2));
		Assert.AreEqual(6, Program.FactorialTail(3));
		Assert.AreEqual(24, Program.FactorialTail(4));
		Assert.AreEqual(120, Program.FactorialTail(5));
		Assert.AreEqual(479001600, Program.FactorialTail(12));
	}


	[TestMethod]
	public void FactorialIterativeTest()
	{
		Assert.AreEqual(1, Program.FactorialIterative(0));
		Assert.AreEqual(1, Program.FactorialIterative(1));
		Assert.AreEqual(2, Program.FactorialIterative(2));
		Assert.AreEqual(6, Program.FactorialIterative(3));
		Assert.AreEqual(24, Program.FactorialIterative(4));
		Assert.AreEqual(120, Program.FactorialIterative(5));
		Assert.AreEqual(479001600, Program.FactorialIterative(12));
		Assert.AreEqual(6227020800, Program.FactorialIterative(13));
		Assert.AreEqual(2432902008176640000, Program.FactorialIterative(20));
		Program.FactorialIterative(100000);
	}


	[TestMethod]
	public void BrickWeightTest()
	{
		Assert.AreEqual(1.0, Program.BrickWeight(0), 1e-10);
		Assert.AreEqual(1.5, Program.BrickWeight(1), 1e-10);
		Assert.AreEqual(1.75, Program.BrickWeight(2), 1e-10);
		Assert.AreEqual(1.875, Program.BrickWeight(3), 1e-10);
		Assert.AreEqual(1.9375, Program.BrickWeight(4), 1e-10);
		Assert.AreEqual(2.0, Program.BrickWeight(40), 1e-10);
	}



	[TestMethod]
	public void FibonacciTest()
	{
		int count = 0;
		Assert.AreEqual(0, Program.Fibonacci(0, ref	count));
		count = 0;
		Assert.AreEqual(1, Program.Fibonacci(1, ref count));
		count = 0;
		Assert.AreEqual(1, Program.Fibonacci(2, ref count));
		count = 0;
		Assert.AreEqual(2, Program.Fibonacci(3, ref count));
		count = 0;
		Assert.AreEqual(3, Program.Fibonacci(4, ref count));
		count = 0;
		Assert.AreEqual(5, Program.Fibonacci(5, ref count));
		count = 0;
		Assert.AreEqual(8, Program.Fibonacci(6, ref count));
		count = 0;
		Assert.AreEqual(13, Program.Fibonacci(7, ref count));
		count = 0;
		Assert.AreEqual(21, Program.Fibonacci(8, ref count));
		count = 0;
		Assert.AreEqual(34, Program.Fibonacci(9, ref count));
		count = 0;
		Assert.AreEqual(55, Program.Fibonacci(10, ref count));
		count = 0;
		Assert.AreEqual(6765, Program.Fibonacci(20, ref count));
		count = 0;
		Assert.AreEqual(832040, Program.Fibonacci(30, ref count));
	}



	[TestMethod]
	public void FibonacciIterativeTest()
	{
		Assert.AreEqual(0, Program.FibonacciIterative(0));
		Assert.AreEqual(1, Program.FibonacciIterative(1));
		Assert.AreEqual(1, Program.FibonacciIterative(2));
		Assert.AreEqual(2, Program.FibonacciIterative(3));
		Assert.AreEqual(3, Program.FibonacciIterative(4));
		Assert.AreEqual(5, Program.FibonacciIterative(5));
		Assert.AreEqual(8, Program.FibonacciIterative(6));
		Assert.AreEqual(13, Program.FibonacciIterative(7));
		Assert.AreEqual(21, Program.FibonacciIterative(8));
		Assert.AreEqual(34, Program.FibonacciIterative(9));
		Assert.AreEqual(55, Program.FibonacciIterative(10));
		Assert.AreEqual(6765, Program.FibonacciIterative(20));
		Assert.AreEqual(832040, Program.FibonacciIterative(30));
	}
}
