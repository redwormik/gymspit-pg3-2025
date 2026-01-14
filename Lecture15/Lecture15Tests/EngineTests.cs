namespace Lecture15.Tests;

using Lecture15;


[TestClass]
public class EngineTests
{
	[TestMethod]
	public void RunTest()
	{
		Engine engine = new Engine(100, 5.0 / 100); // 10 km/h, 5 l/100 km
		GasTank tank = new GasTank(50);
		tank.Add(20);

		double time = engine.Run(100, tank); // 100 km
		Assert.AreEqual(1, time, 1e-6); // 1 hour
		Assert.AreEqual(15, tank.Amount, 1e-6); // 20 - 5

		Assert.ThrowsException<ArgumentException>(() => engine.Run(400, tank)); // needs 20 l
	}
}