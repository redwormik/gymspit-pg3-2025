namespace Lecture17.Tests;

using Lecture17;


[TestClass]
public class EngineTests
{
	[TestMethod]
	public void RunTest()
	{
		Engine engine = new Engine(100, 3.0 / 100); // 10 km/h, 3 l/100 km
		GasTank tank = new GasTank(50);
		Car car = new Car(engine, tank); // 2 l/100 km
		tank.Add(20);

		double time = engine.Run(car, 100, tank); // 100 km
		Assert.AreEqual(1, time, 1e-6); // 1 hour
		Assert.AreEqual(15, tank.Amount, 1e-6); // 20 - 5

		Assert.ThrowsException<ArgumentException>(() => engine.Run(car, 400, tank)); // needs 20 l
	}
}