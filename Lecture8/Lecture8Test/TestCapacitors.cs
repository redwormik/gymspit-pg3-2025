namespace Lecture8Test;

using Lecture8;


[TestClass]
public class TestCapacitors
{
	[TestMethod]
	public void TestSerialCapacitors()
	{
		double result = Program.SerialCapacitors([0.2E-6, 0.4E-6]);

		Assert.AreEqual((double) 4/30*1E-6, result);
	}


	[TestMethod]
	public void TestParallelCapacitors()
	{
		double result = Program.ParallelCapacitors([0.2E-6, 0.4E-6]);

		Assert.AreEqual((double) 0.6E-6, result);
	}


	[TestMethod]
	public void TestTwoPlusTwoCapacitors()
	{
		double result = Program.SerialCapacitors([
			Program.ParallelCapacitors([0.2E-6, 0.1E-6]),
			Program.ParallelCapacitors([0.3E-6, 0.4E-6]),
		]);

		Assert.AreEqual(0.21E-6, result);
	}
}
