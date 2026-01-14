namespace Lecture15.Tests;

using Lecture15;


[TestClass]
public class GasTankTests
{
	[TestMethod]
	public void GasTankTest()
	{
		GasTank tank = new GasTank(50);
		Assert.AreEqual(0, tank.Amount);
	}


	[TestMethod]
	public void AddTest()
	{
		GasTank tank = new GasTank(50);
		tank.Add(20);
		Assert.AreEqual(20, tank.Amount);
		tank.Add(25);
		Assert.AreEqual(45, tank.Amount);
		Assert.ThrowsException<ArgumentException>(() => tank.Add(10));
	}


	[TestMethod]
	public void UseTest()
	{
		GasTank tank = new GasTank(50);
		tank.Add(40);
		tank.Use(15);
		Assert.AreEqual(25, tank.Amount);
		tank.Use(20);
		Assert.AreEqual(5, tank.Amount);
		Assert.ThrowsException<ArgumentException>(() => tank.Use(10));
	}
}